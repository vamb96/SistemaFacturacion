namespace SistemaFacturacion
{
    partial class F_EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EditarProducto));
            BT_Editar = new Button();
            TXT_Descripcion = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            CHK_Activo = new CheckBox();
            label3 = new Label();
            TXT_Precio = new TextBox();
            SuspendLayout();
            // 
            // BT_Editar
            // 
            BT_Editar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Editar.Image = (Image)resources.GetObject("BT_Editar.Image");
            BT_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Editar.Location = new Point(145, 182);
            BT_Editar.Name = "BT_Editar";
            BT_Editar.Size = new Size(118, 39);
            BT_Editar.TabIndex = 3;
            BT_Editar.Text = "Editar";
            BT_Editar.UseVisualStyleBackColor = true;
            BT_Editar.Click += BT_Editar_Click;
            // 
            // TXT_Descripcion
            // 
            TXT_Descripcion.Location = new Point(98, 71);
            TXT_Descripcion.Name = "TXT_Descripcion";
            TXT_Descripcion.Size = new Size(265, 23);
            TXT_Descripcion.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(145, 20);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 30;
            label6.Text = "Editar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 147);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 26;
            label2.Text = "Activo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 74);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 25;
            label1.Text = "Descripcion:";
            // 
            // CHK_Activo
            // 
            CHK_Activo.AutoSize = true;
            CHK_Activo.Location = new Point(99, 148);
            CHK_Activo.Name = "CHK_Activo";
            CHK_Activo.Size = new Size(15, 14);
            CHK_Activo.TabIndex = 2;
            CHK_Activo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 31;
            label3.Text = "Precio:";
            // 
            // TXT_Precio
            // 
            TXT_Precio.Location = new Point(98, 110);
            TXT_Precio.Name = "TXT_Precio";
            TXT_Precio.Size = new Size(100, 23);
            TXT_Precio.TabIndex = 32;
            TXT_Precio.KeyPress += TXT_Precio_KeyPress;
            // 
            // F_EditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 245);
            Controls.Add(TXT_Precio);
            Controls.Add(label3);
            Controls.Add(CHK_Activo);
            Controls.Add(BT_Editar);
            Controls.Add(TXT_Descripcion);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_EditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Editar;
        private TextBox TXT_Descripcion;
        private Label label6;
        private Label label2;
        private Label label1;
        private CheckBox CHK_Activo;
        private Label label3;
        private TextBox TXT_Precio;
    }
}