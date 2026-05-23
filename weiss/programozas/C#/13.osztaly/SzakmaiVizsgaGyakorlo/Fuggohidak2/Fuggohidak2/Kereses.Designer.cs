namespace Fuggohidak2
{
    partial class Kereses
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
            hidnevLb = new ListBox();
            groupBox1 = new GroupBox();
            bezarasBtn = new Button();
            kersesBtn = new Button();
            egykmnelhoszCkb = new CheckBox();
            orszagokCb = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // hidnevLb
            // 
            hidnevLb.FormattingEnabled = true;
            hidnevLb.ItemHeight = 15;
            hidnevLb.Location = new Point(55, 24);
            hidnevLb.Name = "hidnevLb";
            hidnevLb.Size = new Size(467, 274);
            hidnevLb.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bezarasBtn);
            groupBox1.Controls.Add(kersesBtn);
            groupBox1.Controls.Add(egykmnelhoszCkb);
            groupBox1.Controls.Add(orszagokCb);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(55, 344);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Keresés";
            // 
            // bezarasBtn
            // 
            bezarasBtn.Location = new Point(314, 137);
            bezarasBtn.Name = "bezarasBtn";
            bezarasBtn.Size = new Size(75, 23);
            bezarasBtn.TabIndex = 4;
            bezarasBtn.Text = "Bezárás";
            bezarasBtn.UseVisualStyleBackColor = true;
            bezarasBtn.Click += bezarasBtn_Click;
            // 
            // kersesBtn
            // 
            kersesBtn.Location = new Point(80, 137);
            kersesBtn.Name = "kersesBtn";
            kersesBtn.Size = new Size(75, 23);
            kersesBtn.TabIndex = 3;
            kersesBtn.Text = "Keresés";
            kersesBtn.UseVisualStyleBackColor = true;
            kersesBtn.Click += kersesBtn_Click;
            // 
            // egykmnelhoszCkb
            // 
            egykmnelhoszCkb.AutoSize = true;
            egykmnelhoszCkb.Location = new Point(18, 91);
            egykmnelhoszCkb.Name = "egykmnelhoszCkb";
            egykmnelhoszCkb.Size = new Size(137, 19);
            egykmnelhoszCkb.TabIndex = 2;
            egykmnelhoszCkb.Text = "1 km-nél hosszabbak";
            egykmnelhoszCkb.UseVisualStyleBackColor = true;
            // 
            // orszagokCb
            // 
            orszagokCb.DropDownStyle = ComboBoxStyle.DropDownList;
            orszagokCb.FormattingEnabled = true;
            orszagokCb.Location = new Point(102, 37);
            orszagokCb.Name = "orszagokCb";
            orszagokCb.Size = new Size(121, 23);
            orszagokCb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Ország";
            // 
            // Kereses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(groupBox1);
            Controls.Add(hidnevLb);
            Name = "Kereses";
            Text = "Keresés";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox hidnevLb;
        private GroupBox groupBox1;
        private CheckBox egykmnelhoszCkb;
        private ComboBox orszagokCb;
        private Label label1;
        private Button bezarasBtn;
        private Button kersesBtn;
    }
}