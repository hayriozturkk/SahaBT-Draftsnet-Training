namespace Json
{
    partial class Form1
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
            this.dataGridViewTumu = new System.Windows.Forms.DataGridView();
            this.dataGridViewKadin = new System.Windows.Forms.DataGridView();
            this.dataGridViewErkek = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKadin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErkek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTumu
            // 
            this.dataGridViewTumu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumu.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewTumu.Name = "dataGridViewTumu";
            this.dataGridViewTumu.RowHeadersWidth = 51;
            this.dataGridViewTumu.RowTemplate.Height = 24;
            this.dataGridViewTumu.Size = new System.Drawing.Size(601, 599);
            this.dataGridViewTumu.TabIndex = 1;
            // 
            // dataGridViewKadin
            // 
            this.dataGridViewKadin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewKadin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKadin.Location = new System.Drawing.Point(652, 123);
            this.dataGridViewKadin.Name = "dataGridViewKadin";
            this.dataGridViewKadin.RowHeadersWidth = 51;
            this.dataGridViewKadin.RowTemplate.Height = 24;
            this.dataGridViewKadin.Size = new System.Drawing.Size(601, 599);
            this.dataGridViewKadin.TabIndex = 2;
            // 
            // dataGridViewErkek
            // 
            this.dataGridViewErkek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewErkek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErkek.Location = new System.Drawing.Point(1287, 123);
            this.dataGridViewErkek.Name = "dataGridViewErkek";
            this.dataGridViewErkek.RowHeadersWidth = 51;
            this.dataGridViewErkek.RowTemplate.Height = 24;
            this.dataGridViewErkek.Size = new System.Drawing.Size(601, 599);
            this.dataGridViewErkek.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Listesi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1282, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Erkek Personel Listesi";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(647, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kadın Personel Listesi";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "true";
            this.textBox2.Location = new System.Drawing.Point(17, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ülkeye Göre Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewErkek);
            this.Controls.Add(this.dataGridViewKadin);
            this.Controls.Add(this.dataGridViewTumu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKadin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErkek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridViewTumu;
        private System.Windows.Forms.DataGridView dataGridViewKadin;
        private System.Windows.Forms.DataGridView dataGridViewErkek;
    }
}

