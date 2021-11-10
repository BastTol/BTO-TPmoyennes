using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Eleve
    {
        public string Prenom;
        public string Nom;
        public List<Note> Notes { get; internal set; }

        public Eleve(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
            Notes = new List<Note>();
        }

        internal void ajouterNote(Note note)
        {
            if (Notes.Count < 200)
            {
                Notes.Add(note);
            }
            else
            {
                Console.WriteLine("Nombre de notes max atteint");
            }
             
        }

        internal float MoyenneFloat(int indiceMatiere)
        {
            var listNotesDansLaMatiere = Notes.Where(n => n.matiere == indiceMatiere).Select(n => n.note);
            var moyenne = listNotesDansLaMatiere.Sum() / listNotesDansLaMatiere.Count();
            return moyenne;
        }

        internal float MoyenneFloat()
        {
            var listNote = Notes.Select(n => n.note);
            var moyenne = listNote.Sum() / listNote.Count();
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