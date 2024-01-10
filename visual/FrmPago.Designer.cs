namespace visual
{
    partial class FrmPago
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
            label1 = new Label();
            label2 = new Label();
            TxtCalle = new TextBox();
            TxtEstado = new TextBox();
            TxtCiudad = new TextBox();
            CmbPais = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtNombreTarjeta = new TextBox();
            TxtNumeroTarjeta = new TextBox();
            TxtCVV = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            BtnPagar = new Button();
            TxtCP = new TextBox();
            label12 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 30);
            label1.TabIndex = 0;
            label1.Text = "Dirección de facturación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(272, 30);
            label2.TabIndex = 1;
            label2.Text = "Tarjeta de crédito o débito";
            // 
            // TxtCalle
            // 
            TxtCalle.Location = new Point(150, 58);
            TxtCalle.Name = "TxtCalle";
            TxtCalle.Size = new Size(181, 23);
            TxtCalle.TabIndex = 2;
            // 
            // TxtEstado
            // 
            TxtEstado.Location = new Point(99, 96);
            TxtEstado.Name = "TxtEstado";
            TxtEstado.Size = new Size(131, 23);
            TxtEstado.TabIndex = 3;
            // 
            // TxtCiudad
            // 
            TxtCiudad.Location = new Point(424, 58);
            TxtCiudad.Name = "TxtCiudad";
            TxtCiudad.Size = new Size(155, 23);
            TxtCiudad.TabIndex = 4;
            // 
            // CmbPais
            // 
            CmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPais.FormattingEnabled = true;
            CmbPais.Items.AddRange(new object[] { "México", "Guatemala", "Belice", "El Salvador", "Honduras", "Nicaragua", "Costa Rica", "Panamá", "Colombia", "Venezuela", "Ecuador", "Perú", "Bolivia", "Chile", "Argentina", "Paraguay", "Uruguay", "Brasil", "Guyana", "Surinam" });
            CmbPais.Location = new Point(302, 96);
            CmbPais.Name = "CmbPais";
            CmbPais.Size = new Size(168, 23);
            CmbPais.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(256, 96);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 9;
            label6.Text = "Pais:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 58);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 10;
            label3.Text = "Calle principal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 96);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(356, 58);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 12;
            label5.Text = "Ciudad:";
            // 
            // TxtNombreTarjeta
            // 
            TxtNombreTarjeta.Location = new Point(33, 213);
            TxtNombreTarjeta.Name = "TxtNombreTarjeta";
            TxtNombreTarjeta.Size = new Size(291, 23);
            TxtNombreTarjeta.TabIndex = 13;
            TxtNombreTarjeta.KeyPress += TxtNombreTarjeta_KeyPress;
            // 
            // TxtNumeroTarjeta
            // 
            TxtNumeroTarjeta.Location = new Point(33, 263);
            TxtNumeroTarjeta.Name = "TxtNumeroTarjeta";
            TxtNumeroTarjeta.Size = new Size(291, 23);
            TxtNumeroTarjeta.TabIndex = 14;
            TxtNumeroTarjeta.KeyPress += TxtNumeroTarjeta_KeyPress;
            // 
            // TxtCVV
            // 
            TxtCVV.Location = new Point(33, 376);
            TxtCVV.Name = "TxtCVV";
            TxtCVV.Size = new Size(111, 23);
            TxtCVV.TabIndex = 15;
            TxtCVV.KeyPress += TxtCVV_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 189);
            label7.Name = "label7";
            label7.Size = new Size(157, 21);
            label7.TabIndex = 18;
            label7.Text = "Nombre en la Tarjeta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 239);
            label8.Name = "label8";
            label8.Size = new Size(140, 21);
            label8.TabIndex = 19;
            label8.Text = "Número de tarjeta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 294);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 20;
            label9.Text = "Exp. Mes:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(138, 294);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 21;
            label10.Text = "Exp. Año:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(33, 352);
            label11.Name = "label11";
            label11.Size = new Size(43, 21);
            label11.TabIndex = 22;
            label11.Text = "CVV:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Accepted_Cards_US;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(290, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 27);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // BtnPagar
            // 
            BtnPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPagar.Location = new Point(698, 406);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(79, 32);
            BtnPagar.TabIndex = 24;
            BtnPagar.Text = "Pagar";
            BtnPagar.UseVisualStyleBackColor = true;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // TxtCP
            // 
            TxtCP.Location = new Point(605, 98);
            TxtCP.Name = "TxtCP";
            TxtCP.Size = new Size(100, 23);
            TxtCP.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(491, 96);
            label12.Name = "label12";
            label12.Size = new Size(108, 21);
            label12.TabIndex = 26;
            label12.Text = "Código Postal:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            comboBox1.Location = new Point(33, 318);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(76, 23);
            comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37" });
            comboBox2.Location = new Point(138, 318);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(79, 23);
            comboBox2.TabIndex = 28;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(TxtCP);
            Controls.Add(BtnPagar);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TxtCVV);
            Controls.Add(TxtNumeroTarjeta);
            Controls.Add(TxtNombreTarjeta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(CmbPais);
            Controls.Add(TxtCiudad);
            Controls.Add(TxtEstado);
            Controls.Add(TxtCalle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPago";
            Text = "FrmPago";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtCalle;
        private TextBox TxtEstado;
        private TextBox TxtCiudad;
        private ComboBox CmbPais;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtNombreTarjeta;
        private TextBox TxtNumeroTarjeta;
        private TextBox TxtCVV;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Button BtnPagar;
        private TextBox TxtCP;
        private Label label12;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}