using BLL;
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
using UI.Employee;
using UI.Movie;

namespace UI.ShowTime
{
    /// <summary>
    /// User Control để chỉnh sửa thông tin suất chiếu
    /// File này chỉ chứa các event handler gọi đến các hàm logic trong file partial class
    /// </summary>
    public partial class EditShowTimeUC : UserControl
    {
        // Constructor mặc định
        public EditShowTimeUC()
        {
            InitializeComponent();
        }

        // Constructor với tham số để khởi tạo dữ liệu
        public EditShowTimeUC(Home home, DTO.Employee employee, DTO.ShowTime showTime)
        {
            InitializeComponent();
            InitializeData(home, employee, showTime);
        }

        #region Event Handlers - Chỉ gọi hàm

     
        private void EditShowTimeUC_Load(object sender, EventArgs e)
        {
            CenterControlsInPanel();
            LoadInitialData();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveShowTime();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy các thay đổi?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Movie_MainUC movieMain = new Movie_MainUC(_home, _employee);
                _home.LoadControl(movieMain);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn quay lại?\nCác thay đổi chưa lưu sẽ bị mất!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _home.LoadControl(new MNShowTimeUC(_home, _employee));
            }
        }

        #endregion
    }
}