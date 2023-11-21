namespace SistemaFacturacion
{
    partial class F_AgregarClienteFactura
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
            DGV_Productos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            BT_Buscar = new Button();
            label2 = new Label();
            TXT_Id = new TextBox();
            label1 = new Label();
            BT_Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Productos).BeginInit();
            SuspendLayout();
            // 
            // DGV_Productos
            // 
            DGV_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Productos.Columns.AddRange(new DataGridViewColumn[] { ID, CustName });
            DGV_Productos.Location = new Point(25, 74);
            DGV_Productos.Name = "DGV_Productos";
            DGV_Productos.RowHeadersVisible = false;
            DGV_Productos.RowTemplate.Height = 25;
            DGV_Productos.Size = new Size(292, 150);
            DGV_Productos.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // CustName
            // 
            CustName.HeaderText = "Nombre";
            CustName.Name = "CustName";
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Location = new Point(173, 45);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(75, 23);
            BT_Buscar.TabIndex = 11;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 48);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 10;
            label2.Text = "ID:";
            // 
            // TXT_Id
            // 
            TXT_Id.Location = new Point(67, 45);
            TXT_Id.Name = "TXT_Id";
            TXT_Id.Size = new Size(100, 23);
            TXT_Id.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 5);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "Agregar Cliente";
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Location = new Point(88, 229);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(139, 44);
            BT_Agregar.TabIndex = 7;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // F_AgregarClienteFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 276);
            Controls.Add(DGV_Productos);
            Controls.Add(BT_Buscar);
            Controls.Add(label2);
            Controls.Add(TXT_Id);
            Controls.Add(label1);
            Controls.Add(BT_Agregar);
            Name = "F_AgregarClienteFactura";
            Text = "Agregar Cliente a Factura";
            ((System.ComponentModel.ISupportInitialize)DGV_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Productos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustName;
        private Button BT_Buscar;
        private Label label2;
        private TextBox TXT_Id;
        private Label label1;
        private Button BT_Agregar;
    }
}