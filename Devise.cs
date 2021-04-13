using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class Devise
    {
        string nomD;
       double valeur;
        public Devise(string n, double v)
        {
            if (n=="MAD" || n == "Euros" || n == "Dollars")
            {
                this.nomD = n;
                valeur = v;
            }
            else
                Console.WriteLine("devise invalide");
        }
        public void afficher()
        {
            Console.WriteLine("Le solde est : " + this.valeur
                + "de devise :" + this.nomD);
        }

        public void retirer_taux()
        {
            this.valeur -= this.valeur * 0.05;
                    
            
        } 
        public Devise(double v)
        {
            valeur = v;
        }
        public static bool operator <(Devise a, Devise b)
        {
            return a.valeur < b.valeur;

        }
        public static bool operator >(Devise a, Devise b)
        {
            return a.valeur > b.valeur;

        }
        public static Devise operator +(Devise a, Devise b)
        {
            Devise res = new Devise(a.valeur + b.valeur);
            return res;
        }
        public static Devise operator - (Devise a, Devise b)
        {
            Devise res = new Devise(a.valeur - b.valeur);
            return res;
        }
        public static Devise operator /(Devise a, int b)
        {
            if (b != 0)
            {
                Devise res = new Devise(a.valeur / b);
                return res;
            }
            else
                return null;
        }
    }
}
