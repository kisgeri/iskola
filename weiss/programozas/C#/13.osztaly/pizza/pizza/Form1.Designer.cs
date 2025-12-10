namespace pizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rendeles = new System.Windows.Forms.Button();
            this.kozepes = new System.Windows.Forms.RadioButton();
            this.csaladi = new System.Windows.Forms.RadioButton();
            this.kukorica = new System.Windows.Forms.CheckBox();
            this.olivabogyo = new System.Windows.Forms.CheckBox();
            this.gomba = new System.Windows.Forms.CheckBox();
            this.pepperoni = new System.Windows.Forms.CheckBox();
            this.extrasajt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csaladi);
            this.groupBox1.Controls.Add(this.kozepes);
            this.groupBox1.Location = new System.Drawing.Point(123, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "méret";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.extrasajt);
            this.groupBox2.Controls.Add(this.pepperoni);
            this.groupBox2.Controls.Add(this.gomba);
            this.groupBox2.Controls.Add(this.olivabogyo);
            this.groupBox2.Controls.Add(this.kukorica);
            this.groupBox2.Location = new System.Drawing.Point(416, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "plusz feltétt";
            // 
            // rendeles
            // 
            this.rendeles.Location = new System.Drawing.Point(284, 334);
            this.rendeles.Name = "rendeles";
            this.rendeles.Size = new System.Drawing.Size(207, 85);
            this.rendeles.TabIndex = 2;
            this.rendeles.Text = "Rendelés";
            this.rendeles.UseVisualStyleBackColor = true;
            this.rendeles.Click += new System.EventHandler(this.rendeles_Click);
            // 
            // kozepes
            // 
            this.kozepes.AutoSize = true;
            this.kozepes.Location = new System.Drawing.Point(6, 49);
            this.kozepes.Name = "kozepes";
            this.kozepes.Size = new System.Drawing.Size(65, 17);
            this.kozepes.TabIndex = 3;
            this.kozepes.TabStop = true;
            this.kozepes.Text = "közepes";
            this.kozepes.UseVisualStyleBackColor = true;
            // 
            // csaladi
            // 
            this.csaladi.AutoSize = true;
            this.csaladi.Location = new System.Drawing.Point(6, 98);
            this.csaladi.Name = "csaladi";
            this.csaladi.Size = new System.Drawing.Size(58, 17);
            this.csaladi.TabIndex = 4;
            this.csaladi.TabStop = true;
            this.csaladi.Text = "családi";
            this.csaladi.UseVisualStyleBackColor = true;
            // 
            // kukorica
            // 
            this.kukorica.AutoSize = true;
            this.kukorica.Location = new System.Drawing.Point(18, 50);
            this.kukorica.Name = "kukorica";
            this.kukorica.Size = new System.Drawing.Size(67, 17);
            this.kukorica.TabIndex = 0;
            this.kukorica.Text = "kukorica";
            this.kukorica.UseVisualStyleBackColor = true;
            // 
            // olivabogyo
            // 
            this.olivabogyo.AutoSize = true;
            this.olivabogyo.Location = new System.Drawing.Point(18, 73);
            this.olivabogyo.Name = "olivabogyo";
            this.olivabogyo.Size = new System.Drawing.Size(79, 17);
            this.olivabogyo.TabIndex = 1;
            this.olivabogyo.Text = "olívabogyó";
            this.olivabogyo.UseVisualStyleBackColor = true;
            // 
            // gomba
            // 
            this.gomba.AutoSize = true;
            this.gomba.Location = new System.Drawing.Point(18, 98);
            this.gomba.Name = "gomba";
            this.gomba.Size = new System.Drawing.Size(58, 17);
            this.gomba.TabIndex = 2;
            this.gomba.Text = "gomba";
            this.gomba.UseVisualStyleBackColor = true;
            // 
            // pepperoni
            // 
            this.pepperoni.AutoSize = true;
            this.pepperoni.Location = new System.Drawing.Point(18, 121);
            this.pepperoni.Name = "pepperoni";
            this.pepperoni.Size = new System.Drawing.Size(73, 17);
            this.pepperoni.TabIndex = 3;
            this.pepperoni.Text = "pepperoni";
            this.pepperoni.UseVisualStyleBackColor = true;
            // 
            // extrasajt
            // 
            this.extrasajt.AutoSize = true;
            this.extrasajt.Location = new System.Drawing.Point(18, 144);
            this.extrasajt.Name = "extrasajt";
            this.extrasajt.Size = new System.Drawing.Size(68, 17);
            this.extrasajt.TabIndex = 3;
            this.extrasajt.Text = "extra sajt";
            this.extrasajt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rendeles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "pizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton csaladi;
        private System.Windows.Forms.RadioButton kozepes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox olivabogyo;
        private System.Windows.Forms.CheckBox kukorica;
        private System.Windows.Forms.Button rendeles;
        private System.Windows.Forms.CheckBox extrasajt;
        private System.Windows.Forms.CheckBox pepperoni;
        private System.Windows.Forms.CheckBox gomba;
    }
}

