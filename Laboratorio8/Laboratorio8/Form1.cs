namespace Laboratorio8
{
    public partial class Form1 : Form
    {
        Nombres nombres;
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> ListaNombres = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

            ListaNombres = new List<string>();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         
            var busqueda = ListaNombres.Where(x => x.Contains(txtLetra.Text.ToUpper())).ToList();
            int cantidad = ListaNombres.Count();
            txtResultado.AppendText("Lista  Completa :  "+Environment.NewLine);
            foreach (string t in ListaNombres)
            {
                txtResultado.AppendText(t +" ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("la cantidad de elementos de la Lista es : " + cantidad + Environment.NewLine);

            txtResultado.AppendText($"La Lista con al Letra Inicial '{ txtLetra.Text.ToUpper()}' : " +Environment.NewLine);
            foreach (string j in busqueda)
            {
                txtResultado.AppendText(j + " ");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtLetra.Clear();
            txtPalabra.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLetra_Click(object sender, EventArgs e)
        {

        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string input = txtPalabra.Text;
            string resultado = char.ToUpper(input[0])+input.Substring(1);
            txtPalabra.Text = resultado;
            ListaNombres.Add(resultado);
            MessageBox.Show("El Elemento se agrego a la lista con exito");

        }
    }
}
