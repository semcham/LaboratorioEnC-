namespace Laboratorio8_Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> numerosEnteros = new List<int>();

        private List<int> ListaOrdenadaNumerosPrimos(List<int> lista)
        {
            List<int> numeros = new List<int>();
            foreach (int numero in lista)
            {
                if (Esprimo(numero))
                {
                    numeros.Add(numero);
                }
            }
            numeros.Sort();
            bool Esprimo(int numero)
            {
                bool esprimo = true;
                if (numero <= 1)
                {
                    return false;

                }
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esprimo = false;

                    }

                }
                return esprimo;
            }
            return numeros;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numerosEnteros = new List<int>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros " + Environment.NewLine);
            foreach (int i in numerosEnteros)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText(" lista de numeros primos de menor a mayor : " + Environment.NewLine);
            List<int> listaOrdenda = ListaOrdenadaNumerosPrimos(numerosEnteros);
            foreach (int k in listaOrdenda)
            {
                txtResultado.AppendText(k + " ");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseNumeros.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int y = int.Parse(txtIngreseNumeros.Text);
            numerosEnteros.Add(y);
            MessageBox.Show("El lemento se agrego correctamente");
        }
    }
}
