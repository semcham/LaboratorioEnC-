namespace Laboratorio8_Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> palabras = new List<string>();
        private List<string> PalabrasAnagramas(List<string> listapalabras)
        {
            var anagramas = new List<string>();
            for (int i = 0; i < palabras.Count; i++)
            {
                // Ordenar los caracteres de la palabra para obtener la firma
                var firmaActual = new string(palabras[i].OrderBy(c => c).ToArray());

                // Buscar si ya se ha encontrado un anagrama para esta firma
                bool encontrado = false;
                for (int j = 0; j < anagramas.Count; j++)
                {
                    var firmaAnagrama = new string(anagramas[j].OrderBy(c => c).ToArray());
                    if (firmaActual == firmaAnagrama)
                    {
                        encontrado = true;
                        break;
                    }
                }

                // Si no se ha encontrado un anagrama, añadir la palabra actual a la lista de anagramas
                if (!encontrado)
                {
                    anagramas.Add(palabras[i]);
                }
            }

            return anagramas;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            palabras = new List<string>();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseElementos.Clear();
            txtResultados.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string listaP = txtIngreseElementos.Text;
            palabras.Add(listaP);
            MessageBox.Show("El palabra ingresada se agrego correctamnente a la lista");


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultados.AppendText("Lista de palabras  :  " + Environment.NewLine);
            foreach (string t in palabras)
            {

                txtResultados.AppendText(t + " ,");
            }
            txtResultados.AppendText(Environment.NewLine);

            List<string> anagramaP = PalabrasAnagramas(palabras);
            txtResultados.AppendText("las palabras anagramas son : " + Environment.NewLine);
            foreach (var palabra in anagramaP)
            {
                txtResultados.AppendText(palabra + " ");
            }


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblIngreseNumeros_Click(object sender, EventArgs e)
        {

        }

        private void txtResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngreseElementos_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
