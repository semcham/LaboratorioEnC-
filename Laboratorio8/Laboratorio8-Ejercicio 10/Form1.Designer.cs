﻿namespace Laboratorio8_Ejercicio_10
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
            txtPalabra = new TextBox();
            label1 = new Label();
            txtLetra = new TextBox();
            lblLetra = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(169, 335);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 39);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar Elemento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(29, 46);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(125, 27);
            txtPalabra.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "Palabra";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(215, 46);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(125, 27);
            txtLetra.TabIndex = 16;
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(255, 18);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(42, 20);
            lblLetra.TabIndex = 15;
            lblLetra.Text = "Letra";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(561, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(384, 345);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(29, 94);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(657, 218);
            txtResultado.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 335);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 39);
            btnCalcular.TabIndex = 11;
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

        private Button btnAgregar;
        private TextBox txtPalabra;
        private Label label1;
        private TextBox txtLetra;
        private Label lblLetra;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtResultado;
        private Button btnCalcular;
    }
}
