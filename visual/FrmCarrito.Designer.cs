namespace visual
{
    partial class FrmCarrito
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            BtnPagar = new Button();
            dataGridView1 = new DataGridView();
            BtnVaciarCarrito = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "CARRITO";
            // 
            // BtnPagar
            // 
            BtnPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPagar.Location = new Point(680, 384);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(107, 35);
            BtnPagar.TabIndex = 1;
            BtnPagar.Text = "Pagar";
            BtnPagar.UseVisualStyleBackColor = true;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(513, 245);
            dataGridView1.TabIndex = 2;
            // 
            // BtnVaciarCarrito
            // 
            BtnVaciarCarrito.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVaciarCarrito.Location = new Point(534, 384);
            BtnVaciarCarrito.Name = "BtnVaciarCarrito";
            BtnVaciarCarrito.Size = new Size(140, 35);
            BtnVaciarCarrito.TabIndex = 3;
            BtnVaciarCarrito.Text = "Vaciar carrito";
            BtnVaciarCarrito.UseVisualStyleBackColor = true;
            BtnVaciarCarrito.Click += BtnVaciarCarrito_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(611, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(179, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tarjeta de Crédito";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(611, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(173, 29);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Trajeta de Débito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(315, 389);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 389);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 7;
            label3.Text = "0.00$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(611, 46);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 8;
            label4.Text = "Metodo de Pago:";
            // 
            // FrmCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(799, 431);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(BtnVaciarCarrito);
            Controls.Add(dataGridView1);
            Controls.Add(BtnPagar);
            Controls.Add(label1);
            Name = "FrmCarrito";
            Text = "FrmCarrito";
            Load += FrmCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnPagar;
        private DataGridView dataGridView1;
        private Button BtnVaciarCarrito;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}