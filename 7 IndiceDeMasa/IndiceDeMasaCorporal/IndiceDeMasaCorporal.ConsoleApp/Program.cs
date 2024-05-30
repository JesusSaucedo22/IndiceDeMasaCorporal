using IndiceDeMasaCorporal.CalculadoraImc;
Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona\n");

try
{
    decimal peso = ReadDecimal("Proporcione el peso en kilogramos de la persona");
    decimal estatura = ReadDecimal("Proporcione la estatura en metros de la persona");

    decimal imc = CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
    Console.WriteLine($"El indice de masa corporal de la persona es {imc:F4}");
    Console.WriteLine($"El estado nutricional de la persona es {CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional(imc)}");
}
catch (FormatException)
{
    Console.Error.WriteLine("El numero proporcionadp no tiene el formato correcto.");
    //throw;
}
catch (OverflowException)
{
    Console.Error.WriteLine("El numero proporcionado es muy grande.");
    //throw;
}
catch (Exception exc)
{
    Console.Error.WriteLine(exc.Message);
    Console.Error.WriteLine(exc.StackTrace);
}
decimal ReadDecimal(string s)
{
    //Decimal value;
    //bool huboExito = false;
    Console.WriteLine(s);
    string entrada = Console.ReadLine();
    //huboexito = decimal TryParse(entrada, out value);
    //if (huboExito)
    //{
    //    return value;
    //}
    //else
    //{
    //throw new Exception("El valor proporcionado no es un numero");
    //}
    return Convert.ToDecimal(entrada);
}


