namespace visual
{
    partial class NuevoRegistro
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtCargo = new TextBox();
            label4 = new Label();
            txtDepartamento = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtNumero = new TextBox();
            label7 = new Label();
            txtCedula = new TextBox();
            label8 = new Label();
            cmbSexo = new ComboBox();
            btnRegistrar = new Button();
            btnRegresar = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(215, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 139);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 180);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(215, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 220);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(215, 212);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(133, 23);
            txtCargo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 139);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 6;
            label4.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(458, 131);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(121, 23);
            txtDepartamento.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 264);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(215, 256);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 180);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(458, 172);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 220);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(458, 212);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(121, 23);
            txtCedula.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 259);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 14;
            label8.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "Prefiero no decirlo" });
            cmbSexo.Location = new Point(458, 256);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(295, 352);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(411, 352);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(248, 50);
            label9.Name = "label9";
            label9.Size = new Size(267, 37);
            label9.TabIndex = 19;
            label9.Text = "Registro del personal";
            // 
            // NuevoRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(btnRegresar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbSexo);
            Controls.Add(label8);
            Controls.Add(txtCedula);
            Controls.Add(label7);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtDepartamento);
            Controls.Add(label4);
            Controls.Add(txtCargo);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "NuevoRegistro";
            Text = "NuevoRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtCargo;
        private Label label4;
        private TextBox txtDepartamento;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtNumero;
        private Label label7;
        private TextBox txtCedula;
        private Label label8;
        private ComboBox cmbSexo;
        private Button btnRegistrar;
        private Button btnRegresar;
        private Label label9;
    }
}