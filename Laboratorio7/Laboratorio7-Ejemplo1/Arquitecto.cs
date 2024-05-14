public class Arquitecto
{
    // Atributos
    public string Codigo { get; set; }
    public string Nombres { get; set; }
    public string CondicionContrato { get; set; } 
    public string Especialidad { get; set; }
    public string TipoActividad { get; set; }
    public string TipoAfiliacion { get; set; }
    private static decimal porc_Afp = (decimal)0.15;
    private static decimal porc_Snp = (decimal)0.08;
    private static decimal porc_Essalud = (decimal)0.04;
    private static decimal porc_Bonificaion_EEstructura = (decimal)0.16;
    private static decimal porc_Bonificacion_ERH = (decimal)0.18;
    private static int contador = 0;


    public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
    {
        contador++;
        Codigo = codigo;
        Nombres = nombres;
        CondicionContrato = condicionContrato;
        Especialidad = especialidad;
        TipoActividad = tipoActividad;
        TipoAfiliacion = tipoAfiliacion;
    }
    public decimal calcularSueldoBase()
    {
        //SO = Supervision de Obras
        //SV = Supervision de Vias

        if (CondicionContrato == "Estable" && TipoActividad == "SO")
        
            return 4000;
        if (CondicionContrato == "Estable" && TipoActividad == "SV")

            return 6000;
        if (CondicionContrato == "Contratado" && TipoActividad == "SO")
            return 2000;
        if (CondicionContrato == "Contratado" && TipoActividad == "SV")
            return 4500;
        return 0;
    }
    public decimal calcularBonificacion()
    {
        if (Especialidad == "Estructuras")
            return calcularSueldoBase() * porc_Bonificaion_EEstructura;
        if (Especialidad == "Recursos Hidricos")
            return calcularSueldoBase() * porc_Bonificacion_ERH;
        return 0;
    }

    public decimal CalcularMontoSeguro()
    {
        if (TipoAfiliacion == "AFP")
            return calcularSueldoBase() * porc_Afp;
        if (TipoAfiliacion == "SNP")
            return calcularSueldoBase() * porc_Snp;
        return 0;
    }

    public decimal CalcularMontoEssalud()
    {
        return calcularSueldoBase() * porc_Essalud;
    }

    public decimal CalularDescuento()
    {
        return CalcularMontoSeguro() + CalcularMontoEssalud();
    }
    public decimal SueldoBruto()
    {
        return calcularSueldoBase()+calcularBonificacion();
    }
    public decimal SueldoNeto()
    {
        return SueldoBruto() - CalularDescuento();
    }

    public static int GetContador()
    {
        return contador;
    }

}

