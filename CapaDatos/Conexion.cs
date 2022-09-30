using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static string CN = "Data Source=seminariodatabase.database.windows.net;" +
            "Initial Catalog=RetailBD;" +
            "User ID={usuarioBD};" +
            "Password={contraseñaBD};" +
            "Connect Timeout=30;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";
    }
}
