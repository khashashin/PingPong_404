namespace PingPong_404
{
    partial class frmGameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPunkte = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnzahlPunkte = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblErgebnisse = new System.Windows.Forms.Label();
            this.btnEintragen = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Location = new System.Drawing.Point(12, 13);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(41, 13);
            this.lblPunkte.TabIndex = 0;
            this.lblPunkte.Text = "Punkte";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAnzahlPunkte
            // 
            this.lblAnzahlPunkte.AutoSize = true;
            this.lblAnzahlPunkte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzahlPunkte.Location = new System.Drawing.Point(15, 33);
            this.lblAnzahlPunkte.Name = "lblAnzahlPunkte";
            this.lblAnzahlPunkte.Size = new System.Drawing.Size(2, 15);
            this.lblAnzahlPunkte.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblErgebnisse
            // 
            this.lblErgebnisse.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblErgebnisse.Location = new System.Drawing.Point(12, 62);
            this.lblErgebnisse.Name = "lblErgebnisse";
            this.lblErgebnisse.Size = new System.Drawing.Size(346, 350);
            this.lblErgebnisse.TabIndex = 4;
            // 
            // btnEintragen
            // 
            this.btnEintragen.Location = new System.Drawing.Point(283, 28);
            this.btnEintragen.Name = "btnEintragen";
            this.btnEintragen.Size = new System.Drawing.Size(75, 23);
            this.btnEintragen.TabIndex = 5;
            this.btnEintragen.Text = "Eintragen";
            this.btnEintragen.UseVisualStyleBackColor = true;
            this.btnEintragen.Click += new System.EventHandler(this.btnEintragen_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(283, 415);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(75, 23);
            this.btnSchliessen.TabIndex = 6;
            this.btnSchliessen.Text = "Zurück";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnEintragen);
            this.Controls.Add(this.lblErgebnisse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAnzahlPunkte);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPunkte);
            this.Name = "frmGameOver";
            this.Text = "Game Over!";
            this.Load += new System.EventHandler(this.frmGameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAnzahlPunkte;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblErgebnisse;
        private System.Windows.Forms.Button btnEintragen;
        private System.Windows.Forms.Button btnSchliessen;
    }
}