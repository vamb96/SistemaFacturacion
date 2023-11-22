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
    public partial class F_EditarProducto : Form
    {
        private IServiceProduct _serviceProducto;
        private Product Product;
        int _idProduct;
        public F_EditarProducto(int idProduct,IServiceProduct serviceProduct)
        {
            InitializeComponent();
            _serviceProducto = serviceProduct;
            Product = _serviceProducto.Get(idProduct);
            _idProduct = idProduct;

            TXT_Descripcion.Text = Product.Description;
            CHK_Activo.Checked = Product.IsActivo;

        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Description = TXT_Descripcion.Text;
                product.IsActivo = CHK_Activo.Checked;

                _serviceProducto.Update(product, _idProduct);

                MessageBox.Show("El producto ha sido actualizado con exito");

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al actualizar el producto.");

            }

        }
    }
}
