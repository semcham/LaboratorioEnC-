namespace Laboratorio8_Ejercicio_11
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
            label1 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(61, 337);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 39);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar Elemento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreseNumeros
            // 
            txtIngreseNumeros.Location = new Point(61, 38);
            txtIngreseNumeros.Name = "txtIngreseNumeros";
            txtIngreseNumeros.Size = new Size(125, 27);
            txtIngreseNumeros.TabIndex = 27;
            txtIngreseNumeros.TextChanged += txtIngreseNumeros_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 26;
            label1.Text = "ingrese numeros a la lista";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(593, 337);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(416, 337);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(61, 86);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 21;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(235, 337);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtIngreseNumeros);
            Controls.Add(label1);
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
        private Label label1;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultado;
        private Button btnCalcular;
    }
}
