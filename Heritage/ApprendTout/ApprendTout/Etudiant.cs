using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendTout
{
    internal class Etudiant : Personne
    {
		private int _annee;

		public int Annee
		{
			get { return _annee; }
			set { _annee = value; }
		}

		private string _ad_Kot;

		public string AdKot
		{
			get { return _ad_Kot; }
			set { _ad_Kot = value; }
		}

		public Etudiant(string nom, string prenom, string adresse,string codePostal,string localite, int annee, string adKot) : base(nom,prenom,adresse,codePostal,localite)
		{
			_annee= annee;
			_ad_Kot= adKot;
		}

		public override string FabriqueEtiq()
		{
			string etiq = "Nom " + Nom + " Prenom " + Prenom + " Adresse " + Adresse + " Code Postal " + CodePostal + " Localite " + Localite + " adresse de kot " + AdKot + " Année " + Annee;
			return etiq;
        }
	}
}
