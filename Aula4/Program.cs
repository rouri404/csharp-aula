namespace Aula4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Qual sua nota? ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5)
            {
                Console.Write("Recuperação");
            } else
            {
                Console.Write("Reprovado");
            }

            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            string status = idade >= 18 ? "maior" : "menor";
            Console.WriteLine($"Você é de {status}");

            Console.WriteLine("Qual dia da semana é hoje? ");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "sab":
                case "dom":
                    Console.WriteLine("Final de semana");
                    break;
                default:
                    Console.WriteLine("Dia útil");
                    break;
            }
        }
    }
}