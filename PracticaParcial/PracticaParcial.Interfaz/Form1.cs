using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaParcial.Negocio;
using PracticaParcial.Entidades.Clases;
using PracticaParcial.Entidades.Enum;

namespace PracticaParcial.Interfaz
{
    public partial class FrmTarjeta : Form
    {
        private ClienteNegocio _servicioClientes;
        private TarjetaNegocio _servicioTarjetas;
        private List<TarjetaCredito> _tarjetas;
        public FrmTarjeta()
        {
            _servicioClientes = new ClienteNegocio();
            _servicioTarjetas = new TarjetaNegocio();
            InitializeComponent();
        }

        private void FrmTarjeta_Load(object sender, EventArgs e)
        {
            CargarCombos();
            RecargarLista();
            RecargarCalculos();


        }

        private void LimpiarTodo()
        {

        }

        private void CargarCombos()
        {
            cbxTipoTarjeta.DataSource = null;
            cbxTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
            cbxTipoTarjeta.DisplayMember = "GetType";
            cbxTipoTarjeta.ValueMember = "GetTypeCode";

            cbxPeriodoCierre.DataSource = null;
            cbxPeriodoCierre.DataSource = Enum.GetValues(typeof(PeriodoCierre));
            cbxPeriodoCierre.DisplayMember = "GetType";
            cbxPeriodoCierre.ValueMember = "GetTypeCode";

            cbxCliente.DataSource = null;
            cbxCliente.DataSource = _servicioClientes.TraerClientes();
            cbxPeriodoCierre.DisplayMember = "Display";
            cbxPeriodoCierre.ValueMember = "id";

        }

        private void RecargarLista()
        {
            lstTarjetas.DataSource = null;
            lstTarjetas.DataSource = _servicioTarjetas.TraerTarjetas();
        }

        private void RecargarCalculos()
        {

        }
    }
}
