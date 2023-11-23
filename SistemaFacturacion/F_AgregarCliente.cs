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
    public partial class F_AgregarCliente : Form
    {
        private IServiceCustomer _customer;
        public F_AgregarCliente(IServiceCustomer service)
        {
            InitializeComponent();
            _customer = service;
            CB_CustomerType.Items.Clear();

            foreach (CustomerTypes item in _customer.GetCustomerTypes())
            {
                CB_CustomerType.Items.Add(item);
            }
            CB_CustomerType.DisplayMember = "Description";
            
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones())
                {
                    Customer customer = new Customer();
                    customer.CustName = TXT_CustName.Text;
                    customer.Adress = TXT_Adress.Text;
                    CustomerTypes type = (CustomerTypes)CB_CustomerType.SelectedItem;
                    customer.CustomerType = type;
                    customer.CustomerTypeId = type.Id;
                    if (CB_Status.SelectedItem == "Activo")
                    {
                        customer.Status = true;
                    }
                    else
                    {
                        customer.Status = false;

                    }
                    customer.IsActivo = CKB_IsActivo.Checked;

                    _customer.Add(customer);

                    MessageBox.Show($"Cliente: \"{customer.CustName}\" ha sido añadido con exito");
                    this.Close();
                }

            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Ha ocurrido un error al agregar el cliente");
            }

        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(TXT_CustName.Text))
            {
                MessageBox.Show("Introduzca el nombre del cliente");
                return false;
            }
            if (string.IsNullOrEmpty(TXT_Adress.Text))
            {
                MessageBox.Show("Introduzca la direccion del cliente");
                return false;
            }
            if (CB_Status.SelectedItem == null)
            {
                MessageBox.Show("Seleccione  el status del cliente");
                return false;
            }
            if (CB_CustomerType.SelectedItem == null)
            {
                MessageBox.Show("Seleccione  el status del cliente");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
