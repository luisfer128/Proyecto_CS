namespace visual
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            nuevoRegistroToolStripMenuItem = new ToolStripMenuItem();
            actualizarRegistroToolStripMenuItem = new ToolStripMenuItem();
            eliminarRegistroToolStripMenuItem = new ToolStripMenuItem();
            servicios = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            carritoToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.AntiqueWhite;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, personalToolStripMenuItem, servicios, facturaciónToolStripMenuItem, cerrarSesiónToolStripMenuItem, carritoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(48, 20);
            toolStripMenuItem1.Text = "Inicio";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoRegistroToolStripMenuItem, actualizarRegistroToolStripMenuItem, eliminarRegistroToolStripMenuItem });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(64, 20);
            personalToolStripMenuItem.Text = "Personal";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            nuevoRegistroToolStripMenuItem.Size = new Size(172, 22);
            nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            nuevoRegistroToolStripMenuItem.Click += nuevoRegistroToolStripMenuItem_Click;
            // 
            // actualizarRegistroToolStripMenuItem
            // 
            actualizarRegistroToolStripMenuItem.Name = "actualizarRegistroToolStripMenuItem";
            actualizarRegistroToolStripMenuItem.Size = new Size(172, 22);
            actualizarRegistroToolStripMenuItem.Text = "Actualizar Registro";
            actualizarRegistroToolStripMenuItem.Click += actualizarRegistroToolStripMenuItem_Click;
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            eliminarRegistroToolStripMenuItem.Size = new Size(172, 22);
            eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            eliminarRegistroToolStripMenuItem.Click += eliminarRegistroToolStripMenuItem_Click;
            // 
            // servicios
            // 
            servicios.Name = "servicios";
            servicios.Size = new Size(65, 20);
            servicios.Text = "Servicios";
            servicios.Click += servicios_Click;
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(63, 20);
            facturaciónToolStripMenuItem.Text = "Facturas";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.RightToLeft = RightToLeft.No;
            cerrarSesiónToolStripMenuItem.Size = new Size(88, 20);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // carritoToolStripMenuItem
            // 
            carritoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            carritoToolStripMenuItem.Image = Properties.Resources.carrito;
            carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            carritoToolStripMenuItem.Size = new Size(28, 20);
            carritoToolStripMenuItem.Click += carritoToolStripMenuItem_Click;
            // 
            // panel
            // 
            panel.BackgroundImage = Properties.Resources._7b71d9b8_42ad_4d49_bc6b_d2d149fcafb3_removebg_preview;
            panel.BackgroundImageLayout = ImageLayout.Center;
            panel.Location = new Point(0, 27);
            panel.Name = "panel";
            panel.Size = new Size(800, 424);
            panel.TabIndex = 21;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private ToolStripMenuItem actualizarRegistroToolStripMenuItem;
        private ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private ToolStripMenuItem servicios;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private Panel panel;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem carritoToolStripMenuItem;
    }
}