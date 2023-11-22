using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class F_AgregarClienteFactura : Form
    {
        IServiceInvoice _serviceInvoice;
        Customer _Customer;
        Invoice invoice;



        public F_AgregarClienteFactura(IServiceInvoice Serviceinvoice, Invoice invoices)
        {
            InitializeComponent();
            _serviceInvoice = Serviceinvoice;
            invoice = invoices;
            ActualizarDGV();

        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            if (DGV_Clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGV_Clientes.SelectedRows[0];
                int idCliente = (int)filaSeleccionada.Cells[0].Value;

                _Customer = _serviceInvoice.GetCustomerId(idCliente);
                invoice.Customer = _Customer;
                this.Close();
            }

        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<Customer> listCustomers = _serviceInvoice.GetCustomerName(TXT_Name.Text);

            if (listCustomers.Count > 0)
            {
                DGV_Clientes.Rows.Clear();
                foreach (Customer item in listCustomers)
                {
                    DGV_Clientes.Rows.Add(item.Id, item.CustName, item.Adress, item.Status, item.IsActivo, item.CustomerTypeId);
                }
            }
        }

        private void DGV_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDGV()
        {
            List<Customer> listCustomer = _serviceInvoice.GetCustomerAll();

            if (listCustomer.Count > 0)
            {
                DGV_Clientes.Rows.Clear();
                foreach (Customer item in listCustomer)
                {
                    DGV_Clientes.Rows.Add(item.Id, item.CustName, item.Adress, item.Status, item.IsActivo, item.CustomerTypeId);
                }

            }
        }
    }
}
