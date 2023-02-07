using System;
using System.Collections.Generic;
using System.Text;

namespace EX2_Chien
{
    internal class Animal
    {
        protected string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        protected string _birthdayDate;

        public string BirthdayDate
        {
            get { return _birthdayDate; }
            set { _birthdayDate = value; }
        }

        protected int _numberPuce;

        public int NumberPuce
        {
            get { return _numberPuce; }
            set { _numberPuce = value; }
        }

        protected int _size;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        protected bool _competition;

        public bool Competition
        {
            get { return _competition; }
            set { _competition = value; }
        }

        public Animal(string nom,string birthdayDate,int numberPuce, int size, bool competition)
        {
            _nom = nom;
            _birthdayDate = birthdayDate;
            _numberPuce = numberPuce;
            _size = size;
            _competition = competition;
        }

        public string Sleeping()
        {
            string sleeping = Nom + "se repose pour être en forme : )";
            return sleeping;
        }

        public string Eat()
        {
            string eat = Nom + "mange des croquettes";
            return eat;
        }
    }
}
