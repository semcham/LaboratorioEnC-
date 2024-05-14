namespace Laboratorio7_Ejemplo2
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los campos
            decimal Dni = decimal.Parse(txtDni.Text);
            string nombres = txtNombre.Text;
            string cargo = cboCargo.Text;
            decimal a�osAntiguedad = decimal.Parse(txtA�osAntiguedad.Text);
            string area = cboArea.Text;
            jefe = new Jefe(Dni, nombres, cargo, area, a�osAntiguedad);
            MessageBox.Show("Objeto Jefe Creado Exitosamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            txtResultado.AppendText("Objeto Nro: " + Jefe.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("DNI: " + jefe.DNI + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + jefe.Nombres + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("A�os de Antiguedad: " + jefe.A�osAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + jefe.CalcularSueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + jefe.CalcularBonificacion() + Environment.NewLine);
            txtResultado.AppendText("Movilidad : " + jefe.calcularMontoMovilidad() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal() + Environment.NewLine);
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Text = string.Empty;
            txtNombre.Clear();
            txtA�osAntiguedad.Clear();
            txtResultado.Clear();
            txtDni.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
