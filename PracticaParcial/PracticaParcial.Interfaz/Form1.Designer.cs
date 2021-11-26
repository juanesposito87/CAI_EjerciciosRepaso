
namespace PracticaParcial.Interfaz
{
    partial class FrmTarjeta
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
            this.gpbAltaTarjeta = new System.Windows.Forms.GroupBox();
            this.lblHeaderTarjeta = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblPeriodoCierre = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLimiteCompra = new System.Windows.Forms.Label();
            this.txtLimiteCompra = new System.Windows.Forms.TextBox();
            this.cbxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxPeriodoCierre = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNumeroPlastico = new System.Windows.Forms.Label();
            this.txtNumPlastico = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gbxReporte = new System.Windows.Forms.GroupBox();
            this.lblReporteTarjetas = new System.Windows.Forms.Label();
            this.lstTarjetas = new System.Windows.Forms.ListBox();
            this.lblCantidadPlasticos = new System.Windows.Forms.Label();
            this.lblLimitePromedio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gpbAltaTarjeta.SuspendLayout();
            this.gbxReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAltaTarjeta
            // 
            this.gpbAltaTarjeta.Controls.Add(this.btnAlta);
            this.gpbAltaTarjeta.Controls.Add(this.txtNumPlastico);
            this.gpbAltaTarjeta.Controls.Add(this.lblNumeroPlastico);
            this.gpbAltaTarjeta.Controls.Add(this.btnCalcular);
            this.gpbAltaTarjeta.Controls.Add(this.cbxPeriodoCierre);
            this.gpbAltaTarjeta.Controls.Add(this.cbxCliente);
            this.gpbAltaTarjeta.Controls.Add(this.cbxTipoTarjeta);
            this.gpbAltaTarjeta.Controls.Add(this.txtLimiteCompra);
            this.gpbAltaTarjeta.Controls.Add(this.lblLimiteCompra);
            this.gpbAltaTarjeta.Controls.Add(this.lblCliente);
            this.gpbAltaTarjeta.Controls.Add(this.lblPeriodoCierre);
            this.gpbAltaTarjeta.Controls.Add(this.lblTipoTarjeta);
            this.gpbAltaTarjeta.Controls.Add(this.lblHeaderTarjeta);
            this.gpbAltaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAltaTarjeta.Location = new System.Drawing.Point(9, 12);
            this.gpbAltaTarjeta.Name = "gpbAltaTarjeta";
            this.gpbAltaTarjeta.Size = new System.Drawing.Size(306, 426);
            this.gpbAltaTarjeta.TabIndex = 0;
            this.gpbAltaTarjeta.TabStop = false;
            // 
            // lblHeaderTarjeta
            // 
            this.lblHeaderTarjeta.AutoSize = true;
            this.lblHeaderTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTarjeta.Location = new System.Drawing.Point(24, 22);
            this.lblHeaderTarjeta.Name = "lblHeaderTarjeta";
            this.lblHeaderTarjeta.Size = new System.Drawing.Size(265, 25);
            this.lblHeaderTarjeta.TabIndex = 1;
            this.lblHeaderTarjeta.Text = "Formulario Tarjeta de Crédito";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(6, 62);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(92, 20);
            this.lblTipoTarjeta.TabIndex = 2;
            this.lblTipoTarjeta.Text = "Tipo Tarjeta";
            // 
            // lblPeriodoCierre
            // 
            this.lblPeriodoCierre.AutoSize = true;
            this.lblPeriodoCierre.Location = new System.Drawing.Point(6, 104);
            this.lblPeriodoCierre.Name = "lblPeriodoCierre";
            this.lblPeriodoCierre.Size = new System.Drawing.Size(126, 20);
            this.lblPeriodoCierre.TabIndex = 3;
            this.lblPeriodoCierre.Text = "Período de Ciere";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 148);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // lblLimiteCompra
            // 
            this.lblLimiteCompra.AutoSize = true;
            this.lblLimiteCompra.Location = new System.Drawing.Point(6, 195);
            this.lblLimiteCompra.Name = "lblLimiteCompra";
            this.lblLimiteCompra.Size = new System.Drawing.Size(130, 20);
            this.lblLimiteCompra.TabIndex = 5;
            this.lblLimiteCompra.Text = "Límite de compra";
            // 
            // txtLimiteCompra
            // 
            this.txtLimiteCompra.Location = new System.Drawing.Point(168, 192);
            this.txtLimiteCompra.Name = "txtLimiteCompra";
            this.txtLimiteCompra.Size = new System.Drawing.Size(121, 26);
            this.txtLimiteCompra.TabIndex = 6;
            // 
            // cbxTipoTarjeta
            // 
            this.cbxTipoTarjeta.FormattingEnabled = true;
            this.cbxTipoTarjeta.Location = new System.Drawing.Point(168, 59);
            this.cbxTipoTarjeta.Name = "cbxTipoTarjeta";
            this.cbxTipoTarjeta.Size = new System.Drawing.Size(121, 28);
            this.cbxTipoTarjeta.TabIndex = 7;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(168, 145);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 28);
            this.cbxCliente.TabIndex = 8;
            // 
            // cbxPeriodoCierre
            // 
            this.cbxPeriodoCierre.FormattingEnabled = true;
            this.cbxPeriodoCierre.Location = new System.Drawing.Point(168, 101);
            this.cbxPeriodoCierre.Name = "cbxPeriodoCierre";
            this.cbxPeriodoCierre.Size = new System.Drawing.Size(121, 28);
            this.cbxPeriodoCierre.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(10, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(279, 38);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblNumeroPlastico
            // 
            this.lblNumeroPlastico.AutoSize = true;
            this.lblNumeroPlastico.Location = new System.Drawing.Point(6, 317);
            this.lblNumeroPlastico.Name = "lblNumeroPlastico";
            this.lblNumeroPlastico.Size = new System.Drawing.Size(146, 20);
            this.lblNumeroPlastico.TabIndex = 11;
            this.lblNumeroPlastico.Text = "Número de Plástico";
            // 
            // txtNumPlastico
            // 
            this.txtNumPlastico.Location = new System.Drawing.Point(168, 314);
            this.txtNumPlastico.Name = "txtNumPlastico";
            this.txtNumPlastico.ReadOnly = true;
            this.txtNumPlastico.Size = new System.Drawing.Size(121, 26);
            this.txtNumPlastico.TabIndex = 12;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(10, 367);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(279, 38);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // gbxReporte
            // 
            this.gbxReporte.Controls.Add(this.textBox2);
            this.gbxReporte.Controls.Add(this.textBox1);
            this.gbxReporte.Controls.Add(this.lblLimitePromedio);
            this.gbxReporte.Controls.Add(this.lblCantidadPlasticos);
            this.gbxReporte.Controls.Add(this.lstTarjetas);
            this.gbxReporte.Controls.Add(this.lblReporteTarjetas);
            this.gbxReporte.Location = new System.Drawing.Point(346, 12);
            this.gbxReporte.Name = "gbxReporte";
            this.gbxReporte.Size = new System.Drawing.Size(442, 426);
            this.gbxReporte.TabIndex = 1;
            this.gbxReporte.TabStop = false;
            // 
            // lblReporteTarjetas
            // 
            this.lblReporteTarjetas.AutoSize = true;
            this.lblReporteTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteTarjetas.Location = new System.Drawing.Point(20, 22);
            this.lblReporteTarjetas.Name = "lblReporteTarjetas";
            this.lblReporteTarjetas.Size = new System.Drawing.Size(156, 25);
            this.lblReporteTarjetas.TabIndex = 14;
            this.lblReporteTarjetas.Text = "Reporte Tarjetas";
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Location = new System.Drawing.Point(25, 62);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(396, 238);
            this.lstTarjetas.TabIndex = 15;
            // 
            // lblCantidadPlasticos
            // 
            this.lblCantidadPlasticos.AutoSize = true;
            this.lblCantidadPlasticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPlasticos.Location = new System.Drawing.Point(21, 317);
            this.lblCantidadPlasticos.Name = "lblCantidadPlasticos";
            this.lblCantidadPlasticos.Size = new System.Drawing.Size(202, 20);
            this.lblCantidadPlasticos.TabIndex = 16;
            this.lblCantidadPlasticos.Text = "Cantidad plásticos emitidos";
            // 
            // lblLimitePromedio
            // 
            this.lblLimitePromedio.AutoSize = true;
            this.lblLimitePromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitePromedio.Location = new System.Drawing.Point(21, 367);
            this.lblLimitePromedio.Name = "lblLimitePromedio";
            this.lblLimitePromedio.Size = new System.Drawing.Size(121, 20);
            this.lblLimitePromedio.TabIndex = 17;
            this.lblLimitePromedio.Text = "Límite promedio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 19;
            // 
            // FrmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxReporte);
            this.Controls.Add(this.gpbAltaTarjeta);
            this.Name = "FrmTarjeta";
            this.Text = "Decaedro SRL";
            this.Load += new System.EventHandler(this.FrmTarjeta_Load);
            this.gpbAltaTarjeta.ResumeLayout(false);
            this.gpbAltaTarjeta.PerformLayout();
            this.gbxReporte.ResumeLayout(false);
            this.gbxReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAltaTarjeta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtNumPlastico;
        private System.Windows.Forms.Label lblNumeroPlastico;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxPeriodoCierre;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxTipoTarjeta;
        private System.Windows.Forms.TextBox txtLimiteCompra;
        private System.Windows.Forms.Label lblLimiteCompra;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPeriodoCierre;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblHeaderTarjeta;
        private System.Windows.Forms.GroupBox gbxReporte;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLimitePromedio;
        private System.Windows.Forms.Label lblCantidadPlasticos;
        private System.Windows.Forms.ListBox lstTarjetas;
        private System.Windows.Forms.Label lblReporteTarjetas;
    }
}

