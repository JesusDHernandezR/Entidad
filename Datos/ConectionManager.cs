using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class ConectionManager
    {
        public SqlConnection Connection;
        public ConectionManager(string connection)
        {
            Connection = new SqlConnection(connection);
        }
        public void Abrir()
        {
            Connection.Open();
        }
        public void Cerrar()
        {
            Connection.Close();
        }
    }
}
