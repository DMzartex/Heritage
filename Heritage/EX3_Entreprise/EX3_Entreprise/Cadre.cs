using System;
using System.Collections.Generic;
using System.Text;

namespace EX3_Entreprise
{
    internal class Cadre : Membre
    {
        private int _indice;

        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        public Cadre(int matricule, string nom,string prenom,string birthdayDate,int indice) : base(matricule,nom,prenom,birthdayDate)
        {
            _indice = indice;
        }

        public override double calcSalaire()
        {
            double salaire = 0;
            switch (Indice)
            {
                case 1:  salaire = 13000;
                    break;
                case 2: salaire = 15000;
                    break;
                case 3: salaire = 17000;
                    break;
                case 4: salaire = 20000;
                    break;
            }

            return salaire;
        }


    }
}
