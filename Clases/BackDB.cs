using LiteDB;
using MySql.Data.MySqlClient;
using System.Data;


namespace Empleados.Clases
{
    class BackDB
    {
        string strConexion;
        private const string PATH = @"configuraciones.db"; // Direccion de 
        static Configuracion datosConexion; 
        static MySqlConnection mySqlConexion;
        static MySqlDataAdapter dataAdapter;

        public BackDB()
        {
        datosConexion = cargarConfiguracion(); // utilizamos este metodo de la Clase WebUser el cual nos devuelve una Configuracion y la instancia al crear un Web User
        strConexion = datosConexion.stringConexion(); // utiliza el metodo StringConexion(), que nos devuelve un string que utlizamos para la propiedad de la clase MysqlConettion 
            mySqlConexion = new MySqlConnection(strConexion);//Instanciamos esta Clase MySqlConnection.        
        }

        public  bool comprobarConexion()//Metodo que comprueba el estado de la conexion y devuelve true si es correcta
        {
            using(mySqlConexion)
            {
                try
                {
                    mySqlConexion.Open();
                    if (mySqlConexion.State == ConnectionState.Open)
                    {
                        return true;
                    }
                }
                catch
                {

                }
            }

            return false;
        }
        public static Configuracion cargarConfiguracion()// Metodo public static que nos permite crear una coleccion dentro de nuestra Base de Datos local LiteDB 
        {
            using (var db = new LiteDatabase(PATH))
            {
                var configuracion = db.GetCollection<Configuracion>("configuracion"); //variable que representa la coleccion de la clase Configuracion con el nombre "configuracion"

                var results = configuracion.Query().Where(x => x.Id == 1).FirstOrDefault(); // Linq que nos permite buscar una configuracion con el id == 1, 
                if (results == null)// Si no encuentra ninguno(la primera vez que instalamos la aplicacion) creara uno nuevo vacio y lo añadira a la lista 
                {
                    results = new Configuracion { host = "", port = "", stringPwd = "", Id = 1, dataBase = "", usuario = ""};
                    configuracion.Insert(results);
                }

                return results;// devuelve esta Configuracion sea vacia si es la primera vez, o una que ya este configurada cuando actualizamos esta informacion

            }

        }

        public static void guardarConfiguracion(Configuracion configuracion)//Actualiza una configuracion en la DB para los datos y  utiliza como parametro una Configuracion
        {
            using (var db = new LiteDatabase(PATH))
            {
                var config = db.GetCollection<Configuracion>("configuracion");

                config.Update(configuracion); // Utilizamos el metodo Update de la libreria LiteDataBase para actualizar la informacion 
            }
        }

        public static bool existeConfiguracion()//devuelve true si existe alguna configuracion con un usuario real, si encuentra un usuario == null devuelve false ya que no existe config.
        {
            using (var db = new LiteDatabase(PATH))
            {
                var config = db.GetCollection<Configuracion>("configuracion");
                var res = config.Query().Where(x => x.usuario == null).FirstOrDefault();
                if (res == null)
                {
                    return true;
                }
            }
            return false;
        }

        public static DataSet getTablasForm()//Metodo que devuelve un DataSet con la Tablas que utilizamos para el frmPrincipal
        {
            DataSet TablasForm = new DataSet();                       

            MySqlCommand cmdEmpleados = new MySqlCommand();//Command para la sentencia sql que se usa para las tablas
            cmdEmpleados.CommandType = CommandType.Text;
            cmdEmpleados.CommandText = "SELECT * FROM empleados ORDER BY id";
            cmdEmpleados.Connection = mySqlConexion;
            try
            {
                dataAdapter = new MySqlDataAdapter(cmdEmpleados);
                dataAdapter.Fill(TablasForm, "Empleados");
            }
            catch
            {

            }

            return TablasForm;

        }

        public static void UpdateDataSet(DataSet dataSet)//Metodo Statico que Actualiza el DataSet, concretamente la tabla Empleados.
        {
            MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);// CommandBuilder para generar los metodos Insert, Update, Delete del adapter
            try
            {
                dataAdapter.Update(dataSet, "Empleados");
            }
            catch
            {

            }
        }
    }
}
