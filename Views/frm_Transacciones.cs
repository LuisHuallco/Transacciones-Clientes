using System;
using System.Windows.Forms;
using Transacciones.Controllers;

namespace Transacciones.Views
{
    public partial class frm_Transacciones : Form
    {
        public frm_Transacciones()
        {
            InitializeComponent();
        }

        private async void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrigen = int.Parse(txtIdOrigen.Text);
                int idDestino = int.Parse(txtIdDestino.Text);
                decimal monto = decimal.Parse(txtMonto.Text);

                var controller = new ClienteController();
                await controller.TransferirSaldo(idOrigen, idDestino, monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error en la transferencia: " + ex.Message);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(txtEliminar.Text);

                var controller = new ClienteController();
                await controller.EliminarCliente(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al eliminar: " + ex.Message);
            }
        }
    }
}
