namespace Laboratorio8_Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> ListaNumerosEnteros = new List<int>();
        private List<int> OdenarMayorMenor(List<int> lista)
        {
            List<int> ListaordendaDecentemente = lista.OrderByDescending(x => x).ToList();
            return ListaordendaDecentemente;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListaNumerosEnteros = new List<int>();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de desordenada de numeros enteros " + Environment.NewLine);
            foreach (int i in ListaNumerosEnteros)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("La lista ordenada de mayor a menor : " + Environment.NewLine);
            List<int> listaOrdenda = OdenarMayorMenor(ListaNumerosEnteros);
            foreach (int k in listaOrdenda)
            {
                txtResultado.AppendText(k + " ");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtIngreseNumeros.Text);
            ListaNumerosEnteros.Add(n);
            MessageBox.Show("El lemento se agrego correctamente");
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
    }
}
