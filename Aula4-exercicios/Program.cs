namespace Aula4 {
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Qual sua nota?");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            } else
            {
                Console.WriteLine("Reprovado");
            }


            Console.WriteLine("Qual o dia da semana?");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Tente novamente!");
                    break;
            }


            Console.WriteLine("Digite três números");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            int maiorNumero = ( numero1 > numero2) ? ( numero1 > numero3 ? numero1 : numero3 ) : (numero2 > numero3 ? numero2 : numero3);
            Console.WriteLine($"O maior número é {maiorNumero}");


            Console.WriteLine("Qual seu peso?");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura em centímetros?");
            double altura = double.Parse(Console.ReadLine());
            altura = altura/100;

            double imc = peso/(altura*altura);
            Console.WriteLine($"{imc}");

            if (imc >= 30)
            {
                Console.WriteLine("Obeso");
            } else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso");
            } else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            } else
            {
                Console.WriteLine("Abaixo do peso");
            }
        }
    }

}