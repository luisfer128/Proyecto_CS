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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoRegistro));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(407, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(347, 132);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(347, 173);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(407, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 3;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(359, 213);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(355, 257);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(407, 249);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(595, 133);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(656, 124);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 11;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(603, 173);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(656, 165);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(121, 23);
            txtCedula.TabIndex = 13;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkSeaGreen;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Location = new Point(487, 351);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(603, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(437, 54);
            label9.Name = "label9";
            label9.Size = new Size(296, 37);
            label9.TabIndex = 19;
            label9.Text = "Registro del personal";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Supervisor", "Trabajador", "Estudiante" });
            cmbRol.Location = new Point(407, 209);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(133, 23);
            cmbRol.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(600, 216);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 21;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(656, 208);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 22;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(656, 249);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(580, 257);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 24;
            label10.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login_usuario_3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 320);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // NuevoRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoRegistro";
            Text = "NuevoRegistro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}