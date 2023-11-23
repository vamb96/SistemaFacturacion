namespace SistemaFacturacion
{
    partial class F_AgregarTipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AgregarTipoCliente));
            TXT_Description = new TextBox();
            BT_Agregar = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // TXT_Description
            // 
            TXT_Description.Location = new Point(87, 62);
            TXT_Description.Name = "TXT_Description";
            TXT_Description.Size = new Size(280, 23);
            TXT_Description.TabIndex = 5;
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Image = (Image)resources.GetObject("BT_Agregar.Image");
            BT_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Agregar.Location = new Point(152, 102);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(134, 38);
            BT_Agregar.TabIndex = 9;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = false;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 14);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 4;
            label1.Text = "Agregar Tipo de cliente";
            // 
            // F_AgregarTipoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 156);
            Controls.Add(TXT_Description);
            Controls.Add(BT_Agregar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_AgregarTipoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Tipo de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_Description;
        private Button BT_Agregar;
        private Label label2;
        private Label label1;
    }
}