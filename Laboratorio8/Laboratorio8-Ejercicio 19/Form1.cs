namespace Laboratorio8_Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> listaNumerosEnterosPositivos = new List<int>();
        private List<int> ObtenerNumerosNoDuplicadosOrdenadosMayorMenor(List<int> lista)
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
            numerosNoDuplicados.Sort();

            return numerosNoDuplicados;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumerosEnterosPositivos = new List<int> { 45, 2, 20, 12, 40, 35, 1, 3, 6, 21, 3, 40, 35, 2, 8, 5, 9, 37, 5, 60, 100, 21, 100 };

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros " + Environment.NewLine);
            foreach (int i in listaNumerosEnterosPositivos)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText(" lista de numeros no duplicados ordenados de menor a mayor : " + Environment.NewLine);
            List<int> listaOrdenda = ObtenerNumerosNoDuplicadosOrdenadosMayorMenor(listaNumerosEnterosPositivos);
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
