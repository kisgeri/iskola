namespace kilepes
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
            this.kilepes_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kilepes_btn
            // 
            this.kilepes_btn.Location = new System.Drawing.Point(12, 48);
            this.kilepes_btn.Name = "kilepes_btn";
            this.kilepes_btn.Size = new System.Drawing.Size(160, 59);
            this.kilepes_btn.TabIndex = 0;
            this.kilepes_btn.Text = "kilépés";
            this.kilepes_btn.UseVisualStyleBackColor = true;
            this.kilepes_btn.Click += new System.EventHandler(this.kilepes_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 161);
            this.Controls.Add(this.kilepes_btn);
            this.Name = "Form1";
            this.Text = "kilepes";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kilepes_btn;
    }
}

