using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staj_ÖğrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        Form2 form2=new Form2();
       
        public Form1()
        {
            InitializeComponent();
        }

        void OgrenciGetir()
        {
            baglanti = new SqlConnection("Server=.\\SQLEXPRESS; Initial Catalog=Staj-OgrenciBilgiSistemi; Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void btn_OgrenciGoruntule_Click(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void btn_OgrenciSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Ogrenciler where No=@ogrencino";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogrencino", Convert.ToInt32(txt_OgrenciNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void btn_SifreGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Ogrenciler set Ad=@ad,Soyad=@soyad,No=@ogrencino,Sifre=@sifre where No=@ogrencino";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@ogrencino", txt_OgrenciNo.Text);
            komut.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void btn_KayitOl_Click_1(object sender, EventArgs e)
        {
            string sorgu = "Insert into Ogrenciler(Ad,Soyad,No,Sifre) values(@ad,@soyad,@ogrencino,@sifre)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@ogrencino", txt_OgrenciNo.Text);
            komut.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "Berkay" & txt_Soyad.Text == "Koç" & txt_OgrenciNo.Text == "1" & txt_Sifre.Text == "sifre1")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Hüseyin" & txt_Soyad.Text == "Koç" & txt_OgrenciNo.Text == "2" & txt_Sifre.Text == "sifre2")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Ülkü" & txt_Soyad.Text == "Koç" & txt_OgrenciNo.Text == "3" & txt_Sifre.Text == "sifre3")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Simay" & txt_Soyad.Text == "Koç" & txt_OgrenciNo.Text == "4" & txt_Sifre.Text == "sifre4")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Emin" & txt_Soyad.Text == "Çağlar" & txt_OgrenciNo.Text == "5" & txt_Sifre.Text == "sifre5")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Birşeyleri Yanlış Girdiniz!");
        }
    }
}
