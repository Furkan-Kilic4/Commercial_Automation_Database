using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Commercial_Automation_Database
{
    internal class sqlbaglanti
    {
      public SqlConnection baglanti ()
        {
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-QQDK8I3\SQLEXPRESS;Initial Catalog=DBOSİRKETOTOMASYONU;Integrated Security=True;Encrypt=False");
            b.Open();
            return b;

        }
    }
}
