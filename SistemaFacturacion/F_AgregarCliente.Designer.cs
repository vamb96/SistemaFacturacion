namespace SistemaFacturacion
{
    partial class F_AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AgregarCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TXT_CustName = new TextBox();
            TXT_Adress = new TextBox();
            CKB_IsActivo = new CheckBox();
            CB_CustomerType = new ComboBox();
            BT_Agregar = new Button();
            CB_Status = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 74);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 144);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 181);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Activo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 218);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo de cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(168, 22);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 5;
            label6.Text = "Agregar Cliente";
            // 
            // TXT_CustName
            // 
            TXT_CustName.Location = new Point(111, 71);
            TXT_CustName.Name = "TXT_CustName";
            TXT_CustName.Size = new Size(265, 23);
            TXT_CustName.TabIndex = 1;
            // 
            // TXT_Adress
            // 
            TXT_Adress.Location = new Point(111, 105);
            TXT_Adress.Name = "TXT_Adress";
            TXT_Adress.Size = new Size(265, 23);
            TXT_Adress.TabIndex = 2;
            // 
            // CKB_IsActivo
            // 
            CKB_IsActivo.AutoSize = true;
            CKB_IsActivo.Location = new Point(111, 182);
            CKB_IsActivo.Name = "CKB_IsActivo";
            CKB_IsActivo.Size = new Size(15, 14);
            CKB_IsActivo.TabIndex = 4;
            CKB_IsActivo.UseVisualStyleBackColor = true;
            // 
            // CB_CustomerType
            // 
            CB_CustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_CustomerType.FormattingEnabled = true;
            CB_CustomerType.Items.AddRange(new object[] { "Credito", "Contado" });
            CB_CustomerType.Location = new Point(111, 215);
            CB_CustomerType.Name = "CB_CustomerType";
            CB_CustomerType.Size = new Size(121, 23);
            CB_CustomerType.TabIndex = 5;
            // 
            // BT_Agregar
            // 
            BT_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Agregar.Image = (Image)resources.GetObject("BT_Agregar.Image");
            BT_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            BT_Agregar.Location = new Point(154, 261);
            BT_Agregar.Name = "BT_Agregar";
            BT_Agregar.Size = new Size(127, 39);
            BT_Agregar.TabIndex = 6;
            BT_Agregar.Text = "Agregar";
            BT_Agregar.UseVisualStyleBackColor = true;
            BT_Agregar.Click += BT_Agregar_Click;
            // 
            // CB_Status
            // 
            CB_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Status.FormattingEnabled = true;
            CB_Status.Items.AddRange(new object[] { "Inactivo", "Activo" });
            CB_Status.Location = new Point(111, 141);
            CB_Status.Name = "CB_Status";
            CB_Status.Size = new Size(121, 23);
            CB_Status.TabIndex = 3;
            // 
            // F_AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 308);
            Controls.Add(CB_Status);
            Controls.Add(BT_Agregar);
            Controls.Add(CB_CustomerType);
            Controls.Add(CKB_IsActivo);
            Controls.Add(TXT_Adress);
            Controls.Add(TXT_CustName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "F_AgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TXT_CustName;
        private TextBox TXT_Adress;
        private CheckBox CKB_IsActivo;
        private ComboBox CB_CustomerType;
        private Button BT_Agregar;
        private ComboBox CB_Status;
    }
}