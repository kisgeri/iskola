namespace Fuggohidak2
{
    partial class FuggohidakForm
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
            fájlToolStripMenuItem = new ToolStripMenuItem();
            keresésToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            hidnevekLb = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            ketezerutanRB = new RadioButton();
            ketezerelottRb = new RadioButton();
            darabTxt = new TextBox();
            helxtxt = new TextBox();
            evTxt = new TextBox();
            hosszTxt = new TextBox();
            orszagTxt = new TextBox();
            kilepesBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, keresésToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            fájlToolStripMenuItem.Click += fájlToolStripMenuItem_Click;
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(58, 20);
            keresésToolStripMenuItem.Text = "Keresés";
            keresésToolStripMenuItem.Click += keresésToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // hidnevekLb
            // 
            hidnevekLb.FormattingEnabled = true;
            hidnevekLb.ItemHeight = 15;
            hidnevekLb.Location = new Point(23, 38);
            hidnevekLb.Name = "hidnevekLb";
            hidnevekLb.Size = new Size(296, 289);
            hidnevekLb.TabIndex = 1;
            hidnevekLb.SelectedIndexChanged += hidnevekLb_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ketezerutanRB);
            groupBox1.Controls.Add(ketezerelottRb);
            groupBox1.Controls.Add(darabTxt);
            groupBox1.Location = new Point(23, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hidak száma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 134);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "darab";
            // 
            // ketezerutanRB
            // 
            ketezerutanRB.AutoSize = true;
            ketezerutanRB.Location = new Point(18, 81);
            ketezerutanRB.Name = "ketezerutanRB";
            ketezerutanRB.Size = new Size(135, 19);
            ketezerutanRB.TabIndex = 8;
            ketezerutanRB.TabStop = true;
            ketezerutanRB.Text = "2000-ben vagy utána";
            ketezerutanRB.UseVisualStyleBackColor = true;
            ketezerutanRB.CheckedChanged += ketezerutanRB_CheckedChanged;
            // 
            // ketezerelottRb
            // 
            ketezerelottRb.AutoSize = true;
            ketezerelottRb.Location = new Point(18, 36);
            ketezerelottRb.Name = "ketezerelottRb";
            ketezerelottRb.Size = new Size(106, 19);
            ketezerelottRb.TabIndex = 7;
            ketezerelottRb.TabStop = true;
            ketezerelottRb.Text = "2000 előtt épült";
            ketezerelottRb.UseVisualStyleBackColor = true;
            ketezerelottRb.CheckedChanged += ketezerelottRb_CheckedChanged;
            // 
            // darabTxt
            // 
            darabTxt.Location = new Point(18, 131);
            darabTxt.Name = "darabTxt";
            darabTxt.ReadOnly = true;
            darabTxt.Size = new Size(100, 23);
            darabTxt.TabIndex = 7;
            // 
            // helxtxt
            // 
            helxtxt.Location = new Point(419, 49);
            helxtxt.Name = "helxtxt";
            helxtxt.ReadOnly = true;
            helxtxt.Size = new Size(123, 23);
            helxtxt.TabIndex = 3;
            // 
            // evTxt
            // 
            evTxt.Location = new Point(419, 283);
            evTxt.Name = "evTxt";
            evTxt.ReadOnly = true;
            evTxt.Size = new Size(123, 23);
            evTxt.TabIndex = 4;
            // 
            // hosszTxt
            // 
            hosszTxt.Location = new Point(419, 201);
            hosszTxt.Name = "hosszTxt";
            hosszTxt.ReadOnly = true;
            hosszTxt.Size = new Size(123, 23);
            hosszTxt.TabIndex = 5;
            // 
            // orszagTxt
            // 
            orszagTxt.Location = new Point(419, 122);
            orszagTxt.Name = "orszagTxt";
            orszagTxt.ReadOnly = true;
            orszagTxt.Size = new Size(123, 23);
            orszagTxt.TabIndex = 6;
            // 
            // kilepesBtn
            // 
            kilepesBtn.Location = new Point(419, 453);
            kilepesBtn.Name = "kilepesBtn";
            kilepesBtn.Size = new Size(75, 23);
            kilepesBtn.TabIndex = 7;
            kilepesBtn.Text = "Kilépés";
            kilepesBtn.UseVisualStyleBackColor = true;
            kilepesBtn.Click += kilepesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 52);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Hely";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 125);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Ország";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 204);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Hossz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 286);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 11;
            label4.Text = "Év";
            // 
            // FuggohidakForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kilepesBtn);
            Controls.Add(orszagTxt);
            Controls.Add(hosszTxt);
            Controls.Add(evTxt);
            Controls.Add(helxtxt);
            Controls.Add(groupBox1);
            Controls.Add(hidnevekLb);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FuggohidakForm";
            Text = "Függőhidak";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private ListBox hidnevekLb;
        private GroupBox groupBox1;
        private RadioButton ketezerutanRB;
        private RadioButton ketezerelottRb;
        private TextBox darabTxt;
        private TextBox helxtxt;
        private TextBox evTxt;
        private TextBox hosszTxt;
        private TextBox orszagTxt;
        private Button kilepesBtn;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
