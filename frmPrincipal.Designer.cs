
namespace Empleados
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.GroupBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIncidencias = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPswCR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProCR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelegacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserBFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPick = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClavePick = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDFact = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmailUserRegFact = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUserRegFact = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtUserAccount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.ttipNuevo = new System.Windows.Forms.ToolTip(this.components);
            this.ttipAnadir = new System.Windows.Forms.ToolTip(this.components);
            this.ttipRRHH = new System.Windows.Forms.ToolTip(this.components);
            this.ttipConfig = new System.Windows.Forms.ToolTip(this.components);
            this.ttipSubir = new System.Windows.Forms.ToolTip(this.components);
            this.ttipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.ttipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.lbl25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.txtID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeight = 30;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(17, 124);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEmpleados.RowHeadersWidth = 4;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(341, 409);
            this.dgvEmpleados.TabIndex = 4;
            this.dgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleados_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Depart";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deleg";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Controls.Add(this.txtManager);
            this.txtID.Controls.Add(this.label13);
            this.txtID.Controls.Add(this.txtIncidencias);
            this.txtID.Controls.Add(this.label14);
            this.txtID.Controls.Add(this.txtPswCR);
            this.txtID.Controls.Add(this.label11);
            this.txtID.Controls.Add(this.txtProCR);
            this.txtID.Controls.Add(this.label12);
            this.txtID.Controls.Add(this.txtIP);
            this.txtID.Controls.Add(this.label9);
            this.txtID.Controls.Add(this.txtMovil);
            this.txtID.Controls.Add(this.label10);
            this.txtID.Controls.Add(this.txtTelefono);
            this.txtID.Controls.Add(this.label7);
            this.txtID.Controls.Add(this.txtEmail);
            this.txtID.Controls.Add(this.label8);
            this.txtID.Controls.Add(this.txtIdioma);
            this.txtID.Controls.Add(this.label5);
            this.txtID.Controls.Add(this.txtDepartamento);
            this.txtID.Controls.Add(this.label6);
            this.txtID.Controls.Add(this.txtDelegacion);
            this.txtID.Controls.Add(this.label4);
            this.txtID.Controls.Add(this.txtName);
            this.txtID.Controls.Add(this.label2);
            this.txtID.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(382, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 457);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            this.txtID.Text = "ID: XX";
            // 
            // txtManager
            // 
            this.txtManager.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManager.Location = new System.Drawing.Point(122, 409);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(136, 21);
            this.txtManager.TabIndex = 11;
            this.txtManager.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label13.Location = new System.Drawing.Point(17, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 14);
            this.label13.TabIndex = 22;
            this.label13.Text = "Manager";
            // 
            // txtIncidencias
            // 
            this.txtIncidencias.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidencias.Location = new System.Drawing.Point(122, 375);
            this.txtIncidencias.Name = "txtIncidencias";
            this.txtIncidencias.Size = new System.Drawing.Size(136, 21);
            this.txtIncidencias.TabIndex = 10;
            this.txtIncidencias.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label14.Location = new System.Drawing.Point(17, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 14);
            this.label14.TabIndex = 20;
            this.label14.Text = "Incidencias";
            // 
            // txtPswCR
            // 
            this.txtPswCR.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswCR.Location = new System.Drawing.Point(122, 341);
            this.txtPswCR.Name = "txtPswCR";
            this.txtPswCR.Size = new System.Drawing.Size(136, 21);
            this.txtPswCR.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 18;
            this.label11.Text = "PSW_CR";
            // 
            // txtProCR
            // 
            this.txtProCR.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCR.Location = new System.Drawing.Point(122, 305);
            this.txtProCR.Name = "txtProCR";
            this.txtProCR.Size = new System.Drawing.Size(136, 21);
            this.txtProCR.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(17, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 14);
            this.label12.TabIndex = 16;
            this.label12.Text = "Prog_CR";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(122, 273);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(136, 21);
            this.txtIP.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "IP";
            // 
            // txtMovil
            // 
            this.txtMovil.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.Location = new System.Drawing.Point(122, 238);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(136, 21);
            this.txtMovil.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(17, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Móvil";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(122, 202);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 21);
            this.txtTelefono.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teléfono";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(122, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(17, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(122, 133);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(136, 21);
            this.txtIdioma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Idioma";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(122, 98);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(136, 21);
            this.txtDepartamento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Departamento";
            // 
            // txtDelegacion
            // 
            this.txtDelegacion.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelegacion.Location = new System.Drawing.Point(122, 65);
            this.txtDelegacion.Name = "txtDelegacion";
            this.txtDelegacion.Size = new System.Drawing.Size(136, 21);
            this.txtDelegacion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delegación";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(122, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserBFirst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroPick);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtClavePick);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtIDFact);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtEmailUserRegFact);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtUserRegFact);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPerfil);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtUserAccount);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtModificado);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtBaja);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtAlta);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(664, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 457);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtUserBFirst
            // 
            this.txtUserBFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBFirst.Location = new System.Drawing.Point(185, 409);
            this.txtUserBFirst.Name = "txtUserBFirst";
            this.txtUserBFirst.Size = new System.Drawing.Size(136, 21);
            this.txtUserBFirst.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 46;
            this.label3.Text = "Usuario BFirst";
            // 
            // txtNumeroPick
            // 
            this.txtNumeroPick.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPick.Location = new System.Drawing.Point(185, 375);
            this.txtNumeroPick.Name = "txtNumeroPick";
            this.txtNumeroPick.Size = new System.Drawing.Size(136, 21);
            this.txtNumeroPick.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 14);
            this.label15.TabIndex = 44;
            this.label15.Text = "Número Pick";
            // 
            // txtClavePick
            // 
            this.txtClavePick.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePick.Location = new System.Drawing.Point(185, 341);
            this.txtClavePick.Name = "txtClavePick";
            this.txtClavePick.Size = new System.Drawing.Size(136, 21);
            this.txtClavePick.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 14);
            this.label16.TabIndex = 42;
            this.label16.Text = "Clave Pick";
            // 
            // txtIDFact
            // 
            this.txtIDFact.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFact.Location = new System.Drawing.Point(185, 305);
            this.txtIDFact.Name = "txtIDFact";
            this.txtIDFact.Size = new System.Drawing.Size(136, 21);
            this.txtIDFact.TabIndex = 8;
            this.txtIDFact.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label17.Location = new System.Drawing.Point(26, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 14);
            this.label17.TabIndex = 40;
            this.label17.Text = "Id Fact";
            // 
            // txtEmailUserRegFact
            // 
            this.txtEmailUserRegFact.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUserRegFact.Location = new System.Drawing.Point(185, 273);
            this.txtEmailUserRegFact.Name = "txtEmailUserRegFact";
            this.txtEmailUserRegFact.Size = new System.Drawing.Size(136, 21);
            this.txtEmailUserRegFact.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(26, 276);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 14);
            this.label18.TabIndex = 38;
            this.label18.Text = "Email Usuario Reg Facturas";
            // 
            // txtUserRegFact
            // 
            this.txtUserRegFact.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRegFact.Location = new System.Drawing.Point(185, 238);
            this.txtUserRegFact.Name = "txtUserRegFact";
            this.txtUserRegFact.Size = new System.Drawing.Size(136, 21);
            this.txtUserRegFact.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(26, 241);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 14);
            this.label19.TabIndex = 36;
            this.label19.Text = "Usuario Reg Facturación";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(185, 202);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(136, 21);
            this.txtPerfil.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(26, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 14);
            this.label20.TabIndex = 34;
            this.label20.Text = "Perfil";
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(185, 169);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(136, 21);
            this.txtExtension.TabIndex = 4;
            this.txtExtension.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label21.Location = new System.Drawing.Point(26, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 14);
            this.label21.TabIndex = 32;
            this.label21.Text = "Extensión";
            // 
            // txtUserAccount
            // 
            this.txtUserAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAccount.Location = new System.Drawing.Point(185, 133);
            this.txtUserAccount.Name = "txtUserAccount";
            this.txtUserAccount.Size = new System.Drawing.Size(136, 21);
            this.txtUserAccount.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(26, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 14);
            this.label22.TabIndex = 30;
            this.label22.Text = "User Account";
            // 
            // txtModificado
            // 
            this.txtModificado.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificado.Location = new System.Drawing.Point(185, 98);
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.Size = new System.Drawing.Size(136, 21);
            this.txtModificado.TabIndex = 2;
            this.txtModificado.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label23.Location = new System.Drawing.Point(26, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 14);
            this.label23.TabIndex = 28;
            this.label23.Text = "Modificado";
            // 
            // txtBaja
            // 
            this.txtBaja.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaja.Location = new System.Drawing.Point(185, 65);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(136, 21);
            this.txtBaja.TabIndex = 1;
            this.txtBaja.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label24.Location = new System.Drawing.Point(26, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 14);
            this.label24.TabIndex = 26;
            this.label24.Text = "Baja";
            // 
            // txtAlta
            // 
            this.txtAlta.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlta.Location = new System.Drawing.Point(185, 32);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(136, 21);
            this.txtAlta.TabIndex = 0;
            this.txtAlta.Leave += new System.EventHandler(this.txtAlta_Leave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.label25.Location = new System.Drawing.Point(26, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 14);
            this.label25.TabIndex = 24;
            this.label25.Text = "Alta";
            // 
            // btnRRHH
            // 
            this.btnRRHH.BackColor = System.Drawing.Color.Transparent;
            this.btnRRHH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnRRHH.FlatAppearance.BorderSize = 0;
            this.btnRRHH.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRRHH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRRHH.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRRHH.Location = new System.Drawing.Point(839, 27);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(47, 35);
            this.btnRRHH.TabIndex = 8;
            this.btnRRHH.Text = "RRHH";
            this.btnRRHH.UseVisualStyleBackColor = false;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOut.ForeColor = System.Drawing.Color.Firebrick;
            this.lblOut.Location = new System.Drawing.Point(379, 536);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 14);
            this.lblOut.TabIndex = 12;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::Empleados.Properties.Resources.outline_help_center_white_48dp;
            this.btnHelp.Location = new System.Drawing.Point(768, 26);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(47, 35);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.BackColor = System.Drawing.Color.Transparent;
            this.btnBlank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnBlank.FlatAppearance.BorderSize = 0;
            this.btnBlank.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBlank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBlank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBlank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlank.Image = global::Empleados.Properties.Resources.outline_refresh_white_18dp1;
            this.btnBlank.Location = new System.Drawing.Point(883, 26);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(47, 35);
            this.btnBlank.TabIndex = 5;
            this.btnBlank.UseVisualStyleBackColor = false;
            this.btnBlank.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::Empleados.Properties.Resources.baseline_done_white_36dp1;
            this.btnAceptar.Location = new System.Drawing.Point(979, 26);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(47, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::Empleados.Properties.Resources.baseline_add_white_48dp;
            this.btnNuevo.Location = new System.Drawing.Point(929, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.DrawShadows = true;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = global::Empleados.Properties.Resources.outline_search_white_18dp;
            this.btnBuscar.Location = new System.Drawing.Point(314, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Image = global::Empleados.Properties.Resources.outline_manage_accounts_white_36dp;
            this.btnConfiguracion.Location = new System.Drawing.Point(715, 26);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(47, 35);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // lbl25
            // 
            this.lbl25.AutoSize = true;
            this.lbl25.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl25.Location = new System.Drawing.Point(44, 546);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(42, 14);
            this.lbl25.TabIndex = 2;
            this.lbl25.Text = "Nuevo";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(200, 546);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 14);
            this.label27.TabIndex = 3;
            this.label27.Text = "Actualizado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(174, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(7, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(122, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "EMPLEADOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panel3.Controls.Add(this.label26);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(6, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 35);
            this.panel3.TabIndex = 45;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lbl25);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRRHH);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnConfiguracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Empleados";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.txtID.ResumeLayout(false);
            this.txtID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Windows.Forms.GroupBox txtID;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIncidencias;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPswCR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProCR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelegacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserBFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPick;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClavePick;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIDFact;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmailUserRegFact;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUserRegFact;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUserAccount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.ToolTip ttipNuevo;
        private System.Windows.Forms.ToolTip ttipAnadir;
        private System.Windows.Forms.ToolTip ttipRRHH;
        private System.Windows.Forms.ToolTip ttipConfig;
        private System.Windows.Forms.ToolTip ttipSubir;
        private System.Windows.Forms.ToolTip ttipBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolTip ttipHelp;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel3;
    }
}

