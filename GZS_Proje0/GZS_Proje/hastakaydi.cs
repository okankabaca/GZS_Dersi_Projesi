using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GZS_Proje
{
    public partial class hastakaydi : Form
    {
        public hastakaydi()
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

        private void button1_Click(object sender, EventArgs e)
        {
            

                if (text_hadi.Text.Length < 1 && text_hsoyadi.Text.Length < 1 && text_hdogumyili.Text.Length != 4 && text_htc.Text.Length != 11)
                {
                    MessageBox.Show("Lütfen alanları doğru doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    baglanti.Open();
                    MySqlDataAdapter listele = new MySqlDataAdapter("select * from hastalar WHERE h_tc='" + text_htc.Text + "'", baglanti);
                    baglanti.Close();
                    DataTable dt = new DataTable();
                    listele.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Bu hasta zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //ekleme
                        string sorgu = "Insert Into hastalar(h_tc,h_adi,h_soyadi,h_dogumyili)VALUES ('" + text_htc.Text + "','" + text_hadi.Text + "','" + text_hsoyadi.Text + "','" + text_hdogumyili.Text + "')";

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

        private void text_htc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
