using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Empleados.Clases;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Empleados
{
    
    public partial class frmPrincipal : MaterialForm 
    {    
        BackDB backDB = new BackDB();
        DataSet data;
        int loads = 0;
        static bool rhh = false;//Variable bool que determina si ya se inicio la ventana RRHH
        static RRHH recursosHumanos;
        static frmRRHH frmRRHH;
        public frmPrincipal()
        {
            InitializeComponent();
            this.Location = new Point(200, 150);
            ttipNuevo.SetToolTip(btnBlank, "Limpiar");
            ttipRRHH.SetToolTip(btnRRHH, "Recursos Humanos");
            ttipSubir.SetToolTip(btnAceptar, "Subir Cambios");
            ttipConfig.SetToolTip(btnConfiguracion, "Configuracion");
            ttipAnadir.SetToolTip(btnNuevo, "Añadir/Actualizar");
            ttipBuscar.SetToolTip(btnBuscar, "Buscar");
            ttipHelp.SetToolTip(btnHelp, "Ayuda/Manual");
            frmRRHH = new frmRRHH(null);
            frmRRHH.FormClosed += FrmRRHH_FormClosed;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Blue600, Primary.Blue700,
              Primary.Blue800, Accent.LightBlue400,
              TextShade.WHITE
              );
        }

        private void FrmRRHH_FormClosed(object sender, FormClosedEventArgs e)
        {
            rhh = false;
            frmRRHH = new frmRRHH(null);
            frmRRHH.FormClosed += FrmRRHH_FormClosed;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)// Evento click del boton btnConfiguración que abre el formulario de Configuracion
        {
            frmConfiguracion nuevo = new frmConfiguracion();
            nuevo.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)//Evento Load del formulario Principal
        {
            if(!BackDB.existeConfiguracion())//Comprueba si existe una configuracion, de no ser asi, abre un mensaje para que abrira el formulario de configuracion
            {
                string message = "Aceptar para configurar";
                string caption = "No existe Configuracion de Conexion";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    frmConfiguracion nuevo = new frmConfiguracion();
                    nuevo.ShowDialog();
                }
            }
            else// Si ya existe una configuracion
            {
                if (backDB.comprobarConexion())//Comprueba que la conexion se realiza correctamente con esos datos. 
                {
                    if (loads == 0)// Si es la primera vez que se carga
                    {
                        BackDB backDB = new BackDB();//instancia la clase BackDB
                        data = BackDB.getTablasForm();// utiliza el metodo getTablasFOrm paara asignar la informacion al dataSet del formulario
                        DataColumn[] dc = new DataColumn[1];//Creamos un PrimaryKey para poder llevar a cabo busquedas a traves del metodo Find.
                        dc[0] = data.Tables[0].Columns[0];
                        data.Tables[0].PrimaryKey = dc;                        ;
                        cargarListView();//Cargamos la tabla desde el data set 
                        loads++;//Aumentamos el contador del load para que al realizarse el evento Activated no vuelva a realizar lo mismo. 
                        setAutoCompletar();//metodo privado que crea los strings de autocompletar en base a la Tabla.
                        //frmRRHH.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Error de Configuración");//Si la conexion falla, aparecera un mensaje que abrira el formulario de Configuracion
                    frmConfiguracion frmConfiguracion = new frmConfiguracion();
                    frmConfiguracion.ShowDialog();
                }
            }
        }

        private void cargarListView()// Carga el GRID desde la tabla del data set 
        {
            
            foreach(DataRow dr in data.Tables[0].Rows)
            {
                dgvEmpleados.Rows.Add(new object[] { dr[0].ToString(), dr[1], dr[3], dr[2] });
            }
            
        }        

        private void btnBuscar_Click(object sender, EventArgs e) //Metodo para el evento Click del button btnBuscar, busca en la tabla los nombres introducidos en el TextBox Nombre
        {
            if (data != null)//si la dataSet no es null
            {
                var filtro = data.Tables[0].AsEnumerable().Where( x => x.ItemArray[1].ToString().ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                dgvEmpleados.Rows.Clear();//creamos un List con los filtros de busqueda del nombre, limpiamos el grid, y añadimos las filas al grid 
                filtro.ForEach(x => {                                        
                                        dgvEmpleados.Rows.Add(new object[] { x[0].ToString(), x[1], x[3], x[2] });                             
                                          
                                    });
                
                foreach (DataGridViewRow dr in dgvEmpleados.Rows)
                {
                    if (dgvEmpleados.Rows.Count > 0)
                    {
                        int id = Int32.Parse(dr.Cells[0].Value.ToString());                       
                        if (data.Tables[0].Rows.Find(id).RowState == DataRowState.Added)
                        {
                            dr.DefaultCellStyle.ForeColor = Color.White;
                            dr.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        }
                        if (data.Tables[0].Rows.Find(id).RowState == DataRowState.Modified)
                        {
                            dr.DefaultCellStyle.ForeColor = Color.White;
                            dr.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        }
                    }
                }
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)//Evento KeyDown del txtNombre que nos permite llevar a cabo el evento Buscar dandole a la KEY ENTER
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(this, new EventArgs());
            }
        }

        public static List<T> GetControls<T>(Control container) where T : Control //metodo que devuelve una lista de controles (genericos) dentro de un Control determinado (Usando Generics)
        {
            List<T> controls = new List<T>();
            foreach (Control c in container.Controls)
            {
                if (c is T)
                    controls.Add((T)c);
                controls.AddRange(GetControls<T>(c));
            }

            return controls;

        }

        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //Evento Click para las Celdas del Grid la cual 
        {
            int row = e.RowIndex;
            if (row >= 0)//Filtro que nos permite validar la fila seleccionada, por si seleccionamos una fila que no corresponda a la tabla
            {
                if (dgvEmpleados.SelectedCells.Count != 0) // filtro por si no hemos seleccionado ninguna fila
                {

                    int id;
                    Int32.TryParse(dgvEmpleados.Rows[row].Cells[0].Value.ToString(), out id);
                    var empleado = data.Tables[0].Rows.Find(id).ItemArray; // mediante el id que se encuentra en la cell[0] buscamos en la tabla y nos devuelve el DataRow
                    if (empleado != null) // Si es distinto de Null recorre todo el DataRow y rellena los TextBoxes con la infomación de ese Empleado
                    {
                        txtID.Text = "ID: " + empleado[0];
                        txtName.Text = empleado[1].ToString();
                        txtDelegacion.Text = comprobarDelegacion(empleado[2].ToString(),empleado[19].ToString());
                        txtDepartamento.Text = empleado[3].ToString();
                        txtIdioma.Text = empleado[4].ToString();
                        txtEmail.Text = empleado[5].ToString();
                        txtTelefono.Text = empleado[6].ToString();
                        txtMovil.Text = empleado[7].ToString();
                        txtIP.Text = empleado[8].ToString();
                        txtProCR.Text = empleado[9].ToString();
                        txtPswCR.Text = empleado[10].ToString();
                        txtIncidencias.Text = empleado[11].ToString();
                        txtManager.Text = empleado[12].ToString();
                        txtAlta.Text = empleado[13].ToString();
                        txtBaja.Text = empleado[14].ToString();
                        txtModificado.Text = empleado[15].ToString();
                        txtUserAccount.Text = empleado[16].ToString();
                        txtExtension.Text = empleado[17].ToString();
                        txtPerfil.Text = empleado[18].ToString();
                        txtUserRegFact.Text = empleado[20].ToString();
                        txtEmailUserRegFact.Text = empleado[21].ToString();
                        txtIDFact.Text = empleado[22].ToString();
                        txtClavePick.Text = empleado[23].ToString();
                        txtNumeroPick.Text = empleado[24].ToString();
                        txtUserBFirst.Text = empleado[25].ToString();

                        recursosHumanos = new RRHH();
                        recursosHumanos.noVisible = getIntValue(empleado[26].ToString());
                        recursosHumanos.fechaAlta = empleado[27].ToString();
                        recursosHumanos.fechaBaja = empleado[28].ToString();
                        recursosHumanos.nombre = empleado[29].ToString();
                        recursosHumanos.direccion = empleado[30].ToString();
                        recursosHumanos.cp = empleado[31].ToString();
                        recursosHumanos.poblacion = empleado[32].ToString();
                        recursosHumanos.pais = empleado[33].ToString();
                        recursosHumanos.fechaNacimiento = empleado[34].ToString();
                        recursosHumanos.estadoCivil = empleado[35].ToString();
                        recursosHumanos.dni = empleado[36].ToString();
                        recursosHumanos.numSegSocial = empleado[37].ToString();
                        recursosHumanos.riesgosLaborales = getIntValue(empleado[38].ToString());
                        recursosHumanos.telefono = empleado[39].ToString();
                        recursosHumanos.movil = empleado[40].ToString();
                        recursosHumanos.email = empleado[41].ToString();
                        recursosHumanos.observaciones = empleado[42].ToString();
                        recursosHumanos.tipoEmpleado = empleado[43].ToString();

                        frmRRHH.recursosHumanos = recursosHumanos;
                        if (!frmRRHH.IsDisposed)
                        {
                            frmRRHH.llenarTextBoxes();
                        }
                    }
                }
            }
        }
        private string comprobarDelegacion(string del,string codDel)//Metodo que devuelve un String único para la TextBox txtDelegacion en base a 2 parametros que devuelven un string dependiendo de si alguno no es null, y si ambos son null devuelve null
        {
            if(!string.IsNullOrWhiteSpace(del))
            {
                if(string.IsNullOrWhiteSpace(codDel))
                {
                    return del;
                }
                else
                {
                    return del+'-'+codDel;
                }
            }
            else if(!string.IsNullOrWhiteSpace(codDel))
            {
                return codDel;
            }

            return null;
        }

        private void btnRRHH_Click(object sender, EventArgs e) //Cierra y abre el frmRRHH   
        {
            if (!rhh)
            {
                //frmRRHH = new frmRRHH(null);
                frmRRHH.Show();
                rhh = true;
            }
            else
            {
                if (frmRRHH.WindowState == FormWindowState.Normal)
                {
                    frmRRHH.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    frmRRHH.WindowState = FormWindowState.Normal;
                }
            }     



        }

        private void frmPrincipal_Activated(object sender, EventArgs e)//Evento del frmPrincipal que indica cuando esta Activo 
        {
            backDB = new BackDB(); //Reinicializamos la variable backDB que nos permite atualizar la informacion cuando llevamos a cabo la actualizacion de la configuracion
            if(backDB.comprobarConexion()) //Metodo de la clase BackDB que comprueba si la conexion es correcta, 
            {
                if (loads == 0)// si la conexion es correcta y esta es la primera vez que la hacemos, la cual lo sabemos mediante la variable loads
                {
                    //backDB = new BackDB();//Reinicializamos el backDB para que se pueda actualizar la informacion
                    data = BackDB.getTablasForm(); // actualizamos el DataSet por el metodo static de la clase BackDB
                    DataColumn[] dc = new DataColumn[1]; // Creamos un PrimaryKey para el DataTable 2 del dataset, el cual corresponde a la TABLA: Empleados de la BD
                    dc[0] = data.Tables[0].Columns[0];                    
                    data.Tables[0].PrimaryKey = dc;                    
                    cargarListView();// utilizamos el metodo privado para rellenar el GRID 
                    loads++;//aumentamos la variable loads la cual si Activamos mas veces el frmPrincipal, no lleve a cabo ninguna accion
                }
                
            }
            else
            {
                MessageBox.Show("Error de Configuración");
                frmConfiguracion frmConfiguracion = new frmConfiguracion();
                frmConfiguracion.ShowDialog();
            }

            

        }

        private void btnNuevo_Click(object sender, EventArgs e)//Evento Click del control btnNuevo que nos permite vaciar las cajas de Texto tanto del frmPrincipal(this) como del frmRRHH
        {
            GetControls<TextBox>(this).ForEach(p => { p.Text = ""; p.BackColor = Color.White; });
            frmRRHH.recursosHumanos = null;
            txtName.Focus();
            GetControls<TextBox>(frmRRHH).ForEach(p => { p.Text = ""; p.BackColor = Color.White; });
            txtID.Text = "ID: XX";
        }

        private bool checkTextDelegacion()//metodo privado que valida la propiedad Text de txtDelegación y devuelve true or false, y manda un mensaje.
        {
            string text = txtDelegacion.Text;
            if (text.Contains('-'))//Si contiene un guion que separa 2 strings 
            {
                string[] split = text.Split('-');//separamos el string (nom delegacion, cod delegacion)
                if(!split[1].All(char.IsDigit))//si el codigo que hemos escrito esta bien es decir todo son numeros 
                {
                    lblOut.Text = "El texto escrito en Delegación debe tener el formato Ciudad - Código";
                    return false;
                }
                else
                {
                    lblOut.Text = "";
                    return true;
                }
                
            }
            else if(string.IsNullOrWhiteSpace(text))
            {
                lblOut.Text = "";
                return true;
            }
            else
            {
                lblOut.Text = "";
                return true;
            }

            return false;
        }

        private bool comprobarTextBoxes()
        {
            int c = 0;         

            foreach(TextBox tx in intTextBoxes())
            {
                int i;
                if (!string.IsNullOrWhiteSpace(tx.Text))
                {
                    if (!(Int32.TryParse(tx.Text, out i)))
                    {
                        tx.BackColor = ColorTranslator.FromHtml("#03A9F4");
                        c++;
                    }
                }
            }
            foreach (TextBox tx in frmRRHH.getIntTextBoxex())
            {
                int i;
                if (!string.IsNullOrWhiteSpace(tx.Text))
                {
                    if (!(Int32.TryParse(tx.Text, out i)))
                    {
                        tx.BackColor = ColorTranslator.FromHtml("#03A9F4");
                        c++;
                    }
                }
            }
            if (c != 0)
            {
                MessageBox.Show("Los campos Azules deben ser números validos");
                return false;               
            }
            return true;
        }

        private bool blankTextBoxes()
        {
            int c = GetControls<TextBox>(frmRRHH).Where(x => string.IsNullOrWhiteSpace(x.Text) == false).Count();
            c += GetControls<TextBox>(this).Where(x => string.IsNullOrWhiteSpace(x.Text) == false).Count();

            if(c==0)
            {
               MessageBox.Show("No has Introducido ningun Dato");
               return false;
            }
            return true;

        }

        private void setAutoCompletar()
        {
            var delegaciones = data.Tables[0].AsEnumerable().Select(x => x.ItemArray[2].ToString() +'-'+ x.ItemArray[19].ToString()).Distinct().ToList();

            AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();
            foreach(string s  in delegaciones)
            {
                sourceName.Add(s);
            }

            txtDelegacion.AutoCompleteCustomSource = sourceName;
            txtDelegacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDelegacion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var departamentos = data.Tables[0].AsEnumerable().Select(x => x.ItemArray[3].ToString()).Distinct().ToList();

            AutoCompleteStringCollection sourceName2 = new AutoCompleteStringCollection();
            foreach (string s in departamentos)
            {
                sourceName2.Add(s);
            }

            txtDepartamento.AutoCompleteCustomSource = sourceName2;
            txtDepartamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDepartamento.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        private void btnAceptar_Click(object sender, EventArgs e)//Evento Click para el btnAceptar que crea un Empleado Nuevo ,lo añade al DataTable y lo muestra en el GRID o Actualiza un Empleado.
        {
            if (comprobarTextBoxes() && blankTextBoxes() && checkTextDelegacion())
            {
                if (txtID.Text.Contains("XX"))
                {
                    Empleado nuevo = nuevoEmpleado();
                    data.Tables[0].Rows.Add(nuevo.getAsParams());
                    dgvEmpleados.Rows.Clear();

                }
                else
                {
                    string id = txtID.Text.Trim().Substring(3);
                    ActualizarEmpleado(id);
                    dgvEmpleados.Rows.Clear();
                }
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (dr.RowState != DataRowState.Unchanged)
                    {
                        dgvEmpleados.Rows.Add(new object[] { dr[0].ToString(), dr[1], dr[3], dr[2] });
                    }
                }
                foreach (DataGridViewRow dr in dgvEmpleados.Rows)
                {
                    if (dgvEmpleados.Rows.Count > 0)
                    {
                        int id = Int32.Parse(dr.Cells[0].Value.ToString());

                        if (data.Tables[0].Rows.Find(id).RowState == DataRowState.Added)
                        {
                            dr.DefaultCellStyle.ForeColor = Color.White;
                            dr.DefaultCellStyle.BackColor = Color.CornflowerBlue;                          
                        }
                        if (data.Tables[0].Rows.Find(id).RowState == DataRowState.Modified)
                        {
                            dr.DefaultCellStyle.ForeColor = Color.White;
                            dr.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        }
                    }
                }
            }

        }

        private void ActualizarEmpleado(string id)
        {

            DataRow dr = data.Tables[0].Rows.Find(Int32.Parse(id));
            
            dr[1] = getStringValue(txtName.Text);
            dr[2] = delegacionSplit(txtDelegacion.Text)[0];
            dr[3] = getStringValue(txtDepartamento.Text);
            dr[4] = getStringValue(txtIdioma.Text);
            dr[5] = getStringValue(txtEmail.Text);
            dr[6] = getStringValue(txtTelefono.Text);
            dr[7] = getStringValue(txtMovil.Text);
            dr[8] = getStringValue(txtIP.Text);
            dr[9] = getStringValue(txtProCR.Text);
            dr[10] = getStringValue(txtPswCR.Text);
            intDataRow(dr, 11, getIntValue(txtIncidencias.Text));
            intDataRow(dr,12,getIntValue(txtManager.Text));
            intDataRow(dr, 13, getIntValue(txtAlta.Text));
            intDataRow(dr, 14, getIntValue(txtBaja.Text));
            intDataRow(dr, 15, getIntValue(txtModificado.Text));
            dr[16] = getStringValue(txtUserAccount.Text);
            intDataRow(dr, 17, getIntValue(txtExtension.Text));
            dr[18] = getStringValue(txtPerfil.Text);
            dr[19] = delegacionSplit(txtDelegacion.Text)[1];
            dr[20] = getStringValue(txtUserRegFact.Text);
            dr[21] = getStringValue(txtEmailUserRegFact.Text);
            intDataRow(dr, 12, getIntValue(txtIDFact.Text));
            dr[23] = getStringValue(txtClavePick.Text);
            dr[24] = getStringValue(txtNumeroPick.Text);
            dr[25] = getStringValue(txtUserBFirst.Text);
            RRHH nuevo = frmRRHH.getRRHH();

            intDataRow(dr, 38, nuevo.noVisible);
            dr[27] = nuevo.fechaAlta;
            dr[28] = nuevo.fechaBaja;
            dr[29] = nuevo.nombre;
            dr[30] = nuevo.direccion;
            dr[31] = nuevo.cp;
            dr[32] = nuevo.poblacion;
            dr[33] = nuevo.pais;
            dr[34] = nuevo.fechaNacimiento;
            dr[35] = nuevo.estadoCivil;
            dr[36] = nuevo.dni;
            dr[37] = nuevo.numSegSocial;
            intDataRow(dr, 38,nuevo.riesgosLaborales);
            dr[39] = nuevo.telefono;
            dr[40] = nuevo.movil;
            dr[41] = nuevo.email;
            dr[42] = nuevo.observaciones;
            dr[43] = nuevo.tipoEmpleado;            

        }

        private void intDataRow(DataRow dr,int index,int? n) // Metodo privado que recibe como parametros un DataRow, el index de ese dataROw y el un valor int?; por el cual si el valor es null asigna el valor DBNull a ese DataRow[index] del DataTable
        {
            if(n is null)
            {
                dr[index] = DBNull.Value;
            }
            else//Y si no es null asigna el valor int correspondiente
            {
                dr[index] = n;
            }
        }

        private Empleado nuevoEmpleado()//Metodo que devuelve un Empleado a partir de las Cajas de Texto del frmPrincipal, como del frmRRHH
        {            
            Empleado nuevo = new Empleado();
            nuevo.alta = getIntValue(txtAlta.Text);
            nuevo.baja = getIntValue(txtBaja.Text);
            nuevo.clavePick = getStringValue(txtClavePick.Text);
            nuevo.delegacion = delegacionSplit(txtDelegacion.Text)[0];
            nuevo.delegacionAX = delegacionSplit(txtDelegacion.Text)[1];
            nuevo.departamento = getStringValue(txtDepartamento.Text);
            nuevo.email = getStringValue(txtEmail.Text);
            nuevo.emailUsuarioRegistro = getStringValue(txtEmailUserRegFact.Text);
            nuevo.extension = getIntValue(txtExtension.Text);
            nuevo.id = lastID()+1;
            nuevo.idfact = getIntValue(txtIDFact.Text);
            nuevo.idioma = getStringValue(txtIdioma.Text);
            nuevo.incidencias = getIntValue(txtIncidencias.Text);
            nuevo.ip = getStringValue(txtIP.Text);
            nuevo.manager = getIntValue(txtManager.Text);
            nuevo.modificado = getIntValue(txtModificado.Text);
            nuevo.movil = getStringValue(txtMovil.Text);
            nuevo.nombre = getStringValue(txtName.Text);
            nuevo.numeroPick = getStringValue(txtNumeroPick.Text);
            nuevo.perfil = getStringValue(txtPerfil.Text);
            nuevo.progControlRemoto = getStringValue(txtProCR.Text);
            nuevo.pswControlRemoto = getStringValue(txtPswCR.Text);
            nuevo.telefono = getStringValue(txtTelefono.Text);
            nuevo.userAccount = getStringValue(txtUserAccount.Text);
            nuevo.usuarioBFirst = getStringValue(txtUserBFirst.Text);
            nuevo.usuarioRegFacturas = getStringValue(txtUserRegFact.Text);
            nuevo.rrhh = frmRRHH.getRRHH();

            return nuevo;
        }

        private int lastID()
        {
            var res = data.Tables[0].AsEnumerable().Max(x => x.ItemArray[0]).ToString(); //Metodo privado que devuelve valor de ID maximo de la tabla del dataset

            return Int32.Parse(res);
        } 
        

        private int? getIntValue(string s) //metodo privado que devuelve un int? para poder devolver un valor null que coincida con la BD
        {
            int res;
            bool r = Int32.TryParse(s, out res); //variable booleana que nos indica si se ha llevado a podido llevar a cabo la conversion en el parametro output
            if(r)
            {
                return res;
            }
            return null;
        }

        private string getStringValue(string s)// Metodo privado que devuelve un string o null si esta vacio o formado por espacios en blanco
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
            return s;
        }
        
        private string [] delegacionSplit(string s) // Metodo Privado que nos devuelve un string con la delegacion y el codigo para poder llevar a cabo el Alta como la Modificacion
        {
            string[] split = new string[2]; // Instanciamos un array de 2 strings
            if(!string.IsNullOrWhiteSpace(s)) //Validamos el string que pasamos como parámetro 
            {
                if(s.Contains('-'))// si contiene el guion dividimos la palabra , si no devolvemos null
                {
                    split = s.Split('-');                    
                }
                else
                {
                    split[0] = s;
                    split[1] = null;
                }
            }
            else
            {
                split[0] = null;
                split[1] = null;
            }

            return split;
        }

        private void txtAlta_Leave(object sender, EventArgs e)//Evento Leave para un TextBox que lleva a cabo una accion al salir del foco de este TextBox
        {
            TextBox tx = (TextBox)sender;//Apunta la Variable tx al textbox donde se lleva a cabo el evento(sender)
            int res;
            if (!string.IsNullOrWhiteSpace(tx.Text))//Validamos la propiedad text 
            {
                bool r = Int32.TryParse(tx.Text, out res); //variable booleana que nos indica si se ha llevado a podido llevar a cabo la conversion en el parametro output
                if (!r)
                {
                    tx.BackColor = ColorTranslator.FromHtml("#03A9F4");
                    lblOut.Text = String.Format("El campo {0} debe contener un número valido.", tx.Name.Substring(3).ToUpper());                                    
                }
                else
                {
                    tx.BackColor = Color.White;
                    lblOut.Text = "";
                    
                }
            }
            else
            {
                tx.BackColor = Color.White;
                lblOut.Text = "";                
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            foreach(DataRow dr in data.Tables[0].Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                    i++;
            }
            if (i > 0)
            {
                int c = 0;//Variable int que nos sirve para comprobar si se ha llevado a cabo el Update con exito, y nos muestra un mensaje dependiendo del valor de esta.
                try
                {
                    BackDB.UpdateDataSet(data);
                }
                catch
                {
                    c++;
                }
                finally
                {
                    if (c == 0)
                    {
                        MessageBox.Show("Éxito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en Alta/Modificar");
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen Empleados Nuevos o Modificados ");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"O:\ProgramasComunes\UsuariosWeb\Documentos\Empleados(Manual).pdf");
        }

        private List<TextBox> intTextBoxes()
        {
            List<TextBox> lista = new List<TextBox>();
            lista.Add(txtIncidencias);
            lista.Add(txtManager);
            lista.Add(txtModificado);
            lista.Add(txtBaja);
            lista.Add(txtAlta);
            lista.Add(txtIDFact);
            lista.Add(txtExtension);            

            return lista;
        }
       

        //private void groupBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    GroupBox box = sender as GroupBox;
        //    DrawGroupBox(box, e.Graphics, Color.Red, ColorTranslator.FromHtml("#03A9F4"));
        //}
        //private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        //{
        //    if (box != null)
        //    {
        //        Brush textBrush = new SolidBrush(textColor);
        //        Brush borderBrush = new SolidBrush(borderColor);
        //        Pen borderPen = new Pen(borderBrush);
        //        SizeF strSize = g.MeasureString(box.Text, box.Font);
        //        Rectangle rect = new Rectangle(box.ClientRectangle.X,
        //                                       box.ClientRectangle.Y + (int)(strSize.Height / 2),
        //                                       box.ClientRectangle.Width - 1,
        //                                       box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

        //        // Clear text and border
        //        g.Clear(this.BackColor);

        //        // Draw text
        //        g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

        //        // Drawing Border
        //        //Left
        //        g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
        //        //Right
        //        g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
        //        //Bottom
        //        g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
        //        //Top1
        //        g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
        //        //Top2
        //        g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        //    }
        //}
    }
}
