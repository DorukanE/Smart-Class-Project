using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazilimSinama
{
    class Database
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=AkilliSinif;Integrated Security=True");
    }
}
