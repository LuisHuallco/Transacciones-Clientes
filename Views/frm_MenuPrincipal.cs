using System;
using System.Windows.Forms;
using Transacciones.Views;

namespace Transacciones.Views
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm_Clientes clientesForm = new frm_Clientes();
            clientesForm.ShowDialog();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            frm_Transacciones transaccionesForm = new frm_Transacciones();
            transaccionesForm.ShowDialog();
        }
    }
}
