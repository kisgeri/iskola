namespace Fuggohidak
{
    partial class Keresés
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
            this.kereseslb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.egykmnelhosszabb = new System.Windows.Forms.CheckBox();
            this.orszagcB = new System.Windows.Forms.ComboBox();
            this.kerseBtn = new System.Windows.Forms.Button();
            this.bezarasBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kereseslb
            // 
            this.kereseslb.FormattingEnabled = true;
            this.kereseslb.Location = new System.Drawing.Point(95, 87);
            this.kereseslb.Name = "kereseslb";
            this.kereseslb.Size = new System.Drawing.Size(618, 433);
            this.kereseslb.TabIndex = 0;
            this.kereseslb.SelectedIndexChanged += new System.EventHandler(this.hidaklb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezarasBtn);
            this.groupBox1.Controls.Add(this.kerseBtn);
            this.groupBox1.Controls.Add(this.orszagcB);
            this.groupBox1.Controls.Add(this.egykmnelhosszabb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(95, 604);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orszag";
            // 
            // egykmnelhosszabb
            // 
            this.egykmnelhosszabb.AutoSize = true;
            this.egykmnelhosszabb.Location = new System.Drawing.Point(39, 90);
            this.egykmnelhosszabb.Name = "egykmnelhosszabb";
            this.egykmnelhosszabb.Size = new System.Drawing.Size(126, 17);
            this.egykmnelhosszabb.TabIndex = 1;
            this.egykmnelhosszabb.Text = "1 km-nél hosszabbak";
            this.egykmnelhosszabb.UseVisualStyleBackColor = true;
            // 
            // orszagcB
            // 
            this.orszagcB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orszagcB.FormattingEnabled = true;
            this.orszagcB.Location = new System.Drawing.Point(99, 31);
            this.orszagcB.Name = "orszagcB";
            this.orszagcB.Size = new System.Drawing.Size(121, 21);
            this.orszagcB.TabIndex = 2;
            // 
            // kerseBtn
            // 
            this.kerseBtn.Location = new System.Drawing.Point(90, 130);
            this.kerseBtn.Name = "kerseBtn";
            this.kerseBtn.Size = new System.Drawing.Size(75, 23);
            this.kerseBtn.TabIndex = 3;
            this.kerseBtn.Text = "Keresés";
            this.kerseBtn.UseVisualStyleBackColor = true;
            this.kerseBtn.Click += new System.EventHandler(this.kerseBtn_Click);
            // 
            // bezarasBtn
            // 
            this.bezarasBtn.Location = new System.Drawing.Point(449, 130);
            this.bezarasBtn.Name = "bezarasBtn";
            this.bezarasBtn.Size = new System.Drawing.Size(75, 23);
            this.bezarasBtn.TabIndex = 4;
            this.bezarasBtn.Text = "Bezárás";
            this.bezarasBtn.UseVisualStyleBackColor = true;
            this.bezarasBtn.Click += new System.EventHandler(this.bezarasBtn_Click);
            // 
            // Keresés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 849);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kereseslb);
            this.Name = "Keresés";
            this.Text = "Keresés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kereseslb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bezarasBtn;
        private System.Windows.Forms.Button kerseBtn;
        private System.Windows.Forms.ComboBox orszagcB;
        private System.Windows.Forms.CheckBox egykmnelhosszabb;
        private System.Windows.Forms.Label label1;
    }
}