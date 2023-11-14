namespace visual
{
    partial class ActualizarRegistro
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
            label9 = new Label();
            btnActualizar = new Button();
            btnCancelar = new Button();
            label10 = new Label();
            txtContraseña = new TextBox();
            label4 = new Label();
            cmbRol = new ComboBox();
            txtNumero = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            cmbUsuario = new ComboBox();
            label7 = new Label();
            chbEstado = new CheckBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(251, 9);
            label9.Name = "label9";
            label9.Size = new Size(284, 37);
            label9.TabIndex = 35;
            label9.Text = "Actualizacion de datos";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(290, 348);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(411, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(405, 214);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 55;
            label10.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(481, 206);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(133, 23);
            txtContraseña.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 71);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 52;
            label4.Text = "Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Supervisor", "Trabajador", "Estudiante" });
            cmbRol.Location = new Point(232, 211);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(133, 23);
            cmbRol.TabIndex = 51;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(481, 126);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(133, 23);
            txtNumero.TabIndex = 46;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 135);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 45;
            label6.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(481, 167);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 23);
            txtCorreo.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 175);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 43;
            label5.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 215);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 42;
            label3.Text = "Cargo:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(232, 167);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 41;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 175);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 40;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 134);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 39;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(232, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 38;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(346, 63);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(140, 23);
            cmbUsuario.TabIndex = 56;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 256);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 57;
            label7.Text = "Estado:";
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Location = new Point(232, 252);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(60, 19);
            chbEstado.TabIndex = 58;
            chbEstado.Text = "Activo";
            chbEstado.UseVisualStyleBackColor = true;
            // 
            // ActualizarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chbEstado);
            Controls.Add(label7);
            Controls.Add(cmbUsuario);
            Controls.Add(label10);
            Controls.Add(txtContraseña);
            Controls.Add(label4);
            Controls.Add(cmbRol);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label9);
            Name = "ActualizarRegistro";
            Text = "ActualizarRegistro";
            Load += ActualizarRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnActualizar;
        private Button btnCancelar;
        private Label label10;
        private TextBox txtContraseña;
        private Label label4;
        private ComboBox cmbRol;
        private TextBox txtNumero;
        private Label label6;
        private TextBox txtCorreo;
        private Label label5;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbUsuario;
        private Label label7;
        private CheckBox chbEstado;
    }
}