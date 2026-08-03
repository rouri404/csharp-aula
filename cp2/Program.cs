namespace cp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CP2");
        Console.WriteLine("Gabriel Couto - RM55979");

        // 1. Use um laço for para imprimir todos os números pares de 0 a 20, incluindo os limites.
        Console.WriteLine("\n1. Números pares de 0 a 20");

        for (int i = 0; i <= 20; i += 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();


        // 2. Calcule o fatorial de um número usando um laço while. Considere a multiplicação progressiva dos valores necessários.
        Console.WriteLine("\n2. Calcular de fatorial");
        Console.Write("Digite um número para calcular o fatorial: ");

        if (int.TryParse(Console.ReadLine(), out int numFatorial) && numFatorial >= 0)
        {
            long fatorial = 1;
            int contador = numFatorial;
            while (contador > 0)
            {
                fatorial *= contador;
                contador--;
            }
            Console.WriteLine($"O fatorial de {numFatorial} é {fatorial}");
        }
        else
        {
            Console.WriteLine("Número inválido para fatorial.");
        }


        // 3. Peça nomes ao usuário repetidamente até que ele digite fim. Depois, exiba todos os nomes armazenados usando foreach.
        Console.WriteLine("\n3. Lista de nomes");
        List<string> nomes = new List<string>();

        while (true)
        {
            Console.Write("Digite um nome (use 'fim' para sair): ");
            string? nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome) || nome.Trim().ToLower() == "fim")
            {
                break;
            }
            nomes.Add(nome);
        }

        Console.WriteLine("\nNomes armazenados:");

        foreach (var n in nomes)
        {
            Console.WriteLine($"- {n}");
        }


        // 4. Crie um array com 5 notas e calcule a média dessas notas percorrendo o array com foreach.
        Console.WriteLine("\n4. Média de 5 notas");
        double[] notas = { 3.5, 7.0, 9.2, 6.8, 10 };
        double somaNotas = 0;

        foreach (var nota in notas)
        {
            somaNotas += nota;
        }

        double media = somaNotas / notas.Length;
        Console.WriteLine($"Lista de notas: {string.Join(", ", notas)}");
        Console.WriteLine($"A média das notas é {media:F2}");


        // 5. Construa a tabuada de um número usando laços for aninhados, considerando os multiplicadores de 1 a 10.
        Console.WriteLine("\n5. Tabuada");
        Console.Write("Digite um número para ver as tabuadas: ");

        if (int.TryParse(Console.ReadLine(), out int numLimite) && numLimite >= 1)
        {
            for (int i = 1; i <= numLimite; i++)
            {
                Console.WriteLine($"\nTabuada do {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        else
        {
            Console.WriteLine("Número inválido");
        }

        // 6. Leia números informados pelo usuário usando while e conte quantos deles são positivos. Ao final, mostre a quantidade encontrada.
        Console.WriteLine("\n6. Contar números positivos");
        int contPositivos = 0;
        Console.WriteLine("Digite números inteiros (digite 0 para encerrar)\n");

        while (true)
        {
            Console.Write("Número: ");
            if (int.TryParse(Console.ReadLine(), out int numeroLido))
            {
                if (numeroLido == 0) break;
                if (numeroLido > 0)
                {
                    contPositivos++;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um inteiro ou 0 para sair.");
            }
        }
        Console.WriteLine($"Números positivos: {contPositivos}");
    }
}
