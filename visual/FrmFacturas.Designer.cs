﻿namespace visual
{
    partial class FrmFacturas
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
            dgvver = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvver).BeginInit();
            SuspendLayout();
            // 
            // dgvver
            // 
            dgvver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvver.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvver.Location = new Point(12, 65);
            dgvver.Name = "dgvver";
            dgvver.RowTemplate.Height = 25;
            dgvver.Size = new Size(776, 284);
            dgvver.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 1;
            label1.Text = "Facturas";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(672, 374);
            button1.Name = "button1";
            button1.Size = new Size(116, 34);
            button1.TabIndex = 2;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 438);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvver);
            Name = "FrmFacturas";
            Text = "Facturas";
            Load += FrmFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvver;
        private Label label1;
        private Button button1;
    }
}