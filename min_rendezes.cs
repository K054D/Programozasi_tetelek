using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class min_rendezes
    {
        public string Kod()
        {
            return "Rendezés(N,X):\n    Ciklus I=1 -től N-1-ig\n        MIN:=I\n        Ciklus J=I+1-től N-ig\n            Ha X(MIN)>X(J) akkor MIN:=J\n        Ciklus vége\n        Csere(X(I),X(MIN))\n    Ciklus vége\nEljárás vége.";
        }
        public string Lenyeg()
        {
            return "A minimum kiválasztásos rendezés algoritmus működése során a rendezetlen rész legkisebb elemét keresi meg, majd ezt helyezi a rendezett rész végére.";
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
                int MIN = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (X[MIN] < X[j]) MIN = j;
                }
                int segéd = X[i];
                X[i] = X[MIN];
                X[MIN] = segéd;
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
