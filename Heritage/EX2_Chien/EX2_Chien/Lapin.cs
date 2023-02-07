using System;
using System.Collections.Generic;
using System.Text;

namespace EX2_Chien
{
    internal class Lapin : Animal
    {
		private int _tailleOreille;

		public int TailleOreille
		{
			get { return _tailleOreille; }
			set { _tailleOreille = value; }
		}

		public Lapin(string nom, string birthdayDate, int numberPuce, int size, bool competition, int tailleOreille) : base(nom, birthdayDate, numberPuce, size, competition)
        {
			_tailleOreille = tailleOreille;
		}

		public string Bonds()
		{
			string bonds = Nom + " fait des bons !";
			return bonds;
		}

	}
}
