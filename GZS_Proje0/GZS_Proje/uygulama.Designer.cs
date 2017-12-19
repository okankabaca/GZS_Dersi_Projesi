namespace GZS_Proje
{
    partial class uygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uygulama));
            this.nabizal = new System.Windows.Forms.Button();
            this.boyal = new System.Windows.Forms.Button();
            this.anasayfa = new System.Windows.Forms.Button();
            this.nabiz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boy = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_htcler = new System.Windows.Forms.ComboBox();
            this.label_hadi = new System.Windows.Forms.Label();
            this.label_hsoyadi = new System.Windows.Forms.Label();
            this.label_yasi = new System.Windows.Forms.Label();
            this.buton_sonuckayit = new System.Windows.Forms.Button();
            this.sonuclar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buton_detay = new System.Windows.Forms.Button();
            this.sEvet = new System.Windows.Forms.RadioButton();
            this.sHayir = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_nabizsonuc = new System.Windows.Forms.Label();
            this.label_boysonuc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonuclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // nabizal
            // 
            this.nabizal.Location = new System.Drawing.Point(6, 15);
            this.nabizal.Name = "nabizal";
            this.nabizal.Size = new System.Drawing.Size(75, 23);
            this.nabizal.TabIndex = 0;
            this.nabizal.Text = "Ölç";
            this.nabizal.UseVisualStyleBackColor = true;
            this.nabizal.Click += new System.EventHandler(this.nabizal_Click);
            // 
            // boyal
            // 
            this.boyal.Location = new System.Drawing.Point(6, 16);
            this.boyal.Name = "boyal";
            this.boyal.Size = new System.Drawing.Size(75, 23);
            this.boyal.TabIndex = 1;
            this.boyal.Text = "Ölç";
            this.boyal.UseVisualStyleBackColor = true;
            this.boyal.Click += new System.EventHandler(this.boyal_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.Location = new System.Drawing.Point(12, 168);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(97, 23);
            this.anasayfa.TabIndex = 2;
            this.anasayfa.Text = "Anasayfaya Dön";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // nabiz
            // 
            this.nabiz.AutoSize = true;
            this.nabiz.Location = new System.Drawing.Point(141, 25);
            this.nabiz.Name = "nabiz";
            this.nabiz.Size = new System.Drawing.Size(34, 13);
            this.nabiz.TabIndex = 3;
            this.nabiz.Text = "Nabız";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boy);
            this.groupBox1.Controls.Add(this.boyal);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boy";
            // 
            // boy
            // 
            this.boy.AutoSize = true;
            this.boy.Location = new System.Drawing.Point(141, 26);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(25, 13);
            this.boy.TabIndex = 4;
            this.boy.Text = "Boy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nabiz);
            this.groupBox2.Controls.Add(this.nabizal);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nabız";
            // 
            // combo_htcler
            // 
            this.combo_htcler.FormattingEnabled = true;
            this.combo_htcler.Location = new System.Drawing.Point(262, 20);
            this.combo_htcler.Name = "combo_htcler";
            this.combo_htcler.Size = new System.Drawing.Size(138, 21);
            this.combo_htcler.TabIndex = 7;
            this.combo_htcler.SelectedValueChanged += new System.EventHandler(this.combo_htcler_SelectedValueChanged);
            // 
            // label_hadi
            // 
            this.label_hadi.AutoSize = true;
            this.label_hadi.Location = new System.Drawing.Point(259, 45);
            this.label_hadi.Name = "label_hadi";
            this.label_hadi.Size = new System.Drawing.Size(53, 13);
            this.label_hadi.TabIndex = 8;
            this.label_hadi.Text = "Hasta Adı";
            // 
            // label_hsoyadi
            // 
            this.label_hsoyadi.AutoSize = true;
            this.label_hsoyadi.Location = new System.Drawing.Point(259, 68);
            this.label_hsoyadi.Name = "label_hsoyadi";
            this.label_hsoyadi.Size = new System.Drawing.Size(70, 13);
            this.label_hsoyadi.TabIndex = 9;
            this.label_hsoyadi.Text = "Hasta Soyadı";
            // 
            // label_yasi
            // 
            this.label_yasi.AutoSize = true;
            this.label_yasi.Location = new System.Drawing.Point(259, 92);
            this.label_yasi.Name = "label_yasi";
            this.label_yasi.Size = new System.Drawing.Size(58, 13);
            this.label_yasi.TabIndex = 10;
            this.label_yasi.Text = "Hasta Yaşı";
            // 
            // buton_sonuckayit
            // 
            this.buton_sonuckayit.Location = new System.Drawing.Point(262, 127);
            this.buton_sonuckayit.Name = "buton_sonuckayit";
            this.buton_sonuckayit.Size = new System.Drawing.Size(115, 23);
            this.buton_sonuckayit.TabIndex = 11;
            this.buton_sonuckayit.Text = "Sonuçları kaydet";
            this.buton_sonuckayit.UseVisualStyleBackColor = true;
            this.buton_sonuckayit.Click += new System.EventHandler(this.buton_sonuckayit_Click);
            // 
            // sonuclar
            // 
            this.sonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sonuclar.Location = new System.Drawing.Point(12, 240);
            this.sonuclar.Name = "sonuclar";
            this.sonuclar.Size = new System.Drawing.Size(406, 150);
            this.sonuclar.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buton_detay
            // 
            this.buton_detay.Location = new System.Drawing.Point(12, 203);
            this.buton_detay.Name = "buton_detay";
            this.buton_detay.Size = new System.Drawing.Size(97, 23);
            this.buton_detay.TabIndex = 14;
            this.buton_detay.Text = "Detayları Gör";
            this.buton_detay.UseVisualStyleBackColor = true;
            this.buton_detay.Click += new System.EventHandler(this.buton_detay_Click);
            // 
            // sEvet
            // 
            this.sEvet.AutoSize = true;
            this.sEvet.Location = new System.Drawing.Point(3, 19);
            this.sEvet.Name = "sEvet";
            this.sEvet.Size = new System.Drawing.Size(47, 17);
            this.sEvet.TabIndex = 15;
            this.sEvet.TabStop = true;
            this.sEvet.Text = "Evet";
            this.sEvet.UseVisualStyleBackColor = true;
            this.sEvet.CheckedChanged += new System.EventHandler(this.sEvet_CheckedChanged);
            // 
            // sHayir
            // 
            this.sHayir.AutoSize = true;
            this.sHayir.Location = new System.Drawing.Point(3, 35);
            this.sHayir.Name = "sHayir";
            this.sHayir.Size = new System.Drawing.Size(49, 17);
            this.sHayir.TabIndex = 16;
            this.sHayir.TabStop = true;
            this.sHayir.Text = "Hayır";
            this.sHayir.UseVisualStyleBackColor = true;
            this.sHayir.CheckedChanged += new System.EventHandler(this.sHayir_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sHayir);
            this.groupBox3.Controls.Add(this.sEvet);
            this.groupBox3.Location = new System.Drawing.Point(301, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 57);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spor yapıyor mu?";
            // 
            // label_nabizsonuc
            // 
            this.label_nabizsonuc.AutoSize = true;
            this.label_nabizsonuc.Location = new System.Drawing.Point(12, 23);
            this.label_nabizsonuc.MaximumSize = new System.Drawing.Size(180, 0);
            this.label_nabizsonuc.Name = "label_nabizsonuc";
            this.label_nabizsonuc.Size = new System.Drawing.Size(76, 16);
            this.label_nabizsonuc.TabIndex = 18;
            this.label_nabizsonuc.Text = "Nabız sonuç";
            // 
            // label_boysonuc
            // 
            this.label_boysonuc.AutoSize = true;
            this.label_boysonuc.Location = new System.Drawing.Point(12, 93);
            this.label_boysonuc.MaximumSize = new System.Drawing.Size(180, 0);
            this.label_boysonuc.Name = "label_boysonuc";
            this.label_boysonuc.Size = new System.Drawing.Size(65, 16);
            this.label_boysonuc.TabIndex = 19;
            this.label_boysonuc.Text = "Boy sonuç";
            this.label_boysonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_boysonuc);
            this.groupBox4.Controls.Add(this.label_nabizsonuc);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(424, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 149);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonuçlar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radio_kadin);
            this.groupBox5.Controls.Add(this.radio_erkek);
            this.groupBox5.Location = new System.Drawing.Point(168, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 57);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cinsiyet";
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Location = new System.Drawing.Point(3, 35);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(52, 17);
            this.radio_kadin.TabIndex = 16;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            this.radio_kadin.CheckedChanged += new System.EventHandler(this.radio_kadin_CheckedChanged);
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(3, 19);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 17);
            this.radio_erkek.TabIndex = 15;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            this.radio_erkek.CheckedChanged += new System.EventHandler(this.radio_erkek_CheckedChanged);
            // 
            // uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(648, 232);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buton_detay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonuclar);
            this.Controls.Add(this.buton_sonuckayit);
            this.Controls.Add(this.label_yasi);
            this.Controls.Add(this.label_hsoyadi);
            this.Controls.Add(this.label_hadi);
            this.Controls.Add(this.combo_htcler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anasayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "uygulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uygulama";
            this.Load += new System.EventHandler(this.uygulama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonuclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nabizal;
        private System.Windows.Forms.Button boyal;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Label nabiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_htcler;
        private System.Windows.Forms.Label label_hadi;
        private System.Windows.Forms.Label label_hsoyadi;
        private System.Windows.Forms.Label label_yasi;
        private System.Windows.Forms.Button buton_sonuckayit;
        private System.Windows.Forms.DataGridView sonuclar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buton_detay;
        private System.Windows.Forms.Label boy;
        private System.Windows.Forms.RadioButton sEvet;
        private System.Windows.Forms.RadioButton sHayir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_nabizsonuc;
        private System.Windows.Forms.Label label_boysonuc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.RadioButton radio_erkek;
    }
}