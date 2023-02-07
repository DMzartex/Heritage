using System;

namespace EX3_Entreprise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Membre[] mesPersonnes = new Membre[10];
            // Ouvrier
            for(int i = 0; i< 5; i++)
            {
                mesPersonnes[i] = new Ouvrier(i, "nom" + i,"prenom" + i, "21/01/2004", new DateTime(2012, 12, 31));
            }
            // Cadre
            for(int i = 5; i< 8 ; i++)
            {
                mesPersonnes[i] = new Cadre(i, "nom" + i, "prenom" + i, "21/01/2004", 3);
            }
            //Directeur
            for(int i = 8; i< 10; i++)
            {
                mesPersonnes[i] = new Directeur(i, "nom" + i, "prenom" + i, "21/01/2004", 100000, 40);
            }

            // Affichage des caractéristique et des salaiares.
            for(int x = 0; x < mesPersonnes.Length; x++)
            {
                Console.WriteLine(mesPersonnes[x].AfficheCaracteristique());
                Console.WriteLine(mesPersonnes[x].AfficheSalaire(mesPersonnes[x].CalcSalaire()));
            }

            Console.ReadLine();
        }
    }
}
