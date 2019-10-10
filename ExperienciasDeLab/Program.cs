using System;

namespace ExperienciasDeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Animais a;
           
            Console.WriteLine("Informe o nome de um animal e a quantidade que possui dele");
            string[] vet = Console.ReadLine().Split(' ');
            string animal = vet[0];
            int quantidade =int.Parse(vet[1]);

            a = new Animais();
            

            while (animal == "S" || animal == "C" || animal == "R")
            {
                a.Quantia(animal, quantidade);
                vet = Console.ReadLine().Split(' ');
                animal = vet[0];
                quantidade = int.Parse(vet[1]);
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
