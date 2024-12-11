using System;

class Program
{
    static void Main()
    {
        string palavra1 = Console.ReadLine().ToLower();
        string palavra2 = Console.ReadLine().ToLower();
        string palavra3 = Console.ReadLine().ToLower();

        string animal = "";

        if (palavra1 == "vertebrado")
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                {
                    animal = "aguia";
                }
                else if (palavra3 == "onivoro")
                {
                    animal = "pomba";
                }
            }
            else if (palavra2 == "mamifero")
            {
                if (palavra3 == "onivoro")
                {
                    animal = "homem";
                }
                else if (palavra3 == "herbivoro")
                {
                    animal = "vaca";
                }
            }
        }
        else if (palavra1 == "invertebrado")
        {
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                {
                    animal = "pulga";
                }
                else if (palavra3 == "herbivoro")
                {
                    animal = "lagarta";
                }
            }
            else if (palavra2 == "anelideo")
            {
                if (palavra3 == "hematofago")
                {
                    animal = "sanguessuga";
                }
                else if (palavra3 == "onivoro")
                {
                    animal = "minhoca";
                }
            }
        }

        Console.WriteLine(animal);
    }
}