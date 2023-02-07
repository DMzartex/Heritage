using System;

namespace ApprendTout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool estVoisin;
            
            Personne[] mesPersonnes = new Personne[3];

            mesPersonnes[0] = new Etudiant("Michaux", "Dorian", "17 Rue Cuvelier", "5300", "Andenne", 6, "17 Rue de Namur");
            mesPersonnes[1] = new Employe("Lambert", "Fred", "19 Rue Cuvelier", "5300","Andenne","12/02/2012","Informaticien");
            mesPersonnes[2] = new Professeur("Leseau", "surTerre", "22 Rue Lambert", "7300", "Durbuy","informatique");
            
            for(int i = 0; i < mesPersonnes.Length; i++)
            {
               Console.WriteLine(mesPersonnes[i].FabriqueEtiq());  
            }

            if (mesPersonnes[1].EstVoisin(mesPersonnes[0].CodePostal))
            {
                Console.WriteLine(mesPersonnes[1].Nom + " est voisin avec une autre personne");
            }
            else
            {
                Console.WriteLine(mesPersonnes[1].Nom + " n'est pas voisin avec une autre personne");
            }

            if (mesPersonnes[2].EstVoisin(mesPersonnes[0].CodePostal))
            {
                Console.WriteLine(mesPersonnes[2].Nom + " est voisin avec une autre personne");
            }
            else
            {
                Console.WriteLine(mesPersonnes[2].Nom + " n'est pas voisin avec une autre personne");
            }

            Console.ReadLine();


        }
    }
}