namespace visual
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            cursoEnsamblaje = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            cursoProgramacion = new GroupBox();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            cursoBD = new GroupBox();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            cursoEnsamblaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cursoProgramacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cursoBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cursoEnsamblaje
            // 
            cursoEnsamblaje.Controls.Add(label1);
            cursoEnsamblaje.Controls.Add(button1);
            cursoEnsamblaje.Controls.Add(richTextBox1);
            cursoEnsamblaje.Controls.Add(pictureBox1);
            cursoEnsamblaje.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cursoEnsamblaje.ForeColor = SystemColors.ActiveCaptionText;
            cursoEnsamblaje.Location = new Point(12, 12);
            cursoEnsamblaje.Name = "cursoEnsamblaje";
            cursoEnsamblaje.Size = new Size(776, 125);
            cursoEnsamblaje.TabIndex = 0;
            cursoEnsamblaje.TabStop = false;
            cursoEnsamblaje.Text = "Curso de ensamblaje de PC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(599, 90);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "199.99 $";
            // 
            // button1
            // 
            button1.Location = new Point(695, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Wheat;
            richTextBox1.Location = new Point(152, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(441, 83);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._2_3_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cursoProgramacion
            // 
            cursoProgramacion.Controls.Add(label2);
            cursoProgramacion.Controls.Add(richTextBox2);
            cursoProgramacion.Controls.Add(button2);
            cursoProgramacion.Controls.Add(pictureBox2);
            cursoProgramacion.Location = new Point(12, 143);
            cursoProgramacion.Name = "cursoProgramacion";
            cursoProgramacion.Size = new Size(776, 125);
            cursoProgramacion.TabIndex = 1;
            cursoProgramacion.TabStop = false;
            cursoProgramacion.Text = "Curso de Programación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(599, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "249.99 $";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Wheat;
            richTextBox2.Location = new Point(152, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(441, 70);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "En éste curso vamos a aprender JavaScript desde cero, uno de los lenguajes más versátiles. Lo único que necesitas para aprender a programar son ganas (y un ordenador), ¡así que vamos a ello!";
            // 
            // button2
            // 
            button2.Location = new Point(695, 96);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._5100872_cdc1_2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(6, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 97);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // cursoBD
            // 
            cursoBD.Controls.Add(label3);
            cursoBD.Controls.Add(richTextBox3);
            cursoBD.Controls.Add(button3);
            cursoBD.Controls.Add(pictureBox3);
            cursoBD.Location = new Point(12, 274);
            cursoBD.Name = "cursoBD";
            cursoBD.Size = new Size(776, 125);
            cursoBD.TabIndex = 2;
            cursoBD.TabStop = false;
            cursoBD.Text = "Curso de Base de Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(599, 84);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "149.99 $";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Wheat;
            richTextBox3.Location = new Point(152, 22);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(441, 96);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // button3
            // 
            button3.Location = new Point(695, 95);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.e02f6289_883c_454c_8f35_f6a0cee78066;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(6, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 97);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(cursoBD);
            Controls.Add(cursoProgramacion);
            Controls.Add(cursoEnsamblaje);
            Name = "FrmServicios";
            Text = "Servicios";
            cursoEnsamblaje.ResumeLayout(false);
            cursoEnsamblaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cursoProgramacion.ResumeLayout(false);
            cursoProgramacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cursoBD.ResumeLayout(false);
            cursoBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox cursoEnsamblaje;
        private PictureBox pictureBox1;
        private GroupBox cursoProgramacion;
        private PictureBox pictureBox2;
        private GroupBox cursoBD;
        private PictureBox pictureBox3;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private RichTextBox richTextBox3;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}