using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class logaritmikus
    {
        public string Kod()
        {
            return "Keresés(N,X,Y,VAN,SORSZ):\n    E:=1: U:=N\n    Ciklus\n        K:=[(E+U)/2]\n            Elágazás Y<X(K) esetén U:=K-1\n            Y>X(K) esetén E:=K+1\n        Elágazás vége\n    amíg E<=U és X(K)!=Y\n    Ciklus vége\n    VAN:=(E<=U)\n    Ha VAN akkor SORSZ:=K\nEljárás vége. ";
        }
        public string Lenyeg()
        {
            return "A logaritmikus keresés egy hatékony keresési algoritmus, amely egy rendezett tömbben vagy listában keres. A lényege abban rejlik, hogy a keresési tartományt folyamatosan felezve hatékonyan találja meg a keresett elemet vagy értéket.";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva rendezett sorozatban, vagy egy fájl első sorába vesszővel elválasztva, és írja be a keresett számot a második sorba, vagy a fájl második sorába, a program megkeresi a számot a sorban.";
        }
        public int Eredmeny(int[] X, int k)
        {
            int ki = -1;
            int min = 0;
            int max = X.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (k == X[mid])
                {
                    ki = mid;
                    return ki;
                }
                else if (k < X[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return ki;
        }
    }
}
