using BLL;
using DTO;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI.Employee
{
    public partial class SalaryReportUC : UserControl
    {
        private readonly SalaryReportBLL _reportBLL;
        private List<SalaryReportBLL.ReportItem> _currentData;

        // Màu chức vụ
        private readonly Dictionary<string, Color> _roleColors =
            new Dictionary<string, Color>
            {
                { "Admin", Color.FromArgb(255, 107, 107) },
                { "Nhân viên bán vé", Color.FromArgb(78, 205, 196) },
                { "Nhân viên kỹ thuật", Color.FromArgb(255, 195, 113) },
                { "Nhân viên phim", Color.FromArgb(162, 155, 254) },
                { "Bảo vệ", Color.FromArgb(255, 159, 243) },
                { "Tạp vụ", Color.FromArgb(181, 234, 215) }
            };

        // Màu trạng thái
        private readonly Dictionary<string, Color> _statusColors =
            new Dictionary<string, Color>
            {
                { "Đang làm",   Color.FromArgb(46, 213, 115) },
                { "Sắp làm",    Color.FromArgb(72, 219, 251) },
                { "Hoàn thành", Color.FromArgb(162, 155, 254) },
                { "Vắng",       Color.FromArgb(255, 107, 107) },
                { "Nghỉ phép",  Color.FromArgb(255, 195, 113) }
            };

        public SalaryReportUC()
        {
            InitializeComponent();
            _reportBLL = new SalaryReportBLL();

            if (!DesignMode)
            {
                InitFilters();
                InitGrid();
                InitChart();
                LoadRoles();
                LoadReport();
            }
        }

        private void InitFilters()
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Today;
        }

        private void LoadRoles()
        {
            // nếu bạn đã có RoleDAL thì có thể load dynamic,
            // ở đây demo đơn giản: thêm "-- Tất cả --" và các role phổ biến
            cboRole.Items.Clear();
            cboRole.Items.Add("-- Tất cả --");
            cboRole.Items.AddRange(_roleColors.Keys.Cast<object>().ToArray());
            cboRole.SelectedIndex = 0;
        }

        private void InitGrid()
        {
            dgvReport.AutoGenerateColumns = false;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.RowHeadersVisible = false;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;

            dgvReport.Columns.Clear();

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIndex",
                HeaderText = "STT",
                Width = 50,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "HỌ TÊN",
                Width = 200,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRole",
                HeaderText = "CHỨC VỤ",
                Width = 150,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDone",
                HeaderText = "HOÀN THÀNH",
                Width = 90,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colWorking",
                HeaderText = "ĐANG LÀM",
                Width = 90,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAbsent",
                HeaderText = "VẮNG",
                Width = 70,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLeave",
                HeaderText = "NGHỈ PHÉP",
                Width = 90,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "TỔNG CA",
                Width = 80,
                ReadOnly = true
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSalary",
                HeaderText = "LƯƠNG (đ)",
                Width = 120,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0",
                    ForeColor = Color.FromArgb(39, 174, 96)
                }
            });

            dgvReport.CellFormatting += DgvReport_CellFormatting;
        }

        private void InitChart()
        {
            chartSalary.Series.Clear();
            chartSalary.ChartAreas[0].AxisX.Interval = 1;
            chartSalary.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            var series = new Series("Lương")
            {
                ChartType = SeriesChartType.Column
            };
            chartSalary.Series.Add(series);
        }

        private void LoadReport()
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;
            string role = cboRole.SelectedItem != null ? cboRole.SelectedItem.ToString() : null;
            string name = txtSearch.Text.Trim();

            _currentData = _reportBLL.GetSalaryReport(start, end, role, name);

            // Fill grid
            dgvReport.Rows.Clear();
            int index = 1;
            foreach (var r in _currentData)
            {
                dgvReport.Rows.Add(
                    index++,
                    r.Employee.FullName,
                    r.Employee.Role != null ? r.Employee.Role.RoleName : "",
                    r.Completed,
                    r.Working,
                    r.Absent,
                    r.Leave,
                    r.Total,
                    r.Salary
                );
            }

            // Tổng quan
            lblTotalEmployee.Text = _currentData.Count.ToString();
            lblTotalSalary.Text = _currentData.Sum(x => x.Salary).ToString("N0") + " đ";
            lblTotalDone.Text = _currentData.Sum(x => x.Completed).ToString();
            lblTotalAbsent.Text = _currentData.Sum(x => x.Absent).ToString();

            // Chart
            chartSalary.Series[0].Points.Clear();
            foreach (var r in _currentData)
            {
                chartSalary.Series[0].Points.AddXY(r.Employee.FullName, r.Salary);
            }
        }

        private void DgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReport.Columns[e.ColumnIndex].Name == "colRole" && e.Value != null)
            {
                string role = e.Value.ToString();
                if (_roleColors.TryGetValue(role, out Color c))
                {
                    e.CellStyle.BackColor = c;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = c;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        // ====== EVENT HANDLERS ======

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
                dtpEndDate.Value = dtpStartDate.Value.Date;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
                dtpStartDate.Value = dtpEndDate.Value.Date;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // có thể debounce nếu muốn, tạm thời reload luôn
            LoadReport();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
