﻿namespace SistemaComidaRapida
{
    partial class frmCajero
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajero));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.panelOrden = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSelecCliente = new System.Windows.Forms.Button();
            this.dgvDetalleOrden = new System.Windows.Forms.DataGridView();
            this.btnEnviarCocina = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mstCajero = new System.Windows.Forms.MenuStrip();
            this.verPantallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCocineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.btnCerrarFrm = new System.Windows.Forms.Button();
            this.labelTipodeCuenta = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCerrarT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.mstCajero.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelHora.ForeColor = System.Drawing.Color.Black;
            this.labelHora.Location = new System.Drawing.Point(34, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(51, 20);
            this.labelHora.TabIndex = 0;
            this.labelHora.Text = "18:54";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelFecha.ForeColor = System.Drawing.Color.Black;
            this.labelFecha.Location = new System.Drawing.Point(13, 18);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(93, 20);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "20/10/2019";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBottom.Controls.Add(this.panelTime);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 724);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1370, 40);
            this.panelBottom.TabIndex = 7;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Transparent;
            this.panelTime.Controls.Add(this.labelHora);
            this.panelTime.Controls.Add(this.labelFecha);
            this.panelTime.Location = new System.Drawing.Point(330, 1);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(109, 39);
            this.panelTime.TabIndex = 10;
            // 
            // panelOrden
            // 
            this.panelOrden.Controls.Add(this.label17);
            this.panelOrden.Controls.Add(this.btnSelecCliente);
            this.panelOrden.Controls.Add(this.dgvDetalleOrden);
            this.panelOrden.Controls.Add(this.btnEnviarCocina);
            this.panelOrden.Controls.Add(this.button3);
            this.panelOrden.Controls.Add(this.label3);
            this.panelOrden.Controls.Add(this.txtNombreCliente);
            this.panelOrden.Controls.Add(this.label14);
            this.panelOrden.Controls.Add(this.txtIdCliente);
            this.panelOrden.Controls.Add(this.label13);
            this.panelOrden.Controls.Add(this.txtNoOrden);
            this.panelOrden.Controls.Add(this.label12);
            this.panelOrden.Controls.Add(this.txtTotalFinal);
            this.panelOrden.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOrden.Location = new System.Drawing.Point(838, 88);
            this.panelOrden.Name = "panelOrden";
            this.panelOrden.Size = new System.Drawing.Size(532, 636);
            this.panelOrden.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label17.Location = new System.Drawing.Point(305, 550);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 22);
            this.label17.TabIndex = 53;
            this.label17.Text = "TOTAL $";
            // 
            // btnSelecCliente
            // 
            this.btnSelecCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.btnSelecCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecCliente.FlatAppearance.BorderSize = 0;
            this.btnSelecCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSelecCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSelecCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelecCliente.ForeColor = System.Drawing.Color.White;
            this.btnSelecCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelecCliente.Location = new System.Drawing.Point(62, 67);
            this.btnSelecCliente.Name = "btnSelecCliente";
            this.btnSelecCliente.Size = new System.Drawing.Size(105, 52);
            this.btnSelecCliente.TabIndex = 49;
            this.btnSelecCliente.Text = "Nueva Orden";
            this.btnSelecCliente.UseVisualStyleBackColor = false;
            this.btnSelecCliente.Click += new System.EventHandler(this.btnSelecCliente_Click);
            // 
            // dgvDetalleOrden
            // 
            this.dgvDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleOrden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(67)))));
            this.dgvDetalleOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalleOrden.ColumnHeadersHeight = 35;
            this.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleOrden.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalleOrden.EnableHeadersVisualStyles = false;
            this.dgvDetalleOrden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvDetalleOrden.Location = new System.Drawing.Point(10, 125);
            this.dgvDetalleOrden.Name = "dgvDetalleOrden";
            this.dgvDetalleOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleOrden.RowHeadersVisible = false;
            this.dgvDetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrden.Size = new System.Drawing.Size(510, 418);
            this.dgvDetalleOrden.TabIndex = 35;
            // 
            // btnEnviarCocina
            // 
            this.btnEnviarCocina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.btnEnviarCocina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCocina.Enabled = false;
            this.btnEnviarCocina.FlatAppearance.BorderSize = 0;
            this.btnEnviarCocina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEnviarCocina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEnviarCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCocina.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnviarCocina.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCocina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnviarCocina.Location = new System.Drawing.Point(93, 580);
            this.btnEnviarCocina.Name = "btnEnviarCocina";
            this.btnEnviarCocina.Size = new System.Drawing.Size(369, 50);
            this.btnEnviarCocina.TabIndex = 8;
            this.btnEnviarCocina.Text = "Enviar a Cocina";
            this.btnEnviarCocina.UseVisualStyleBackColor = false;
            this.btnEnviarCocina.Click += new System.EventHandler(this.btnEnviarCocina_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(720, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Extras";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(20, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orden";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Location = new System.Drawing.Point(260, 94);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(260, 25);
            this.txtNombreCliente.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label14.Location = new System.Drawing.Point(185, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 22);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nombre";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIdCliente.Location = new System.Drawing.Point(275, 63);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(89, 25);
            this.txtIdCliente.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label13.Location = new System.Drawing.Point(185, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 22);
            this.label13.TabIndex = 45;
            this.label13.Text = "Id CLiente";
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Enabled = false;
            this.txtNoOrden.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNoOrden.Location = new System.Drawing.Point(209, 32);
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(161, 25);
            this.txtNoOrden.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label12.Location = new System.Drawing.Point(116, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 45;
            this.label12.Text = "No. Orden";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Enabled = false;
            this.txtTotalFinal.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalFinal.Location = new System.Drawing.Point(378, 549);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(142, 25);
            this.txtTotalFinal.TabIndex = 49;
            this.txtTotalFinal.Text = "0";
            this.txtTotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(67)))));
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMenu.ColumnHeadersHeight = 35;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvMenu.Location = new System.Drawing.Point(12, 36);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(631, 507);
            this.dgvMenu.TabIndex = 34;
            this.dgvMenu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMenu_CellMouseClick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.label16);
            this.panelMenu.Controls.Add(this.txtCantidad);
            this.panelMenu.Controls.Add(this.txtExtra);
            this.panelMenu.Controls.Add(this.txtDesc);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.txtCategoria);
            this.panelMenu.Controls.Add(this.label11);
            this.panelMenu.Controls.Add(this.label15);
            this.panelMenu.Controls.Add(this.txtId);
            this.panelMenu.Controls.Add(this.label7);
            this.panelMenu.Controls.Add(this.txtPrecio);
            this.panelMenu.Controls.Add(this.label10);
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Controls.Add(this.txtNombre);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.txtBuscar);
            this.panelMenu.Controls.Add(this.dgvMenu);
            this.panelMenu.Controls.Add(this.label9);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 88);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(821, 636);
            this.panelMenu.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label16.Location = new System.Drawing.Point(649, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 22);
            this.label16.TabIndex = 53;
            this.label16.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCantidad.Location = new System.Drawing.Point(650, 529);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 26);
            this.txtCantidad.TabIndex = 52;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtExtra
            // 
            this.txtExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExtra.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtExtra.Location = new System.Drawing.Point(649, 419);
            this.txtExtra.MaximumSize = new System.Drawing.Size(169, 79);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExtra.Size = new System.Drawing.Size(169, 14);
            this.txtExtra.TabIndex = 51;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDesc.Location = new System.Drawing.Point(649, 247);
            this.txtDesc.MaximumSize = new System.Drawing.Size(161, 80);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(161, 15);
            this.txtDesc.TabIndex = 51;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(646, 565);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 46);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar a Pedido";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(650, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cantidad";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.Location = new System.Drawing.Point(650, 355);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(161, 25);
            this.txtCategoria.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label11.Location = new System.Drawing.Point(12, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Menú";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(646, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 22);
            this.label15.TabIndex = 41;
            this.label15.Text = "Extra";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(649, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 25);
            this.txtId.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(649, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecio.Location = new System.Drawing.Point(668, 186);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 25);
            this.txtPrecio.TabIndex = 49;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(650, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(649, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(649, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 25);
            this.txtNombre.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(649, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(649, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Id";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.Location = new System.Drawing.Point(63, 573);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(189, 25);
            this.txtBuscar.TabIndex = 35;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(70, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Buscar Por Nombre";
            // 
            // mstCajero
            // 
            this.mstCajero.BackColor = System.Drawing.Color.White;
            this.mstCajero.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPantallasToolStripMenuItem});
            this.mstCajero.Location = new System.Drawing.Point(0, 60);
            this.mstCajero.Name = "mstCajero";
            this.mstCajero.Size = new System.Drawing.Size(1370, 28);
            this.mstCajero.TabIndex = 54;
            this.mstCajero.Text = "menuStrip1";
            // 
            // verPantallasToolStripMenuItem
            // 
            this.verPantallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaCocineroToolStripMenuItem});
            this.verPantallasToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.verPantallasToolStripMenuItem.Name = "verPantallasToolStripMenuItem";
            this.verPantallasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.verPantallasToolStripMenuItem.Text = "Ver Pantallas";
            // 
            // pantallaCocineroToolStripMenuItem
            // 
            this.pantallaCocineroToolStripMenuItem.Name = "pantallaCocineroToolStripMenuItem";
            this.pantallaCocineroToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.pantallaCocineroToolStripMenuItem.Text = "Pantalla Cocinero";
            this.pantallaCocineroToolStripMenuItem.Click += new System.EventHandler(this.pantallaCocineroToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(67)))));
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1370, 60);
            this.panelTop.TabIndex = 55;
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
            this.panelTopRight.Controls.Add(this.btnCerrarFrm);
            this.panelTopRight.Controls.Add(this.labelTipodeCuenta);
            this.panelTopRight.Controls.Add(this.labelUsuario);
            this.panelTopRight.Controls.Add(this.btnMinimizar);
            this.panelTopRight.Controls.Add(this.btnCerrarSesion);
            this.panelTopRight.Controls.Add(this.btnCerrarT);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(935, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(435, 60);
            this.panelTopRight.TabIndex = 10;
            // 
            // btnCerrarFrm
            // 
            this.btnCerrarFrm.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFrm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarFrm.BackgroundImage")));
            this.btnCerrarFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFrm.FlatAppearance.BorderSize = 0;
            this.btnCerrarFrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFrm.Location = new System.Drawing.Point(410, -3);
            this.btnCerrarFrm.Name = "btnCerrarFrm";
            this.btnCerrarFrm.Size = new System.Drawing.Size(25, 33);
            this.btnCerrarFrm.TabIndex = 14;
            this.btnCerrarFrm.UseVisualStyleBackColor = false;
            this.btnCerrarFrm.Visible = false;
            this.btnCerrarFrm.Click += new System.EventHandler(this.btnCerrarFrm_Click_1);
            // 
            // labelTipodeCuenta
            // 
            this.labelTipodeCuenta.AutoSize = true;
            this.labelTipodeCuenta.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTipodeCuenta.ForeColor = System.Drawing.Color.White;
            this.labelTipodeCuenta.Location = new System.Drawing.Point(251, 30);
            this.labelTipodeCuenta.Name = "labelTipodeCuenta";
            this.labelTipodeCuenta.Size = new System.Drawing.Size(55, 20);
            this.labelTipodeCuenta.TabIndex = 12;
            this.labelTipodeCuenta.Text = "Cajero";
            this.labelTipodeCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(170, 10);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(136, 20);
            this.labelUsuario.TabIndex = 13;
            this.labelUsuario.Text = "Usuario: SaulUS01";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnMinimizar.Location = new System.Drawing.Point(374, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 33);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(320, 10);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 37);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
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
            this.btnCerrarT.Location = new System.Drawing.Point(409, 0);
            this.btnCerrarT.Name = "btnCerrarT";
            this.btnCerrarT.Size = new System.Drawing.Size(25, 33);
            this.btnCerrarT.TabIndex = 2;
            this.btnCerrarT.UseVisualStyleBackColor = false;
            this.btnCerrarT.Click += new System.EventHandler(this.btnCerrarT_Click);
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
            // frmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1370, 764);
            this.ControlBox = false;
            this.Controls.Add(this.panelOrden);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.mstCajero);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstCajero;
            this.Name = "frmCajero";
            this.Text = " Cajero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cajero_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelOrden.ResumeLayout(false);
            this.panelOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.mstCajero.ResumeLayout(false);
            this.mstCajero.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelOrden;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviarCocina;
        private System.Windows.Forms.DataGridView dgvDetalleOrden;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSelecCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem verPantallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaCocineroToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mstCajero;
        public System.Windows.Forms.Label labelTipodeCuenta;
        public System.Windows.Forms.Button btnCerrarSesion;
        public System.Windows.Forms.Button btnCerrarFrm;
        public System.Windows.Forms.Label labelUsuario;
        public System.Windows.Forms.Button btnCerrarT;
    }
}