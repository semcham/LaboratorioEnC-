namespace Laboratorio8_Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> ListaNumeros = new List<int>();
        private List<int> OdernarMayorMenor(List<int> lista)
        {
            List<int> ListaOrdenda = lista.OrderBy(x => x).ToList();
            return ListaOrdenda;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListaNumeros = new List<int>();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de desordenada de numeros enteros " + Environment.NewLine);
            foreach (int i in ListaNumeros)
            {
                txtResultado.AppendText(i + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            txtResultado.AppendText("La lista ordenada de menor a mayor : " + Environment.NewLine);
            List<int> listaOrdenda = OdernarMayorMenor(ListaNumeros);
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
            int n = int.Parse(txtIngreseNumeros.Text);
            ListaNumeros.Add(n);
            MessageBox.Show("El lemento se agrego correctamente");
        }

        private void txtIngreseNumeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
