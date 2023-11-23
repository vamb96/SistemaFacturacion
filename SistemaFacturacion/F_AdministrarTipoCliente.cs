using Controladores.Services;
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
    public partial class F_AdministrarTipoCliente : Form
    {
        IServiceCustomerTypes _service = new ServiceCustomerType(Universal.GetStringConexion());
        Action _actualizarDGV;
        public F_AdministrarTipoCliente()
        {
            InitializeComponent();
            ActualizarDGV();
            _actualizarDGV = ActualizarDGV;
        }






        private void ActualizarDGV()
        {
            List<CustomerTypes> listType = _service.GetListType();
            DGV_CustomerType.Rows.Clear();

            foreach (CustomerTypes type in listType)
            {
                DGV_CustomerType.Rows.Add(type.Id, type.Description);
            }
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            List<CustomerTypes> listCustomer = _service.GetListType(TXT_Buscar.Text);

            if (listCustomer.Count > 0)
            {
                DGV_CustomerType.Rows.Clear();
                foreach (CustomerTypes type in listCustomer)
                {
                    DGV_CustomerType.Rows.Add(type.Id, type.Description);
                }
            }
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {

            F_AgregarTipoCliente mostrar = new F_AgregarTipoCliente(_service, _actualizarDGV);
            mostrar.ShowDialog();
        }

        private void DGV_CustomerType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DGV_CustomerType.Columns["Editar"].Index && e.RowIndex >= 0)
                {
                    int idCustomerType = Convert.ToInt32(DGV_CustomerType.Rows[e.RowIndex].Cells["ID"].Value);

                    F_EditarTipoCliente mostrar = new F_EditarTipoCliente(idCustomerType, _service);
                    mostrar.ShowDialog();
                    ActualizarDGV();

                }
                if (e.ColumnIndex == DGV_CustomerType.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idCustomertype = Convert.ToInt32(DGV_CustomerType.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este Tipo de Cliente?", "Confirmación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {

                            if (_service.Delete(idCustomertype))
                            {
                                MessageBox.Show("El Tipo de Cliente ha sido eliminado con exito");
                                ActualizarDGV();
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ha ocurrido un error al eliminar el Tipo de Cliente");
                        }

                    }
                    else
                    {
                        Console.WriteLine("El usuario ha presionado 'No' o ha cerrado el mensaje");
                    }
                }
            }

            catch
            {
                MessageBox.Show("Ha ocurrido un error.");
            }
        }
    }
}
