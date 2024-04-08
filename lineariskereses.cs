using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class lineariskereses
    {
        public string Kod()
        {
            return "Keresés(N,X,VAN,SORSZ):\n   I:=1\n   Ciklus amíg I<=N és nem T(X(I))\n      I:=I+1\n      Ciklus vége\n   VAN:= (I<=N)\n   Ha VAN akkor SORSZ:=I\nEljárás vége. ";
        }
        public string Lenyeg()
        {
            return "A lineáris keresés egy algoritmus, amely egy adott elemet keres egy adatsorban (például egy tömbben vagy listában) úgy, hogy egymás után vizsgálja az elemeket a sorrendjükben, amíg megtalálja a keresett elemet vagy eléri a sor végét.";
        }
        public string Feladat()
        {
            return "Adjuk meg egy üzlet egyhavi forgalmát: az első tömbbe a napi bevételeket írja vesszővel elválasztva, a másikba a kiadásokat. Fájlbeolvasás esetén az első sorba a bevételeket, a másodikba a kiadásokat írja vesszővel elválasztva. A program megad egy napot, amely nem volt nyereséges.";
        }
        public int Eredmeny(int[] bev, int[] kiad, int n)
        {
            int i = 0;

            while (i < n && (kiad[i] - bev[i] < 0))
            {
                i++;
            }

            return i+1;
        }
    }
}
