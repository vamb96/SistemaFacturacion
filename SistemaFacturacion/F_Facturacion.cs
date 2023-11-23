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
        IServiceInvoice _service = new ServiceInvoice(Universal.GetStringConexion());
        Invoice invoice;
        Action _actualizarTotales;
        Action _actualizarDGV;


        public F_Facturacion()
        {
            InitializeComponent();
            invoice = new Invoice();
            invoice.ListDetails = new List<InvoiceDetail>();
            invoice.dateTime = DateTime.Now;
            LBL_Fecha.Text = invoice.dateTime.ToString();
            _actualizarTotales = CalcularTotales;
            _actualizarDGV = ActualizarDGV;

        }

        private void BT_AgregarProducto_Click(object sender, EventArgs e)
        {
            F_AgregarProductoFactura mostrar = new F_AgregarProductoFactura(_service, invoice, _actualizarTotales);
            mostrar.ShowDialog();
            ActualizarDGV();
        }

        private void BT_AgregarClienteFactura_Click(object sender, EventArgs e)
        {
            F_AgregarClienteFactura mostrar = new F_AgregarClienteFactura(_service, invoice);
            mostrar.ShowDialog();
            if (invoice.Customer != null)
            {
                ActualizarInfocliente();
            }

        }

        public void CalcularTotales()
        {
            invoice.Total = 0;
            invoice.SubTotal = 0;
            invoice.TotalItbis = 0;
            foreach (InvoiceDetail item in invoice.ListDetails)
            {
                invoice.TotalItbis += item.TotalItbis;
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
                DGV_DetalleFactura.Rows.Add(item.id, item.ProductId, item.producto.Description, item.Qty, item.Price, item.SubTotal, item.TotalItbis, item.Total);
            }

        }

        private void BT_GuardarFactura_Click(object sender, EventArgs e)
        {
            if (invoice.Customer != null && invoice.ListDetails.Count > 0)
            {
                try
                {
                    CalcularTotales();
                    _service.Add(invoice);
                    MessageBox.Show("Factura gurada con exito.");
                    this.Hide();
                    F_Facturacion mostrar = new F_Facturacion();
                    mostrar.ShowDialog();
                }
                catch (Exception)
                {

                    throw;//MessageBox.Show("Ha ocurrido un error al guardar la factura");
                }
                
            }
            else
            {
                MessageBox.Show("Complete los datos de la factura");
            }

        }

        private void ActualizarInfocliente()
        {
            TXT_IdCliente.Text = invoice.Customer.Id.ToString();
            TXT_NombreCliente.Text = invoice.Customer.CustName;
        }

        private void DGV_DetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DGV_DetalleFactura.Columns["Editar"].Index && e.RowIndex >= 0)
                {
                    int idDetail = Convert.ToInt32(DGV_DetalleFactura.Rows[e.RowIndex].Cells["Id"].Value);

                    F_EditarProductoFactura mostrar = new F_EditarProductoFactura(idDetail, invoice, _service, _actualizarTotales, _actualizarDGV);
                    mostrar.ShowDialog();
                    ActualizarDGV();

                }
                if (e.ColumnIndex == DGV_DetalleFactura.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idDetail = Convert.ToInt32(DGV_DetalleFactura.Rows[e.RowIndex].Cells["Id"].Value);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {

                            if (_service.DeleteDetail(idDetail, invoice))
                            {
                                MessageBox.Show("El producto ha sido eliminado con exito");
                                ActualizarDGV();
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ha ocurrido un error al eliminar el producto");
                        }

                    }
                    else
                    {
                        Console.WriteLine("El usuario ha presionado 'No' o ha cerrado el mensaje");
                    }
                }
            }


            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al seleccionar esta opcion.");
            }
        }

        private void ListadoFacturas_Click(object sender, EventArgs e)
        {
            F_ListaFacturas mostrar = new F_ListaFacturas(_service);
            mostrar.ShowDialog();
        }
    }
}
