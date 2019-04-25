namespace Area_Nutricion
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.cbxActividad = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonoContac = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtTorre = new System.Windows.Forms.TextBox();
            this.txtNumeroApto = new System.Windows.Forms.TextBox();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtPermanencia = new System.Windows.Forms.TextBox();
            this.cbxRegimen = new System.Windows.Forms.ComboBox();
            this.cbxEscolaridad = new System.Windows.Forms.ComboBox();
            this.txtAntecedentes = new System.Windows.Forms.TextBox();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefonoContac = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTorre = new System.Windows.Forms.Label();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.lblNombreEdificio = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblocupacion = new System.Windows.Forms.Label();
            this.lblAntecedentes = new System.Windows.Forms.Label();
            this.lblEnAnos = new System.Windows.Forms.Label();
            this.LblRegistroNuevo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVerRegistros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbInfoGral = new System.Windows.Forms.GroupBox();
            this.gbInfoAdicional = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.gbInfoGral.SuspendLayout();
            this.gbInfoAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // cbxActividad
            // 
            this.cbxActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActividad.FormattingEnabled = true;
            this.cbxActividad.Items.AddRange(new object[] {
            "Sedentario",
            "Actividad ligera",
            "Actividad moderada",
            "Actividad intensa",
            "Actividad muy intensa"});
            this.cbxActividad.Location = new System.Drawing.Point(201, 258);
            this.cbxActividad.Name = "cbxActividad";
            this.cbxActividad.Size = new System.Drawing.Size(188, 27);
            this.cbxActividad.TabIndex = 92;
            this.ttMensaje.SetToolTip(this.cbxActividad, resources.GetString("cbxActividad.ToolTip"));
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 344);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 27);
            this.txtEmail.TabIndex = 67;
            this.ttMensaje.SetToolTip(this.txtEmail, "Ingrese el correo electrónico ");
            // 
            // txtTelefonoContac
            // 
            this.txtTelefonoContac.Location = new System.Drawing.Point(511, 307);
            this.txtTelefonoContac.MaxLength = 11;
            this.txtTelefonoContac.Name = "txtTelefonoContac";
            this.txtTelefonoContac.Size = new System.Drawing.Size(131, 27);
            this.txtTelefonoContac.TabIndex = 66;
            this.ttMensaje.SetToolTip(this.txtTelefonoContac, "Ingrese un número de teléfono en caso de emeregnecia");
            this.txtTelefonoContac.TextChanged += new System.EventHandler(this.txtTelefonoContac_TextChanged);
            this.txtTelefonoContac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoContac_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(174, 304);
            this.txtTelefono.MaxLength = 11;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 27);
            this.txtTelefono.TabIndex = 65;
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese el número de teléfono ");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtTorre
            // 
            this.txtTorre.Location = new System.Drawing.Point(416, 269);
            this.txtTorre.MaxLength = 15;
            this.txtTorre.Name = "txtTorre";
            this.txtTorre.Size = new System.Drawing.Size(52, 27);
            this.txtTorre.TabIndex = 61;
            this.ttMensaje.SetToolTip(this.txtTorre, "Ingreseero número o nombre de la torre");
            // 
            // txtNumeroApto
            // 
            this.txtNumeroApto.Location = new System.Drawing.Point(591, 269);
            this.txtNumeroApto.MaxLength = 5;
            this.txtNumeroApto.Name = "txtNumeroApto";
            this.txtNumeroApto.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroApto.TabIndex = 60;
            this.ttMensaje.SetToolTip(this.txtNumeroApto, "Ingrese el número del apartamento");
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(174, 264);
            this.txtNombreEdificio.MaxLength = 50;
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(151, 27);
            this.txtNombreEdificio.TabIndex = 59;
            this.ttMensaje.SetToolTip(this.txtNombreEdificio, "Ingrese el nombre del edificio");
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(478, 226);
            this.txtBarrio.MaxLength = 30;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(164, 27);
            this.txtBarrio.TabIndex = 55;
            this.ttMensaje.SetToolTip(this.txtBarrio, "Ingrese el nombre del barrio");
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoCompleteCustomSource.AddRange(new string[] {
            "Carrera",
            "Calle",
            "Diagonal",
            "Avenida"});
            this.txtDireccion.Location = new System.Drawing.Point(174, 222);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(151, 27);
            this.txtDireccion.TabIndex = 54;
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la dirección");
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(478, 181);
            this.txtHijos.MaxLength = 2;
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(164, 27);
            this.txtHijos.TabIndex = 52;
            this.ttMensaje.SetToolTip(this.txtHijos, "Ingrese número de hijos");
            this.txtHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHijos_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(478, 94);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(165, 27);
            this.txtNumero.TabIndex = 43;
            this.ttMensaje.SetToolTip(this.txtNumero, "Ingrese el número de documento");
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(478, 54);
            this.txtApellido.MaxLength = 60;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 27);
            this.txtApellido.TabIndex = 39;
            this.ttMensaje.SetToolTip(this.txtApellido, "Ingrese apellido");
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 54);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.Tag = "";
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese nombre");
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)",
            "Unión libre",
            "Divorciado(a)",
            "Viudo(a)"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(174, 179);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(151, 27);
            this.cbxEstadoCivil.TabIndex = 50;
            this.ttMensaje.SetToolTip(this.cbxEstadoCivil, "Seleccione una opción");
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(507, 136);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(135, 27);
            this.dtpFechaNacimiento.TabIndex = 48;
            this.ttMensaje.SetToolTip(this.dtpFechaNacimiento, "Seleccione su fecha de nacimiento");
            // 
            // cbxIdentificacion
            // 
            this.cbxIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdentificacion.FormattingEnabled = true;
            this.cbxIdentificacion.ItemHeight = 19;
            this.cbxIdentificacion.Items.AddRange(new object[] {
            "Cédula de ciudadania",
            "Tarjeta de identidad ",
            "Cédula de extranjería ",
            "Pasaporte",
            "Registro civil",
            "Migrante"});
            this.cbxIdentificacion.Location = new System.Drawing.Point(174, 94);
            this.cbxIdentificacion.Name = "cbxIdentificacion";
            this.cbxIdentificacion.Size = new System.Drawing.Size(151, 27);
            this.cbxIdentificacion.TabIndex = 41;
            this.ttMensaje.SetToolTip(this.cbxIdentificacion, "Seleccione un tipo de documento");
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(201, 327);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(45, 27);
            this.txtPeso.TabIndex = 88;
            this.ttMensaje.SetToolTip(this.txtPeso, "Ingrese el peso el kilogramos");
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(201, 292);
            this.txtEstatura.MaxLength = 3;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(45, 27);
            this.txtEstatura.TabIndex = 87;
            this.ttMensaje.SetToolTip(this.txtEstatura, "Ingrese la estatura en centimetro");
            this.txtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatura_KeyPress);
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(201, 222);
            this.txtEps.MaxLength = 50;
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(188, 27);
            this.txtEps.TabIndex = 83;
            this.ttMensaje.SetToolTip(this.txtEps, "EPS a la que pertenece");
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(201, 48);
            this.txtOcupacion.MaxLength = 50;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(188, 27);
            this.txtOcupacion.TabIndex = 82;
            this.ttMensaje.SetToolTip(this.txtOcupacion, "A qué se dedica?");
            // 
            // txtPermanencia
            // 
            this.txtPermanencia.Location = new System.Drawing.Point(201, 152);
            this.txtPermanencia.MaxLength = 2;
            this.txtPermanencia.Name = "txtPermanencia";
            this.txtPermanencia.Size = new System.Drawing.Size(45, 27);
            this.txtPermanencia.TabIndex = 81;
            this.ttMensaje.SetToolTip(this.txtPermanencia, "¿cuanto tiempo ha vivido en este país?");
            this.txtPermanencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPermanencia_KeyPress);
            // 
            // cbxRegimen
            // 
            this.cbxRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegimen.FormattingEnabled = true;
            this.cbxRegimen.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.cbxRegimen.Location = new System.Drawing.Point(201, 187);
            this.cbxRegimen.Name = "cbxRegimen";
            this.cbxRegimen.Size = new System.Drawing.Size(188, 27);
            this.cbxRegimen.TabIndex = 79;
            this.ttMensaje.SetToolTip(this.cbxRegimen, "Seleecione una de las opciones");
            // 
            // cbxEscolaridad
            // 
            this.cbxEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEscolaridad.FormattingEnabled = true;
            this.cbxEscolaridad.Items.AddRange(new object[] {
            "Ninguno",
            "Primaria",
            "Secundaria",
            "Técnica",
            "Tecnología",
            "Pregrado",
            "Posgrado"});
            this.cbxEscolaridad.Location = new System.Drawing.Point(201, 83);
            this.cbxEscolaridad.Name = "cbxEscolaridad";
            this.cbxEscolaridad.Size = new System.Drawing.Size(188, 27);
            this.cbxEscolaridad.TabIndex = 78;
            this.ttMensaje.SetToolTip(this.cbxEscolaridad, "Selecciones una de las opciones");
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.Location = new System.Drawing.Point(174, 382);
            this.txtAntecedentes.MaxLength = 500;
            this.txtAntecedentes.Multiline = true;
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(278, 80);
            this.txtAntecedentes.TabIndex = 94;
            this.ttMensaje.SetToolTip(this.txtAntecedentes, "Ingrese los antecedentes Médicos");
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Location = new System.Drawing.Point(201, 118);
            this.txtPaisOrigen.MaxLength = 40;
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(188, 27);
            this.txtPaisOrigen.TabIndex = 80;
            this.ttMensaje.SetToolTip(this.txtPaisOrigen, "¿Cual es su país de origen?");
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.ItemHeight = 19;
            this.cbxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbxGenero.Location = new System.Drawing.Point(174, 138);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(151, 27);
            this.cbxGenero.TabIndex = 99;
            this.ttMensaje.SetToolTip(this.cbxGenero, "Seleccione su género");
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 347);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "&E-mail*";
            // 
            // lblTelefonoContac
            // 
            this.lblTelefonoContac.AutoSize = true;
            this.lblTelefonoContac.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoContac.Location = new System.Drawing.Point(356, 311);
            this.lblTelefonoContac.Name = "lblTelefonoContac";
            this.lblTelefonoContac.Size = new System.Drawing.Size(149, 18);
            this.lblTelefonoContac.TabIndex = 64;
            this.lblTelefonoContac.Text = "Tel&éfono de contacto*";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(21, 307);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 18);
            this.lblTelefono.TabIndex = 63;
            this.lblTelefono.Text = "Te&léfono*";
            // 
            // lblTorre
            // 
            this.lblTorre.AutoSize = true;
            this.lblTorre.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorre.Location = new System.Drawing.Point(356, 275);
            this.lblTorre.Name = "lblTorre";
            this.lblTorre.Size = new System.Drawing.Size(43, 18);
            this.lblTorre.TabIndex = 62;
            this.lblTorre.Text = "&Torre";
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartamento.Location = new System.Drawing.Point(475, 275);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(110, 18);
            this.lblApartamento.TabIndex = 58;
            this.lblApartamento.Text = "N&úmero de apto";
            // 
            // lblNombreEdificio
            // 
            this.lblNombreEdificio.AutoSize = true;
            this.lblNombreEdificio.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdificio.Location = new System.Drawing.Point(21, 266);
            this.lblNombreEdificio.Name = "lblNombreEdificio";
            this.lblNombreEdificio.Size = new System.Drawing.Size(134, 18);
            this.lblNombreEdificio.TabIndex = 57;
            this.lblNombreEdificio.Text = "No&mbre del edificio";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(356, 230);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(56, 18);
            this.lblBarrio.TabIndex = 56;
            this.lblBarrio.Text = "&Barrio*";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(21, 225);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 18);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "&Dirección*";
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroH.Location = new System.Drawing.Point(356, 183);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(112, 18);
            this.lblNumeroH.TabIndex = 51;
            this.lblNumeroH.Text = "Núme&ro de hijos";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(21, 182);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(87, 18);
            this.lblEstadoCivil.TabIndex = 49;
            this.lblEstadoCivil.Text = "&Estado civil*";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(356, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(146, 18);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "&Fecha de nacimiento*";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(21, 142);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 18);
            this.lblGenero.TabIndex = 44;
            this.lblGenero.Text = "&Género*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(356, 100);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 18);
            this.lblNumero.TabIndex = 42;
            this.lblNumero.Text = "Nú&mero*";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTid.Location = new System.Drawing.Point(21, 99);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(153, 18);
            this.lblTid.TabIndex = 40;
            this.lblTid.Text = "&Tipo de identificación*";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(356, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 18);
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "&Apellido*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "&Nombre*";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(25, 262);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(111, 18);
            this.lblActividad.TabIndex = 91;
            this.lblActividad.Text = "&Actividad fisica*";
            this.lblActividad.Click += new System.EventHandler(this.lblActividad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "Kilos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 89;
            this.label6.Text = "Centímetros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 86;
            this.label7.Text = "Pe&so*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "&Estatura*";
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEps.Location = new System.Drawing.Point(25, 226);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(40, 18);
            this.lblEps.TabIndex = 77;
            this.lblEps.Text = "&EPS*";
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.Location = new System.Drawing.Point(25, 191);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(73, 18);
            this.lblRegimen.TabIndex = 76;
            this.lblRegimen.Text = "&Régimen*";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(25, 156);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(99, 18);
            this.lblTiempo.TabIndex = 75;
            this.lblTiempo.Text = "&Permanencia*";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(25, 122);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(105, 18);
            this.lblOrigen.TabIndex = 74;
            this.lblOrigen.Text = "Pa&ís de origen*";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(25, 87);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(136, 18);
            this.lblNivel.TabIndex = 73;
            this.lblNivel.Text = "&Nivel de escolaridad";
            // 
            // lblocupacion
            // 
            this.lblocupacion.AutoSize = true;
            this.lblocupacion.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocupacion.Location = new System.Drawing.Point(25, 52);
            this.lblocupacion.Name = "lblocupacion";
            this.lblocupacion.Size = new System.Drawing.Size(83, 18);
            this.lblocupacion.TabIndex = 72;
            this.lblocupacion.Text = "&Ocupación*";
            // 
            // lblAntecedentes
            // 
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntecedentes.Location = new System.Drawing.Point(22, 381);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.Size = new System.Drawing.Size(96, 18);
            this.lblAntecedentes.TabIndex = 93;
            this.lblAntecedentes.Text = "&Antecedentes";
            // 
            // lblEnAnos
            // 
            this.lblEnAnos.AutoSize = true;
            this.lblEnAnos.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnAnos.Location = new System.Drawing.Point(262, 156);
            this.lblEnAnos.Name = "lblEnAnos";
            this.lblEnAnos.Size = new System.Drawing.Size(59, 18);
            this.lblEnAnos.TabIndex = 95;
            this.lblEnAnos.Text = "En años ";
            // 
            // LblRegistroNuevo
            // 
            this.LblRegistroNuevo.AutoSize = true;
            this.LblRegistroNuevo.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroNuevo.Location = new System.Drawing.Point(454, 20);
            this.LblRegistroNuevo.Name = "LblRegistroNuevo";
            this.LblRegistroNuevo.Size = new System.Drawing.Size(257, 45);
            this.LblRegistroNuevo.TabIndex = 96;
            this.LblRegistroNuevo.Text = "Nuevo registro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(825, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 34);
            this.btnGuardar.TabIndex = 97;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVerRegistros
            // 
            this.btnVerRegistros.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRegistros.Location = new System.Drawing.Point(932, 516);
            this.btnVerRegistros.Name = "btnVerRegistros";
            this.btnVerRegistros.Size = new System.Drawing.Size(111, 34);
            this.btnVerRegistros.TabIndex = 98;
            this.btnVerRegistros.Text = "&RESULTADOS ";
            this.btnVerRegistros.UseVisualStyleBackColor = true;
            this.btnVerRegistros.Click += new System.EventHandler(this.btnVerRegistros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1049, 516);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 34);
            this.btnSalir.TabIndex = 100;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbInfoGral
            // 
            this.gbInfoGral.Controls.Add(this.lblNombre);
            this.gbInfoGral.Controls.Add(this.lblApellido);
            this.gbInfoGral.Controls.Add(this.cbxGenero);
            this.gbInfoGral.Controls.Add(this.lblTid);
            this.gbInfoGral.Controls.Add(this.cbxIdentificacion);
            this.gbInfoGral.Controls.Add(this.lblNumero);
            this.gbInfoGral.Controls.Add(this.lblGenero);
            this.gbInfoGral.Controls.Add(this.lblFecha);
            this.gbInfoGral.Controls.Add(this.txtAntecedentes);
            this.gbInfoGral.Controls.Add(this.dtpFechaNacimiento);
            this.gbInfoGral.Controls.Add(this.lblAntecedentes);
            this.gbInfoGral.Controls.Add(this.lblEstadoCivil);
            this.gbInfoGral.Controls.Add(this.cbxEstadoCivil);
            this.gbInfoGral.Controls.Add(this.lblNumeroH);
            this.gbInfoGral.Controls.Add(this.lblDireccion);
            this.gbInfoGral.Controls.Add(this.lblBarrio);
            this.gbInfoGral.Controls.Add(this.lblNombreEdificio);
            this.gbInfoGral.Controls.Add(this.lblApartamento);
            this.gbInfoGral.Controls.Add(this.lblTorre);
            this.gbInfoGral.Controls.Add(this.lblTelefono);
            this.gbInfoGral.Controls.Add(this.lblTelefonoContac);
            this.gbInfoGral.Controls.Add(this.txtNombre);
            this.gbInfoGral.Controls.Add(this.txtApellido);
            this.gbInfoGral.Controls.Add(this.txtNumero);
            this.gbInfoGral.Controls.Add(this.txtHijos);
            this.gbInfoGral.Controls.Add(this.txtDireccion);
            this.gbInfoGral.Controls.Add(this.txtBarrio);
            this.gbInfoGral.Controls.Add(this.txtNombreEdificio);
            this.gbInfoGral.Controls.Add(this.txtNumeroApto);
            this.gbInfoGral.Controls.Add(this.txtTorre);
            this.gbInfoGral.Controls.Add(this.txtTelefono);
            this.gbInfoGral.Controls.Add(this.txtTelefonoContac);
            this.gbInfoGral.Controls.Add(this.txtEmail);
            this.gbInfoGral.Controls.Add(this.lblEmail);
            this.gbInfoGral.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoGral.Location = new System.Drawing.Point(23, 74);
            this.gbInfoGral.Name = "gbInfoGral";
            this.gbInfoGral.Size = new System.Drawing.Size(670, 476);
            this.gbInfoGral.TabIndex = 101;
            this.gbInfoGral.TabStop = false;
            this.gbInfoGral.Text = "Información general";
            // 
            // gbInfoAdicional
            // 
            this.gbInfoAdicional.Controls.Add(this.lblocupacion);
            this.gbInfoAdicional.Controls.Add(this.lblNivel);
            this.gbInfoAdicional.Controls.Add(this.lblOrigen);
            this.gbInfoAdicional.Controls.Add(this.lblTiempo);
            this.gbInfoAdicional.Controls.Add(this.lblRegimen);
            this.gbInfoAdicional.Controls.Add(this.lblEnAnos);
            this.gbInfoAdicional.Controls.Add(this.lblEps);
            this.gbInfoAdicional.Controls.Add(this.cbxActividad);
            this.gbInfoAdicional.Controls.Add(this.cbxEscolaridad);
            this.gbInfoAdicional.Controls.Add(this.lblActividad);
            this.gbInfoAdicional.Controls.Add(this.cbxRegimen);
            this.gbInfoAdicional.Controls.Add(this.label5);
            this.gbInfoAdicional.Controls.Add(this.label8);
            this.gbInfoAdicional.Controls.Add(this.label6);
            this.gbInfoAdicional.Controls.Add(this.label7);
            this.gbInfoAdicional.Controls.Add(this.txtPeso);
            this.gbInfoAdicional.Controls.Add(this.txtPaisOrigen);
            this.gbInfoAdicional.Controls.Add(this.txtEstatura);
            this.gbInfoAdicional.Controls.Add(this.txtPermanencia);
            this.gbInfoAdicional.Controls.Add(this.txtEps);
            this.gbInfoAdicional.Controls.Add(this.txtOcupacion);
            this.gbInfoAdicional.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoAdicional.Location = new System.Drawing.Point(713, 77);
            this.gbInfoAdicional.Name = "gbInfoAdicional";
            this.gbInfoAdicional.Size = new System.Drawing.Size(415, 382);
            this.gbInfoAdicional.TabIndex = 102;
            this.gbInfoAdicional.TabStop = false;
            this.gbInfoAdicional.Text = "Información adicional";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1152, 557);
            this.Controls.Add(this.gbInfoAdicional);
            this.Controls.Add(this.gbInfoGral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerRegistros);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.LblRegistroNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.gbInfoGral.ResumeLayout(false);
            this.gbInfoGral.PerformLayout();
            this.gbInfoAdicional.ResumeLayout(false);
            this.gbInfoAdicional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.ComboBox cbxActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtPermanencia;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxRegimen;
        private System.Windows.Forms.ComboBox cbxEscolaridad;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblocupacion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoContac;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtTorre;
        private System.Windows.Forms.TextBox txtNumeroApto;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoContac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTorre;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.Label lblNombreEdificio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cbxIdentificacion;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEnAnos;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.Label LblRegistroNuevo;
        private System.Windows.Forms.Button btnVerRegistros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbInfoAdicional;
        private System.Windows.Forms.GroupBox gbInfoGral;
    }
}