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
    public partial class F_AgregarProductoFactura : Form
    {
        private IServiceInvoice _service;
        Product _product = new Product();
        InvoiceDetail _invoiceDetail;
        Invoice _invoice;
        public F_AgregarProductoFactura(IServiceInvoice service, InvoiceDetail invoiceDetails, Invoice invoice)
        {
            InitializeComponent();
            _service = service;
            _invoiceDetail = invoiceDetails;
            _invoice = invoice;
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            _product = _service.GetProduct(Convert.ToInt32(TXT_Id));
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            _invoiceDetail = new InvoiceDetail();
            _invoiceDetail.InvoiceId = _invoice.Id;
            _invoiceDetail.IdProducto = _product.Id;
            _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
            _invoiceDetail.Price = Convert.ToInt32(TXT_Precio);
            _invoiceDetail.Itebis = _invoiceDetail.Qty * _invoiceDetail.Price * 0.18M;
            _invoiceDetail.SubTotal = _invoiceDetail.Qty * _invoiceDetail.Price;
            _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.Itebis;
            _invoiceDetail.producto = _product;
            _invoiceDetail.invoice = _invoice;

            _invoice.ListDetails.Add(_invoiceDetail);
        }
    }
}
