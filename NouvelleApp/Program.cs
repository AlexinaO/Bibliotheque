using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque;


namespace NouvelleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var personne = new Personne("Alexina","Orsoni");
            personne.Nom = "Alexina";
            Console.Write(personne.Nom);
        }
    }
}
