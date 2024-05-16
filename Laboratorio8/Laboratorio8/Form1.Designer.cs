namespace Laboratorio8
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
            btnCalcular = new Button();
            txtResultado = new TextBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblLetra = new Label();
            txtLetra = new TextBox();
            txtPalabra = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(41, 326);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(41, 85);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(396, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(573, 336);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(263, 0);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(42, 20);
            lblLetra.TabIndex = 6;
            lblLetra.Text = "Letra";
            lblLetra.Click += lblLetra_Click;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(227, 37);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(125, 27);
            txtLetra.TabIndex = 7;
            txtLetra.TextChanged += txtLetra_TextChanged;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(41, 37);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(125, 27);
            txtPalabra.TabIndex = 9;
            txtPalabra.TextChanged += txtTexto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 8;
            label1.Text = "Palabra";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(181, 326);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 39);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar Elemento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtPalabra);
            Controls.Add(label1);
            Controls.Add(txtLetra);
            Controls.Add(lblLetra);
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
        private Button btnCalcular;
        private TextBox txtResultado;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblLetra;
        private TextBox txtLetra;
        private TextBox txtPalabra;
        private Label label1;
        private Button btnAgregar;
    }
}
