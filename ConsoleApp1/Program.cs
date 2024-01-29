using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animali Animale1 = new Animali();
            Animale1.Name = "Felix";
            Animale1.Razza = "Gatto";
            Animale1.Habitat = "Domestico";
            Animali Animale2 = new Animali();
            Animale2.Name = "Bobby";
            Animale2.Razza = "Cane";
            Animale2.Habitat = "Domestico";
            Animali Animale3 = new Animali();
            Animale3.Name = "Palla di neve";
            Animale3.Razza = "Calamaro gigante";
            Animale3.Habitat = "Alaska";

            Console.WriteLine("Primo animale: " + "\n" + "\n" + "Nome: " + Animale1.Name + "\n");
            Console.WriteLine("Razza: " + Animale1.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale1.Habitat + "\n" + "\n");
            Console.WriteLine("Secondo animale: " + "\n" + "\n" + "Nome: " + Animale2.Name + "\n");
            Console.WriteLine("Razza: " + Animale2.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale2.Habitat + "\n" + "\n");
            Console.WriteLine("Terzo animale: " + "\n" + "\n" + "Nome: " + Animale3.Name + "\n");
            Console.WriteLine("Razza: " + Animale3.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale3.Habitat);
            Console.ReadLine();
        }
    }
}
