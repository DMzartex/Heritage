using System;
using System.Collections.Generic;
using System.Text;

namespace EX2_Chien
{
    internal class Chat : Animal
    {
        public Chat(string nom, string birthdayDate, int numberPuce, int size, bool competition) : base(nom, birthdayDate, numberPuce, size, competition)
        {

        }

        public string Miauler()
        {
            string miauler = Nom + " miaule car il a faim !";
            return miauler;
        }

        public string Ronronne()
        {
            string ronronne = Nom + " ronronne car il est content !";
            return ronronne;
        }
    }
}
