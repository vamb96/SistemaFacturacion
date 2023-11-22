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
        InvoiceDetail InvoiceDetail;
        //private static int idTemporal = 5; // Inicializar el contador


        //Action ActualizarTotales = CalcularTotales;

        public F_Facturacion()
        {
            InitializeComponent();
            invoice = new Invoice();
            InvoiceDetail = new InvoiceDetail();
            LBL_Fecha.Text = DateTime.Now.ToString();
            //invoice.Id = IDTemporal();
        }

        private void BT_AgregarProducto_Click(object sender, EventArgs e)
        {
            F_AgregarProductoFactura mostrar = new F_AgregarProductoFactura(_service, InvoiceDetail, invoice);
            mostrar.ShowDialog();


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

        /*
        public static int IDTemporal()
        {
            
            int id = idTemporal;
            idTemporal++; 
            return id;
        }
        */
    }
}
