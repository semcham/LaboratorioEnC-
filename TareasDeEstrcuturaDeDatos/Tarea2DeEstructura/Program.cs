

//4.Desarrollo y Actividades Ejercicio: 
//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 
Console.WriteLine("=============== Imprimir los Numeros Pares del 1 al 100 =============");
int NumPares(int a)
{
    if (a <= 100)
    {
        int valor = 1 + NumPares(a + 1);
        if (a % 2 == 0)
        {
            Console.WriteLine(valor);
        }
        return valor;
    }
    else
        return 1;
}
NumPares(1);
Console.ReadKey();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");
//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 
Console.WriteLine("=============== Sumatoria Del los Numeros del 1 a n =============");
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
Console.WriteLine("La Sumatoria de los {0} Numeros Naturales es : {1}",n,sumatoria);
Console.WriteLine("=============== FIN DEL PROGRAMA=============");
//3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
Console.WriteLine("============== Calcular Piramide de Numeros del 1 a n =============");
Console.Write("Ingrese el tamaño del Piramide : ");
int h = int.Parse(Console.ReadLine());
ImprimirPiramideAscendente(h);

static void ImprimirPiramideAscendente(int h)
{
    for (int i = 1; i <= h; i++)
    {
        for (int j = 1; j <= h - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= i * 2 - 1; k++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
Console.WriteLine("=============== Imprima la Pirámide de Números Invertidos del 1 al n =============");
Console.Write("Ingrese el tamaño del Piramide(INVERTIDO): ");
int w = int.Parse(Console.ReadLine());
ImprimirPiramideInvertida(w);

static void ImprimirPiramideInvertida(int w)
{
    ImprimirPiramideInvertidaRecursiva(w, w);
}
static void ImprimirPiramideInvertidaRecursiva(int original, int actual)
{
    if (actual <= 0)
    {
        return;
    }
    for (int i = 1; i <= original - actual; i++)
        Console.Write(" ");
    {
    }
    for (int j = 1; j <= actual * 2 - 1; j++)
    {
        Console.Write(actual);
    }
    Console.WriteLine();
    ImprimirPiramideInvertidaRecursiva(original, actual - 1);
}
Console.WriteLine("=============== FIN DEL PROGRAMA=============");
//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n.
Console.WriteLine("=========Generador de tabla de Multiplicar===========");
Console.Write("Ingrese un numero entero: ");
int s = int.Parse(Console.ReadLine());
for (int i = 1; i <= s; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        int resul = i * j;
        Console.WriteLine($"{i}x{j}={resul}");

    }
    Console.WriteLine();
}
Console.ReadLine();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//Arreglos y Matrices: 
//6) Crea una matriz de números reales. 
Console.WriteLine("=============== Crea una Matriz de Números Reales =============");
double[,] m = new double[3,3];
Random R = new Random();
for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 3; j++)
    {
        m[i, j] = R.Next(-9, 9);
        Console.Write(m[i, j]+ " ");
    }
    Console.WriteLine(" ");
}
Console.Read();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

/*
//7) Crea una matriz de números complejos. 
using System.Numerics;

Console.WriteLine("=================La Matriz de Numeros Complejos =============");
Complex[,] complejoMatriz = new Complex[3, 3];
complejoMatriz[0,0]= new Complex(3,4);
complejoMatriz[0, 1] = new Complex(4, 8);
complejoMatriz[1, 0] = new Complex(1, 6);
complejoMatriz[1, 2] = new Complex(1.2, 5);
complejoMatriz[2, 1] = new Complex(3, 7);
complejoMatriz[0, 2] = new Complex(4, 11);
complejoMatriz[2, 0] = new Complex(5, 12);
complejoMatriz[1, 1] = new Complex(4, 14);
complejoMatriz[2, 2] = new Complex(9, 16);
for (int i = 0; i < complejoMatriz.GetLength(0); i++) // Iterar sobre las filas
{
    for (int j = 0; j < complejoMatriz.GetLength(1); j++) // Iterar sobre las columnas

    { 
        Console.Write($" {complejoMatriz[i, j]} ");
    }
    Console.WriteLine(); 
}
Console.ReadLine();
Console.WriteLine("=================Fin del Programa =============");

*/
//8) Crea una matriz de matrices. 
Console.WriteLine("=============== Matriz De Matrices =============");
int[][,] MatrizDeMatrices = new int[][,]
{
            new int[,] { {1, 3, 8}, {5, 7,5},{3,6,5} },
            new int[,] { {0, 2, 6}, {4, 6, 7}, {8, 10, 5 }},
            new int[,] { {2, 4, 8 }, {2, 55, 11}, { 6, 8, 5 } },
            new int[,] { {11, 22, 3}, {99, 88, 1},{ 3, 5, 4 } }
};

for (int k = 0; k < MatrizDeMatrices.Length; k++) 
// Recorremos el matriz de matrices
{
    Console.WriteLine($"Matriz {k + 1}:");

    int[,] matriz = MatrizDeMatrices[k];
    int Filas = matriz.GetLength(0);
    int Columnas = matriz.GetLength(1);

    for (int i = 0; i < Filas; i++) // Recorremos las filas
    {
        for (int j = 0; j < Columnas; j++) // Recorremos las columnas
        {
            Console.Write(matriz[i, j] + " "); 
        }
        Console.WriteLine(""); 
    }

    Console.WriteLine(""); 
}Console.Read();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");
//9) Accede al elemento central de una matriz.
Console.WriteLine("=============== Accede al elemento central de una matriz =============");
int[,] matrizImpar = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

// Matriz de ejemplo con un número par de filas y columnas
int[,] matrizPar = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

// Acceder al elemento central de una matriz con un número impar de filas y columnas
int centroImpar = matrizImpar[matrizImpar.GetLength(0) / 2, matrizImpar.GetLength(1) / 2];
Console.WriteLine("Elemento central de la matriz impar: " + centroImpar);

// Acceder al elemento central de una matriz con un número par de filas y columnas
int filaCentral = matrizPar.GetLength(0) / 2;
int columnaCentral = matrizPar.GetLength(1) / 2;
int centroPar1 = matrizPar[filaCentral, columnaCentral];
int centroPar2 = matrizPar[filaCentral - 1, columnaCentral];
int centroPar3 = matrizPar[filaCentral, columnaCentral - 1];
int centroPar4 = matrizPar[filaCentral - 1, columnaCentral - 1];
Console.WriteLine("Elementos centrales de la matriz par: " + centroPar1 + ", " + centroPar2 + ", " + centroPar3 + ", " + centroPar4);

Console.WriteLine("=============== FIN DEL PROGRAMA=============");

Console.WriteLine("=============== Suma dos Matrices de Diferentes Tamaños =============");
//10) Suma dos matrices de diferentes tamaños.
int[,] MatrizA = new int[4, 4];
int[,] MatrizB = new int[4, 4];
int[,] MatrizC= new int[4, 4];
Random l = new Random();
Console.WriteLine("==========La Matriz A=============");
for (int i = 0;i < 4; i++)
{
    for (int j = 0;j < 4; j++)
    {
        MatrizA[i, j] = l.Next(2, 100);
        Console.Write(MatrizA[i, j]+ " ");
    }
    Console.WriteLine(" ");
}
Console.Read();
Console.WriteLine("========La Matriz B=========");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        MatrizB[i, j] = l.Next(2, 100);
        Console.Write(MatrizB[i, j] + " ");
    }
    Console.WriteLine(" ");
}
Console.Read();

for (int i = 0; i<4; i++)
{
    for(int j = 0;j<4; j++)
    {
        MatrizC[i, j] = MatrizA[i, j] + MatrizB[i,j];
    }
    Console.WriteLine("");
    
}
Console.Read();
Console.WriteLine("=================La Suma de Matrices ES : =======================");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(MatrizC[i, j] + " ");
    }
    Console.WriteLine("");
}
Console.Read();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");
//11) Multiplica una matriz por un número.
Console.WriteLine("========== Multiplica una Matriz por un Número ============");
int[,] B = new int[3, 3];
double[,] D = new double[3, 3];
Console.Write("Ingrese un Escalar  :");
double e = double.Parse(Console.ReadLine());
Random r = new Random();
Console.WriteLine("===================La Matriz Inicialmente==================");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        B[i, j] = r.Next(2, 100);
        Console.Write(B[i, j] + " ");
        D[i, j] = e * B[i, j];
    }
    Console.WriteLine(" ");
}
Console.Read();
Console.WriteLine("================== La matriz Multiplicado por un Escalar ==================");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(Math.Round(D[i, j], 2) + " ");
    }
    Console.WriteLine("");
}
Console.Read();
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//12) Calcula la media de los elementos de una matriz.
Console.WriteLine("=============== Calcula la Media de los Elementos de una Matriz =============");
double sumar, mediaElementos;
double[,] H = new double[3, 3];
Random g = new Random();
int longitudH = H.Length;
sumar = 0;
Console.WriteLine("===================La matriz H ==================");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        H[i, j] = g.Next(2, 5);
        Console.Write(H[i, j] + " ");
        sumar += H[i, j];
    }
    Console.WriteLine(" ");
}
Console.Read();
mediaElementos = sumar/longitudH;
Console.WriteLine("La media de Elementos de la Matriz es :"+ Math.Round(mediaElementos, 4));
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//Ejercicio Matrices: 
//Ejercicio 1: 
//Crea una matriz de números aleatorios de tamaño 100x100. 
Console.WriteLine("=============== Crea una Matriz de números Aleatorios de Tamaño 100x100 =============");
int[,]MatrizAleatorioN = new int[100, 100];
Random V = new Random();
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        MatrizAleatorioN[i, j] = V.Next(1, 9);
        Console.Write(MatrizAleatorioN[i, j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//Ejercicio 2: 
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 
Console.WriteLine("======================Calcular : media,mediana,desviacion estandar============");
double media, mediana, desEstabdar;
int[,] Matriz = new int[6,6 ];
media = 0;
int longitudM = Matriz.Length;
Random z = new Random();
for (int i = 0; i < 6; i++) //creamos una matriz de 6x6 con numeros aleatorios
{
    for (int j = 0; j < 6; j++)
    {
        Matriz[i, j] = z.Next(1, 9);//generamos numeros aleatorios del 1 al 9
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
Console.WriteLine("La Media es: " + Math.Round(resultado, 2));
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
Console.WriteLine("La Desviacion Estandar es: " + Math.Round(desEstabdar,4));
Console.WriteLine(" ============== Fin del Programa ===============");

//Ejercicio 3: 
//Escribe una función que encuentre el elemento máximo de una matriz. 
Console.WriteLine("=============== Escribe una Función que encuentre el Elemento Máximo de una Matriz =============");
int[,] A = new int[4, 4];
Random t = new Random();
for (int i = 0; i < 4; i++) //creamos una matriz de 4x4 con numeros aleatorios
{
    for (int j = 0; j < 4; j++)
    {
        A[i, j] = t.Next(1, 200);//generamos numeros aleatorios del 1 al 200
        Console.Write(A[i, j]+" ");
    }
    Console.WriteLine(" ");
}
Console.Read();
int elementoMayorMatriz(int[,] MatrizA)
{
    int elementoMayor = int.MinValue;
    int f, c;
    f = A.GetLength(0);
    c = A.GetLength(1);
    for (int i = 0; i < f; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (A[i, j] > elementoMayor)
                elementoMayor = A[i, j];
        }
    }
    return elementoMayor;
}
int max = elementoMayorMatriz(A);
Console.WriteLine("El Elemento Maximo o Mayor de la Matriz es :"+ max);
Console.WriteLine("=============== FIN DEL PROGRAMA=============");

//Ejercicio 4: 
//Escribe una función que encuentre la submatriz de mayor suma de una matriz. 
Console.WriteLine("=====================    Calcular la Submatriz de Mayor Suma =====================");
int[,] matrizS = {
        {1, 16, -1, -4, -20},
        {-8, -3, 4, 2, 6},
        {3, 8, -10, 6, 3},
        {-4, -1, 5, 7, -6}
    };
Console.WriteLine($"La suma máxima de la submatriz es: {MaxSumSubmatrix(matrizS)}");
int MaxSumSubmatrix(int[,] matrizS)
{
    int maxSum = int.MinValue, filas = matrizS.GetLength(0), columnas = matrizS.GetLength(1);

    for (int left = 0; left < columnas; left++)
    {
        int[] temp = new int[filas];

        for (int right = left; right < columnas; right++)
        {
            for (int i = 0; i < filas; i++)
                temp[i] += matrizS[i, right];

            int currentMax = temp[0], maxEndHere = temp[0];
            for (int i = 1; i < filas; i++)
            {
                maxEndHere = Math.Max(temp[i], maxEndHere + temp[i]);
                currentMax = Math.Max(currentMax, maxEndHere);
            }
            maxSum = Math.Max(maxSum, currentMax);
        }
    }
    return maxSum;
}
Console.WriteLine("================== FIN DEL PROGRAMA ================");
//Ejercicio 5: 
//Escribe una función que encuentre la matriz de covarianza de dos matrices.
Console.WriteLine("================== CALCULAR LA COVARIANZA DE DOS MATRICES ================");
double[,] matriz1 = { { 4, 2 }, { 6, 9 } };
double[,] matriz2 = { { 5, 11 }, { 21, 6 } };
int fl = matriz1.GetLength(0), cols = matriz1.GetLength(1);
double[,] covarianza = new double[cols, cols];

for (int i = 0; i < cols; i++)
{
    for (int j = 0; j < cols; j++)
    {
        double sum1 = 0, sum2 = 0, sum12 = 0;
        for (int k = 0; k < fl; k++)
        {
            sum1 += matriz1[k, i];
            sum2 += matriz2[k, j];
            sum12 += matriz1[k, i] * matriz2[k, j];
        }
        covarianza[i, j] = (sum12 - sum1 * sum2 / fl) / fl;
    }
}
for (int i = 0; i < cols; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write(covarianza[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine("================== FIN DEL PROGRAMA ================");


