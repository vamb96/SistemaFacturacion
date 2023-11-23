﻿using Datos.Interfaces;
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
    public partial class F_EditarProductoFactura : Form
    {
        IServiceInvoice _serviceInvoice;
        Invoice _invoice;
        InvoiceDetail _invoiceDetail;
        Action _actualizarTotales;
        Action _actualizarDGV;
        public F_EditarProductoFactura(int idDetail, Invoice invoice, IServiceInvoice serviceInvoice, Action action, Action actualizarDGV)
        {
            InitializeComponent();
            _invoice = invoice;
            _serviceInvoice = serviceInvoice;
            _invoiceDetail = _serviceInvoice.FindDetail(idDetail, invoice);
            _actualizarTotales = action;
            _actualizarDGV = actualizarDGV;

            NUD_Cantidad.Minimum = 1;
            NUD_Cantidad.DecimalPlaces = 0;

            TXT_Descripcion.Text = _invoiceDetail.producto.Description;
            NUD_Cantidad.Value = _invoiceDetail.Qty;
            TXT_Precio.Text = _invoiceDetail.Price.ToString();

        }

        private void TXT_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                int value;
                if (!int.TryParse(TXT_Precio.Text + e.KeyChar, out value) || value <= 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void BT_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                _invoiceDetail.Qty = (int)NUD_Cantidad.Value;
                _invoiceDetail.Price = Convert.ToInt32(TXT_Precio.Text);
                _invoiceDetail.SubTotal = _invoiceDetail.Qty * _invoiceDetail.Price;
                _invoiceDetail.TotalItbis = _invoiceDetail.SubTotal * 0.18M;
                _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.TotalItbis;
                _actualizarTotales();
                _actualizarDGV();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error al modificar el producto");
            }


        }
    }
}
