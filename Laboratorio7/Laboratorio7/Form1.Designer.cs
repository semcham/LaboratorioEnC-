namespace Laboratorio7
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
            label1 = new Label();
            cboTipoSeguro = new ComboBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtSueldo = new TextBox();
            label3 = new Label();
            txtHorasExtras = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "codigo";
            // 
            // cboTipoSeguro
            // 
            cboTipoSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSeguro.FormattingEnabled = true;
            cboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoSeguro.Location = new Point(585, 32);
            cboTipoSeguro.Name = "cboTipoSeguro";
            cboTipoSeguro.Size = new Size(151, 28);
            cboTipoSeguro.TabIndex = 1;
            cboTipoSeguro.SelectedIndexChanged += cboTipoSeguro_SelectedIndexChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(3, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(3, 85);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 6;
            txtSueldo.TextChanged += txtSueldo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 62);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Sueldo";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(214, 85);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(125, 27);
            txtHorasExtras.TabIndex = 8;
            txtHorasExtras.TextChanged += txtHorasExtras_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 62);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Horas Extras";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 9);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 9;
            label5.Text = "Tipo Seguro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 63);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 11;
            label6.Text = "Area";
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Administracion", "Informatica", "Contabilidad" });
            cboArea.Location = new Point(585, 84);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 12;
            cboArea.SelectedIndexChanged += cboArea_SelectedIndexChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 129);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(724, 260);
            txtResultado.TabIndex = 13;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(36, 395);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(127, 29);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear Objetos";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(180, 395);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(252, 29);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar Informacion Del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(526, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(642, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            Controls.Add(cboArea);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHorasExtras);
            Controls.Add(label4);
            Controls.Add(txtSueldo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(cboTipoSeguro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipoSeguro;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtSueldo;
        private Label label3;
        private TextBox txtHorasExtras;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
