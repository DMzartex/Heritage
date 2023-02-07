using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EX3_Entreprise
{
    internal class Membre
    {
		protected int _matricule;

		public int Matricule
		{
			get { return _matricule; }
			set { _matricule = value; }
		}

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

		protected string _birthdayDate;

		public string BirthdayDate
		{
			get { return _birthdayDate; }
			set { _birthdayDate = value; }
		}

		public Membre(int matricule,string nom, string prenom,string birthdayDate)
		{
			_matricule = matricule;
			_nom = nom;
			_prenom = prenom;
			_birthdayDate = birthdayDate;
		}

        public string afficheSalaire(double salaire)
        {
            string result = "Le salaire de l'ouvrier est de : " + salaire + " écus";
            return result;
        }
        public string AfficheCaracteristique()
		{
			string result = "Prénom : " + Prenom + "\r\n" + " Nom : " + Nom + "\r\n" + "Matricule : " + Matricule + "\r\n" + "Date de naissance : " + BirthdayDate;
			return result;
        }

        public virtual double calcSalaire()
        {
            double salaire = 0;
            return salaire;
        }

    }
}
