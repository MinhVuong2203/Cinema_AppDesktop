using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.Helpers
{
    /// <summary>
    /// Quản lý việc in hóa đơn tổng và các vé riêng lẻ
    /// </summary>
    public class PrintManager
    {
        private readonly CinemaDBContext _context;
        private readonly Guid _invoiceID;
        private const string INVOICE_FOLDER = "InvoiceFolder";

        public PrintManager(Guid invoiceID)
        {
            _context = new CinemaDBContext();
            _invoiceID = invoiceID;
        }

        /// <summary>
        /// Lưu hóa đơn và tất cả các vé ra file tự động
        /// </summary>
        public void SaveAll()
        {
            try
            {
                // Lấy đường dẫn thư mục project
                string projectPath = GetProjectPath();
                string folderPath = Path.Combine(projectPath, INVOICE_FOLDER);

                // Tạo thư mục nếu chưa có
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                List<string> savedFiles = new List<string>();

                // 1. Lưu hóa đơn tổng
                var invoicePrinter = new InvoicePrintHelper(_invoiceID);
                string invoiceFile = invoicePrinter.SaveToFile(folderPath);
                savedFiles.Add(Path.GetFileName(invoiceFile));

                // 2. Lưu tất cả các vé
                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == _invoiceID)
                    .ToList();

                foreach (var it in invoiceTickets)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    string ticketFile = ticketPrinter.SaveToFile(folderPath);
                    savedFiles.Add(Path.GetFileName(ticketFile));
                }

                // Hiển thị thông báo thành công
                string message = $"Đã lưu thành công {savedFiles.Count} file vào:\n" +
                                $"{folderPath}\n\n" +
                                $"Các file đã lưu:\n" +
                                string.Join("\n", savedFiles.Take(5));

                if (savedFiles.Count > 5)
                {
                    message += $"\n... và {savedFiles.Count - 5} file khác";
                }

                MessageBox.Show(message, "Lưu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở thư mục chứa file
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy đường dẫn thư mục project
        /// </summary>
        private string GetProjectPath()
        {
            // Lấy đường dẫn của application
            string appPath = Application.StartupPath;

            // Quay lại thư mục project (từ bin\Debug về root)
            DirectoryInfo dir = new DirectoryInfo(appPath);
            while (dir != null && dir.Name != "bin")
            {
                dir = dir.Parent;
            }

            if (dir != null && dir.Parent != null)
            {
                return dir.Parent.FullName;
            }

            // Fallback: dùng thư mục hiện tại
            return appPath;
        }

        /// <summary>
        /// Lưu chỉ các vé PNG
        /// </summary>
        public void SaveTicketsOnly()
        {
            try
            {
                string projectPath = GetProjectPath();
                string folderPath = Path.Combine(projectPath, INVOICE_FOLDER);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == _invoiceID)
                    .ToList();

                if (!invoiceTickets.Any())
                {
                    MessageBox.Show(
                        "Hóa đơn này không có vé xem phim!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                List<string> savedFiles = new List<string>();
                foreach (var it in invoiceTickets)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    string ticketFile = ticketPrinter.SaveToFile(folderPath);
                    savedFiles.Add(Path.GetFileName(ticketFile));
                }

                string message = $"Đã lưu thành công {savedFiles.Count} vé!\n\n" +
                                $"Các file đã lưu:\n" +
                                string.Join("\n", savedFiles.Take(5));

                if (savedFiles.Count > 5)
                {
                    message += $"\n... và {savedFiles.Count - 5} vé khác";
                }

                message += $"\n\nĐường dẫn: {folderPath}";

                MessageBox.Show(message, "Lưu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở thư mục
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lưu chỉ hóa đơn tổng dưới dạng PDF và mở file
        /// </summary>
        public void SaveInvoiceOnly()
        {
            try
            {
                string projectPath = GetProjectPath();
                string folderPath = Path.Combine(projectPath, INVOICE_FOLDER);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var invoicePrinter = new InvoicePrintHelper(_invoiceID);
                string pdfFile = invoicePrinter.SaveToPDF(folderPath);

                MessageBox.Show(
                    $"Đã lưu hóa đơn PDF thành công!\n\n" +
                    $"File: {Path.GetFileName(pdfFile)}\n" +
                    $"Đường dẫn: {folderPath}",
                    "Lưu thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Mở file PDF trực tiếp
                System.Diagnostics.Process.Start(pdfFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn PDF: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ✅ Lưu chỉ các vé dưới dạng PDF và MỞ TẤT CẢ
        /// </summary>
        public void SaveTicketsOnlyPDF()
        {
            try
            {
                string projectPath = GetProjectPath();
                string folderPath = Path.Combine(projectPath, INVOICE_FOLDER);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == _invoiceID)
                    .ToList();

                if (!invoiceTickets.Any())
                {
                    MessageBox.Show(
                        "Hóa đơn này không có vé xem phim!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                List<string> savedFiles = new List<string>();
                List<string> fullPaths = new List<string>(); // ✅ THÊM: Lưu đường dẫn đầy đủ

                foreach (var it in invoiceTickets)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    string ticketFile = ticketPrinter.SaveToPDF(folderPath);
                    savedFiles.Add(Path.GetFileName(ticketFile));
                    fullPaths.Add(ticketFile); // ✅ THÊM: Lưu full path
                }

                string message = $"Đã lưu thành công {savedFiles.Count} vé PDF!\n\n" +
                                $"Các file đã lưu:\n" +
                                string.Join("\n", savedFiles.Take(5));

                if (savedFiles.Count > 5)
                {
                    message += $"\n... và {savedFiles.Count - 5} vé khác";
                }

                message += $"\n\nĐường dẫn: {folderPath}";

                MessageBox.Show(message, "Lưu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ MỞ TẤT CẢ FILE PDF VÉ
                foreach (var filePath in fullPaths)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filePath);
                        System.Threading.Thread.Sleep(300); // Delay 300ms giữa các file để tránh lag
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Không thể mở file {filePath}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu vé PDF: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ✅ Lưu hóa đơn PDF và tất cả các vé PDF, MỞ TẤT CẢ
        /// </summary>
        public void SaveAllPDF()
        {
            try
            {
                string projectPath = GetProjectPath();
                string folderPath = Path.Combine(projectPath, INVOICE_FOLDER);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                List<string> savedFiles = new List<string>();
                List<string> allFilePaths = new List<string>(); // ✅ THÊM: Lưu tất cả đường dẫn

                // 1. Lưu hóa đơn tổng dưới dạng PDF
                var invoicePrinter = new InvoicePrintHelper(_invoiceID);
                string pdfInvoiceFile = invoicePrinter.SaveToPDF(folderPath);
                savedFiles.Add(Path.GetFileName(pdfInvoiceFile));
                allFilePaths.Add(pdfInvoiceFile); // ✅ THÊM

                // 2. Lưu tất cả các vé dưới dạng PDF
                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == _invoiceID)
                    .ToList();

                foreach (var it in invoiceTickets)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    string ticketFile = ticketPrinter.SaveToPDF(folderPath);
                    savedFiles.Add(Path.GetFileName(ticketFile));
                    allFilePaths.Add(ticketFile); // ✅ THÊM
                }

                string message = $"Đã lưu thành công {savedFiles.Count} file PDF vào:\n" +
                                $"{folderPath}\n\n" +
                                $"Các file đã lưu:\n" +
                                string.Join("\n", savedFiles.Take(5));

                if (savedFiles.Count > 5)
                {
                    message += $"\n... và {savedFiles.Count - 5} file khác";
                }

                MessageBox.Show(message, "Lưu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ MỞ TẤT CẢ FILE PDF (HÓA ĐƠN + VÉ)
                foreach (var filePath in allFilePaths)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filePath);
                        System.Threading.Thread.Sleep(300); // Delay 300ms giữa các file
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Không thể mở file {filePath}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file PDF: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// In cả hóa đơn tổng và tất cả các vé riêng lẻ
        /// </summary>
        public void PrintAll()
        {
            try
            {
                var result = MessageBox.Show(
                    "Bạn muốn in:\n\n" +
                    "• Hóa đơn tổng\n" +
                    "• Tất cả các vé xem phim\n\n" +
                    "Tiếp tục?",
                    "Xác nhận in",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                // 1. In hóa đơn tổng
                PrintInvoice();

                // 2. In từng vé
                PrintAllTickets();

                MessageBox.Show(
                    "Đã in xong hóa đơn và vé!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi in: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// In chỉ hóa đơn tổng
        /// </summary>
        public void PrintInvoice()
        {
            var printHelper = new InvoicePrintHelper(_invoiceID);
            printHelper.Print();
        }

        /// <summary>
        /// In tất cả các vé trong hóa đơn
        /// </summary>
        public void PrintAllTickets()
        {
            var invoiceTickets = _context.InvoiceTickets
                .Where(it => it.InvoiceID == _invoiceID)
                .ToList();

            if (!invoiceTickets.Any())
            {
                MessageBox.Show(
                    "Hóa đơn này không có vé xem phim!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int count = 1;
            foreach (var it in invoiceTickets)
            {
                var result = MessageBox.Show(
                    $"In vé {count}/{invoiceTickets.Count}?",
                    "In vé",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    break;

                if (result == DialogResult.Yes)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    ticketPrinter.Print();
                }

                count++;
            }
        }

        /// <summary>
        /// In một vé cụ thể
        /// </summary>
        public void PrintSingleTicket(Guid ticketID)
        {
            var ticketPrinter = new TicketPrintHelper(ticketID, _context);
            ticketPrinter.Print();
        }

        /// <summary>
        /// Lấy danh sách vé trong hóa đơn để hiển thị cho người dùng chọn
        /// </summary>
        public List<TicketInfo> GetTicketsList()
        {
            var result = new List<TicketInfo>();

            var invoiceTickets = _context.InvoiceTickets
                .Where(it => it.InvoiceID == _invoiceID)
                .ToList();

            foreach (var it in invoiceTickets)
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                if (ticket == null) continue;

                var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                var showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == ticket.ShowTimeID);
                var movie = showTime != null ?
                    _context.Movies.FirstOrDefault(m => m.MovieID == showTime.MovieID) : null;

                result.Add(new TicketInfo
                {
                    TicketID = ticket.TicketID,
                    MovieTitle = movie?.Title ?? "N/A",
                    SeatName = seat?.SeatName ?? "N/A",
                    ShowTime = showTime?.StartTime ?? DateTime.MinValue,
                    Price = ticket.Price ?? 0,
                    TicketType = ticket.TicketType
                });
            }

            return result;
        }

        /// <summary>
        /// Class chứa thông tin vé để hiển thị
        /// </summary>
        public class TicketInfo
        {
            public Guid TicketID { get; set; }
            public string MovieTitle { get; set; }
            public string SeatName { get; set; }
            public DateTime ShowTime { get; set; }
            public decimal Price { get; set; }
            public string TicketType { get; set; }

            public override string ToString()
            {
                return $"{MovieTitle} - Ghế {SeatName} - {ShowTime:dd/MM HH:mm}";
            }
        }
    }
}