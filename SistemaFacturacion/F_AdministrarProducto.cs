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
    public partial class F_AdministrarProducto : Form
    {
        IServiceProduct serviceProduct = new ServiceProduct("Data Source = VAMB; Initial Catalog = SistemaFacturacion; Integrated Security = True; Trust Server Certificate=True;");
        public F_AdministrarProducto()
        {
            InitializeComponent();
            ActualizarDGV();
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            F_AgregarProducto mostrar = new F_AgregarProducto(serviceProduct);
            mostrar.ShowDialog();
            ActualizarDGV();
        }

        public void ActualizarDGV()
        {
            DGV_Product.Rows.Clear();

            foreach (Product product in serviceProduct.GetAll())
            {
                DGV_Product.Rows.Add(product.Id, product.Description, product.IsActivo);
            }

        }

        private void DGV_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DGV_Product.Columns["Editar"].Index && e.RowIndex >= 0)
                {
                    int idProduct = Convert.ToInt32(DGV_Product.Rows[e.RowIndex].Cells["ID"].Value);

                    F_EditarProducto mostrar = new F_EditarProducto(idProduct, serviceProduct);
                    mostrar.ShowDialog();
                    ActualizarDGV();

                }
                if (e.ColumnIndex == DGV_Product.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idCustomer = Convert.ToInt32(DGV_Product.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {

                            if (serviceProduct.Delete(idCustomer))
                            {
                                MessageBox.Show("El producto ha sido eliminado con exito");
                                ActualizarDGV();
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ha ocurrido un error al eliminar el cliente");
                        }

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al seleccionar la opcion.");
            }
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<Product> listProduct = serviceProduct.GetAll();

            if (listProduct.Count > 0)
            {
                DGV_Product.Rows.Clear();
                foreach (Product item in serviceProduct.GetProducts(TXT_Buscar.Text))
                {
                    DGV_Product.Rows.Add(item.Id, item.Description, item.IsActivo);
                }
            }

        }
    }
}
