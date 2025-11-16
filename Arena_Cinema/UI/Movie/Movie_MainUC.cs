using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Movie
{
    public partial class Movie_MainUC : UserControl
    {
        private bool isFirstLoad = true;
        private Home _home;
        private DTO.Employee _employee;

        public Movie_MainUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            this.Load += Movie_MainUC_Load;
            this._home = form;
        }

        private void Movie_MainUC_Load(object sender, EventArgs e)
        {
            // Lắng nghe resize để điều chỉnh margin động
            this.SizeChanged += (s, ev) => AdjustCardMargins();
            panel_movie.SizeChanged += (s, ev) => AdjustCardMargins();

            // QUAN TRỌNG: Delay nhiều hơn để đảm bảo control đã render xong
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((state) =>
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        AdjustCardMargins();
                        isFirstLoad = false;
                    }));
                    timer?.Dispose();
                }
            }, null, 100, System.Threading.Timeout.Infinite); // Delay 100ms
        }

        private void AdjustCardMargins()
        {
            if (moviesContainer == null || !moviesContainer.IsHandleCreated)
                return;

            var cards = moviesContainer.Controls
                .OfType<ReaLTaiizor.Controls.MaterialCard>()
                .ToList();

            if (cards.Count == 0)
                return;

            // Lấy width thực tế
            int containerWidth = panel_movie.ClientSize.Width;

            if (containerWidth <= 0)
            {
                System.Diagnostics.Debug.WriteLine("Container width = 0, skipping...");
                return;
            }
            int panelPadding = panel_movie.Padding.Left + panel_movie.Padding.Right;
            int flowPadding = moviesContainer.Padding.Left + moviesContainer.Padding.Right;
            int availableWidth = containerWidth - panelPadding - flowPadding - 25;

 
            int cardWidth = cards[0].Width;

          
            int cardsPerRow = 4;
            int minMargin = 6; // Margin tối thiểu


            int minTotalWidth = (cardsPerRow * cardWidth) + (minMargin * 2 * cardsPerRow);

            System.Diagnostics.Debug.WriteLine($"Need for 4 cards: {minTotalWidth}px");

       
            if (minTotalWidth > availableWidth)
            {
                cardsPerRow = 3;
                minTotalWidth = (cardsPerRow * cardWidth) + (minMargin * 2 * cardsPerRow);
                System.Diagnostics.Debug.WriteLine($"Reduced to 3 cards, need: {minTotalWidth}px");

                if (minTotalWidth > availableWidth)
                {
                    cardsPerRow = 2;
                    System.Diagnostics.Debug.WriteLine($"Reduced to 2 cards");
                }
            }

            int totalCardWidth = cardsPerRow * cardWidth;
            int remainingSpace = availableWidth - totalCardWidth;

       
            int calculatedMargin = remainingSpace / (cardsPerRow * 2);

       
            int finalMargin = Math.Max(6, Math.Min(calculatedMargin, 35));


    
            moviesContainer.SuspendLayout();
            try
            {
                foreach (var card in cards)
                {
                    card.Margin = new Padding(finalMargin);
                }
            }
            finally
            {
                moviesContainer.ResumeLayout(true);
                moviesContainer.PerformLayout();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new AddMovieUC(this._home, this._employee));


        }
    }
}