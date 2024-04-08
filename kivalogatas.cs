using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class kivalogatas
    {
        public string Kod()
        {
            return "Kiválogatás (N, X, DB,Y ):\n    DB:=O\n    Ciklus I=1-től N-ig\n        Ha T(X(I)) akkor DB:=DB+1: Y(DB):=I\n    Ciklus vége\nEljárás vége.";
        }
        public string Lenyeg()
        {
            return "A kiválogatás (vagy szűrés) programozási tétel egy olyan algoritmus, amely egy adott feltételnek megfelelő elemeket válogat ki egy adatsorból (például egy tömbből vagy listából) és ezeket egy új adatsorba helyezi.";
        }
        public string Feladat()
        {
            return "Írja be egy osztály tanulóinak átlagát vesszővel elválasztva vagy egy fájl első sorában vesszővel elválasztva, a program megmondja, hogy hányadik sorszámú tanulók jeles átlagúak.";
        }
        public string Eredmeny(double[] atlagok, int n) {
            string ki = "";
            for (int i = 0; i < n; i++)
            {
                if (atlagok[i] >= 4.5) {
                    ki += $"{(i+1).ToString()},";
                }
            }
            string kifele = "";
            if (ki.Length != 0)
            {
                kifele = ki.Remove(ki.Length - 1, 1);
            }
            else {
                kifele = "-1";
            }
            return kifele;
        }
      
    }
}
