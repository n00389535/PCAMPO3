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
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCaracteres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinúsculas = new System.Windows.Forms.Button();
            this.btnMayusculas = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnLongitud = new System.Windows.Forms.Button();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDividir.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Gold;
            this.btnDividir.Location = new System.Drawing.Point(544, 320);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(143, 26);
            this.btnDividir.TabIndex = 61;
            this.btnDividir.Text = "Dividir Frase";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIndice.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndice.ForeColor = System.Drawing.Color.Gold;
            this.btnIndice.Location = new System.Drawing.Point(544, 290);
            this.btnIndice.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(143, 26);
            this.btnIndice.TabIndex = 60;
            this.btnIndice.Text = " Indice de un caracter";
            this.btnIndice.UseVisualStyleBackColor = false;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReemplazar.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReemplazar.ForeColor = System.Drawing.Color.Gold;
            this.btnReemplazar.Location = new System.Drawing.Point(544, 260);
            this.btnReemplazar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(143, 26);
            this.btnReemplazar.TabIndex = 59;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = false;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(450, 115);
            this.txtPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(56, 20);
            this.txtPosicion.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Posición a extraer";
            // 
            // txtNumCaracteres
            // 
            this.txtNumCaracteres.Location = new System.Drawing.Point(450, 86);
            this.txtNumCaracteres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCaracteres.Name = "txtNumCaracteres";
            this.txtNumCaracteres.Size = new System.Drawing.Size(56, 20);
            this.txtNumCaracteres.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Num Caracteres";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(544, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 26);
            this.button1.TabIndex = 54;
            this.button1.Text = "Extraer N caracteres";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinúsculas
            // 
            this.btnMinúsculas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinúsculas.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinúsculas.ForeColor = System.Drawing.Color.Gold;
            this.btnMinúsculas.Location = new System.Drawing.Point(544, 200);
            this.btnMinúsculas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinúsculas.Name = "btnMinúsculas";
            this.btnMinúsculas.Size = new System.Drawing.Size(143, 26);
            this.btnMinúsculas.TabIndex = 53;
            this.btnMinúsculas.Text = "Minúsculas";
            this.btnMinúsculas.UseVisualStyleBackColor = false;
            this.btnMinúsculas.Click += new System.EventHandler(this.btnMinúsculas_Click);
            // 
            // btnMayusculas
            // 
            this.btnMayusculas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMayusculas.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayusculas.ForeColor = System.Drawing.Color.Gold;
            this.btnMayusculas.Location = new System.Drawing.Point(544, 170);
            this.btnMayusculas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMayusculas.Name = "btnMayusculas";
            this.btnMayusculas.Size = new System.Drawing.Size(143, 26);
            this.btnMayusculas.TabIndex = 52;
            this.btnMayusculas.Text = "Mayúsculas";
            this.btnMayusculas.UseVisualStyleBackColor = false;
            this.btnMayusculas.Click += new System.EventHandler(this.btnMayusculas_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrim.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrim.ForeColor = System.Drawing.Color.Gold;
            this.btnTrim.Location = new System.Drawing.Point(544, 140);
            this.btnTrim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(143, 26);
            this.btnTrim.TabIndex = 51;
            this.btnTrim.Text = "Eliminar espacios";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnLongitud
            // 
            this.btnLongitud.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLongitud.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongitud.ForeColor = System.Drawing.Color.Gold;
            this.btnLongitud.Location = new System.Drawing.Point(544, 111);
            this.btnLongitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnLongitud.Name = "btnLongitud";
            this.btnLongitud.Size = new System.Drawing.Size(143, 26);
            this.btnLongitud.TabIndex = 50;
            this.btnLongitud.Text = "Longitud de caracteres";
            this.btnLongitud.UseVisualStyleBackColor = false;
            this.btnLongitud.Click += new System.EventHandler(this.btnLongitud_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConcatenar.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcatenar.ForeColor = System.Drawing.Color.Gold;
            this.btnConcatenar.Location = new System.Drawing.Point(544, 81);
            this.btnConcatenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(143, 26);
            this.btnConcatenar.TabIndex = 49;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = false;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(94, 150);
            this.lstResultado.Margin = new System.Windows.Forms.Padding(2);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(424, 277);
            this.lstResultado.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(160, 117);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 20);
            this.txtApellido.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tratamiento de Cadenas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumCaracteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMinúsculas);
            this.Controls.Add(this.btnMayusculas);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnLongitud);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCaracteres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinúsculas;
        private System.Windows.Forms.Button btnMayusculas;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnLongitud;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

