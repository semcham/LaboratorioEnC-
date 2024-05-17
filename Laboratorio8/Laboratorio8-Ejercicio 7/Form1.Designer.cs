

namespace Laboratorio8_Ejercicio_7
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
            lblIElementos = new Label();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtIngreseElementos = new TextBox();
            txtResultados = new TextBox();
            SuspendLayout();
            // 
            // lblIElementos
            // 
            lblIElementos.AutoSize = true;
            lblIElementos.Location = new Point(72, 33);
            lblIElementos.Name = "lblIElementos";
            lblIElementos.Size = new Size(195, 20);
            lblIElementos.TabIndex = 54;
            lblIElementos.Text = "Ingrese Elementos para lista";
            lblIElementos.Click += lblIngreseNumeros_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(83, 373);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 39);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "Agregar Elemento a la Lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(606, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 39);
            btnSalir.TabIndex = 50;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(467, 373);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 39);
            btnLimpiar.TabIndex = 49;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(315, 373);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 47;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtIngreseElementos
            // 
            txtIngreseElementos.Location = new Point(72, 69);
            txtIngreseElementos.Name = "txtIngreseElementos";
            txtIngreseElementos.Size = new Size(125, 27);
            txtIngreseElementos.TabIndex = 61;
            txtIngreseElementos.TextChanged += txtIngreseElementos_TextChanged;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(72, 102);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(657, 218);
            txtResultados.TabIndex = 60;
            txtResultados.TextChanged += txtResultados_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIngreseElementos);
            Controls.Add(txtResultados);
            Controls.Add(lblIElementos);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion
        private Label lblIElementos;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtIngreseElementos;
        private TextBox txtResultados;
    }
}
