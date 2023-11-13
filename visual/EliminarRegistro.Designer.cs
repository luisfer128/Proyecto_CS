namespace visual
{
    partial class EliminarRegistro
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
            label1 = new Label();
            cmbPerfil = new ComboBox();
            btnEliminar = new Button();
            btnRegresar = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(255, 57);
            label9.Name = "label9";
            label9.Size = new Size(259, 37);
            label9.TabIndex = 36;
            label9.Text = "Eliminacion de perfil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 167);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 37;
            label1.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(332, 164);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(121, 23);
            cmbPerfil.TabIndex = 38;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(292, 307);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(413, 307);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(292, 282);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Quiero eliminar el perfil";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.delete_user_profile_account_remove_icon_196557;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // EliminarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(cmbPerfil);
            Controls.Add(label1);
            Controls.Add(label9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EliminarRegistro";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EliminarRegistro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label1;
        private ComboBox cmbPerfil;
        private Button btnEliminar;
        private Button btnRegresar;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}