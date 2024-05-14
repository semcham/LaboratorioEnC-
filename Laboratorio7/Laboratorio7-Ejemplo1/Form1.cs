namespace Laboratorio7_Ejemplo1
{
    public partial class Form1 : Form
    {

        Arquitecto arquitecto;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            string Nombre = txtNombre.Text; 
            string seguro = cboTipoAfiliacion.Text; 
            string Especialidad = cboEspecialidad.Text;
            string CondicionContrato = cboCondicionContrato.Text;
            string TipoActividad = cboTipoActividad.Text;

            arquitecto = new Arquitecto(Codigo, Nombre, CondicionContrato, Especialidad, TipoActividad, seguro); // Corregido el orden de los parámetros
            MessageBox.Show("Objeto Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Objeto Nro: " + Arquitecto.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombres: " + arquitecto.Nombres + Environment.NewLine);
            txtResultado.AppendText("Tipo de Afiliacion: " + arquitecto.TipoAfiliacion + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + arquitecto.calcularSueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Condicion de contrato : " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Tipo de Actividad: " + arquitecto.TipoActividad + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + arquitecto.calcularBonificacion() + Environment.NewLine);
            txtResultado.AppendText("Monto de Seguro: " + arquitecto.CalcularMontoSeguro() + Environment.NewLine);
            txtResultado.AppendText("Monto de Essalud: " + arquitecto.CalcularMontoEssalud() + Environment.NewLine);
            txtResultado.AppendText("Monto de Descuento: " + arquitecto.CalularDescuento() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto() + Environment.NewLine);
        }

        private void cboTipoAfiliación_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtResultado.Clear();
            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

