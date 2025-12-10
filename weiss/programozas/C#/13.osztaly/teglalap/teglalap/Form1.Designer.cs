namespace teglalap
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
            this.szamitosBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aOldalTxt = new System.Windows.Forms.TextBox();
            this.bOldalTxt = new System.Windows.Forms.TextBox();
            this.teruletLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szamitosBtn
            // 
            this.szamitosBtn.Location = new System.Drawing.Point(2, 110);
            this.szamitosBtn.Name = "szamitosBtn";
            this.szamitosBtn.Size = new System.Drawing.Size(141, 31);
            this.szamitosBtn.TabIndex = 0;
            this.szamitosBtn.Text = "Számítás";
            this.szamitosBtn.UseVisualStyleBackColor = true;
            this.szamitosBtn.Click += new System.EventHandler(this.szamitosBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Terület:";
            // 
            // aOldalTxt
            // 
            this.aOldalTxt.Location = new System.Drawing.Point(21, 6);
            this.aOldalTxt.Name = "aOldalTxt";
            this.aOldalTxt.Size = new System.Drawing.Size(122, 20);
            this.aOldalTxt.TabIndex = 4;
            this.aOldalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bOldalTxt
            // 
            this.bOldalTxt.Location = new System.Drawing.Point(21, 35);
            this.bOldalTxt.Name = "bOldalTxt";
            this.bOldalTxt.Size = new System.Drawing.Size(122, 20);
            this.bOldalTxt.TabIndex = 5;
            this.bOldalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // teruletLbl
            // 
            this.teruletLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teruletLbl.Location = new System.Drawing.Point(47, 74);
            this.teruletLbl.Name = "teruletLbl";
            this.teruletLbl.Size = new System.Drawing.Size(95, 24);
            this.teruletLbl.TabIndex = 6;
            this.teruletLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 157);
            this.Controls.Add(this.teruletLbl);
            this.Controls.Add(this.bOldalTxt);
            this.Controls.Add(this.aOldalTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szamitosBtn);
            this.Name = "Form1";
            this.Text = "téglalap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szamitosBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aOldalTxt;
        private System.Windows.Forms.TextBox bOldalTxt;
        private System.Windows.Forms.Label teruletLbl;
    }
}

