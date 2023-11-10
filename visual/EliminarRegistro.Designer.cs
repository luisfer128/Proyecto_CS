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
            cmbPerfil.Location = new Point(367, 159);
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
            // EliminarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label1;
        private ComboBox cmbPerfil;
        private Button btnEliminar;
        private Button btnRegresar;
    }
}