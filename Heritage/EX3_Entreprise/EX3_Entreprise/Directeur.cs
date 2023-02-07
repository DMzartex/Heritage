using System;
using System.Collections.Generic;
using System.Text;

namespace EX3_Entreprise
{
    internal class Directeur : Membre
    {
        private double _chiffreAffaire;

        public double ChiffreAffaire
        {
            get { return _chiffreAffaire; }
            set { _chiffreAffaire = value; }
        }

        private double _pourcentage;

        public double Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }

        
        public Directeur(int matricule, string nom, string prenom, string birthdayDate, double chiffreAffaire, double pourcentage) : base(matricule,nom,prenom,birthdayDate)
        {
            _chiffreAffaire=chiffreAffaire;
            _pourcentage = pourcentage;
        }

        public override double calcSalaire()
        {
            double salaire = (ChiffreAffaire * Pourcentage) / 100;
            return salaire;
        }
    }
}
