using System;
using System.Collections.Generic;
using System.Linq;

namespace UI.PayOSMethod
{
    /// <summary>
    /// ✅ Quản lý mapping OrderCode → InvoiceID trong memory
    /// </summary>
    public class PaymentMappingManager
    {
        // Singleton pattern
        private static PaymentMappingManager _instance;
        private static readonly object _lock = new object();

        // Dictionary lưu mapping
        private Dictionary<long, PaymentMapping> _mappings;

        private PaymentMappingManager()
        {
            _mappings = new Dictionary<long, PaymentMapping>();
        }

        public static PaymentMappingManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PaymentMappingManager();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Thêm mapping mới
        /// </summary>
        public void AddMapping(long orderCode, Guid invoiceID, int amount)
        {
            lock (_lock)
            {
                if (_mappings.ContainsKey(orderCode))
                {
                    Console.WriteLine($"⚠️ Mapping already exists for OrderCode: {orderCode}");
                    return;
                }

                _mappings[orderCode] = new PaymentMapping
                {
                    OrderCode = orderCode,
                    InvoiceID = invoiceID,
                    Amount = amount,
                    CreatedAt = DateTime.Now
                };

                Console.WriteLine($"✅ Added mapping: OrderCode {orderCode} → InvoiceID {invoiceID}");
                Console.WriteLine($"   Total mappings: {_mappings.Count}");
            }
        }

        /// <summary>
        /// Lấy InvoiceID từ OrderCode
        /// </summary>
        public Guid? GetInvoiceID(long orderCode)
        {
            lock (_lock)
            {
                if (_mappings.ContainsKey(orderCode))
                {
                    var mapping = _mappings[orderCode];
                    Console.WriteLine($"✅ Found mapping: OrderCode {orderCode} → InvoiceID {mapping.InvoiceID}");
                    return mapping.InvoiceID;
                }

                Console.WriteLine($"❌ No mapping found for OrderCode: {orderCode}");
                return null;
            }
        }

        /// <summary>
        /// Xóa mapping (sau khi xử lý xong)
        /// </summary>
        public void RemoveMapping(long orderCode)
        {
            lock (_lock)
            {
                if (_mappings.ContainsKey(orderCode))
                {
                    _mappings.Remove(orderCode);
                    Console.WriteLine($"🗑️ Removed mapping for OrderCode: {orderCode}");
                }
            }
        }

        /// <summary>
        /// Lấy tất cả mapping (for debugging)
        /// </summary>
        public List<PaymentMapping> GetAllMappings()
        {
            lock (_lock)
            {
                return _mappings.Values.ToList();
            }
        }

        /// <summary>
        /// Xóa mapping cũ (quá 1 giờ)
        /// </summary>
        public void CleanupOldMappings()
        {
            lock (_lock)
            {
                var oneHourAgo = DateTime.Now.AddHours(-1);
                var oldMappings = _mappings.Where(m => m.Value.CreatedAt < oneHourAgo)
                                           .Select(m => m.Key)
                                           .ToList();

                foreach (var orderCode in oldMappings)
                {
                    _mappings.Remove(orderCode);
                    Console.WriteLine($"🗑️ Cleaned up old mapping: OrderCode {orderCode}");
                }

                if (oldMappings.Count > 0)
                {
                    Console.WriteLine($"🧹 Cleaned up {oldMappings.Count} old mappings");
                }
            }
        }
    }

    /// <summary>
    /// DTO cho payment mapping
    /// </summary>
    public class PaymentMapping
    {
        public long OrderCode { get; set; }
        public Guid InvoiceID { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}