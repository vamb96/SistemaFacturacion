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
    public partial class F_AgregarProducto : Form
    {
        IServiceProduct _serviceProduct;
        public F_AgregarProducto(IServiceProduct serviceProduct)
        {
            InitializeComponent();
            _serviceProduct = serviceProduct;
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            if (Validaciones())
            {
                try
                {
                    product.Description = TXT_Description.Text;
                    product.IsActivo = CKB_IsActivo.Checked;
                    product.Price = decimal.Parse(TXT_Price.Text);
                    _serviceProduct.Add(product);

                    MessageBox.Show("El producto ha sido añadido con exito");
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un problema al agregar el producto");
                }
            }
            else
            {
                MessageBox.Show("Error al guardar el producto");
            }

        }


        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(TXT_Description.Text))
            {
                MessageBox.Show("Introduzca el nombre del producto");
                return false;
            }


            if (_serviceProduct.GetProductByDescription(TXT_Description.Text) != null)
            {
                MessageBox.Show("Existe un producto con este nombre");
                return false;
            }
            if (string.IsNullOrEmpty(TXT_Price.Text))
            {
                MessageBox.Show("Introduzca un valor en el precio.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
