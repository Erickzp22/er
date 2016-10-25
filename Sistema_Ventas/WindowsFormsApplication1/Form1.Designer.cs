namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Cierre = new System.Windows.Forms.Button();
            this.btn_Administrador = new System.Windows.Forms.Button();
            this.btn_Vendedor = new System.Windows.Forms.Button();
            this.btn_Retiro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_Abrir);
            this.groupBox1.Controls.Add(this.btn_Cierre);
            this.groupBox1.Controls.Add(this.btn_Administrador);
            this.groupBox1.Controls.Add(this.btn_Vendedor);
            this.groupBox1.Controls.Add(this.btn_Retiro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(311, 587);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Image = global::WindowsFormsApplication1.Properties.Resources.cierre2;
            this.btn_Abrir.Location = new System.Drawing.Point(16, 441);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(128, 128);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir Caja";
            this.btn_Abrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.MouseLeave += new System.EventHandler(this.btn_Abrir_MouseLeave);
            this.btn_Abrir.MouseHover += new System.EventHandler(this.btn_Abrir_MouseHover);
            // 
            // btn_Cierre
            // 
            this.btn_Cierre.Image = global::WindowsFormsApplication1.Properties.Resources.Inicio1;
            this.btn_Cierre.Location = new System.Drawing.Point(164, 334);
            this.btn_Cierre.Name = "btn_Cierre";
            this.btn_Cierre.Size = new System.Drawing.Size(128, 128);
            this.btn_Cierre.TabIndex = 3;
            this.btn_Cierre.Text = "Cierre de caja";
            this.btn_Cierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cierre.UseVisualStyleBackColor = true;
            this.btn_Cierre.MouseLeave += new System.EventHandler(this.btn_Cierre_MouseLeave);
            this.btn_Cierre.MouseHover += new System.EventHandler(this.btn_Cierre_MouseHover);
            // 
            // btn_Administrador
            // 
            this.btn_Administrador.Image = global::WindowsFormsApplication1.Properties.Resources.Administrador1;
            this.btn_Administrador.Location = new System.Drawing.Point(16, 236);
            this.btn_Administrador.Name = "btn_Administrador";
            this.btn_Administrador.Size = new System.Drawing.Size(128, 128);
            this.btn_Administrador.TabIndex = 2;
            this.btn_Administrador.Text = "Administrador";
            this.btn_Administrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Administrador.UseVisualStyleBackColor = true;
            this.btn_Administrador.MouseLeave += new System.EventHandler(this.btn_Administrador_MouseLeave);
            this.btn_Administrador.MouseHover += new System.EventHandler(this.btn_Administrador_MouseHover);
            // 
            // btn_Vendedor
            // 
            this.btn_Vendedor.Image = global::WindowsFormsApplication1.Properties.Resources.vendedor1;
            this.btn_Vendedor.Location = new System.Drawing.Point(164, 128);
            this.btn_Vendedor.Name = "btn_Vendedor";
            this.btn_Vendedor.Size = new System.Drawing.Size(128, 128);
            this.btn_Vendedor.TabIndex = 1;
            this.btn_Vendedor.Text = "Vendedor";
            this.btn_Vendedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Vendedor.UseVisualStyleBackColor = true;
            this.btn_Vendedor.MouseLeave += new System.EventHandler(this.btn_Vendedor_MouseLeave);
            this.btn_Vendedor.MouseHover += new System.EventHandler(this.btn_Vendedor_MouseHover);
            // 
            // btn_Retiro
            // 
            this.btn_Retiro.Image = global::WindowsFormsApplication1.Properties.Resources.Retirar1;
            this.btn_Retiro.Location = new System.Drawing.Point(16, 20);
            this.btn_Retiro.Name = "btn_Retiro";
            this.btn_Retiro.Size = new System.Drawing.Size(128, 128);
            this.btn_Retiro.TabIndex = 0;
            this.btn_Retiro.Text = "Retiro de efectivo";
            this.btn_Retiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Retiro.UseVisualStyleBackColor = true;
            this.btn_Retiro.MouseLeave += new System.EventHandler(this.btn_Retiro_MouseLeave);
            this.btn_Retiro.MouseHover += new System.EventHandler(this.btn_Retiro_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.LogoFF;
            this.pictureBox1.Location = new System.Drawing.Point(427, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 658);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Retiro;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Cierre;
        private System.Windows.Forms.Button btn_Administrador;
        private System.Windows.Forms.Button btn_Vendedor;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;

    }
}

