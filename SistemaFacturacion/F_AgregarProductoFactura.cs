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
        Action _action;
        public F_AgregarProductoFactura(IServiceInvoice service, Invoice invoice, Action action)
        {
            InitializeComponent();
            _service = service;
            _invoice = invoice;
            _action = action;
            _invoiceDetail = new InvoiceDetail();
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

                try
                {
                    decimal numeroEntero = Convert.ToDecimal(TXT_Precio.Text);
                    
                    _invoiceDetail.ProductId = idProducto;//producto.Id;
                    _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
                    _invoiceDetail.Price = numeroEntero;
                    _invoiceDetail.SubTotal = _invoiceDetail.Qty * _invoiceDetail.Price;
                    _invoiceDetail.Itebis = _invoiceDetail.SubTotal * 0.18M;
                    _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.Itebis;
                    _invoiceDetail.producto = producto;
                    _invoiceDetail.invoice = _invoice;
                    
                    _invoice.ListDetails.Add(_invoiceDetail);
                    _action();
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error al convertir el precio a entero.");
                }
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
