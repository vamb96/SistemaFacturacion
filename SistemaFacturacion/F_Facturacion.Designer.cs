﻿namespace SistemaFacturacion
{
    partial class F_Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Facturacion));
            LBL_Fecha = new Label();
            groupBox1 = new GroupBox();
            BT_ListadoFacturas = new Button();
            BT_GuardarFactura = new Button();
            BT_AgregarProducto = new Button();
            BT_Buscar = new Button();
            DGV_DetalleFactura = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            IdProduc = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            SubTotalDetalle = new DataGridViewTextBoxColumn();
            Itebis = new DataGridViewTextBoxColumn();
            TotalDetalle = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            groupBox2 = new GroupBox();
            TXT_TotalFactura = new TextBox();
            TXT_SubTotalFactura = new TextBox();
            TXT_Itebis_Factura = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TXT_NombreCliente = new TextBox();
            TXT_IdCliente = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetalleFactura).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // LBL_Fecha
            // 
            LBL_Fecha.AutoSize = true;
            LBL_Fecha.Location = new Point(888, 19);
            LBL_Fecha.Name = "LBL_Fecha";
            LBL_Fecha.Size = new Size(38, 15);
            LBL_Fecha.TabIndex = 9;
            LBL_Fecha.Text = "Fecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BT_ListadoFacturas);
            groupBox1.Controls.Add(LBL_Fecha);
            groupBox1.Controls.Add(BT_GuardarFactura);
            groupBox1.Controls.Add(BT_AgregarProducto);
            groupBox1.Controls.Add(BT_Buscar);
            groupBox1.Controls.Add(DGV_DetalleFactura);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TXT_NombreCliente);
            groupBox1.Controls.Add(TXT_IdCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1061, 345);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Factura";
            // 
            // BT_ListadoFacturas
            // 
            BT_ListadoFacturas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_ListadoFacturas.Image = (Image)resources.GetObject("BT_ListadoFacturas.Image");
            BT_ListadoFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            BT_ListadoFacturas.Location = new Point(83, -5);
            BT_ListadoFacturas.Name = "BT_ListadoFacturas";
            BT_ListadoFacturas.Size = new Size(196, 28);
            BT_ListadoFacturas.TabIndex = 4;
            BT_ListadoFacturas.Text = "Ver Listado de facturas";
            BT_ListadoFacturas.UseVisualStyleBackColor = true;
            BT_ListadoFacturas.Click += ListadoFacturas_Click;
            // 
            // BT_GuardarFactura
            // 
            BT_GuardarFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BT_GuardarFactura.Image = (Image)resources.GetObject("BT_GuardarFactura.Image");
            BT_GuardarFactura.ImageAlign = ContentAlignment.MiddleLeft;
            BT_GuardarFactura.Location = new Point(855, 298);
            BT_GuardarFactura.Name = "BT_GuardarFactura";
            BT_GuardarFactura.Size = new Size(193, 39);
            BT_GuardarFactura.TabIndex = 3;
            BT_GuardarFactura.Text = "Guardar Factura";
            BT_GuardarFactura.UseVisualStyleBackColor = true;
            BT_GuardarFactura.Click += BT_GuardarFactura_Click;
            // 
            // BT_AgregarProducto
            // 
            BT_AgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AgregarProducto.Image = (Image)resources.GetObject("BT_AgregarProducto.Image");
            BT_AgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            BT_AgregarProducto.Location = new Point(855, 106);
            BT_AgregarProducto.Name = "BT_AgregarProducto";
            BT_AgregarProducto.Size = new Size(193, 39);
            BT_AgregarProducto.TabIndex = 2;
            BT_AgregarProducto.Text = "Agregar Producto";
            BT_AgregarProducto.UseVisualStyleBackColor = true;
            BT_AgregarProducto.Click += BT_AgregarProducto_Click;
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Image = (Image)resources.GetObject("BT_Buscar.Image");
            BT_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Buscar.Location = new Point(525, 22);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(189, 36);
            BT_Buscar.TabIndex = 1;
            BT_Buscar.Text = "Agregar Cliente";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_AgregarClienteFactura_Click;
            // 
            // DGV_DetalleFactura
            // 
            DGV_DetalleFactura.AllowUserToAddRows = false;
            DGV_DetalleFactura.AllowUserToDeleteRows = false;
            DGV_DetalleFactura.AllowUserToResizeColumns = false;
            DGV_DetalleFactura.AllowUserToResizeRows = false;
            DGV_DetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetalleFactura.Columns.AddRange(new DataGridViewColumn[] { Id, ProductId, IdProduc, Qty, Price, SubTotalDetalle, Itebis, TotalDetalle, Editar, Eliminar });
            DGV_DetalleFactura.Location = new Point(11, 76);
            DGV_DetalleFactura.MultiSelect = false;
            DGV_DetalleFactura.Name = "DGV_DetalleFactura";
            DGV_DetalleFactura.RowHeadersVisible = false;
            DGV_DetalleFactura.RowTemplate.Height = 25;
            DGV_DetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetalleFactura.Size = new Size(805, 261);
            DGV_DetalleFactura.TabIndex = 6;
            DGV_DetalleFactura.CellClick += DGV_DetalleFactura_CellClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // ProductId
            // 
            ProductId.Frozen = true;
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.Visible = false;
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
            // SubTotalDetalle
            // 
            SubTotalDetalle.Frozen = true;
            SubTotalDetalle.HeaderText = "SubTotal";
            SubTotalDetalle.Name = "SubTotalDetalle";
            SubTotalDetalle.ReadOnly = true;
            // 
            // Itebis
            // 
            Itebis.Frozen = true;
            Itebis.HeaderText = "Itbis";
            Itebis.Name = "Itebis";
            Itebis.ReadOnly = true;
            // 
            // TotalDetalle
            // 
            TotalDetalle.Frozen = true;
            TotalDetalle.HeaderText = "Total";
            TotalDetalle.Name = "TotalDetalle";
            TotalDetalle.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.Frozen = true;
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.Frozen = true;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TXT_TotalFactura);
            groupBox2.Controls.Add(TXT_SubTotalFactura);
            groupBox2.Controls.Add(TXT_Itebis_Factura);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(862, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 128);
            groupBox2.TabIndex = 5;
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
            // TXT_Itebis_Factura
            // 
            TXT_Itebis_Factura.Location = new Point(67, 27);
            TXT_Itebis_Factura.Name = "TXT_Itebis_Factura";
            TXT_Itebis_Factura.ReadOnly = true;
            TXT_Itebis_Factura.Size = new Size(100, 25);
            TXT_Itebis_Factura.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 102);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 6;
            label6.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 67);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "SubTotal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2, 32);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Total Itbis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 32);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // TXT_NombreCliente
            // 
            TXT_NombreCliente.Location = new Point(206, 29);
            TXT_NombreCliente.Name = "TXT_NombreCliente";
            TXT_NombreCliente.ReadOnly = true;
            TXT_NombreCliente.Size = new Size(313, 23);
            TXT_NombreCliente.TabIndex = 5;
            // 
            // TXT_IdCliente
            // 
            TXT_IdCliente.Location = new Point(38, 29);
            TXT_IdCliente.Name = "TXT_IdCliente";
            TXT_IdCliente.ReadOnly = true;
            TXT_IdCliente.Size = new Size(88, 23);
            TXT_IdCliente.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 32);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // F_Facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 371);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_Facturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetalleFactura).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LBL_Fecha;
        private GroupBox groupBox1;
        private Button BT_GuardarFactura;
        private Button BT_AgregarProducto;
        private DataGridView DGV_DetalleFactura;
        private GroupBox groupBox2;
        private TextBox TXT_TotalFactura;
        private TextBox TXT_SubTotalFactura;
        private TextBox TXT_Itebis_Factura;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TXT_NombreCliente;
        private TextBox TXT_IdCliente;
        private Label label2;
        private Button BT_Buscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn IdProduc;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn SubTotalDetalle;
        private DataGridViewTextBoxColumn Itebis;
        private DataGridViewTextBoxColumn TotalDetalle;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Button BT_ListadoFacturas;
    }
}