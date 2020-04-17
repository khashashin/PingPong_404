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

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void Bewegung()
        {
            picBall.Location = new Point(picBall.Location.X + x, picBall.Location.Y + y);

            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                x = -x;
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

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            Bewegung();
        }
    }
}
