namespace Laboratorio7_Ejemplo1
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
            txtCodigo = new TextBox();
            label1 = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            cboCondicionContrato = new ComboBox();
            cboEspecialidad = new ComboBox();
            label3 = new Label();
            cboTipoActividad = new ComboBox();
            label4 = new Label();
            cboTipoAfiliacion = new ComboBox();
            label5 = new Label();
            txtResultado = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(1, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(185, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombres_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, -4);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 5;
            label2.Text = "Condicion de Contrato";
            // 
            // cboCondicionContrato
            // 
            cboCondicionContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicionContrato.FormattingEnabled = true;
            cboCondicionContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboCondicionContrato.Location = new Point(426, 19);
            cboCondicionContrato.Name = "cboCondicionContrato";
            cboCondicionContrato.Size = new Size(151, 28);
            cboCondicionContrato.TabIndex = 12;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hidricos" });
            cboEspecialidad.Location = new Point(613, 73);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(151, 28);
            cboEspecialidad.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(671, 50);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 13;
            label3.Text = "Especialidad";
            // 
            // cboTipoActividad
            // 
            cboTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoActividad.FormattingEnabled = true;
            cboTipoActividad.Items.AddRange(new object[] { "SO", "SV" });
            cboTipoActividad.Location = new Point(426, 73);
            cboTipoActividad.Name = "cboTipoActividad";
            cboTipoActividad.Size = new Size(151, 28);
            cboTipoActividad.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 50);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 15;
            label4.Text = "Tipo de Actividad";
            // 
            // cboTipoAfiliacion
            // 
            cboTipoAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoAfiliacion.FormattingEnabled = true;
            cboTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoAfiliacion.Location = new Point(625, 19);
            cboTipoAfiliacion.Name = "cboTipoAfiliacion";
            cboTipoAfiliacion.Size = new Size(151, 28);
            cboTipoAfiliacion.TabIndex = 18;
            cboTipoAfiliacion.SelectedIndexChanged += cboTipoAfiliación_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, -4);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 17;
            label5.Text = "Tipo de Afiliación";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(35, 100);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(741, 304);
            txtResultado.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(650, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(532, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(196, 410);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(252, 29);
            btnMostrar.TabIndex = 21;
            btnMostrar.Text = "Mostrar Informacion Del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(44, 409);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(127, 29);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Crear Objetos";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboTipoAfiliacion);
            Controls.Add(label5);
            Controls.Add(cboTipoActividad);
            Controls.Add(label4);
            Controls.Add(cboEspecialidad);
            Controls.Add(label3);
            Controls.Add(cboCondicionContrato);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cboCondicionContrato;
        private ComboBox cboEspecialidad;
        private Label label3;
        private ComboBox cboTipoActividad;
        private Label label4;
        private ComboBox cboTipoAfiliacion;
        private Label label5;
        private TextBox txtResultado;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnCrear;
    }
}
