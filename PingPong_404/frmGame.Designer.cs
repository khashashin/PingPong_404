namespace PingPong_404
{
    partial class frmPingPong
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPingPong));
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnRunter = new System.Windows.Forms.Button();
            this.grpSteuerung = new System.Windows.Forms.GroupBox();
            this.rdbSchläger = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.grpSteuerung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerRechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(12, 12);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(541, 311);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(532, 145);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlägerRechts.TabIndex = 1;
            this.picSchlägerRechts.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(291, 145);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(25, 25);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 20;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(560, 12);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(24, 311);
            this.vsbSchlägerRechts.TabIndex = 2;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Location = new System.Drawing.Point(13, 348);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(44, 13);
            this.lblPunkte.TabIndex = 3;
            this.lblPunkte.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(99, 345);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 20);
            this.txtPunkte.TabIndex = 4;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(96, 372);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(291, 103);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Anleitung";
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Image = ((System.Drawing.Image)(resources.GetObject("btnHoch.Image")));
            this.btnHoch.Location = new System.Drawing.Point(672, 149);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(45, 25);
            this.btnHoch.TabIndex = 6;
            this.btnHoch.Tag = "ho";
            this.btnHoch.UseVisualStyleBackColor = false;
            this.btnHoch.Click += new System.EventHandler(this.Verschieben_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Image = ((System.Drawing.Image)(resources.GetObject("btnLinks.Image")));
            this.btnLinks.Location = new System.Drawing.Point(639, 180);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(35, 25);
            this.btnLinks.TabIndex = 7;
            this.btnLinks.Tag = "li";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.Verschieben_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Image = ((System.Drawing.Image)(resources.GetObject("btnRechts.Image")));
            this.btnRechts.Location = new System.Drawing.Point(713, 180);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(35, 25);
            this.btnRechts.TabIndex = 8;
            this.btnRechts.Tag = "re";
            this.btnRechts.UseVisualStyleBackColor = false;
            this.btnRechts.Click += new System.EventHandler(this.Verschieben_Click);
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.White;
            this.btnRunter.Image = ((System.Drawing.Image)(resources.GetObject("btnRunter.Image")));
            this.btnRunter.Location = new System.Drawing.Point(672, 211);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(45, 25);
            this.btnRunter.TabIndex = 9;
            this.btnRunter.Tag = "ru";
            this.btnRunter.UseVisualStyleBackColor = false;
            this.btnRunter.Click += new System.EventHandler(this.Verschieben_Click);
            // 
            // grpSteuerung
            // 
            this.grpSteuerung.Controls.Add(this.rdbSchläger);
            this.grpSteuerung.Controls.Add(this.rdbBall);
            this.grpSteuerung.Location = new System.Drawing.Point(588, 375);
            this.grpSteuerung.Name = "grpSteuerung";
            this.grpSteuerung.Size = new System.Drawing.Size(200, 100);
            this.grpSteuerung.TabIndex = 10;
            this.grpSteuerung.TabStop = false;
            this.grpSteuerung.Text = "Wahl der Steuerung";
            // 
            // rdbSchläger
            // 
            this.rdbSchläger.AutoSize = true;
            this.rdbSchläger.Location = new System.Drawing.Point(7, 44);
            this.rdbSchläger.Name = "rdbSchläger";
            this.rdbSchläger.Size = new System.Drawing.Size(114, 17);
            this.rdbSchläger.TabIndex = 1;
            this.rdbSchläger.Text = "Schlägersteuerung";
            this.rdbSchläger.UseVisualStyleBackColor = true;
            this.rdbSchläger.CheckedChanged += new System.EventHandler(this.rdbSchläger_CheckedChanged);
            // 
            // rdbBall
            // 
            this.rdbBall.AutoSize = true;
            this.rdbBall.Checked = true;
            this.rdbBall.Location = new System.Drawing.Point(7, 20);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(89, 17);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.TabStop = true;
            this.rdbBall.Text = "Ballsteuerung";
            this.rdbBall.UseVisualStyleBackColor = true;
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.grpSteuerung);
            this.Controls.Add(this.btnRunter);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.KeyPreview = true;
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPingPong_KeyUp);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.grpSteuerung.ResumeLayout(false);
            this.grpSteuerung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picSchlägerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnRunter;
        private System.Windows.Forms.GroupBox grpSteuerung;
        private System.Windows.Forms.RadioButton rdbSchläger;
        private System.Windows.Forms.RadioButton rdbBall;
    }
}

    