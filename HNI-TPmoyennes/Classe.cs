using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{ 
    class Classe
    {
        public List<Eleve> Eleves { get; internal set; }
        public List<Matiere> Matieres { get; internal set; }

        public Classe(string nomClasse)
        {
            Eleves = new List<Eleve>();
            Matieres = new List<Matiere>();
            NomClasse = nomClasse;  
        }

        public string NomClasse { get; internal set; }

        public void ajouterEleve(string prenom, string nom)
        {
            Eleve eleve = new Eleve(prenom, nom);
            if (Eleves.Count < 30)
            {
                Eleves.Add(eleve);
            }
            else
            {
                Console.WriteLine("Nombre d'élèves max atteint");
            }
            
        }

        public void ajouterMatiere(string nomMatiere)
        {
            Matiere matiere = new Matiere(nomMatiere);
            if (Matieres.Count < 10)
            {
                Matieres.Add(matiere);
            }
            else
            {
                Console.WriteLine("Nombre de matières max atteint");
            }
            
        }

        internal float MoyenneFloat(int indiceMatiere)
        {
            var listMoyenneDansLaMatiere = Eleves.Select(e => e.MoyenneFloat(indiceMatiere));
            var moyenne = listMoyenneDansLaMatiere.Sum() / listMoyenneDansLaMatiere.Count();
            return moyenne;
        }

        internal float MoyenneFloat()
        {
            var listMoyenneDansLaClasse = Eleves.Select(e => e.MoyenneFloat());
            var moyenne = listMoyenneDansLaClasse.Sum() / listMoyenneDansLaClasse.Count();
            return moyenne;
        }
        internal string Moyenne(int indiceMatiere)
        {
            return MoyenneFloat(indiceMatiere).ToString("0.00");
        }

        internal string Moyenne()
        {
            return MoyenneFloat().ToString("0.00");
        }
    }
}