namespace Laboratorio8_Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> listaPalabrasP = new List<string>();
        private List<string> PalabrasMismaLongitud(List<string> lista, int numero)
        {
            List<string> PalabrasConLongIgual = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Length == numero)
                {
                    PalabrasConLongIgual.Add(lista[i]);

                }
            }

            return PalabrasConLongIgual;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaPalabrasP = new List<string>();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string listaK = txtIngreseElemento.Text;
            listaPalabrasP.Add(listaK);
            MessageBox.Show("El elemento se agrego correctamente");


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseElemento.Clear();
            txtNumero.Clear();
            txtResultadoE.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultadoE.AppendText("Lista de Nombres: "+Environment.NewLine);
            foreach (string o in listaPalabrasP)
            {
                txtResultadoE.AppendText(o + " ");
            }
            txtResultadoE.AppendText(Environment.NewLine);
            txtResultadoE.AppendText("Las palabras con la misma longitud : "+Environment.NewLine);
            int numero = int.Parse(txtNumero.Text);
            List<string> PalabrasMismaLongitudQueNumeroIngresado = PalabrasMismaLongitud(listaPalabrasP, numero);
            foreach (string j in PalabrasMismaLongitudQueNumeroIngresado)
            {
                txtResultadoE.AppendText(j + " ");
            }
        }
    }
}
