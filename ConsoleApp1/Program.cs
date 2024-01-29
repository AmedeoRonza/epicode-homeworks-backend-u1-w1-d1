using System;
using System.Collections.Generic;
using System.Globalization;
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

            Console.WriteLine("ANIMALI: " + "\n" + "\n");
            Console.WriteLine("Primo animale: " + "\n" + "\n" + "Nome: " + Animale1.Name + "\n");
            Console.WriteLine("Razza: " + Animale1.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale1.Habitat + "\n" + "\n");
            Console.WriteLine("Secondo animale: " + "\n" + "\n" + "Nome: " + Animale2.Name + "\n");
            Console.WriteLine("Razza: " + Animale2.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale2.Habitat + "\n" + "\n");
            Console.WriteLine("Terzo animale: " + "\n" + "\n" + "Nome: " + Animale3.Name + "\n");
            Console.WriteLine("Razza: " + Animale3.Razza + "\n");
            Console.WriteLine("Habitat: " + Animale3.Habitat + "\n" + "\n");

            Gruppo2 Membro1 = new Gruppo2();
            Membro1.Name = "Amedeo";
            Membro1.Surname = "Ronza";
            Membro1.Valutazione = "10";
            Gruppo2 Membro2 = new Gruppo2();
            Membro2.Name = "Melissa";
            Membro2.Surname = "Canu";
            Membro2.Valutazione = "10";
            Gruppo2 Membro3 = new Gruppo2();
            Membro3.Name = "Egidio";
            Membro3.Surname = "Roseti";
            Membro3.Valutazione = "10";
            Gruppo2 Membro4 = new Gruppo2();
            Membro4.Name = "Francesco";
            Membro4.Surname = "Napoli";
            Membro4.Valutazione = "10";
            Gruppo2 Membro5 = new Gruppo2();
            Membro5.Name = "Antonio";
            Membro5.Surname = "Marucci";
            Membro5.Valutazione = "10";
            Console.WriteLine("GRUPPO 2: " + "\n" + "\n");
            Console.WriteLine("Primo Membro: " + "\n" + "\n" + "Nome: " + Membro1.Name + "\n");
            Console.WriteLine("Cognome: " + Membro1.Surname + "\n");
            Console.WriteLine("Valutazione: " + Membro1.Valutazione + "\n" + "\n");
            Console.WriteLine("Secondo Membro: " + "\n" + "\n" + "Nome: " + Membro2.Name + "\n");
            Console.WriteLine("Cognome: " + Membro2.Surname + "\n");
            Console.WriteLine("Valutazione: " + Membro2.Valutazione + "\n" + "\n");
            Console.WriteLine("Terzo Membro: " + "\n" + "\n" + "Nome: " + Membro3.Name + "\n");
            Console.WriteLine("Cognome: " + Membro3.Surname + "\n");
            Console.WriteLine("Valutazione: " + Membro3.Valutazione + "\n" + "\n");
            Console.WriteLine("Quarto Membro: " + "\n" + "\n" + "Nome: " + Membro4.Name + "\n");
            Console.WriteLine("Cognome: " + Membro4.Surname + "\n");
            Console.WriteLine("Valutazione: " + Membro4.Valutazione + "\n" + "\n");
            Console.WriteLine("Quinto Membro: " + "\n" + "\n" + "Nome: " + Membro5.Name + "\n");
            Console.WriteLine("Cognome: " + Membro5.Surname + "\n");
            Console.WriteLine("Valutazione: " + Membro5.Valutazione);
            Console.ReadLine();
        }
    }
}
