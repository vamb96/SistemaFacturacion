namespace SistemaFacturacion
{
    partial class F_AdministrarProducto
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
            label2 = new Label();
            BT_Buscar = new Button();
            BT_Agregar = new Button();
            textBox1 = new TextBox();
            DGV_Customer = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            IsActivo = new DataGridViewTextBoxColumn();
            CustomerType = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Customer).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 24);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 11;
            label2.Text = "Administrar Producto";
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Location = new Point(317, 79);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(80, 27);
            BT_Buscar.TabIndex = 10;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Location = new Point(737, 79);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(80, 27);
            BT_Agregar.TabIndex = 9;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 8;
            // 
            // DGV_Customer
            // 
            DGV_Customer.AllowUserToAddRows = false;
            DGV_Customer.AllowUserToDeleteRows = false;
            DGV_Customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Customer.Columns.AddRange(new DataGridViewColumn[] { ID, CustName, Adress, Status, IsActivo, CustomerType, Editar, Eliminar });
            DGV_Customer.Location = new Point(13, 112);
            DGV_Customer.MultiSelect = false;
            DGV_Customer.Name = "DGV_Customer";
            DGV_Customer.RowHeadersVisible = false;
            DGV_Customer.RowTemplate.Height = 25;
            DGV_Customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Customer.Size = new Size(804, 207);
            DGV_Customer.TabIndex = 7;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // CustName
            // 
            CustName.Frozen = true;
            CustName.HeaderText = "Nombre";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // Adress
            // 
            Adress.Frozen = true;
            Adress.HeaderText = "Direccion";
            Adress.Name = "Adress";
            Adress.ReadOnly = true;
            // 
            // Status
            // 
            Status.Frozen = true;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // IsActivo
            // 
            IsActivo.Frozen = true;
            IsActivo.HeaderText = "Activo";
            IsActivo.Name = "IsActivo";
            IsActivo.ReadOnly = true;
            // 
            // CustomerType
            // 
            CustomerType.Frozen = true;
            CustomerType.HeaderText = "Tipo de cliente";
            CustomerType.Name = "CustomerType";
            CustomerType.ReadOnly = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 86);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "ID:";
            // 
            // F_AdministrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 330);
            Controls.Add(label2);
            Controls.Add(BT_Buscar);
            Controls.Add(BT_Agregar);
            Controls.Add(textBox1);
            Controls.Add(DGV_Customer);
            Controls.Add(label1);
            Name = "F_AdministrarProducto";
            Text = "F_AgregarProductos";
            ((System.ComponentModel.ISupportInitialize)DGV_Customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BT_Buscar;
        private Button BT_Agregar;
        private TextBox textBox1;
        private DataGridView DGV_Customer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn IsActivo;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Label label1;
    }
}