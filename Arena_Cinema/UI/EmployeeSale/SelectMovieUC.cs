using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Common;
using DTO;
using Microsoft.VisualBasic.Devices;

namespace UI.EmployeeSale
{
    public partial class SelectMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL _movieBLL = new MovieBLL();

        public SelectMovieUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            _home = form;
            _employee = employee;
            LoadEmployeeData();
            LoadMoviesShowingToday();
        }

        private void LoadEmployeeData()
        {
            if (_employee == null) return;
            ImgHelper.DisplayImageFromRelative(_employee.ImageUrl, picAVT);
            lb_EmName.Text = _employee.FullName;
            lb_EmpIDText.Text = $"Mã NV: {_employee.EmployeeID}";
            lb_BranchText.Text = $"Chi nhánh: {_employee.Address}";
            lb_EmailText.Text = $"Email: {_employee.Email}";
            lb_PhoneText.Text = $"SĐT: {_employee.Phone}";
            lb_BthDayText.Text = $"Ngày sinh: {_employee.BirthDate?.ToString("dd/MM/yyyy") ?? "N/A"}";
            lb_SalaryText.Text = $"Lương: {_employee.HourWage?.ToString("C") ?? "N/A"}";
            lb_workDateText.Text = $"Ngày vào làm: {_employee.RegisterDate?.ToString("dd/MM/yyyy") ?? "N/A"}";
        }

        private void LoadMoviesShowingToday()
        {
            flpMovies.Controls.Clear();
            var allMovies = _movieBLL.GetAllMovies();
            var today = DateTime.Today;
            var moviesShowingToday = allMovies
                .Where(m => m.StartTime.HasValue && m.EndTime.HasValue
                            && m.StartTime.Value <= today && m.EndTime.Value >= today
                            && !m.IsDeleted)
                .ToList();

            foreach (var movie in moviesShowingToday)
            {
                //string fullPath = Path.Combine(Application.StartupPath, movie.ImageUrl);
                var panel = new Panel
                {
                    Width = 320,
                    Height = 560,
                    Margin = new Padding(10),
                    BackColor = System.Drawing.Color.White
                };

                var picPoster = new PictureBox
                {
                    Location = new System.Drawing.Point(10, 10),
                    Size = new System.Drawing.Size(300, 400),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    //ImageLocation = fullPath
                };
                ImgHelper.DisplayImageFromRelative(movie.ImageUrl, picPoster);

                var lbTitle = new Label
                {
                    Location = new System.Drawing.Point(10, 420),
                    Size = new System.Drawing.Size(300, 30),
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold),
                    Text = $"{movie.Title} ({movie.AgeLimit})"
                };

                var lbInfo = new Label
                {
                    Location = new System.Drawing.Point(10, 455),
                    Size = new System.Drawing.Size(300, 25),
                    Font = new System.Drawing.Font("Segoe UI", 10F),
                    Text = $"{movie.Genre} • {movie.DurationMinutes} phút"
                };

                var lbAge = new Label
                {
                    Location = new System.Drawing.Point(10, 480),
                    Size = new System.Drawing.Size(300, 25),
                    Font = new System.Drawing.Font("Segoe UI", 10F),
                    Text = movie.AgeLimit
                };

                var btnBook = new Button
                {
                    Location = new System.Drawing.Point(10, 510),
                    Size = new System.Drawing.Size(300, 40),
                    Text = "Đặt vé",
                    BackColor = System.Drawing.Color.FromArgb(184, 28, 45),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
                };
                btnBook.Click += (s, e) => _home.LoadControl(new SaleTicketUC(movie));

                panel.Controls.Add(picPoster);
                panel.Controls.Add(lbTitle);
                panel.Controls.Add(lbInfo);
                panel.Controls.Add(lbAge);
                panel.Controls.Add(btnBook);

                flpMovies.Controls.Add(panel);
            }
        }
    }
}
