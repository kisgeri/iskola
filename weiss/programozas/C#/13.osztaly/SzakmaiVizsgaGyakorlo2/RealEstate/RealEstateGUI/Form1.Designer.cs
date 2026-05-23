namespace RealEstateGUI
{
    partial class hirdetesekForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            keresésToolStripMenuItem = new ToolStripMenuItem();
            bezárásToolStripMenuItem = new ToolStripMenuItem();
            nevCb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            telefonTxt = new TextBox();
            KetegoriaTxt = new TextBox();
            szobakTxt = new TextBox();
            alapterTxt = new TextBox();
            EmletTxt = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { keresésToolStripMenuItem, bezárásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(58, 20);
            keresésToolStripMenuItem.Text = "Keresés";
            keresésToolStripMenuItem.Click += keresésToolStripMenuItem_Click;
            // 
            // bezárásToolStripMenuItem
            // 
            bezárásToolStripMenuItem.Name = "bezárásToolStripMenuItem";
            bezárásToolStripMenuItem.Size = new Size(58, 20);
            bezárásToolStripMenuItem.Text = "Bezárás";
            bezárásToolStripMenuItem.Click += bezárásToolStripMenuItem_Click;
            // 
            // nevCb
            // 
            nevCb.DropDownStyle = ComboBoxStyle.DropDownList;
            nevCb.FormattingEnabled = true;
            nevCb.Location = new Point(153, 80);
            nevCb.Name = "nevCb";
            nevCb.Size = new Size(121, 23);
            nevCb.TabIndex = 1;
            nevCb.SelectedIndexChanged += nevCb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 83);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 118);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefonszám:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 152);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Kategória:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 190);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Szobák:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 226);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 6;
            label5.Text = "Alapterülett:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 264);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Emelet:";
            // 
            // telefonTxt
            // 
            telefonTxt.Location = new Point(153, 115);
            telefonTxt.Name = "telefonTxt";
            telefonTxt.ReadOnly = true;
            telefonTxt.Size = new Size(121, 23);
            telefonTxt.TabIndex = 8;
            // 
            // KetegoriaTxt
            // 
            KetegoriaTxt.Location = new Point(153, 149);
            KetegoriaTxt.Name = "KetegoriaTxt";
            KetegoriaTxt.ReadOnly = true;
            KetegoriaTxt.Size = new Size(121, 23);
            KetegoriaTxt.TabIndex = 9;
            // 
            // szobakTxt
            // 
            szobakTxt.Location = new Point(153, 187);
            szobakTxt.Name = "szobakTxt";
            szobakTxt.ReadOnly = true;
            szobakTxt.Size = new Size(121, 23);
            szobakTxt.TabIndex = 10;
            // 
            // alapterTxt
            // 
            alapterTxt.Location = new Point(153, 223);
            alapterTxt.Name = "alapterTxt";
            alapterTxt.ReadOnly = true;
            alapterTxt.Size = new Size(121, 23);
            alapterTxt.TabIndex = 11;
            // 
            // EmletTxt
            // 
            EmletTxt.Location = new Point(153, 261);
            EmletTxt.Name = "EmletTxt";
            EmletTxt.ReadOnly = true;
            EmletTxt.Size = new Size(121, 23);
            EmletTxt.TabIndex = 12;
            // 
            // hirdetesekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(EmletTxt);
            Controls.Add(alapterTxt);
            Controls.Add(szobakTxt);
            Controls.Add(KetegoriaTxt);
            Controls.Add(telefonTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nevCb);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "hirdetesekForm";
            Text = "Hírdetesek";
            Load += hirdetesekForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem bezárásToolStripMenuItem;
        private ComboBox nevCb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox telefonTxt;
        private TextBox KetegoriaTxt;
        private TextBox szobakTxt;
        private TextBox alapterTxt;
        private TextBox EmletTxt;
    }
}
