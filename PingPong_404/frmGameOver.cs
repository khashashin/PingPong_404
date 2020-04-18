using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PingPong_404.Properties;

namespace PingPong_404
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            lblErgebnisse.Text = File.ReadAllText("C:\\Users\\Joel Graf\\source\\repos\\PingPong_404\\PingPong_404\\Rangliste.txt");
        }

        private void btnEintragen_Click(object sender, EventArgs e)
        {
            File.AppendAllText("C:\\Users\\Joel Graf\\source\\repos\\PingPong_404\\PingPong_404\\Rangliste.txt", lblAnzahlPunkte.Text + "      |       " + txtName.Text + "     |       " + DateTime.Now.ToString("DDMMYYYY") + Environment.NewLine);
            lblErgebnisse.Text = File.ReadAllText("C:\\Users\\Joel Graf\\source\\repos\\PingPong_404\\PingPong_404\\Rangliste.txt");
        }

        public void SetzePunkte(int Punkte)
        {
            lblAnzahlPunkte.Text = Punkte.ToString();
        }
    }
}