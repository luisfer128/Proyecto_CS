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
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtNumero = new TextBox();
            label7 = new Label();
            txtCedula = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            cmbRol = new ComboBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label10 = new Label();
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
            txtApellido.KeyPress += txtApellido_KeyPress;
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
            label6.Location = new Point(403, 140);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(464, 131);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 11;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 180);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(464, 172);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(121, 23);
            txtCedula.TabIndex = 13;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(295, 358);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(411, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Supervisor", "Trabajador", "Estudiante" });
            cmbRol.Location = new Point(215, 216);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(133, 23);
            cmbRol.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 223);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 21;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(464, 215);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 22;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(464, 256);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(388, 264);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 24;
            label10.Text = "Contraseña:";
            // 
            // NuevoRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(cmbRol);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCedula);
            Controls.Add(label7);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtNumero;
        private Label label7;
        private TextBox txtCedula;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label9;
        private ComboBox cmbRol;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label10;
    }
}