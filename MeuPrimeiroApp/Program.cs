class Program
{
    static void Main()
    {
        Console.WriteLine("Olá mundo");

        // Nome
        Console.Write("Qual seu nome? ");
        string nome = Console.ReadLine();

        // Idade
        Console.Write("Qual sua idade? ");
        string idade = Console.ReadLine();

        // Curso
        Console.Write("Qual seu curso? ");
        string curso = Console.ReadLine();

        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos de idade, e estou cursando {curso}");
    }
}
