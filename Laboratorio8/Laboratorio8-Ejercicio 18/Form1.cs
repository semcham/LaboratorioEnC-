namespace Laboratorio8_Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> listaPalAbras = new List<string>();
        private List<string> PalabrasLongitudMenorMayor(List<string> lista)
        {


            return lista.OrderByDescending(p => p.Length).ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaPalAbras = new List<string> { "Hola", "Manzana", "Luz", "Domingo", "Miercoles", "uva", "lados", "L" ,"colosal","Lo"};

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de palabras: " + Environment.NewLine);
            foreach (string t in listaPalAbras)
            {
                txtResultado.AppendText(t + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("Las palabras ordenadas de menor a mayor por su longitud: " + Environment.NewLine);
            List<string> PalabraslogMenorMayor = PalabrasLongitudMenorMayor(listaPalAbras);
            foreach (string i in PalabraslogMenorMayor)
            {
                txtResultado.AppendText(i + " ,");

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
