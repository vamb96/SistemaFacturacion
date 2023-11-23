namespace SistemaFacturacion
{
    partial class F_EditarProductoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EditarProductoFactura));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TXT_Descripcion = new TextBox();
            NUD_Cantidad = new NumericUpDown();
            BT_Modificar = new Button();
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Modificar producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 111);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // TXT_Descripcion
            // 
            TXT_Descripcion.Location = new Point(109, 69);
            TXT_Descripcion.Name = "TXT_Descripcion";
            TXT_Descripcion.ReadOnly = true;
            TXT_Descripcion.Size = new Size(218, 23);
            TXT_Descripcion.TabIndex = 4;
            // 
            // NUD_Cantidad
            // 
            NUD_Cantidad.Location = new Point(109, 109);
            NUD_Cantidad.Name = "NUD_Cantidad";
            NUD_Cantidad.Size = new Size(100, 23);
            NUD_Cantidad.TabIndex = 1;
            // 
            // BT_Modificar
            // 
            BT_Modificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Modificar.Image = (Image)resources.GetObject("BT_Modificar.Image");
            BT_Modificar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Modificar.Location = new Point(135, 153);
            BT_Modificar.Name = "BT_Modificar";
            BT_Modificar.Size = new Size(138, 40);
            BT_Modificar.TabIndex = 3;
            BT_Modificar.Text = "Modificar";
            BT_Modificar.UseVisualStyleBackColor = true;
            BT_Modificar.Click += BT_Modificar_Click;
            // 
            // F_EditarProductoFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 208);
            Controls.Add(BT_Modificar);
            Controls.Add(NUD_Cantidad);
            Controls.Add(TXT_Descripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_EditarProductoFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Productos en la Factura";
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TXT_Descripcion;
        private NumericUpDown NUD_Cantidad;
        private Button BT_Modificar;
    }
}