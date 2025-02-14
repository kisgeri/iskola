
namespace KaszinoOsszesitett
{
    partial class blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blackjack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tartas_btn = new System.Windows.Forms.Button();
            this.get_btn = new System.Windows.Forms.Button();
            this.double_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.jatekos_kartyai = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tartas_btn);
            this.panel1.Controls.Add(this.get_btn);
            this.panel1.Controls.Add(this.double_btn);
            this.panel1.Location = new System.Drawing.Point(225, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 50);
            this.panel1.TabIndex = 0;
            // 
            // tartas_btn
            // 
            this.tartas_btn.Enabled = false;
            this.tartas_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tartas_btn.Location = new System.Drawing.Point(400, 0);
            this.tartas_btn.Name = "tartas_btn";
            this.tartas_btn.Size = new System.Drawing.Size(150, 50);
            this.tartas_btn.TabIndex = 2;
            this.tartas_btn.Text = "Tartás";
            this.tartas_btn.UseVisualStyleBackColor = true;
            // 
            // get_btn
            // 
            this.get_btn.Enabled = false;
            this.get_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.get_btn.Location = new System.Drawing.Point(200, 0);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(150, 50);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "Húzás";
            this.get_btn.UseVisualStyleBackColor = true;
            // 
            // double_btn
            // 
            this.double_btn.BackColor = System.Drawing.Color.DarkRed;
            this.double_btn.Enabled = false;
            this.double_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.double_btn.FlatAppearance.BorderSize = 2;
            this.double_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.double_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.double_btn.ForeColor = System.Drawing.Color.White;
            this.double_btn.Location = new System.Drawing.Point(0, 0);
            this.double_btn.Name = "double_btn";
            this.double_btn.Size = new System.Drawing.Size(150, 50);
            this.double_btn.TabIndex = 0;
            this.double_btn.Text = "Duplázás";
            this.double_btn.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(433, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.Location = new System.Drawing.Point(225, 544);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(550, 50);
            this.start.TabIndex = 3;
            this.start.Text = "Kezdés";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // jatekos_kartyai
            // 
            this.jatekos_kartyai.Location = new System.Drawing.Point(203, 376);
            this.jatekos_kartyai.Name = "jatekos_kartyai";
            this.jatekos_kartyai.Size = new System.Drawing.Size(600, 218);
            this.jatekos_kartyai.TabIndex = 4;
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.jatekos_kartyai);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "blackjack";
            this.Text = "blackjack";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tartas_btn;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Button double_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel jatekos_kartyai;
    }
}