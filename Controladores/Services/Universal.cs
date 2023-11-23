using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.Services
{
    public class Universal
    {
        public static string GetStringConexion()
        {
            return "Data Source=VICTOR\\MSSQLSERVER01;Initial Catalog=SistemaFacturacion;Integrated Security=True;Trust Server Certificate=True;";
        }
    }
}
