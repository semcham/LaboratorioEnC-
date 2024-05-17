namespace Laboratorio8_Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> ListaPalabras = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListaPalabras = new List<string>();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string t = txtPalabra.Text.ToUpper();
            txtPalabra.Text = t;
            ListaPalabras.Add(t);
            MessageBox.Show("El Elemento se agrego a la lista con exito");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            var busqueda = ListaPalabras.Where(x => x.Contains(txtLetra.Text.ToUpper())).ToList();
            int cantidad = ListaPalabras.Count();
            txtResultado.AppendText("Lista  Completa :  " + Environment.NewLine);
            foreach (string t in ListaPalabras)
            {
                txtResultado.AppendText(t + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("la cantidad de elementos de la Lista es : " + cantidad + Environment.NewLine);

            txtResultado.AppendText($"La Lista de palabras que contengan la letra '{txtLetra.Text.ToUpper()}' son  : " + Environment.NewLine);
            foreach (string j in busqueda)
            {
                txtResultado.AppendText(j + " ");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLetra.Clear();
            txtResultado.Clear();
            txtPalabra.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            string p = txtLetra.Text.ToUpper();

        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
