using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Automation_Database
{
    public partial class SİRKETLER : Form
    {
        public SİRKETLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_SIRKETLER", bgl.baglanti());
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTYTKL.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTYAD.Text == string.Empty)
            {
                hata = 1;
            }

            if (MTXTTEL.Text == string.Empty)
            {
                hata = 1;
            }

            if (MTXTTEL2.Text == string.Empty)
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

            if (TXTVER.Text == string.Empty)
            {
                hata = 1;
            }
            if (RTXTADRES.Text == string.Empty)
            {
                hata = 1;
            }
            if (TXTFALLIYET.Text == string.Empty)
            {
                hata = 1;
            }

            if (hata == 1)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu = "insert into TBL_SIRKETLER (AD,YETKILI,YETKILIADSOYAD,TELEFON1,TELEFON2,MAIL,IL,ILCE,VERGIDAIRESI,ADRES,FALLIYET) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)";
            SqlCommand cm = new SqlCommand(sorgu, bgl.baglanti());
            cm.Parameters.AddWithValue("@P1", TXTAD.Text);
            cm.Parameters.AddWithValue("@P2", TXTYTKL.Text);
            cm.Parameters.AddWithValue("@P3", TXTYAD.Text);
            cm.Parameters.AddWithValue("@P4", MTXTTEL.Text);
            cm.Parameters.AddWithValue("@P5", MTXTTEL2.Text);
            cm.Parameters.AddWithValue("@P6", TXTMAIL.Text);
            cm.Parameters.AddWithValue("@P7", CBIL.Text);
            cm.Parameters.AddWithValue("@P8", CBILCE.Text);
            cm.Parameters.AddWithValue("@P9", TXTVER.Text);
            cm.Parameters.AddWithValue("@P10", RTXTADRES.Text);
            cm.Parameters.AddWithValue("@P11", TXTFALLIYET.Text);
            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
            {
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                TXTID.Clear();
                TXTAD.Clear();
                TXTYTKL.Clear();
                TXTYAD.Clear();
                MTXTTEL.Clear();
                MTXTTEL2.Clear();
                TXTMAIL.Clear();
                CBIL.SelectedIndex = -1;
                CBILCE.SelectedIndex = -1;
                TXTVER.Clear();
                RTXTADRES.Clear();
                TXTFALLIYET.Clear();

            }
            else
            {
                MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SİRKETLER_Load(object sender, EventArgs e)
        {
            listele();
            ilListesi();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTYTKL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTYAD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MTXTTEL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MTXTTEL2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TXTMAIL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            CBIL.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            CBILCE.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            TXTVER.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            RTXTADRES.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            TXTFALLIYET.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        private void BTNSIL_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTID.Text == string.Empty)
            {
                hata = 1;
            }

            if (hata == 1)
            {
                MessageBox.Show("SİLENECEK ID GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("select * from TBL_SIRKETLER where ID ='" + TXTID.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete from TBL_SIRKETLER where ID ='" + TXTID.Text + "'", bgl.baglanti());
                    int basari = cm.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    if (basari == 1)
                    {
                        MessageBox.Show("KAYIT SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KAYIT SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("BÖYLE BİR MÜŞTERİ BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            TXTID.Clear();
            listele();
            bgl.baglanti().Close();
        
        }
    }
}
