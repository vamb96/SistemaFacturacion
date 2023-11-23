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
    public partial class F_EditarTipoCliente : Form
    {
        private IServiceCustomerTypes _serviceCustomerTypes;
        private CustomerTypes _type;
        public F_EditarTipoCliente(int id, IServiceCustomerTypes customerTypes)
        {
            InitializeComponent();
            _serviceCustomerTypes = customerTypes;
            _type = _serviceCustomerTypes.Find(id);


            TXT_Description.Text = _type.Description;

        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            CustomerTypes type = new CustomerTypes();
            type.Description = TXT_Description.Text;

            try
            {
                _serviceCustomerTypes.Update(_type.Id, type);
                MessageBox.Show("El tipo de cliente ha sido actualizado");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al editar el tipo de cliente");
            }

        }
    }
}
