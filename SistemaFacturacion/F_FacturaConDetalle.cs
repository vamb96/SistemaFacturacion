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
    public partial class F_FacturaConDetalle : Form
    {
        Invoice _invoice;
        List<InvoiceDetail> _invoiceDetails;
        IServiceInvoice _service;
        public F_FacturaConDetalle(Invoice invoice, List<InvoiceDetail> invoiceDetails, IServiceInvoice service)
        {
            InitializeComponent();
            _invoice = invoice;
            _invoiceDetails = invoiceDetails;
            _service = service;
            Customer customer = _service.GetCustomerId(_invoice.CustomerId);
            LBL_IdInvoice.Text = _invoice.Id.ToString();
            LBL_IdCliente.Text = _invoice.CustomerId.ToString();
            LBL_Nombre.Text = customer.CustName;
            LBL_Fecha.Text = _invoice.dateTime.ToString();
            TXT_ItbisTotal.Text = _invoice.TotalItbis.ToString();
            TXT_SubTotalFactura.Text = _invoice.SubTotal.ToString();
            TXT_TotalFactura.Text = _invoice.Total.ToString();

            foreach (InvoiceDetail item in _invoiceDetails)
            {
                Product product = _service.GetProductId(item.ProductId);
                DGV_DetalleFactura.Rows.Add(product.Description, item.Qty, item.Price, item.TotalItbis, item.SubTotal, item.Total);
            }

        }
    }
}
