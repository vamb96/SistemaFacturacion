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
    public partial class F_AgregarTipoCliente : Form
    {
        private IServiceCustomerTypes _service;
        private Action _actualizarDGV;
        public F_AgregarTipoCliente(IServiceCustomerTypes service, Action action)
        {
            InitializeComponent();
            _service = service;
            _actualizarDGV = action;
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            CustomerTypes type = new CustomerTypes();

            type.Description = TXT_Description.Text;
            _service.Add(type);
            _actualizarDGV();
            MessageBox.Show("El tipo de cliente ha sido añadido con exito.");
            this.Close();

        }
    }
}
