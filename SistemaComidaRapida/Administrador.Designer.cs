﻿namespace SistemaComidaRapida
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.labelTipodeCuenta = new System.Windows.Forms.Label();
            this.btnCerrarT = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPantallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCajeroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCocineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(67)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1005, 60);
            this.panelTop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Service System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.btnMinimizar);
            this.panelTopRight.Controls.Add(this.labelTipodeCuenta);
            this.panelTopRight.Controls.Add(this.btnCerrarT);
            this.panelTopRight.Controls.Add(this.btnCerrarSesion);
            this.panelTopRight.Controls.Add(this.labelUsuario);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(677, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(328, 60);
            this.panelTopRight.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(268, -2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 33);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // labelTipodeCuenta
            // 
            this.labelTipodeCuenta.AutoSize = true;
            this.labelTipodeCuenta.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTipodeCuenta.ForeColor = System.Drawing.Color.White;
            this.labelTipodeCuenta.Location = new System.Drawing.Point(99, 27);
            this.labelTipodeCuenta.Name = "labelTipodeCuenta";
            this.labelTipodeCuenta.Size = new System.Drawing.Size(107, 20);
            this.labelTipodeCuenta.TabIndex = 0;
            this.labelTipodeCuenta.Text = "Administrador";
            this.labelTipodeCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarT
            // 
            this.btnCerrarT.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarT.BackgroundImage")));
            this.btnCerrarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarT.FlatAppearance.BorderSize = 0;
            this.btnCerrarT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarT.Location = new System.Drawing.Point(303, -2);
            this.btnCerrarT.Name = "btnCerrarT";
            this.btnCerrarT.Size = new System.Drawing.Size(25, 33);
            this.btnCerrarT.TabIndex = 12;
            this.btnCerrarT.UseVisualStyleBackColor = false;
            this.btnCerrarT.Click += new System.EventHandler(this.btnCerrarT_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(212, 6);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 37);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(57, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(149, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario: EstelaUS02";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.BackColor = System.Drawing.Color.White;
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.verPantallasToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 60);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(1005, 28);
            this.menuStripAdmin.TabIndex = 6;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEmpleadosToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.historialDePedidosToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.verToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.verToolStripMenuItem.Text = "Reportes";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Reporte de empleados";
            this.listaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.menuToolStripMenuItem.Text = "Reporte de Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // historialDePedidosToolStripMenuItem
            // 
            this.historialDePedidosToolStripMenuItem.Name = "historialDePedidosToolStripMenuItem";
            this.historialDePedidosToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.historialDePedidosToolStripMenuItem.Text = "Historial de Pedidos";
            this.historialDePedidosToolStripMenuItem.Click += new System.EventHandler(this.historialDePedidosToolStripMenuItem_Click);
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.menuToolStripMenuItem1,
            this.historialToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click_1);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // verPantallasToolStripMenuItem
            // 
            this.verPantallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaCajeroToolStripMenuItem1,
            this.pantallaCocineroToolStripMenuItem});
            this.verPantallasToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.verPantallasToolStripMenuItem.Name = "verPantallasToolStripMenuItem";
            this.verPantallasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.verPantallasToolStripMenuItem.Text = "Ver Pantallas";
            // 
            // pantallaCajeroToolStripMenuItem1
            // 
            this.pantallaCajeroToolStripMenuItem1.Name = "pantallaCajeroToolStripMenuItem1";
            this.pantallaCajeroToolStripMenuItem1.Size = new System.Drawing.Size(199, 24);
            this.pantallaCajeroToolStripMenuItem1.Text = "Pantalla Cajero";
            this.pantallaCajeroToolStripMenuItem1.Click += new System.EventHandler(this.pantallaCajeroToolStripMenuItem1_Click);
            // 
            // pantallaCocineroToolStripMenuItem
            // 
            this.pantallaCocineroToolStripMenuItem.Name = "pantallaCocineroToolStripMenuItem";
            this.pantallaCocineroToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.pantallaCocineroToolStripMenuItem.Text = "Pantalla Cocinero";
            this.pantallaCocineroToolStripMenuItem.Click += new System.EventHandler(this.pantallaCocineroToolStripMenuItem_Click);
            // 
            // pantallaCajeroToolStripMenuItem
            // 
            this.pantallaCajeroToolStripMenuItem.Name = "pantallaCajeroToolStripMenuItem";
            this.pantallaCajeroToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // cocineroToolStripMenuItem
            // 
            this.cocineroToolStripMenuItem.Name = "cocineroToolStripMenuItem";
            this.cocineroToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1005, 546);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmAdministrador";
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTipodeCuenta;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarT;
        private System.Windows.Forms.ToolStripMenuItem verPantallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaCajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cocineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaCajeroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pantallaCocineroToolStripMenuItem;
    }
}