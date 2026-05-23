namespace Fuggohid
{
    partial class Keresés
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
            hidakNevLb = new ListBox();
            groupBox1 = new GroupBox();
            orszagCB = new ComboBox();
            bezarasBtn = new Button();
            keresesBtn = new Button();
            egykmHCKB = new CheckBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // hidakNevLb
            // 
            hidakNevLb.FormattingEnabled = true;
            hidakNevLb.ItemHeight = 15;
            hidakNevLb.Location = new Point(34, 28);
            hidakNevLb.Name = "hidakNevLb";
            hidakNevLb.SelectionMode = SelectionMode.None;
            hidakNevLb.Size = new Size(502, 289);
            hidakNevLb.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orszagCB);
            groupBox1.Controls.Add(bezarasBtn);
            groupBox1.Controls.Add(keresesBtn);
            groupBox1.Controls.Add(egykmHCKB);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Keresés";
            // 
            // orszagCB
            // 
            orszagCB.DropDownStyle = ComboBoxStyle.DropDownList;
            orszagCB.FormattingEnabled = true;
            orszagCB.Location = new Point(82, 28);
            orszagCB.Name = "orszagCB";
            orszagCB.Size = new Size(121, 23);
            orszagCB.TabIndex = 4;
            // 
            // bezarasBtn
            // 
            bezarasBtn.Location = new Point(340, 122);
            bezarasBtn.Name = "bezarasBtn";
            bezarasBtn.Size = new Size(75, 23);
            bezarasBtn.TabIndex = 3;
            bezarasBtn.Text = "Bezárás";
            bezarasBtn.UseVisualStyleBackColor = true;
            bezarasBtn.Click += bezarasBtn_Click;
            // 
            // keresesBtn
            // 
            keresesBtn.Location = new Point(96, 122);
            keresesBtn.Name = "keresesBtn";
            keresesBtn.Size = new Size(75, 23);
            keresesBtn.TabIndex = 2;
            keresesBtn.Text = "Keresés";
            keresesBtn.UseVisualStyleBackColor = true;
            keresesBtn.Click += keresesBtn_Click;
            // 
            // egykmHCKB
            // 
            egykmHCKB.AutoSize = true;
            egykmHCKB.Location = new Point(33, 75);
            egykmHCKB.Name = "egykmHCKB";
            egykmHCKB.Size = new Size(125, 19);
            egykmHCKB.TabIndex = 1;
            egykmHCKB.Text = "1 km-nél hosszabb";
            egykmHCKB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Ország";
            // 
            // Keresés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(groupBox1);
            Controls.Add(hidakNevLb);
            Name = "Keresés";
            Text = "keresesform";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox hidakNevLb;
        private GroupBox groupBox1;
        private ComboBox orszagCB;
        private Button bezarasBtn;
        private Button keresesBtn;
        private CheckBox egykmHCKB;
        private Label label1;
    }
}