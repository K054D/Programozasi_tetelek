using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class javitott_bub
    {
        public string Kod()
        {
            return "Rendezés (N,X):\n    I:=N\n    Ciklus amíg I>=2\n        CS:=0\n        Ciklus J=1-től I-1-ig\n            Ha X(J)>X(J+1) akkor Csere(X(J),X(J+1)): CS:=J\n        Ciklus vége\n        I:=CS\n    Ciklus vége\nEljárás vége . ";
        }
        public string Lenyeg()
        {
            return "A javított buborékos rendezés programozási tétel lényege azonos a hagyományos buborékos rendezésével, de hatékonyabbá teszi az algoritmust azzal, hogy optimalizálja az összehasonlítások és cserék számát.";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva, vagy egy fájl első sorába vesszővel elválasztva, a program rendezi ezeket.";
        }
        public string Eredmeny(int[] X, int n)
        {
            DateTime kezd = DateTime.Now;
            int i = n - 1;
            while (i >= 1)
            {
                int cs = 0;
                for (int j = 0; j < i; j++)
                {
                    if (X[j] > X[j + 1])
                    {

                        int segéd = X[j];
                        X[j] = X[j + 1];
                        X[j + 1] = segéd;
                        cs = j;
                    }
                }
                i = cs;
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
