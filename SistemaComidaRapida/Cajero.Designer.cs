namespace SistemaComidaRapida
{
    partial class Cajero
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkCombos = new System.Windows.Forms.CheckBox();
            this.checkBebidas = new System.Windows.Forms.CheckBox();
            this.checkPlatos = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnEnviarOrden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(341, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkCombos
            // 
            this.checkCombos.AutoSize = true;
            this.checkCombos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCombos.Location = new System.Drawing.Point(341, 45);
            this.checkCombos.Name = "checkCombos";
            this.checkCombos.Size = new System.Drawing.Size(74, 22);
            this.checkCombos.TabIndex = 3;
            this.checkCombos.Text = "Combos";
            this.checkCombos.UseVisualStyleBackColor = true;
            // 
            // checkBebidas
            // 
            this.checkBebidas.AutoSize = true;
            this.checkBebidas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBebidas.Location = new System.Drawing.Point(341, 73);
            this.checkBebidas.Name = "checkBebidas";
            this.checkBebidas.Size = new System.Drawing.Size(75, 22);
            this.checkBebidas.TabIndex = 3;
            this.checkBebidas.Text = "Bebidas";
            this.checkBebidas.UseVisualStyleBackColor = true;
            // 
            // checkPlatos
            // 
            this.checkPlatos.AutoSize = true;
            this.checkPlatos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPlatos.Location = new System.Drawing.Point(341, 101);
            this.checkPlatos.Name = "checkPlatos";
            this.checkPlatos.Size = new System.Drawing.Size(64, 22);
            this.checkPlatos.TabIndex = 3;
            this.checkPlatos.Text = "Platos";
            this.checkPlatos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviarOrden);
            this.groupBox2.Controls.Add(this.btnExtras);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(451, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(64, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnExtras
            // 
            this.btnExtras.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnExtras.Location = new System.Drawing.Point(204, 353);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(104, 23);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            // 
            // btnEnviarOrden
            // 
            this.btnEnviarOrden.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnviarOrden.Location = new System.Drawing.Point(103, 382);
            this.btnEnviarOrden.Name = "btnEnviarOrden";
            this.btnEnviarOrden.Size = new System.Drawing.Size(160, 23);
            this.btnEnviarOrden.TabIndex = 2;
            this.btnEnviarOrden.Text = "Enviar Orden a Cocina";
            this.btnEnviarOrden.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENÚ";
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 437);
            this.Controls.Add(this.checkPlatos);
            this.Controls.Add(this.checkBebidas);
            this.Controls.Add(this.checkCombos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkCombos;
        private System.Windows.Forms.CheckBox checkBebidas;
        private System.Windows.Forms.CheckBox checkPlatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnviarOrden;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}