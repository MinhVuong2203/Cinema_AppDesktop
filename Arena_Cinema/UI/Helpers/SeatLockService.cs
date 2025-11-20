using System;
using System.Threading;
using DAL;

namespace UI.Helpers
{
    /// <summary>
    /// Background service tự động unlock ghế hết hạn
    /// Chạy định kỳ mỗi 1 phút
    /// </summary>
    public class SeatLockService
    {
        private static SeatLockService _instance;
        private Timer _timer;
        private SeatLockDAL _seatLockDAL;

        private SeatLockService()
        {
            _seatLockDAL = new SeatLockDAL();
            StartAutoUnlockService();
        }

        public static SeatLockService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatLockService();
                return _instance;
            }
        }

        private void StartAutoUnlockService()
        {
            // Chạy mỗi 1 phút để auto-unlock ghế hết hạn
            _timer = new Timer(AutoUnlockCallback, null, 0, 60000);
            Console.WriteLine("[SeatLockService] Started - Auto-unlock every 1 minute");
        }

        private void AutoUnlockCallback(object state)
        {
            try
            {
                int unlockedCount = _seatLockDAL.AutoUnlockExpiredSeats();
                if (unlockedCount > 0)
                {
                    Console.WriteLine($"[SeatLockService] Auto-unlocked {unlockedCount} expired seats");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SeatLockService] Auto-unlock error: {ex.Message}");
            }
        }

        public void Stop()
        {
            _timer?.Dispose();
            Console.WriteLine("[SeatLockService] Stopped");
        }
    }
}