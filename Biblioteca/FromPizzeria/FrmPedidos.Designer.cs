namespace FromPizzeria
{
    partial class FrmPedidos
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
            this.cmbGusto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMas = new System.Windows.Forms.Button();
            this.cmbCoccion = new System.Windows.Forms.ComboBox();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDomicilio = new System.Windows.Forms.CheckBox();
            this.listPizza = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarPizza = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnBorrarPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGusto
            // 
            this.cmbGusto.FormattingEnabled = true;
            this.cmbGusto.Items.AddRange(new object[] {
            "Muzzarella",
            "Napolitana",
            "Hawaiana"});
            this.cmbGusto.Location = new System.Drawing.Point(40, 47);
            this.cmbGusto.Name = "cmbGusto";
            this.cmbGusto.Size = new System.Drawing.Size(121, 21);
            this.cmbGusto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gusto";
            // 
            // btnMenos
            // 
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(125, 186);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(36, 27);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(40, 160);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(121, 20);
            this.textCantidad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // btnMas
            // 
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(40, 186);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(36, 27);
            this.btnMas.TabIndex = 9;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // cmbCoccion
            // 
            this.cmbCoccion.FormattingEnabled = true;
            this.cmbCoccion.Items.AddRange(new object[] {
            "Horno",
            "A la Piedra"});
            this.cmbCoccion.Location = new System.Drawing.Point(44, 94);
            this.cmbCoccion.Name = "cmbCoccion";
            this.cmbCoccion.Size = new System.Drawing.Size(117, 21);
            this.cmbCoccion.TabIndex = 10;
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarPedido.Location = new System.Drawing.Point(243, 285);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(189, 29);
            this.btnCargarPedido.TabIndex = 11;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = true;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cocción";
            // 
            // checkDomicilio
            // 
            this.checkDomicilio.AutoSize = true;
            this.checkDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDomicilio.Location = new System.Drawing.Point(43, 231);
            this.checkDomicilio.Name = "checkDomicilio";
            this.checkDomicilio.Size = new System.Drawing.Size(113, 22);
            this.checkDomicilio.TabIndex = 13;
            this.checkDomicilio.Text = "A Domicilio";
            this.checkDomicilio.UseVisualStyleBackColor = true;
            // 
            // listPizza
            // 
            this.listPizza.FormattingEnabled = true;
            this.listPizza.Location = new System.Drawing.Point(243, 41);
            this.listPizza.Name = "listPizza";
            this.listPizza.Size = new System.Drawing.Size(385, 212);
            this.listPizza.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pizzas";
            // 
            // btnAgregarPizza
            // 
            this.btnAgregarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPizza.Location = new System.Drawing.Point(12, 285);
            this.btnAgregarPizza.Name = "btnAgregarPizza";
            this.btnAgregarPizza.Size = new System.Drawing.Size(91, 29);
            this.btnAgregarPizza.TabIndex = 16;
            this.btnAgregarPizza.Text = "Agregar Pizza";
            this.btnAgregarPizza.UseVisualStyleBackColor = true;
            this.btnAgregarPizza.Click += new System.EventHandler(this.btnAgregarPizza_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarPedido.Location = new System.Drawing.Point(447, 285);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(181, 29);
            this.btnCancelarPedido.TabIndex = 17;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnBorrarPizza
            // 
            this.btnBorrarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarPizza.Location = new System.Drawing.Point(109, 285);
            this.btnBorrarPizza.Name = "btnBorrarPizza";
            this.btnBorrarPizza.Size = new System.Drawing.Size(91, 29);
            this.btnBorrarPizza.TabIndex = 18;
            this.btnBorrarPizza.Text = "Borrar Pizza";
            this.btnBorrarPizza.UseVisualStyleBackColor = true;
            this.btnBorrarPizza.Click += new System.EventHandler(this.btnBorrarPizza_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 342);
            this.Controls.Add(this.btnBorrarPizza);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnAgregarPizza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listPizza);
            this.Controls.Add(this.checkDomicilio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.cmbCoccion);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGusto);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.ComboBox cmbCoccion;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkDomicilio;
        private System.Windows.Forms.ListBox listPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarPizza;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnBorrarPizza;
    }
}