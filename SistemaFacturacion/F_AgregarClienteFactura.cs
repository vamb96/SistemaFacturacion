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
        Customer Customer;
        Invoice invoice;
        public F_AgregarClienteFactura(IServiceInvoice Serviceinvoice, Invoice invoice)
        {
            InitializeComponent();
            _serviceInvoice = Serviceinvoice;
            invoice = invoice;
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            invoice.Customer = Customer;
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            Customer = new Customer();
            Customer = _serviceInvoice.GetCustomer(Convert.ToInt32(TXT_Id));
        }
    }
}
