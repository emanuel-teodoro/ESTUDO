public class Program
{
    public static void Main(string[] args)
    {
        string Nome;
        int N1, N2, N3, N4, RA;

        Console.WriteLine("Informe o nome do aluno");
        Nome = Console.ReadLine();

        Console.WriteLine("Informe o RA do aluno");
        RA = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a 1 nota");
        N1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a 2 nota");
        N2 = int.Parse(Console.ReadLine());
            
        Console.WriteLine("Informe a 3 nota");
        N3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a 4 nota");
        N4 = int.Parse(Console.ReadLine());

        double Media = (N1 + N2 + N3 + N4)/4;

        Console.WriteLine("A media final do aluno: " + Nome + " é: " + Media);
    }
}