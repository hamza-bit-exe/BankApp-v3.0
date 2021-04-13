using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class compte_epargne :Compte_Bancaire
    {
        public compte_epargne(client c1, Devise d) : base(c1, d)
        {

        }
        public override bool debiter(Devise montant)
        {
           
            if (base.debiter(montant))
            {
                if (montant < solde / 2)
                {
                    solde -= montant;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
