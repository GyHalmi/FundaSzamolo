
namespace FundaSzamolo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVizsgalt = new System.Windows.Forms.TextBox();
            this.txtKezdet = new System.Windows.Forms.TextBox();
            this.txtMegtakarit = new System.Windows.Forms.TextBox();
            this.txtTamogat = new System.Windows.Forms.TextBox();
            this.txtBefiz = new System.Windows.Forms.TextBox();
            this.txtHonapok = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "szerződések kezdete: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "vizsgált időpont:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "befizetett összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "állami támogatás:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "eltelt hónapok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "megtakarítás összege:";
            // 
            // txtVizsgalt
            // 
            this.txtVizsgalt.Location = new System.Drawing.Point(152, 50);
            this.txtVizsgalt.Name = "txtVizsgalt";
            this.txtVizsgalt.Size = new System.Drawing.Size(100, 20);
            this.txtVizsgalt.TabIndex = 7;
            // 
            // txtKezdet
            // 
            this.txtKezdet.Location = new System.Drawing.Point(152, 26);
            this.txtKezdet.Name = "txtKezdet";
            this.txtKezdet.Size = new System.Drawing.Size(100, 20);
            this.txtKezdet.TabIndex = 8;
            // 
            // txtMegtakarit
            // 
            this.txtMegtakarit.Location = new System.Drawing.Point(152, 199);
            this.txtMegtakarit.Name = "txtMegtakarit";
            this.txtMegtakarit.Size = new System.Drawing.Size(100, 20);
            this.txtMegtakarit.TabIndex = 9;
            // 
            // txtTamogat
            // 
            this.txtTamogat.Location = new System.Drawing.Point(152, 175);
            this.txtTamogat.Name = "txtTamogat";
            this.txtTamogat.Size = new System.Drawing.Size(100, 20);
            this.txtTamogat.TabIndex = 10;
            // 
            // txtBefiz
            // 
            this.txtBefiz.Location = new System.Drawing.Point(152, 151);
            this.txtBefiz.Name = "txtBefiz";
            this.txtBefiz.Size = new System.Drawing.Size(100, 20);
            this.txtBefiz.TabIndex = 11;
            // 
            // txtHonapok
            // 
            this.txtHonapok.Location = new System.Drawing.Point(152, 127);
            this.txtHonapok.Name = "txtHonapok";
            this.txtHonapok.Size = new System.Drawing.Size(100, 20);
            this.txtHonapok.TabIndex = 12;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(87, 88);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(95, 23);
            this.btnSzamol.TabIndex = 13;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 249);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.txtHonapok);
            this.Controls.Add(this.txtBefiz);
            this.Controls.Add(this.txtTamogat);
            this.Controls.Add(this.txtMegtakarit);
            this.Controls.Add(this.txtKezdet);
            this.Controls.Add(this.txtVizsgalt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Funda számoló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVizsgalt;
        private System.Windows.Forms.TextBox txtKezdet;
        private System.Windows.Forms.TextBox txtMegtakarit;
        private System.Windows.Forms.TextBox txtTamogat;
        private System.Windows.Forms.TextBox txtBefiz;
        private System.Windows.Forms.TextBox txtHonapok;
        private System.Windows.Forms.Button btnSzamol;
    }
}

