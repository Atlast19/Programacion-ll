// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

class program { 
    static void Main(string[] args)
    {
        var docentesPorHora = new DocentePorHora { Nombre = "Juan Pérez",TipoEmpleado = "Docente por horas", HorasTrabajadas = 12 };

        var docenteContratoFijo = new DocenteContratoFijo { Nombre = "María Gómez", TipoEmpleado = "Doncete de contrato fijo" ,  SalarioFijo = 20000, AlcanzóMeta = true };

        var empleadoAdministrativo = new EmpleadoAdministrativo { Nombre = "Carlos Ruiz",TipoEmpleado = "Empleado Administrativo", SalarioFijo = 15000, AlcanzóMeta = false };


        Console.WriteLine(docentesPorHora);
        Console.WriteLine(docenteContratoFijo);
        Console.WriteLine(empleadoAdministrativo);
        Console.ReadKey();
    }
}

public class DocentePorHora
{
    public string Nombre { get; set; }
    public string TipoEmpleado { get; set; }
    public int HorasTrabajadas { get; set; }

    public decimal SalarioMensual()
    {
        return HorasTrabajadas * 800;
    }
    public override string ToString()
    {
        return $"{Nombre} - {TipoEmpleado} - Salario: {SalarioMensual():C} dolares";
    }

}

public class DocenteContratoFijo
{
    public string Nombre { get; set; }
    public string TipoEmpleado { get; set; }
    public decimal SalarioFijo { get; set; }
    public bool AlcanzóMeta { get; set; }

    public decimal SalarioMensual()
    {
        return AlcanzóMeta ? SalarioFijo : SalarioFijo / 2;
    }

    public override string ToString()
    {
        return $"{Nombre} - {TipoEmpleado} - Salario: {SalarioMensual():C} dolares";
    }
}

public class EmpleadoAdministrativo
{
    public string Nombre { get; set; }
    public string TipoEmpleado { get; set; }
    public decimal SalarioFijo { get; set; }
    public bool AlcanzóMeta { get; set; }

    public decimal SalarioMensual()
    {
        return AlcanzóMeta ? SalarioFijo : SalarioFijo / 2;
    }

    public override string ToString()
    {
        return $"{Nombre} - {TipoEmpleado} - Salario: {SalarioMensual():C} dolares";
    }
}