namespace Laboratorio7_Ejemplo2
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnCrear = new Button();
            txtResultado = new TextBox();
            cboCargo = new ComboBox();
            label4 = new Label();
            cboArea = new ComboBox();
            label3 = new Label();
            lblNombres = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtDni = new TextBox();
            txtAñosAntiguedad = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(662, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(544, 417);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(208, 418);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(252, 29);
            btnMostrar.TabIndex = 38;
            btnMostrar.Text = "Mostrar Informacion Del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(56, 417);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(127, 29);
            btnCrear.TabIndex = 37;
            btnCrear.Text = "Crear Objetos";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(15, 83);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(741, 304);
            txtResultado.TabIndex = 36;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(456, 28);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(122, 28);
            cboCargo.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 4);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 32;
            label4.Text = "Cargo";
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificacion" });
            cboArea.Location = new Point(595, 28);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 9);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 30;
            label3.Text = "Area";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(176, 4);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 27;
            lblNombres.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 4);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 25;
            label1.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(1, 28);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 24;
            // 
            // txtAñosAntiguedad
            // 
            txtAñosAntiguedad.Location = new Point(312, 26);
            txtAñosAntiguedad.Name = "txtAñosAntiguedad";
            txtAñosAntiguedad.Size = new Size(125, 27);
            txtAñosAntiguedad.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 3);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 42;
            label2.Text = "Años de Antiguedad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAñosAntiguedad);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboCargo);
            Controls.Add(label4);
            Controls.Add(cboArea);
            Controls.Add(label3);
            Controls.Add(lblNombres);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtDni);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.DimGray;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnCrear;
        private TextBox txtResultado;
        private ComboBox cboTipoAfiliacion;
        private Label label5;
        private ComboBox cboCargo;
        private Label label4;
        private ComboBox cboArea;
        private Label label3;
        private Label lblNombres;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtDni;
        private TextBox txtAñosAntiguedad;
        private Label label2;
    }
}
