namespace cp2
{
    class Program
    {
        static List<string> usuarios = new List<string>();
        static List<string> nomes = new List<string>();
        static List<double[]> notasAlunos = new List<double[]>();
        public static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("Bem-vindo à Calculadora de Notas\n\n");
            Console.WriteLine("1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");

            while (running)
            {
                Console.Write("Digite uma opção: ");

                string option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        CadastrarAluno();
                        break;
                    case "2":
                        LancarNotas();
                        break;
                    case "3":
                        CalcularMedia();
                        break;
                    case "4":
                        exit();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente!\n");
                        break;
                }

            }
        }

        public static void CadastrarAluno()
        {
            Console.Write("\nDigite o usuário do aluno: ");
            string usuarioAluno = Console.ReadLine() ?? "";

            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine() ?? "";

            usuarios.Add(usuarioAluno);
            nomes.Add(nomeAluno);
            notasAlunos.Add(new double[3]);

            Console.WriteLine("\nAluno cadastrado com sucesso!");
            Console.WriteLine("\n1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");
        }

        public static void LancarNotas()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado!");
                Console.WriteLine("\n1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");
                return;
            }

            Console.Write("\nDigite o usuário do aluno: ");
            string usuarioBusca = Console.ReadLine() ?? "";

            int indiceAluno = usuarios.IndexOf(usuarioBusca);

            if (indiceAluno == -1)
            {
                Console.WriteLine("Aluno não encontrado!");
                Console.WriteLine("\n1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");
                return;
            }

            Console.WriteLine($"Lançando notas para o aluno: {nomes[indiceAluno]}");

            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                bool notaValida = false;

                while (!notaValida)
                {
                    Console.Write($"Digite a nota {i + 1} (0 a 10): ");
                    string notaEntrada = Console.ReadLine() ?? "";

                    if (double.TryParse(notaEntrada, out double nota) && nota >= 0 && nota <= 10)
                    {
                        notas[i] = nota;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida");
                    }
                }
            }

            if (notasAlunos.Count > indiceAluno)
            {
                notasAlunos[indiceAluno] = notas;
            }
            else
            {
                notasAlunos.Add(notas);
            }

            Console.WriteLine($"\nAs 3 notas de {nomes[indiceAluno]} foram lançadas com sucesso!");
            Console.WriteLine("\n1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");
        }

        public static void CalcularMedia()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado!");
                return;
            }

            Console.Write("\nDigite o usuário do aluno: ");
            string usuarioBusca = Console.ReadLine() ?? "";

            int indiceAluno = usuarios.IndexOf(usuarioBusca);

            if (indiceAluno == -1)
            {
                Console.WriteLine("Aluno não encontrado!");
                return;
            }

            double[] notas = notasAlunos[indiceAluno];

            double soma = 0;
            for (int i=0; i<3; i++)
            {
                soma += notas[i];
            }

            double media = soma / 3;

            Console.WriteLine($"\nAluno: {nomes[indiceAluno]}");
            Console.WriteLine($"Notas: {notas[0]:F1} | {notas[1]:F1} | {notas[2]:F1}");
            Console.WriteLine($"Média final: {media:F2}");

            ExibirSituacao(media);

            Console.WriteLine("\n1 - Cadastrar aluno\n2 - Lançar notas\n3 - Calcular média\n4 - Sair");
        }

        public static void ExibirSituacao(double media)
        {
            if (media >= 7.0)
            {
                Console.WriteLine("Situação: Aprovado\n");
            }
            else if (media >= 5.0 && media < 7.0)
            {
                Console.WriteLine("Situação: Recuperação\n");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado\n");
            }
        }


        public static void exit()
        {
            Console.WriteLine("Sair");
        }
    }
}
