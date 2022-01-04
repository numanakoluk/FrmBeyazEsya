
namespace FrmBeyazEsya
{
    partial class FrmFiyataGoreSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiyataGoreSatis));
            this.dgwFiyataGoreSatis = new System.Windows.Forms.DataGridView();
            this.lblFiyataGore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiyataGoreSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFiyataGoreSatis
            // 
            this.dgwFiyataGoreSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFiyataGoreSatis.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgwFiyataGoreSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFiyataGoreSatis.Location = new System.Drawing.Point(4, 285);
            this.dgwFiyataGoreSatis.Name = "dgwFiyataGoreSatis";
            this.dgwFiyataGoreSatis.RowHeadersWidth = 51;
            this.dgwFiyataGoreSatis.RowTemplate.Height = 24;
            this.dgwFiyataGoreSatis.Size = new System.Drawing.Size(796, 162);
            this.dgwFiyataGoreSatis.TabIndex = 0;
            // 
            // lblFiyataGore
            // 
            this.lblFiyataGore.AutoSize = true;
            this.lblFiyataGore.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyataGore.Location = new System.Drawing.Point(195, 140);
            this.lblFiyataGore.Name = "lblFiyataGore";
            this.lblFiyataGore.Size = new System.Drawing.Size(387, 56);
            this.lblFiyataGore.TabIndex = 3;
            this.lblFiyataGore.Text = "Fiyata Göre Satis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFiyataGoreSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFiyataGore);
            this.Controls.Add(this.dgwFiyataGoreSatis);
            this.Name = "FrmFiyataGoreSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiyataGoreSatis";
            this.Load += new System.EventHandler(this.FiyataGoreSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiyataGoreSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFiyataGoreSatis;
        private System.Windows.Forms.Label lblFiyataGore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}