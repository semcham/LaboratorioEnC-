namespace Laboratorio8_Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> listaNumeros1 = new List<int>();
        private List<int> listaNumeros2 = new List<int>();
        private List<int> Diferencia(List<int> lista1, List<int> lista2)
        {
            var difenciaElementos = lista1.Except(lista2).ToList();
            return difenciaElementos;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumeros1 = new List<int>();
            listaNumeros1 = new List<int>();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros de la Lista 1  :  " + Environment.NewLine);
            foreach (int t in listaNumeros1)
            {

                txtResultado.AppendText(t + " ,");
            }
            txtResultado.AppendText(Environment.NewLine);

            txtResultado.AppendText("Lista de numeros enteros de la Lista 2 :  " + Environment.NewLine);
            foreach (int s in listaNumeros2)
            {

                txtResultado.AppendText(s + " ,");

            }
            txtResultado.AppendText(Environment.NewLine);
            List<int> difenecia = Diferencia(listaNumeros1, listaNumeros2);
            txtResultado.AppendText("La difenecia de Elementos  de las Lista 1 y Lista 2 es : " + Environment.NewLine);
            foreach (int j in difenecia)
            {
                txtResultado.AppendText(j + " ,");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseElementosLista1.Clear();
            txtIngreseElementosLista2.Clear();
            txtResultado.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int lista1 = int.Parse(txtIngreseElementosLista1.Text);
            int lista2 = int.Parse(txtIngreseElementosLista2.Text);
            listaNumeros1.Add(lista1);
            listaNumeros2.Add(lista2);
            MessageBox.Show("Los elementos de numeros enteros se agregaron a sus respectivas listas correctamnente");

        }
    }
}
