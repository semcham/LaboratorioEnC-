namespace Laboratorio8_Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> listaNumerosEnteros1 = new List<int>();
        private List<int> listaNumerosEnteros2 = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumerosEnteros1 = new List<int>();
            listaNumerosEnteros2 = new List<int>();

        }
        private List<int> ObtenerElementosComunes(List<int> lista1, List<int> lista2)
        {
            var elementosComunes = lista1.Intersect(lista2).ToList();
            return elementosComunes;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int lista1 = int.Parse(txtIngreseElementosLista1.Text);
            int lista2 = int.Parse(txtIngreseElementosLista2.Text);
            listaNumerosEnteros1.Add(lista1);
            listaNumerosEnteros2.Add(lista2);
            MessageBox.Show("Los elementos de numeros enteros se agregaron a sus respectivas listas correctamnente");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtResultado.AppendText("Lista de numeros enteros de la Lista 1  :  " + Environment.NewLine);
            foreach (int t in listaNumerosEnteros1)
            {

                txtResultado.AppendText(t + " ,");
            }
            txtResultado.AppendText(Environment.NewLine);

            txtResultado.AppendText("Lista de numeros enteros de la Lista 2 :  " + Environment.NewLine);
            foreach (int s in listaNumerosEnteros2)
            {

                txtResultado.AppendText(s + " ,");

            }
            txtResultado.AppendText(Environment.NewLine);
            List<int> ElementosComunes = ObtenerElementosComunes(listaNumerosEnteros1 , listaNumerosEnteros2);
            txtResultado.AppendText("Los Elementos Comunes de las Lista 1 y Lista 2 es : "+Environment.NewLine);
            foreach (int j in ElementosComunes)
            {
                txtResultado.AppendText (j + " ,");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseElementosLista1.Clear();
            txtIngreseElementosLista2.Clear();
            txtResultado.Clear();
        }
    }
}
