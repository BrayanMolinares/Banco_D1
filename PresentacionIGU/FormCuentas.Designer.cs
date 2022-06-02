namespace PresentacionIGU
{
    partial class FormCuentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumeroCuenta = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonConsignarCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // textIdCliente
            // 
            this.textIdCliente.Location = new System.Drawing.Point(99, 38);
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textIdCliente.TabIndex = 1;
            this.textIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextIdCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Enabled = false;
            this.textNombreCliente.Location = new System.Drawing.Point(99, 80);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textNombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NumeroCuenta";
            // 
            // textNumeroCuenta
            // 
            this.textNumeroCuenta.Location = new System.Drawing.Point(99, 124);
            this.textNumeroCuenta.Name = "textNumeroCuenta";
            this.textNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.textNumeroCuenta.TabIndex = 5;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(43, 237);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 6;
            this.botonAgregar.Text = "Nueva";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(144, 237);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 7;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(246, 237);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 8;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(99, 160);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo";
            // 
            // botonConsignarCuenta
            // 
            this.botonConsignarCuenta.Location = new System.Drawing.Point(283, 158);
            this.botonConsignarCuenta.Name = "botonConsignarCuenta";
            this.botonConsignarCuenta.Size = new System.Drawing.Size(75, 23);
            this.botonConsignarCuenta.TabIndex = 11;
            this.botonConsignarCuenta.Text = "Consignar";
            this.botonConsignarCuenta.UseVisualStyleBackColor = true;
            this.botonConsignarCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 317);
            this.Controls.Add(this.botonConsignarCuenta);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textNumeroCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIdCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormCuentas";
            this.Text = "FormCuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumeroCuenta;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonConsignarCuenta;
    }
}