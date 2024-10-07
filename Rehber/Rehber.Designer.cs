namespace Rehber
{
    partial class Rehber
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnyenikisi = new System.Windows.Forms.Button();
            this.btnkisisil = new System.Windows.Forms.Button();
            this.btnkisiguncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REHBER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(690, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnyenikisi
            // 
            this.btnyenikisi.Location = new System.Drawing.Point(15, 12);
            this.btnyenikisi.Name = "btnyenikisi";
            this.btnyenikisi.Size = new System.Drawing.Size(222, 34);
            this.btnyenikisi.TabIndex = 1;
            this.btnyenikisi.Text = "Yeni Kişi Ekle";
            this.btnyenikisi.UseVisualStyleBackColor = true;
            this.btnyenikisi.Click += new System.EventHandler(this.btnyenikisi_Click);
            // 
            // btnkisisil
            // 
            this.btnkisisil.Location = new System.Drawing.Point(484, 12);
            this.btnkisisil.Name = "btnkisisil";
            this.btnkisisil.Size = new System.Drawing.Size(224, 34);
            this.btnkisisil.TabIndex = 2;
            this.btnkisisil.Text = "Kişi Sil";
            this.btnkisisil.UseVisualStyleBackColor = true;
            this.btnkisisil.Click += new System.EventHandler(this.btnkisisil_Click);
            // 
            // btnkisiguncelle
            // 
            this.btnkisiguncelle.Location = new System.Drawing.Point(253, 12);
            this.btnkisiguncelle.Name = "btnkisiguncelle";
            this.btnkisiguncelle.Size = new System.Drawing.Size(214, 34);
            this.btnkisiguncelle.TabIndex = 3;
            this.btnkisiguncelle.Text = "Kişi Güncelle";
            this.btnkisiguncelle.UseVisualStyleBackColor = true;
            this.btnkisiguncelle.Click += new System.EventHandler(this.btnkisiguncelle_Click);
            // 
            // Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.btnkisiguncelle);
            this.Controls.Add(this.btnkisisil);
            this.Controls.Add(this.btnyenikisi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Rehber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnyenikisi;
        private System.Windows.Forms.Button btnkisisil;
        private System.Windows.Forms.Button btnkisiguncelle;
    }
}

