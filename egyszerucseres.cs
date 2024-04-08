using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class egyszerucseres
    {
        public string Kod()
        {
            return "Rendezés(N,X):\n    Ciklus I=1-től N-1-ig\n        Ciklus J=I+1-től N-ig\n            Ha X(I)>X(J) akkor Csere (X(I),X(J))\n        Ciklus vége\n    Ciklus vége\nEljárás vége . ' ";
        }
        public string Lenyeg()
        {
            return "Az egyszerű cserés rendezés tétel lényege az, hogy egy rendezetlen listát lépésről lépésre rendezetté alakítunk át. Az algoritmus működése során szomszédos elemeket hasonlítunk össze, és ha az előző elem nagyobb, akkor azokat felcseréljük. ";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva, vagy egy fájl első sorába vesszővel elválasztva, a program rendezi ezeket.";
        }
        public string Eredmeny(int[] X, int n)
        {
            DateTime kezd = DateTime.Now;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (X[i] > X[j])
                    {

                        int segéd = X[i];
                        X[i] = X[j];
                        X[j] = segéd;
                    }
                }

            }
            DateTime vege = DateTime.Now;
            TimeSpan ido = (vege - kezd);
            string kif = "";
            for (int k = 0; k < n-1; k++)
            {
                kif += X[k] + ",";
            }
            kif += X[n - 1];
            kif += $"\n{ido}";
            return kif;
        }
    }
}
