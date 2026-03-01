using System;

public class ImparOuPar : IChallenge
{
    public string Name => "Par ou Ímpar";

    public void Execute()
    {
        Console.WriteLine("Retorna Ímpar ou Par");
        Console.Write("Digite qualquer número: ");

        var input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            // bool r = true;
            // string result = r ? "Par" : "Impar";

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} é Par");
            }
            else
            {
                Console.WriteLine($"{number} é Ímpar");
            }

        }
        else
        {
            Console.WriteLine("Digite um número válido");
        }
    }
}