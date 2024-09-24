using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        string padrao = @"^[a-zA-Z]{3}[0-9]{4}$";
        bool placaValida = Regex.IsMatch(placa, padrao);

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }
}
