using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_ÖğrenciBilgiSistemi
{
    public partial class Form2 : Form
    {      

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_OncekiSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btn_SonrakiSayfa_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
            form3.Show();
        }

        private void btn_DersListele_Click(object sender, EventArgs e)
        {
            lb_Dersler.Items.Clear();
            if (cb_Dersler.SelectedIndex==0)
            {
                lb_Dersler.Items.Add("Programlama Temelleri");
                lb_Dersler.Items.Add("Matematik I");
                lb_Dersler.Items.Add("İngilizce I");
                lb_Dersler.Items.Add("Tarih I ");
                lb_Dersler.Items.Add("Türkçe I");
                lb_Dersler.Items.Add("Web Tasarım Temelleri");
                lb_Dersler.Items.Add("Veri Tabanı I");

                MessageBox.Show("Bu Dönem Alacağınız Toplam Ders Yükü(AKTS) --> 35 ");
            }

            else if(cb_Dersler.SelectedIndex==1)
            {
                lb_Dersler.Items.Add("İngilizce II");
                lb_Dersler.Items.Add("Nesne Tabanlı Programlama I");
                lb_Dersler.Items.Add("Görsel Programlama");
                lb_Dersler.Items.Add("Tarih II");
                lb_Dersler.Items.Add("Veri Tabanı II");
                lb_Dersler.Items.Add("Türkçe II");
                lb_Dersler.Items.Add("İnternet Programcılığı");

                MessageBox.Show("Bu Dönem Alacağınız Toplam Ders Yükü(AKTS) --> 30 ");
            }

            else if (cb_Dersler.SelectedIndex == 2)
            {
                lb_Dersler.Items.Add("Seçmeli Ders I");
                lb_Dersler.Items.Add("Seçmeli Ders II");
                lb_Dersler.Items.Add("Seçmeli Ders III");
                lb_Dersler.Items.Add("İnternet Programcılığı II");
                lb_Dersler.Items.Add("Veri Tabanı ve Yönetimi");
                lb_Dersler.Items.Add("Nesne Tabanlı Programlama");
                lb_Dersler.Items.Add("Görsel Programlama II");

                MessageBox.Show("Bu Dönem Alacağınız Toplam Ders Yükü(AKTS) --> 40 ");
            }

            else if (cb_Dersler.SelectedIndex == 3)
            {
                lb_Dersler.Items.Add("Seçmeli Ders IV");
                lb_Dersler.Items.Add("Seçmeli Ders V");
                lb_Dersler.Items.Add("Bilgisayar Donanımı");
                lb_Dersler.Items.Add("Web Editörü");
                lb_Dersler.Items.Add("Sistem Analizi ve Tasarımı");
                lb_Dersler.Items.Add("Sunucu İşletim Sistemi");

                MessageBox.Show("Bu Dönem Alacağınız Toplam Ders Yükü(AKTS) --> 25 ");
            }
        }
    }
}
