using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class client
    {
        private string nom;
        private string prenom;
        private string adressse;
        private List<Compte_Bancaire> listeCompte;

        public client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adressse = a;
            listeCompte = new List<Compte_Bancaire>();
        }

        public void afficher()
        {

            Console.WriteLine("le nom est :" + this.nom);
            Console.WriteLine("le prenom est :" + this.prenom);
            Console.WriteLine("l'adresse est :" + this.adressse);
        }
        public void ajouterCompte(Compte_Bancaire c)
        {
            listeCompte.Add(c);
        }
    }
}
