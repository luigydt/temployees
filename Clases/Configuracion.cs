using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Clases
{
    public class Configuracion
    {
         public int Id { get; set; } // Utilizamos un Id para que podamos utilizar LiteDB ya que es un requerimiento para poder utilizar algunos metodos de esta Libreria
         public string host { get; set; } // host de la conexion
         public string port { get; set; } // puerto de esta conexion
         public string usuario { get; set; }
         public string dataBase { get; set; } // Base de Datos que se utiliza 
         public string stringPwd { get; set; } // Contraseña para las credenciales de conexion         

        public string stringConexion()// Metodo publico que devuelve el string de conexion utilizada para la propiedad connectionstring de la clase MysqlConnection
        {
            return "Server=" + host + ";Database=" + dataBase + ";port=" + port + ";User Id=" + usuario + ";password=" + stringPwd +";Connection Timeout = 1";
        }
    }
}
