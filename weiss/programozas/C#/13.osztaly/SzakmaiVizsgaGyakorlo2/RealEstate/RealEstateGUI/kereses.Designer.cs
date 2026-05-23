namespace RealEstateGUI
{
    partial class kereses
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
            eredmenyLb = new ListBox();
            groupBox1 = new GroupBox();
            keresesBtn = new Button();
            kisebbRb = new RadioButton();
            nagyobRb = new RadioButton();
            darabTxt = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // eredmenyLb
            // 
            eredmenyLb.FormattingEnabled = true;
            eredmenyLb.ItemHeight = 15;
            eredmenyLb.Location = new Point(75, 48);
            eredmenyLb.Name = "eredmenyLb";
            eredmenyLb.Size = new Size(333, 259);
            eredmenyLb.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(keresesBtn);
            groupBox1.Controls.Add(kisebbRb);
            groupBox1.Controls.Add(nagyobRb);
            groupBox1.Location = new Point(75, 362);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "alapterület:";
            // 
            // keresesBtn
            // 
            keresesBtn.Location = new Point(37, 125);
            keresesBtn.Name = "keresesBtn";
            keresesBtn.Size = new Size(75, 23);
            keresesBtn.TabIndex = 2;
            keresesBtn.Text = "kerésés";
            keresesBtn.UseVisualStyleBackColor = true;
            keresesBtn.Click += keresesBtn_Click;
            // 
            // kisebbRb
            // 
            kisebbRb.AutoSize = true;
            kisebbRb.Location = new Point(37, 80);
            kisebbRb.Name = "kisebbRb";
            kisebbRb.Size = new Size(95, 19);
            kisebbRb.TabIndex = 1;
            kisebbRb.TabStop = true;
            kisebbRb.Text = "50-nél kisebb";
            kisebbRb.UseVisualStyleBackColor = true;
            kisebbRb.CheckedChanged += kisebbRb_CheckedChanged;
            // 
            // nagyobRb
            // 
            nagyobRb.AutoSize = true;
            nagyobRb.Location = new Point(37, 37);
            nagyobRb.Name = "nagyobRb";
            nagyobRb.Size = new Size(108, 19);
            nagyobRb.TabIndex = 0;
            nagyobRb.TabStop = true;
            nagyobRb.Text = "50-nél nagyobb";
            nagyobRb.UseVisualStyleBackColor = true;
            nagyobRb.CheckedChanged += nagyobRb_CheckedChanged;
            // 
            // darabTxt
            // 
            darabTxt.Location = new Point(75, 324);
            darabTxt.Name = "darabTxt";
            darabTxt.ReadOnly = true;
            darabTxt.Size = new Size(100, 23);
            darabTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 327);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Darab";
            // 
            // kereses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(label1);
            Controls.Add(darabTxt);
            Controls.Add(groupBox1);
            Controls.Add(eredmenyLb);
            Name = "kereses";
            Text = "Keresés";
            Load += kereses_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox eredmenyLb;
        private GroupBox groupBox1;
        private Button keresesBtn;
        private RadioButton kisebbRb;
        private RadioButton nagyobRb;
        private TextBox darabTxt;
        private Label label1;
    }
}