namespace Laboratorio8_Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> listaNumerosEnteros = new List<int>();
        private List<int> ObtenerNumerosDuplicados(List<int> listaNumeros)
        {
            List<int> vistos = new List<int>();
            List<int> duplicados = new List<int>();

            foreach (int numero in listaNumeros)
            {
                if (vistos.Contains(numero))
                {
                    if (!duplicados.Contains(numero))
                    {
                        duplicados.Add(numero);
                    }
                }
                else
                {
                    vistos.Add(numero);
                }
            }

            return duplicados;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumerosEnteros = new List<int> { 1, 2, 3, 10,1,3,4,4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros " + Environment.NewLine);
            foreach (int i in listaNumerosEnteros)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText(" lista de numeros duplicados  : " + Environment.NewLine);
            List<int> listaOrdenda = ObtenerNumerosDuplicados(listaNumerosEnteros);
            foreach (int k in listaOrdenda)
            {
                txtResultado.AppendText(k + " ");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
