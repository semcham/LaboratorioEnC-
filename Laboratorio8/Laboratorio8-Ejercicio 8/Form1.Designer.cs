namespace Laboratorio8_Ejercicio8
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
            lblIngreseNumeros = new Label();
            btnAgregar = new Button();
            txtIngreseElementosLista = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblIngreseNumeros
            // 
            lblIngreseNumeros.AutoSize = true;
            lblIngreseNumeros.Location = new Point(37, 9);
            lblIngreseNumeros.Name = "lblIngreseNumeros";
            lblIngreseNumeros.Size = new Size(195, 20);
            lblIngreseNumeros.TabIndex = 61;
            lblIngreseNumeros.Text = "Ingrese Elementos para lista";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(58, 349);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 39);
            btnAgregar.TabIndex = 60;
            btnAgregar.Text = "Agregar Elemento a la Lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreseElementosLista
            // 
            txtIngreseElementosLista.Location = new Point(47, 60);
            txtIngreseElementosLista.Name = "txtIngreseElementosLista";
            txtIngreseElementosLista.Size = new Size(125, 27);
            txtIngreseElementosLista.TabIndex = 59;
            txtIngreseElementosLista.TextChanged += txtIngreseElementosLista_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(581, 349);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 39);
            btnSalir.TabIndex = 58;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(442, 349);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 39);
            btnLimpiar.TabIndex = 57;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(47, 93);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 56;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(290, 349);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 55;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIngreseNumeros);
            Controls.Add(btnAgregar);
            Controls.Add(txtIngreseElementosLista);
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

        private Label lblIngreseNumeros;
        private Button btnAgregar;
        private TextBox txtIngreseElementosLista;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultado;
        private Button btnCalcular;
    }
}
