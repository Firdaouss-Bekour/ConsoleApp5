using System;

namespace exercice1sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            Console.WriteLine("veuillez entrez un nbr");
            nbr = int.Parse(Console.ReadLine());

            for (int i = 2; i <= nbr / 2; i++)
            {
                if (nbr % i == 0)
                {
                    Console.WriteLine(nbr + " n'est pas premier");
                    Console.ReadLine();
                }
            }
            Console.WriteLine(nbr + "est un nbr premier ");
            Console.ReadLine();
        }
    }
}

