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
using System.Data.Common;
namespace Commercial_Automation_Database
{
    public partial class ÜRÜNLER : Form
    {
        public ÜRÜNLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ÜRÜNLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTMARKA.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTMODEL.Text == string.Empty)
            {
                hata = 1;
            }

            if (MTXTYIL.Text == string.Empty)
            {
                hata = 1;
            }

            if (NUADET.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTALIS.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTSATIS.Text == string.Empty)
            {
                hata = 1;
            }

            if (hata == 1)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sorgu = "insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYATI,SATISFIYATI) values ('"
                + TXTAD.Text + "', '" + TXTMARKA.Text + "', '" + TXTMODEL.Text + "', '" + MTXTYIL.Text + "', "
                + NUADET.Text + ", " + TXTALIS.Text + ", " + TXTSATIS.Text + ")";

            SqlCommand cm = new SqlCommand(sorgu, bgl.baglanti());
            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
            {
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                TXTID.Clear();
                TXTAD.Clear();
                TXTMARKA.Clear();
                TXTMODEL.Clear();
                MTXTYIL.Clear();
                TXTALIS.Clear();
                TXTSATIS.Clear();
            }
            else
            {
                MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTID.Text==string.Empty)
            {
                hata = 1;
            }

            if (hata==1)
            {
                MessageBox.Show("SİLENECEK ID GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("select * from TBL_URUNLER where ID ='"+TXTID.Text+"'",bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete from TBL_URUNLER where ID ='" + TXTID.Text + "'", bgl.baglanti());
                    int basari = cm.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    if (basari == 1)
                    {
                        MessageBox.Show("ÜRÜN SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ÜRÜN SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("BÖYLE BİR ÜRÜN BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            TXTID.Clear();
            listele();
            bgl.baglanti().Close();
        }
    }
}
