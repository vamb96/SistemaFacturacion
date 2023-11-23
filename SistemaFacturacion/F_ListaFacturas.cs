using Datos.Interfaces;
using Datos.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class F_ListaFacturas : Form
    {
        IServiceInvoice _service;
        Invoice _invoice;
        List<InvoiceDetail> _invoiceDetails;
        public F_ListaFacturas(IServiceInvoice service)
        {
            InitializeComponent();
            _service = service;
            List<Invoice> listInvoice = _service.GetAll();


            foreach (Invoice invoice in listInvoice)
            {
                Customer customer = _service.GetCustomerId(invoice.CustomerId);
                DGV_ListadoFacturas.Rows.Add(invoice.Id, customer.CustName, invoice.SubTotal, invoice.TotalItbis, invoice.Total, invoice.dateTime);
            }
        }

        private void DGV_ListadoFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_ListadoFacturas.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DGV_ListadoFacturas.SelectedRows[0];
                int idInvoice = (int)fila.Cells[0].Value;

                _invoice = _service.Get(idInvoice);
                _invoiceDetails = _service.GetInvoiceDetails(idInvoice);

                F_FacturaConDetalle mostrar = new F_FacturaConDetalle(_invoice, _invoiceDetails, _service);
                mostrar.ShowDialog();
            }
        }
    }
}
