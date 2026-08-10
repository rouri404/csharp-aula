namespace Aula3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Bem-vindo ao App Aula 2\n");

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            var idade = Console.ReadLine();

            Console.Write("Qual a seu peso? ");
            var peso = Console.ReadLine();

            Console.Write("Qual cidade você mora? ");
            string cidade = Console.ReadLine();

            string interpolacao = $"Você se chama {nome}, possui {idade} anos de idade, pesa {peso} kgs e mora em {cidade}!";
            string trim = interpolacao.Trim();
            string toUpper = interpolacao.ToUpper();
            string substring = interpolacao.Substring(0, 20);
            string split = interpolacao.Split(' ')[0];

            Console.WriteLine($"\nInterpolação: {interpolacao}");
            Console.WriteLine($"Trim: {trim}");
            Console.WriteLine($"ToUpper: {toUpper}");
            Console.WriteLine($"Substring: {substring}");
            Console.WriteLine($"Split: {split}");


            const double PI = Math.PI;

            Console.Write("\nQual o raio do círculo? ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = PI * Math.Pow(raio, 2);

            Console.WriteLine($"\nO círculo tem {areaCirculo} de área");
        }
    }
}