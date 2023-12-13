/*
Exercice 1.1 calcul de la moyenne de 2 nombre

VARIABLES
	nombre1 est un entier
	nombre2 est un entier
	moyenne est un reel
DEBUT DU PROGRAMME
	Ecrire "Saisir le 1er nombre"
	Lire nombre1
	Ecrire "saisir le 2eme nombre"
	Lire nombre2
	moyenne <-- (nombre1 + nombre2)/2d
	Ecrire "La moyenne est :",moyenne
FIN DU PROGRAMME
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace moyenne
{
	class Program
	{
		static void Main(string[] args)
		{
            // declaration des variables
            int nombre1;
            int nombre2;
            double moyenne;
            string saisie = "";

			// Etape 1 : lecture de nombre1 et nombre2 
			Console.WriteLine("Saisir le 1er nombre");
			saisie = Console.ReadLine();
			nombre1 = int.Parse(saisie);
			Console.WriteLine("Saisir le 2eme nombre");
			saisie = Console.ReadLine();
			nombre2 = int.Parse(saisie);

			// Etape 2 : calcul de la moyenne
			moyenne = (nombre2 + nombre1)/2d;

            Console.WriteLine("La moyenne est : " + moyenne);

        }
	}
}