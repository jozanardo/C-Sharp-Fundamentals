class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        // Formato completo
        Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

        // Apenas a data no formato "01/03/2024"
        Console.WriteLine("Data: " + dataAtual.ToString("dd/MM/yyyy"));

        // Apenas a hora no formato de 24 horas
        Console.WriteLine("Hora: " + dataAtual.ToString("HH:mm"));

        // Data com o mês por extenso
        Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}
