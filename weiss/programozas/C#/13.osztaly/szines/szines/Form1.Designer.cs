namespace szines
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxblue = new System.Windows.Forms.TextBox();
            this.textBoxgreen = new System.Windows.Forms.TextBox();
            this.textBoxred = new System.Windows.Forms.TextBox();
            this.szinPnl = new System.Windows.Forms.Panel();
            this.blueHSb = new System.Windows.Forms.HScrollBar();
            this.greenHSb = new System.Windows.Forms.HScrollBar();
            this.redHSb = new System.Windows.Forms.HScrollBar();
            this.bluelabel = new System.Windows.Forms.Label();
            this.greenlabel = new System.Windows.Forms.Label();
            this.redlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mutasdBtn = new System.Windows.Forms.Button();
            this.utvonaltxt = new System.Windows.Forms.TextBox();
            this.kepPb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kepPb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxblue);
            this.groupBox1.Controls.Add(this.textBoxgreen);
            this.groupBox1.Controls.Add(this.textBoxred);
            this.groupBox1.Controls.Add(this.szinPnl);
            this.groupBox1.Controls.Add(this.blueHSb);
            this.groupBox1.Controls.Add(this.greenHSb);
            this.groupBox1.Controls.Add(this.redHSb);
            this.groupBox1.Controls.Add(this.bluelabel);
            this.groupBox1.Controls.Add(this.greenlabel);
            this.groupBox1.Controls.Add(this.redlabel);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kezelok";
            // 
            // textBoxblue
            // 
            this.textBoxblue.Location = new System.Drawing.Point(446, 96);
            this.textBoxblue.Name = "textBoxblue";
            this.textBoxblue.Size = new System.Drawing.Size(100, 20);
            this.textBoxblue.TabIndex = 9;
            this.textBoxblue.Text = "0";
            this.textBoxblue.TextChanged += new System.EventHandler(this.textBoxblue_TextChanged);
            // 
            // textBoxgreen
            // 
            this.textBoxgreen.Location = new System.Drawing.Point(446, 60);
            this.textBoxgreen.Name = "textBoxgreen";
            this.textBoxgreen.Size = new System.Drawing.Size(100, 20);
            this.textBoxgreen.TabIndex = 8;
            this.textBoxgreen.Text = "0";
            this.textBoxgreen.TextChanged += new System.EventHandler(this.textBoxgreen_TextChanged);
            // 
            // textBoxred
            // 
            this.textBoxred.Location = new System.Drawing.Point(446, 28);
            this.textBoxred.Name = "textBoxred";
            this.textBoxred.Size = new System.Drawing.Size(100, 20);
            this.textBoxred.TabIndex = 7;
            this.textBoxred.Text = "0";
            this.textBoxred.TextChanged += new System.EventHandler(this.textBoxred_TextChanged);
            // 
            // szinPnl
            // 
            this.szinPnl.BackColor = System.Drawing.SystemColors.Desktop;
            this.szinPnl.Location = new System.Drawing.Point(566, 28);
            this.szinPnl.Name = "szinPnl";
            this.szinPnl.Size = new System.Drawing.Size(200, 100);
            this.szinPnl.TabIndex = 6;
            this.szinPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // blueHSb
            // 
            this.blueHSb.Location = new System.Drawing.Point(80, 96);
            this.blueHSb.Maximum = 255;
            this.blueHSb.Name = "blueHSb";
            this.blueHSb.Size = new System.Drawing.Size(352, 20);
            this.blueHSb.TabIndex = 5;
            this.blueHSb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueHSb_Scroll);
            // 
            // greenHSb
            // 
            this.greenHSb.Location = new System.Drawing.Point(80, 60);
            this.greenHSb.Maximum = 255;
            this.greenHSb.Name = "greenHSb";
            this.greenHSb.Size = new System.Drawing.Size(352, 20);
            this.greenHSb.TabIndex = 4;
            this.greenHSb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenHSb_Scroll);
            // 
            // redHSb
            // 
            this.redHSb.Location = new System.Drawing.Point(80, 28);
            this.redHSb.Maximum = 255;
            this.redHSb.Name = "redHSb";
            this.redHSb.Size = new System.Drawing.Size(352, 20);
            this.redHSb.TabIndex = 3;
            this.redHSb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScrollBarred_Scroll);
            // 
            // bluelabel
            // 
            this.bluelabel.AutoSize = true;
            this.bluelabel.Location = new System.Drawing.Point(8, 99);
            this.bluelabel.Name = "bluelabel";
            this.bluelabel.Size = new System.Drawing.Size(35, 13);
            this.bluelabel.TabIndex = 2;
            this.bluelabel.Text = "BLUE";
            // 
            // greenlabel
            // 
            this.greenlabel.AutoSize = true;
            this.greenlabel.Location = new System.Drawing.Point(8, 63);
            this.greenlabel.Name = "greenlabel";
            this.greenlabel.Size = new System.Drawing.Size(45, 13);
            this.greenlabel.TabIndex = 1;
            this.greenlabel.Text = "GREEN";
            // 
            // redlabel
            // 
            this.redlabel.AutoSize = true;
            this.redlabel.Location = new System.Drawing.Point(8, 31);
            this.redlabel.Name = "redlabel";
            this.redlabel.Size = new System.Drawing.Size(30, 13);
            this.redlabel.TabIndex = 0;
            this.redlabel.Text = "RED";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kepPb);
            this.groupBox2.Controls.Add(this.utvonaltxt);
            this.groupBox2.Controls.Add(this.mutasdBtn);
            this.groupBox2.Location = new System.Drawing.Point(4, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "képmegjelenítés";
            // 
            // mutasdBtn
            // 
            this.mutasdBtn.Location = new System.Drawing.Point(691, 35);
            this.mutasdBtn.Name = "mutasdBtn";
            this.mutasdBtn.Size = new System.Drawing.Size(75, 23);
            this.mutasdBtn.TabIndex = 0;
            this.mutasdBtn.Text = "mutasd";
            this.mutasdBtn.UseVisualStyleBackColor = true;
            this.mutasdBtn.Click += new System.EventHandler(this.mutasdBtn_Click);
            // 
            // utvonaltxt
            // 
            this.utvonaltxt.Location = new System.Drawing.Point(11, 35);
            this.utvonaltxt.Name = "utvonaltxt";
            this.utvonaltxt.Size = new System.Drawing.Size(646, 20);
            this.utvonaltxt.TabIndex = 1;
            // 
            // kepPb
            // 
            this.kepPb.Location = new System.Drawing.Point(11, 96);
            this.kepPb.Name = "kepPb";
            this.kepPb.Size = new System.Drawing.Size(772, 345);
            this.kepPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kepPb.TabIndex = 2;
            this.kepPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "szines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kepPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxblue;
        private System.Windows.Forms.TextBox textBoxgreen;
        private System.Windows.Forms.TextBox textBoxred;
        private System.Windows.Forms.Panel szinPnl;
        private System.Windows.Forms.HScrollBar blueHSb;
        private System.Windows.Forms.HScrollBar greenHSb;
        private System.Windows.Forms.HScrollBar redHSb;
        private System.Windows.Forms.Label bluelabel;
        private System.Windows.Forms.Label greenlabel;
        private System.Windows.Forms.Label redlabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox kepPb;
        private System.Windows.Forms.TextBox utvonaltxt;
        private System.Windows.Forms.Button mutasdBtn;
    }
}

