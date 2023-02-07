using System;
using System.Collections.Generic;
using System.Text;

namespace EX3_Entreprise
{
    internal class Ouvrier : Membre
    {
        private DateTime _dateEntree;

        public DateTime DateEntree
        {
            get { return _dateEntree; }
            set { _dateEntree = value; }
        }

        public Ouvrier(int matricule, string nom, string prenom, string birthdayDate, DateTime dateEntree) : base(matricule,nom,prenom,birthdayDate)
        {
            _dateEntree = dateEntree;
        }

        public double calcDate()
        {
            DateTime date = DateTime.Now;
            TimeSpan diff = date.Subtract(DateEntree);
            double years = diff.TotalDays / 365.0;
            return years;
        }

        public override double calcSalaire()
        {
           double annee = calcDate();
           double salaire = 2500; 
           
            for(int i = 0; i < annee - 1; i++)
            {
                if(salaire < 5000)
                {
                    salaire = salaire + 100;
                }
            }

            return salaire;
        }

    }
}
