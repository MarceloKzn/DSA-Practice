using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var challenges = new List<IChallenge>
        {
            new ImparOuPar(),
            new MaiorQue(),
            new MediaDeTres()
        };

        Console.WriteLine("Escolha um desafio:");

        for (int i = 0; i < challenges.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {challenges[i].Name}");
        }

        Console.Write("Digite o número do desafio: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int choice))
        {
            if (choice > 0 && choice <= challenges.Count)
            {
                Console.Clear();
                challenges[choice - 1].Execute();
            }
        }
        else
        {
            Console.WriteLine("Desafio inválido, escolha outro");
        }
    }
}