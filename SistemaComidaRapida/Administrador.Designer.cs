namespace SistemaComidaRapida
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
            this.btnListaEmp = new System.Windows.Forms.Button();
            this.btnVerMenu = new System.Windows.Forms.Button();
            this.btnHisPedi = new System.Windows.Forms.Button();
            this.btnHisClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaEmp
            // 
            this.btnListaEmp.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnListaEmp.Location = new System.Drawing.Point(70, 33);
            this.btnListaEmp.Name = "btnListaEmp";
            this.btnListaEmp.Size = new System.Drawing.Size(130, 23);
            this.btnListaEmp.TabIndex = 0;
            this.btnListaEmp.Text = "Lista de Empleados";
            this.btnListaEmp.UseVisualStyleBackColor = true;
            // 
            // btnVerMenu
            // 
            this.btnVerMenu.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerMenu.Location = new System.Drawing.Point(70, 78);
            this.btnVerMenu.Name = "btnVerMenu";
            this.btnVerMenu.Size = new System.Drawing.Size(130, 23);
            this.btnVerMenu.TabIndex = 0;
            this.btnVerMenu.Text = "Ver Menú";
            this.btnVerMenu.UseVisualStyleBackColor = true;
            // 
            // btnHisPedi
            // 
            this.btnHisPedi.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnHisPedi.Location = new System.Drawing.Point(70, 123);
            this.btnHisPedi.Name = "btnHisPedi";
            this.btnHisPedi.Size = new System.Drawing.Size(130, 23);
            this.btnHisPedi.TabIndex = 0;
            this.btnHisPedi.Text = "Historial de Pedidos";
            this.btnHisPedi.UseVisualStyleBackColor = true;
            // 
            // btnHisClientes
            // 
            this.btnHisClientes.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnHisClientes.Location = new System.Drawing.Point(70, 168);
            this.btnHisClientes.Name = "btnHisClientes";
            this.btnHisClientes.Size = new System.Drawing.Size(130, 23);
            this.btnHisClientes.TabIndex = 0;
            this.btnHisClientes.Text = "Historial Clientes";
            this.btnHisClientes.UseVisualStyleBackColor = true;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 240);
            this.Controls.Add(this.btnHisClientes);
            this.Controls.Add(this.btnHisPedi);
            this.Controls.Add(this.btnVerMenu);
            this.Controls.Add(this.btnListaEmp);
            this.Name = "frmAdministrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaEmp;
        private System.Windows.Forms.Button btnVerMenu;
        private System.Windows.Forms.Button btnHisPedi;
        private System.Windows.Forms.Button btnHisClientes;
    }
}