namespace Laboratorio8_Ejercicio_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> listaPalabrasPa = new List<string>();
        private List<string> PalabrasLongitudMayorMenor(List<string> lista)
        {


            return lista.OrderBy(p => p.Length).ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaPalabrasPa = new List<string> { "Hola", "Manzana", "Luz", "Domingo", "Miercoles", "uva" };

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de palabras: " + Environment.NewLine);
            foreach (string a in listaPalabrasPa)
            {
                txtResultado.AppendText(a + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("Las palabras ordenadas de menor a mayor por su longitud: " + Environment.NewLine);
            List<string> palabrasLongMayorMenor = PalabrasLongitudMayorMenor(listaPalabrasPa);
            foreach (string j in palabrasLongMayorMenor)
            {
                txtResultado.AppendText(j + " ");

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
