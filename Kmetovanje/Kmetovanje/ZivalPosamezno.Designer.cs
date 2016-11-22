namespace Kmetovanje
{
    partial class ZivalPosamezno
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
            this.tcZival = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwPosOpombe = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgwPosKontrole = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwPosTelitve = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgwPosLaktacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosBeljakovin = new System.Windows.Forms.TextBox();
            this.tbPosMascobe = new System.Windows.Forms.TextBox();
            this.tbPosLitrov = new System.Windows.Forms.TextBox();
            this.tbPosImeZiv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPosUsesStevZiv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPosOce = new System.Windows.Forms.TextBox();
            this.tbPosMati = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPosRojstvoZiv = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tcZival.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosOpombe)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosKontrole)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosTelitve)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosLaktacije)).BeginInit();
            this.SuspendLayout();
            // 
            // tcZival
            // 
            this.tcZival.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcZival.Controls.Add(this.tabPage1);
            this.tcZival.Controls.Add(this.tabPage4);
            this.tcZival.Controls.Add(this.tabPage2);
            this.tcZival.Controls.Add(this.tabPage3);
            this.tcZival.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcZival.ItemSize = new System.Drawing.Size(50, 136);
            this.tcZival.Location = new System.Drawing.Point(12, 154);
            this.tcZival.Multiline = true;
            this.tcZival.Name = "tcZival";
            this.tcZival.SelectedIndex = 0;
            this.tcZival.Size = new System.Drawing.Size(968, 401);
            this.tcZival.TabIndex = 0;
            this.tcZival.SelectedIndexChanged += new System.EventHandler(this.tcZival_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwPosOpombe);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(140, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Posegi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwPosOpombe
            // 
            this.dgwPosOpombe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPosOpombe.Location = new System.Drawing.Point(6, 6);
            this.dgwPosOpombe.Name = "dgwPosOpombe";
            this.dgwPosOpombe.Size = new System.Drawing.Size(766, 296);
            this.dgwPosOpombe.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgwPosKontrole);
            this.tabPage4.Location = new System.Drawing.Point(140, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(824, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kontrole";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgwPosKontrole
            // 
            this.dgwPosKontrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPosKontrole.Location = new System.Drawing.Point(6, 6);
            this.dgwPosKontrole.Name = "dgwPosKontrole";
            this.dgwPosKontrole.Size = new System.Drawing.Size(240, 150);
            this.dgwPosKontrole.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgwPosTelitve);
            this.tabPage2.Location = new System.Drawing.Point(140, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Telitve";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgwPosTelitve
            // 
            this.dgwPosTelitve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPosTelitve.Location = new System.Drawing.Point(6, 6);
            this.dgwPosTelitve.Name = "dgwPosTelitve";
            this.dgwPosTelitve.Size = new System.Drawing.Size(240, 150);
            this.dgwPosTelitve.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgwPosLaktacije);
            this.tabPage3.Location = new System.Drawing.Point(140, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(824, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Laktacije";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgwPosLaktacije
            // 
            this.dgwPosLaktacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPosLaktacije.Location = new System.Drawing.Point(16, 12);
            this.dgwPosLaktacije.Name = "dgwPosLaktacije";
            this.dgwPosLaktacije.Size = new System.Drawing.Size(240, 150);
            this.dgwPosLaktacije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1016, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Življenska prireja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1145, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litrov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1145, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "% Maščobe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1145, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "% Beljakovin";
            // 
            // tbPosBeljakovin
            // 
            this.tbPosBeljakovin.Location = new System.Drawing.Point(1020, 206);
            this.tbPosBeljakovin.Name = "tbPosBeljakovin";
            this.tbPosBeljakovin.Size = new System.Drawing.Size(119, 26);
            this.tbPosBeljakovin.TabIndex = 5;
            // 
            // tbPosMascobe
            // 
            this.tbPosMascobe.Location = new System.Drawing.Point(1020, 166);
            this.tbPosMascobe.Name = "tbPosMascobe";
            this.tbPosMascobe.Size = new System.Drawing.Size(119, 26);
            this.tbPosMascobe.TabIndex = 6;
            // 
            // tbPosLitrov
            // 
            this.tbPosLitrov.Location = new System.Drawing.Point(1020, 99);
            this.tbPosLitrov.Name = "tbPosLitrov";
            this.tbPosLitrov.Size = new System.Drawing.Size(119, 26);
            this.tbPosLitrov.TabIndex = 7;
            // 
            // tbPosImeZiv
            // 
            this.tbPosImeZiv.Location = new System.Drawing.Point(91, 21);
            this.tbPosImeZiv.Name = "tbPosImeZiv";
            this.tbPosImeZiv.Size = new System.Drawing.Size(238, 26);
            this.tbPosImeZiv.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ime živali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ušesna številka";
            // 
            // tbPosUsesStevZiv
            // 
            this.tbPosUsesStevZiv.Location = new System.Drawing.Point(144, 54);
            this.tbPosUsesStevZiv.Name = "tbPosUsesStevZiv";
            this.tbPosUsesStevZiv.Size = new System.Drawing.Size(185, 26);
            this.tbPosUsesStevZiv.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Oče";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mati";
            // 
            // tbPosOce
            // 
            this.tbPosOce.Location = new System.Drawing.Point(409, 21);
            this.tbPosOce.Name = "tbPosOce";
            this.tbPosOce.Size = new System.Drawing.Size(182, 26);
            this.tbPosOce.TabIndex = 15;
            // 
            // tbPosMati
            // 
            this.tbPosMati.Location = new System.Drawing.Point(409, 54);
            this.tbPosMati.Name = "tbPosMati";
            this.tbPosMati.Size = new System.Drawing.Size(182, 26);
            this.tbPosMati.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rojena";
            // 
            // dtpPosRojstvoZiv
            // 
            this.dtpPosRojstvoZiv.Location = new System.Drawing.Point(78, 88);
            this.dtpPosRojstvoZiv.Name = "dtpPosRojstvoZiv";
            this.dtpPosRojstvoZiv.Size = new System.Drawing.Size(251, 26);
            this.dtpPosRojstvoZiv.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1016, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "S povprečno vsebnostjo";
            // 
            // ZivalPosamezno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpPosRojstvoZiv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPosMati);
            this.Controls.Add(this.tbPosOce);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPosUsesStevZiv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPosImeZiv);
            this.Controls.Add(this.tbPosLitrov);
            this.Controls.Add(this.tbPosMascobe);
            this.Controls.Add(this.tbPosBeljakovin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcZival);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ZivalPosamezno";
            this.Text = "Žival Posamezno";
            this.Load += new System.EventHandler(this.ZivalPosamezno_Load);
            this.tcZival.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosOpombe)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosKontrole)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosTelitve)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPosLaktacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcZival;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwPosOpombe;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgwPosKontrole;
        private System.Windows.Forms.DataGridView dgwPosTelitve;
        private System.Windows.Forms.DataGridView dgwPosLaktacije;
        private System.Windows.Forms.TextBox tbPosBeljakovin;
        private System.Windows.Forms.TextBox tbPosMascobe;
        private System.Windows.Forms.TextBox tbPosLitrov;
        private System.Windows.Forms.TextBox tbPosImeZiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPosUsesStevZiv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPosOce;
        private System.Windows.Forms.TextBox tbPosMati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPosRojstvoZiv;
        private System.Windows.Forms.Label label5;
    }
}