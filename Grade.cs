using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqlProjet_Final
{
    class Grade
    {
        //definition des attributs de la classe Note

        public List<Student> etudiantliste { get; set; } = new List<Student>();
        public List<Course> courslite { get; set; } = new List<Course>();
        public double Note { get; set; }

        // Creation d'une liste pour la classe Note

        List<Grade> listenote = new List<Grade>();

        // definition du constructeur

        public Grade()
        {

        }





        // definition d'une methode pour ajouter un cours dans la liste
        //prenant comme argument un cours c

        public void Addcour(Course c) { this.courslite.Add(c); }

        // definition d'une methode pour ajouter un cours dans la liste
        //prenant comme argument la classe, le numeroDuCours, le code, et titre

        public void Addcour(int classe, int numeroDuCours, int code, String titre) { this.Addcour(new Course(classe, numeroDuCours, code, titre)); }

        // definition d'une methode pour ajouter un etudiant dans la liste
        //prenant comme argument un etudiant c

        public void Addetudiant(Student c) { this.etudiantliste.Add(c); }


        // definition d'une methode pour ajouter un etudiant dans la liste
        //prenant comme argument le numeroEtudiant, le nom et le prenom

        public void Addetudiant(int numeroEtudiant, String nom, String prenom) { this.Addetudiant(new Student(numeroEtudiant, nom, prenom)); }

        // definition d'une methode pour ajouter une note dans la liste
        //prenant comme argument une note g
        public void Addnote(Grade g)
        {
            this.listenote.Add(g);
        }

        // definition d'une methode pour ajouter une note dans la liste
        //prenant comme argument le numeroEtudiant, le numeroDuCours et la note
        public void Addnote(Student numeroEtudiant, Course numeroDuCours, double note)
        { this.Addetudiant(new Grade(numeroEtudiant, numeroDuCours, note)); }





    }

}

