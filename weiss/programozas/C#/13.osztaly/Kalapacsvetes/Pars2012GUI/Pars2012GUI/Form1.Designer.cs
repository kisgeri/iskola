namespace Pars2012GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.versenyzokCB = new System.Windows.Forms.ComboBox();
            this.csoportLbl = new System.Windows.Forms.Label();
            this.nemzetLbl = new System.Windows.Forms.Label();
            this.nemzetKodLbl = new System.Windows.Forms.Label();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureBoxZászló = new System.Windows.Forms.PictureBox();
            this.sorozatLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxZászló)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válasszon versenyzőt!";
            // 
            // versenyzokCB
            // 
            this.versenyzokCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versenyzokCB.FormattingEnabled = true;
            this.versenyzokCB.Location = new System.Drawing.Point(53, 59);
            this.versenyzokCB.Name = "versenyzokCB";
            this.versenyzokCB.Size = new System.Drawing.Size(210, 21);
            this.versenyzokCB.TabIndex = 1;
            this.versenyzokCB.SelectedIndexChanged += new System.EventHandler(this.versenyzokCB_SelectedIndexChanged);
            // 
            // csoportLbl
            // 
            this.csoportLbl.AutoSize = true;
            this.csoportLbl.Location = new System.Drawing.Point(41, 94);
            this.csoportLbl.Name = "csoportLbl";
            this.csoportLbl.Size = new System.Drawing.Size(46, 13);
            this.csoportLbl.TabIndex = 2;
            this.csoportLbl.Text = "Csoport:";
            // 
            // nemzetLbl
            // 
            this.nemzetLbl.AutoSize = true;
            this.nemzetLbl.Location = new System.Drawing.Point(41, 118);
            this.nemzetLbl.Name = "nemzetLbl";
            this.nemzetLbl.Size = new System.Drawing.Size(46, 13);
            this.nemzetLbl.TabIndex = 3;
            this.nemzetLbl.Text = "Nemzet:";
            // 
            // nemzetKodLbl
            // 
            this.nemzetKodLbl.AutoSize = true;
            this.nemzetKodLbl.Location = new System.Drawing.Point(41, 140);
            this.nemzetKodLbl.Name = "nemzetKodLbl";
            this.nemzetKodLbl.Size = new System.Drawing.Size(67, 13);
            this.nemzetKodLbl.TabIndex = 4;
            this.nemzetKodLbl.Text = "Nemzet kód:";
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Location = new System.Drawing.Point(41, 203);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(57, 13);
            this.eredmenyLbl.TabIndex = 5;
            this.eredmenyLbl.Text = "Eredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zászló:";
            // 
            // PictureBoxZászló
            // 
            this.PictureBoxZászló.Location = new System.Drawing.Point(53, 259);
            this.PictureBoxZászló.Name = "PictureBoxZászló";
            this.PictureBoxZászló.Size = new System.Drawing.Size(363, 177);
            this.PictureBoxZászló.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxZászló.TabIndex = 7;
            this.PictureBoxZászló.TabStop = false;
            // 
            // sorozatLbl
            // 
            this.sorozatLbl.AutoSize = true;
            this.sorozatLbl.Location = new System.Drawing.Point(41, 177);
            this.sorozatLbl.Name = "sorozatLbl";
            this.sorozatLbl.Size = new System.Drawing.Size(46, 13);
            this.sorozatLbl.TabIndex = 8;
            this.sorozatLbl.Text = "Sorozat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 448);
            this.Controls.Add(this.sorozatLbl);
            this.Controls.Add(this.PictureBoxZászló);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.nemzetKodLbl);
            this.Controls.Add(this.nemzetLbl);
            this.Controls.Add(this.csoportLbl);
            this.Controls.Add(this.versenyzokCB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "London 2012 – Férfi kalapácsvetés – selejtező";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxZászló)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox versenyzokCB;
        private System.Windows.Forms.Label csoportLbl;
        private System.Windows.Forms.Label nemzetLbl;
        private System.Windows.Forms.Label nemzetKodLbl;
        private System.Windows.Forms.Label eredmenyLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PictureBoxZászló;
        private System.Windows.Forms.Label sorozatLbl;
    }
}

