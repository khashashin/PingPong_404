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
        string Verschiebung;

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void BallBewegung()
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

        private void BallVerschieben(string richtung)
        {
            switch (richtung)
            {
                case "li":
                    picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
                    break;

                case "re":
                    picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y);
                    break;

                case "ho":
                    picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
                    break;

                case "ru":
                    picBall.Location = new Point(picBall.Location.X, picBall.Location.Y + 25);
                    break;

                default:
                    break;
            }
        }

        private void Verschieben_Click(Object sender, EventArgs e)
        {
            Verschiebung = Convert.ToString(((Button)sender).Tag);
            BallVerschieben(Verschiebung);
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            BallBewegung();
        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {
            vsbSchlägerRechts.Maximum = (pnlSpiel.Height - picSchlägerRechts.Height) + vsbSchlägerRechts.LargeChange;
            vsbSchlägerRechts.Value = (pnlSpiel.Height / 2) - (picSchlägerRechts.Height / 2);
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, vsbSchlägerRechts.Value);

            lblText.Text = "Tasstatursteuerung:\n" +
                "Taste\n" +
                "H          Horizontale Flugrichtung umkehren\n" +
                "V          Vertikale Flugrichtung umkehren\n" +
                "P          Spiel pausieren\n" +
                "S          Spiel weiterlaufen lassen";
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, vsbSchlägerRechts.Value);
        }

        private void frmPingPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                x = -x;
            }
            else if (e.KeyCode == Keys.P)
            {
                tmrSpiel.Stop();
            }
            else if (e.KeyCode == Keys.S)
            {
                tmrSpiel.Start();
            }
            else if (e.KeyCode == Keys.V)
            {
                y = -y;
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        Verschiebung = "ho";
                        break;

                    case Keys.Down:
                        Verschiebung = "ru";
                        break;

                    case Keys.Left:
                        Verschiebung = "li";
                        break;

                    case Keys.Right:
                        Verschiebung = "re";
                        break;

                    default:
                        break;
                }
                BallVerschieben(Verschiebung);
            }
        }
    }
}
