using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class kivalasztas
    {
        public string Kod()
        {
            return "Kiválasztás(N,X,SORSZ):\n   I:=1\n   Ciklus amíg nem T(X(I))\n      I:=I+1\n    Ciklus vége\n   SORSZ:=I\nEljárás vége.";
        }
        public string Lenyeg()
        {
            return "A kiválasztás algoritmusának célja az, hogy hatékonyan és pontosan megkeresse az adott kritérium alapján legmegfelelőbb elemet a sorozatból.";
        }
        public string Feladat()
        {
            return "Írjon be egy számot, a program megmondja a legkisebb 1-től különböző osztóját, vagy olvasson be egy fájlt melyben egy szám található";
        }
        public int Eredmeny(int szam)
        {
            int i = 2;

            while (i <= szam && szam%i != 0)
            {
                i++;
            }

            return i;
        }
    }
}
