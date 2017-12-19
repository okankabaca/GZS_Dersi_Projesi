using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GZS_Proje
{
    public partial class formgiris : Form
    {
        public formgiris()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=gzs_vt;Uid=root");

        private void giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from kullanicilar WHERE k_adi='"+k_adi.Text+"' AND k_parola='"+parola.Text+"'", baglanti);
                
            baglanti.Close();
            DataTable dt = new DataTable();
            listele.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                uygulama uyg = new uygulama();
                this.Hide();
                uyg.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void formgiris_Load(object sender, EventArgs e)
        {

         
    

        }

        private void buton_kayitol_Click(object sender, EventArgs e)
        {
            kullanici_kayit kform = new kullanici_kayit();
            this.Hide();
            kform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastakaydi kform = new hastakaydi();
            this.Hide();
            kform.Show();
        }
    }
}
