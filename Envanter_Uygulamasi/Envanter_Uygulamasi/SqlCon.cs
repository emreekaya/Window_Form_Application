using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter_Uygulamasi
{
    public static class SqlCon
    {
        public static  SqlConnection baglanti =  new SqlConnection("Data Source=DESKTOP-DIF1517\\SQLEXPRESS01;Initial Catalog=Envanter_Veri_Tabani;Integrated Security=True");
    }
}
