namespace prySp2LobatoCeleste
{
    partial class frmReserva
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
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.gboxTitular = new System.Windows.Forms.GroupBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gboxFormasPago = new System.Windows.Forms.GroupBox();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.gboxAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.gboxTipos = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.gboxTitular.SuspendLayout();
            this.gboxFormasPago.SuspendLayout();
            this.gboxAdicionales.SuspendLayout();
            this.gboxTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(544, 405);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(85, 28);
            this.cmdAceptar.TabIndex = 10;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // gboxTitular
            // 
            this.gboxTitular.Controls.Add(this.lblTelefonos);
            this.gboxTitular.Controls.Add(this.txtTelefonos);
            this.gboxTitular.Controls.Add(this.txtNombre);
            this.gboxTitular.Controls.Add(this.lblNombre);
            this.gboxTitular.Location = new System.Drawing.Point(79, 273);
            this.gboxTitular.Name = "gboxTitular";
            this.gboxTitular.Size = new System.Drawing.Size(643, 100);
            this.gboxTitular.TabIndex = 14;
            this.gboxTitular.TabStop = false;
            this.gboxTitular.Text = "Titular de la reserva";
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(106, 67);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 3;
            this.lblTelefonos.Text = "Teléfonos";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(203, 67);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(320, 20);
            this.txtTelefonos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(203, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(106, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gboxFormasPago
            // 
            this.gboxFormasPago.Controls.Add(this.cmbTarjeta);
            this.gboxFormasPago.Controls.Add(this.lblTarjeta);
            this.gboxFormasPago.Controls.Add(this.optEfectivo);
            this.gboxFormasPago.Controls.Add(this.optTarjeta);
            this.gboxFormasPago.Location = new System.Drawing.Point(283, 136);
            this.gboxFormasPago.Name = "gboxFormasPago";
            this.gboxFormasPago.Size = new System.Drawing.Size(439, 115);
            this.gboxFormasPago.TabIndex = 13;
            this.gboxFormasPago.TabStop = false;
            this.gboxFormasPago.Text = "Formas de pago";
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(215, 75);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(135, 21);
            this.cmbTarjeta.TabIndex = 6;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(212, 56);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lblTarjeta.TabIndex = 5;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(75, 28);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 3;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "&Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(75, 52);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 4;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "&Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // gboxAdicionales
            // 
            this.gboxAdicionales.Controls.Add(this.chkTelevisor);
            this.gboxAdicionales.Controls.Add(this.chkHeladera);
            this.gboxAdicionales.Controls.Add(this.chkCocina);
            this.gboxAdicionales.Location = new System.Drawing.Point(79, 136);
            this.gboxAdicionales.Name = "gboxAdicionales";
            this.gboxAdicionales.Size = new System.Drawing.Size(172, 115);
            this.gboxAdicionales.TabIndex = 12;
            this.gboxAdicionales.TabStop = false;
            this.gboxAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(43, 75);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "&Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(43, 52);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(72, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "&Herladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(43, 29);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "&Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // gboxTipos
            // 
            this.gboxTipos.Controls.Add(this.lblTipo);
            this.gboxTipos.Controls.Add(this.txtDias);
            this.gboxTipos.Controls.Add(this.lblDias);
            this.gboxTipos.Controls.Add(this.cmbTipo);
            this.gboxTipos.Controls.Add(this.lblPersonas);
            this.gboxTipos.Controls.Add(this.cmbPersonas);
            this.gboxTipos.Location = new System.Drawing.Point(79, 18);
            this.gboxTipos.Name = "gboxTipos";
            this.gboxTipos.Size = new System.Drawing.Size(643, 112);
            this.gboxTipos.TabIndex = 11;
            this.gboxTipos.TabStop = false;
            this.gboxTipos.Text = "Tipos de cabaña";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(64, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(556, 48);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(54, 20);
            this.txtDias.TabIndex = 4;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(520, 51);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(30, 13);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Días";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(107, 48);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(106, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(261, 51);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "Personas";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(318, 48);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(112, 21);
            this.cmbPersonas.TabIndex = 1;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.gboxTitular);
            this.Controls.Add(this.gboxFormasPago);
            this.Controls.Add(this.gboxAdicionales);
            this.Controls.Add(this.gboxTipos);
            this.Name = "frmReserva";
            this.Text = "Reserva de cabañas";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.gboxTitular.ResumeLayout(false);
            this.gboxTitular.PerformLayout();
            this.gboxFormasPago.ResumeLayout(false);
            this.gboxFormasPago.PerformLayout();
            this.gboxAdicionales.ResumeLayout(false);
            this.gboxAdicionales.PerformLayout();
            this.gboxTipos.ResumeLayout(false);
            this.gboxTipos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.GroupBox gboxTitular;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gboxFormasPago;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox gboxAdicionales;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox gboxTipos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox cmbPersonas;
    }
}

