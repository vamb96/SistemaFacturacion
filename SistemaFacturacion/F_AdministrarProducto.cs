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
    public partial class F_AdministrarProducto : Form
    {
        public F_AdministrarProducto()
        {
            InitializeComponent();
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            F_AgregarProducto mostrar = new F_AgregarProducto();
            mostrar.ShowDialog();
        }

    }
}
