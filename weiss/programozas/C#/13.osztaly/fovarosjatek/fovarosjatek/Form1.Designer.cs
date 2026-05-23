namespace fovarosjatek
{
    partial class fovarosFm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.jatekStartBtn = new System.Windows.Forms.Button();
            this.leaderBoardBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.country = new System.Windows.Forms.Label();
            this.CityCb = new System.Windows.Forms.ComboBox();
            this.answerBtn = new System.Windows.Forms.Button();
            this.scoreBoardLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLbl.Location = new System.Drawing.Point(134, 48);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(340, 31);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Ki tudod találni a fővárost ?";
            // 
            // jatekStartBtn
            // 
            this.jatekStartBtn.Location = new System.Drawing.Point(234, 146);
            this.jatekStartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jatekStartBtn.Name = "jatekStartBtn";
            this.jatekStartBtn.Size = new System.Drawing.Size(116, 32);
            this.jatekStartBtn.TabIndex = 1;
            this.jatekStartBtn.Text = "Játék índítása";
            this.jatekStartBtn.UseVisualStyleBackColor = true;
            this.jatekStartBtn.Click += new System.EventHandler(this.jatekStartBtn_Click);
            // 
            // leaderBoardBtn
            // 
            this.leaderBoardBtn.Location = new System.Drawing.Point(234, 212);
            this.leaderBoardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leaderBoardBtn.Name = "leaderBoardBtn";
            this.leaderBoardBtn.Size = new System.Drawing.Size(116, 32);
            this.leaderBoardBtn.TabIndex = 2;
            this.leaderBoardBtn.Text = "Eredmények";
            this.leaderBoardBtn.UseVisualStyleBackColor = true;
            this.leaderBoardBtn.Click += new System.EventHandler(this.leaderBoardBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Location = new System.Drawing.Point(234, 281);
            this.rulesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(116, 32);
            this.rulesBtn.TabIndex = 3;
            this.rulesBtn.Text = "Szabályzat";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTxt.Location = new System.Drawing.Point(333, 92);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(121, 23);
            this.nameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(136, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add meg a felhasználó neved:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // endBtn
            // 
            this.endBtn.Enabled = false;
            this.endBtn.Location = new System.Drawing.Point(303, 281);
            this.endBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(98, 25);
            this.endBtn.TabIndex = 6;
            this.endBtn.Text = "Játék befejezése";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Enabled = false;
            this.ReturnBtn.Location = new System.Drawing.Point(9, 10);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(56, 19);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "vissza";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.RRBtn_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.country.Location = new System.Drawing.Point(241, 112);
            this.country.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(102, 31);
            this.country.TabIndex = 9;
            this.country.Text = "Ország";
            // 
            // CityCb
            // 
            this.CityCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CityCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CityCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CityCb.FormattingEnabled = true;
            this.CityCb.IntegralHeight = false;
            this.CityCb.Location = new System.Drawing.Point(199, 194);
            this.CityCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityCb.Name = "CityCb";
            this.CityCb.Size = new System.Drawing.Size(178, 28);
            this.CityCb.Sorted = true;
            this.CityCb.TabIndex = 10;
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(186, 281);
            this.answerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(98, 25);
            this.answerBtn.TabIndex = 11;
            this.answerBtn.Text = "Válasz leadása";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // scoreBoardLb
            // 
            this.scoreBoardLb.FormattingEnabled = true;
            this.scoreBoardLb.Location = new System.Drawing.Point(157, 81);
            this.scoreBoardLb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreBoardLb.Name = "scoreBoardLb";
            this.scoreBoardLb.Size = new System.Drawing.Size(297, 225);
            this.scoreBoardLb.TabIndex = 12;
            // 
            // fovarosFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.scoreBoardLb);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.CityCb);
            this.Controls.Add(this.country);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.leaderBoardBtn);
            this.Controls.Add(this.jatekStartBtn);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "fovarosFm";
            this.Text = "főváros játék";
            this.Load += new System.EventHandler(this.fovarosFm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button jatekStartBtn;
        private System.Windows.Forms.Button leaderBoardBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.ComboBox CityCb;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.ListBox scoreBoardLb;
    }
}

