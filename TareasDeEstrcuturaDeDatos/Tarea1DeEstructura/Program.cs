
//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.

using System;

Console.WriteLine("========Calcular:suma,resta,multiplicacion,division=============");
double n1, n2, suma, resta, multiplicacion, division;
Console.Write("Ingrese el primer numero : ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero : ");
n2 = double.Parse(Console.ReadLine());
suma = n1 + n2;
resta = n1 - n2;
multiplicacion = n1*n2;
Console.WriteLine("La suma es :" + suma);
Console.WriteLine("La resta es :" + resta);
Console.WriteLine("La multiplicacion es :" + multiplicacion);
if (n2 >0)
{
    division = n1/n2;
    Console.WriteLine("La division es :" + Math.Round(division,2));
}
else
{
    Console.WriteLine("ERROR.No se pude dividir entre Cero.");

}
Console.WriteLine("=========Fin del Programa===========");


//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 
Console.WriteLine("=========Calcular si el numero es Par o Impar===========");
Console.Write("Ingrese un numero entero : ");
int n = int.Parse(Console.ReadLine());
bool esPar = false;
if (n%2== 0)
{
    esPar= true;
}
Console.WriteLine(esPar?"Es el numero {0} es Par":"El numero {0} es Impar",n);
Console.WriteLine("=========Fin del Programa===========");

//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 
Console.WriteLine("=========Calcular el Area del triangulo===========");
Console.Write("Ingrese la base del triangulo : ");
double b, h, area;
b = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del triangulo : ");
h = double.Parse(Console.ReadLine());
area = (b * h) / 2;
Console.WriteLine("El Area del Triangulo es:"+Math.Round(area,2));
Console.WriteLine("=========Fin del Programa===========");

//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 
Console.WriteLine("=========Calcular el factorial de un numero===========");
Console.Write("Ingrese un numero entero : ");
int numero = int.Parse(Console.ReadLine());
int factorial = 1;
if (numero == 1 || numero == 0)
{
    factorial = 1;
}
else
{
    for (int i = 2; i <=numero; i++)
    {
        factorial *= i;
    }
 
}
Console.WriteLine("El factorial del numero {0} es : {1}", numero, factorial);
Console.WriteLine("=========Fin del Programa===========");


//Número Primo: 
//5) Verifica si un número ingresado por el usuario es primo o no. 
Console.WriteLine("=========Calcular si el numero es primo o no ===========");
Console.Write("Ingrese un numero entero positivo : ");
int n4 = int.Parse(Console.ReadLine());
bool esPrimo = true;
if (n4==0||n4==1 )
{
    esPrimo = false;
}else if (n4 >= 2)
{

    for (int i = 2; i < n4 && esPrimo; i++)
    {
        if (n4 % i == 0)
        {
            esPrimo = false;
        }
    }
}
else
{
    esPrimo = true;
}

Console.WriteLine(esPrimo ? "El numero  {0} es Primo" : "El numero {0} no es primo",n4);
Console.WriteLine("=========Fin del Programa===========");


//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión. 

Console.WriteLine("=========Calcular la Inversion de una Cadena===========");
Console.Write("Ingrese una cadena de texto: ");
string texto = Console.ReadLine();
int l = texto.Length-1;
string TextoInvertido = "";
while (l>=0)
{
    TextoInvertido += texto[l];
    l-=1;
}
Console.WriteLine("La cadena Invertida es:{0}",TextoInvertido);
Console.WriteLine("=========Fin del Programa===========");

//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario. 
Console.WriteLine("=========Calcular la Suma de Numeros Pares===========");
int n3, sumaPares;
Console.Write("Ingrese un numero entero(Rango): ");
n3 = int.Parse(Console.ReadLine());
suma = 0;
for (int i = 0; i <= n3; i++)
{
    if (i%2 == 0)
    {
        suma += i;
    }
}
Console.WriteLine("La sumatoria en el rango de los {0} primeros numeros Pares es : {1}",n3,suma);
Console.WriteLine("=========Fin del Programa===========");

//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

Console.WriteLine("=========Calcular la lista de cuadrados===========");
List<int> listCudrados = new List<int>();
for (int i = 1;i <= 10; i++)
{
    int cuadrado = i*i;
    listCudrados.Add(cuadrado);
}
Console.WriteLine("El cuadrado de los 10 primeros numeros naturales es:");
foreach (int num in listCudrados)
{
    Console.WriteLine(num + " ");
}  
Console.WriteLine();
Console.WriteLine("=========Fin del Programa===========");




//Contador de Vocales: 
//9) Cuenta el número de vocales en una cadena de texto. 
Console.WriteLine("=========Programa : Contador de Vocales===========");
Console.Write("Ingrese un texto:");
string t = Console.ReadLine();
int contadorVocales = 0;
int letra;
for (int i = 0;i < t.Length; i++)
{
    letra = t[i];
    if ((letra == 'a')|| (letra == 'e' )||(letra == 'i')||(letra == 'o' )||(letra == 'u'))
    {
        contadorVocales++;
    }
}
Console.WriteLine("La cantidad de vocales es : {0}",contadorVocales);

Console.WriteLine("=========Fin del Programa===========");



//Números de la Serie Fibonacci: 
//10) Genera los primeros 10 números de la serie Fibonacci. 
Console.WriteLine("=========Calcular La serie Fibonacci===========");
Console.Write("Ingrese un numero entero: ");
int n5 = int.Parse(Console.ReadLine());
int a = 0;
int x = 1;
int c;
for (int i = 0; i<=n5; i++)
{
    Console.WriteLine(a);
    c = a + x;
    a = x;
    x = c;

}
Console.WriteLine();
Console.WriteLine("=========Fin del Programa===========");

//Ordenamiento de Lista: 
//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 
Console.WriteLine("=========Programa:Ordenamiento de Lista de menor a mayor ===========");
List<int> numeros = new List<int> { 1,4,55,77,3,30,99,55,18};
numeros.Sort();
Console.WriteLine("La lista ordenada :");
foreach (int j in numeros)
{
    Console.Write(j + " ");
}
Console.WriteLine();
Console.WriteLine("=========Fin del Programa===========");

//Palíndromo:
//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 
Console.WriteLine("=========Verificar si la palabra es Palindromo o no===========");
Console.Write("Ingrese una palabra: ");
string p = Console.ReadLine();
int pl = p.Length - 1;
string PalabraInvertida = "";
while (pl >= 0)
{
    PalabraInvertida += p[pl];
    pl -= 1;
}
if (p == PalabraInvertida)
{
    Console.WriteLine("La palabra '{0}' es Palindromo.",p);
}
else
{
    Console.WriteLine("La palabra '{0}' no es Palindromo.",p);
}
Console.WriteLine("=========Fin del Programa===========");

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 
Console.WriteLine("=========Generador de tabla de Multiplicar===========");
Console.Write("Ingrese un numero entero: ");
int s = int.Parse(Console.ReadLine());
for (int i = 1; i <= s; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        int resultado = i * j;
        Console.WriteLine($"{i}x{j}={resultado}");

    }
    Console.WriteLine();
}
Console.WriteLine("=========Fin del Programa===========");


//Cálculo del Área de un Círculo: 
//14) Pide el radio de un círculo al usuario y calcula su área. 
Console.WriteLine("=========Calcular el Area de un Circulo===========");
double r, Area;
Console.Write("Ingrese el Radio del Circulo: ");
r = double.Parse(Console.ReadLine());
Area =Math.PI*(r*r);
Console.WriteLine("El Area del circulo es: "+Math.Round(Area,2));
Console.WriteLine("=========Fin del Programa===========");

//Suma de Dígitos: 
//15) Toma un número entero y calcula la suma de sus dígitos. 
Console.WriteLine("=========Calcular la suma de los digitos de un numero===========");
Console.Write("Ingrese un numero entero positivo: ");
int d = int.Parse(Console.ReadLine());
int sumaDigitos=0;
while (d > 0)
{
    int digito = d%10;
    sumaDigitos+=digito;
    d/=10;
}
Console.WriteLine($"La suma de los digitos del numero  es : {sumaDigitos}");
Console.WriteLine("=========Fin del Programa===========");




