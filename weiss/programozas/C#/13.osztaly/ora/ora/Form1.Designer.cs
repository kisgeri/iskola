namespace ora
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
            this.components = new System.ComponentModel.Container();
            this.ora = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stopper = new System.Windows.Forms.Label();
            this.pausetopper = new System.Windows.Forms.Button();
            this.stoptopper = new System.Windows.Forms.Button();
            this.starttopper = new System.Windows.Forms.Button();
            this.mozgoTpg = new System.Windows.Forms.TabPage();
            this.mozgo_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.UgrogombTbp = new System.Windows.Forms.TabPage();
            this.ugroBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mozgoTpg.SuspendLayout();
            this.UgrogombTbp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ora.Location = new System.Drawing.Point(90, 62);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(105, 20);
            this.ora.TabIndex = 0;
            this.ora.Text = "00:00:00:000";
            this.ora.Click += new System.EventHandler(this.ora_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(9, 113);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(211, 113);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(75, 23);
            this.stopbtn.TabIndex = 2;
            this.stopbtn.Text = "stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.mozgoTpg);
            this.tabControl1.Controls.Add(this.UgrogombTbp);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 170);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stopbtn);
            this.tabPage1.Controls.Add(this.ora);
            this.tabPage1.Controls.Add(this.startbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "oraTpg";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stopper);
            this.tabPage2.Controls.Add(this.pausetopper);
            this.tabPage2.Controls.Add(this.stoptopper);
            this.tabPage2.Controls.Add(this.starttopper);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "stopprTpg";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stopper
            // 
            this.stopper.AutoSize = true;
            this.stopper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.stopper.Location = new System.Drawing.Point(94, 53);
            this.stopper.Name = "stopper";
            this.stopper.Size = new System.Drawing.Size(105, 20);
            this.stopper.TabIndex = 3;
            this.stopper.Text = "00:00:00:000";
            // 
            // pausetopper
            // 
            this.pausetopper.Enabled = false;
            this.pausetopper.Location = new System.Drawing.Point(111, 113);
            this.pausetopper.Name = "pausetopper";
            this.pausetopper.Size = new System.Drawing.Size(75, 23);
            this.pausetopper.TabIndex = 2;
            this.pausetopper.Text = "pause";
            this.pausetopper.UseVisualStyleBackColor = true;
            this.pausetopper.Click += new System.EventHandler(this.pausetopper_Click);
            // 
            // stoptopper
            // 
            this.stoptopper.Enabled = false;
            this.stoptopper.Location = new System.Drawing.Point(211, 113);
            this.stoptopper.Name = "stoptopper";
            this.stoptopper.Size = new System.Drawing.Size(75, 23);
            this.stoptopper.TabIndex = 1;
            this.stoptopper.Text = "stop";
            this.stoptopper.UseVisualStyleBackColor = true;
            this.stoptopper.Click += new System.EventHandler(this.stoptopper_Click);
            // 
            // starttopper
            // 
            this.starttopper.Location = new System.Drawing.Point(9, 113);
            this.starttopper.Name = "starttopper";
            this.starttopper.Size = new System.Drawing.Size(75, 23);
            this.starttopper.TabIndex = 0;
            this.starttopper.Text = "start";
            this.starttopper.UseVisualStyleBackColor = true;
            this.starttopper.Click += new System.EventHandler(this.starttopper_Click);
            // 
            // mozgoTpg
            // 
            this.mozgoTpg.Controls.Add(this.mozgo_label);
            this.mozgoTpg.Location = new System.Drawing.Point(4, 22);
            this.mozgoTpg.Name = "mozgoTpg";
            this.mozgoTpg.Size = new System.Drawing.Size(296, 144);
            this.mozgoTpg.TabIndex = 2;
            this.mozgoTpg.Text = "mozgofelirat";
            this.mozgoTpg.UseVisualStyleBackColor = true;
            // 
            // mozgo_label
            // 
            this.mozgo_label.AutoSize = true;
            this.mozgo_label.Location = new System.Drawing.Point(115, 37);
            this.mozgo_label.Name = "mozgo_label";
            this.mozgo_label.Size = new System.Drawing.Size(69, 13);
            this.mozgo_label.TabIndex = 0;
            this.mozgo_label.Text = "mozgó feliratt";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 15;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // UgrogombTbp
            // 
            this.UgrogombTbp.Controls.Add(this.ugroBtn);
            this.UgrogombTbp.Location = new System.Drawing.Point(4, 22);
            this.UgrogombTbp.Name = "UgrogombTbp";
            this.UgrogombTbp.Size = new System.Drawing.Size(296, 144);
            this.UgrogombTbp.TabIndex = 3;
            this.UgrogombTbp.Text = "Ugrogomb";
            this.UgrogombTbp.UseVisualStyleBackColor = true;
            // 
            // ugroBtn
            // 
            this.ugroBtn.Location = new System.Drawing.Point(106, 57);
            this.ugroBtn.Name = "ugroBtn";
            this.ugroBtn.Size = new System.Drawing.Size(85, 25);
            this.ugroBtn.TabIndex = 0;
            this.ugroBtn.Text = "nyomd meg !!!";
            this.ugroBtn.UseVisualStyleBackColor = true;
            this.ugroBtn.MouseEnter += new System.EventHandler(this.ugroBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 176);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mozgoTpg.ResumeLayout(false);
            this.mozgoTpg.PerformLayout();
            this.UgrogombTbp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ora;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label stopper;
        private System.Windows.Forms.Button pausetopper;
        private System.Windows.Forms.Button stoptopper;
        private System.Windows.Forms.Button starttopper;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage mozgoTpg;
        private System.Windows.Forms.Label mozgo_label;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TabPage UgrogombTbp;
        private System.Windows.Forms.Button ugroBtn;
    }
}

