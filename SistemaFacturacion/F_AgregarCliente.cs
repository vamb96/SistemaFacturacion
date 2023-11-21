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
            Customer customer = new Customer();
            customer.CustName = TXT_CustName.Text;
            customer.Adress = TXT_Adress.Text;
            customer.Status = TXT_Status.Text;
            customer.IsActivo = CKB_IsActivo.Checked;
            customer.CustomerTypeId = CB_CustomerType.SelectedIndex;

            _customer.Add(customer);
        }
    }
}
