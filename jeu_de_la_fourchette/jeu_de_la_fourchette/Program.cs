/*
VARIABLES
	nombre est un entier
	nbJoueur est un entier
	max est un entier
	min est un entier
	essai est un entier
	win est un boolean

DEBUT DU PROGRAMME
	nombre <-- est genere aleatoirement
	essai = 0
	win = false
	min = 0
	max = 100
Debut boucle
Faire
	Ecrire "Saisir un nombre entre ",min," et ",max
	Lire nbJoueur
	Debut si
		si nbJoueur est superieur à nombre
		Alors 
		      Ecrire "C'est moins !!!"
		      max <-- nbJoueur 
		sinon si nbJoueur est inferieur à nombre
		      Ecrire"C'est plus !!!"
		      min <-- nbJoueur 
		sinon
		      win <-- vrai
	Fin Si
	essai <-- essai+1
Tant que win = faux
	Ecrire "Bravo, vous avez trouve en", essai,  " essais "
Fin du programme
*/

using System;
using System.Collections.Generic;
using System.Text;

int nombre, nbJoueur, max, min, essai;
Boolean win;
String saisie;

min = 0;
max = 100;
win = false;
essai = 0;
nombre = new Random().Next(min, max);

do
{
    Console.WriteLine("Saisir un nombre entre " + min + " et " + max);
    saisie = Console.ReadLine();
    nbJoueur = int.Parse(saisie);

    if (nbJoueur > nombre)
    {
        Console.WriteLine("C'est moins !!!");
        max = nbJoueur;
    }
    else if (nbJoueur < nombre)
    {
        Console.WriteLine("C'est plus !!!");
        min = nbJoueur;
    }
    else
    {
        win = true;
    }
    essai++;
} while (!win);

Console.WriteLine("Bravo vous avez trouvé en " + essai);
