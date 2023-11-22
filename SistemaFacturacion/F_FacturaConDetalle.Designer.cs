namespace SistemaFacturacion
{
    partial class F_FacturaConDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            LBL_IdInvoice = new Label();
            groupBox2 = new GroupBox();
            TXT_TotalFactura = new TextBox();
            TXT_SubTotalFactura = new TextBox();
            TXT_ItbisTotal = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            DGV_DetalleFactura = new DataGridView();
            IdProduc = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Itebis = new DataGridViewTextBoxColumn();
            SubTotalDetalle = new DataGridViewTextBoxColumn();
            TotalDetalle = new DataGridViewTextBoxColumn();
            EditarProducto = new DataGridViewButtonColumn();
            EliminarProducto = new DataGridViewButtonColumn();
            LBL_Fecha = new Label();
            LBL_IdCliente = new Label();
            LBL_Nombre = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LBL_IdInvoice);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(DGV_DetalleFactura);
            groupBox1.Controls.Add(LBL_Fecha);
            groupBox1.Controls.Add(LBL_IdCliente);
            groupBox1.Controls.Add(LBL_Nombre);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // LBL_IdInvoice
            // 
            LBL_IdInvoice.AutoSize = true;
            LBL_IdInvoice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_IdInvoice.Location = new Point(6, 0);
            LBL_IdInvoice.Name = "LBL_IdInvoice";
            LBL_IdInvoice.Size = new Size(83, 20);
            LBL_IdInvoice.TabIndex = 9;
            LBL_IdInvoice.Text = "ID_Factura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TXT_TotalFactura);
            groupBox2.Controls.Add(TXT_SubTotalFactura);
            groupBox2.Controls.Add(TXT_ItbisTotal);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(615, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 128);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totales";
            // 
            // TXT_TotalFactura
            // 
            TXT_TotalFactura.Location = new Point(67, 96);
            TXT_TotalFactura.Name = "TXT_TotalFactura";
            TXT_TotalFactura.ReadOnly = true;
            TXT_TotalFactura.Size = new Size(100, 25);
            TXT_TotalFactura.TabIndex = 9;
            // 
            // TXT_SubTotalFactura
            // 
            TXT_SubTotalFactura.Location = new Point(67, 63);
            TXT_SubTotalFactura.Name = "TXT_SubTotalFactura";
            TXT_SubTotalFactura.ReadOnly = true;
            TXT_SubTotalFactura.Size = new Size(100, 25);
            TXT_SubTotalFactura.TabIndex = 8;
            // 
            // TXT_ItbisTotal
            // 
            TXT_ItbisTotal.Location = new Point(67, 27);
            TXT_ItbisTotal.Name = "TXT_ItbisTotal";
            TXT_ItbisTotal.ReadOnly = true;
            TXT_ItbisTotal.Size = new Size(100, 25);
            TXT_ItbisTotal.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 102);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 6;
            label6.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 67);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 5;
            label5.Text = "SubTotal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 32);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 4;
            label4.Text = "Itbis:";
            // 
            // DGV_DetalleFactura
            // 
            DGV_DetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetalleFactura.Columns.AddRange(new DataGridViewColumn[] { IdProduc, Qty, Price, Itebis, SubTotalDetalle, TotalDetalle, EditarProducto, EliminarProducto });
            DGV_DetalleFactura.Location = new Point(6, 76);
            DGV_DetalleFactura.MultiSelect = false;
            DGV_DetalleFactura.Name = "DGV_DetalleFactura";
            DGV_DetalleFactura.RowHeadersVisible = false;
            DGV_DetalleFactura.RowTemplate.Height = 25;
            DGV_DetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetalleFactura.Size = new Size(603, 196);
            DGV_DetalleFactura.TabIndex = 7;
            // 
            // IdProduc
            // 
            IdProduc.Frozen = true;
            IdProduc.HeaderText = "Descripcion";
            IdProduc.Name = "IdProduc";
            IdProduc.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.Frozen = true;
            Qty.HeaderText = "Cantidad";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Price
            // 
            Price.Frozen = true;
            Price.HeaderText = "Precio";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Itebis
            // 
            Itebis.Frozen = true;
            Itebis.HeaderText = "Itbis";
            Itebis.Name = "Itebis";
            Itebis.ReadOnly = true;
            // 
            // SubTotalDetalle
            // 
            SubTotalDetalle.Frozen = true;
            SubTotalDetalle.HeaderText = "SubTotal";
            SubTotalDetalle.Name = "SubTotalDetalle";
            SubTotalDetalle.ReadOnly = true;
            // 
            // TotalDetalle
            // 
            TotalDetalle.Frozen = true;
            TotalDetalle.HeaderText = "Total";
            TotalDetalle.Name = "TotalDetalle";
            TotalDetalle.ReadOnly = true;
            // 
            // EditarProducto
            // 
            EditarProducto.Frozen = true;
            EditarProducto.HeaderText = "Editar";
            EditarProducto.Name = "EditarProducto";
            EditarProducto.ReadOnly = true;
            // 
            // EliminarProducto
            // 
            EliminarProducto.Frozen = true;
            EliminarProducto.HeaderText = "Eliminar";
            EliminarProducto.Name = "EliminarProducto";
            EliminarProducto.ReadOnly = true;
            // 
            // LBL_Fecha
            // 
            LBL_Fecha.AutoSize = true;
            LBL_Fecha.Location = new Point(654, 31);
            LBL_Fecha.Name = "LBL_Fecha";
            LBL_Fecha.Size = new Size(43, 17);
            LBL_Fecha.TabIndex = 2;
            LBL_Fecha.Text = "Fecha";
            // 
            // LBL_IdCliente
            // 
            LBL_IdCliente.AutoSize = true;
            LBL_IdCliente.Location = new Point(19, 35);
            LBL_IdCliente.Name = "LBL_IdCliente";
            LBL_IdCliente.Size = new Size(69, 17);
            LBL_IdCliente.TabIndex = 1;
            LBL_IdCliente.Text = "ID Cliente";
            // 
            // LBL_Nombre
            // 
            LBL_Nombre.AutoSize = true;
            LBL_Nombre.Location = new Point(103, 35);
            LBL_Nombre.Name = "LBL_Nombre";
            LBL_Nombre.Size = new Size(58, 17);
            LBL_Nombre.TabIndex = 0;
            LBL_Nombre.Text = "Nombre";
            // 
            // F_FacturaConDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 321);
            Controls.Add(groupBox1);
            Name = "F_FacturaConDetalle";
            Text = " Factura Con Detalle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetalleFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LBL_Fecha;
        private Label LBL_IdCliente;
        private Label LBL_Nombre;
        private DataGridView DGV_DetalleFactura;
        private DataGridViewTextBoxColumn IdProduc;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Itebis;
        private DataGridViewTextBoxColumn SubTotalDetalle;
        private DataGridViewTextBoxColumn TotalDetalle;
        private DataGridViewButtonColumn EditarProducto;
        private DataGridViewButtonColumn EliminarProducto;
        private Label LBL_IdInvoice;
        private GroupBox groupBox2;
        private TextBox TXT_TotalFactura;
        private TextBox TXT_SubTotalFactura;
        private TextBox TXT_ItbisTotal;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}