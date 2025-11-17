using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace UI.SeatManagement
{
    public partial class SeatManagementUC : UserControl
    {
        private int _roomId;
        private SeatBLL _seatBLL = new SeatBLL();
        public SeatManagementUC(int roomID)
        {
            _roomId = roomID;
            InitializeComponent();
        }
    }
}
