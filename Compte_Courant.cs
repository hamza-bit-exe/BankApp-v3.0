using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class Compte_Courant : Compte_Bancaire
    {
        private int numeroCB;
        private static int cmp=0;
        private Devise decouvertMax;
        public Compte_Courant(client leTitulaire, 
            Devise soldeInitial,
            int numeroCB, Devise decouvertMax)
        : base(leTitulaire, soldeInitial)
        {
            this.numeroCB = ++cmp;
            this.decouvertMax = decouvertMax;
        }
        public override bool debiter(Devise montant)
        {
            
            // on n'effectue le débit que si le solde final reste supérieur au découvert
            if (base.debiter(montant))
            {
                if (solde - montant > decouvertMax)
                {
                    base.debiter(montant);
                    solde -= montant;
                    return true;
                }
                else return false;
            }
            else
                return false;
        
        }
    }
}
