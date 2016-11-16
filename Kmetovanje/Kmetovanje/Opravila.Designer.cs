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
            // Opravila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodajOp);
            this.Controls.Add(this.dgwOpravila);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Opravila";
            this.Text = "Opravila";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpravila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOpravila;
        private System.Windows.Forms.Button btnDodajOp;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnShrani;
    }
}