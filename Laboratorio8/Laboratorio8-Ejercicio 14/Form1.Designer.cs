﻿namespace Laboratorio8_Ejercicio_14;

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
        btnSalir = new Button();
        btnLimpiar = new Button();
        txtResultado = new TextBox();
        btnCalcular = new Button();
        SuspendLayout();
        // 
        // btnSalir
        // 
        btnSalir.Location = new Point(574, 296);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(94, 39);
        btnSalir.TabIndex = 43;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(397, 296);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(94, 39);
        btnLimpiar.TabIndex = 42;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // txtResultado
        // 
        txtResultado.Location = new Point(42, 55);
        txtResultado.Multiline = true;
        txtResultado.Name = "txtResultado";
        txtResultado.Size = new Size(657, 218);
        txtResultado.TabIndex = 41;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(60, 296);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(101, 39);
        btnCalcular.TabIndex = 40;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
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

    private Button btnSalir;
    private Button btnLimpiar;
    private TextBox txtResultado;
    private Button btnCalcular;
}
