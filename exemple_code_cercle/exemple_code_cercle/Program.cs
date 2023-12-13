using System;
using System.Collections.Generic;
using System.Text;

namespace exemple
{
    class Cercle
    {
        static void Main(string[] args)
        {
            // delcaration de variables
            string saisie;
            double rayon;
            double perimetre;

            // Etape 1 : lecture du rayon
            Console.WriteLine("Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();
            // Etape 2 : calcul et affichage du perimetre
            rayon = Convert.ToDouble(saisie);
            perimetre = 2 * Math.PI * rayon;
            Console.WriteLine("le cercle de rayon " + rayon);
            Console.WriteLine(" a pour perimetre : " + perimetre);

            Console.ReadLine();
        }
    }
}
