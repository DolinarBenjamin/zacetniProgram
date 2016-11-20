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
            this.dgwAktivneZiv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrikaziKontrole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOKontrole = new System.Windows.Forms.DateTimePicker();
            this.dtpODKontrole = new System.Windows.Forms.DateTimePicker();
            this.btnDodajKontrolo = new System.Windows.Forms.Button();
            this.dgwKontrole = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbImeOpombe = new System.Windows.Forms.ComboBox();
            this.tbIzbranaZival = new System.Windows.Forms.TextBox();
            this.tbOpisOpombe = new System.Windows.Forms.TextBox();
            this.dtpDatumOpombe = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPodrobnostiZivKont = new System.Windows.Forms.Button();
            this.tcHlev.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivneZiv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKontrole)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHlev
            // 
            this.tcHlev.Controls.Add(this.tabPage1);
            this.tcHlev.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.button1);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Osemenitve";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Izbrana žival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Izberite opombo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Datum opombe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Opis opombe";
            // 
            // cbImeOpombe
            // 
            this.cbImeOpombe.FormattingEnabled = true;
            this.cbImeOpombe.Location = new System.Drawing.Point(814, 113);
            this.cbImeOpombe.Name = "cbImeOpombe";
            this.cbImeOpombe.Size = new System.Drawing.Size(257, 28);
            this.cbImeOpombe.TabIndex = 5;
            // 
            // tbIzbranaZival
            // 
            this.tbIzbranaZival.Location = new System.Drawing.Point(814, 50);
            this.tbIzbranaZival.Name = "tbIzbranaZival";
            this.tbIzbranaZival.Size = new System.Drawing.Size(257, 26);
            this.tbIzbranaZival.TabIndex = 6;
            // 
            // tbOpisOpombe
            // 
            this.tbOpisOpombe.Location = new System.Drawing.Point(814, 244);
            this.tbOpisOpombe.Multiline = true;
            this.tbOpisOpombe.Name = "tbOpisOpombe";
            this.tbOpisOpombe.Size = new System.Drawing.Size(257, 132);
            this.tbOpisOpombe.TabIndex = 7;
            // 
            // dtpDatumOpombe
            // 
            this.dtpDatumOpombe.Location = new System.Drawing.Point(814, 183);
            this.dtpDatumOpombe.Name = "dtpDatumOpombe";
            this.dtpDatumOpombe.Size = new System.Drawing.Size(257, 26);
            this.dtpDatumOpombe.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj opombo";
            this.button1.UseVisualStyleBackColor = true;
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
            // Hlev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.tcHlev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hlev";
            this.Text = "Hlev";
            this.Load += new System.EventHandler(this.Hlev_Load);
            this.tcHlev.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktivneZiv)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumOpombe;
        private System.Windows.Forms.TextBox tbOpisOpombe;
        private System.Windows.Forms.TextBox tbIzbranaZival;
        private System.Windows.Forms.ComboBox cbImeOpombe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPodrobnostiZivKont;
    }
}