namespace PCAMPO3
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
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCuota = new System.Windows.Forms.ListBox();
            this.lstPeriodo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstMonto = new System.Windows.Forms.ListBox();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(345, 189);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(69, 20);
            this.txtTasa.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tasa efectiva anual (TEA) a 360 días:";
            // 
            // lstCuota
            // 
            this.lstCuota.BackColor = System.Drawing.Color.DarkOrange;
            this.lstCuota.FormattingEnabled = true;
            this.lstCuota.Location = new System.Drawing.Point(418, 223);
            this.lstCuota.Margin = new System.Windows.Forms.Padding(2);
            this.lstCuota.Name = "lstCuota";
            this.lstCuota.Size = new System.Drawing.Size(69, 121);
            this.lstCuota.TabIndex = 60;
            // 
            // lstPeriodo
            // 
            this.lstPeriodo.BackColor = System.Drawing.Color.DarkOrange;
            this.lstPeriodo.FormattingEnabled = true;
            this.lstPeriodo.Location = new System.Drawing.Point(349, 223);
            this.lstPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.lstPeriodo.Name = "lstPeriodo";
            this.lstPeriodo.Size = new System.Drawing.Size(69, 121);
            this.lstPeriodo.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "num cuotas";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboPeriodo.Location = new System.Drawing.Point(418, 163);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(69, 21);
            this.cboPeriodo.TabIndex = 57;
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.BackColor = System.Drawing.Color.Orange;
            this.btnBurbuja.Location = new System.Drawing.Point(509, 290);
            this.btnBurbuja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(103, 26);
            this.btnBurbuja.TabIndex = 56;
            this.btnBurbuja.Text = "Orden Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = false;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "monto solicitado";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(239, 163);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(69, 20);
            this.txtMonto.TabIndex = 53;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrar.Location = new System.Drawing.Point(509, 257);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(103, 26);
            this.btnMostrar.TabIndex = 52;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "ENTIDAD  FINANCIRA ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(509, 228);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 26);
            this.btnIngresar.TabIndex = 50;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 134);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // lstMonto
            // 
            this.lstMonto.BackColor = System.Drawing.Color.DarkOrange;
            this.lstMonto.FormattingEnabled = true;
            this.lstMonto.Location = new System.Drawing.Point(279, 223);
            this.lstMonto.Margin = new System.Windows.Forms.Padding(2);
            this.lstMonto.Name = "lstMonto";
            this.lstMonto.Size = new System.Drawing.Size(69, 121);
            this.lstMonto.TabIndex = 47;
            // 
            // lstCliente
            // 
            this.lstCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(140, 223);
            this.lstCliente.Margin = new System.Windows.Forms.Padding(2);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(139, 121);
            this.lstCliente.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCuota);
            this.Controls.Add(this.lstPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstMonto);
            this.Controls.Add(this.lstCliente);
            this.Name = "Form1";
            this.Text = ";\\=";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstCuota;
        private System.Windows.Forms.ListBox lstPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstMonto;
        private System.Windows.Forms.ListBox lstCliente;
    }
}

