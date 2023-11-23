namespace SistemaFacturacion
{
    partial class F_ListaFacturas
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
            label1 = new Label();
            DGV_ListadoFacturas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            TotalItbis = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_ListadoFacturas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Listado de facturas";
            // 
            // DGV_ListadoFacturas
            // 
            DGV_ListadoFacturas.AllowUserToAddRows = false;
            DGV_ListadoFacturas.AllowUserToDeleteRows = false;
            DGV_ListadoFacturas.AllowUserToResizeColumns = false;
            DGV_ListadoFacturas.AllowUserToResizeRows = false;
            DGV_ListadoFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ListadoFacturas.Columns.AddRange(new DataGridViewColumn[] { Id, CustName, SubTotal, TotalItbis, Total, DateTime });
            DGV_ListadoFacturas.Location = new Point(12, 58);
            DGV_ListadoFacturas.MultiSelect = false;
            DGV_ListadoFacturas.Name = "DGV_ListadoFacturas";
            DGV_ListadoFacturas.ReadOnly = true;
            DGV_ListadoFacturas.RowHeadersVisible = false;
            DGV_ListadoFacturas.RowTemplate.Height = 25;
            DGV_ListadoFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_ListadoFacturas.Size = new Size(603, 198);
            DGV_ListadoFacturas.TabIndex = 2;
            DGV_ListadoFacturas.CellDoubleClick += DGV_ListadoFacturas_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID Factura";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // CustName
            // 
            CustName.HeaderText = "Cliente";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // TotalItbis
            // 
            TotalItbis.HeaderText = "Total Itbis";
            TotalItbis.Name = "TotalItbis";
            TotalItbis.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // DateTime
            // 
            DateTime.HeaderText = "Fecha";
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 259);
            label2.Name = "label2";
            label2.Size = new Size(358, 15);
            label2.TabIndex = 3;
            label2.Text = "Para ver el detalle de una factura presionar doble click en la factura";
            // 
            // F_ListaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 284);
            Controls.Add(label2);
            Controls.Add(DGV_ListadoFacturas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_ListaFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Facturas";
            ((System.ComponentModel.ISupportInitialize)DGV_ListadoFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGV_ListadoFacturas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn TotalItbis;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn DateTime;
        private Label label2;
    }
}