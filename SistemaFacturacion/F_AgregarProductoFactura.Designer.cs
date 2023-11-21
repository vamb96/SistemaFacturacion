namespace SistemaFacturacion
{
    partial class F_AgregarProductoFactura
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
            BT_Agregar = new Button();
            label1 = new Label();
            TXT_Id = new TextBox();
            label2 = new Label();
            BT_Buscar = new Button();
            DGV_Productos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            TXT_Precio = new TextBox();
            NUD_Cantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DGV_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).BeginInit();
            SuspendLayout();
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Location = new Point(184, 232);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(139, 44);
            BT_Agregar.TabIndex = 0;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 7);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 1;
            label1.Text = "Agregar Producto";
            // 
            // TXT_Id
            // 
            TXT_Id.Location = new Point(142, 36);
            TXT_Id.Name = "TXT_Id";
            TXT_Id.Size = new Size(100, 23);
            TXT_Id.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Location = new Point(248, 36);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(75, 23);
            BT_Buscar.TabIndex = 5;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // DGV_Productos
            // 
            DGV_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Productos.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion });
            DGV_Productos.Location = new Point(100, 65);
            DGV_Productos.Name = "DGV_Productos";
            DGV_Productos.RowHeadersVisible = false;
            DGV_Productos.RowTemplate.Height = 25;
            DGV_Productos.Size = new Size(292, 106);
            DGV_Productos.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 193);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 192);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Precio:";
            // 
            // TXT_Precio
            // 
            TXT_Precio.Location = new Point(144, 189);
            TXT_Precio.Name = "TXT_Precio";
            TXT_Precio.Size = new Size(100, 23);
            TXT_Precio.TabIndex = 9;
            // 
            // NUD_Cantidad
            // 
            NUD_Cantidad.Location = new Point(330, 189);
            NUD_Cantidad.Name = "NUD_Cantidad";
            NUD_Cantidad.Size = new Size(62, 23);
            NUD_Cantidad.TabIndex = 10;
            // 
            // F_AgregarProductoFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 294);
            Controls.Add(NUD_Cantidad);
            Controls.Add(TXT_Precio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DGV_Productos);
            Controls.Add(BT_Buscar);
            Controls.Add(label2);
            Controls.Add(TXT_Id);
            Controls.Add(label1);
            Controls.Add(BT_Agregar);
            Name = "F_AgregarProductoFactura";
            Text = "Agregar Producto a Factura";
            ((System.ComponentModel.ISupportInitialize)DGV_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Agregar;
        private Label label1;
        private TextBox TXT_Id;
        private Label label2;
        private Button BT_Buscar;
        private DataGridView DGV_Productos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private Label label3;
        private Label label4;
        private TextBox TXT_Precio;
        private NumericUpDown NUD_Cantidad;
    }
}