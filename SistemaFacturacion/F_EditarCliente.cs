using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            CB_CustomerType.Items.Clear();
            
            TXT_CustName.Text = _customer.CustName;
            TXT_Adress.Text = _customer.Adress;
            CB_Status.SelectedIndex = Convert.ToInt32(_customer.Status);
            CKB_IsActivo.Checked = _customer.IsActivo;
            CB_CustomerType.Text = _customer.CustomerTypeId.ToString();

            foreach (CustomerTypes item in _serviceCustomer.GetCustomerTypes())
            {
                CB_CustomerType.Items.Add(item);
                if (_customer.CustomerTypeId == item.Id)
                {
                    CB_CustomerType.SelectedItem = item;
                }
            }
            CB_CustomerType.DisplayMember = "Description";
            

            //ustomerTypes type = _serviceCustomer.GetCustomerType(_customer.CustomerTypeId);
            //CB_CustomerType.SelectedItem = type;
            //CB_CustomerType.DisplayMember = "Description";
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
                CustomerTypes type = (CustomerTypes)CB_CustomerType.SelectedItem;       
                customer.CustomerTypeId = type.Id;

                _serviceCustomer.Update(customer, _idCustomer);
                MessageBox.Show("El cliente ha sido actualizado con exito.");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al actualizar el cliente.");

            }

        }
    }
}
