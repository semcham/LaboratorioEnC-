namespace Laboratorio8_Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> listaNum1 = new List<int>();
        private List<int> listaNum2 = new List<int>();
        private List<int> Diferencia(List<int> lista1, List<int> lista2)
        {
            var difenciaElementos = lista2.Except(lista1).ToList();
            return difenciaElementos;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaNum1 = new List<int>();
            listaNum2 = new List<int>();

        }

        private void txtResultado_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int list1 = int.Parse(txtIngreseElementosLista1.Text);
            int list2 = int.Parse(txtIngreseElementosLista2.Text);
            listaNum1.Add(list1);
            listaNum2.Add(list2);
            MessageBox.Show("Los elementos de numeros enteros se agregaron a sus respectivas listas correctamnente");

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            txtResultado.AppendText("Lista de numeros enteros de la Lista 1  :  " + Environment.NewLine);
            foreach (int t in listaNum1)
            {

                txtResultado.AppendText(t + " ,");
            }
            txtResultado.AppendText(Environment.NewLine);

            txtResultado.AppendText("Lista de numeros enteros de la Lista 2 :  " + Environment.NewLine);
            foreach (int s in listaNum2)
            {

                txtResultado.AppendText(s + " ,");

            }
            txtResultado.AppendText(Environment.NewLine);
            List<int> difenecia = Diferencia(listaNum1, listaNum2);
            txtResultado.AppendText("La difenecia de Elementos  de las Lista 2 y Lista 1 es : " + Environment.NewLine);
            foreach (int j in difenecia)
            {
                txtResultado.AppendText(j + " ,");
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtIngreseElementosLista1.Clear();
            txtIngreseElementosLista2.Clear();
            txtResultado.Clear();

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
