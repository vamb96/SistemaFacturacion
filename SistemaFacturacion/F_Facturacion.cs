using Datos.Interfaces;
using Controladores.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using System.Drawing.Text;

namespace SistemaFacturacion
{
    public partial class F_Facturacion : Form
    {
        IServiceInvoice _service = new ServiceInvoice("Data Source=VAMB;Initial Catalog=SistemaFacturacion;Integrated Security=True;Trust Server Certificate=True;");
        Invoice invoice;
        Action _action;

        public F_Facturacion()
        {
            InitializeComponent();
            invoice = new Invoice();
            invoice.ListDetails = new List<InvoiceDetail>();
            invoice.dateTime = DateTime.Now;
            LBL_Fecha.Text = invoice.dateTime.ToString();
            _action = CalcularTotales; // Chequear
            //invoice.Id = IDTemporal();
        }

        private void BT_AgregarProducto_Click(object sender, EventArgs e)
        {
            F_AgregarProductoFactura mostrar = new F_AgregarProductoFactura(_service, invoice, _action);
            mostrar.ShowDialog();
            ActualizarDGV();


        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            F_AgregarClienteFactura mostrar = new F_AgregarClienteFactura(_service, invoice);
            mostrar.ShowDialog();
            TXT_IdCliente.Text = invoice.Customer.Id.ToString();
            TXT_NombreCliente.Text = invoice.Customer.CustName;
        }

        public void CalcularTotales()
        {
            invoice.Total = 0;
            invoice.SubTotal = 0;
            invoice.TotalItbis = 0;
            foreach (InvoiceDetail item in invoice.ListDetails)
            {
                invoice.TotalItbis += item.Itebis;
                invoice.SubTotal += item.SubTotal;
                invoice.Total += item.Total;
            }
            TXT_Itebis_Factura.Text = invoice.TotalItbis.ToString();
            TXT_SubTotalFactura.Text = invoice.SubTotal.ToString();
            TXT_TotalFactura.Text = invoice.Total.ToString();
        }

        private void ActualizarDGV()
        {
            DGV_DetalleFactura.Rows.Clear();

            foreach (InvoiceDetail item in invoice.ListDetails)
            {
                DGV_DetalleFactura.Rows.Add(item.producto.Description, item.Qty, item.Price, item.Itebis, item.SubTotal, item.Total);
            }

        }

        private void BT_GuardarFactura_Click(object sender, EventArgs e)
        {
            CalcularTotales();
            _service.Add(invoice);
        }

    }
}
