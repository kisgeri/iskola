namespace GombHopp
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
            this.hoppBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yKoordTxt = new System.Windows.Forms.TextBox();
            this.xKoordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hoppBtn
            // 
            this.hoppBtn.Location = new System.Drawing.Point(283, 296);
            this.hoppBtn.Name = "hoppBtn";
            this.hoppBtn.Size = new System.Drawing.Size(70, 20);
            this.hoppBtn.TabIndex = 0;
            this.hoppBtn.Text = "button1";
            this.hoppBtn.UseVisualStyleBackColor = true;
            this.hoppBtn.Click += new System.EventHandler(this.hoppBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // yKoordTxt
            // 
            this.yKoordTxt.Location = new System.Drawing.Point(494, 66);
            this.yKoordTxt.Name = "yKoordTxt";
            this.yKoordTxt.Size = new System.Drawing.Size(142, 20);
            this.yKoordTxt.TabIndex = 3;
            this.yKoordTxt.Text = "100";
            this.yKoordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xKoordTxt
            // 
            this.xKoordTxt.Location = new System.Drawing.Point(180, 66);
            this.xKoordTxt.Name = "xKoordTxt";
            this.xKoordTxt.Size = new System.Drawing.Size(121, 20);
            this.xKoordTxt.TabIndex = 4;
            this.xKoordTxt.Text = "100";
            this.xKoordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.xKoordTxt);
            this.Controls.Add(this.yKoordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoppBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hoppBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yKoordTxt;
        private System.Windows.Forms.TextBox xKoordTxt;
    }
}

