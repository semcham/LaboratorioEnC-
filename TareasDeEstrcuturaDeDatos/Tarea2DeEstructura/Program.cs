

//4.Desarrollo y Actividades Ejercicio: 
/*
//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 
int n = 100;
int numerosPares(int n)
{
    int y = 2;
    while (y<n)
    {
        Console.WriteLine(" "+y+"");
            y += 2;
    }return y;
  
}
int numeros = numerosPares(n);
Console.WriteLine(numeros + "");
Console.ReadLine();
*/
//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 
/*
Console.Write("Ingrese un numero entero positivo:");
int n = int.Parse(Console.ReadLine());
int sumatoria = sumatoriaN(n);
int sumatoriaN(int n)
{
    if (n==0)
    {
        return 0;
    }
    else
    {
        return n + sumatoriaN(n - 1);
    }
}
Console.WriteLine("La sumatoria de los {0} numeros naturales es : {1}",n,sumatoria);
*/
//3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
using System.Text;
public class recursividad
{
    public void PiramideDeNumeros(int numLimitador, int longitud)
    {
        if (numLimitador > 0)
        {
            string escalonVacio = new string(' ', numLimitador - 1);
            string numeroEscalon = new StringBuilder(numLimitador.ToString().Length * longitud).Insert(0, numLimitador.ToString(), longitud).ToString();

            Console.WriteLine(escalonVacio + numeroEscalon);
            PiramideDeNumeros(numLimitador - 1, longitud + 2);
        }
    }

}



//4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n. 

//Arreglos y Matrices: 
//6) Crea una matriz de números reales. 
//7) Crea una matriz de números complejos. 
//8) Crea una matriz de matrices. 
//9) Accede al elemento central de una matriz. 
//10) Suma dos matrices de diferentes tamaños. 
//11) Multiplica una matriz por un número. 
//12) Calcula la media de los elementos de una matriz. 

//Ejercicio Matrices: 
/*
//Ejercicio 1: 
//Crea una matriz de números aleatorios de tamaño 100x100. 

int[,]MatrizAleatorioN = new int[100, 100];
Random r = new Random();
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        MatrizAleatorioN[i, j] = r.Next(1, 9);
        Console.Write(MatrizAleatorioN[i, j]);
    }
    Console.WriteLine(" ");
}
/*
//Ejercicio 2: 
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 
Console.WriteLine("======================Calcular : media,mediana,desviacion estandar============");
double media, mediana, desEstabdar;
int[,] Matriz = new int[6,6 ];
media = 0;
int longitudM = Matriz.Length;
Random t = new Random();
for (int i = 0; i < 6; i++) //creamos una matriz de 6x6 con numeros aleatorios
{
    for (int j = 0; j < 6; j++)
    {
        Matriz[i, j] = t.Next(1, 9);//generamos numeros aleatorios del 1 al 9
        Console.Write(Matriz[i, j]);
    }
    Console.WriteLine();
}
Console.Read();
// media
for (int a = 0;a <6; a++)
    for (int b = 0;b <6; b++)
    {
        media += Matriz[a, b];

    }
{
}
double resultado = media / longitudM;
Console.WriteLine("La media es: " + Math.Round(resultado, 2));
//mediana
List<int> lista = new List<int>(); //creamos una lista
int filas = Matriz.GetLength(0);
int columnas = Matriz.GetLength(1);
for (int i = 0;i < filas; i++)
{
    for(int j = 0;j < columnas; j++)
    {
        lista.Add(Matriz[i, j]);//agregamos los elementos de la matriz a la lista
    }
}
lista.Sort();//ordenamos la lista de menor a mayor
int lonLista = lista.Count;//El tamaño de la lista

if (lonLista%2== 0)
{
    double sumaMedia = (lista[(lonLista/2)-1]+ lista[(lonLista/2)]);
    mediana = sumaMedia / 2;

    Console.WriteLine("La mediana es :"+ mediana);

}
else
{
    mediana = lista[(lonLista / 2)];
    Console.WriteLine("La mediana es :" + mediana);

}
//la desviación estándar 
double sumaCuadrados = lista.Sum(x => Math.Pow(x - mediana, 2));
double varianza = Math.Round((sumaCuadrados / (lonLista - 1)), 4);
desEstabdar =Math.Sqrt(varianza);
Console.WriteLine("La desviacion estandar es: " + Math.Round(desEstabdar,4));
Console.WriteLine(" ============== Fin del programa===============");

//Ejercicio 3: 
//Escribe una función que encuentre el elemento máximo de una matriz. 
int[,] MatrizA = new int[4, 4];
Random t = new Random();
for (int i = 0; i < 4; i++) //creamos una matriz de 4x4 con numeros aleatorios
{
    for (int j = 0; j < 4; j++)
    {
        MatrizA[i, j] = t.Next(1, 200);//generamos numeros aleatorios del 1 al 9
        Console.Write(MatrizA[i, j]+" ");
    }
    Console.WriteLine(" ");
}
Console.Read();
int elementoMayorMatriz(int[,] MatrizA)
{
    int elementoMayor = int.MinValue;
    int f, c;
    f = MatrizA.GetLength(0);
    c = MatrizA.GetLength(1);
    Console.WriteLine("f" + f);
    Console.WriteLine("c" + c);
    for (int i = 0; i < f; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (MatrizA[i, j] > elementoMayor)
                elementoMayor = MatrizA[i, j];
        }
    }
    return elementoMayor;
}
int max = elementoMayorMatriz(MatrizA);
Console.WriteLine("El elemento maximo o mayor de la matriz es :"+ max);

*/
//Ejercicio 4: 
//Escribe una función que encuentre la submatriz de mayor suma de una matriz. 
//Ejercicio 5: 
//Escribe una función que encuentre la matriz de covarianza de dos matrices.



