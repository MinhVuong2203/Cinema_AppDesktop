using BLL;
using DAL;
using DTO;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace UI.Employee
{
    public partial class OperationUC : UserControl
    {
        private readonly EmployeeBLL _employeeBLL = new EmployeeBLL();
        private readonly OperationBLL _operationBLL = new OperationBLL();

        private Bitmap _bmpChecked;
        private Bitmap _bmpUnchecked;

        private readonly Dictionary<int, int> _opIdToColIndex = new Dictionary<int, int>();
        private readonly Dictionary<Guid, HashSet<int>> _employeeOpIds = new Dictionary<Guid, HashSet<int>>();

        //List<DTO.Employee> employees = new List<DTO.Employee>();

        public OperationUC()
        {
            InitializeComponent();
            LoadCboRoles();
            // load khi UC được show
            this.Load += OperationUC_Load;

            InitPermissionGrid();
        }

        public void LoadCboRoles()
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("-- Tất cả --");
            RoleDAL roleDAL = new RoleDAL();
            var roles = roleDAL.GetAllRoles();
            foreach (var role in roles)
            {
                cboRole.Items.Add(role.RoleName);
            }
            cboRole.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định
        }

        private void OperationUC_Load(object sender, EventArgs e)
        {
            var employees = _employeeBLL.GetAllEmployees();
            var operations = _operationBLL.GetAllOperation();   // lấy danh sách Operation

            LoadPermissionTable(employees, operations);
        }


        private void Load_OperationUC()
        {
            string nameFilter = txtSearch.Text.Trim();
            string roleFilter = cboRole.SelectedItem?.ToString();
            // Lấy dữ liệu thật từ DB
            var employees = _employeeBLL.FilterEmployees(
            nameFilter,
            string.IsNullOrWhiteSpace(roleFilter) || roleFilter == "-- Tất cả --"
                ? null
                : roleFilter,
            includeDeleted: false);
            //var employees = _employeeBLL.FilterEmployees(this.txtSearch.Text, this.cboRole.Text);      // đã Include Operations
            var operations = _operationBLL.GetAllOperation();   // lấy danh sách Operation

            // Render lên bảng
            LoadPermissionTable(employees, operations);
        }



        private void InitPermissionGrid()
        {
            dgvPermissions.AutoGenerateColumns = false;
            dgvPermissions.Dock = DockStyle.Fill;

            dgvPermissions.AllowUserToAddRows = false;
            dgvPermissions.AllowUserToDeleteRows = false;
            dgvPermissions.AllowUserToResizeRows = false;
            dgvPermissions.RowHeadersVisible = false;

            // FULL WIDTH: cột tự fill hết chiều ngang
            //dgvPermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermissions.ScrollBars = ScrollBars.Both;
            // Font to hơn
            dgvPermissions.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dgvPermissions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            // Header / row cao hơn
            dgvPermissions.ColumnHeadersHeight = 44;
            dgvPermissions.RowTemplate.Height = 42;

            

            // Style header xanh
            dgvPermissions.EnableHeadersVisualStyles = false;
            dgvPermissions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 115, 217);
            dgvPermissions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPermissions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Style dòng
            dgvPermissions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(184, 227, 196);
            dgvPermissions.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 40, 50);
            dgvPermissions.GridColor = Color.FromArgb(235, 239, 245);
            dgvPermissions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPermissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermissions.MultiSelect = false;

            // Click để toggle nên để readonly
            dgvPermissions.ReadOnly = true;

            dgvPermissions.CellClick -= DgvPermissions_CellClick;
            dgvPermissions.CellClick += DgvPermissions_CellClick;

            // Checkbox bitmap (đẹp + chắc chắn có dấu tick)
            _bmpChecked = CreateThemedCheckBitmap(true, 20);
            _bmpUnchecked = CreateThemedCheckBitmap(false, 20);
        }


    public void LoadPermissionTable(List<DTO.Employee> employees, List<DTO.Operation> operations)
        {
            if (employees == null) employees = new List<DTO.Employee>();
            if (operations == null) operations = new List<DTO.Operation>();

            BuildColumns(operations);
            BuildRows(employees, operations);
        }

        private void BuildColumns(List<DTO.Operation> operations)
        {
            dgvPermissions.DataSource = null;      // đảm bảo không bị bind gây null value
            dgvPermissions.Columns.Clear();
            _opIdToColIndex.Clear();

            dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmployeeId",
                Visible = false
            });

            dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Nhân viên",
                MinimumWidth = 220
            });

            dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRole",
                HeaderText = "Chức vụ",
                MinimumWidth = 160
            });

            foreach (var op in operations)
            {
                var col = new DataGridViewImageColumn
                {
                    Name = $"op_{op.OperationId}",
                    HeaderText = op.OperationName, // hoặc OperationCode
                    MinimumWidth = 120,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Tag = op.OperationId
                };

                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.NullValue = _bmpUnchecked; // <-- FIX X đỏ

                dgvPermissions.Columns.Add(col);
                _opIdToColIndex[op.OperationId] = dgvPermissions.Columns.Count - 1;
            }
        }


        private void BuildRows(List<DTO.Employee> employees, List<DTO.Operation> operations)
        {
            dgvPermissions.Rows.Clear();
            _employeeOpIds.Clear();

            foreach (var emp in employees)
            {
                var assigned = new HashSet<int>(
                    (emp.Operations ?? new List<DTO.Operation>()).Select(x => x.OperationId)
                );

                _employeeOpIds[emp.EmployeeID] = assigned;

                int r = dgvPermissions.Rows.Add();
                var row = dgvPermissions.Rows[r];

                row.Cells["colEmployeeId"].Value = emp.EmployeeID;
                row.Cells["colFullName"].Value = emp.FullName;
                row.Cells["colRole"].Value = emp.Role != null ? emp.Role.RoleName : "";

                foreach (var op in operations)
                {
                    if (_opIdToColIndex.TryGetValue(op.OperationId, out int c))
                    {
                        row.Cells[c].Value = assigned.Contains(op.OperationId) ? _bmpChecked : _bmpUnchecked;
                    }
                    else
                    {
                        // Nếu thiếu cột mapping thì bỏ qua để không crash
                        System.Diagnostics.Debug.WriteLine($"Missing column mapping for OperationId={op.OperationId}");
                    }

                }
            }
        }

        private void DgvPermissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvPermissions.Columns[e.ColumnIndex] as DataGridViewImageColumn;
            if (col == null) return;
            if (!(col.Tag is int opId)) return;

            var empIdObj = dgvPermissions.Rows[e.RowIndex].Cells["colEmployeeId"].Value;
            if (empIdObj == null) return;

            var empId = (Guid)empIdObj;

            TogglePermission(empId, e.RowIndex, e.ColumnIndex, opId);
        }

        private void TogglePermission(Guid empId, int rowIndex, int colIndex, int opId)
        {
            if (!_employeeOpIds.TryGetValue(empId, out var set))
            {
                set = new HashSet<int>();
                _employeeOpIds[empId] = set;
            }

            bool nowChecked;
            if (set.Contains(opId))
            {
                set.Remove(opId);
                nowChecked = false;
            }
            else
            {
                set.Add(opId);
                nowChecked = true;
            }

            dgvPermissions.Rows[rowIndex].Cells[colIndex].Value = nowChecked ? _bmpChecked : _bmpUnchecked;
        }

        private Bitmap CreateThemedCheckBitmap(bool isChecked, int size)
        {
            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var border = Color.FromArgb(15, 15, 15);
                var fillChecked = Color.FromArgb(32, 115, 217);
                var tick = Color.White;

                // Ô vuông (không bo góc)
                var rect = new Rectangle(4, 4, size - 8, size - 8);

                if (isChecked)
                {
                    using (var brush = new SolidBrush(fillChecked))
                        g.FillRectangle(brush, rect);
                }

                using (var pen = new Pen(border, 1.2f))
                    g.DrawRectangle(pen, rect);

                // Tick nhỏ hơn nữa (mảnh hơn + co vào giữa)
                if (isChecked)
                {
                    using (var penTick = new Pen(tick, 1.8f)) // giảm độ dày
                    {
                        penTick.StartCap = LineCap.Round;
                        penTick.EndCap = LineCap.Round;

                        // Co tick vào giữa hơn so với bản cũ
                        var p1 = new Point((int)(size * 0.34), (int)(size * 0.56));
                        var p2 = new Point((int)(size * 0.47), (int)(size * 0.67));
                        var p3 = new Point((int)(size * 0.66), (int)(size * 0.40));

                        g.DrawLines(penTick, new[] { p1, p2, p3 });
                    }
                }
            }
            return bmp;
        }

        // Snapshot quyền hiện tại (dùng cho nút Lưu)
        public Dictionary<Guid, HashSet<int>> GetCurrentPermissionSnapshot()
            => _employeeOpIds;

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            // snapshot: EmployeeID -> HashSet(OperationId)
            var snapshot = GetCurrentPermissionSnapshot();

            var ok = _operationBLL.SaveEmployeeOperations(snapshot);
            MessageBox.Show(ok ? "Lưu phân quyền thành công." : "Lưu phân quyền thất bại.");
        }



        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_OperationUC();
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_OperationUC();

        }
    }
}
