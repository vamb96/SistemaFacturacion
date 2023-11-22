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
    public partial class F_EditarProductoFactura : Form
    {
        IServiceInvoice _serviceInvoice;
        Invoice _invoice;
        InvoiceDetail _invoiceDetail;
        Action _actualizarTotales;
        public F_EditarProductoFactura(int idProduct, Invoice invoice, IServiceInvoice serviceInvoice, Action action)
        {
            InitializeComponent();
            _invoice = invoice;
            _actualizarTotales = action;
            NUD_Cantidad.Minimum = 1;
            NUD_Cantidad.DecimalPlaces = 0;

            foreach (InvoiceDetail item in _invoice.ListDetails)
            {
                if (item.ProductId == idProduct)
                {
                    _invoiceDetail = item;
                }
            }

            TXT_Descripcion.Text = _invoiceDetail.producto.Description;
            NUD_Cantidad.Value = _invoiceDetail.Qty;
            TXT_Precio.Text = _invoiceDetail.Price.ToString();

        }

        private void F_EditarProductoFactura_Load(object sender, EventArgs e)
        {
            _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
            _invoiceDetail.Price = Convert.ToInt32(TXT_Precio.Text);
            _actualizarTotales();

        }

        private void TXT_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                int value;
                if (!int.TryParse(TXT_Precio.Text + e.KeyChar, out value) || value <= 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
