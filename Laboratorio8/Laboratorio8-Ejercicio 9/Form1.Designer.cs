namespace Laboratorio8_Ejercicio_9
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
            txtIngreseElemento = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultadoE = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // lblIngreseNumeros
            // 
            lblIngreseNumeros.AutoSize = true;
            lblIngreseNumeros.Location = new Point(41, 3);
            lblIngreseNumeros.Name = "lblIngreseNumeros";
            lblIngreseNumeros.Size = new Size(195, 20);
            lblIngreseNumeros.TabIndex = 68;
            lblIngreseNumeros.Text = "Ingrese Elementos para lista";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(62, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(213, 39);
            btnAgregar.TabIndex = 67;
            btnAgregar.Text = "Agregar Elemento a la Lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreseElemento
            // 
            txtIngreseElemento.Location = new Point(51, 54);
            txtIngreseElemento.Name = "txtIngreseElemento";
            txtIngreseElemento.Size = new Size(125, 27);
            txtIngreseElemento.TabIndex = 66;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(585, 343);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 39);
            btnSalir.TabIndex = 65;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(446, 343);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 39);
            btnLimpiar.TabIndex = 64;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultadoE
            // 
            txtResultadoE.Location = new Point(51, 87);
            txtResultadoE.Multiline = true;
            txtResultadoE.Name = "txtResultadoE";
            txtResultadoE.Size = new Size(657, 218);
            txtResultadoE.TabIndex = 63;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(294, 343);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 62;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 70;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(370, 54);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 69;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(lblIngreseNumeros);
            Controls.Add(btnAgregar);
            Controls.Add(txtIngreseElemento);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(txtResultadoE);
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
        private TextBox txtIngreseElemento;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultadoE;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtNumero;
    }
}
