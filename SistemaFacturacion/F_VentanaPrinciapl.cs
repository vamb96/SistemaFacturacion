using Controladores.Services;
using Datos.Interfaces;

namespace SistemaFacturacion
{
    public partial class F_VentanaPrinciapl : Form
    {
        public F_VentanaPrinciapl()
        {
            InitializeComponent();
        }

        private void BT_AdministrarCliente_Click(object sender, EventArgs e)
        {
            F_AdministrarCliente mostrar = new F_AdministrarCliente();
            mostrar.ShowDialog();
        }

        private void BT_AdministrarProductos_Click(object sender, EventArgs e)
        {
            F_AdministrarProducto mostrar = new F_AdministrarProducto();
            mostrar.ShowDialog();
        }

        private void BT_Facturar_Click(object sender, EventArgs e)
        {
            F_Facturacion mostrar = new F_Facturacion();
            mostrar.ShowDialog();
        }
    }
}