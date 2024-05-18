namespace Laboratorio8_Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> nummerosPositivos = new List<int>();
        private static List<int> ListaOrdenadaNumerosPrimosMayorMenor(List<int> lista)
        {
            List<int> numeros = new List<int>();
            foreach (int numero in lista)
            {
                if (Esprimo(numero))
                {
                    numeros.Add(numero);
                }
            }
            numeros.Sort((a, b) => b.CompareTo(a));
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
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            nummerosPositivos = new List<int>() { 1,2,3,137,21,51,5,31,78,12,87,41};

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros " + Environment.NewLine);
            foreach (int p in nummerosPositivos)
            {
                txtResultado.AppendText(p + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText(" lista de numeros primos de menor a mayor : " + Environment.NewLine);
            List<int> listaOrdenda = ListaOrdenadaNumerosPrimosMayorMenor(nummerosPositivos);
            foreach (int r in listaOrdenda)
            {
                txtResultado.AppendText(r + " ");

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

        private void txtIngreseNumeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
