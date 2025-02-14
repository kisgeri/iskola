
namespace kaszinooooo
{
    partial class kocka_poker
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
            this.cim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.szam1 = new System.Windows.Forms.Label();
            this.szam2 = new System.Windows.Forms.Label();
            this.szam3 = new System.Windows.Forms.Label();
            this.szam5 = new System.Windows.Forms.Label();
            this.szam4 = new System.Windows.Forms.Label();
            this.parok_szama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cim.Location = new System.Drawing.Point(300, 10);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(193, 19);
            this.cim.TabIndex = 0;
            this.cim.Text = "Kaszinó szofter v.0.0.0.1";
            this.cim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(300, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pörgetés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // szam1
            // 
            this.szam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam1.Location = new System.Drawing.Point(120, 180);
            this.szam1.Margin = new System.Windows.Forms.Padding(0);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(50, 80);
            this.szam1.TabIndex = 0;
            this.szam1.Text = "0";
            this.szam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.szam1.Visible = false;
            // 
            // szam2
            // 
            this.szam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam2.Location = new System.Drawing.Point(240, 180);
            this.szam2.Margin = new System.Windows.Forms.Padding(0);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(50, 80);
            this.szam2.TabIndex = 2;
            this.szam2.Text = "0";
            this.szam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.szam2.Visible = false;
            // 
            // szam3
            // 
            this.szam3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam3.Location = new System.Drawing.Point(360, 180);
            this.szam3.Margin = new System.Windows.Forms.Padding(0);
            this.szam3.Name = "szam3";
            this.szam3.Size = new System.Drawing.Size(50, 80);
            this.szam3.TabIndex = 3;
            this.szam3.Text = "0";
            this.szam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.szam3.Visible = false;
            // 
            // szam5
            // 
            this.szam5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam5.Location = new System.Drawing.Point(600, 180);
            this.szam5.Margin = new System.Windows.Forms.Padding(0);
            this.szam5.Name = "szam5";
            this.szam5.Size = new System.Drawing.Size(50, 80);
            this.szam5.TabIndex = 4;
            this.szam5.Text = "0";
            this.szam5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.szam5.Visible = false;
            // 
            // szam4
            // 
            this.szam4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szam4.Location = new System.Drawing.Point(480, 180);
            this.szam4.Margin = new System.Windows.Forms.Padding(0);
            this.szam4.Name = "szam4";
            this.szam4.Size = new System.Drawing.Size(50, 80);
            this.szam4.TabIndex = 5;
            this.szam4.Text = "0";
            this.szam4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.szam4.Visible = false;
            // 
            // parok_szama
            // 
            this.parok_szama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parok_szama.Location = new System.Drawing.Point(300, 330);
            this.parok_szama.Name = "parok_szama";
            this.parok_szama.Size = new System.Drawing.Size(200, 20);
            this.parok_szama.TabIndex = 6;
            this.parok_szama.Text = "Párok száma:";
            this.parok_szama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kocka_poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.parok_szama);
            this.Controls.Add(this.szam4);
            this.Controls.Add(this.szam5);
            this.Controls.Add(this.szam3);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cim);
            this.Name = "kocka_poker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label szam1;
        private System.Windows.Forms.Label szam2;
        private System.Windows.Forms.Label szam3;
        private System.Windows.Forms.Label szam5;
        private System.Windows.Forms.Label szam4;
        private System.Windows.Forms.Label parok_szama;
    }
}

