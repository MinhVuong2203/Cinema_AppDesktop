using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
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
            LoadEmployeeData(employee);
            LoadMoviesShowingToday();
        }

        private void LoadEmployeeData(DTO.Employee employee)
        {
            if (employee == null) return;
            ImgHelper.DisplayImageFromRelative(employee.ImageUrl, picAVT);
            lb_EmName.Text = employee.FullName;
            lb_EmpIDText.Text = $"Mã NV: {employee.EmployeeID}";
            lb_BranchText.Text = $"Chi nhánh: {employee.Address}";
            lb_EmailText.Text = $"Email: {employee.Email}";
            lb_PhoneText.Text = $"SĐT: {employee.Phone}";
            lb_BthDayText.Text = $"Ngày sinh: {employee.BirthDate?.ToString("dd/MM/yyyy") ?? "N/A"}";
            lb_SalaryText.Text = $"Lương: {employee.HourWage?.ToString("C") ?? "N/A"}";
            lb_workDateText.Text = $"Ngày vào làm: {employee.RegisterDate?.ToString("dd/MM/yyyy") ?? "N/A"}";
        }

        private void LoadMoviesShowingToday()
        {
            flpMovies.Controls.Clear();

            using (var showTimeDAL = new ShowTimeDAL())
            {
                var todayShowTimes = showTimeDAL.GetTodayShowTimes();

                var movieIdsWithShowTime = todayShowTimes
                    .Select(st => st.MovieID)
                    .Distinct()
                    .ToList();

                var allMovies = _movieBLL.GetAllMovies();
                var moviesShowingToday = allMovies
                    .Where(m => movieIdsWithShowTime.Contains(m.MovieID) && !m.IsDeleted)
                    .ToList();

                foreach (var movie in moviesShowingToday)
                {
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
                    btnBook.Click += (s, e) => _home.LoadControl(new SaleTicketUC(movie, _home, _employee));

                    panel.Controls.Add(picPoster);
                    panel.Controls.Add(lbTitle);
                    panel.Controls.Add(lbInfo);
                    panel.Controls.Add(lbAge);
                    panel.Controls.Add(btnBook);

                    flpMovies.Controls.Add(panel);
                }

                // ✅ HIỂN THỊ THÔNG BÁO NẾU KHÔNG CÓ PHIM NÀO
                if (moviesShowingToday.Count == 0)
                {
                    var lblNoMovie = new Label
                    {
                        Text = "Không có phim nào có lịch chiếu trong ngày hôm nay.",
                        Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                        ForeColor = System.Drawing.Color.Gray,
                        AutoSize = true,
                        Margin = new Padding(20)
                    };
                    flpMovies.Controls.Add(lblNoMovie);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SaleHomeUC(_home, _employee));
        }
    }
}
