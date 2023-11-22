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
        IServiceCustomer ServiceCustomer = new ServiceCustomer("Data Source=VICTOR\\MSSQLSERVER01;Initial Catalog=SistemaFacturacion;Integrated Security=True;Trust Server Certificate=True;");

        public F_AdministrarCliente()
        {
            InitializeComponent();
            
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            F_AgregarCliente mostrar = new F_AgregarCliente(ServiceCustomer);
            mostrar.ShowDialog();
        }
    }
}
