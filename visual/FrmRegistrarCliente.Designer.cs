namespace visual
{
    partial class FrmRegistrarCliente
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
            pictureBox1 = new PictureBox();
            label10 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            label9 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtCedula = new TextBox();
            label7 = new Label();
            txtNumero = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login_usuario_3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(18, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 320);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(586, 221);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 44;
            label10.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(662, 213);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 43;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(413, 254);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(357, 262);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 41;
            label4.Text = "Usuario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(443, 59);
            label9.Name = "label9";
            label9.Size = new Size(296, 37);
            label9.TabIndex = 39;
            label9.Text = "Registro del personal";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(609, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkSeaGreen;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Location = new Point(493, 356);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 37;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(662, 170);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(121, 23);
            txtCedula.TabIndex = 36;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(609, 178);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 35;
            label7.Text = "Cedula:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(662, 129);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 34;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(601, 138);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 33;
            label6.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(413, 213);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 23);
            txtCorreo.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(361, 221);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 31;
            label5.Text = "Correo:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(413, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 29;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(353, 178);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 28;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 137);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(413, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 26;
            txtNombre.KeyPress += txtNombre_KeyPress_1;
            // 
            // FrmRegistrarCliente
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
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCedula);
            Controls.Add(label7);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "FrmRegistrarCliente";
            Text = "FrmRegistrarCliente";
            FormClosed += FrmRegistrarCliente_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label10;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label4;
        private Label label9;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtCedula;
        private Label label7;
        private TextBox txtNumero;
        private Label label6;
        private TextBox txtCorreo;
        private Label label5;
        private TextBox txtApellido;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
    }
}