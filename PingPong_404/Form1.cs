using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_404
{
    public partial class frmPingPong : Form
    {
        public frmPingPong()
        {
            InitializeComponent();
        }

        int x = 5;
        int y = 2;
        int Punkte = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void Bewegung()
        {
            picBall.Location = new Point(picBall.Location.X + x, picBall.Location.Y + y);

            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerRechts.Width &&
                picBall.Location.Y >= picSchlägerRechts.Location.Y - picBall.Height &&
                picBall.Location.Y <= picSchlägerRechts.Location.Y + picSchlägerRechts.Height)
            {
                x = -x;
                PunkteErhöhen(10);
            }
            
            if (picBall.Location.X <= 0)
            {
                x = -x;
            }

            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                y = -y;
            }
            else if (picBall.Location.Y <= 0)
            {
                y = -y;
            }
        }

        private void PunkteErhöhen(int Anzahl)
        {
            Punkte = Punkte + Anzahl;
            txtPunkte.Text = Punkte.ToString();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            Bewegung();
        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {
            vsbSchlägerRechts.Maximum = (pnlSpiel.Height - picSchlägerRechts.Height) + vsbSchlägerRechts.LargeChange;
            vsbSchlägerRechts.Value = (pnlSpiel.Height / 2) - (picSchlägerRechts.Height / 2);
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, vsbSchlägerRechts.Value);
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, vsbSchlägerRechts.Value);
        }
    }
}
