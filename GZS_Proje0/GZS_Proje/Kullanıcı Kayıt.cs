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
    public partial class kullanici_kayit : Form
    {
        public kullanici_kayit()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=gzs_vt;Uid=root");

        private void button2_Click(object sender, EventArgs e)
        {
            formgiris fgiris = new formgiris();
            this.Close();
            fgiris.Show();
                        
        }

        private void kullanici_kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (text_kadi.Text.Length < 3 && text_kparola.Text.Length<5)
            {
                MessageBox.Show("Kullanıcı adi en az 3 ve parolanız en az 6 hane olmalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglanti.Open();
                MySqlDataAdapter listele = new MySqlDataAdapter("select * from kullanicilar WHERE k_adi='"+text_kadi.Text+"'", baglanti);
                baglanti.Close();
                DataTable dt = new DataTable();
                listele.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Kullanıcı adi mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 else
                {
                    //ekleme
                    string sorgu = "Insert Into kullanicilar(k_adi,k_parola)VALUES ('" + text_kadi.Text + "','" + text_kparola.Text + "')";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    baglanti.Open();
                    int kayit = komut.ExecuteNonQuery();

                    baglanti.Close();
                    if (kayit == 1)
                    {
                        MessageBox.Show("Kaydetme işlemi BAŞARILI");
                    }
                    else
                        MessageBox.Show("kaydetme işlmei başarısz");
                    baglanti.Close();
                }
                
            }
            
        }
        
    }
    
}
