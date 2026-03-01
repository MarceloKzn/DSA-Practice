using System;
using System.Collections.Generic;
public class MediaDeTres : IChallenge
{
    public string Name => "Media Simples";

    public void Execute()
    {
        List<int> notas = new();
        // Leia 3 notas e calcule a média

        while (true)
        {
            Console.WriteLine("Digite 3 Notas(ou mais) para Calcular a média");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Entrada vazia.");
            }
            else if (!int.TryParse(input, out int newNote))
            {
                Console.WriteLine("Número inválido.");
            }
            else
            {
                notas.Add(newNote);
            }

            if (notas.Count >= 3)
            {
                Console.WriteLine($"Já tem {notas.Count} notas");
                Console.WriteLine("Ainda quer Adicionar mais números nas Notas?\n");

                Console.WriteLine(" [1] Sim \n [2] Não");

                var res = Console.ReadLine()?.ToLower();

                if (res == "2" || res == "não" || res == "nao" || res == "no")
                {
                    Media(notas);
                    break;
                }
            }
        }
    }

    void Media(List<int> list)
    {

        int total = 0;

        foreach (var notas in list)
        {
            total += notas;
        }

        double mid = (double)total / list.Count;

        Console.Write($"A Média é {mid}");

    }
}