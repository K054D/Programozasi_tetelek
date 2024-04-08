using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class buborekos
    {
        public string Kod()
        {
            return "Rendezés (N,X):\n    Ciklus I=N-től 2-ig -1-esével\n        Ciklus J=I-től I-1-ig\n            Ha X(J)>X(J+1) akkor Csere (X(J),X(J+1))\n        Ciklus vége\n    Ciklus vége\nEljárás vége";
        }
        public string Lenyeg()
        {
            return "A buborékos rendezés működése során szomszédos elemeket hasonlítunk össze, és ha az előző elem nagyobb, akkor azokat felcseréljük. Ezt az összehasonlítást és cserét addig folytatjuk, amíg a lista teljesen rendezetté válik.";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva, vagy egy fájl első sorába vesszővel elválasztva, a program rendezi ezeket.";
        }
        public string Eredmeny(int[] X, int n)
        {
            DateTime kezd = DateTime.Now;
            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (X[j] > X[j + 1]) {
                        int segéd = X[i];
                        X[j] = X[j+1];
                        X[j+1] = segéd;
                    }
                }
            }
            DateTime vege = DateTime.Now;
            TimeSpan ido = (vege - kezd);
            string kif = "";
            for (int k = 0; k < n - 1; k++)
            {
                kif += X[k] + ",";
            }
            kif += X[n - 1];
            kif += $"\n{ido}";
            return kif;
        }
    }
}
