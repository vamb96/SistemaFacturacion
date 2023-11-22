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
            DGV_Clientes = new DataGridView();
            BT_Buscar = new Button();
            label2 = new Label();
            TXT_Name = new TextBox();
            label1 = new Label();
            BT_Agregar = new Button();
            ID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            IsActivo = new DataGridViewCheckBoxColumn();
            CustomerTypeId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV_Clientes).BeginInit();
            SuspendLayout();
            // 
            // DGV_Clientes
            // 
            DGV_Clientes.AllowUserToAddRows = false;
            DGV_Clientes.AllowUserToDeleteRows = false;
            DGV_Clientes.AllowUserToOrderColumns = true;
            DGV_Clientes.AllowUserToResizeColumns = false;
            DGV_Clientes.AllowUserToResizeRows = false;
            DGV_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Clientes.Columns.AddRange(new DataGridViewColumn[] { ID, CustName, Adress, Status, IsActivo, CustomerTypeId });
            DGV_Clientes.Location = new Point(37, 75);
            DGV_Clientes.MultiSelect = false;
            DGV_Clientes.Name = "DGV_Clientes";
            DGV_Clientes.ReadOnly = true;
            DGV_Clientes.RowHeadersVisible = false;
            DGV_Clientes.RowTemplate.Height = 25;
            DGV_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Clientes.Size = new Size(537, 150);
            DGV_Clientes.TabIndex = 12;
            DGV_Clientes.CellClick += DGV_Clientes_CellClick;
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Location = new Point(499, 51);
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
            label2.Location = new Point(37, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // TXT_Name
            // 
            TXT_Name.Location = new Point(97, 48);
            TXT_Name.Name = "TXT_Name";
            TXT_Name.Size = new Size(384, 23);
            TXT_Name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "Agregar Cliente";
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Location = new Point(233, 229);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(139, 44);
            BT_Agregar.TabIndex = 7;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // CustName
            // 
            CustName.HeaderText = "Nombre";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // Adress
            // 
            Adress.HeaderText = "Direccion";
            Adress.Name = "Adress";
            Adress.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IsActivo
            // 
            IsActivo.HeaderText = "Activo";
            IsActivo.Name = "IsActivo";
            IsActivo.ReadOnly = true;
            // 
            // CustomerTypeId
            // 
            CustomerTypeId.HeaderText = "Tipo";
            CustomerTypeId.Name = "CustomerTypeId";
            CustomerTypeId.ReadOnly = true;
            // 
            // F_AgregarClienteFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 290);
            Controls.Add(DGV_Clientes);
            Controls.Add(BT_Buscar);
            Controls.Add(label2);
            Controls.Add(TXT_Name);
            Controls.Add(label1);
            Controls.Add(BT_Agregar);
            Name = "F_AgregarClienteFactura";
            Text = "Agregar Cliente a Factura";
            ((System.ComponentModel.ISupportInitialize)DGV_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Clientes;
        private Button BT_Buscar;
        private Label label2;
        private TextBox TXT_Name;
        private Label label1;
        private Button BT_Agregar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewCheckBoxColumn IsActivo;
        private DataGridViewTextBoxColumn CustomerTypeId;
    }
}