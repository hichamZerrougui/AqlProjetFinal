using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqlProjet_Final
{
    class Course
    {

        //definition des attributs de la classe Cours

        public int NumeroDuCours { get; set; }
        public int Code { get; set; }
        public String Titre { get; set; }

        // definition du premier constructeur

        public Course()
        {

        }

        // definition du second constructeur

        public Course(int numeroDuCours)
        {
            this.NumeroDuCours = numeroDuCours;
        }

        // definition du troixieme constructeur

        public Course(int classe, int numeroDuCours, int code, String titre) : this(numeroDuCours)
        {
            this.Classe = classe;
            this.Code = code;
            this.Titre = titre;

        }
    }
}
