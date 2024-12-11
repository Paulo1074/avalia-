using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        float N1 = float.Parse(input[0]);
        float N2 = float.Parse(input[1]);
        float N3 = float.Parse(input[2]);
        float N4 = float.Parse(input[3]);

        float media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");

            float notaExame = float.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");

            float mediaFinal = (media + notaExame) / 2;
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {mediaFinal:F1}");
        }
    }
}