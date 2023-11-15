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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarRegistro));
            label9 = new Label();
            label1 = new Label();
            cmbPerfil = new ComboBox();
            btnEliminar = new Button();
            btnRegresar = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(130, 82);
            label9.Name = "label9";
            label9.Size = new Size(288, 37);
            label9.TabIndex = 36;
            label9.Text = "Eliminación de perfil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 192);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 37;
            label1.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(188, 189);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(121, 23);
            cmbPerfil.TabIndex = 38;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkSeaGreen;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(130, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DarkSeaGreen;
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.Location = new Point(251, 336);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(159, 302);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 19);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Quiero eliminar el perfil";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.delete_user_profile_account_remove_icon_196557;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(59, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pngtree_remove_current_user_delete_profile_png_image_5551703;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(483, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 267);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // EliminarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(cmbPerfil);
            Controls.Add(label1);
            Controls.Add(label9);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EliminarRegistro";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EliminarRegistro";
            Load += EliminarRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}