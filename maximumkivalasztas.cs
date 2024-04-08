using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class maximumkivalasztas
    {
        public string Kod()
        {
            return "Maximumkiválasztás(N ,X,MAX ):\n    MAX:=1\n    Ciklus I=2 -től N-ig\n      Ha X(MAX) <X(I) akkor MAX:=I\n    Ciklus vége\nEljárás vége . ";
        }
        public string Lenyeg()
        {
            return "A maximumkiválasztás programozási tétel lényege, hogy egy adott adatsorban (például egy tömbben vagy listában) megtalálja a legnagyobb értékű elemet.";
        }
        public string Feladat()
        {
            return "Írja be egy kórház betegeinek hőmérsékletét vesszővel elválasztva, vagy egy fájl első sorában vesszővel elválasztva, a program megmondja, hogy ki a leglázasabb.";
        }
        public string Eredmeny(int[] hom)
        {
            int max = 0;

            for (int i = 1; i < hom.Length; i++)
            {
                if (hom[i] > hom[max]) { 
                    max = i;
                }
            }

            return $"{(max+1).ToString()}. beteg a leglázasabb: {hom[max].ToString()}°C";
        }
    }
}
