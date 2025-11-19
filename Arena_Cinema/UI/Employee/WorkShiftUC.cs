using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Employee
{
    public partial class WorkShiftUC : UserControl
    {
        private Home _home;
        private DTO.Employee _currentEmployee;

        private EmployeeBLL _employeeBLL;
        private WorkShiftBLL _workShiftBLL;
        private RoleDAL _roleDAL;

        private List<DTO.Employee> _employees;
        private List<WorkShift> _workShifts;

        private DateTime _startDate;
        private DateTime _endDate;

        private Timer _searchTimer;

        private readonly Dictionary<string, (TimeSpan Start, TimeSpan End)> _shiftTimes =
            new Dictionary<string, (TimeSpan, TimeSpan)>
            {
                { "Sáng",  (new TimeSpan(8, 0, 0),  new TimeSpan(12, 0, 0)) },
                { "Chiều", (new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0)) },
                { "Tối",   (new TimeSpan(16, 0, 0), new TimeSpan(23, 0, 0)) }
            };

        private readonly string[] _statusList = { "Đang làm", "Sắp làm", "Hoàn thành", "Vắng", "Nghỉ phép" };

        public WorkShiftUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
           
            _home = home;
            _currentEmployee = employee;

            _employeeBLL = new EmployeeBLL();
            _workShiftBLL = new WorkShiftBLL();
            _roleDAL = new RoleDAL();

            _startDate = DateTime.Today;
            _endDate = DateTime.Today.AddDays(6);

            _searchTimer = new Timer();
            _searchTimer.Interval = 300;
            _searchTimer.Tick += (s, e) =>
            {
                _searchTimer.Stop();
                LoadDataAsync();
            };
            StartShiftTimer();
            virtualRenderer.CellClicked += VirtualRenderer_CellClicked;
        }

        private void StartShiftTimer()
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 600000;
            timer.Tick += (s, e) => AutoUpdateShiftStatuses();
            timer.Start();
            AutoUpdateShiftStatuses();
        }
        private void AutoUpdateShiftStatuses()
        {
            var now = DateTime.Now;
            DateTime today = now.Date;

            // Lấy toàn bộ ca có StartTime <= hôm nay
            var shifts = _workShiftBLL.GetWorkShiftsByDateRange(
                DateTime.MinValue,      // từ trước tới giờ
                today                   // đến hết ngày hôm nay
            );
            foreach (var shift in shifts)
            {
                // Nếu trạng thái được set cố định → không auto update
                if (shift.Status == "Vắng" || shift.Status == "Nghỉ phép")
                    continue;
                string oldStatus = shift.Status;
                string newStatus = oldStatus;
                if (now < shift.StartTime)
                    newStatus = "Sắp làm";
                else if (now >= shift.StartTime && now <= shift.EndTime)
                    newStatus = "Đang làm";
                else
                    newStatus = "Hoàn thành";
                if (newStatus == oldStatus)
                    continue;
                shift.Status = newStatus;
                _workShiftBLL.UpdateWorkShift(shift);
            }
        }


        private void WorkShiftUC_Load(object sender, EventArgs e)
        {
            InitFilterControls();
            LoadRoles();
            LoadDataAsync();
        }

        private void InitFilterControls()
        {
            dtpStartDate.Value = _startDate;
            dtpEndDate.Value = _endDate;
        }

        private void LoadRoles()
        {
            try
            {
                var roles = _roleDAL.GetAllRoles();
                cboRole.Items.Clear();
                cboRole.Items.Add("-- Tất cả --");
                foreach (var r in roles)
                {
                    cboRole.Items.Add(r.RoleName);
                }
                cboRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chức vụ: " + ex.Message);
            }
        }

        private async void LoadDataAsync()
        {
            try
            {
                string roleFilter = cboRole.SelectedIndex > 0 ? cboRole.Text : null;

                var start = _startDate;
                var end = _endDate;

                List<DTO.Employee> employees = null;
                List<WorkShift> shifts = null;

                employees = _employeeBLL.FilterEmployees("", roleFilter, false);
                shifts = _workShiftBLL.GetWorkShiftsByDateRange(_startDate, _endDate);

                _employees = employees;
                _workShifts = shifts;

                virtualRenderer.SetData(_employees, _workShifts, _startDate, _endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VirtualRenderer_CellClicked(object sender, ShiftCellClickEventArgs e)
        {
            if (e.WorkShift == null)
            {
                HandleAddShift(e);
            }
            else
            {
                ShowShiftContextMenu(e);
            }
        }

        private void HandleAddShift(ShiftCellClickEventArgs info)
        {
            var timeRange = _shiftTimes[info.ShiftName];
            DateTime startTime = info.Date.Date.Add(timeRange.Start);
            DateTime endTime = info.Date.Date.Add(timeRange.End);

            try
            {
                var ws = new WorkShift
                {
                    EmployeeID = info.Employee.EmployeeID,
                    StartTime = startTime,
                    EndTime = endTime,
                    WorkingHours = (endTime - startTime).TotalHours,
                    SalaryPerHour = info.Employee.HourWage ?? 0,
                    Status = "Sắp làm"
                };

                _workShiftBLL.AddWorkShift(ws);
                LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân ca: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ShowShiftContextMenu(ShiftCellClickEventArgs info)
        {
            var menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 12F);

            if (info.WorkShift.Status == "Sắp làm")
            {
                var del = new ToolStripMenuItem("❌ Xóa ca làm");
                del.Click += (s, e) => DeleteShift(info.WorkShift);
                menu.Items.Add(del);
            }
            else
            {
                foreach (string st in _statusList)
                {
                    if (st == info.WorkShift.Status || st == "Đang làm" || st=="Sắp làm") continue; 
                    string icon = "📝";                   
                    if (st == "Hoàn thành") icon = "✅";
                    else if (st == "Vắng") icon = "❌";
                    else if (st == "Nghỉ phép") icon = "🏖️";

                    var item = new ToolStripMenuItem(icon + " " + st);
                    string targetStatus = st;
                    item.Click += (s, e) => UpdateShiftStatus(info.WorkShift, targetStatus);
                    menu.Items.Add(item);
                }
            }


            menu.Show(Cursor.Position);
        }

        private void DeleteShift(WorkShift ws)
        {
            if (MessageBox.Show("Xóa ca làm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _workShiftBLL.DeleteWorkShift(ws.ShiftID);
                    LoadDataAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa ca: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateShiftStatus(WorkShift ws, string newStatus)
        {
            try
            {
                ws.Status = newStatus;
                _workShiftBLL.UpdateWorkShift(ws);
                LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==== Event filter ====

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            _startDate = dtpStartDate.Value.Date;
            if (_startDate > _endDate)
            {
                _endDate = _startDate.AddDays(6);
                dtpEndDate.Value = _endDate;
            }
            LoadDataAsync();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            _endDate = dtpEndDate.Value.Date;
            if (_endDate < _startDate)
            {
                _startDate = _endDate.AddDays(-6);
                dtpStartDate.Value = _startDate;
            }
            LoadDataAsync();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }
    }
}
