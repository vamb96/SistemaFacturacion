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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_VentanaPrinciapl));
            BT_Facturar = new Button();
            BT_AdministrarCliente = new Button();
            BT_AdministrarProductos = new Button();
            BT_AdministrarTipoCliente = new Button();
            SuspendLayout();
            // 
            // BT_Facturar
            // 
            BT_Facturar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Facturar.Image = (Image)resources.GetObject("BT_Facturar.Image");
            BT_Facturar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Facturar.Location = new Point(48, 53);
            BT_Facturar.Name = "BT_Facturar";
            BT_Facturar.Size = new Size(138, 55);
            BT_Facturar.TabIndex = 1;
            BT_Facturar.Text = "Facturar";
            BT_Facturar.UseVisualStyleBackColor = true;
            BT_Facturar.Click += BT_Facturar_Click;
            // 
            // BT_AdministrarCliente
            // 
            BT_AdministrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AdministrarCliente.Image = (Image)resources.GetObject("BT_AdministrarCliente.Image");
            BT_AdministrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            BT_AdministrarCliente.Location = new Point(210, 53);
            BT_AdministrarCliente.Name = "BT_AdministrarCliente";
            BT_AdministrarCliente.Size = new Size(202, 55);
            BT_AdministrarCliente.TabIndex = 2;
            BT_AdministrarCliente.Text = "Administrar Clientes";
            BT_AdministrarCliente.UseVisualStyleBackColor = true;
            BT_AdministrarCliente.Click += BT_AdministrarCliente_Click;
            // 
            // BT_AdministrarProductos
            // 
            BT_AdministrarProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AdministrarProductos.Image = (Image)resources.GetObject("BT_AdministrarProductos.Image");
            BT_AdministrarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            BT_AdministrarProductos.Location = new Point(436, 53);
            BT_AdministrarProductos.Name = "BT_AdministrarProductos";
            BT_AdministrarProductos.Size = new Size(214, 55);
            BT_AdministrarProductos.TabIndex = 3;
            BT_AdministrarProductos.Text = "Administrar Productos";
            BT_AdministrarProductos.UseVisualStyleBackColor = true;
            BT_AdministrarProductos.Click += BT_AdministrarProductos_Click;
            // 
            // BT_AdministrarTipoCliente
            // 
            BT_AdministrarTipoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_AdministrarTipoCliente.Image = (Image)resources.GetObject("BT_AdministrarTipoCliente.Image");
            BT_AdministrarTipoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            BT_AdministrarTipoCliente.Location = new Point(692, 53);
            BT_AdministrarTipoCliente.Name = "BT_AdministrarTipoCliente";
            BT_AdministrarTipoCliente.Size = new Size(247, 55);
            BT_AdministrarTipoCliente.TabIndex = 4;
            BT_AdministrarTipoCliente.Text = "Administrar Tipo de Cliente";
            BT_AdministrarTipoCliente.UseVisualStyleBackColor = true;
            BT_AdministrarTipoCliente.Click += AdministrarTipoCliente_Click;
            // 
            // F_VentanaPrinciapl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 149);
            Controls.Add(BT_AdministrarTipoCliente);
            Controls.Add(BT_AdministrarProductos);
            Controls.Add(BT_AdministrarCliente);
            Controls.Add(BT_Facturar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_VentanaPrinciapl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Facturar;
        private Button BT_AdministrarCliente;
        private Button BT_AdministrarProductos;
        private Button BT_AdministrarTipoCliente;
    }
}