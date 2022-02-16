using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public static class SqlCon
    {
        public static SqlConnection Connection= new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=HastaneProje;Integrated Security=True");
    }
}