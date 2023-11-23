namespace SistemaFacturacion
{
    partial class F_AdministrarTipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AdministrarTipoCliente));
            label2 = new Label();
            BT_Buscar = new Button();
            BT_Agregar = new Button();
            TXT_Buscar = new TextBox();
            DGV_CustomerType = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            IsActivo = new DataGridViewCheckBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_CustomerType).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 9);
            label2.Name = "label2";
            label2.Size = new Size(255, 25);
            label2.TabIndex = 17;
            label2.Text = "Administrar Tipo de Cliente";
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Image = (Image)resources.GetObject("BT_Buscar.Image");
            BT_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Buscar.Location = new Point(248, 76);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(91, 27);
            BT_Buscar.TabIndex = 13;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Image = (Image)resources.GetObject("BT_Agregar.Image");
            BT_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Agregar.Location = new Point(409, 76);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(99, 29);
            BT_Agregar.TabIndex = 14;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // TXT_Buscar
            // 
            TXT_Buscar.Location = new Point(74, 77);
            TXT_Buscar.Name = "TXT_Buscar";
            TXT_Buscar.Size = new Size(167, 23);
            TXT_Buscar.TabIndex = 12;
            // 
            // DGV_CustomerType
            // 
            DGV_CustomerType.AllowUserToAddRows = false;
            DGV_CustomerType.AllowUserToDeleteRows = false;
            DGV_CustomerType.AllowUserToResizeColumns = false;
            DGV_CustomerType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CustomerType.Columns.AddRange(new DataGridViewColumn[] { ID, CustName, IsActivo, Editar, Eliminar });
            DGV_CustomerType.Location = new Point(12, 106);
            DGV_CustomerType.MultiSelect = false;
            DGV_CustomerType.Name = "DGV_CustomerType";
            DGV_CustomerType.RowHeadersVisible = false;
            DGV_CustomerType.RowTemplate.Height = 25;
            DGV_CustomerType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_CustomerType.Size = new Size(496, 207);
            DGV_CustomerType.TabIndex = 16;
            DGV_CustomerType.CellClick += DGV_CustomerType_CellClick;
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
            // IsActivo
            // 
            IsActivo.Frozen = true;
            IsActivo.HeaderText = "Activo";
            IsActivo.Name = "IsActivo";
            IsActivo.ReadOnly = true;
            IsActivo.Resizable = DataGridViewTriState.True;
            IsActivo.SortMode = DataGridViewColumnSortMode.Automatic;
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
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 15;
            label1.Text = "Nombre:";
            // 
            // F_AdministrarTipoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 321);
            Controls.Add(label2);
            Controls.Add(BT_Buscar);
            Controls.Add(BT_Agregar);
            Controls.Add(TXT_Buscar);
            Controls.Add(DGV_CustomerType);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_AdministrarTipoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Tipo De Cliente";
            ((System.ComponentModel.ISupportInitialize)DGV_CustomerType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BT_Buscar;
        private Button BT_Agregar;
        private TextBox TXT_Buscar;
        private DataGridView DGV_CustomerType;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewCheckBoxColumn IsActivo;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Label label1;
    }
}