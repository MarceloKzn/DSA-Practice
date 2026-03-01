public class MaiorQue : IChallenge
{
    public string Name => "Maior de Dois";

    public void Execute()
    {
        Console.WriteLine("Escolha dois números e veja qual é o maior");
        Console.Write("Primeiro: ");
        var input1 = Console.ReadLine();
        Console.Write("Segundo: ");
        var input2 = Console.ReadLine();


        if (int.TryParse(input1, out int number))
        {
            if (int.TryParse(input2, out int number2))
            {
                if (number > number2)
                {
                    Console.WriteLine($"O Maior número é o: {number}");
                }
                else
                {
                    Console.WriteLine($"O Maior número é o: {number2}");
                }
            }
        }
        else
        {
            Console.WriteLine("Digite números válidos");
        }

    }
}