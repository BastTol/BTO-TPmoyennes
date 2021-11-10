using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Matiere
    {
        string NomMatiere;

        public Matiere(string nomMatiere)
        {
            NomMatiere = nomMatiere;
        }

        public override string ToString()
        {
            return NomMatiere;
        }

    }
}
