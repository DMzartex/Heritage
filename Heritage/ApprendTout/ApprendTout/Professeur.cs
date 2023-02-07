using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendTout
{
    internal class Professeur : Personne
    {
		private string _specialistation;

		public string Specialisation
		{
			get { return _specialistation; }
			set { _specialistation = value; }
		}

        public Professeur(string nom, string prenom, string adresse, string codePostal, string localite, string specialisation) : base(nom, prenom, adresse, codePostal, localite)
        {
           _specialistation= specialisation;
        }

    }
}
