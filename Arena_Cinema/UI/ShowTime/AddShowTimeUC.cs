using System;
using System.Windows.Forms;
using DTO;
using BLL;
using UI;

namespace UI.ShowTime
{
    public partial class AddShowTimeUC : UserControl
    {
        // Constructor không tham số (BẮT BUỘC cho Designer)
        public AddShowTimeUC()
        {
            InitializeComponent();
        }

        // Constructor có tham số
        public AddShowTimeUC(Home home, DTO.Employee employee) : this()
        {
            _home = home;
            _employee = employee;
            InitializeData(home, employee);
            this.Load += (s, e) => LoadInitialData();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var showTime = new DTO.ShowTime
                {
                    MovieID = (int)((ComboBoxItem)cboMovie.SelectedItem).Value,
                    RoomID = (int)((ComboBoxItem)cboRoom.SelectedItem).Value,
                    StartTime = dtpStartTime.Value,
                    Price = decimal.Parse(txtPrice.Text),
                    IsDeleted = false
                };

                var result = showTimeBLL.AddShowTime(showTime);
                MessageBox.Show(result.message, result.success ? "Thành công" : "Lỗi",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (result.success)
                {
                    _home?.LoadControl(new MNShowTimeUC(_home, _employee));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác?", "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _home?.LoadControl(new MNShowTimeUC(_home, _employee));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _home?.LoadControl(new MNShowTimeUC(_home, _employee));
        }
    }
}