namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.meretPnl = new System.Windows.Forms.Panel();
            this.vSB = new System.Windows.Forms.VScrollBar();
            this.hSB = new System.Windows.Forms.HScrollBar();
            this.mozgokep = new System.Windows.Forms.TabPage();
            this.mozgoPtb = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ellenorBtn = new System.Windows.Forms.Button();
            this.kezdoalapotTxt = new System.Windows.Forms.TextBox();
            this.hozzaadBtn = new System.Windows.Forms.Button();
            this.kivonBtn = new System.Windows.Forms.Button();
            this.szamTxt = new System.Windows.Forms.TextBox();
            this.hosszLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.visszaBtn = new System.Windows.Forms.Button();
            this.deleteallBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listTxt = new System.Windows.Forms.TextBox();
            this.ListBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.filmlista = new System.Windows.Forms.TabPage();
            this.moziLatottLb = new System.Windows.Forms.ListBox();
            this.keresBtn = new System.Windows.Forms.Button();
            this.atmozgatBtn = new System.Windows.Forms.Button();
            this.atmasolBtn = new System.Windows.Forms.Button();
            this.torolMindBtn = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.beszurBtn = new System.Windows.Forms.Button();
            this.felveszBtn = new System.Windows.Forms.Button();
            this.helyNud = new System.Windows.Forms.NumericUpDown();
            this.topMoziLb = new System.Windows.Forms.ListBox();
            this.filmTxt = new System.Windows.Forms.TextBox();
            this.webbongeszoTB = new System.Windows.Forms.TabPage();
            this.bongeszoWB = new System.Windows.Forms.WebBrowser();
            this.ugrasBtn = new System.Windows.Forms.Button();
            this.urlCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.autinyilvantartTp = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rendszamLb = new System.Windows.Forms.Label();
            this.rendszamTxt = new System.Windows.Forms.TextBox();
            this.markaLb = new System.Windows.Forms.Label();
            this.markaCB = new System.Windows.Forms.ComboBox();
            this.tipusTxt = new System.Windows.Forms.TextBox();
            this.tipusLb = new System.Windows.Forms.Label();
            this.EvjaratNUD = new System.Windows.Forms.NumericUpDown();
            this.hengerUrtartalomTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uzemanyagCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.felvesz1Btn = new System.Windows.Forms.Button();
            this.listazBtn = new System.Windows.Forms.Button();
            this.autolistLB = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mozgokep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mozgoPtb)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.filmlista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helyNud)).BeginInit();
            this.webbongeszoTB.SuspendLayout();
            this.autinyilvantartTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.mozgokep);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.filmlista);
            this.tabControl1.Controls.Add(this.webbongeszoTB);
            this.tabControl1.Controls.Add(this.autinyilvantartTp);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 1000);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.meretPnl);
            this.tabPage1.Controls.Add(this.vSB);
            this.tabPage1.Controls.Add(this.hSB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1492, 974);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "boxmeret";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // meretPnl
            // 
            this.meretPnl.BackColor = System.Drawing.Color.DodgerBlue;
            this.meretPnl.Location = new System.Drawing.Point(26, 28);
            this.meretPnl.Name = "meretPnl";
            this.meretPnl.Size = new System.Drawing.Size(118, 100);
            this.meretPnl.TabIndex = 2;
            // 
            // vSB
            // 
            this.vSB.Location = new System.Drawing.Point(3, 24);
            this.vSB.Name = "vSB";
            this.vSB.Size = new System.Drawing.Size(19, 947);
            this.vSB.TabIndex = 1;
            this.vSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSB_Scroll);
            // 
            // hSB
            // 
            this.hSB.Location = new System.Drawing.Point(22, 7);
            this.hSB.Name = "hSB";
            this.hSB.Size = new System.Drawing.Size(1467, 17);
            this.hSB.TabIndex = 0;
            this.hSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB_Scroll);
            // 
            // mozgokep
            // 
            this.mozgokep.Controls.Add(this.mozgoPtb);
            this.mozgokep.Location = new System.Drawing.Point(4, 22);
            this.mozgokep.Name = "mozgokep";
            this.mozgokep.Padding = new System.Windows.Forms.Padding(3);
            this.mozgokep.Size = new System.Drawing.Size(1492, 974);
            this.mozgokep.TabIndex = 1;
            this.mozgokep.Text = "kepugrik";
            this.mozgokep.UseVisualStyleBackColor = true;
            // 
            // mozgoPtb
            // 
            this.mozgoPtb.ImageLocation = "https://ih1.redbubble.net/image.4757655391.9914/bg,f8f8f8-flat,750x,075,f-pad,750" +
    "x1000,f8f8f8.jpg";
            this.mozgoPtb.Location = new System.Drawing.Point(410, 363);
            this.mozgoPtb.Name = "mozgoPtb";
            this.mozgoPtb.Size = new System.Drawing.Size(113, 92);
            this.mozgoPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mozgoPtb.TabIndex = 0;
            this.mozgoPtb.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ellenorBtn);
            this.tabPage2.Controls.Add(this.kezdoalapotTxt);
            this.tabPage2.Controls.Add(this.hozzaadBtn);
            this.tabPage2.Controls.Add(this.kivonBtn);
            this.tabPage2.Controls.Add(this.szamTxt);
            this.tabPage2.Controls.Add(this.hosszLbl);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1492, 974);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "sudokuGUI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ellenorBtn
            // 
            this.ellenorBtn.Location = new System.Drawing.Point(421, 222);
            this.ellenorBtn.Name = "ellenorBtn";
            this.ellenorBtn.Size = new System.Drawing.Size(75, 23);
            this.ellenorBtn.TabIndex = 7;
            this.ellenorBtn.Text = "Ellenőrzés";
            this.ellenorBtn.UseVisualStyleBackColor = true;
            this.ellenorBtn.Click += new System.EventHandler(this.ellenorBtn_Click);
            // 
            // kezdoalapotTxt
            // 
            this.kezdoalapotTxt.Location = new System.Drawing.Point(35, 186);
            this.kezdoalapotTxt.Name = "kezdoalapotTxt";
            this.kezdoalapotTxt.Size = new System.Drawing.Size(461, 20);
            this.kezdoalapotTxt.TabIndex = 6;
            this.kezdoalapotTxt.TextChanged += new System.EventHandler(this.kezdoalapotTxt_TextChanged);
            // 
            // hozzaadBtn
            // 
            this.hozzaadBtn.Location = new System.Drawing.Point(206, 43);
            this.hozzaadBtn.Name = "hozzaadBtn";
            this.hozzaadBtn.Size = new System.Drawing.Size(23, 20);
            this.hozzaadBtn.TabIndex = 5;
            this.hozzaadBtn.Text = "+";
            this.hozzaadBtn.UseVisualStyleBackColor = true;
            this.hozzaadBtn.Click += new System.EventHandler(this.hozzaadBtn_Click);
            // 
            // kivonBtn
            // 
            this.kivonBtn.Location = new System.Drawing.Point(146, 43);
            this.kivonBtn.Name = "kivonBtn";
            this.kivonBtn.Size = new System.Drawing.Size(23, 20);
            this.kivonBtn.TabIndex = 4;
            this.kivonBtn.Text = "-";
            this.kivonBtn.UseVisualStyleBackColor = true;
            this.kivonBtn.Click += new System.EventHandler(this.kivonBtn_Click);
            // 
            // szamTxt
            // 
            this.szamTxt.Enabled = false;
            this.szamTxt.Location = new System.Drawing.Point(175, 43);
            this.szamTxt.Name = "szamTxt";
            this.szamTxt.Size = new System.Drawing.Size(25, 20);
            this.szamTxt.TabIndex = 3;
            this.szamTxt.Text = "4";
            this.szamTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hosszLbl
            // 
            this.hosszLbl.AutoSize = true;
            this.hosszLbl.Location = new System.Drawing.Point(32, 222);
            this.hosszLbl.Name = "hosszLbl";
            this.hosszLbl.Size = new System.Drawing.Size(37, 13);
            this.hosszLbl.TabIndex = 2;
            this.hosszLbl.Text = "hossz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kezdőállapot:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új feladvány méret:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.visszaBtn);
            this.tabPage3.Controls.Add(this.deleteallBtn);
            this.tabPage3.Controls.Add(this.deleteBtn);
            this.tabPage3.Controls.Add(this.listTxt);
            this.tabPage3.Controls.Add(this.ListBtn);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1492, 974);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "oka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "viszaküldés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "bevásárló lista";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(573, 78);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(247, 160);
            this.listBox2.TabIndex = 10;
            // 
            // visszaBtn
            // 
            this.visszaBtn.Location = new System.Drawing.Point(745, 51);
            this.visszaBtn.Name = "visszaBtn";
            this.visszaBtn.Size = new System.Drawing.Size(75, 23);
            this.visszaBtn.TabIndex = 7;
            this.visszaBtn.Text = "hozzaad";
            this.visszaBtn.UseVisualStyleBackColor = true;
            this.visszaBtn.Click += new System.EventHandler(this.visszaBtn_Click);
            // 
            // deleteallBtn
            // 
            this.deleteallBtn.BackColor = System.Drawing.Color.Red;
            this.deleteallBtn.Location = new System.Drawing.Point(39, 245);
            this.deleteallBtn.Name = "deleteallBtn";
            this.deleteallBtn.Size = new System.Drawing.Size(88, 23);
            this.deleteallBtn.TabIndex = 5;
            this.deleteallBtn.Text = "összes törlése";
            this.deleteallBtn.UseVisualStyleBackColor = false;
            this.deleteallBtn.Click += new System.EventHandler(this.deleteallBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(211, 246);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Törlés";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // listTxt
            // 
            this.listTxt.Location = new System.Drawing.Point(39, 51);
            this.listTxt.Name = "listTxt";
            this.listTxt.Size = new System.Drawing.Size(166, 20);
            this.listTxt.TabIndex = 3;
            this.listTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listTxt_KeyDown);
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(211, 51);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(75, 20);
            this.ListBtn.TabIndex = 2;
            this.ListBtn.Text = "hozzaad";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sérült termék",
            "nem tetszett",
            "rossz termék",
            "hibás termék"});
            this.comboBox1.Location = new System.Drawing.Point(604, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(247, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // filmlista
            // 
            this.filmlista.Controls.Add(this.moziLatottLb);
            this.filmlista.Controls.Add(this.keresBtn);
            this.filmlista.Controls.Add(this.atmozgatBtn);
            this.filmlista.Controls.Add(this.atmasolBtn);
            this.filmlista.Controls.Add(this.torolMindBtn);
            this.filmlista.Controls.Add(this.torolBtn);
            this.filmlista.Controls.Add(this.beszurBtn);
            this.filmlista.Controls.Add(this.felveszBtn);
            this.filmlista.Controls.Add(this.helyNud);
            this.filmlista.Controls.Add(this.topMoziLb);
            this.filmlista.Controls.Add(this.filmTxt);
            this.filmlista.Location = new System.Drawing.Point(4, 22);
            this.filmlista.Name = "filmlista";
            this.filmlista.Size = new System.Drawing.Size(1492, 974);
            this.filmlista.TabIndex = 4;
            this.filmlista.Text = "Filmlista";
            this.filmlista.UseVisualStyleBackColor = true;
            // 
            // moziLatottLb
            // 
            this.moziLatottLb.FormattingEnabled = true;
            this.moziLatottLb.Location = new System.Drawing.Point(363, 16);
            this.moziLatottLb.Name = "moziLatottLb";
            this.moziLatottLb.Size = new System.Drawing.Size(131, 290);
            this.moziLatottLb.TabIndex = 10;
            // 
            // keresBtn
            // 
            this.keresBtn.Location = new System.Drawing.Point(272, 264);
            this.keresBtn.Name = "keresBtn";
            this.keresBtn.Size = new System.Drawing.Size(69, 21);
            this.keresBtn.TabIndex = 9;
            this.keresBtn.Text = "Keres";
            this.keresBtn.UseVisualStyleBackColor = true;
            this.keresBtn.Click += new System.EventHandler(this.keresBtn_Click);
            // 
            // atmozgatBtn
            // 
            this.atmozgatBtn.Location = new System.Drawing.Point(272, 213);
            this.atmozgatBtn.Name = "atmozgatBtn";
            this.atmozgatBtn.Size = new System.Drawing.Size(69, 21);
            this.atmozgatBtn.TabIndex = 8;
            this.atmozgatBtn.Text = "Átmozgat";
            this.atmozgatBtn.UseVisualStyleBackColor = true;
            this.atmozgatBtn.Click += new System.EventHandler(this.atmozgatBtn_Click);
            // 
            // atmasolBtn
            // 
            this.atmasolBtn.Location = new System.Drawing.Point(272, 186);
            this.atmasolBtn.Name = "atmasolBtn";
            this.atmasolBtn.Size = new System.Drawing.Size(69, 21);
            this.atmasolBtn.TabIndex = 7;
            this.atmasolBtn.Text = "Átmásol";
            this.atmasolBtn.UseVisualStyleBackColor = true;
            this.atmasolBtn.Click += new System.EventHandler(this.atmasolBtn_Click);
            // 
            // torolMindBtn
            // 
            this.torolMindBtn.Location = new System.Drawing.Point(272, 141);
            this.torolMindBtn.Name = "torolMindBtn";
            this.torolMindBtn.Size = new System.Drawing.Size(69, 21);
            this.torolMindBtn.TabIndex = 6;
            this.torolMindBtn.Text = "Töröl mind";
            this.torolMindBtn.UseVisualStyleBackColor = true;
            this.torolMindBtn.Click += new System.EventHandler(this.torolMindBtn_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(272, 114);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(69, 21);
            this.torolBtn.TabIndex = 5;
            this.torolBtn.Text = "Töröl";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.torolBtn_Click);
            // 
            // beszurBtn
            // 
            this.beszurBtn.Location = new System.Drawing.Point(272, 87);
            this.beszurBtn.Name = "beszurBtn";
            this.beszurBtn.Size = new System.Drawing.Size(69, 21);
            this.beszurBtn.TabIndex = 4;
            this.beszurBtn.Text = "Beszúr";
            this.beszurBtn.UseVisualStyleBackColor = true;
            this.beszurBtn.Click += new System.EventHandler(this.beszurBtn_Click);
            // 
            // felveszBtn
            // 
            this.felveszBtn.Location = new System.Drawing.Point(272, 60);
            this.felveszBtn.Name = "felveszBtn";
            this.felveszBtn.Size = new System.Drawing.Size(69, 21);
            this.felveszBtn.TabIndex = 3;
            this.felveszBtn.Text = "Felvesz";
            this.felveszBtn.UseVisualStyleBackColor = true;
            this.felveszBtn.Click += new System.EventHandler(this.felveszBtn_Click);
            // 
            // helyNud
            // 
            this.helyNud.Location = new System.Drawing.Point(273, 15);
            this.helyNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.helyNud.Name = "helyNud";
            this.helyNud.Size = new System.Drawing.Size(69, 20);
            this.helyNud.TabIndex = 2;
            this.helyNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.helyNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.helyNud.ValueChanged += new System.EventHandler(this.helyNud_ValueChanged);
            // 
            // topMoziLb
            // 
            this.topMoziLb.FormattingEnabled = true;
            this.topMoziLb.Items.AddRange(new object[] {
            "film",
            "film 2",
            "film előzmény",
            "film 3"});
            this.topMoziLb.Location = new System.Drawing.Point(4, 43);
            this.topMoziLb.Name = "topMoziLb";
            this.topMoziLb.Size = new System.Drawing.Size(262, 264);
            this.topMoziLb.TabIndex = 1;
            // 
            // filmTxt
            // 
            this.filmTxt.Location = new System.Drawing.Point(4, 16);
            this.filmTxt.Name = "filmTxt";
            this.filmTxt.Size = new System.Drawing.Size(262, 20);
            this.filmTxt.TabIndex = 0;
            // 
            // webbongeszoTB
            // 
            this.webbongeszoTB.Controls.Add(this.bongeszoWB);
            this.webbongeszoTB.Controls.Add(this.ugrasBtn);
            this.webbongeszoTB.Controls.Add(this.urlCB);
            this.webbongeszoTB.Controls.Add(this.label6);
            this.webbongeszoTB.Location = new System.Drawing.Point(4, 22);
            this.webbongeszoTB.Name = "webbongeszoTB";
            this.webbongeszoTB.Size = new System.Drawing.Size(1492, 974);
            this.webbongeszoTB.TabIndex = 5;
            this.webbongeszoTB.Text = "webbongeszo";
            this.webbongeszoTB.UseVisualStyleBackColor = true;
            // 
            // bongeszoWB
            // 
            this.bongeszoWB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bongeszoWB.Location = new System.Drawing.Point(0, 531);
            this.bongeszoWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.bongeszoWB.Name = "bongeszoWB";
            this.bongeszoWB.Size = new System.Drawing.Size(1492, 443);
            this.bongeszoWB.TabIndex = 3;
            // 
            // ugrasBtn
            // 
            this.ugrasBtn.Location = new System.Drawing.Point(499, 12);
            this.ugrasBtn.Name = "ugrasBtn";
            this.ugrasBtn.Size = new System.Drawing.Size(75, 23);
            this.ugrasBtn.TabIndex = 2;
            this.ugrasBtn.Text = "Ugrás";
            this.ugrasBtn.UseVisualStyleBackColor = true;
            this.ugrasBtn.Click += new System.EventHandler(this.ugrasBtn_Click);
            // 
            // urlCB
            // 
            this.urlCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.urlCB.FormattingEnabled = true;
            this.urlCB.Location = new System.Drawing.Point(45, 12);
            this.urlCB.Name = "urlCB";
            this.urlCB.Size = new System.Drawing.Size(448, 21);
            this.urlCB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "URL:";
            // 
            // autinyilvantartTp
            // 
            this.autinyilvantartTp.Controls.Add(this.autolistLB);
            this.autinyilvantartTp.Controls.Add(this.listazBtn);
            this.autinyilvantartTp.Controls.Add(this.felvesz1Btn);
            this.autinyilvantartTp.Controls.Add(this.label9);
            this.autinyilvantartTp.Controls.Add(this.uzemanyagCB);
            this.autinyilvantartTp.Controls.Add(this.label8);
            this.autinyilvantartTp.Controls.Add(this.label7);
            this.autinyilvantartTp.Controls.Add(this.hengerUrtartalomTxt);
            this.autinyilvantartTp.Controls.Add(this.EvjaratNUD);
            this.autinyilvantartTp.Controls.Add(this.tipusLb);
            this.autinyilvantartTp.Controls.Add(this.tipusTxt);
            this.autinyilvantartTp.Controls.Add(this.markaCB);
            this.autinyilvantartTp.Controls.Add(this.markaLb);
            this.autinyilvantartTp.Controls.Add(this.rendszamTxt);
            this.autinyilvantartTp.Controls.Add(this.rendszamLb);
            this.autinyilvantartTp.Location = new System.Drawing.Point(4, 22);
            this.autinyilvantartTp.Name = "autinyilvantartTp";
            this.autinyilvantartTp.Size = new System.Drawing.Size(1492, 974);
            this.autinyilvantartTp.TabIndex = 6;
            this.autinyilvantartTp.Text = "Autónyilvántartás";
            this.autinyilvantartTp.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rendszamLb
            // 
            this.rendszamLb.AutoSize = true;
            this.rendszamLb.Location = new System.Drawing.Point(35, 13);
            this.rendszamLb.Name = "rendszamLb";
            this.rendszamLb.Size = new System.Drawing.Size(60, 13);
            this.rendszamLb.TabIndex = 0;
            this.rendszamLb.Text = "Rendszám:";
            // 
            // rendszamTxt
            // 
            this.rendszamTxt.Location = new System.Drawing.Point(101, 10);
            this.rendszamTxt.Name = "rendszamTxt";
            this.rendszamTxt.Size = new System.Drawing.Size(153, 20);
            this.rendszamTxt.TabIndex = 1;
            // 
            // markaLb
            // 
            this.markaLb.AutoSize = true;
            this.markaLb.Location = new System.Drawing.Point(55, 66);
            this.markaLb.Name = "markaLb";
            this.markaLb.Size = new System.Drawing.Size(40, 13);
            this.markaLb.TabIndex = 2;
            this.markaLb.Text = "Márka:";
            // 
            // markaCB
            // 
            this.markaCB.FormattingEnabled = true;
            this.markaCB.Location = new System.Drawing.Point(101, 63);
            this.markaCB.Name = "markaCB";
            this.markaCB.Size = new System.Drawing.Size(153, 21);
            this.markaCB.TabIndex = 2;
            // 
            // tipusTxt
            // 
            this.tipusTxt.Location = new System.Drawing.Point(101, 120);
            this.tipusTxt.Name = "tipusTxt";
            this.tipusTxt.Size = new System.Drawing.Size(153, 20);
            this.tipusTxt.TabIndex = 3;
            // 
            // tipusLb
            // 
            this.tipusLb.AutoSize = true;
            this.tipusLb.Location = new System.Drawing.Point(52, 123);
            this.tipusLb.Name = "tipusLb";
            this.tipusLb.Size = new System.Drawing.Size(38, 13);
            this.tipusLb.TabIndex = 5;
            this.tipusLb.Text = "Típus:";
            // 
            // EvjaratNUD
            // 
            this.EvjaratNUD.Location = new System.Drawing.Point(101, 229);
            this.EvjaratNUD.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.EvjaratNUD.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.EvjaratNUD.Name = "EvjaratNUD";
            this.EvjaratNUD.Size = new System.Drawing.Size(153, 20);
            this.EvjaratNUD.TabIndex = 5;
            this.EvjaratNUD.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // hengerUrtartalomTxt
            // 
            this.hengerUrtartalomTxt.Location = new System.Drawing.Point(101, 179);
            this.hengerUrtartalomTxt.Name = "hengerUrtartalomTxt";
            this.hengerUrtartalomTxt.Size = new System.Drawing.Size(153, 20);
            this.hengerUrtartalomTxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hengerűrtartalom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Évjárat:";
            // 
            // uzemanyagCB
            // 
            this.uzemanyagCB.FormattingEnabled = true;
            this.uzemanyagCB.Location = new System.Drawing.Point(101, 279);
            this.uzemanyagCB.Name = "uzemanyagCB";
            this.uzemanyagCB.Size = new System.Drawing.Size(153, 21);
            this.uzemanyagCB.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Üzemanyag:";
            // 
            // felvesz1Btn
            // 
            this.felvesz1Btn.Location = new System.Drawing.Point(283, 63);
            this.felvesz1Btn.Name = "felvesz1Btn";
            this.felvesz1Btn.Size = new System.Drawing.Size(75, 44);
            this.felvesz1Btn.TabIndex = 7;
            this.felvesz1Btn.Text = "Felvesz";
            this.felvesz1Btn.UseVisualStyleBackColor = true;
            this.felvesz1Btn.Click += new System.EventHandler(this.felvesz1Btn_Click);
            // 
            // listazBtn
            // 
            this.listazBtn.Location = new System.Drawing.Point(283, 205);
            this.listazBtn.Name = "listazBtn";
            this.listazBtn.Size = new System.Drawing.Size(75, 44);
            this.listazBtn.TabIndex = 8;
            this.listazBtn.Text = "Listáz";
            this.listazBtn.UseVisualStyleBackColor = true;
            this.listazBtn.Click += new System.EventHandler(this.listazBtn_Click);
            // 
            // autolistLB
            // 
            this.autolistLB.FormattingEnabled = true;
            this.autolistLB.Location = new System.Drawing.Point(389, 10);
            this.autolistLB.Name = "autolistLB";
            this.autolistLB.Size = new System.Drawing.Size(284, 290);
            this.autolistLB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 1031);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Vezérlők használata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mozgokep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mozgoPtb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.filmlista.ResumeLayout(false);
            this.filmlista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helyNud)).EndInit();
            this.webbongeszoTB.ResumeLayout(false);
            this.webbongeszoTB.PerformLayout();
            this.autinyilvantartTp.ResumeLayout(false);
            this.autinyilvantartTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage mozgokep;
        private System.Windows.Forms.Panel meretPnl;
        private System.Windows.Forms.VScrollBar vSB;
        private System.Windows.Forms.HScrollBar hSB;
        private System.Windows.Forms.PictureBox mozgoPtb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button hozzaadBtn;
        private System.Windows.Forms.Button kivonBtn;
        private System.Windows.Forms.TextBox szamTxt;
        private System.Windows.Forms.Label hosszLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ellenorBtn;
        private System.Windows.Forms.TextBox kezdoalapotTxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.TextBox listTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button deleteallBtn;
        private System.Windows.Forms.Button visszaBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage filmlista;
        private System.Windows.Forms.ListBox moziLatottLb;
        private System.Windows.Forms.Button keresBtn;
        private System.Windows.Forms.Button atmozgatBtn;
        private System.Windows.Forms.Button atmasolBtn;
        private System.Windows.Forms.Button torolMindBtn;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button beszurBtn;
        private System.Windows.Forms.Button felveszBtn;
        private System.Windows.Forms.NumericUpDown helyNud;
        private System.Windows.Forms.ListBox topMoziLb;
        private System.Windows.Forms.TextBox filmTxt;
        private System.Windows.Forms.TabPage webbongeszoTB;
        private System.Windows.Forms.WebBrowser bongeszoWB;
        private System.Windows.Forms.Button ugrasBtn;
        private System.Windows.Forms.ComboBox urlCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage autinyilvantartTp;
        private System.Windows.Forms.ListBox autolistLB;
        private System.Windows.Forms.Button listazBtn;
        private System.Windows.Forms.Button felvesz1Btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox uzemanyagCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hengerUrtartalomTxt;
        private System.Windows.Forms.NumericUpDown EvjaratNUD;
        private System.Windows.Forms.Label tipusLb;
        private System.Windows.Forms.TextBox tipusTxt;
        private System.Windows.Forms.ComboBox markaCB;
        private System.Windows.Forms.Label markaLb;
        private System.Windows.Forms.TextBox rendszamTxt;
        private System.Windows.Forms.Label rendszamLb;
    }
}

