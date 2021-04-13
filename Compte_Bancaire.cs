using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    abstract class  Compte_Bancaire
    {
       
        private readonly client titulaire;
        protected Devise solde;
        
        //protected static Devise plafond;

        public Compte_Bancaire()
        {

        }
        public Compte_Bancaire(client titu,Devise somme)
        {
           
            this.titulaire = titu;
            this.solde = somme;
        }
        public virtual bool crediter(Devise somme)
        {

            Devise valnul = new Devise(0);
            if (somme > valnul)
            {
                this.solde += somme;

                //Operation o = new Operation("crediter", somme);
                // op[i] = o;
               // liste.Add(o);
                //op[i].afficher();
                // i++;
                return true;
            }
            return false;
        }
        public void afficher()
        {
           
                this.solde.afficher();
        }
        public virtual bool debiter(Devise somme)
        {
            Devise valnul = new Devise(0);
            if (somme > valnul)
            {

                if (this.solde > somme)
                {

                    this.solde -= somme;
                    // Operation o = new Operation("debiter", somme);

                    //liste.Add(o);
                    return true;
                }
                else
                {
                    Console.WriteLine("somme > solde ");
                    return false;
                }
            
           
            }
            else
            {
                Console.WriteLine("somme  invalide ");
                return false;
            }

        }
    }
}
