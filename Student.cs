using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqlProjet_Final
{
    class Student
    {
        //definition des attributs de la classe Etudiant

        public int NumeroEtudiant { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }

        // definition du premier constructeur

        public Student()
        {

        }

        // definition du second constructeur
        public Student(int numeroEtudiant)
        {
            this.NumeroEtudiant = numeroEtudiant;
        }

        // definition du troixieme constructeur
        public Student(int numeroEtudiant, String nom, String prenom) : this(numeroEtudiant)
        {

            this.Nom = nom;
            this.Prenom = prenom;
        }



    }
}

