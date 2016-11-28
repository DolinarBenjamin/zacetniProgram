namespace Kmetovanje
{
    partial class OpombeUS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbopomba = new System.Windows.Forms.TextBox();
            this.lbopomba = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.lbdatum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btizbriši = new System.Windows.Forms.Button();
            this.bturejanje = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.Controls.Add(this.tbopomba, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbopomba, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbstatus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbdatum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 134);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tbopomba
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbopomba, 2);
            this.tbopomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbopomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbopomba.Location = new System.Drawing.Point(5, 45);
            this.tbopomba.Multiline = true;
            this.tbopomba.Name = "tbopomba";
            this.tbopomba.ReadOnly = true;
            this.tbopomba.Size = new System.Drawing.Size(474, 84);
            this.tbopomba.TabIndex = 5;
            this.tbopomba.DoubleClick += new System.EventHandler(this.tbopomba_DoubleClick);
            // 
            // lbopomba
            // 
            this.lbopomba.AutoSize = true;
            this.lbopomba.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbopomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbopomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbopomba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbopomba.Location = new System.Drawing.Point(5, 2);
            this.lbopomba.Name = "lbopomba";
            this.lbopomba.Size = new System.Drawing.Size(233, 38);
            this.lbopomba.TabIndex = 1;
            this.lbopomba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbstatus.ForeColor = System.Drawing.Color.Red;
            this.lbstatus.Location = new System.Drawing.Point(487, 2);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(270, 38);
            this.lbstatus.TabIndex = 7;
            this.lbstatus.Text = "Odprto";
            this.lbstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbstatus.DoubleClick += new System.EventHandler(this.lbstatus_DoubleClick);
            // 
            // lbdatum
            // 
            this.lbdatum.AutoSize = true;
            this.lbdatum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdatum.Location = new System.Drawing.Point(246, 2);
            this.lbdatum.Name = "lbdatum";
            this.lbdatum.Size = new System.Drawing.Size(233, 38);
            this.lbdatum.TabIndex = 8;
            this.lbdatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btizbriši);
            this.panel2.Controls.Add(this.bturejanje);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(487, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 84);
            this.panel2.TabIndex = 9;
            // 
            // btizbriši
            // 
            this.btizbriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btizbriši.Location = new System.Drawing.Point(79, 39);
            this.btizbriši.Name = "btizbriši";
            this.btizbriši.Size = new System.Drawing.Size(96, 27);
            this.btizbriši.TabIndex = 4;
            this.btizbriši.Text = "Izbriši";
            this.btizbriši.UseVisualStyleBackColor = true;
            this.btizbriši.Click += new System.EventHandler(this.btizbriši_Click);
            // 
            // bturejanje
            // 
            this.bturejanje.Enabled = false;
            this.bturejanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bturejanje.Location = new System.Drawing.Point(79, 10);
            this.bturejanje.Name = "bturejanje";
            this.bturejanje.Size = new System.Drawing.Size(96, 27);
            this.bturejanje.TabIndex = 3;
            this.bturejanje.Text = "Uredi";
            this.bturejanje.UseVisualStyleBackColor = true;
            this.bturejanje.Click += new System.EventHandler(this.bturejanje_Click);
            // 
            // OpombeUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OpombeUS";
            this.Size = new System.Drawing.Size(771, 150);
            this.Load += new System.EventHandler(this.OpombeUS_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbopomba;
        private System.Windows.Forms.Label lbopomba;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label lbdatum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btizbriši;
        private System.Windows.Forms.Button bturejanje;
    }
}
