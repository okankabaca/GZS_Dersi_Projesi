using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GZS_Proje
{
    public partial class uygulama : Form
    {
        SerialPort seriPort;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=gzs_vt;Uid=root");
        public uygulama()
        {
            InitializeComponent();
            seriPort = new SerialPort();
            seriPort.PortName = "COM3";
            seriPort.BaudRate = 9600;

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
             formgiris fgiris = new formgiris();
             fgiris.Show();
             this.Close();
                
            }
        }

        private void uygulama_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT *FROM hastalar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combo_htcler.Items.Add(dr["h_tc"]);
            }
            baglanti.Close();

            combo_htcler.SelectedItem = combo_htcler.Items[0];
            
              
            

        }




        private void nabizal_Click(object sender, EventArgs e)
        {
            seriPort.Open();
            seriPort.WriteLine("1");
            Thread.Sleep(1000);
            nabiz.Text = (seriPort.ReadExisting());
            seriPort.Close();
            Class1.olculennabiz  = Convert.ToDouble(nabiz.Text);
            

        }

        private void boyal_Click(object sender, EventArgs e)
        {
            
            seriPort.Open();
            seriPort.WriteLine("2");
            Thread.Sleep(1000);
            boy.Text = seriPort.ReadExisting();
            seriPort.Close();
            Class1.olculenboy = Convert.ToInt32(boy.Text);
                       
        
        }

        private void combo_htcler_SelectedValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT * FROM hastalar where h_tc='"+combo_htcler.SelectedItem.ToString()+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label_hadi.Text = dr["h_adi"].ToString();
                label_hsoyadi.Text = dr["h_soyadi"].ToString();
                label_yasi.Text = (System.DateTime.Now.Year - Convert.ToInt32(dr["h_dogumyili"])).ToString();
                Class1.yas = Convert.ToInt32(label_yasi.Text.ToString());
            }
            
             baglanti.Close();
            sonuclarılistele(combo_htcler.SelectedItem.ToString());
            
        }

        private void buton_sonuckayit_Click(object sender, EventArgs e)
        {
            if(nabiz.Text=="Nabız" || boy.Text == "Boy")
            {
                MessageBox.Show("Nabız yada boyu ölçünüz");
            }
            else
            {
                string sorgu = "Insert Into sonuclar(s_tc,s_nabiz,s_boy)VALUES ('" + combo_htcler.SelectedItem.ToString() + "','" + nabiz.Text + "','" + boy.Text + "')";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                int kayit = komut.ExecuteNonQuery();

                baglanti.Close();
                if (kayit == 1)
                {
                    MessageBox.Show("Kaydetme işlemi BAŞARILI");
                    sonuclarılistele(combo_htcler.SelectedItem.ToString());
                    if (this.Height != 430)
                    {
                        this.SetDesktopLocation(this.Location.X, this.Location.Y - 80);

                    }
                    
                    this.Height = 430;
                    

                }
                else
                {
                    MessageBox.Show("kaydetme işlmei başarısz");
                    
                }
                
            }
        }
        public void sonuclarılistele(string tc)
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from sonuclar WHERE s_tc='" + tc + "'", baglanti);
            baglanti.Close();
            DataTable dt = new DataTable();
            listele.Fill(dt);
            sonuclar.DataSource = dt;

        }

        private void buton_detay_Click(object sender, EventArgs e)
        {
            if (this.Height != 430)
            {
                this.SetDesktopLocation(this.Location.X, this.Location.Y - 80);

            }
            this.Height = 430;

            if (nabiz.Text == "Nabız" || boy.Text=="Boy")
            {
                MessageBox.Show("Nabız veya boy ölçümü yapmadınız.");
            }
            else if (Class1.cinsiyet=="")
            {
                MessageBox.Show("Lütfen cinsiyet belirtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
            {
                label_nabizsonuc.Text = Class1.nabizsonuc(Convert.ToDouble(nabiz.Text.ToString()) / 100);
                label_boysonuc.Text = Class1.boysonuc(Convert.ToInt32(boy.Text));
            }
                
                
            
        }

        private void sEvet_CheckedChanged(object sender, EventArgs e)
        {
            Class1.spor = true;
        }

        private void sHayir_CheckedChanged(object sender, EventArgs e)
        {
            Class1.spor = false;
        }

        private void radio_erkek_CheckedChanged(object sender, EventArgs e)
        {
            Class1.cinsiyet = "Erkek";
        }

        private void radio_kadin_CheckedChanged(object sender, EventArgs e)
        {
            Class1.cinsiyet = "Kadın";
        }
    }
}
