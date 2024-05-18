namespace Laboratorio8_Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> listaPalabras = new List<string>();
        private List<string> EncontrarPalabrasPalindromasOrdenadosPorLongitudMayorMenor(List<string> listaP)
        {
            List<string> palabrasPalindromas = new List<string>();
            foreach (var palabra in listaP)
            {
                if (EsPalindromo(palabra))
                {
                    palabrasPalindromas.Add(palabra);
                }
            }

            return palabrasPalindromas.OrderByDescending(p => p.Length).ToList();
            bool EsPalindromo(string palabra)
            {
                int a = 0;
                int b = palabra.Length - 1;
                while (a < b)
                {
                    if (palabra[a] != palabra[b])
                    {
                        return false;
                    }
                    a++;
                    b--;
                }
                return true;

            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaPalabras = new List<string> { "oso", "reconocer", "ese", "lluvia", "calor", "ella", "ana" };

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de Palabras : " + Environment.NewLine);
            foreach (string p in listaPalabras)
            {
                txtResultado.AppendText(p + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("Las palabras palindromos son : " + Environment.NewLine);
            List<string> palindromos = EncontrarPalabrasPalindromasOrdenadosPorLongitudMayorMenor(listaPalabras);
            foreach (string f in palindromos)
            {
                txtResultado.AppendText(f + " ");
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
