namespace ablak_ugri
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
            this.balfent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jobblent = new System.Windows.Forms.Button();
            this.jobbfent = new System.Windows.Forms.Button();
            this.kozep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balfent
            // 
            this.balfent.Location = new System.Drawing.Point(205, 12);
            this.balfent.Name = "balfent";
            this.balfent.Size = new System.Drawing.Size(100, 57);
            this.balfent.TabIndex = 0;
            this.balfent.Text = "jobb fent sarok";
            this.balfent.UseVisualStyleBackColor = true;
            this.balfent.Click += new System.EventHandler(this.balfent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "jobb lent sarok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jobblent
            // 
            this.jobblent.Location = new System.Drawing.Point(12, 208);
            this.jobblent.Name = "jobblent";
            this.jobblent.Size = new System.Drawing.Size(100, 57);
            this.jobblent.TabIndex = 2;
            this.jobblent.Text = "bal lent sarok";
            this.jobblent.UseVisualStyleBackColor = true;
            this.jobblent.Click += new System.EventHandler(this.jobblent_Click);
            // 
            // jobbfent
            // 
            this.jobbfent.Location = new System.Drawing.Point(12, 12);
            this.jobbfent.Name = "jobbfent";
            this.jobbfent.Size = new System.Drawing.Size(100, 57);
            this.jobbfent.TabIndex = 3;
            this.jobbfent.Text = "bal fent sarok";
            this.jobbfent.UseVisualStyleBackColor = true;
            this.jobbfent.Click += new System.EventHandler(this.jobbfent_Click);
            // 
            // kozep
            // 
            this.kozep.Location = new System.Drawing.Point(108, 110);
            this.kozep.Name = "kozep";
            this.kozep.Size = new System.Drawing.Size(100, 57);
            this.kozep.TabIndex = 4;
            this.kozep.Text = "közép";
            this.kozep.UseVisualStyleBackColor = true;
            this.kozep.Click += new System.EventHandler(this.kozep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 277);
            this.Controls.Add(this.kozep);
            this.Controls.Add(this.jobbfent);
            this.Controls.Add(this.jobblent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.balfent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ablak ugrik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balfent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button jobblent;
        private System.Windows.Forms.Button jobbfent;
        private System.Windows.Forms.Button kozep;
    }
}

