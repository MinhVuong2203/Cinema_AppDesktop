using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DTO;

namespace UI.Employee
{
    public class ShiftCellClickEventArgs : EventArgs
    {
        public DTO.Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public string ShiftName { get; set; }
        public WorkShift WorkShift { get; set; }
        public MouseButtons Button { get; set; }
    }

    public class WorkShiftVirtualRenderer : ScrollableControl
    {
        public List<DTO.Employee> Employees { get; set; } = new List<DTO.Employee>();
        public List<WorkShift> WorkShifts { get; set; } = new List<WorkShift>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public event EventHandler<ShiftCellClickEventArgs> CellClicked;

        private readonly Dictionary<string, (TimeSpan Start, TimeSpan End)> _shiftTimes =
            new Dictionary<string, (TimeSpan, TimeSpan)>
            {
                { "Sáng",  (new TimeSpan(8, 0, 0),  new TimeSpan(12, 0, 0)) },
                { "Chiều", (new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0)) },
                { "Tối",   (new TimeSpan(16, 0, 0), new TimeSpan(23, 0, 0)) }
            };

        private readonly string[] _shiftOrder = { "Sáng", "Chiều", "Tối" };

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

        private readonly Dictionary<string, Color> _statusColors =
            new Dictionary<string, Color>
            {
                { "Đang làm", Color.FromArgb(46, 213, 115) },
                { "Sắp làm", Color.FromArgb(72, 219, 251) },
                { "Hoàn thành", Color.FromArgb(162, 155, 254) },
                { "Vắng", Color.FromArgb(255, 107, 107) },
                { "Nghỉ phép", Color.FromArgb(255, 195, 113) }
            };

        private int _rowHeight = 62;
        private int _nameColWidth = 220;
        private int _shiftColWidth = 100;
        private int _headerDateHeight = 32;
        private int _headerShiftHeight = 28;

        private int _hoverRow = -1;
        private int _hoverDay = -1;
        private int _hoverShift = -1;

        public WorkShiftVirtualRenderer()
        {
            DoubleBuffered = true;
            AutoScroll = true;
            BackColor = Color.White;
        }

        public void SetData(List<DTO.Employee> employees, List<WorkShift> shifts,
            DateTime startDate, DateTime endDate)
        {
            Employees = employees ?? new List<DTO.Employee>();
            WorkShifts = shifts ?? new List<WorkShift>();
            StartDate = startDate.Date;
            EndDate = endDate.Date;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            int days = (EndDate - StartDate).Days + 1;
            if (days <= 0) return;

            int totalWidth = _nameColWidth + days * 3 * _shiftColWidth;
            int totalHeight = _headerDateHeight + _headerShiftHeight + Employees.Count * _rowHeight;

            AutoScrollMinSize = new Size(totalWidth, totalHeight);
            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            DrawHeader(e.Graphics, days);
            DrawRows(e.Graphics, days);
        }

        private void DrawHeader(Graphics g, int days)
        {
            using (var headerBg = new SolidBrush(Color.FromArgb(245, 247, 250)))
            using (var borderPen = new Pen(Color.FromArgb(220, 220, 220)))
            using (var textBrush = new SolidBrush(Color.FromArgb(52, 73, 94)))
            using (var fontBold = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (var fontShift = new Font("Segoe UI", 10F, FontStyle.Bold))
            {
                // Cột "Nhân viên"
                g.FillRectangle(headerBg, 0, 0, _nameColWidth,
                    _headerDateHeight + _headerShiftHeight);
                g.DrawRectangle(borderPen, 0, 0, _nameColWidth,
                    _headerDateHeight + _headerShiftHeight);
                g.DrawString("Nhân viên", fontBold, textBrush,
                    new RectangleF(0, 0, _nameColWidth, _headerDateHeight + _headerShiftHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

                int x = _nameColWidth;
                for (int d = 0; d < days; d++)
                {
                    DateTime date = StartDate.AddDays(d);

                    Color dateColor = (date.DayOfWeek == DayOfWeek.Sunday)
                        ? Color.FromArgb(255, 179, 186)
                        : Color.FromArgb(255, 244, 214);

                    using (var dateBg = new SolidBrush(dateColor))
                    {
                        g.FillRectangle(dateBg, x, 0, _shiftColWidth * 3, _headerDateHeight);
                    }

                    g.DrawRectangle(borderPen, x, 0, _shiftColWidth * 3, _headerDateHeight);

                    g.DrawString(
                        date.ToString("dd-MM"),
                        fontBold, textBrush,
                        new RectangleF(x, 0, _shiftColWidth * 3, _headerDateHeight),
                        new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

                    // 3 ô Sáng / Chiều / Tối
                    string[] shifts = { "Sáng", "Chiều", "Tối" };
                    Color[] shiftColors = {
                        Color.FromArgb(255, 234, 167),
                        Color.FromArgb(178, 190, 195),
                        Color.FromArgb(253, 167, 223)
                    };

                    for (int s = 0; s < 3; s++)
                    {
                        using (var shiftBg = new SolidBrush(shiftColors[s]))
                        {
                            g.FillRectangle(shiftBg, x + s * _shiftColWidth,
                                _headerDateHeight, _shiftColWidth, _headerShiftHeight);
                        }

                        g.DrawRectangle(borderPen,
                            x + s * _shiftColWidth,
                            _headerDateHeight,
                            _shiftColWidth,
                            _headerShiftHeight);

                        g.DrawString(shifts[s], fontShift, textBrush,
                            new RectangleF(x + s * _shiftColWidth, _headerDateHeight,
                                _shiftColWidth, _headerShiftHeight),
                            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    }

                    x += _shiftColWidth * 3;
                }
            }
        }

        private void DrawRows(Graphics g, int days)
        {
            int startY = _headerDateHeight + _headerShiftHeight;

            using (var borderPen = new Pen(Color.FromArgb(230, 230, 230)))
            using (var nameFont = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (var roleFont = new Font("Segoe UI", 10F, FontStyle.Italic))
            using (var nameBrush = new SolidBrush(Color.FromArgb(44, 62, 80)))
            using (var roleBrush = new SolidBrush(Color.FromArgb(100, 100, 100)))
            using (var hoverBorderPen = new Pen(Color.FromArgb(52, 152, 219), 1F))
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    DTO.Employee emp = Employees[i];
                    int y = startY + i * _rowHeight;

                    // nền dòng (hover)
                    if (i == _hoverRow)
                    {
                        using (var hoverBg = new SolidBrush(Color.FromArgb(245, 249, 255)))
                        {
                            g.FillRectangle(hoverBg, 0, y, _nameColWidth + days * 3 * _shiftColWidth, _rowHeight);
                        }
                    }

                    // cột tên
                    Color roleColor;
                    if (emp.Role != null && _roleColors.TryGetValue(emp.Role.RoleName ?? "", out roleColor))
                    {
                        using (var roleBg = new SolidBrush(roleColor))
                        {
                            g.FillRectangle(roleBg, 0, y, 6, _rowHeight);
                        }
                    }

                    g.DrawRectangle(borderPen, 0, y, _nameColWidth, _rowHeight);

                    Rectangle nameRect = new Rectangle(10, y + 8, _nameColWidth - 20, 22);
                    Rectangle roleRect = new Rectangle(10, y + 30, _nameColWidth - 20, 18);

                    g.DrawString(emp.FullName, nameFont, nameBrush, nameRect,
                        new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

                    if (emp.Role != null)
                    {
                        g.DrawString(emp.Role.RoleName, roleFont, roleBrush, roleRect,
                            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    }

                    // vẽ ca
                    DrawShiftRow(g, emp, i, y, days, borderPen, hoverBorderPen);
                }
            }
        }

        private void DrawShiftRow(Graphics g, DTO.Employee emp, int rowIndex, int rowY,
            int days, Pen borderPen, Pen hoverBorderPen)
        {
            using (var statusFont = new Font("Segoe UI", 10F, FontStyle.Bold))
            using (var timeFont = new Font("Segoe UI", 11F, FontStyle.Regular))
            using (var textBrushWhite = new SolidBrush(Color.White))
            using (var plusBrush = new SolidBrush(Color.FromArgb(189, 195, 199)))
            {
                int x = _nameColWidth;

                for (int d = 0; d < days; d++)
                {
                    DateTime date = StartDate.AddDays(d);

                    for (int s = 0; s < 3; s++)
                    {
                        string shiftName = _shiftOrder[s];
                        var timeRange = _shiftTimes[shiftName];

                        DateTime start = date.Date.Add(timeRange.Start);
                        DateTime end = date.Date.Add(timeRange.End);

                        WorkShift shift = WorkShifts.Find(ws =>
                            ws.EmployeeID == emp.EmployeeID &&
                            ws.StartTime >= start &&
                            ws.StartTime < end);

                        Rectangle rect = new Rectangle(x, rowY, _shiftColWidth, _rowHeight);

                        if (shift != null)
                        {
                            Color statusColor;
                            if (!_statusColors.TryGetValue(shift.Status ?? "", out statusColor))
                                statusColor = Color.Gray;

                            using (var bg = new SolidBrush(statusColor))
                                g.FillRectangle(bg, rect);

                            // giờ
                            string timeText = string.Format("{0:HH:mm} - {1:HH:mm}",
                                shift.StartTime, shift.EndTime);
                            Rectangle timeRect = new Rectangle(rect.X + 4, rect.Y + 4,
                                rect.Width - 8, 20);
                            g.DrawString(timeText, timeFont, textBrushWhite, timeRect,
                                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

                            // trạng thái
                            Rectangle statusRect = new Rectangle(rect.X + 4, rect.Y + 24,
                                rect.Width - 8, rect.Height - 28);
                            g.DrawString(shift.Status, statusFont, textBrushWhite, statusRect,
                                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            if (date.Date <= DateTime.Today)
                            {
                                g.FillRectangle(Brushes.WhiteSmoke, rect);
                                g.DrawString("—",
                                    new Font("Segoe UI", 18F, FontStyle.Bold),
                                    new SolidBrush(Color.Gray),
                                    rect,
                                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                            }
                            else
                            {
                                // ô tương lai → click được
                                g.FillRectangle(Brushes.White, rect);
                                g.DrawString("+",
                                    new Font("Segoe UI", 18F, FontStyle.Bold),
                                    plusBrush,
                                    rect,
                                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                            }
                        }

                        g.DrawRectangle(borderPen, rect);

                        // hover border
                        if (rowIndex == _hoverRow && d == _hoverDay && s == _hoverShift)
                        {
                            g.DrawRectangle(hoverBorderPen, rect);
                        }

                        x += _shiftColWidth;
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var logicalPoint = new Point(e.X - AutoScrollPosition.X, e.Y - AutoScrollPosition.Y);

            int days = (EndDate - StartDate).Days + 1;
            int headerHeight = _headerDateHeight + _headerShiftHeight;

            int newRow = -1;
            int newDay = -1;
            int newShift = -1;

            if (logicalPoint.Y >= headerHeight)
            {
                int yInRows = logicalPoint.Y - headerHeight;
                newRow = yInRows / _rowHeight;

                if (newRow >= 0 && newRow < Employees.Count)
                {
                    if (logicalPoint.X >= _nameColWidth)
                    {
                        int xInShifts = logicalPoint.X - _nameColWidth;
                        int cellIndex = xInShifts / _shiftColWidth;
                        int totalShiftCols = days * 3;

                        if (cellIndex >= 0 && cellIndex < totalShiftCols)
                        {
                            newDay = cellIndex / 3;
                            newShift = cellIndex % 3;
                        }
                    }
                }
            }

            if (newRow != _hoverRow || newDay != _hoverDay || newShift != _hoverShift)
            {
                _hoverRow = newRow;
                _hoverDay = newDay;
                _hoverShift = newShift;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hoverRow = -1;
            _hoverDay = -1;
            _hoverShift = -1;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                return;

            var logicalPoint = new Point(e.X - AutoScrollPosition.X, e.Y - AutoScrollPosition.Y);
            int days = (EndDate - StartDate).Days + 1;
            int headerHeight = _headerDateHeight + _headerShiftHeight;

            if (logicalPoint.Y < headerHeight) return;

            int row = (logicalPoint.Y - headerHeight) / _rowHeight;
            if (row < 0 || row >= Employees.Count) return;

            if (logicalPoint.X < _nameColWidth) return;

            int xInShifts = logicalPoint.X - _nameColWidth;
            int cellIndex = xInShifts / _shiftColWidth;
            int totalShiftCols = days * 3;

            if (cellIndex < 0 || cellIndex >= totalShiftCols) return;

            int dayIndex = cellIndex / 3;
            int shiftIndex = cellIndex % 3;

            DateTime date = StartDate.AddDays(dayIndex);
            string shiftName = _shiftOrder[shiftIndex];
            var timeRange = _shiftTimes[shiftName];

            DateTime start = date.Date.Add(timeRange.Start);
            DateTime end = date.Date.Add(timeRange.End);

            DTO.Employee emp = Employees[row];

            WorkShift shift = WorkShifts.Find(ws =>
                ws.EmployeeID == emp.EmployeeID &&
                ws.StartTime >= start &&
                ws.StartTime < end);

            if (shift == null && date.Date <= DateTime.Today)
                return;

            if (CellClicked != null)
            {
                CellClicked(this, new ShiftCellClickEventArgs
                {
                    Employee = emp,
                    Date = date,
                    ShiftName = shiftName,
                    WorkShift = shift,
                    Button = e.Button
                });
            }
        }
    }
}
