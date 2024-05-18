namespace Laboratorio8_Ejercicio_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> listaNumerosenteros = new List<int>();
        private List<int> ObtenerNumerosNoDuplicados(List<int> lista)
        {
            List<int> numerosNoDuplicados = new List<int>();
            HashSet<int> duplicados = new HashSet<int>();

            foreach (int num in lista)
            {
                if (!duplicados.Contains(num))
                {
                    if (numerosNoDuplicados.Contains(num))
                    {
                        numerosNoDuplicados.Remove(num);
                        duplicados.Add(num);
                    }
                    else
                    {
                        numerosNoDuplicados.Add(num);
                    }
                }
            }

            return numerosNoDuplicados;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumerosenteros = new List<int> { 1, 2, 3, 4, 20, 4, 1, 6, 7, 8, 3, 6, 9, 10 };
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros " + Environment.NewLine);
            foreach (int i in listaNumerosenteros)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText(" lista de numeros no duplicados  : " + Environment.NewLine);
            List<int> listaOrdenda = ObtenerNumerosNoDuplicados(listaNumerosenteros);
            foreach (int k in listaOrdenda)
            {
                txtResultado.AppendText(k + " ");

            }
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
