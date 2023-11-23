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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            NUD_Cantidad.Minimum = 1;
            NUD_Cantidad.DecimalPlaces = 0;
            ActualizarDGV();
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<Product> list = _service.GetProducts(TXT_Nombre.Text);

            if (list.Count > 0)
            {
                DGV_Productos.Rows.Clear();
                try
                {
                    foreach (Product item in list)
                    {
                        DGV_Productos.Rows.Add(item.Id, item.Description);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error al buscar el producto");
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

                if (!_invoice.ListDetails.Any(detail => detail.ProductId == idProducto))
                {

                    try
                    {
                        _invoiceDetail.ProductId = idProducto;
                        _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
                        _invoiceDetail.Price = producto.Price;
                        _invoiceDetail.SubTotal = _invoiceDetail.Qty * _invoiceDetail.Price;
                        _invoiceDetail.TotalItbis = _invoiceDetail.SubTotal * 0.18M;
                        _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.TotalItbis;
                        _invoiceDetail.producto = producto;
                        _invoiceDetail.invoice = _invoice;

                        _invoice.ListDetails.Add(_invoiceDetail);
                        _action();
                        this.Close();

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ha ocurrido un error intentelo nuevamente.");
                    }
                }
                else
                {
                    try
                    {
                        foreach (InvoiceDetail detail in _invoice.ListDetails)
                        {
                            if (detail.ProductId == producto.Id)
                            {
                                detail.Qty += Convert.ToInt32(NUD_Cantidad.Value);
                                detail.SubTotal = detail.Qty * detail.Price;
                                detail.TotalItbis = detail.SubTotal * 0.18M;
                                detail.Total = detail.SubTotal + detail.TotalItbis;
                                this.Close();
                                _action();
                            }

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ha ocurrido un error al agregar el producto");
                    }

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
                    DGV_Productos.Rows.Add(item.Id, item.Description, item.Price);
                }
            }
        }

    }
}
