using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        public F_EditarProducto(int idProduct, IServiceProduct serviceProduct)
        {
            InitializeComponent();
            _serviceProducto = serviceProduct;
            Product = _serviceProducto.GetProductById(idProduct);
            _idProduct = idProduct;

            TXT_Descripcion.Text = Product.Description;
            CHK_Activo.Checked = Product.IsActivo;
            TXT_Precio.Text =  Product.Price.ToString();

        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {

            if (Validaciones())
            {
                try
                {
                    Product product = new Product();
                    product.Description = TXT_Descripcion.Text;
                    product.IsActivo = CHK_Activo.Checked;
                    product.Price = decimal.Parse(TXT_Precio.Text);

                    _serviceProducto.Update(product, _idProduct);

                    MessageBox.Show("El producto ha sido actualizado con exito");
                    this.Close();
                }
                catch (Exception)
                {

                    throw;//MessageBox.Show("Ha ocurrido un error al actualizar el producto.");
                }

            }

        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(TXT_Descripcion.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TXT_Precio.Text))
            {
                return false;
            }
            return true;
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
