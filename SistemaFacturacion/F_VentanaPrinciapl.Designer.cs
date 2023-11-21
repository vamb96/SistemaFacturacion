namespace SistemaFacturacion
{
    partial class F_VentanaPrinciapl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BT_Facturar = new Button();
            BT_AdministrarCliente = new Button();
            BT_AdministrarProductos = new Button();
            SuspendLayout();
            // 
            // BT_Facturar
            // 
            BT_Facturar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Facturar.Location = new Point(58, 80);
            BT_Facturar.Name = "BT_Facturar";
            BT_Facturar.Size = new Size(177, 55);
            BT_Facturar.TabIndex = 0;
            BT_Facturar.Text = "Facturar";
            BT_Facturar.UseVisualStyleBackColor = true;
            BT_Facturar.Click += BT_Facturar_Click;
            // 
            // BT_AdministrarCliente
            // 
            BT_AdministrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AdministrarCliente.Location = new Point(277, 80);
            BT_AdministrarCliente.Name = "BT_AdministrarCliente";
            BT_AdministrarCliente.Size = new Size(177, 55);
            BT_AdministrarCliente.TabIndex = 1;
            BT_AdministrarCliente.Text = "Administrar Clientes";
            BT_AdministrarCliente.UseVisualStyleBackColor = true;
            BT_AdministrarCliente.Click += BT_AdministrarCliente_Click;
            // 
            // BT_AdministrarProductos
            // 
            BT_AdministrarProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AdministrarProductos.Location = new Point(498, 80);
            BT_AdministrarProductos.Name = "BT_AdministrarProductos";
            BT_AdministrarProductos.Size = new Size(177, 55);
            BT_AdministrarProductos.TabIndex = 2;
            BT_AdministrarProductos.Text = "Administrar Productos";
            BT_AdministrarProductos.UseVisualStyleBackColor = true;
            BT_AdministrarProductos.Click += BT_AdministrarProductos_Click;
            // 
            // F_VentanaPrinciapl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 230);
            Controls.Add(BT_AdministrarProductos);
            Controls.Add(BT_AdministrarCliente);
            Controls.Add(BT_Facturar);
            Name = "F_VentanaPrinciapl";
            Text = "Ventana Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Facturar;
        private Button BT_AdministrarCliente;
        private Button BT_AdministrarProductos;
    }
}