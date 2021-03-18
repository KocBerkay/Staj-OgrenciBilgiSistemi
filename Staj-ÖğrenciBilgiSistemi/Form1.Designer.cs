
namespace Staj_ÖğrenciBilgiSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_OgrenciSil = new System.Windows.Forms.Button();
            this.btn_SifreGuncelle = new System.Windows.Forms.Button();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_OgrenciNo = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OgrenciGoruntule = new System.Windows.Forms.Button();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(581, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 343);
            this.dataGridView1.TabIndex = 38;
            // 
            // btn_OgrenciSil
            // 
            this.btn_OgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciSil.Location = new System.Drawing.Point(236, 349);
            this.btn_OgrenciSil.Name = "btn_OgrenciSil";
            this.btn_OgrenciSil.Size = new System.Drawing.Size(85, 55);
            this.btn_OgrenciSil.TabIndex = 37;
            this.btn_OgrenciSil.Text = "Öğrenci Sil";
            this.btn_OgrenciSil.UseVisualStyleBackColor = true;
            this.btn_OgrenciSil.Click += new System.EventHandler(this.btn_OgrenciSil_Click);
            // 
            // btn_SifreGuncelle
            // 
            this.btn_SifreGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SifreGuncelle.Location = new System.Drawing.Point(354, 349);
            this.btn_SifreGuncelle.Name = "btn_SifreGuncelle";
            this.btn_SifreGuncelle.Size = new System.Drawing.Size(85, 55);
            this.btn_SifreGuncelle.TabIndex = 36;
            this.btn_SifreGuncelle.Text = "Şifre Güncelle";
            this.btn_SifreGuncelle.UseVisualStyleBackColor = true;
            this.btn_SifreGuncelle.Click += new System.EventHandler(this.btn_SifreGuncelle_Click);
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitOl.Location = new System.Drawing.Point(354, 288);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(85, 55);
            this.btn_KayitOl.TabIndex = 35;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click_1);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(236, 107);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(168, 26);
            this.txt_Soyad.TabIndex = 33;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(236, 194);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(168, 26);
            this.txt_Sifre.TabIndex = 32;
            // 
            // txt_OgrenciNo
            // 
            this.txt_OgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_OgrenciNo.Location = new System.Drawing.Point(236, 154);
            this.txt_OgrenciNo.Name = "txt_OgrenciNo";
            this.txt_OgrenciNo.Size = new System.Drawing.Size(168, 26);
            this.txt_OgrenciNo.TabIndex = 31;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(236, 61);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(168, 26);
            this.txt_Ad.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(109, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ad:";
            // 
            // btn_OgrenciGoruntule
            // 
            this.btn_OgrenciGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciGoruntule.Location = new System.Drawing.Point(113, 291);
            this.btn_OgrenciGoruntule.Name = "btn_OgrenciGoruntule";
            this.btn_OgrenciGoruntule.Size = new System.Drawing.Size(95, 113);
            this.btn_OgrenciGoruntule.TabIndex = 39;
            this.btn_OgrenciGoruntule.Text = "Öğrencileri Görüntüle";
            this.btn_OgrenciGoruntule.UseVisualStyleBackColor = true;
            this.btn_OgrenciGoruntule.Click += new System.EventHandler(this.btn_OgrenciGoruntule_Click);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.Location = new System.Drawing.Point(236, 288);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(85, 55);
            this.btn_GirisYap.TabIndex = 40;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 453);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.btn_OgrenciGoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_OgrenciSil);
            this.Controls.Add(this.btn_SifreGuncelle);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_OgrenciNo);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_OgrenciSil;
        private System.Windows.Forms.Button btn_SifreGuncelle;
        private System.Windows.Forms.Button btn_KayitOl;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_OgrenciNo;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OgrenciGoruntule;
        private System.Windows.Forms.Button btn_GirisYap;
    }
}

