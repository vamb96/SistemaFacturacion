namespace SistemaFacturacion
{
    partial class F_AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AgregarProducto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BT_Agregar = new Button();
            TXT_Description = new TextBox();
            CKB_IsActivo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 96);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Activo";
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Image = (Image)resources.GetObject("BT_Agregar.Image");
            BT_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Agregar.Location = new Point(151, 127);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(134, 38);
            BT_Agregar.TabIndex = 3;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = false;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // TXT_Description
            // 
            TXT_Description.Location = new Point(106, 57);
            TXT_Description.Name = "TXT_Description";
            TXT_Description.Size = new Size(280, 23);
            TXT_Description.TabIndex = 1;
            // 
            // CKB_IsActivo
            // 
            CKB_IsActivo.AutoSize = true;
            CKB_IsActivo.Location = new Point(106, 96);
            CKB_IsActivo.Name = "CKB_IsActivo";
            CKB_IsActivo.Size = new Size(15, 14);
            CKB_IsActivo.TabIndex = 2;
            CKB_IsActivo.UseVisualStyleBackColor = true;
            // 
            // F_AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 179);
            Controls.Add(CKB_IsActivo);
            Controls.Add(TXT_Description);
            Controls.Add(BT_Agregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BT_Agregar;
        private TextBox TXT_Description;
        private CheckBox CKB_IsActivo;
    }
}