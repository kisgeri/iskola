namespace Fuggohidak
{
    partial class Form2
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
            this.KeresetLb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.egykmHChb = new System.Windows.Forms.CheckBox();
            this.keresesBtn = new System.Windows.Forms.Button();
            this.orszagCb = new System.Windows.Forms.ComboBox();
            this.bezarasBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeresetLb
            // 
            this.KeresetLb.FormattingEnabled = true;
            this.KeresetLb.Location = new System.Drawing.Point(42, 12);
            this.KeresetLb.Name = "KeresetLb";
            this.KeresetLb.Size = new System.Drawing.Size(389, 251);
            this.KeresetLb.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezarasBtn);
            this.groupBox1.Controls.Add(this.orszagCb);
            this.groupBox1.Controls.Add(this.keresesBtn);
            this.groupBox1.Controls.Add(this.egykmHChb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ország";
            // 
            // egykmHChb
            // 
            this.egykmHChb.AutoSize = true;
            this.egykmHChb.Location = new System.Drawing.Point(6, 68);
            this.egykmHChb.Name = "egykmHChb";
            this.egykmHChb.Size = new System.Drawing.Size(126, 17);
            this.egykmHChb.TabIndex = 1;
            this.egykmHChb.Text = "1 km-nél hosszabbak";
            this.egykmHChb.UseVisualStyleBackColor = true;
            // 
            // keresesBtn
            // 
            this.keresesBtn.Location = new System.Drawing.Point(57, 102);
            this.keresesBtn.Name = "keresesBtn";
            this.keresesBtn.Size = new System.Drawing.Size(75, 23);
            this.keresesBtn.TabIndex = 2;
            this.keresesBtn.Text = "Keresés";
            this.keresesBtn.UseVisualStyleBackColor = true;
            this.keresesBtn.Click += new System.EventHandler(this.keresesBtn_Click);
            // 
            // orszagCb
            // 
            this.orszagCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orszagCb.FormattingEnabled = true;
            this.orszagCb.Location = new System.Drawing.Point(83, 27);
            this.orszagCb.Name = "orszagCb";
            this.orszagCb.Size = new System.Drawing.Size(121, 21);
            this.orszagCb.TabIndex = 3;
            // 
            // bezarasBtn
            // 
            this.bezarasBtn.Location = new System.Drawing.Point(258, 102);
            this.bezarasBtn.Name = "bezarasBtn";
            this.bezarasBtn.Size = new System.Drawing.Size(75, 23);
            this.bezarasBtn.TabIndex = 4;
            this.bezarasBtn.Text = "Bezárás";
            this.bezarasBtn.UseVisualStyleBackColor = true;
            this.bezarasBtn.Click += new System.EventHandler(this.bezarasBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KeresetLb);
            this.Name = "Form2";
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox KeresetLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox orszagCb;
        private System.Windows.Forms.Button keresesBtn;
        private System.Windows.Forms.CheckBox egykmHChb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bezarasBtn;
    }
}