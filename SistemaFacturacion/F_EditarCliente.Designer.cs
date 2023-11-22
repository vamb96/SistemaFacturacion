namespace SistemaFacturacion
{
    partial class F_EditarCliente
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
            CB_Status = new ComboBox();
            BT_Editar = new Button();
            CB_CustomerType = new ComboBox();
            CKB_IsActivo = new CheckBox();
            TXT_Adress = new TextBox();
            TXT_CustName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CB_Status
            // 
            CB_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Status.FormattingEnabled = true;
            CB_Status.Items.AddRange(new object[] { "Inactivo", "Activo" });
            CB_Status.Location = new Point(103, 130);
            CB_Status.Name = "CB_Status";
            CB_Status.Size = new Size(121, 23);
            CB_Status.TabIndex = 24;
            // 
            // BT_Editar
            // 
            BT_Editar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Editar.Location = new Point(152, 252);
            BT_Editar.Name = "BT_Editar";
            BT_Editar.Size = new Size(118, 39);
            BT_Editar.TabIndex = 23;
            BT_Editar.Text = "Editar";
            BT_Editar.UseVisualStyleBackColor = true;
            BT_Editar.Click += BT_Editar_Click;
            // 
            // CB_CustomerType
            // 
            CB_CustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_CustomerType.FormattingEnabled = true;
            CB_CustomerType.Items.AddRange(new object[] { "Credito", "Contado" });
            CB_CustomerType.Location = new Point(103, 207);
            CB_CustomerType.Name = "CB_CustomerType";
            CB_CustomerType.Size = new Size(121, 23);
            CB_CustomerType.TabIndex = 22;
            // 
            // CKB_IsActivo
            // 
            CKB_IsActivo.AutoSize = true;
            CKB_IsActivo.Location = new Point(103, 173);
            CKB_IsActivo.Name = "CKB_IsActivo";
            CKB_IsActivo.Size = new Size(15, 14);
            CKB_IsActivo.TabIndex = 21;
            CKB_IsActivo.UseVisualStyleBackColor = true;
            // 
            // TXT_Adress
            // 
            TXT_Adress.Location = new Point(103, 94);
            TXT_Adress.Name = "TXT_Adress";
            TXT_Adress.Size = new Size(265, 23);
            TXT_Adress.TabIndex = 20;
            // 
            // TXT_CustName
            // 
            TXT_CustName.Location = new Point(103, 60);
            TXT_CustName.Name = "TXT_CustName";
            TXT_CustName.Size = new Size(265, 23);
            TXT_CustName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(168, 9);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 18;
            label6.Text = "Editar Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 210);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 17;
            label5.Text = "Tipo de cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 172);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 16;
            label4.Text = "Activo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 133);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 15;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 14;
            label2.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // F_EditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 303);
            Controls.Add(CB_Status);
            Controls.Add(BT_Editar);
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
            Name = "F_EditarCliente";
            Text = "Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Status;
        private Button BT_Editar;
        private ComboBox CB_CustomerType;
        private CheckBox CKB_IsActivo;
        private TextBox TXT_Adress;
        private TextBox TXT_CustName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}