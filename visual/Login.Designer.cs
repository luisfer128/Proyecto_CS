namespace visual
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iniciarSesion_lb = new Label();
            llRecuperar = new LinkLabel();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // iniciarSesion_lb
            // 
            iniciarSesion_lb.AutoSize = true;
            iniciarSesion_lb.Location = new Point(249, 32);
            iniciarSesion_lb.Name = "iniciarSesion_lb";
            iniciarSesion_lb.Size = new Size(76, 15);
            iniciarSesion_lb.TabIndex = 0;
            iniciarSesion_lb.Text = "Iniciar Sesion";
            // 
            // llRecuperar
            // 
            llRecuperar.AutoSize = true;
            llRecuperar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            llRecuperar.Location = new Point(218, 263);
            llRecuperar.Name = "llRecuperar";
            llRecuperar.Size = new Size(152, 20);
            llRecuperar.TabIndex = 14;
            llRecuperar.TabStop = true;
            llRecuperar.Text = "Recuperar contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveBorder;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(249, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 29);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(189, 217);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(224, 27);
            txtPass.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(189, 175);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 27);
            txtUser.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 219);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 182);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 385);
            Controls.Add(llRecuperar);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iniciarSesion_lb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iniciarSesion_lb;
        private LinkLabel llRecuperar;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label3;
        private Label label2;
    }
}