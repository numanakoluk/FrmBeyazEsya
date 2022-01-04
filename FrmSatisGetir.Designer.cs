
namespace FrmBeyazEsya
{
    partial class FrmSatisGetir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatisGetir));
            this.dgwSatisGetir = new System.Windows.Forms.DataGridView();
            this.lblSatisGetir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisGetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSatisGetir
            // 
            this.dgwSatisGetir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSatisGetir.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgwSatisGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSatisGetir.Location = new System.Drawing.Point(1, 184);
            this.dgwSatisGetir.Name = "dgwSatisGetir";
            this.dgwSatisGetir.RowHeadersWidth = 51;
            this.dgwSatisGetir.RowTemplate.Height = 24;
            this.dgwSatisGetir.Size = new System.Drawing.Size(885, 266);
            this.dgwSatisGetir.TabIndex = 0;
            // 
            // lblSatisGetir
            // 
            this.lblSatisGetir.AutoSize = true;
            this.lblSatisGetir.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisGetir.Location = new System.Drawing.Point(272, 84);
            this.lblSatisGetir.Name = "lblSatisGetir";
            this.lblSatisGetir.Size = new System.Drawing.Size(271, 56);
            this.lblSatisGetir.TabIndex = 2;
            this.lblSatisGetir.Text = "Satış Bilgisi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSatisGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSatisGetir);
            this.Controls.Add(this.dgwSatisGetir);
            this.Name = "FrmSatisGetir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisGetir";
            this.Load += new System.EventHandler(this.FrmSatisGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisGetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSatisGetir;
        private System.Windows.Forms.Label lblSatisGetir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}