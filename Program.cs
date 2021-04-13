using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_desComptes
{
    class Program
    {
        static void Main(string[] args)
        { client c1 = new client("hamza", "zouhri", "casablanca");
            Devise dev = new Devise("MAD", 3000);
            Devise dev2 = new Devise(1000);
            Compte_Bancaire cc = new compte_payant(c1,dev);
            cc.crediter(dev2);
            cc.afficher();
            Console.ReadKey();
        }
    }
}
