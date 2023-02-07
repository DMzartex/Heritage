using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendTout
{
    internal class Employe : Personne
    {
		private string _dateEmbauche;

		public string  DateEmbauche
		{
			get { return _dateEmbauche; }
			set { _dateEmbauche = value; }
		}

		private string _fonction;

		public string Fonction
		{
			get { return _fonction; }
			set { _fonction = value; }
		}

        public Employe(string nom, string prenom, string adresse, string codePostal, string localite, string dateEmbauche, string fonction) : base(nom, prenom, adresse, codePostal, localite)
        {
            _dateEmbauche=dateEmbauche;
            _fonction=fonction;
        }
    }
}
