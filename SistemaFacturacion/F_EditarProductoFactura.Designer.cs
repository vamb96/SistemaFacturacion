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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TXT_Descripcion = new TextBox();
            TXT_Precio = new TextBox();
            NUD_Cantidad = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 16);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 152);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // TXT_Descripcion
            // 
            TXT_Descripcion.Location = new Point(109, 69);
            TXT_Descripcion.Name = "TXT_Descripcion";
            TXT_Descripcion.Size = new Size(218, 23);
            TXT_Descripcion.TabIndex = 4;
            // 
            // TXT_Precio
            // 
            TXT_Precio.Location = new Point(109, 149);
            TXT_Precio.Name = "TXT_Precio";
            TXT_Precio.Size = new Size(100, 23);
            TXT_Precio.TabIndex = 5;
            TXT_Precio.KeyPress += TXT_Precio_KeyPress;
            // 
            // NUD_Cantidad
            // 
            NUD_Cantidad.Location = new Point(109, 109);
            NUD_Cantidad.Name = "NUD_Cantidad";
            NUD_Cantidad.Size = new Size(100, 23);
            NUD_Cantidad.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(141, 200);
            button1.Name = "button1";
            button1.Size = new Size(121, 51);
            button1.TabIndex = 7;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // F_EditarProductoFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 261);
            Controls.Add(button1);
            Controls.Add(NUD_Cantidad);
            Controls.Add(TXT_Precio);
            Controls.Add(TXT_Descripcion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "F_EditarProductoFactura";
            Text = "Editar Productos Factura";
            Load += F_EditarProductoFactura_Load;
            ((System.ComponentModel.ISupportInitialize)NUD_Cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TXT_Descripcion;
        private TextBox TXT_Precio;
        private NumericUpDown NUD_Cantidad;
        private Button button1;
    }
}