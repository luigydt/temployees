using Empleados.Clases;
using MaterialSkin.Controls;
using System;

namespace Empleados
{
    public partial class frmConfiguracion : MaterialForm
    {
        Configuracion config;
        public frmConfiguracion()
        {
            InitializeComponent();
            config = BackDB.cargarConfiguracion(); // al iniciar el Form utilizamos el metodo static que nos devuelve una configuracion o crea una nueva en caso de no existir ninguna
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)// Evento Click del boton btnConfiguracion que guarda los datos de configuracion en la base de datos local
        {
            config.host = txtHost.Text;
            config.dataBase = txtDataBase.Text;
            config.port = txtPuerto.Text;
            config.stringPwd = txtPassword.Text;
            config.usuario = txtUser.Text;

            BackDB.guardarConfiguracion(config);
            this.Close();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)// Evento load que carga la configuracion guardada y se visualiza en las TextBox correspondientes.
        {
            txtDataBase.Text = config.dataBase;
            txtHost.Text = config.host;
            txtPassword.Text = config.stringPwd;
            txtPuerto.Text = config.port;
            txtUser.Text = config.usuario;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }
    }
}
