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
            SqlCommand cm = new SqlCommand("select ilceadi from ilceler where sehirid=@p1",bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", CBIL.SelectedIndex + 1);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CBILCE.Items.Add(dr[0]); 
            }
            bgl.baglanti().Close();
        }
    }
}
