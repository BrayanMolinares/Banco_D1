namespace PresentacionIGU
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonCuentas = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonClientes
            // 
            this.botonClientes.Location = new System.Drawing.Point(129, 35);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(124, 52);
            this.botonClientes.TabIndex = 0;
            this.botonClientes.Text = "Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonCuentas
            // 
            this.botonCuentas.Location = new System.Drawing.Point(129, 132);
            this.botonCuentas.Name = "botonCuentas";
            this.botonCuentas.Size = new System.Drawing.Size(124, 52);
            this.botonCuentas.TabIndex = 1;
            this.botonCuentas.Text = "Cuentas";
            this.botonCuentas.UseVisualStyleBackColor = true;
            this.botonCuentas.Click += new System.EventHandler(this.botonCuentas_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(129, 231);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(124, 52);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 341);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonCuentas);
            this.Controls.Add(this.botonClientes);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonCuentas;
        private System.Windows.Forms.Button botonSalir;
    }
}

