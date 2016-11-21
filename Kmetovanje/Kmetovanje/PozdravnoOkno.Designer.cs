namespace Kmetovanje
{
    partial class PozdravnoOkno
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
            this.btnPolje = new System.Windows.Forms.Button();
            this.btnHlev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPolje
            // 
            this.btnPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPolje.Location = new System.Drawing.Point(168, 114);
            this.btnPolje.Name = "btnPolje";
            this.btnPolje.Size = new System.Drawing.Size(123, 54);
            this.btnPolje.TabIndex = 0;
            this.btnPolje.Text = "Polje";
            this.btnPolje.UseVisualStyleBackColor = true;
            this.btnPolje.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHlev
            // 
            this.btnHlev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHlev.Location = new System.Drawing.Point(770, 114);
            this.btnHlev.Name = "btnHlev";
            this.btnHlev.Size = new System.Drawing.Size(132, 54);
            this.btnHlev.TabIndex = 1;
            this.btnHlev.Text = "Hlev";
            this.btnHlev.UseVisualStyleBackColor = true;
            this.btnHlev.Click += new System.EventHandler(this.button2_Click);
            // 
            // PozdravnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 581);
            this.Controls.Add(this.btnHlev);
            this.Controls.Add(this.btnPolje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PozdravnoOkno";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPolje;
        private System.Windows.Forms.Button btnHlev;
    }
}

