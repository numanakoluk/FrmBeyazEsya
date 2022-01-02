
namespace FrmBeyazEsya
{
    partial class FrmStokBilgiGetir
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
            this.dgwStokBilgi = new System.Windows.Forms.DataGridView();
            this.lblStokBilgisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStokBilgi
            // 
            this.dgwStokBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStokBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStokBilgi.Location = new System.Drawing.Point(3, 205);
            this.dgwStokBilgi.Name = "dgwStokBilgi";
            this.dgwStokBilgi.RowHeadersWidth = 51;
            this.dgwStokBilgi.RowTemplate.Height = 24;
            this.dgwStokBilgi.Size = new System.Drawing.Size(994, 251);
            this.dgwStokBilgi.TabIndex = 0;
            // 
            // lblStokBilgisi
            // 
            this.lblStokBilgisi.AutoSize = true;
            this.lblStokBilgisi.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokBilgisi.Location = new System.Drawing.Point(342, 81);
            this.lblStokBilgisi.Name = "lblStokBilgisi";
            this.lblStokBilgisi.Size = new System.Drawing.Size(264, 56);
            this.lblStokBilgisi.TabIndex = 1;
            this.lblStokBilgisi.Text = "Stok Bilgisi";
            // 
            // FrmStokBilgiGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(997, 456);
            this.Controls.Add(this.lblStokBilgisi);
            this.Controls.Add(this.dgwStokBilgi);
            this.Name = "FrmStokBilgiGetir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Bilgi Getir";
            this.Load += new System.EventHandler(this.FrmStokBilgiGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStokBilgi;
        private System.Windows.Forms.Label lblStokBilgisi;
    }
}