using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Personne
    {
        Personne() { } //quand on ne met rien devant une méthode, par défaut c'est en mode privé
        /*public string nom;
        public string prenom;
        public int age;*/ // on ne met JAMAIS les variables en public
        private string nom;
        private string prenom;
        private int age;
        public Personne(string prenom, string nom)
        {
            this.SetPrenom(prenom);
            this.SetNom(nom);
        }
        public string Nom
        {
            get { return nom; }
             private set { nom = value; } //value = valeur que l'utilisateur va entrer - avec private, la valeur n'est pas visible de l'extérieur
        }

        /* public string Nom{get;private set;} peut remplacer
         private string nom;
         public string Nom
         {get{return nom;}
         private set{nom = value;}*/
        public string GetNom()
        {
            return nom;
        }
        public void SetNom()
        {

        }
        public void Marcher()
        { }
        public void Courrir()
        { }
    }
}
