using Controladores.Services;
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
        InvoiceDetail _invoiceDetail;
        Invoice _invoice;
        public F_AgregarProductoFactura(IServiceInvoice service, InvoiceDetail invoiceDetails, Invoice invoice)
        {
            InitializeComponent();
            _service = service;
            _invoiceDetail = invoiceDetails;
            _invoice = invoice;
            ActualizarDGV();
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<Product> list = _service.GetProducts(TXT_Nombre.Text);

            if (list.Count > 0)
            {
                DGV_Productos.Rows.Clear();
                foreach (Product item in list)
                {
                    DGV_Productos.Rows.Add(item.Id,item.Description);
                }
            }
            else
            {
                MessageBox.Show("No hay productos que contengan esa palabra o caracter.");
            }
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {

            if (DGV_Productos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGV_Productos.SelectedRows[0];
                int idProducto = (int)filaSeleccionada.Cells[0].Value;

                Product producto = _service.GetProductId(idProducto);

                _invoiceDetail.InvoiceId = -1;
                _invoiceDetail.IdProducto = producto.Id;
                _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
                try
                {
                    int numeroEntero = Convert.ToInt32(TXT_Precio);
                    _invoiceDetail.Price = numeroEntero;
                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error al convertir el precio a entero.");
                }
                
                _invoiceDetail.Itebis = _invoiceDetail.Qty * _invoiceDetail.Price * 0.18M;
                _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.Itebis;
                _invoiceDetail.producto = producto;
                _invoiceDetail.invoice = _invoice;

                _invoice.ListDetails.Add(_invoiceDetail);
                MessageBox.Show("Producto añadido correctamente.");
            }

        }

        private void ActualizarDGV()
        {
            List<Product> listProducts = _service.GetProductAll();
            if (listProducts.Count > 0)
            {
                DGV_Productos.Rows.Clear();
                foreach (Product item in listProducts)
                {
                    DGV_Productos.Rows.Add(item.Id, item.Description);
                }
            }
        }
    }
}
