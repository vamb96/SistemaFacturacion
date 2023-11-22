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
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.CustName = TXT_CustName.Text;
                customer.Adress = TXT_Adress.Text;
                if (CB_Status.SelectedItem == "Activo")
                {
                    customer.Status = true;
                }
                else
                {
                    customer.Status = false;

                }
                customer.IsActivo = CKB_IsActivo.Checked;
                if (CB_CustomerType.SelectedItem == "Contado")
                {
                    customer.CustomerTypeId = 1;
                }
                else
                {
                    customer.CustomerTypeId = 2;
                }
                _customer.Add(customer);
                MessageBox.Show($"Cliente:{customer.CustName} ha sido añadido con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al agregar el cliente");
            }
            
        }
    }
}
