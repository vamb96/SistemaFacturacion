﻿namespace SistemaFacturacion
{
    partial class F_AdministrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AdministrarCliente));
            label1 = new Label();
            DGV_Customer = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            IsActivo = new DataGridViewCheckBoxColumn();
            CustomerType = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            TXT_Buscar = new TextBox();
            BT_Agregar = new Button();
            BT_Buscar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Customer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // DGV_Customer
            // 
            DGV_Customer.AllowUserToAddRows = false;
            DGV_Customer.AllowUserToDeleteRows = false;
            DGV_Customer.AllowUserToResizeColumns = false;
            DGV_Customer.AllowUserToResizeRows = false;
            DGV_Customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Customer.Columns.AddRange(new DataGridViewColumn[] { ID, CustName, Adress, Status, IsActivo, CustomerType, Editar, Eliminar });
            DGV_Customer.Location = new Point(18, 109);
            DGV_Customer.MultiSelect = false;
            DGV_Customer.Name = "DGV_Customer";
            DGV_Customer.RowHeadersVisible = false;
            DGV_Customer.RowTemplate.Height = 25;
            DGV_Customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Customer.Size = new Size(804, 207);
            DGV_Customer.TabIndex = 4;
            DGV_Customer.CellClick += DGV_Customer_CellClick;
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
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // TXT_Buscar
            // 
            TXT_Buscar.Location = new Point(81, 80);
            TXT_Buscar.Name = "TXT_Buscar";
            TXT_Buscar.Size = new Size(240, 23);
            TXT_Buscar.TabIndex = 1;
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Image = (Image)resources.GetObject("BT_Agregar.Image");
            BT_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Agregar.Location = new Point(718, 79);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(104, 27);
            BT_Agregar.TabIndex = 3;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // BT_Buscar
            // 
            BT_Buscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Buscar.Image = (Image)resources.GetObject("BT_Buscar.Image");
            BT_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Buscar.Location = new Point(326, 78);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(89, 27);
            BT_Buscar.TabIndex = 2;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(301, 18);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 5;
            label2.Text = "Administrar Cliente";
            // 
            // F_AdministrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 330);
            Controls.Add(label2);
            Controls.Add(BT_Buscar);
            Controls.Add(BT_Agregar);
            Controls.Add(TXT_Buscar);
            Controls.Add(DGV_Customer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_AdministrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Cliente";
            ((System.ComponentModel.ISupportInitialize)DGV_Customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGV_Customer;
        private TextBox TXT_Buscar;
        private Button BT_Agregar;
        private Button BT_Buscar;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewCheckBoxColumn IsActivo;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}