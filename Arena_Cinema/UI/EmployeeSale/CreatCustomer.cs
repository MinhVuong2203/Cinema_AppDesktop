using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.EmployeeSale
{
    public partial class CreatCustomer : Form
    {
        private readonly CinemaDBContext _context;
        public CreatCustomer(string phone)
        {

            InitializeComponent();
            _context = new CinemaDBContext();
            txtPhone.Text = phone;
            txtPhone.Enabled = false;
        }

        //tạo khách hàng mới
        public void CreatedCustomer()
        {
            //Guid 
            string phone = txtPhone.Text;
            string name = txtFullName.Text;
            string email = txtEmail.Text;
            DateTime bthDate = dtpBirthDate.Value;
            string gender = cbGender.Text;
            DateTime regis = dtpRegisterDate.Value;
            // Tạo đối tượng khách hàng mới
            var customer = new Customer
            {
                Phone = phone,
                FullName = name,
                Email = email,
                BirthDate = bthDate.ToString(),
            };

            // Thêm khách hàng vào cơ sở dữ liệu
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatedCustomer();
            //đóng form
            this.Dispose();
        }
    }
}
