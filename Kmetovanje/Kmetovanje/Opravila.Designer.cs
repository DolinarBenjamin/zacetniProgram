namespace Kmetovanje
{
    partial class Opravila
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
            this.dgwOpravila = new System.Windows.Forms.DataGridView();
            this.btnDodajOp = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCenaOpravila = new System.Windows.Forms.TextBox();
            this.tbImeOpravila = new System.Windows.Forms.TextBox();
            this.cbEnotaOpravila = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpravila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOpravila
            // 
            this.dgwOpravila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOpravila.Location = new System.Drawing.Point(25, 22);
            this.dgwOpravila.Name = "dgwOpravila";
            this.dgwOpravila.Size = new System.Drawing.Size(596, 528);
            this.dgwOpravila.TabIndex = 0;
            // 
            // btnDodajOp
            // 
            this.btnDodajOp.Location = new System.Drawing.Point(904, 31);
            this.btnDodajOp.Name = "btnDodajOp";
            this.btnDodajOp.Size = new System.Drawing.Size(95, 41);
            this.btnDodajOp.TabIndex = 1;
            this.btnDodajOp.Text = "Nov zapis";
            this.btnDodajOp.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(655, 31);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(103, 41);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(776, 31);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(96, 41);
            this.btnShrani.TabIndex = 3;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime opravila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cena opravila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena na enoto";
            // 
            // tbCenaOpravila
            // 
            this.tbCenaOpravila.Location = new System.Drawing.Point(680, 244);
            this.tbCenaOpravila.Name = "tbCenaOpravila";
            this.tbCenaOpravila.Size = new System.Drawing.Size(249, 26);
            this.tbCenaOpravila.TabIndex = 7;
            // 
            // tbImeOpravila
            // 
            this.tbImeOpravila.Location = new System.Drawing.Point(681, 165);
            this.tbImeOpravila.Name = "tbImeOpravila";
            this.tbImeOpravila.Size = new System.Drawing.Size(414, 26);
            this.tbImeOpravila.TabIndex = 8;
            // 
            // cbEnotaOpravila
            // 
            this.cbEnotaOpravila.FormattingEnabled = true;
            this.cbEnotaOpravila.Location = new System.Drawing.Point(681, 311);
            this.cbEnotaOpravila.Name = "cbEnotaOpravila";
            this.cbEnotaOpravila.Size = new System.Drawing.Size(248, 28);
            this.cbEnotaOpravila.TabIndex = 9;
            // 
            // Opravila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.cbEnotaOpravila);
            this.Controls.Add(this.tbImeOpravila);
            this.Controls.Add(this.tbCenaOpravila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodajOp);
            this.Controls.Add(this.dgwOpravila);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Opravila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opravila";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpravila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOpravila;
        private System.Windows.Forms.Button btnDodajOp;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCenaOpravila;
        private System.Windows.Forms.TextBox tbImeOpravila;
        private System.Windows.Forms.ComboBox cbEnotaOpravila;
    }
}