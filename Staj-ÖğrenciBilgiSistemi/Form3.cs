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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ode_Click(object sender, EventArgs e)
        {
            double faturatutari, taksit, odenecektutar;
            faturatutari = Convert.ToDouble(txt_OdenecekTutar.Text);
            taksit = Convert.ToDouble(txt_Taksit.Text);

            if (txt_Taksit.Text == "")
                odenecektutar = faturatutari;
            else
                odenecektutar = faturatutari / taksit;
            MessageBox.Show(odenecektutar.ToString()+" TL", "Bu Ay Ödenecek Tutar");
        }

        private void btn_OncekiSayfayaDon_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}
