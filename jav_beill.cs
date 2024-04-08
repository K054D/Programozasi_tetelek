using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class jav_beill
    {
        public string Kod()
        {
            return "Rendezés(N,X):\n    Ciklus I=2-től N-ig\n        J:=I-1 : Y:=X(I)\n        Ciklus amíg J>0 és X(J)>Y\n            X(J+1):=X(J) : J:=J-1\n        Ciklus vége\n        X(J+1):=Y\n    Ciklus vége\nEljárás vége.";
        }
        public string Lenyeg()
        {
            return "A beillesztéses rendezés algoritmusa rendezetté alakítja a listát, úgy hogy az egyes elemeket beilleszti a már rendezett részbe. Minden új elem beillesztésekor olyan helyet keres, ahová az új elem bekerülhet úgy, hogy az rendezett maradjon.";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva, vagy egy fájl első sorába vesszővel elválasztva, a program rendezi ezeket.";
        }
        public string Eredmeny(int[] X, int n)
        {
            DateTime kezd = DateTime.Now;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int y = X[i];
                while (j >= 0 && X[j] > y)
                {
                    X[j + 1] = X[j]; j--;

                }

                X[j + 1] = y;

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
