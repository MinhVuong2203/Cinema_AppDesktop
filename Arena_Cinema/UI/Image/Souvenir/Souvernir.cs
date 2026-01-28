using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
using DTO;
using UI.Employee;
using UI.SeatManagement;

namespace UI.ScreeningRoom
{
    public partial class Room_homeUC : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private RoomBLL _roomBLL = new RoomBLL();

        private List<Room> _allRooms = new List<Room>();
        private string _filterType = "Tất cả";
        private int currentPage = 1;
        private int pageSize = 6;
        private int totalPages = 1;
        private List<Room> currentRooms = new List<Room>();

        public Room_homeUC(Home form, Room room)
        {
            this._room = room;
            this._home = form;
            InitializeComponent();

            cardRoomSample.Visible = false;
            panelRoomsList.AutoScroll = true;
            ConfigureFlowLayoutPanel();

            LoadRoomTypes();
            LoadRoomsWithFilter();
            this.Resize += Room_homeUC_Resize;
            panelRoomsList.SizeChanged += (s, e) => AdjustCardSizes();
        }
        private void ConfigureFlowLayoutPanel()
        {
            panelRoomsList.FlowDirection = FlowDirection.LeftToRight;
            panelRoomsList.WrapContents = true;
            panelRoomsList.AutoScroll = true;
            panelRoomsList.Padding = new Padding(10, 10, 10, 10);

            AdjustCardSizes();
        }
        private void AdjustCardSizes()
        {
            if (panelRoomsList == null || cardRoomSample == null) return;
            int cardWidth = 350;  
            int cardHeight = 350; 
            int panelWidth = panelRoomsList.ClientSize.Width;
            int padding = panelRoomsList.Padding.Left + panelRoomsList.Padding.Right;
            int availableWidth = panelWidth - padding;
            int cardsPerRow = 3;
            int totalCardWidth = cardsPerRow * cardWidth;
            int remainingSpace = availableWidth - totalCardWidth;
            int spacing = Math.Max(10, remainingSpace / (cardsPerRow + 1)); 
            cardRoomSample.Size = new Size(cardWidth, cardHeight);
            cardRoomSample.Margin = new Padding(spacing, 10, 15, 10);
            foreach (Control control in panelRoomsList.Controls)
            {
                if (control is ReaLTaiizor.Controls.MaterialCard card && control != cardRoomSample)
                {
                    card.Size = new Size(cardWidth, cardHeight);
                    card.Margin = new Padding(spacing, 10, 15, 10);
                }
            }
        }

        private void Room_homeUC_Resize(object sender, EventArgs e)
        {
            AdjustCardSizes();
        }

        private void LoadRoomTypes()
        {
            cboRoomType.Items.Clear();
            cboRoomType.Items.Add("Tất cả");
            cboRoomType.Items.AddRange(new[] { "2D", "3D", "IMAX", "VIP" });
            cboRoomType.SelectedIndex = 0;

            cboRoomType.SelectedIndexChanged += (s, e) =>
            {
                _filterType = cboRoomType.SelectedItem.ToString();
                currentPage = 1;
                LoadRoomsWithFilter();
            };
        }

        private void LoadRoomsWithFilter()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                panelRoomsList.Controls.Clear();

                _roomBLL = new RoomBLL();
                var allRooms = _roomBLL.GetAllRooms();
                allRooms = allRooms.Where(r => r.statement == "Bình thường").ToList();

                if (_filterType != "Tất cả")
                    allRooms = allRooms.Where(r => r.RoomType == _filterType).ToList();

                int totalRooms = allRooms.Count;
                totalPages = (int)Math.Ceiling((double)totalRooms / pageSize);

                if (totalPages == 0)
                    totalPages = 1;

                if (currentPage > totalPages)
                    currentPage = totalPages;
                if (currentPage < 1)
                    currentPage = 1;

                currentRooms = allRooms
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                DisplayRooms(currentRooms);
                UpdateInfoLabel();
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DisplayRooms(List<Room> rooms)
        {
            panelRoomsList.SuspendLayout();
            try
            {
                foreach (Control control in panelRoomsList.Controls.Cast<Control>().ToList())
                {
                    panelRoomsList.Controls.Remove(control);
                    control.Dispose();
                }

                if (rooms == null || rooms.Count == 0)
                {
                    System.Windows.Forms.Panel noDataPanel = new System.Windows.Forms.Panel
                    {
                        Size = new Size(panelRoomsList.Width - 50, 200),
                        Margin = new Padding(20)
                    };

                    Label lblNoData = new Label
                    {
                        Text = "Không tìm thấy phòng nào!",
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };

                    lblNoData.Location = new Point(
                        Math.Max(0, (noDataPanel.Width - lblNoData.PreferredWidth) / 2),
                        Math.Max(0, (noDataPanel.Height - lblNoData.PreferredHeight) / 2)
                    );

                    noDataPanel.Controls.Add(lblNoData);
                    panelRoomsList.Controls.Add(noDataPanel);
                    return;
                }

                AdjustCardSizes();

                foreach (var room in rooms)
                {
                    var card = CloneCard(cardRoomSample);
                    FillCard(card, room);
                    panelRoomsList.Controls.Add(card);
                }
            }
            finally
            {
                panelRoomsList.ResumeLayout(true);
                panelRoomsList.PerformLayout();
            }
        }

        private void UpdateInfoLabel()
        {
            try
            {
                if (lblInfo == null) return;

                int totalRooms = currentRooms?.Count ?? 0;
                string filterInfo = _filterType != "Tất cả" ? $" | {_filterType}" : "";

                lblInfo.Text = $"Hiển thị: {totalRooms} phòng{filterInfo}   Trang {currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating info label: {ex.Message}");
            }
        }

        private void UpdatePaginationButtons()
        {
            try
            {
                if (paginationPanel == null) return;
                var buttonsToRemove = paginationPanel.Controls
                    .OfType<ReaLTaiizor.Controls.ParrotButton>()
                    .Where(btn => btn != btnPageNumberTemplate && btn != btnNavTemplate)
                    .ToList();

                foreach (var btn in buttonsToRemove)
                {
                    paginationPanel.Controls.Remove(btn);
                    btn.Dispose();
                }

                CreateNavigationButtons();
                CreatePageNumberButtons();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating pagination: {ex.Message}");
            }
        }

        private void CreateNavigationButtons()
        {
            Color disabledColor = Color.FromArgb(180, 180, 180);
            var btnNavFirst = CloneNavButton("btnNavFirst", "««", 490);
            btnNavFirst.Click += (s, e) => NavigateToPage(1);
            btnNavFirst.Enabled = currentPage > 1;
            if (!btnNavFirst.Enabled) btnNavFirst.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavFirst);
            var btnNavPrev = CloneNavButton("btnNavPrev", "‹", 540);
            btnNavPrev.Click += (s, e) => { if (currentPage > 1) NavigateToPage(currentPage - 1); };
            btnNavPrev.Enabled = currentPage > 1;
            if (!btnNavPrev.Enabled) btnNavPrev.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavPrev);
            int nextButtonX = 590 + (Math.Min(totalPages, 5) * 45);
            var btnNavNext = CloneNavButton("btnNavNext", "›", nextButtonX);
            btnNavNext.Click += (s, e) => { if (currentPage < totalPages) NavigateToPage(currentPage + 1); };
            btnNavNext.Enabled = currentPage < totalPages;
            if (!btnNavNext.Enabled) btnNavNext.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavNext);
            var btnNavLast = CloneNavButton("btnNavLast", "»", nextButtonX + 50);
            btnNavLast.Click += (s, e) => NavigateToPage(totalPages);
            btnNavLast.Enabled = currentPage < totalPages;
            if (!btnNavLast.Enabled) btnNavLast.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavLast);
        }

        private ReaLTaiizor.Controls.ParrotButton CloneNavButton(string name, string text, int x)
        {
            var btn = new ReaLTaiizor.Controls.ParrotButton
            {
                Name = name,
                BackgroundColor = btnNavTemplate.BackgroundColor,
                ButtonImage = btnNavTemplate.ButtonImage,
                ButtonStyle = btnNavTemplate.ButtonStyle,
                ButtonText = text,
                ClickBackColor = btnNavTemplate.ClickBackColor,
                ClickTextColor = btnNavTemplate.ClickTextColor,
                CornerRadius = btnNavTemplate.CornerRadius,
                Cursor = btnNavTemplate.Cursor,
                Font = btnNavTemplate.Font,
                Horizontal_Alignment = btnNavTemplate.Horizontal_Alignment,
                HoverBackgroundColor = btnNavTemplate.HoverBackgroundColor,
                HoverTextColor = btnNavTemplate.HoverTextColor,
                ImagePosition = btnNavTemplate.ImagePosition,
                Location = new Point(x, 10),
                Size = btnNavTemplate.Size,
                SmoothingType = btnNavTemplate.SmoothingType,
                TextColor = btnNavTemplate.TextColor,
                TextRenderingType = btnNavTemplate.TextRenderingType,
                Vertical_Alignment = btnNavTemplate.Vertical_Alignment
            };
            return btn;
        }

        private void CreatePageNumberButtons()
        {
            Color activeColor = Color.FromArgb(220, 53, 69);  
            Color inactiveColor = Color.FromArgb(108, 117, 125); 
            List<int> pagesToShow = CalculatePagesToShow();
            int startX = 590;
            int buttonWidth = 35;
            int spacing = 10;

            for (int i = 0; i < pagesToShow.Count; i++)
            {
                int pageNum = pagesToShow[i];
                bool isCurrentPage = pageNum == currentPage;

                var btnPage = new ReaLTaiizor.Controls.ParrotButton
                {
                    Name = $"btnDynamicPage{pageNum}",
                    BackgroundColor = isCurrentPage ? activeColor : inactiveColor,
                    ButtonImage = btnPageNumberTemplate.ButtonImage,
                    ButtonStyle = btnPageNumberTemplate.ButtonStyle,
                    ButtonText = pageNum.ToString(),
                    ClickBackColor = btnPageNumberTemplate.ClickBackColor,
                    ClickTextColor = btnPageNumberTemplate.ClickTextColor,
                    CornerRadius = btnPageNumberTemplate.CornerRadius,
                    Cursor = btnPageNumberTemplate.Cursor,
                    Font = btnPageNumberTemplate.Font,
                    Horizontal_Alignment = btnPageNumberTemplate.Horizontal_Alignment,
                    HoverBackgroundColor = isCurrentPage ? activeColor : Color.FromArgb(128, 137, 145),
                    HoverTextColor = btnPageNumberTemplate.HoverTextColor,
                    ImagePosition = btnPageNumberTemplate.ImagePosition,
                    Location = new Point(startX + (i * (buttonWidth + spacing)), 10),
                    Size = btnPageNumberTemplate.Size,
                    SmoothingType = btnPageNumberTemplate.SmoothingType,
                    TextColor = btnPageNumberTemplate.TextColor,
                    TextRenderingType = btnPageNumberTemplate.TextRenderingType,
                    Vertical_Alignment = btnPageNumberTemplate.Vertical_Alignment,
                    Tag = pageNum
                };

                btnPage.Click += (s, e) =>
                {
                    var btn = s as ReaLTaiizor.Controls.ParrotButton;
                    if (btn != null && btn.Tag is int page)
                    {
                        NavigateToPage(page);
                    }
                };

                paginationPanel.Controls.Add(btnPage);
            }
        }

        private List<int> CalculatePagesToShow()
        {
            List<int> pages = new List<int>();

            if (totalPages <= 5)
            {
                for (int i = 1; i <= totalPages; i++)
                {
                    pages.Add(i);
                }
            }
            else
            {
                if (currentPage <= 3)
                {
                    pages.AddRange(new[] { 1, 2, 3, 4, 5 });
                }
                else if (currentPage >= totalPages - 2)
                {
                    for (int i = totalPages - 4; i <= totalPages; i++)
                    {
                        pages.Add(i);
                    }
                }
                else
                {
                    for (int i = currentPage - 2; i <= currentPage + 2; i++)
                    {
                        pages.Add(i);
                    }
                }
            }

            return pages;
        }

        private void NavigateToPage(int page)
        {
            if (page < 1 || page > totalPages || page == currentPage)
                return;

            currentPage = page;
            LoadRoomsWithFilter();
        }

        private ReaLTaiizor.Controls.MaterialCard CloneCard(ReaLTaiizor.Controls.MaterialCard original)
        {
            var card = new ReaLTaiizor.Controls.MaterialCard
            {
                Size = original.Size,
                BackColor = original.BackColor,
                Margin = original.Margin
            };

            var panel = new System.Windows.Forms.Panel
            {
                Size = original.Controls[0].Size,
                BackColor = original.Controls[0].BackColor,
                Dock = DockStyle.Fill
            };

            foreach (Control ctrl in original.Controls[0].Controls)
            {
                var cloned = CloneControl(ctrl);
                if (cloned != null)
                    panel.Controls.Add(cloned);
            }

            card.Controls.Add(panel);
            return card;
        }

        private Control CloneControl(Control ctrl)
        {
            if (ctrl is Label lbl) return new Label
            {
                Name = lbl.Name,
                Text = lbl.Text,
                Location = lbl.Location,
                Size = lbl.Size,
                Font = lbl.Font,
                ForeColor = lbl.ForeColor,
                BackColor = lbl.BackColor
            };

            if (ctrl is PictureBox pic) return new PictureBox
            {
                Name = pic.Name,
                Location = pic.Location,
                Size = pic.Size,
                SizeMode = pic.SizeMode,
                BorderStyle = pic.BorderStyle
            };

            if (ctrl is ReaLTaiizor.Controls.MaterialButton btn) return new ReaLTaiizor.Controls.MaterialButton
            {
                Name = btn.Name,
                Text = btn.Text,
                Location = btn.Location,
                Size = btn.Size,
                BackColor = btn.BackColor,
                ForeColor = btn.ForeColor
            };

            return new Control { Location = ctrl.Location, Size = ctrl.Size };
        }

        private void FillCard(ReaLTaiizor.Controls.MaterialCard card, Room room)
        {
            var p = (System.Windows.Forms.Panel)card.Controls[0];

            var pic = (PictureBox)p.Controls["ptbRoomImage"];

            if (!string.IsNullOrEmpty(room.ImageUrl))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, room.ImageUrl);

                    if (File.Exists(fullPath))
                    {
                        if (pic.Image != null && pic.Image != Properties.Resources.roomDefault)
                        {
                            pic.Image.Dispose();
                        }

                        using (var img = Image.FromFile(fullPath))
                        {
                            pic.Image = new Bitmap(img);
                        }
                    }
                    else
                    {
                        pic.Image = Properties.Resources.roomDefault;
                    }
                }
                catch
                {
                    pic.Image = Properties.Resources.roomDefault;
                }
            }
            else
            {
                pic.Image = Properties.Resources.roomDefault;
            }

            ((Label)p.Controls["lblRoomID"]).Text = $"ID: {room.RoomID}";
            ((Label)p.Controls["lblEmployeeName"]).Text = room.RoomName;
            ((Label)p.Controls["lblRoomType"]).Text = room.RoomType ?? "Standard";
            ((Label)p.Controls["lblSeatcount"]).Text = $"{room.SeatCount ?? 0} ghế";
            ((Label)p.Controls["lblDescription"]).Text = room.Description ?? "Không có mô tả";

            var btnSua = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnSua"];
            btnSua.Tag = room.RoomID;
            btnSua.Click -= BtnEdit_Click;
            btnSua.Click += BtnEdit_Click;

            var btnXoa = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnXoa"];
            btnXoa.Tag = room.RoomID;
            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            var btnMaintenance = (ReaLTaiizor.Controls.MaterialButton)p.Controls["BtnSeatManagement"];
            btnMaintenance.Tag = room.RoomID;

            if (room.statement == "Bảo trì")
            {
                btnMaintenance.Text = Resources.Lang.hoatdong;
                btnMaintenance.BackColor = Color.Green;
            }
            else
            {
                btnMaintenance.Text = Resources.Lang.baotri;
                btnMaintenance.BackColor = Color.Orange;
            }

            btnMaintenance.Click -= BtnMaintenance_Click;
            btnMaintenance.Click += BtnMaintenance_Click;
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;
            var roomBLL = new RoomBLL();
            var room = roomBLL.GetRoomById(roomId);

            if (room == null)
            {
                MessageBox.Show("Không tìm thấy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message, result;

            if (room.statement == "Bảo trì")
            {
                message = $"Chuyển phòng '{room.RoomName}' về trạng thái hoạt động?";
                if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    result = roomBLL.SetRoomNormal(roomId);

                    if (result.Contains("thành công"))
                    {
                        MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsWithFilter();
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                message = $"Chuyển phòng '{room.RoomName}' sang trạng thái bảo trì?\n\nPhòng sẽ không hiển thị trong danh sách chính.";
                if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    result = roomBLL.SetRoomMaintenance(roomId);

                    if (result.Contains("thành công"))
                    {
                        MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (currentRooms.Count == 1 && currentPage > 1)
                        {
                            currentPage--;
                        }

                        LoadRoomsWithFilter();
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;
            var room = _roomBLL.GetRoomById(roomId);
            _home.LoadControl(new AddRoom(_home, room));
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new AddRoom(_home, null));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;

            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string result = _roomBLL.DeleteRoom(roomId);
                MessageBox.Show(result);

                if (currentRooms.Count == 1 && currentPage > 1)
                {
                    currentPage--;
                }

                LoadRoomsWithFilter();
            }
        }

        public void RefreshData()
        {
            LoadRoomsWithFilter();
        }

        private void btnDeletedRoom_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new Deleted_room(_home, this._room));
        }

        private void btnSeatManagement_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new maintenanceRoom(_home, this._room));
        }
    }
}