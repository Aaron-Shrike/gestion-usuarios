namespace Ventas
{
    partial class frmPersonal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.gbEntidad = new System.Windows.Forms.GroupBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.chkVigente = new System.Windows.Forms.CheckBox();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
      this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
      this.txtCorreo = new System.Windows.Forms.TextBox();
      this.txtCelular = new System.Windows.Forms.TextBox();
      this.lblCorreo = new System.Windows.Forms.Label();
      this.lblFechaNacimiento = new System.Windows.Forms.Label();
      this.lblCelular = new System.Windows.Forms.Label();
      this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
      this.lblApellidos = new System.Windows.Forms.Label();
      this.txtNombres = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDNI = new System.Windows.Forms.TextBox();
      this.lblDNI = new System.Windows.Forms.Label();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnModificar = new System.Windows.Forms.Button();
      this.gbListado = new System.Windows.Forms.GroupBox();
      this.btnListar = new System.Windows.Forms.Button();
      this.dgvListado = new System.Windows.Forms.DataGridView();
      this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.gbEntidad.SuspendLayout();
      this.gbListado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
      this.SuspendLayout();
      // 
      // gbEntidad
      // 
      this.gbEntidad.Controls.Add(this.btnCancelar);
      this.gbEntidad.Controls.Add(this.chkVigente);
      this.gbEntidad.Controls.Add(this.btnAceptar);
      this.gbEntidad.Controls.Add(this.dtpFechaNacimiento);
      this.gbEntidad.Controls.Add(this.txtApellidoMaterno);
      this.gbEntidad.Controls.Add(this.txtCorreo);
      this.gbEntidad.Controls.Add(this.txtCelular);
      this.gbEntidad.Controls.Add(this.lblCorreo);
      this.gbEntidad.Controls.Add(this.lblFechaNacimiento);
      this.gbEntidad.Controls.Add(this.lblCelular);
      this.gbEntidad.Controls.Add(this.txtApellidoPaterno);
      this.gbEntidad.Controls.Add(this.lblApellidos);
      this.gbEntidad.Controls.Add(this.txtNombres);
      this.gbEntidad.Controls.Add(this.label2);
      this.gbEntidad.Controls.Add(this.txtDNI);
      this.gbEntidad.Controls.Add(this.lblDNI);
      this.gbEntidad.Enabled = false;
      this.gbEntidad.Location = new System.Drawing.Point(12, 12);
      this.gbEntidad.Name = "gbEntidad";
      this.gbEntidad.Size = new System.Drawing.Size(403, 269);
      this.gbEntidad.TabIndex = 0;
      this.gbEntidad.TabStop = false;
      this.gbEntidad.Text = "Entidad";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(306, 230);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 15;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // chkVigente
      // 
      this.chkVigente.AutoSize = true;
      this.chkVigente.Location = new System.Drawing.Point(73, 197);
      this.chkVigente.Name = "chkVigente";
      this.chkVigente.Size = new System.Drawing.Size(62, 17);
      this.chkVigente.TabIndex = 13;
      this.chkVigente.Text = "&Vigente";
      this.chkVigente.UseVisualStyleBackColor = true;
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(225, 230);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 14;
      this.btnAceptar.Text = "&Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // dtpFechaNacimiento
      // 
      this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaNacimiento.Location = new System.Drawing.Point(73, 139);
      this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
      this.dtpFechaNacimiento.Size = new System.Drawing.Size(137, 20);
      this.dtpFechaNacimiento.TabIndex = 10;
      // 
      // txtApellidoMaterno
      // 
      this.txtApellidoMaterno.Location = new System.Drawing.Point(244, 84);
      this.txtApellidoMaterno.Name = "txtApellidoMaterno";
      this.txtApellidoMaterno.Size = new System.Drawing.Size(137, 20);
      this.txtApellidoMaterno.TabIndex = 6;
      // 
      // txtCorreo
      // 
      this.txtCorreo.Location = new System.Drawing.Point(73, 165);
      this.txtCorreo.Name = "txtCorreo";
      this.txtCorreo.Size = new System.Drawing.Size(308, 20);
      this.txtCorreo.TabIndex = 12;
      // 
      // txtCelular
      // 
      this.txtCelular.Location = new System.Drawing.Point(73, 110);
      this.txtCelular.Name = "txtCelular";
      this.txtCelular.Size = new System.Drawing.Size(137, 20);
      this.txtCelular.TabIndex = 8;
      // 
      // lblCorreo
      // 
      this.lblCorreo.AutoSize = true;
      this.lblCorreo.Location = new System.Drawing.Point(12, 172);
      this.lblCorreo.Name = "lblCorreo";
      this.lblCorreo.Size = new System.Drawing.Size(38, 13);
      this.lblCorreo.TabIndex = 11;
      this.lblCorreo.Text = "C&orreo";
      // 
      // lblFechaNacimiento
      // 
      this.lblFechaNacimiento.AutoSize = true;
      this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 145);
      this.lblFechaNacimiento.Name = "lblFechaNacimiento";
      this.lblFechaNacimiento.Size = new System.Drawing.Size(63, 13);
      this.lblFechaNacimiento.TabIndex = 9;
      this.lblFechaNacimiento.Text = "&Fecha Nac.";
      // 
      // lblCelular
      // 
      this.lblCelular.AutoSize = true;
      this.lblCelular.Location = new System.Drawing.Point(12, 117);
      this.lblCelular.Name = "lblCelular";
      this.lblCelular.Size = new System.Drawing.Size(39, 13);
      this.lblCelular.TabIndex = 7;
      this.lblCelular.Text = "Ce&lular";
      // 
      // txtApellidoPaterno
      // 
      this.txtApellidoPaterno.Location = new System.Drawing.Point(73, 84);
      this.txtApellidoPaterno.Name = "txtApellidoPaterno";
      this.txtApellidoPaterno.Size = new System.Drawing.Size(164, 20);
      this.txtApellidoPaterno.TabIndex = 5;
      // 
      // lblApellidos
      // 
      this.lblApellidos.AutoSize = true;
      this.lblApellidos.Location = new System.Drawing.Point(12, 91);
      this.lblApellidos.Name = "lblApellidos";
      this.lblApellidos.Size = new System.Drawing.Size(49, 13);
      this.lblApellidos.TabIndex = 4;
      this.lblApellidos.Text = "A&pellidos";
      // 
      // txtNombres
      // 
      this.txtNombres.Location = new System.Drawing.Point(73, 58);
      this.txtNombres.Name = "txtNombres";
      this.txtNombres.Size = new System.Drawing.Size(137, 20);
      this.txtNombres.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "&Nombres";
      // 
      // txtDNI
      // 
      this.txtDNI.Location = new System.Drawing.Point(73, 32);
      this.txtDNI.Name = "txtDNI";
      this.txtDNI.Size = new System.Drawing.Size(137, 20);
      this.txtDNI.TabIndex = 1;
      // 
      // lblDNI
      // 
      this.lblDNI.AutoSize = true;
      this.lblDNI.Location = new System.Drawing.Point(12, 39);
      this.lblDNI.Name = "lblDNI";
      this.lblDNI.Size = new System.Drawing.Size(26, 13);
      this.lblDNI.TabIndex = 0;
      this.lblDNI.Text = "&DNI";
      // 
      // btnNuevo
      // 
      this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNuevo.Location = new System.Drawing.Point(11, 337);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(75, 23);
      this.btnNuevo.TabIndex = 2;
      this.btnNuevo.Text = "&Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // btnModificar
      // 
      this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnModificar.Location = new System.Drawing.Point(92, 337);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new System.Drawing.Size(75, 23);
      this.btnModificar.TabIndex = 3;
      this.btnModificar.Text = "&Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
      // 
      // gbListado
      // 
      this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbListado.Controls.Add(this.btnListar);
      this.gbListado.Controls.Add(this.btnModificar);
      this.gbListado.Controls.Add(this.btnNuevo);
      this.gbListado.Controls.Add(this.dgvListado);
      this.gbListado.Location = new System.Drawing.Point(421, 12);
      this.gbListado.Name = "gbListado";
      this.gbListado.Size = new System.Drawing.Size(408, 370);
      this.gbListado.TabIndex = 1;
      this.gbListado.TabStop = false;
      this.gbListado.Text = "Listado";
      // 
      // btnListar
      // 
      this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnListar.Location = new System.Drawing.Point(324, 19);
      this.btnListar.Name = "btnListar";
      this.btnListar.Size = new System.Drawing.Size(75, 23);
      this.btnListar.TabIndex = 0;
      this.btnListar.Text = "&Listar";
      this.btnListar.UseVisualStyleBackColor = true;
      this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
      // 
      // dgvListado
      // 
      this.dgvListado.AllowUserToAddRows = false;
      this.dgvListado.AllowUserToDeleteRows = false;
      this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombre,
            this.cdCelular,
            this.cdCorreo});
      this.dgvListado.Location = new System.Drawing.Point(11, 56);
      this.dgvListado.MultiSelect = false;
      this.dgvListado.Name = "dgvListado";
      this.dgvListado.ReadOnly = true;
      this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvListado.Size = new System.Drawing.Size(388, 275);
      this.dgvListado.TabIndex = 1;
      // 
      // cdNombre
      // 
      this.cdNombre.DataPropertyName = "NombreCompleto";
      this.cdNombre.HeaderText = "Personal";
      this.cdNombre.Name = "cdNombre";
      this.cdNombre.ReadOnly = true;
      this.cdNombre.Width = 200;
      // 
      // cdCelular
      // 
      this.cdCelular.DataPropertyName = "Celular";
      this.cdCelular.HeaderText = "Celular";
      this.cdCelular.Name = "cdCelular";
      this.cdCelular.ReadOnly = true;
      // 
      // cdCorreo
      // 
      this.cdCorreo.DataPropertyName = "Correo";
      this.cdCorreo.HeaderText = "Correo";
      this.cdCorreo.Name = "cdCorreo";
      this.cdCorreo.ReadOnly = true;
      this.cdCorreo.Width = 150;
      // 
      // btnCerrar
      // 
      this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCerrar.Location = new System.Drawing.Point(754, 393);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(75, 23);
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.Text = "C&errar";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // frmPersonal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(841, 428);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.gbListado);
      this.Controls.Add(this.gbEntidad);
      this.Name = "frmPersonal";
      this.Text = "Gestión de personal";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonal_FormClosed);
      this.gbEntidad.ResumeLayout(false);
      this.gbEntidad.PerformLayout();
      this.gbListado.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
    }
}

