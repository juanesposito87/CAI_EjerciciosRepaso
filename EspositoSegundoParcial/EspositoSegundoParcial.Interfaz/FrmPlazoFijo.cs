using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EspositoSegundoParcial.Entidades.Dominio;
using EspositoSegundoParcial.Entidades.Utilidades;
using EspositoSegundoParcial.Negocio;
using EspositoSegundoParcial.Entidades.Excepciones;

namespace EspositoSegundoParcial.Interfaz
{
    public partial class FrmPlazoFijo : Form
    {
        private List<TipoPlazoFijo> _tiposPF;
        private List<PlazoFijo> _plazosFijos;
        private NegocioPlazoFijo _negocioPF;

        public FrmPlazoFijo()
        {
            _negocioPF = new NegocioPlazoFijo();
            _tiposPF = new List<TipoPlazoFijo>();
            _plazosFijos = new List<PlazoFijo>();
            InitializeComponent();
        }

        private void FrmPlazoFijo_Load(object sender, EventArgs e)
        {
            ActualizarListas();
            CargarCombos();
        }

        private void ActualizarListas()
        {
            _tiposPF = _negocioPF.TipoPFS();
            _plazosFijos = _negocioPF.TraerPlazoFijoPorUsuario();
        }

        private void CargarCombos()
        {
            cbxTipoPF.DataSource = null;
            cbxTipoPF.DataSource = _tiposPF;
            cbxTipoPF.DisplayMember = "Display";

            lstPlazoFIjo.DataSource = null;
            lstPlazoFIjo.DataSource = _plazosFijos;
        }

        private void cbxTipoPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(((TipoPlazoFijo)cbxTipoPF.SelectedItem).Id == 0))
            {
                txtTasaI.Text = ((TipoPlazoFijo)cbxTipoPF.SelectedItem).Tasa.ToString();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.Validar(cbxTipoPF, lblTipoPF);
                Validaciones.Validar(txtKAinvertir, lblKAInvertir);
                Validaciones.Validar(txtDias, lblDias);
                double k = Validaciones.PasarStringADouble(txtKAinvertir.Text);
                int d = Validaciones.PasarStringAInt(txtDias.Text);
                Simular((TipoPlazoFijo)cbxTipoPF.SelectedItem, k, d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Simular(TipoPlazoFijo tpf, double KInvertir, int Dias)
        {
            try
            {
                PlazoFijo pfijo = _negocioPF.Simular(tpf, KInvertir, Dias);
                txtInteresARecibir.Text = pfijo.Interes.ToString();
                txtMontoF.Text = pfijo.MontoFinal.ToString();
            }
            catch (PlazoMaximoException max)
            {
                MessageBox.Show(max.Message);
            }
            catch (PlazoMinimoException min)
            {
                MessageBox.Show(min.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxTipoPF.SelectedIndex = 1;

        }
    }
}
