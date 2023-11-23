namespace SistemaFacturacion
{
    partial class F_EditarTipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EditarTipoCliente));
            TXT_Description = new TextBox();
            BT_Editar = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // TXT_Description
            // 
            TXT_Description.Location = new Point(87, 57);
            TXT_Description.Name = "TXT_Description";
            TXT_Description.Size = new Size(280, 23);
            TXT_Description.TabIndex = 11;
            // 
            // BT_Editar
            // 
            BT_Editar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Editar.Image = (Image)resources.GetObject("BT_Editar.Image");
            BT_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Editar.Location = new Point(152, 97);
            BT_Editar.Name = "BT_Editar";
            BT_Editar.Size = new Size(134, 38);
            BT_Editar.TabIndex = 13;
            BT_Editar.Text = "Editar";
            BT_Editar.UseVisualStyleBackColor = false;
            BT_Editar.Click += BT_Editar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 12;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 10;
            label1.Text = "Editar Tipo de cliente";
            // 
            // F_EditarTipoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 142);
            Controls.Add(TXT_Description);
            Controls.Add(BT_Editar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_EditarTipoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Tipo de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_Description;
        private Button BT_Editar;
        private Label label2;
        private Label label1;
    }
}