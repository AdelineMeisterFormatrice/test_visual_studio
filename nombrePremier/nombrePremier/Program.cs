/*
Exercice 2.6 Nombre premier

Variables
	nombre est un entier
	i est un entier
	compteur est un entier
Debut du programme
	Ecrire "Saisir un nombre entier"
	lire nombre
	compteur <-- 0
	Debut boucle pour
	Pour i allant de 2 a nombre-1
		Debut Si
			Si nombre mod i = 0
			Alors
				Compteur <-- compteur+1
		Fin si
	Fin pour
	Debut si
		Si compteur = 0
		Alors
			Ecrire "Le nombre ",nombre," est premier"
		Sinon
			Ecrire "le nombre ",nombre," n'est pas premier"
	Fin si
Fin du programme
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace nbPremier
{
	class Program
	{
		static void Main(string[] args)
		{
			int nombre;
			int compteur;
			string saisie;

			Console.WriteLine("Saisir un nombre entier");
			saisie = Console.ReadLine();
			nombre = int.Parse(saisie);

			compteur = 0;

			for(int i = 2;i < nombre;i++)
			{
				if(nombre%i == 0)
				{
					compteur++;
				}
			}

			if(compteur == 0)
			{
				Console.WriteLine("Le nombre " + nombre + " est premier");
			}
			else
			{
				Console.WriteLine("Le nombre " + nombre + " n'est pas premier");
			}
		}
	}
}