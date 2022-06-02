namespace PresentacionIGU

{

    partial class FormClientes
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
            this.botonNuevoCliente = new System.Windows.Forms.Button();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // textIdCliente
            // 
            this.textIdCliente.Location = new System.Drawing.Point(121, 67);
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textIdCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(121, 112);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textNombreCliente.TabIndex = 3;
            // 
            // botonNuevoCliente
            // 
            this.botonNuevoCliente.Location = new System.Drawing.Point(40, 211);
            this.botonNuevoCliente.Name = "botonNuevoCliente";
            this.botonNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.botonNuevoCliente.TabIndex = 4;
            this.botonNuevoCliente.Text = "Nuevo";
            this.botonNuevoCliente.UseVisualStyleBackColor = true;
            this.botonNuevoCliente.Click += new System.EventHandler(this.botonNuevoCliente_Click);
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Location = new System.Drawing.Point(146, 211);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarCliente.TabIndex = 5;
            this.botonBuscarCliente.Text = "Buscar";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(254, 211);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 298);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonBuscarCliente);
            this.Controls.Add(this.botonNuevoCliente);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIdCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormClientes";
            this.Text = "MenuClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Button botonNuevoCliente;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.Button botonSalir;
    }
}