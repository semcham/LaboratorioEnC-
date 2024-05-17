namespace Labotatorio8_Ejercicio_3
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
            btnAgregar = new Button();
            txtIngreseNumeros = new TextBox();
            txtDivisor = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            lblIngreseNumeros = new Label();
            lblDivisor = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(75, 360);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 39);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar Elemento a la Lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreseNumeros
            // 
            txtIngreseNumeros.Location = new Point(72, 61);
            txtIngreseNumeros.Name = "txtIngreseNumeros";
            txtIngreseNumeros.Size = new Size(125, 27);
            txtIngreseNumeros.TabIndex = 16;
            txtIngreseNumeros.TextChanged += txtIngreseNumeros_TextChanged;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(251, 48);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(125, 27);
            txtDivisor.TabIndex = 15;
            txtDivisor.TextChanged += txtDivisor_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(607, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(461, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(72, 109);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(307, 360);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblIngreseNumeros
            // 
            lblIngreseNumeros.AutoSize = true;
            lblIngreseNumeros.Location = new Point(75, 25);
            lblIngreseNumeros.Name = "lblIngreseNumeros";
            lblIngreseNumeros.Size = new Size(122, 20);
            lblIngreseNumeros.TabIndex = 18;
            lblIngreseNumeros.Text = "Ingrese numeros ";
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(289, 25);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(55, 20);
            lblDivisor.TabIndex = 19;
            lblDivisor.Text = "Divisor";
            lblDivisor.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDivisor);
            Controls.Add(lblIngreseNumeros);
            Controls.Add(btnAgregar);
            Controls.Add(txtIngreseNumeros);
            Controls.Add(txtDivisor);
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

        private Button btnAgregar;
        private TextBox txtIngreseNumeros;
        private TextBox txtDivisor;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label lblIngreseNumeros;
        private Label lblDivisor;
    }
}
