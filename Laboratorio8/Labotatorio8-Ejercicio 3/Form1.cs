using System;
using System.Security.Cryptography.X509Certificates;

namespace Labotatorio8_Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private List<int> listaNumerosEnteros = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumerosEnteros = new List<int>();
        }
        //Funcion para calcular apartir de una lista inicial en la cual divides los elemetos
        // de esa lista por un numero y devuelve los numeros que son divisibles por ese numero.
        private List<int> ObtenerNumerosDivididos(List<int> listaNumerosEnteros, int divisor)
        {
            List<int> listaNumerosDivididosPorUnNumero = new List<int>();
            foreach (int numero in listaNumerosEnteros)
            {
                if (numero % divisor == 0)
                {
                    listaNumerosDivididosPorUnNumero.Add(numero);
                }
            }
            return listaNumerosDivididosPorUnNumero;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtResultado.AppendText("Lista Inicial de Numeros Enteros  :  " + Environment.NewLine);
            foreach (int t in listaNumerosEnteros)
            {

                txtResultado.AppendText(t + " ");
            }
            txtResultado.AppendText(Environment.NewLine);
            int divisor = int.Parse(txtDivisor.Text);
            txtResultado.AppendText($"La Lista de numeros enteros que son divisbles por este numero'{txtDivisor.Text}'  son :  " + Environment.NewLine);
            List<int> listaNumDividos = ObtenerNumerosDivididos(listaNumerosEnteros, divisor);
            foreach (int k in listaNumDividos)
            {
                txtResultado.AppendText(k + " ");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtIngreseNumeros.Text);
            listaNumerosEnteros.Add(n);
            MessageBox.Show("El numero se agrego a la lista con exito");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseNumeros.Clear();
            txtDivisor.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtIngreseNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
