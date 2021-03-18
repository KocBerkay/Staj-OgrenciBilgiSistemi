
namespace Staj_ÖğrenciBilgiSistemi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_Ode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Taksit = new System.Windows.Forms.TextBox();
            this.txt_OdenecekTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OncekiSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ode
            // 
            this.btn_Ode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ode.Location = new System.Drawing.Point(415, 222);
            this.btn_Ode.Name = "btn_Ode";
            this.btn_Ode.Size = new System.Drawing.Size(100, 36);
            this.btn_Ode.TabIndex = 12;
            this.btn_Ode.Text = "Öde";
            this.btn_Ode.UseVisualStyleBackColor = true;
            this.btn_Ode.Click += new System.EventHandler(this.btn_Ode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taksit(İsteğe Bağlı):";
            // 
            // txt_Taksit
            // 
            this.txt_Taksit.Location = new System.Drawing.Point(415, 159);
            this.txt_Taksit.Name = "txt_Taksit";
            this.txt_Taksit.Size = new System.Drawing.Size(100, 22);
            this.txt_Taksit.TabIndex = 10;
            // 
            // txt_OdenecekTutar
            // 
            this.txt_OdenecekTutar.Location = new System.Drawing.Point(415, 107);
            this.txt_OdenecekTutar.Name = "txt_OdenecekTutar";
            this.txt_OdenecekTutar.Size = new System.Drawing.Size(100, 22);
            this.txt_OdenecekTutar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(264, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ödenecek Tutar:";
            // 
            // btn_OncekiSayfayaDon
            // 
            this.btn_OncekiSayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OncekiSayfayaDon.Location = new System.Drawing.Point(415, 280);
            this.btn_OncekiSayfayaDon.Name = "btn_OncekiSayfayaDon";
            this.btn_OncekiSayfayaDon.Size = new System.Drawing.Size(100, 75);
            this.btn_OncekiSayfayaDon.TabIndex = 7;
            this.btn_OncekiSayfayaDon.Text = "Önceki Sayfaya Dön";
            this.btn_OncekiSayfayaDon.UseVisualStyleBackColor = true;
            this.btn_OncekiSayfayaDon.Click += new System.EventHandler(this.btn_OncekiSayfayaDon_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.btn_Ode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Taksit);
            this.Controls.Add(this.txt_OdenecekTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OncekiSayfayaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dönem Ücreti Ödeme";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Taksit;
        private System.Windows.Forms.TextBox txt_OdenecekTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OncekiSayfayaDon;
    }
}