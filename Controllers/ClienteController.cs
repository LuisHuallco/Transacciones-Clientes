using Microsoft.EntityFrameworkCore;
using Transacciones.Data;
using Transacciones.Models;
using System.Windows.Forms;

namespace Transacciones.Controllers
{
    public class ClienteController
    {
        public async Task TransferirSaldo(int idOrigen, int idDestino, decimal monto)
        {
            using var context = new AppDbContext();
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var origen = await context.Clientes.FindAsync(idOrigen);
                var destino = await context.Clientes.FindAsync(idDestino);

                if (origen == null || destino == null)
                    throw new Exception("Cliente no encontrado.");

                if (origen.Saldo < monto)
                    throw new Exception("Saldo insuficiente.");

                origen.Saldo -= monto;
                destino.Saldo += monto;

                await context.SaveChangesAsync();
                await transaction.CommitAsync();
                MessageBox.Show(" Transferencia realizada con éxito.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($" Error: {ex.Message}");
            }
        }

        public async Task EliminarCliente(int idCliente)
        {
            using var context = new AppDbContext();
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var cliente = await context.Clientes.FindAsync(idCliente);
                if (cliente == null)
                    throw new Exception("Cliente no encontrado.");

                if (cliente.Saldo != 0)
                    throw new Exception("El saldo debe ser 0 para eliminar al cliente.");

                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();
                await transaction.CommitAsync();
                MessageBox.Show(" Cliente eliminado con éxito.");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($" Error al eliminar: {ex.Message}");
            }
        }

        public async Task CrearCliente(string nombre, string email, decimal saldo)
        {
            using var context = new AppDbContext();
            var nuevo = new Cliente
            {
                Nombre = nombre,
                Email = email,
                Saldo = saldo
            };
            context.Clientes.Add(nuevo);
            await context.SaveChangesAsync();
            MessageBox.Show(" Cliente registrado.");
        }

        public List<Cliente> ListarClientes()
        {
            using var context = new AppDbContext();
            return context.Clientes.ToList();
        }
        public async Task EditarCliente(int idCliente, string nuevoNombre, string nuevoEmail)
        {
            using var context = new AppDbContext();

            var cliente = await context.Clientes.FindAsync(idCliente);
            if (cliente == null)
                throw new Exception("Cliente no encontrado.");

            cliente.Nombre = nuevoNombre;
            cliente.Email = nuevoEmail;

            await context.SaveChangesAsync();
            MessageBox.Show("Cliente Actualizado exitosamente.");
        }

    }
}
