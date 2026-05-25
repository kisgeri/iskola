namespace Fuggohidak
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hidakLb = new System.Windows.Forms.ListBox();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.helytxt = new System.Windows.Forms.TextBox();
            this.orszagtxt = new System.Windows.Forms.TextBox();
            this.hossztxt = new System.Windows.Forms.TextBox();
            this.evtxt = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.ketezerelot = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.darabTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hidakLb
            // 
            this.hidakLb.FormattingEnabled = true;
            this.hidakLb.Location = new System.Drawing.Point(12, 27);
            this.hidakLb.Name = "hidakLb";
            this.hidakLb.Size = new System.Drawing.Size(438, 446);
            this.hidakLb.TabIndex = 1;
            this.hidakLb.SelectedIndexChanged += new System.EventHandler(this.hidakLb_SelectedIndexChanged);
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            this.fájlToolStripMenuItem.Click += new System.EventHandler(this.fájlToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.darabTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.ketezerelot);
            this.groupBox1.Location = new System.Drawing.Point(12, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hidak száma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hely:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ország:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hossz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Év:";
            // 
            // helytxt
            // 
            this.helytxt.Location = new System.Drawing.Point(547, 74);
            this.helytxt.Name = "helytxt";
            this.helytxt.Size = new System.Drawing.Size(100, 20);
            this.helytxt.TabIndex = 7;
            // 
            // orszagtxt
            // 
            this.orszagtxt.Location = new System.Drawing.Point(547, 138);
            this.orszagtxt.Name = "orszagtxt";
            this.orszagtxt.Size = new System.Drawing.Size(100, 20);
            this.orszagtxt.TabIndex = 8;
            // 
            // hossztxt
            // 
            this.hossztxt.Location = new System.Drawing.Point(547, 205);
            this.hossztxt.Name = "hossztxt";
            this.hossztxt.Size = new System.Drawing.Size(100, 20);
            this.hossztxt.TabIndex = 9;
            // 
            // evtxt
            // 
            this.evtxt.Location = new System.Drawing.Point(547, 270);
            this.evtxt.Name = "evtxt";
            this.evtxt.Size = new System.Drawing.Size(100, 20);
            this.evtxt.TabIndex = 10;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(547, 652);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Kilépés";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ketezerelot
            // 
            this.ketezerelot.AutoSize = true;
            this.ketezerelot.Location = new System.Drawing.Point(36, 42);
            this.ketezerelot.Name = "ketezerelot";
            this.ketezerelot.Size = new System.Drawing.Size(98, 17);
            this.ketezerelot.TabIndex = 0;
            this.ketezerelot.TabStop = true;
            this.ketezerelot.Text = "2000 előtt épült";
            this.ketezerelot.UseVisualStyleBackColor = true;
            this.ketezerelot.CheckedChanged += new System.EventHandler(this.ketezerelot_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2000-ben vagy utána";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "darab";
            // 
            // darabTxt
            // 
            this.darabTxt.Location = new System.Drawing.Point(36, 169);
            this.darabTxt.Name = "darabTxt";
            this.darabTxt.Size = new System.Drawing.Size(100, 20);
            this.darabTxt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 813);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.evtxt);
            this.Controls.Add(this.hossztxt);
            this.Controls.Add(this.orszagtxt);
            this.Controls.Add(this.helytxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hidakLb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Függőhidak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ListBox hidakLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox helytxt;
        private System.Windows.Forms.TextBox darabTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ketezerelot;
        private System.Windows.Forms.TextBox orszagtxt;
        private System.Windows.Forms.TextBox hossztxt;
        private System.Windows.Forms.TextBox evtxt;
        private System.Windows.Forms.Button exit;
    }
}

