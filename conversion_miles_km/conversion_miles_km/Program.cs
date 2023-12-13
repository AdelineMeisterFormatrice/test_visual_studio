/*
Variable
	kilometre est reel
	miles est un reel
	fermeture_prog est un booleen
	quit est une chaine de caractere
	saisieUtilisataire est une chaine de caractere

Debut du programme
	quit <-- "q"
	Debut tant que
	Tant que fermeture_prog est faux
	faire
		Ecrire "saisir le nombre de kilometre ou tapez q pour quitter"
		lire saisiUtilisateur
		debut si
			Si saisiUtilisateur est egale à quit
			Alors
				fermeture_prog est vrai
			Sinon
				kilometre <-- convertion en reel de saisieUtilisateur
				Debut si
					Si kilometre est < 0.01 OU kilometre > 1 000000
					Alors
						Ecrire "saisie invalide, saisissez une valeur comprise entre 0.01 et 1000000"
						Lire saisie utilisateur
					Sinon
						miles <-- kilometre/1.609
						Ecrire kilometre, " kilometre est egale à ",miles," miles"
		Fin si
	Fin tant que
Fin du programme
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace conversion
{
	class Program
	{
		static void Main(string[] args)
		{
			double km, miles;
			Boolean fermeture_prog;
			String quit;
			String saisie;
			fermeture_prog = false;
			quit = "q";

			while(!fermeture_prog)
			{
				Console.WriteLine("saisir le nombre de kilometre ou tapez q pour quitter");
				saisie = Console.ReadLine();

				if(saisie.Equals(quit))
				{
					fermeture_prog=true;
				}
				else
				{
					km = int.Parse(saisie);

					if(km < 0.01 || km > 1000000)
					{
						Console.WriteLine("saisie invalide, saisissez une valeur comprise entre 0.01 et 1000000");
						saisie = Console.ReadLine();
					}
					else
					{
						miles = km / 1.609;
						Console.WriteLine(km + "kilometre est egale à " + miles + " miles");
					}
				}

            }
		}
	}
}