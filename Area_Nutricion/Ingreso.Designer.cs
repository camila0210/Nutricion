namespace Area_Nutricion
{
    partial class Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gpbValidacion = new System.Windows.Forms.GroupBox();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbValidacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(58, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "&Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(61, 71);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(88, 19);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "&Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(169, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 27);
            this.txtUsuario.TabIndex = 2;
            this.ttAyuda.SetToolTip(this.txtUsuario, "Por favor ingrese nombre de usuario");
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(169, 71);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(100, 27);
            this.txtContra.TabIndex = 3;
            this.ttAyuda.SetToolTip(this.txtContra, "Por favor ingrese la contraseña");
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(137, 130);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 37);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gpbValidacion
            // 
            this.gpbValidacion.Controls.Add(this.btnIngresar);
            this.gpbValidacion.Controls.Add(this.txtContra);
            this.gpbValidacion.Controls.Add(this.txtUsuario);
            this.gpbValidacion.Controls.Add(this.lblUsuario);
            this.gpbValidacion.Controls.Add(this.lblContra);
            this.gpbValidacion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValidacion.Location = new System.Drawing.Point(43, 29);
            this.gpbValidacion.Name = "gpbValidacion";
            this.gpbValidacion.Size = new System.Drawing.Size(371, 188);
            this.gpbValidacion.TabIndex = 5;
            this.gpbValidacion.TabStop = false;
            this.gpbValidacion.Text = "Validar usuario";
            // 
            // ttAyuda
            // 
            this.ttAyuda.IsBalloon = true;
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(457, 251);
            this.Controls.Add(this.gpbValidacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.gpbValidacion.ResumeLayout(false);
            this.gpbValidacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gpbValidacion;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.ErrorProvider erpMensaje;
    }
}

