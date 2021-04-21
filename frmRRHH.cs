using Empleados.Clases;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empleados
{    
    public partial class frmRRHH : MaterialForm
    {
        public RRHH recursosHumanos { get; set; } // Variable de la clase RRHH que contiene la informacion para mostrar o guardar de la parte RRHH de la BD

        //public frmPrincipal frmPrincipal;
        
        public frmRRHH(RRHH rHH) // Metodo constructor del form que recibe como parametro una variable de la clase RRHH
        {
            InitializeComponent();
            recursosHumanos = rHH;
            if (recursosHumanos != null)
            {
                llenarTextBoxes();
            }
        }

        private void frmRRHH_Load(object sender, EventArgs e)//Metodo Load que llena los TextBox del formulario si recursos humanos no es NULL 
        {
            if (recursosHumanos != null)
            {
                llenarTextBoxes();
            }
            this.Location = new Point(1230, 150);//Posicion del formulario que nos permite localizar los 2 formularios uno al lado del otro 
           
        }

        public void llenarTextBoxes() //Metodo privado que muestra la informacion de la varibale recursosHumanos en los TextBoxes correspondientes 
        {
            
            txtCP.Text = recursosHumanos.cp;
            txtDireccion.Text = recursosHumanos.direccion;
            txtDNI.Text = recursosHumanos.dni;
            txtEmail.Text = recursosHumanos.email;
            txtEstadoCivil.Text = recursosHumanos.estadoCivil;
            txtFechaAlta.Text = recursosHumanos.fechaAlta;
            txtFechaBaja.Text = recursosHumanos.fechaBaja;
            txtFechaNacimiento.Text = recursosHumanos.fechaNacimiento;
            txtMovil.Text = recursosHumanos.movil;
            txtNombre.Text = recursosHumanos.nombre;
            txtNoVisible.Text = recursosHumanos.noVisible.ToString();
            txtNumSS.Text = recursosHumanos.numSegSocial;
            txtObservaciones.Text = recursosHumanos.observaciones;
            txtPais.Text = recursosHumanos.pais;
            txtPoblacion.Text = recursosHumanos.poblacion;
            txtRiesgosLaborales.Text = recursosHumanos.riesgosLaborales.ToString();
            txtTelefono.Text = recursosHumanos.telefono;
            txtTipoEmpleado.Text = recursosHumanos.tipoEmpleado.ToString();
        }

        private void frmRRHH_FormClosing(object sender, FormClosingEventArgs e)// Metodo Close del formulario que nos permite evitar el cierre completo del form, si no ocultarlo.
        {
            //e.Cancel = true;
            //this.Hide();
        }
        private void frmRRHH_Leave(object sender, EventArgs e)
        {
            //this.Close();
        }
        public List<TextBox> getIntTextBoxex()
        {
            List<TextBox> lista = new List<TextBox>();
            lista.Add(txtNoVisible);
            lista.Add(txtRiesgosLaborales);

            return lista;
        }

        public RRHH getRRHH()//Metodo publico que nos devuelve una variable de la clase RRHH  desde la informacion escrita en los TextBoxes
        {
            recursosHumanos = new RRHH();
            recursosHumanos.cp = txtCP.Text;
            recursosHumanos.direccion = txtDireccion.Text;
            recursosHumanos.dni = txtDNI.Text;
            recursosHumanos.email = txtEmail.Text;
            recursosHumanos.estadoCivil = txtEstadoCivil.Text;
            recursosHumanos.fechaAlta = txtFechaAlta.Text;
            recursosHumanos.fechaBaja = txtFechaBaja.Text;
            recursosHumanos.fechaNacimiento = txtFechaNacimiento.Text;
            recursosHumanos.movil = txtMovil.Text;
            recursosHumanos.nombre = txtNombre.Text;
            recursosHumanos.noVisible = getIntValue(txtNoVisible.Text);
            recursosHumanos.numSegSocial = txtNumSS.Text;
            recursosHumanos.observaciones = txtObservaciones.Text;
            recursosHumanos.pais = txtPais.Text;
            recursosHumanos.poblacion = txtPoblacion.Text;
            recursosHumanos.riesgosLaborales = getIntValue(txtRiesgosLaborales.Text);
            recursosHumanos.telefono = txtTelefono.Text;
            recursosHumanos.tipoEmpleado = txtTipoEmpleado.Text;

            return recursosHumanos;
        }
        private int? getIntValue(string s)// Metodo privado que nos devuelve un int? pasando como parametro un string
        {
            int res;
            bool r = Int32.TryParse(s, out res); // clase bool que nos permite saber si el string parametrizado se puede Parsear a Int, 
            if (r)//si es true, devuelve la variable res, correspondiente al numero parseado
            {
                return res;
            }
            return null;// si no se puede parsear a int, devuelve null
        }

        private void txtNoVisible_Leave(object sender, EventArgs e)// Evento Leave de las TextBox que controla si en algunos de estos controles se ha introducido un valor correcto.
        {
            TextBox tx = (TextBox)sender;//Apunta la variabale TextBox tx al TextBox que realiza el evento(sender)
            int res;
            if (!string.IsNullOrWhiteSpace(tx.Text))//Si la propiedad text del TextBox no es null o formado por espacios en blanco
            {
                bool r = Int32.TryParse(tx.Text, out res); //variable booleana que nos indica si se ha llevado a podido llevar a cabo la conversion en el parametro output
                if (!r)// Si es False , cambiamos la propiedad BackColor del TextBox para indicar que debemos cambiar el valor introducido
                {
                    tx.BackColor = ColorTranslator.FromHtml("#03A9F4");
                    lblOut.Text = String.Format("El campo {0} debe contener un número valido.", tx.Name.Substring(3).ToUpper());//Tambien mostramos un mensaje en el Label de color Rojo indicando este fallo
                    
                }
                else
                {
                    tx.BackColor = Color.White;//Cuando este valor sea correcto volvera al color anterior de la propiedad BackColor y borramos el mensaje.
                    lblOut.Text = "";

                }
            }
            else
            {
                tx.BackColor = Color.White;// Realizamos la misma accion si lo escrito en la TextBox 
                lblOut.Text = "";
            }
        }
    }
}
