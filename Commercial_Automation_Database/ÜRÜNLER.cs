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
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER",bgl.baglanti());
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
    }
}
