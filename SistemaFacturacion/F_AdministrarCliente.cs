﻿using Controladores.Services;
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
    public partial class F_AdministrarCliente : Form
    {
        IServiceCustomer ServiceCustomer = new ServiceCustomer(Universal.GetStringConexion());

        public F_AdministrarCliente()
        {
            InitializeComponent();
            ActualizarDGV();

        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            F_AgregarCliente mostrar = new F_AgregarCliente(ServiceCustomer);
            mostrar.ShowDialog();
            ActualizarDGV();
        }

        public void ActualizarDGV()
        {
            DGV_Customer.Rows.Clear();
            foreach (Customer customer in ServiceCustomer.GetAll())
            {
                string NameCustomerType ="";
                if (ServiceCustomer.GetCustomerType(customer.CustomerTypeId) != null)
                {
                    NameCustomerType = ServiceCustomer.GetCustomerType(customer.CustomerTypeId).Description;
                }

                DGV_Customer.Rows.Add(customer.Id, customer.CustName, customer.Adress, customer.Status,
                    customer.IsActivo, NameCustomerType);
            }
        }

        private void DGV_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DGV_Customer.Columns["Editar"].Index && e.RowIndex >= 0)
                {
                    int idCustomer = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells["ID"].Value);

                    F_EditarCliente mostrar = new F_EditarCliente(idCustomer, ServiceCustomer);
                    mostrar.ShowDialog();
                    ActualizarDGV();

                }
                if (e.ColumnIndex == DGV_Customer.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idCustomer = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {

                            if (ServiceCustomer.Delete(idCustomer))
                            {
                                MessageBox.Show("El cliente ha sido eliminado con exito");
                                ActualizarDGV();
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ha ocurrido un error al eliminar el cliente");
                        }

                    }
                    else
                    {
                        Console.WriteLine("El usuario ha presionado 'No' o ha cerrado el mensaje");
                    }
                }
            }


            catch (Exception)
            {

                throw;//MessageBox.Show("Ha ocurrido un error al seleccionar esta opcion.");
            }
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<Customer> ListCustomer = ServiceCustomer.GetCustomers(TXT_Buscar.Text);

            DGV_Customer.Rows.Clear();
            foreach (Customer customer in ListCustomer)
            {
                DGV_Customer.Rows.Add(customer.Id, customer.CustName, customer.Adress, customer.Status,
                customer.IsActivo, customer.CustomerTypeId);
            }
        }
    }
}
