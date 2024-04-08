using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class masolas
    {
        public string Kod()
        {
            return "Másolás ( N , X , Y}:\n    Ciklus I =1 - től N-ig\n        Y(I) : =f( X(I))\n    Cik1us vége\nE1járás vége.";
        }
        public string Lenyeg()
        {
            return "A másolás (vagy másolat készítése) programozási tétel lényege, hogy másolatot készít egy adatsorról vagy egy adott részéről. Ez az algoritmus általában egy másik adatsort hoz létre, amely ugyanazokat az elemeket tartalmazza, mint az eredeti, de önállóan kezelhető és módosítható.";
        }
        public string Feladat()
        {
            return "Írjon be egy szöveget, vagy írja be egy fájl első sorába, a program minden magánhangzóját kicseréli 'e' betűre.";
        }
        public string Eredmeny(string szoveg)
        {
            string kim = "";
            char[] tomb = szoveg.ToCharArray();
            char[] mh = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };

            for (int i = 0; i < tomb.Length; i++)
            {
                if (Eleme(tomb[i]))
                {
                    kim += "e";
                }
                else {
                    kim += tomb[i];
                }
            }

            return kim;
        }

        public bool Eleme(char kar) {
            char[] mh = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            bool x = false;
            for (int j = 0; j < 13; j++)
            {
                if (kar.CompareTo(mh[j]) == 0)
                {
                    x = true;
                }
                
            }
            return x;

        }
    }
}
