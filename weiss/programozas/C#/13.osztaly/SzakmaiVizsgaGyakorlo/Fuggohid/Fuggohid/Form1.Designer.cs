namespace Fuggohid
{
    partial class Függőhidak
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
            keresésToolStripMenuItem1 = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            hidNevLb = new ListBox();
            groupBox1 = new GroupBox();
            ketezereelottRb = new RadioButton();
            ketezereutaniRb = new RadioButton();
            label5 = new Label();
            darabTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            orszagTxt = new TextBox();
            helytxt = new TextBox();
            hosszTxt = new TextBox();
            evTxt = new TextBox();
            kilepesBtn = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { keresésToolStripMenuItem, keresésToolStripMenuItem1, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(37, 20);
            keresésToolStripMenuItem.Text = "Fájl";
            keresésToolStripMenuItem.Click += keresésToolStripMenuItem_Click;
            // 
            // keresésToolStripMenuItem1
            // 
            keresésToolStripMenuItem1.Name = "keresésToolStripMenuItem1";
            keresésToolStripMenuItem1.Size = new Size(58, 20);
            keresésToolStripMenuItem1.Text = "Keresés";
            keresésToolStripMenuItem1.Click += keresésToolStripMenuItem1_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // hidNevLb
            // 
            hidNevLb.FormattingEnabled = true;
            hidNevLb.ItemHeight = 15;
            hidNevLb.Location = new Point(30, 32);
            hidNevLb.Name = "hidNevLb";
            hidNevLb.Size = new Size(284, 274);
            hidNevLb.TabIndex = 1;
            hidNevLb.SelectedIndexChanged += hidNevLb_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ketezereelottRb);
            groupBox1.Controls.Add(ketezereutaniRb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(darabTxt);
            groupBox1.Location = new Point(30, 340);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 175);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hídak száma";
            // 
            // ketezereelottRb
            // 
            ketezereelottRb.AutoSize = true;
            ketezereelottRb.Location = new Point(29, 43);
            ketezereelottRb.Name = "ketezereelottRb";
            ketezereelottRb.Size = new Size(106, 19);
            ketezereelottRb.TabIndex = 13;
            ketezereelottRb.TabStop = true;
            ketezereelottRb.Text = "2000 előtt épült";
            ketezereelottRb.UseVisualStyleBackColor = true;
            ketezereelottRb.CheckedChanged += ketezereelottRb_CheckedChanged;
            // 
            // ketezereutaniRb
            // 
            ketezereutaniRb.AutoSize = true;
            ketezereutaniRb.Location = new Point(29, 85);
            ketezereutaniRb.Name = "ketezereutaniRb";
            ketezereutaniRb.Size = new Size(135, 19);
            ketezereutaniRb.TabIndex = 12;
            ketezereutaniRb.TabStop = true;
            ketezereutaniRb.Text = "2000-ben vagy utána";
            ketezereutaniRb.UseVisualStyleBackColor = true;
            ketezereutaniRb.CheckedChanged += ketezereutaniRb_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 135);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "darab";
            // 
            // darabTxt
            // 
            darabTxt.Location = new Point(29, 132);
            darabTxt.Name = "darabTxt";
            darabTxt.ReadOnly = true;
            darabTxt.Size = new Size(100, 23);
            darabTxt.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 52);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Hely";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 117);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Ország";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 263);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "Év";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 187);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Hossz";
            // 
            // orszagTxt
            // 
            orszagTxt.Location = new Point(400, 114);
            orszagTxt.Name = "orszagTxt";
            orszagTxt.ReadOnly = true;
            orszagTxt.Size = new Size(100, 23);
            orszagTxt.TabIndex = 7;
            // 
            // helytxt
            // 
            helytxt.Location = new Point(400, 49);
            helytxt.Name = "helytxt";
            helytxt.ReadOnly = true;
            helytxt.Size = new Size(100, 23);
            helytxt.TabIndex = 8;
            // 
            // hosszTxt
            // 
            hosszTxt.Location = new Point(400, 184);
            hosszTxt.Name = "hosszTxt";
            hosszTxt.ReadOnly = true;
            hosszTxt.Size = new Size(100, 23);
            hosszTxt.TabIndex = 9;
            // 
            // evTxt
            // 
            evTxt.Location = new Point(400, 260);
            evTxt.Name = "evTxt";
            evTxt.ReadOnly = true;
            evTxt.Size = new Size(100, 23);
            evTxt.TabIndex = 10;
            // 
            // kilepesBtn
            // 
            kilepesBtn.Location = new Point(400, 421);
            kilepesBtn.Name = "kilepesBtn";
            kilepesBtn.Size = new Size(75, 23);
            kilepesBtn.TabIndex = 11;
            kilepesBtn.Text = "Kilépés";
            kilepesBtn.UseVisualStyleBackColor = true;
            kilepesBtn.Click += kilepesBtn_Click;
            // 
            // Függőhidak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(kilepesBtn);
            Controls.Add(evTxt);
            Controls.Add(hosszTxt);
            Controls.Add(helytxt);
            Controls.Add(orszagTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(hidNevLb);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Függőhidak";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem keresésToolStripMenuItem1;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private ListBox hidNevLb;
        private GroupBox groupBox1;
        private RadioButton ketezereutaniRb;
        private Label label5;
        private TextBox darabTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox orszagTxt;
        private TextBox helytxt;
        private TextBox hosszTxt;
        private TextBox evTxt;
        private RadioButton ketezereelottRb;
        private Button kilepesBtn;
    }
}
