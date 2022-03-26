using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLogicLayer;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace OgrenciNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void OgrenciListesi()
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.Listele();
            dataGridView1.DataSource = OgrList;
            this.Text = "Öğrenci Listesi";


        }

        void NotListesi()
        {
            List<EntityNotlar> NotList = BLLNotlar.Listele();
            dataGridView1.DataSource = NotList;
            this.Text = "Not Listesi";
        }

        void KulupListesi()
        {
            List<EntityKulup> KulupList = BLLKulup.Listele();
            cmbKulup.DataSource = KulupList;
            cmbKulup.DisplayMember = "KulupAd";
            cmbKulup.ValueMember = "KulupID";
            cmbKulup.Text = "Seçiniz";
            dataGridView1.DataSource = KulupList;
            this.Text = "Kulüp Listesi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            KulupListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OgrenciListesi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Fotograf = txtFotograf.Text;
            ent.KulupID = Convert.ToInt16(cmbKulup.SelectedValue);
            BLLOgrenci.Ekle(ent);
            MessageBox.Show("Öğrenci Kaydı Yapıldı.");
            OgrenciListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Fotograf = txtFotograf.Text;
            ent.KulupID = Convert.ToInt16(cmbKulup.SelectedValue);
            ent.ID = Convert.ToInt16(txtID.Text);
            BLLOgrenci.Guncelle(ent);
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            OgrenciListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Öğrenci Listesi")

            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtFotograf.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }

            if (this.Text == "Not Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtNotlarOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                txtSinav1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtSinav2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtSinav3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txtProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                txtOrtalama.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                txtDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                
            }
            if (this.Text == "Kulüp Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtKulupID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtKulupAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            }
        }

        private void btnNotlarListele_Click(object sender, EventArgs e)
        {
            NotListesi();
        }

        private void btnNotlarGuncelle_Click(object sender, EventArgs e)
        {
            EntityNotlar ent = new EntityNotlar();
            ent.OgrID = Convert.ToInt16(txtNotlarOgrId.Text);
            ent.Sinav1 = Convert.ToInt16(txtSinav1.Text);
            ent.Sinav2 = Convert.ToInt16(txtSinav2.Text);
            ent.Sinav3 = Convert.ToInt16(txtSinav3.Text);
            ent.Proje = Convert.ToInt16(txtProje.Text);
            ent.Ortalama = Convert.ToInt16(txtOrtalama.Text);
            ent.Durum = txtDurum.Text;
            BLLNotlar.Guncelle(ent);
            MessageBox.Show("Notlar Güncellendi.");
            NotListesi();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, proje;
            double ortalama;
            string durum;

            s1 = Convert.ToInt16(txtSinav1.Text);
            s2 = Convert.ToInt16(txtSinav2.Text);
            s3 = Convert.ToInt16(txtSinav3.Text);
            proje = Convert.ToInt16(txtProje.Text);

            ortalama = (s1 + s2 + s3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();

            if (ortalama>= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            txtDurum.Text = durum;
        }

        private void btnKulupListele_Click(object sender, EventArgs e)
        {
            KulupListesi();
        }

        private void btnKulupKaydet_Click(object sender, EventArgs e)
        {
            EntityKulup ent = new EntityKulup();
            ent.KulupAd = txtKulupAd.Text;
            BLLKulup.Ekle(ent);
            KulupListesi();
        }

        private void btnKulupSil_Click(object sender, EventArgs e)
        {
            EntityKulup ent = new EntityKulup();
            ent.KulupID = Convert.ToInt16(txtKulupID.Text);
            BLLKulup.Sil(ent.KulupID);
            KulupListesi();
        }

        private void btnKulupGuncelle_Click(object sender, EventArgs e)
        {
            EntityKulup ent = new EntityKulup();
            ent.KulupAd = txtKulupAd.Text;
            ent.KulupID = Convert.ToInt16(txtKulupID.Text);
            BLLKulup.Guncelle(ent);
            KulupListesi();
        }
    }
}
