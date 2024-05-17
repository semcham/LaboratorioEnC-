namespace Laboratorio8_Ejercicio5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDivisor = new Label();
            lblIngreseNumeros = new Label();
            btnAgregar = new Button();
            txtIngreseElementosLista1 = new TextBox();
            txtIngreseElementosLista2 = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(413, 26);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(203, 20);
            lblDivisor.TabIndex = 37;
            lblDivisor.Text = "Ingrese elementos para lista2";
            // 
            // lblIngreseNumeros
            // 
            lblIngreseNumeros.AutoSize = true;
            lblIngreseNumeros.Location = new Point(49, 26);
            lblIngreseNumeros.Name = "lblIngreseNumeros";
            lblIngreseNumeros.Size = new Size(203, 20);
            lblIngreseNumeros.TabIndex = 36;
            lblIngreseNumeros.Text = "Ingrese Elementos para lista1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(49, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 39);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar Elemento a la Listas";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreseElementosLista1
            // 
            txtIngreseElementosLista1.Location = new Point(49, 62);
            txtIngreseElementosLista1.Name = "txtIngreseElementosLista1";
            txtIngreseElementosLista1.Size = new Size(125, 27);
            txtIngreseElementosLista1.TabIndex = 34;
            // 
            // txtIngreseElementosLista2
            // 
            txtIngreseElementosLista2.Location = new Point(413, 62);
            txtIngreseElementosLista2.Name = "txtIngreseElementosLista2";
            txtIngreseElementosLista2.Size = new Size(125, 27);
            txtIngreseElementosLista2.TabIndex = 33;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(572, 361);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 39);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(433, 361);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 39);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(38, 105);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 30;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(281, 361);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 29;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDivisor);
            Controls.Add(lblIngreseNumeros);
            Controls.Add(btnAgregar);
            Controls.Add(txtIngreseElementosLista1);
            Controls.Add(txtIngreseElementosLista2);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDivisor;
        private Label lblIngreseNumeros;
        private Button btnAgregar;
        private TextBox txtIngreseElementosLista1;
        private TextBox txtIngreseElementosLista2;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultado;
        private Button btnCalcular;
    }
}
