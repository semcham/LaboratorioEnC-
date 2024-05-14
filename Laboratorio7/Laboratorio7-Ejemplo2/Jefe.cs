public class Jefe
{
    // Atributos
    public decimal  DNI { get; set; }
    public string Nombres { get; set; }
    public string Cargo { get; set; }
    public string Area { get; set; }
    public decimal AñosAntiguedad { get; set; }
    private static decimal porc_Bonificacion_AñosAntiguedad_menorIgual7 = (decimal)0.05;
    private static decimal porc_Bonificacion_AñosAntiguedad_mayorIgual8 = (decimal)0.04;
    private static int contador = 0;


    public Jefe(decimal Dni, string nombres, string cargo, string area, decimal añosAntiguedad)
    {
        contador++;
        this.DNI = Dni;
        this.Nombres = nombres;
        this.Cargo = cargo;
        this.Area = area;
        this.AñosAntiguedad = añosAntiguedad;
    }
    public decimal CalcularSueldoBase()
    {
     
        if (Cargo == "Gerente" && Area == "Contabilidad")

            return 6000;
        if (Cargo == "Gerente" && Area == "Planificacion")

            return 7000;
        if (Cargo == "Subgerente" && Area == "Contabilidad")
            return 5000;
        if (Cargo == "Subgerente" && Area == "Planificacion")
            return 6000;
        return 0;
    }
    public decimal calcularMontoMovilidad()
    {
        if (Cargo == "Gerente")
            return 700;
        if (Cargo == "Subgerente")
            return 400;
        return 0;
    }
    public decimal CalcularBonificacion()
    {
        if (AñosAntiguedad<=7)
            return CalcularSueldoBase() * porc_Bonificacion_AñosAntiguedad_menorIgual7;
        if (AñosAntiguedad>=8 )
            return CalcularSueldoBase() * porc_Bonificacion_AñosAntiguedad_mayorIgual8;
        return 0;
    }
    public decimal CalcularSueldoFinal()
    {
        return CalcularSueldoBase()+CalcularBonificacion()+calcularMontoMovilidad();
    }

    public static int GetContador()
    {
        return contador;
    }

}