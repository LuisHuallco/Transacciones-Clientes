using System;
using System.Windows.Forms;
using Transacciones.Controllers;
using Transacciones.Models;

namespace Transacciones.Views
{
    public partial class frm_Clientes : Form
    {
        private int? idSeleccionado = null;

        public frm_Clientes()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: verificar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSaldo.Text))
                {
                    MessageBox.Show("Complete los campos antes de Registrarse.");
                    return;
                }

                string nombre = txtNombre.Text;
                string email = txtEmail.Text;
                decimal saldo = decimal.Parse(txtSaldo.Text);

                var controller = new ClienteController();
                await controller.CrearCliente(nombre, email, saldo);

                MessageBox.Show(" Cliente registrado correctamente.");
                LimpiarCampos();
                dgvClientes.DataSource = controller.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al registrar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var controller = new ClienteController();
            dgvClientes.DataSource = controller.ListarClientes();
        }

        private void btnIrTransacciones_Click(object sender, EventArgs e)
        {
            frm_Transacciones form = new frm_Transacciones();
            form.Show();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtSaldo.Text = fila.Cells["Saldo"].Value.ToString();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona un cliente para editar.");
                return;
            }

            try
            {
                string nuevoNombre = txtNombre.Text;
                string nuevoEmail = txtEmail.Text;

                var controller = new ClienteController();
                await controller.EditarCliente(idSeleccionado.Value, nuevoNombre, nuevoEmail);

                MessageBox.Show(" Cliente Actualizado correctamente.");
                dgvClientes.DataSource = controller.ListarClientes();
                LimpiarCampos();
                idSeleccionado = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al editar: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtSaldo.Clear();
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            var controller = new ClienteController();
            dgvClientes.DataSource = controller.ListarClientes();
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            idSeleccionado = null; 
        }

    }
}
