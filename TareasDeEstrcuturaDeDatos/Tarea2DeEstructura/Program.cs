// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Vehiculo
{
    public decimal VelocidadMaxima { get; set; }
    public int NumeroRuedas { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

class Moto : Vehiculo
{
    public int Cilindrada { get; set; }

    public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
    {
        Cilindrada = cilindrada;
    }
    Vehiculo vehiculo = (Vehiculo)new Moto("ducati", "A1", 1000);
}

