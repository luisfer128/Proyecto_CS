namespace visual
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            iniciarSesion_lb = new Label();
            llRecuperar = new LinkLabel();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iniciarSesion_lb
            // 
            iniciarSesion_lb.AutoSize = true;
            iniciarSesion_lb.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            iniciarSesion_lb.ForeColor = Color.LightSeaGreen;
            iniciarSesion_lb.Location = new Point(197, 27);
            iniciarSesion_lb.Name = "iniciarSesion_lb";
            iniciarSesion_lb.Size = new Size(192, 37);
            iniciarSesion_lb.TabIndex = 0;
            iniciarSesion_lb.Text = "Iniciar Sesión";
            // 
            // llRecuperar
            // 
            llRecuperar.AutoSize = true;
            llRecuperar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            llRecuperar.Location = new Point(299, 289);
            llRecuperar.Name = "llRecuperar";
            llRecuperar.Size = new Size(152, 20);
            llRecuperar.TabIndex = 14;
            llRecuperar.TabStop = true;
            llRecuperar.Text = "Recuperar contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(249, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 29);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(191, 246);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(224, 27);
            txtPass.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(191, 204);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 27);
            txtUser.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(87, 248);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(101, 211);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._7b71d9b8_42ad_4d49_bc6b_d2d149fcafb3_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(208, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 131);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(191, 289);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(579, 385);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(llRecuperar);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iniciarSesion_lb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}