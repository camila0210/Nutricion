namespace Area_Nutricion
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.btnMigrantes = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMigrantes
            // 
            this.btnMigrantes.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrantes.Location = new System.Drawing.Point(44, 59);
            this.btnMigrantes.Name = "btnMigrantes";
            this.btnMigrantes.Size = new System.Drawing.Size(97, 35);
            this.btnMigrantes.TabIndex = 0;
            this.btnMigrantes.Text = "Migrantes";
            this.btnMigrantes.UseVisualStyleBackColor = true;
            this.btnMigrantes.Click += new System.EventHandler(this.btnMigrantes_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(156, 59);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(97, 35);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "&Peso";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntres.Location = new System.Drawing.Point(268, 59);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(97, 35);
            this.btntres.TabIndex = 2;
            this.btntres.Text = "&IMC";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.btntres_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(140, 18);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(134, 26);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "RESULTADOS";
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.Location = new System.Drawing.Point(138, 114);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(131, 35);
            this.btnNuevoRegistro.TabIndex = 5;
            this.btnNuevoRegistro.Text = "Nuevo registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(433, 207);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnMigrantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMigrantes;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnNuevoRegistro;
    }
}