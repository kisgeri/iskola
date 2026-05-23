namespace Pars2012GUIora
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
            this.zaszlopb = new System.Windows.Forms.PictureBox();
            this.versenyzoCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.csoportLbl = new System.Windows.Forms.Label();
            this.nemzetLbl = new System.Windows.Forms.Label();
            this.nemzetKodLbl = new System.Windows.Forms.Label();
            this.sorozatLbl = new System.Windows.Forms.Label();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaszlopb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válasszon versenyzőt!";
            // 
            // zaszlopb
            // 
            this.zaszlopb.Location = new System.Drawing.Point(80, 268);
            this.zaszlopb.Name = "zaszlopb";
            this.zaszlopb.Size = new System.Drawing.Size(307, 157);
            this.zaszlopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zaszlopb.TabIndex = 1;
            this.zaszlopb.TabStop = false;
            // 
            // versenyzoCb
            // 
            this.versenyzoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versenyzoCb.FormattingEnabled = true;
            this.versenyzoCb.Location = new System.Drawing.Point(51, 58);
            this.versenyzoCb.Name = "versenyzoCb";
            this.versenyzoCb.Size = new System.Drawing.Size(250, 21);
            this.versenyzoCb.TabIndex = 2;
            this.versenyzoCb.SelectedIndexChanged += new System.EventHandler(this.versenyzoCb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zászló:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Csoport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nemzet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nemzet kód:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sorozat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Eredmény:";
            // 
            // csoportLbl
            // 
            this.csoportLbl.AutoSize = true;
            this.csoportLbl.Location = new System.Drawing.Point(100, 92);
            this.csoportLbl.Name = "csoportLbl";
            this.csoportLbl.Size = new System.Drawing.Size(10, 13);
            this.csoportLbl.TabIndex = 9;
            this.csoportLbl.Text = "-";
            // 
            // nemzetLbl
            // 
            this.nemzetLbl.AutoSize = true;
            this.nemzetLbl.Location = new System.Drawing.Point(100, 117);
            this.nemzetLbl.Name = "nemzetLbl";
            this.nemzetLbl.Size = new System.Drawing.Size(10, 13);
            this.nemzetLbl.TabIndex = 10;
            this.nemzetLbl.Text = "-";
            // 
            // nemzetKodLbl
            // 
            this.nemzetKodLbl.AutoSize = true;
            this.nemzetKodLbl.Location = new System.Drawing.Point(121, 139);
            this.nemzetKodLbl.Name = "nemzetKodLbl";
            this.nemzetKodLbl.Size = new System.Drawing.Size(10, 13);
            this.nemzetKodLbl.TabIndex = 11;
            this.nemzetKodLbl.Text = "-";
            // 
            // sorozatLbl
            // 
            this.sorozatLbl.AutoSize = true;
            this.sorozatLbl.Location = new System.Drawing.Point(100, 167);
            this.sorozatLbl.Name = "sorozatLbl";
            this.sorozatLbl.Size = new System.Drawing.Size(10, 13);
            this.sorozatLbl.TabIndex = 12;
            this.sorozatLbl.Text = "-";
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Location = new System.Drawing.Point(111, 197);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(10, 13);
            this.eredmenyLbl.TabIndex = 13;
            this.eredmenyLbl.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.sorozatLbl);
            this.Controls.Add(this.nemzetKodLbl);
            this.Controls.Add(this.nemzetLbl);
            this.Controls.Add(this.csoportLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versenyzoCb);
            this.Controls.Add(this.zaszlopb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "London 2012 – Férfi kalapácsvetés – selejtező";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaszlopb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox zaszlopb;
        private System.Windows.Forms.ComboBox versenyzoCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label csoportLbl;
        private System.Windows.Forms.Label nemzetLbl;
        private System.Windows.Forms.Label nemzetKodLbl;
        private System.Windows.Forms.Label sorozatLbl;
        private System.Windows.Forms.Label eredmenyLbl;
    }
}

