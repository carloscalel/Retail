using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        //public static string CN = "Data Source=CALEL-PC;" +
        //    "Initial Catalog=DBPRUEBAS;" +
        //    "Integrated Security=True;" +
        //    "Connect Timeout=30;Encrypt=False;" +
        //    "TrustServerCertificate=False;" +
        //    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public static string CN = "Data Source=seminariodatabase.database.windows.net;" +
            "Initial Catalog=RetailBD;" +
            "User ID=CarlosCalel;" +
            "Password=Fer.1994*;" +
            "Connect Timeout=30;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

    }
}
