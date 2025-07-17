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
using Microsoft.Data.SqlClient;

namespace Commercial_Automation_Database
{
    public partial class MÜŞTERİLER : Form
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void ilListesi()
        {
            SqlCommand cm = new SqlCommand("Select sehiradi from iller", bgl.baglanti());
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CBIL.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void TXTMODEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void MÜŞTERİLER_Load(object sender, EventArgs e)
        {
            listele();
            ilListesi();
        }

        private void TXTAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBILCE.Items.Clear();
            SqlCommand cm = new SqlCommand("select ilceadi from ilceler where sehirid=@p1", bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", CBIL.SelectedIndex + 1);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CBILCE.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTSOYAD.Text == string.Empty)
            {
                hata = 1;
            }

            if (MTXTTEL.Text == string.Empty)
            {
                hata = 1;
            }

            if (MTXTTC.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTMAIL.Text == string.Empty)
            {
                hata = 1;
            }

            if (CBIL.Text == string.Empty)
            {
                hata = 1;
            }

            if (CBILCE.Text == string.Empty)
            {
                hata = 1;
            }

            if (RTXTADRES.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTVERGI.Text == string.Empty)
            {
                hata = 1;
            }

            if (hata == 1)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu = "insert into TBL_MUSTERILER (AD,SOYADI,TELEFON,TC,MAİL,İL,İLÇE,ADRES,VERGİDAİRESİ) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)";
            SqlCommand cm = new SqlCommand(sorgu, bgl.baglanti());
            cm.Parameters.AddWithValue("@P1", TXTAD.Text);
            cm.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
            cm.Parameters.AddWithValue("@P3", MTXTTEL.Text);
            cm.Parameters.AddWithValue("@P4", MTXTTC.Text);
            cm.Parameters.AddWithValue("@P5", TXTMAIL.Text);
            cm.Parameters.AddWithValue("@P6", CBIL.Text);
            cm.Parameters.AddWithValue("@P7", CBILCE.Text);
            cm.Parameters.AddWithValue("@P8", RTXTADRES.Text);
            cm.Parameters.AddWithValue("@P9", TXTVERGI.Text);
            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
            {
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                TXTID.Clear();
                TXTAD.Clear();
                TXTSOYAD.Clear();
                MTXTTEL.Clear();
                MTXTTC.Clear();
                TXTMAIL.Clear();
                CBIL.SelectedIndex = -1;
                CBILCE.SelectedIndex = -1;
                RTXTADRES.Clear();
                TXTVERGI.Clear();
            }
            else
            {
                MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
