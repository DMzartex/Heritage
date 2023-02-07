using System;
using System.Collections.Generic;
using System.Text;

namespace EX2_Chien
{
    internal class Chien : Animal
    {
        public Chien(string nom, string birthdayDate, int numberPuce, int size, bool competition) : base(nom, birthdayDate,numberPuce,size, competition)
        {

        }

        public string Aboyer()
        {
            string aboyer = Nom + "à aboyer !";
            return aboyer;
        }
    }
}
