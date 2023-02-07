using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendTout
{
	internal class Personne
    {
		protected string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		protected string _prenom;

		public string Prenom
		{
			get { return _prenom; }
			set { _prenom = value; }
		}

		protected string _adresse;

		public string Adresse
		{
			get { return _adresse; }
			set { _adresse = value; }
		}


		protected string _codePostal;

		public string CodePostal
		{
			get { return _codePostal; }
			set { _codePostal = value; }
		}

		protected string _localite;

		public string  Localite
		{
			get { return _localite; }
			set { _localite = value; }
		}

		public Personne(string nom,string prenom,string adresse,string codePostal, string localite)
		{
			_nom = nom;
			_prenom = prenom;
			_adresse = adresse;
			_codePostal = codePostal;
			_localite = localite;
		}


		public virtual string FabriqueEtiq()
		{
			string etiq = "Nom " + Nom + " Prenom " + Prenom + " Adresse " + Adresse + " Code Postal " + CodePostal + " Localite " + Localite;
			return etiq;
		}

		public bool EstVoisin(string postalCode)
		{
			bool voisin = false;

            if (postalCode == CodePostal)
            {
                voisin = true;
            }

            return voisin;
		}

	}
}
