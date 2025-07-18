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
    public partial class GİDERLER : Form
    {
        public GİDERLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void GİDERLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTELEKTIRIK.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTSU.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTDOGALGAZ.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTİNTERNET.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTKİRA.Text == string.Empty)
            {
                hata = 1;
            }

            if (TXTMAASLAR.Text == string.Empty)
            {
                hata = 1;
            }

            if (CBAY.Text == string.Empty)
            {
                hata = 1;
            }

            if (CBYIL.Text == string.Empty)
            {
                hata = 1;
            }

            if (hata == 1)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu = "insert into TBL_GIDERLER (ELEKTIRIK,SU,DOGALGAZ,INTERNET,KIRA,MAASLAR,AY,YIL) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)";
            SqlCommand cm = new SqlCommand(sorgu, bgl.baglanti());
            cm.Parameters.AddWithValue("@P1", TXTELEKTIRIK.Text);
            cm.Parameters.AddWithValue("@P2", TXTSU.Text);
            cm.Parameters.AddWithValue("@P4", TXTDOGALGAZ.Text);
            cm.Parameters.AddWithValue("@P3", TXTİNTERNET.Text);
            cm.Parameters.AddWithValue("@P5", TXTKİRA.Text);
            cm.Parameters.AddWithValue("@P6", TXTMAASLAR.Text);
            cm.Parameters.AddWithValue("@P7", CBAY.Text);
            cm.Parameters.AddWithValue("@P8", CBYIL.Text);
            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
            {
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                TXTID.Clear();
                TXTELEKTIRIK.Clear();
                TXTSU.Clear();
                TXTDOGALGAZ.Clear();
                TXTİNTERNET.Clear();
                TXTKİRA.Clear();
                TXTMAASLAR.Clear();
                CBAY.SelectedIndex = -1;
                CBYIL.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                SqlCommand komut = new SqlCommand("select * from TBL_GIDERLER where ID ='" + TXTID.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete from TBL_GIDERLER where ID ='" + TXTID.Text + "'", bgl.baglanti());
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
                    MessageBox.Show("BÖYLE BİR KAYIT BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            TXTID.Clear();
            listele();
            bgl.baglanti().Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTELEKTIRIK.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTSU.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTDOGALGAZ.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TXTİNTERNET.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TXTKİRA.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TXTMAASLAR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            CBAY.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            CBYIL.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }
    }
}
