using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class compte_payant :Compte_Bancaire
    {
        public compte_payant(client c1, Devise d) : base(c1, d)
        {

        }
         public void sup_taux()
        {
            this.valeur -= this.valeur * 0.05;
        } 
        public override bool crediter(Devise somme)
        {
            if (base.crediter(somme))
            {
                solde.sup_taux();
                return true;
            }
            else
                return false;
        }
        public override bool debiter(Devise somme)
        {
            if (base.debiter(somme))
            {
                solde.sup_taux();
                return true;
            }
            else
                return false;
        }
    }
}
