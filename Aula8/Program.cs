using System;

namespace Aula8
{
    class Program
    {
        public static void Main()
        {
            Log("Aula 8 - 05/10/2026");

            while (true)
            {
                Console.WriteLine("Questão 1\n");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Calcular Média");
                Console.WriteLine("6 - Dobrar Valor");
                Console.WriteLine("7 - Dividir com Resto");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                
                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    Log("Saindo...");
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        {
                            Console.Write("Digite o primeiro número: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Somar(a, b)}\n");
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Digite o primeiro número: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Subtrair(a, b)}\n");
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Digite o primeiro número: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Multiplicar(a, b)}\n");
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Digite o dividendo: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o divisor: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double resultado = Dividir(a, b);
                            if (!double.IsNaN(resultado))
                                Console.WriteLine($"Resultado: {resultado}\n");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Digite as notas separadas por espaço (ex: 1.2 3 4.5):");
                            string[] entradas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            double[] notas = new double[entradas.Length];
                            for (int i = 0; i < entradas.Length; i++)
                            {
                                notas[i] = Convert.ToDouble(entradas[i]);
                            }
                            Console.WriteLine($"Média: {CalcularMedia(notas)}\n");
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Digite um valor para ser dobrado: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            DobrarValor(ref valor);
                            Console.WriteLine($"Valor após ser dobrado: {valor}\n");
                            break;
                        }
                    case "7":
                        {
                            Console.Write("Digite o dividendo: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o divisor: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double resto;
                            double quociente = Dividir(a, b, out resto);
                            if (!double.IsNaN(quociente))
                                Console.WriteLine($"Quociente: {quociente} | Resto: {resto}\n");
                            break;
                        }
                    default:
                        Log("Tente novamente.\n", "WARN");
                        break;
                }
            }
        }

        // 1. operações básicas
        public static double Somar(double a, double b) => a + b;

        public static double Subtrair(double a, double b) => a - b;

        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Log("Erro: Tentativa de divisão por zero!", "ERRO");
                return double.NaN;
            }
            return a / b;
        }

        // 2. método com params para calcular média
        public static double CalcularMedia(params double[] notas)
        {
            if (notas == null || notas.Length == 0) return 0;
            
            double soma = 0;
            foreach (var nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }

        // 3. método com ref para dobrar valor
        public static void DobrarValor(ref double valor)
        {
            valor *= 2;
        }

        // 4. método com out para divisão com resto
        public static double Dividir(double a, double b, out double resto)
        {
            if (b == 0)
            {
                Log("Erro: Tentativa de divisão por zero!", "ERRO");
                resto = 0;
                return double.NaN;
            }
            
            resto = a % b;
            return Math.Truncate(a / b);
        }

        // 5. método com parâmetro opcional
        public static void Log(string mensagem, string nivel = "INFO")
        {
            Console.WriteLine($"[{nivel}] {mensagem}");
        }
    }
}