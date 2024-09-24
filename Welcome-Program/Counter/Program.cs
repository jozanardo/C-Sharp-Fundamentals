class Program
{
    static void Main()
    {
        Console.Write("Digite uma ou mais palavras: ");
        string input = Console.ReadLine();

        int contador = 0;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                contador++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres é: {contador}");
    }
}
