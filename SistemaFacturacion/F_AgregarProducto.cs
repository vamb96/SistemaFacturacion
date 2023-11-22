using Controladores.Services;
using Datos.Interfaces;
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
        IServiceProduct service = new ServiceProduct("Data Source=VICTOR\\MSSQLSERVER01;Initial Catalog=SistemaFacturacion;Integrated Security=True;Trust Server Certificate=True;");
        public F_AgregarProducto()
        {
            InitializeComponent();
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
