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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarRegistro));
            label9 = new Label();
            btnActualizar = new Button();
            btnCancelar = new Button();
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(375, 42);
            label9.Name = "label9";
            label9.Size = new Size(316, 37);
            label9.TabIndex = 35;
            label9.Text = "Actualizacion de datos";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Location = new Point(416, 314);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(537, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(393, 104);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 52;
            label4.Text = "Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Supervisor", "Trabajador", "Estudiante" });
            cmbRol.Location = new Point(346, 236);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(133, 23);
            cmbRol.TabIndex = 51;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(595, 151);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(133, 23);
            txtNumero.TabIndex = 46;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(534, 160);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 45;
            label6.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(595, 192);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 23);
            txtCorreo.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(543, 200);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 43;
            label5.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(298, 240);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 42;
            label3.Text = "Cargo:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(346, 192);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 41;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 200);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 40;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 159);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 39;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.Location = new Point(346, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 38;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(449, 96);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(140, 23);
            cmbUsuario.TabIndex = 56;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(544, 244);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 57;
            label7.Text = "Estado:";
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Location = new Point(595, 240);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(60, 19);
            chbEstado.TabIndex = 58;
            chbEstado.Text = "Activo";
            chbEstado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ACTUALIZACION_DATOS;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 233);
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // ActualizarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(chbEstado);
            Controls.Add(label7);
            Controls.Add(cmbUsuario);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ActualizarRegistro";
            Text = "ActualizarRegistro";
            Load += ActualizarRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnActualizar;
        private Button btnCancelar;
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
        private PictureBox pictureBox1;
    }
}