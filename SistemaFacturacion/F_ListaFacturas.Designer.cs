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
            dataGridView1 = new DataGridView();
            IdInvoice = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            TotalItbis = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 48);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Listado de facturas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdInvoice, Customer, SubTotal, TotalItbis, Total, DateTime });
            dataGridView1.Location = new Point(12, 97);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(603, 198);
            dataGridView1.TabIndex = 2;
            // 
            // IdInvoice
            // 
            IdInvoice.HeaderText = "ID Factura";
            IdInvoice.Name = "IdInvoice";
            IdInvoice.ReadOnly = true;
            // 
            // Customer
            // 
            Customer.HeaderText = "Cliente";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
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
            // F_ListaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 444);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "F_ListaFacturas";
            Text = "Lista de Facturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdInvoice;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn TotalItbis;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn DateTime;
    }
}