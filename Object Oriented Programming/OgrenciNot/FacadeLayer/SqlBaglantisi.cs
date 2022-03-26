using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer
{
    public class SqlBaglantisi
    {
        public static SqlConnection Baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbTestKatman;Integrated Security=True");
    }
}
