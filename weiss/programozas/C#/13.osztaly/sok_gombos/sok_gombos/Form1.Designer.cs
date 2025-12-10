namespace sok_gombos
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
            this.eltunes = new System.Windows.Forms.Button();
            this.lathatatlan = new System.Windows.Forms.Button();
            this.inaktiv = new System.Windows.Forms.Button();
            this.ugras = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.eger_pozicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eltunes
            // 
            this.eltunes.Location = new System.Drawing.Point(97, 62);
            this.eltunes.Name = "eltunes";
            this.eltunes.Size = new System.Drawing.Size(130, 65);
            this.eltunes.TabIndex = 0;
            this.eltunes.Text = "Eltűnés";
            this.eltunes.UseVisualStyleBackColor = true;
            this.eltunes.MouseEnter += new System.EventHandler(this.eltunes_MouseEnter);
            this.eltunes.MouseLeave += new System.EventHandler(this.eltunes_MouseLeave);
            // 
            // lathatatlan
            // 
            this.lathatatlan.Location = new System.Drawing.Point(97, 133);
            this.lathatatlan.Name = "lathatatlan";
            this.lathatatlan.Size = new System.Drawing.Size(130, 65);
            this.lathatatlan.TabIndex = 1;
            this.lathatatlan.Text = "Láthatatlan";
            this.lathatatlan.UseVisualStyleBackColor = true;
            this.lathatatlan.Click += new System.EventHandler(this.lathatatlan_Click);
            // 
            // inaktiv
            // 
            this.inaktiv.Location = new System.Drawing.Point(97, 204);
            this.inaktiv.Name = "inaktiv";
            this.inaktiv.Size = new System.Drawing.Size(130, 65);
            this.inaktiv.TabIndex = 2;
            this.inaktiv.Text = "Inaktív";
            this.inaktiv.UseVisualStyleBackColor = true;
            this.inaktiv.Click += new System.EventHandler(this.inaktiv_Click);
            // 
            // ugras
            // 
            this.ugras.Location = new System.Drawing.Point(330, 62);
            this.ugras.Name = "ugras";
            this.ugras.Size = new System.Drawing.Size(130, 65);
            this.ugras.TabIndex = 3;
            this.ugras.Text = "Ugrás";
            this.ugras.UseVisualStyleBackColor = true;
            this.ugras.Click += new System.EventHandler(this.ugras_Click);
            // 
            // kilepes
            // 
            this.kilepes.Location = new System.Drawing.Point(233, 270);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(91, 39);
            this.kilepes.TabIndex = 6;
            this.kilepes.Text = "kilépés";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // eger_pozicio
            // 
            this.eger_pozicio.AutoSize = true;
            this.eger_pozicio.Location = new System.Drawing.Point(327, 133);
            this.eger_pozicio.Name = "eger_pozicio";
            this.eger_pozicio.Size = new System.Drawing.Size(78, 13);
            this.eger_pozicio.TabIndex = 7;
            this.eger_pozicio.Text = "Egér pozíciója:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eger_pozicio);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.ugras);
            this.Controls.Add(this.inaktiv);
            this.Controls.Add(this.lathatatlan);
            this.Controls.Add(this.eltunes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eltunes;
        private System.Windows.Forms.Button lathatatlan;
        private System.Windows.Forms.Button inaktiv;
        private System.Windows.Forms.Button ugras;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.Label eger_pozicio;
    }
}

