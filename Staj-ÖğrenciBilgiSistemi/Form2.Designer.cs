
namespace Staj_ÖğrenciBilgiSistemi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lb_Dersler = new System.Windows.Forms.ListBox();
            this.btn_OncekiSayfa = new System.Windows.Forms.Button();
            this.btn_SonrakiSayfa = new System.Windows.Forms.Button();
            this.btn_DersListele = new System.Windows.Forms.Button();
            this.cb_Dersler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_Dersler
            // 
            this.lb_Dersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_Dersler.FormattingEnabled = true;
            this.lb_Dersler.ItemHeight = 20;
            this.lb_Dersler.Location = new System.Drawing.Point(543, 154);
            this.lb_Dersler.Name = "lb_Dersler";
            this.lb_Dersler.Size = new System.Drawing.Size(355, 184);
            this.lb_Dersler.TabIndex = 0;
            // 
            // btn_OncekiSayfa
            // 
            this.btn_OncekiSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OncekiSayfa.Location = new System.Drawing.Point(543, 365);
            this.btn_OncekiSayfa.Name = "btn_OncekiSayfa";
            this.btn_OncekiSayfa.Size = new System.Drawing.Size(101, 76);
            this.btn_OncekiSayfa.TabIndex = 2;
            this.btn_OncekiSayfa.Text = "Önceki Sayfaya Dön";
            this.btn_OncekiSayfa.UseVisualStyleBackColor = true;
            this.btn_OncekiSayfa.Click += new System.EventHandler(this.btn_OncekiSayfa_Click);
            // 
            // btn_SonrakiSayfa
            // 
            this.btn_SonrakiSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SonrakiSayfa.Location = new System.Drawing.Point(797, 365);
            this.btn_SonrakiSayfa.Name = "btn_SonrakiSayfa";
            this.btn_SonrakiSayfa.Size = new System.Drawing.Size(101, 76);
            this.btn_SonrakiSayfa.TabIndex = 3;
            this.btn_SonrakiSayfa.Text = "Sonraki Sayfa";
            this.btn_SonrakiSayfa.UseVisualStyleBackColor = true;
            this.btn_SonrakiSayfa.Click += new System.EventHandler(this.btn_SonrakiSayfa_Click);
            // 
            // btn_DersListele
            // 
            this.btn_DersListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DersListele.Location = new System.Drawing.Point(672, 74);
            this.btn_DersListele.Name = "btn_DersListele";
            this.btn_DersListele.Size = new System.Drawing.Size(101, 60);
            this.btn_DersListele.TabIndex = 4;
            this.btn_DersListele.Text = "Dersleri Listele";
            this.btn_DersListele.UseVisualStyleBackColor = true;
            this.btn_DersListele.Click += new System.EventHandler(this.btn_DersListele_Click);
            // 
            // cb_Dersler
            // 
            this.cb_Dersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Dersler.FormattingEnabled = true;
            this.cb_Dersler.Items.AddRange(new object[] {
            "1. Yıl 1. Dönem",
            "1. Yıl 2. Dönem",
            "2. Yıl 1. Dönem",
            "2. Yıl 2. Dönem"});
            this.cb_Dersler.Location = new System.Drawing.Point(543, 30);
            this.cb_Dersler.Name = "cb_Dersler";
            this.cb_Dersler.Size = new System.Drawing.Size(355, 28);
            this.cb_Dersler.TabIndex = 5;
            this.cb_Dersler.Text = "Hangi Dönemden Ders Seçeceksiniz?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 453);
            this.Controls.Add(this.cb_Dersler);
            this.Controls.Add(this.btn_DersListele);
            this.Controls.Add(this.btn_SonrakiSayfa);
            this.Controls.Add(this.btn_OncekiSayfa);
            this.Controls.Add(this.lb_Dersler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Kayıt Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Dersler;
        private System.Windows.Forms.Button btn_OncekiSayfa;
        private System.Windows.Forms.Button btn_SonrakiSayfa;
        private System.Windows.Forms.Button btn_DersListele;
        private System.Windows.Forms.ComboBox cb_Dersler;
    }
}