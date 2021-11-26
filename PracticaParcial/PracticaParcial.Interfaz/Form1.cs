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
        private List<TipoTarjeta> _tipoTarjeta;
        private List<PeriodoCierre> _periodoCierre;
        public FrmTarjeta()
        {
            InitializeComponent();
            _servicioClientes = new ClienteNegocio();
        }

        private void FrmTarjeta_Load(object sender, EventArgs e)
        {
            cbxTipoTarjeta.DataSource = null;
            cbxTipoTarjeta.DataSource = _tipoTarjeta;
            cbxTipoTarjeta.DisplayMember = "GetType";
            cbxTipoTarjeta.ValueMember = "GetTypeCode";

            cbxPeriodoCierre.DataSource = null;
            cbxPeriodoCierre.DataSource = _periodoCierre;
            cbxPeriodoCierre.DisplayMember = "GetType";
            cbxPeriodoCierre.ValueMember = "GetTypeCode";

            cbxCliente.DataSource = null;
            cbxCliente.DataSource = _servicioClientes.TraerClientes();
        }
    }
}
