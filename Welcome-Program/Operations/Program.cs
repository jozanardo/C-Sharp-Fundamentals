class Program
{
    static void Main()
    {
        double num1, num2;

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Divisão: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }

        Console.WriteLine($"Média: {(num1 + num2) / 2}");
    }
}
