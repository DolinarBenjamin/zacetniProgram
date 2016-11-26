namespace Kmetovanje
{
    partial class Hlev
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
            this.tcHlev = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPodrobnostiAktZiv = new System.Windows.Forms.Button();
            this.btnDodajOpombo = new System.Windows.Forms.Button();
            this.dtpDatumOpombe = new System.Windows.Forms.DateTimePicker();
            this.tbOpisOpombe = new System.Windows.Forms.TextBox();
            this.tbIzbranaZival = new System.Windows.Forms.TextBox();
            this.cbImeOpombe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwAktivneZiv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbOsemPreg = new System.Windows.Forms.GroupBox();
            this.dtpDatumOsemPreg = new System.Windows.Forms.DateTimePicker();
            this.tbIzbranaZivOsemPreg = new System.Windows.Forms.TextBox();
            this.cbOsemPreg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDatumOsemPreg = new System.Windows.Forms.Label();
            this.lblOsemPreg = new System.Windows.Forms.Label();
            this.dgwOsemenitve = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPodrobnostiZivKont = new System.Windows.Forms.Button();
            this.btnPrikaziKontrole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOKontrole = new System.Windows.Forms.DateTimePicker();
            this.dtpODKontrole = new System.Windows.Forms.DateTimePicker();
            this.btnDodajKontrolo = new System.Windows.Forms.Button();
            this.dgwKontrole = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnDodajOsemPreg = new System.Windows.Forms.Button();
            this.lblPredvidenDatum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIzidPreg = new System.Windows.Forms.Label();
            this.dtpPredvidenPregTel = new System.Windows.Forms.DateTimePicker();
            this.chebOsemPregon = new System.Windows.Forms.CheckBox();
            this.cbBik = new System.Windows.Forms.ComboBox();
            this.tcHlev.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivneZiv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbOsemPreg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOsemenitve)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKontrole)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHlev
            // 
            this.tcHlev.Controls.Add(this.tabPage1);
            this.tcHlev.Controls.Add(this.tabPage2);
            this.tcHlev.Controls.Add(this.tabPage6);
            this.tcHlev.Controls.Add(this.tabPage3);
            this.tcHlev.Controls.Add(this.tabPage4);
            this.tcHlev.Controls.Add(this.tabPage5);
            this.tcHlev.Location = new System.Drawing.Point(12, 12);
            this.tcHlev.Name = "tcHlev";
            this.tcHlev.SelectedIndex = 0;
            this.tcHlev.Size = new System.Drawing.Size(1248, 557);
            this.tcHlev.TabIndex = 0;
            this.tcHlev.SelectedIndexChanged += new System.EventHandler(this.tcHlev_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPodrobnostiAktZiv);
            this.tabPage1.Controls.Add(this.btnDodajOpombo);
            this.tabPage1.Controls.Add(this.dtpDatumOpombe);
            this.tabPage1.Controls.Add(this.tbOpisOpombe);
            this.tabPage1.Controls.Add(this.tbIzbranaZival);
            this.tabPage1.Controls.Add(this.cbImeOpombe);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgwAktivneZiv);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktivne živali";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPodrobnostiAktZiv
            // 
            this.btnPodrobnostiAktZiv.Location = new System.Drawing.Point(1040, 19);
            this.btnPodrobnostiAktZiv.Name = "btnPodrobnostiAktZiv";
            this.btnPodrobnostiAktZiv.Size = new System.Drawing.Size(178, 42);
            this.btnPodrobnostiAktZiv.TabIndex = 10;
            this.btnPodrobnostiAktZiv.Text = "Podrobnosti o živali";
            this.btnPodrobnostiAktZiv.UseVisualStyleBackColor = true;
            this.btnPodrobnostiAktZiv.Click += new System.EventHandler(this.btnPodrobnostiAktZiv_Click);
            // 
            // btnDodajOpombo
            // 
            this.btnDodajOpombo.Location = new System.Drawing.Point(814, 427);
            this.btnDodajOpombo.Name = "btnDodajOpombo";
            this.btnDodajOpombo.Size = new System.Drawing.Size(141, 48);
            this.btnDodajOpombo.TabIndex = 9;
            this.btnDodajOpombo.Text = "Dodaj opombo";
            this.btnDodajOpombo.UseVisualStyleBackColor = true;
            // 
            // dtpDatumOpombe
            // 
            this.dtpDatumOpombe.Location = new System.Drawing.Point(814, 216);
            this.dtpDatumOpombe.Name = "dtpDatumOpombe";
            this.dtpDatumOpombe.Size = new System.Drawing.Size(257, 26);
            this.dtpDatumOpombe.TabIndex = 8;
            // 
            // tbOpisOpombe
            // 
            this.tbOpisOpombe.Location = new System.Drawing.Point(814, 277);
            this.tbOpisOpombe.Multiline = true;
            this.tbOpisOpombe.Name = "tbOpisOpombe";
            this.tbOpisOpombe.Size = new System.Drawing.Size(257, 132);
            this.tbOpisOpombe.TabIndex = 7;
            // 
            // tbIzbranaZival
            // 
            this.tbIzbranaZival.Location = new System.Drawing.Point(814, 83);
            this.tbIzbranaZival.Name = "tbIzbranaZival";
            this.tbIzbranaZival.Size = new System.Drawing.Size(257, 26);
            this.tbIzbranaZival.TabIndex = 6;
            // 
            // cbImeOpombe
            // 
            this.cbImeOpombe.FormattingEnabled = true;
            this.cbImeOpombe.Location = new System.Drawing.Point(814, 146);
            this.cbImeOpombe.Name = "cbImeOpombe";
            this.cbImeOpombe.Size = new System.Drawing.Size(257, 28);
            this.cbImeOpombe.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Opis opombe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Datum opombe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Izberite opombo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Izbrana žival";
            // 
            // dgwAktivneZiv
            // 
            this.dgwAktivneZiv.AllowUserToAddRows = false;
            this.dgwAktivneZiv.AllowUserToDeleteRows = false;
            this.dgwAktivneZiv.AllowUserToResizeColumns = false;
            this.dgwAktivneZiv.AllowUserToResizeRows = false;
            this.dgwAktivneZiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAktivneZiv.Location = new System.Drawing.Point(6, 6);
            this.dgwAktivneZiv.MultiSelect = false;
            this.dgwAktivneZiv.Name = "dgwAktivneZiv";
            this.dgwAktivneZiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAktivneZiv.Size = new System.Drawing.Size(767, 512);
            this.dgwAktivneZiv.TabIndex = 0;
            this.dgwAktivneZiv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAktivneZiv_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDodajOsemPreg);
            this.tabPage2.Controls.Add(this.gbOsemPreg);
            this.tabPage2.Controls.Add(this.dtpDatumOsemPreg);
            this.tabPage2.Controls.Add(this.tbIzbranaZivOsemPreg);
            this.tabPage2.Controls.Add(this.cbOsemPreg);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblDatumOsemPreg);
            this.tabPage2.Controls.Add(this.lblOsemPreg);
            this.tabPage2.Controls.Add(this.dgwOsemenitve);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Osemenitve";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbOsemPreg
            // 
            this.gbOsemPreg.Controls.Add(this.cbBik);
            this.gbOsemPreg.Controls.Add(this.chebOsemPregon);
            this.gbOsemPreg.Controls.Add(this.dtpPredvidenPregTel);
            this.gbOsemPreg.Controls.Add(this.lblIzidPreg);
            this.gbOsemPreg.Controls.Add(this.label9);
            this.gbOsemPreg.Controls.Add(this.lblPredvidenDatum);
            this.gbOsemPreg.Location = new System.Drawing.Point(959, 205);
            this.gbOsemPreg.Name = "gbOsemPreg";
            this.gbOsemPreg.Size = new System.Drawing.Size(275, 230);
            this.gbOsemPreg.TabIndex = 7;
            this.gbOsemPreg.TabStop = false;
            // 
            // dtpDatumOsemPreg
            // 
            this.dtpDatumOsemPreg.Location = new System.Drawing.Point(968, 173);
            this.dtpDatumOsemPreg.Name = "dtpDatumOsemPreg";
            this.dtpDatumOsemPreg.Size = new System.Drawing.Size(251, 26);
            this.dtpDatumOsemPreg.TabIndex = 6;
            this.dtpDatumOsemPreg.ValueChanged += new System.EventHandler(this.dtpDatumOsemPreg_ValueChanged);
            // 
            // tbIzbranaZivOsemPreg
            // 
            this.tbIzbranaZivOsemPreg.Location = new System.Drawing.Point(968, 113);
            this.tbIzbranaZivOsemPreg.Name = "tbIzbranaZivOsemPreg";
            this.tbIzbranaZivOsemPreg.Size = new System.Drawing.Size(221, 26);
            this.tbIzbranaZivOsemPreg.TabIndex = 5;
            // 
            // cbOsemPreg
            // 
            this.cbOsemPreg.FormattingEnabled = true;
            this.cbOsemPreg.Items.AddRange(new object[] {
            "Osemenitev",
            "Pregled"});
            this.cbOsemPreg.Location = new System.Drawing.Point(968, 46);
            this.cbOsemPreg.Name = "cbOsemPreg";
            this.cbOsemPreg.Size = new System.Drawing.Size(221, 28);
            this.cbOsemPreg.TabIndex = 4;
            this.cbOsemPreg.SelectedIndexChanged += new System.EventHandler(this.cbOsemPreg_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(964, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Izbrana žival";
            // 
            // lblDatumOsemPreg
            // 
            this.lblDatumOsemPreg.AutoSize = true;
            this.lblDatumOsemPreg.Location = new System.Drawing.Point(964, 150);
            this.lblDatumOsemPreg.Name = "lblDatumOsemPreg";
            this.lblDatumOsemPreg.Size = new System.Drawing.Size(145, 20);
            this.lblDatumOsemPreg.TabIndex = 2;
            this.lblDatumOsemPreg.Text = "Datum Osemenitve";
            // 
            // lblOsemPreg
            // 
            this.lblOsemPreg.AutoSize = true;
            this.lblOsemPreg.Location = new System.Drawing.Point(964, 23);
            this.lblOsemPreg.Name = "lblOsemPreg";
            this.lblOsemPreg.Size = new System.Drawing.Size(159, 20);
            this.lblOsemPreg.TabIndex = 1;
            this.lblOsemPreg.Text = "Osemenitev \\ Pregled";
            // 
            // dgwOsemenitve
            // 
            this.dgwOsemenitve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOsemenitve.Location = new System.Drawing.Point(6, 6);
            this.dgwOsemenitve.Name = "dgwOsemenitve";
            this.dgwOsemenitve.Size = new System.Drawing.Size(914, 512);
            this.dgwOsemenitve.TabIndex = 0;
            this.dgwOsemenitve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOsemenitve_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPodrobnostiZivKont);
            this.tabPage3.Controls.Add(this.btnPrikaziKontrole);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dtpDOKontrole);
            this.tabPage3.Controls.Add(this.dtpODKontrole);
            this.tabPage3.Controls.Add(this.btnDodajKontrolo);
            this.tabPage3.Controls.Add(this.dgwKontrole);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1240, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kontrole";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPodrobnostiZivKont
            // 
            this.btnPodrobnostiZivKont.Location = new System.Drawing.Point(1012, 470);
            this.btnPodrobnostiZivKont.Name = "btnPodrobnostiZivKont";
            this.btnPodrobnostiZivKont.Size = new System.Drawing.Size(172, 48);
            this.btnPodrobnostiZivKont.TabIndex = 7;
            this.btnPodrobnostiZivKont.Text = "Podrobnosti živali";
            this.btnPodrobnostiZivKont.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziKontrole
            // 
            this.btnPrikaziKontrole.Location = new System.Drawing.Point(812, 471);
            this.btnPrikaziKontrole.Name = "btnPrikaziKontrole";
            this.btnPrikaziKontrole.Size = new System.Drawing.Size(136, 47);
            this.btnPrikaziKontrole.TabIndex = 6;
            this.btnPrikaziKontrole.Text = "Prikaži zapise";
            this.btnPrikaziKontrole.UseVisualStyleBackColor = true;
            this.btnPrikaziKontrole.Click += new System.EventHandler(this.btnPrikaziKontrole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Od";
            // 
            // dtpDOKontrole
            // 
            this.dtpDOKontrole.Location = new System.Drawing.Point(525, 478);
            this.dtpDOKontrole.Name = "dtpDOKontrole";
            this.dtpDOKontrole.Size = new System.Drawing.Size(260, 26);
            this.dtpDOKontrole.TabIndex = 3;
            // 
            // dtpODKontrole
            // 
            this.dtpODKontrole.Location = new System.Drawing.Point(226, 479);
            this.dtpODKontrole.Name = "dtpODKontrole";
            this.dtpODKontrole.Size = new System.Drawing.Size(257, 26);
            this.dtpODKontrole.TabIndex = 2;
            // 
            // btnDodajKontrolo
            // 
            this.btnDodajKontrolo.Location = new System.Drawing.Point(6, 471);
            this.btnDodajKontrolo.Name = "btnDodajKontrolo";
            this.btnDodajKontrolo.Size = new System.Drawing.Size(155, 47);
            this.btnDodajKontrolo.TabIndex = 1;
            this.btnDodajKontrolo.Text = "Dodaj kontrolo";
            this.btnDodajKontrolo.UseVisualStyleBackColor = true;
            // 
            // dgwKontrole
            // 
            this.dgwKontrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKontrole.Location = new System.Drawing.Point(6, 6);
            this.dgwKontrole.Name = "dgwKontrole";
            this.dgwKontrole.Size = new System.Drawing.Size(1228, 459);
            this.dgwKontrole.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1240, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistika";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1240, 524);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Vse živali";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1240, 524);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Pregled Osemenitev";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnDodajOsemPreg
            // 
            this.btnDodajOsemPreg.Location = new System.Drawing.Point(993, 450);
            this.btnDodajOsemPreg.Name = "btnDodajOsemPreg";
            this.btnDodajOsemPreg.Size = new System.Drawing.Size(180, 43);
            this.btnDodajOsemPreg.TabIndex = 8;
            this.btnDodajOsemPreg.Text = "Dodaj osemenitev";
            this.btnDodajOsemPreg.UseVisualStyleBackColor = true;
            // 
            // lblPredvidenDatum
            // 
            this.lblPredvidenDatum.AutoSize = true;
            this.lblPredvidenDatum.Location = new System.Drawing.Point(6, 161);
            this.lblPredvidenDatum.Name = "lblPredvidenDatum";
            this.lblPredvidenDatum.Size = new System.Drawing.Size(51, 20);
            this.lblPredvidenDatum.TabIndex = 0;
            this.lblPredvidenDatum.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bik";
            // 
            // lblIzidPreg
            // 
            this.lblIzidPreg.AutoSize = true;
            this.lblIzidPreg.Location = new System.Drawing.Point(6, 93);
            this.lblIzidPreg.Name = "lblIzidPreg";
            this.lblIzidPreg.Size = new System.Drawing.Size(100, 20);
            this.lblIzidPreg.TabIndex = 9;
            this.lblIzidPreg.Text = "Izid pregleda";
            // 
            // dtpPredvidenPregTel
            // 
            this.dtpPredvidenPregTel.Enabled = false;
            this.dtpPredvidenPregTel.Location = new System.Drawing.Point(9, 186);
            this.dtpPredvidenPregTel.Name = "dtpPredvidenPregTel";
            this.dtpPredvidenPregTel.Size = new System.Drawing.Size(251, 26);
            this.dtpPredvidenPregTel.TabIndex = 10;
            // 
            // chebOsemPregon
            // 
            this.chebOsemPregon.AutoSize = true;
            this.chebOsemPregon.Location = new System.Drawing.Point(9, 116);
            this.chebOsemPregon.Name = "chebOsemPregon";
            this.chebOsemPregon.Size = new System.Drawing.Size(65, 24);
            this.chebOsemPregon.TabIndex = 9;
            this.chebOsemPregon.Text = "Breja";
            this.chebOsemPregon.UseVisualStyleBackColor = true;
            // 
            // cbBik
            // 
            this.cbBik.FormattingEnabled = true;
            this.cbBik.Location = new System.Drawing.Point(9, 45);
            this.cbBik.Name = "cbBik";
            this.cbBik.Size = new System.Drawing.Size(251, 28);
            this.cbBik.TabIndex = 11;
            // 
            // Hlev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.tcHlev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hlev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hlev";
            this.Load += new System.EventHandler(this.Hlev_Load);
            this.tcHlev.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivneZiv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbOsemPreg.ResumeLayout(false);
            this.gbOsemPreg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOsemenitve)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKontrole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHlev;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgwAktivneZiv;
        private System.Windows.Forms.Button btnDodajKontrolo;
        private System.Windows.Forms.DataGridView dgwKontrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOKontrole;
        private System.Windows.Forms.DateTimePicker dtpODKontrole;
        private System.Windows.Forms.Button btnPrikaziKontrole;
        private System.Windows.Forms.Button btnDodajOpombo;
        private System.Windows.Forms.DateTimePicker dtpDatumOpombe;
        private System.Windows.Forms.TextBox tbOpisOpombe;
        private System.Windows.Forms.TextBox tbIzbranaZival;
        private System.Windows.Forms.ComboBox cbImeOpombe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPodrobnostiZivKont;
        private System.Windows.Forms.GroupBox gbOsemPreg;
        private System.Windows.Forms.DateTimePicker dtpDatumOsemPreg;
        private System.Windows.Forms.TextBox tbIzbranaZivOsemPreg;
        private System.Windows.Forms.ComboBox cbOsemPreg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDatumOsemPreg;
        private System.Windows.Forms.Label lblOsemPreg;
        private System.Windows.Forms.DataGridView dgwOsemenitve;
        private System.Windows.Forms.Button btnPodrobnostiAktZiv;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnDodajOsemPreg;
        private System.Windows.Forms.DateTimePicker dtpPredvidenPregTel;
        private System.Windows.Forms.Label lblIzidPreg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPredvidenDatum;
        private System.Windows.Forms.ComboBox cbBik;
        private System.Windows.Forms.CheckBox chebOsemPregon;
    }
}