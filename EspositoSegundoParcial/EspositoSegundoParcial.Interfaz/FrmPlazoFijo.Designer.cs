
namespace EspositoSegundoParcial.Interfaz
{
    partial class FrmPlazoFijo
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
            this.gbxSimlador = new System.Windows.Forms.GroupBox();
            this.gbxExistentes = new System.Windows.Forms.GroupBox();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.lblPlazosFijosAlta = new System.Windows.Forms.Label();
            this.lblTipoPF = new System.Windows.Forms.Label();
            this.lblMontoF = new System.Windows.Forms.Label();
            this.lblInteresARecibir = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblKAInvertir = new System.Windows.Forms.Label();
            this.lblTasaI = new System.Windows.Forms.Label();
            this.cbxTipoPF = new System.Windows.Forms.ComboBox();
            this.txtTasaI = new System.Windows.Forms.TextBox();
            this.txtInteresARecibir = new System.Windows.Forms.TextBox();
            this.txtMontoF = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtKAinvertir = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstPlazoFIjo = new System.Windows.Forms.ListBox();
            this.lblMontoT = new System.Windows.Forms.Label();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblComisionT = new System.Windows.Forms.Label();
            this.gbxSimlador.SuspendLayout();
            this.gbxExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSimlador
            // 
            this.gbxSimlador.Controls.Add(this.btnLimpiar);
            this.gbxSimlador.Controls.Add(this.btnAlta);
            this.gbxSimlador.Controls.Add(this.btnSimular);
            this.gbxSimlador.Controls.Add(this.txtKAinvertir);
            this.gbxSimlador.Controls.Add(this.txtDias);
            this.gbxSimlador.Controls.Add(this.txtMontoF);
            this.gbxSimlador.Controls.Add(this.txtInteresARecibir);
            this.gbxSimlador.Controls.Add(this.txtTasaI);
            this.gbxSimlador.Controls.Add(this.cbxTipoPF);
            this.gbxSimlador.Controls.Add(this.lblTasaI);
            this.gbxSimlador.Controls.Add(this.lblKAInvertir);
            this.gbxSimlador.Controls.Add(this.lblDias);
            this.gbxSimlador.Controls.Add(this.lblInteresARecibir);
            this.gbxSimlador.Controls.Add(this.lblMontoF);
            this.gbxSimlador.Controls.Add(this.lblTipoPF);
            this.gbxSimlador.Controls.Add(this.lblSimulador);
            this.gbxSimlador.Location = new System.Drawing.Point(22, 12);
            this.gbxSimlador.Name = "gbxSimlador";
            this.gbxSimlador.Size = new System.Drawing.Size(453, 496);
            this.gbxSimlador.TabIndex = 0;
            this.gbxSimlador.TabStop = false;
            // 
            // gbxExistentes
            // 
            this.gbxExistentes.Controls.Add(this.textBox2);
            this.gbxExistentes.Controls.Add(this.lblComisionT);
            this.gbxExistentes.Controls.Add(this.txtMontoT);
            this.gbxExistentes.Controls.Add(this.lblMontoT);
            this.gbxExistentes.Controls.Add(this.lstPlazoFIjo);
            this.gbxExistentes.Controls.Add(this.lblPlazosFijosAlta);
            this.gbxExistentes.Location = new System.Drawing.Point(494, 12);
            this.gbxExistentes.Name = "gbxExistentes";
            this.gbxExistentes.Size = new System.Drawing.Size(534, 496);
            this.gbxExistentes.TabIndex = 1;
            this.gbxExistentes.TabStop = false;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.Location = new System.Drawing.Point(32, 19);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(104, 24);
            this.lblSimulador.TabIndex = 0;
            this.lblSimulador.Text = "Simulador";
            // 
            // lblPlazosFijosAlta
            // 
            this.lblPlazosFijosAlta.AutoSize = true;
            this.lblPlazosFijosAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazosFijosAlta.Location = new System.Drawing.Point(42, 19);
            this.lblPlazosFijosAlta.Name = "lblPlazosFijosAlta";
            this.lblPlazosFijosAlta.Size = new System.Drawing.Size(322, 24);
            this.lblPlazosFijosAlta.TabIndex = 1;
            this.lblPlazosFijosAlta.Text = "PLAZOS FIJOS DADOS DE ALTA";
            // 
            // lblTipoPF
            // 
            this.lblTipoPF.AutoSize = true;
            this.lblTipoPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPF.Location = new System.Drawing.Point(10, 75);
            this.lblTipoPF.Name = "lblTipoPF";
            this.lblTipoPF.Size = new System.Drawing.Size(126, 20);
            this.lblTipoPF.TabIndex = 1;
            this.lblTipoPF.Text = "Tipo Plazo Fijo";
            // 
            // lblMontoF
            // 
            this.lblMontoF.AutoSize = true;
            this.lblMontoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoF.Location = new System.Drawing.Point(10, 319);
            this.lblMontoF.Name = "lblMontoF";
            this.lblMontoF.Size = new System.Drawing.Size(103, 20);
            this.lblMontoF.TabIndex = 2;
            this.lblMontoF.Text = "Monto Final";
            // 
            // lblInteresARecibir
            // 
            this.lblInteresARecibir.AutoSize = true;
            this.lblInteresARecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresARecibir.Location = new System.Drawing.Point(10, 280);
            this.lblInteresARecibir.Name = "lblInteresARecibir";
            this.lblInteresARecibir.Size = new System.Drawing.Size(135, 20);
            this.lblInteresARecibir.TabIndex = 3;
            this.lblInteresARecibir.Text = "Interés a recibir";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(10, 230);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(45, 20);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Días";
            // 
            // lblKAInvertir
            // 
            this.lblKAInvertir.AutoSize = true;
            this.lblKAInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKAInvertir.Location = new System.Drawing.Point(10, 182);
            this.lblKAInvertir.Name = "lblKAInvertir";
            this.lblKAInvertir.Size = new System.Drawing.Size(139, 20);
            this.lblKAInvertir.TabIndex = 5;
            this.lblKAInvertir.Text = "Capital a invertir";
            // 
            // lblTasaI
            // 
            this.lblTasaI.AutoSize = true;
            this.lblTasaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaI.Location = new System.Drawing.Point(10, 131);
            this.lblTasaI.Name = "lblTasaI";
            this.lblTasaI.Size = new System.Drawing.Size(110, 20);
            this.lblTasaI.TabIndex = 6;
            this.lblTasaI.Text = "Tasa Interés";
            // 
            // cbxTipoPF
            // 
            this.cbxTipoPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPF.FormattingEnabled = true;
            this.cbxTipoPF.Location = new System.Drawing.Point(234, 73);
            this.cbxTipoPF.Name = "cbxTipoPF";
            this.cbxTipoPF.Size = new System.Drawing.Size(201, 21);
            this.cbxTipoPF.TabIndex = 7;
            this.cbxTipoPF.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPF_SelectedIndexChanged);
            // 
            // txtTasaI
            // 
            this.txtTasaI.Location = new System.Drawing.Point(234, 131);
            this.txtTasaI.Name = "txtTasaI";
            this.txtTasaI.ReadOnly = true;
            this.txtTasaI.Size = new System.Drawing.Size(201, 20);
            this.txtTasaI.TabIndex = 8;
            // 
            // txtInteresARecibir
            // 
            this.txtInteresARecibir.Location = new System.Drawing.Point(234, 282);
            this.txtInteresARecibir.Name = "txtInteresARecibir";
            this.txtInteresARecibir.ReadOnly = true;
            this.txtInteresARecibir.Size = new System.Drawing.Size(201, 20);
            this.txtInteresARecibir.TabIndex = 9;
            // 
            // txtMontoF
            // 
            this.txtMontoF.Location = new System.Drawing.Point(234, 321);
            this.txtMontoF.Name = "txtMontoF";
            this.txtMontoF.ReadOnly = true;
            this.txtMontoF.Size = new System.Drawing.Size(201, 20);
            this.txtMontoF.TabIndex = 10;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(234, 232);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(201, 20);
            this.txtDias.TabIndex = 11;
            // 
            // txtKAinvertir
            // 
            this.txtKAinvertir.Location = new System.Drawing.Point(234, 184);
            this.txtKAinvertir.Name = "txtKAinvertir";
            this.txtKAinvertir.Size = new System.Drawing.Size(201, 20);
            this.txtKAinvertir.TabIndex = 12;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(14, 377);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(243, 35);
            this.btnSimular.TabIndex = 13;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(14, 436);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(421, 35);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(288, 377);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstPlazoFIjo
            // 
            this.lstPlazoFIjo.FormattingEnabled = true;
            this.lstPlazoFIjo.Location = new System.Drawing.Point(32, 73);
            this.lstPlazoFIjo.Name = "lstPlazoFIjo";
            this.lstPlazoFIjo.Size = new System.Drawing.Size(476, 277);
            this.lstPlazoFIjo.TabIndex = 2;
            // 
            // lblMontoT
            // 
            this.lblMontoT.AutoSize = true;
            this.lblMontoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoT.Location = new System.Drawing.Point(42, 392);
            this.lblMontoT.Name = "lblMontoT";
            this.lblMontoT.Size = new System.Drawing.Size(120, 24);
            this.lblMontoT.TabIndex = 3;
            this.lblMontoT.Text = "Monto Total";
            // 
            // txtMontoT
            // 
            this.txtMontoT.Location = new System.Drawing.Point(307, 397);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.ReadOnly = true;
            this.txtMontoT.Size = new System.Drawing.Size(201, 20);
            this.txtMontoT.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lblComisionT
            // 
            this.lblComisionT.AutoSize = true;
            this.lblComisionT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionT.Location = new System.Drawing.Point(42, 447);
            this.lblComisionT.Name = "lblComisionT";
            this.lblComisionT.Size = new System.Drawing.Size(149, 24);
            this.lblComisionT.TabIndex = 12;
            this.lblComisionT.Text = "Comisión Total";
            // 
            // FrmPlazoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 521);
            this.Controls.Add(this.gbxExistentes);
            this.Controls.Add(this.gbxSimlador);
            this.Name = "FrmPlazoFijo";
            this.Text = "Inversión Online SRL";
            this.Load += new System.EventHandler(this.FrmPlazoFijo_Load);
            this.gbxSimlador.ResumeLayout(false);
            this.gbxSimlador.PerformLayout();
            this.gbxExistentes.ResumeLayout(false);
            this.gbxExistentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSimlador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtKAinvertir;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtMontoF;
        private System.Windows.Forms.TextBox txtInteresARecibir;
        private System.Windows.Forms.TextBox txtTasaI;
        private System.Windows.Forms.ComboBox cbxTipoPF;
        private System.Windows.Forms.Label lblTasaI;
        private System.Windows.Forms.Label lblKAInvertir;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblInteresARecibir;
        private System.Windows.Forms.Label lblMontoF;
        private System.Windows.Forms.Label lblTipoPF;
        private System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.GroupBox gbxExistentes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblComisionT;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.Label lblMontoT;
        private System.Windows.Forms.ListBox lstPlazoFIjo;
        private System.Windows.Forms.Label lblPlazosFijosAlta;
    }
}

