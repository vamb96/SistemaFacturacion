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
    public partial class F_EditarCliente : Form
    {
        int _idCustomer;
        IServiceCustomer _serviceCustomer;
        Customer _customer;
        public F_EditarCliente(int idCustomer, IServiceCustomer ServiceCustomer)
        {
            InitializeComponent();
            _idCustomer = idCustomer;
            _serviceCustomer = ServiceCustomer;
            _customer = _serviceCustomer.Get(_idCustomer);

            TXT_CustName.Text = _customer.CustName;
            TXT_Adress.Text = _customer.Adress;
            CB_Status.SelectedIndex = Convert.ToInt32(_customer.Status);
            CKB_IsActivo.Checked = _customer.IsActivo;
            CB_CustomerType.SelectedIndex = Convert.ToInt32(_customer.CustomerType);
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.CustName = TXT_CustName.Text;
                customer.Adress = TXT_Adress.Text;
                customer.Status = Convert.ToBoolean(CB_Status.SelectedIndex);
                customer.IsActivo = Convert.ToBoolean(CKB_IsActivo.Checked);
                if (CB_CustomerType.SelectedItem == "Contado")
                {
                    customer.CustomerTypeId = 1;
                }
                else
                {
                    customer.CustomerTypeId = 2;
                }

                _serviceCustomer.Update(customer, _idCustomer);

                MessageBox.Show("El cliente ha sido actualizado con exito.");

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al actualizar el cliente.");
                
            }
            
        }
    }
}
