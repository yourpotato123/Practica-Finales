namespace FinalMayo2023
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btPago = new System.Windows.Forms.Button();
            this.btSaldo = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbCUIT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btImportarProcto = new System.Windows.Forms.Button();
            this.btExportarPedido = new System.Windows.Forms.Button();
            this.btExportarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btPago);
            this.groupBox1.Controls.Add(this.btSaldo);
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.tbCUIT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar/agregar cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 283);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Pedido";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(211, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 160);
            this.listBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos elegidos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btAgregarPedido_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Elegir Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btElegirProducto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btPago
            // 
            this.btPago.Location = new System.Drawing.Point(221, 80);
            this.btPago.Name = "btPago";
            this.btPago.Size = new System.Drawing.Size(75, 37);
            this.btPago.TabIndex = 4;
            this.btPago.Text = "Realizar Pago";
            this.btPago.UseVisualStyleBackColor = true;
            this.btPago.Click += new System.EventHandler(this.btPago_Click);
            // 
            // btSaldo
            // 
            this.btSaldo.Location = new System.Drawing.Point(116, 80);
            this.btSaldo.Name = "btSaldo";
            this.btSaldo.Size = new System.Drawing.Size(78, 37);
            this.btSaldo.TabIndex = 3;
            this.btSaldo.Text = "Ver Saldo";
            this.btSaldo.UseVisualStyleBackColor = true;
            this.btSaldo.Click += new System.EventHandler(this.btSaldo_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(10, 80);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(81, 37);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar / Selecionar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbCUIT
            // 
            this.tbCUIT.Location = new System.Drawing.Point(46, 29);
            this.tbCUIT.Name = "tbCUIT";
            this.tbCUIT.Size = new System.Drawing.Size(132, 20);
            this.tbCUIT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btImportarProcto);
            this.groupBox3.Controls.Add(this.btExportarPedido);
            this.groupBox3.Controls.Add(this.btExportarCliente);
            this.groupBox3.Location = new System.Drawing.Point(455, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 425);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Razon Social";
            // 
            // btImportarProcto
            // 
            this.btImportarProcto.Location = new System.Drawing.Point(48, 347);
            this.btImportarProcto.Name = "btImportarProcto";
            this.btImportarProcto.Size = new System.Drawing.Size(122, 41);
            this.btImportarProcto.TabIndex = 2;
            this.btImportarProcto.Text = "Importar Productos";
            this.btImportarProcto.UseVisualStyleBackColor = true;
            this.btImportarProcto.Click += new System.EventHandler(this.btImportarProcto_Click);
            // 
            // btExportarPedido
            // 
            this.btExportarPedido.Location = new System.Drawing.Point(48, 216);
            this.btExportarPedido.Name = "btExportarPedido";
            this.btExportarPedido.Size = new System.Drawing.Size(122, 45);
            this.btExportarPedido.TabIndex = 1;
            this.btExportarPedido.Text = "Exportar Pedido";
            this.btExportarPedido.UseVisualStyleBackColor = true;
            this.btExportarPedido.Click += new System.EventHandler(this.btExportarPedido_Click);
            // 
            // btExportarCliente
            // 
            this.btExportarCliente.Location = new System.Drawing.Point(48, 107);
            this.btExportarCliente.Name = "btExportarCliente";
            this.btExportarCliente.Size = new System.Drawing.Size(122, 42);
            this.btExportarCliente.TabIndex = 0;
            this.btExportarCliente.Text = "Exportar Cliente";
            this.btExportarCliente.UseVisualStyleBackColor = true;
            this.btExportarCliente.Click += new System.EventHandler(this.btExportarCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPago;
        private System.Windows.Forms.Button btSaldo;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbCUIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btImportarProcto;
        private System.Windows.Forms.Button btExportarPedido;
        private System.Windows.Forms.Button btExportarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

