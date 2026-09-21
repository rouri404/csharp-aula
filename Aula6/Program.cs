using System;

namespace Aula6
{
    class Program
    {
        public static void Main()
        {
            Exercicio1();
            Exercicio2();
            
            Console.WriteLine("\nExercício 3");
            Console.WriteLine("7 é primo? " + EhPrimo(7));
            Console.WriteLine("10 é primo? " + EhPrimo(10));
            Console.WriteLine("13 é primo? " + EhPrimo(13));
            
            Exercicio4();
            Exercicio5();
        }

        // 1. Solicite números até que o usuário digite 0. Some apenas os números positivos; use continue para ignorar os demais valores que não devem ser somados.
        static void Exercicio1()
        {
            Console.WriteLine("Exercício 1");
            int soma = 0;
            while (true)
            {
                Console.Write("Digite um número (0 para sair): ");
                if (!int.TryParse(Console.ReadLine(), out int numero)) continue;

                if (numero == 0) break;

                if (numero < 0) 
                {
                    continue;
                }

                soma += numero;
            }
            Console.WriteLine($"A soma dos números positivos é: {soma}");
        }

        // 2. Leia cinco nomes. Interrompa a leitura com break quando encontrar o nome Maria e exiba a posição em que ele foi encontrado.
        static void Exercicio2()
        {
            Console.WriteLine("\nExercício 2");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º nome: ");
                string nome = Console.ReadLine();

                if (nome != null && nome.Equals("Maria", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Nome Maria encontrado na posição {i}.");
                    break;
                }
            }
        }

        // 3. Crie um método EhPrimo(n) para verificar se um número é primo. Use return antecipado para encerrar o método assim que uma condição de saída for identificada
        static bool EhPrimo(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        // 4. Imprima a tabuada dos valores de 1 a 10, mas use continue para pular os múltiplos de 3.
        static void Exercicio4()
        {
            Console.WriteLine("\nExercício 4");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0) continue;
                
                Console.WriteLine($"Tabuada do {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        // 5. Implemente um jogo para adivinhar um número de 1 a 100. Forneça dicas ao usuário e use break quando ele acertar o número.
        static void Exercicio5()
        {
            Console.WriteLine("\nExercício 5");
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;

            Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

            while (true)
            {
                Console.Write("Sua tentativa: ");
                if (!int.TryParse(Console.ReadLine(), out int palpite))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                tentativa++;

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativa} tentativas.");
                    break;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Dica: O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("Dica: O número secreto é menor.");
                }
            }
        }
    }
}