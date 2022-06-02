namespace PresentacionIGU
{
    partial class FormularioConsignacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonConsignar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroCuenta = new System.Windows.Forms.TextBox();
            this.textidCliente = new System.Windows.Forms.TextBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Saldo";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(123, 202);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 19;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonConsignar
            // 
            this.botonConsignar.Location = new System.Drawing.Point(239, 147);
            this.botonConsignar.Name = "botonConsignar";
            this.botonConsignar.Size = new System.Drawing.Size(75, 23);
            this.botonConsignar.TabIndex = 18;
            this.botonConsignar.Text = "Consignar";
            this.botonConsignar.UseVisualStyleBackColor = true;
            this.botonConsignar.Click += new System.EventHandler(this.botonConsignar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero de cuenta";
            // 
            // textNumeroCuenta
            // 
            this.textNumeroCuenta.Location = new System.Drawing.Point(113, 34);
            this.textNumeroCuenta.Name = "textNumeroCuenta";
            this.textNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.textNumeroCuenta.TabIndex = 21;
            this.textNumeroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroCuenta_KeyPress);
            // 
            // textidCliente
            // 
            this.textidCliente.Location = new System.Drawing.Point(113, 72);
            this.textidCliente.Name = "textidCliente";
            this.textidCliente.Size = new System.Drawing.Size(100, 20);
            this.textidCliente.TabIndex = 22;
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(113, 109);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textNombreCliente.TabIndex = 23;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(113, 145);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 24;
            // 
            // FormularioConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 244);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.textidCliente);
            this.Controls.Add(this.textNumeroCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonConsignar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioConsignacion";
            this.Text = "FormularioConsignacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonConsignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroCuenta;
        private System.Windows.Forms.TextBox textidCliente;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.TextBox textSaldo;
    }
}