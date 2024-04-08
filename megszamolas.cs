using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class megszamolas
    {
        public string Kod()
        {
            return "Megszámolás(N,X,DB):\n   DB:=O\n   Ciklus I=1-től N-ig\n      Ha T(X(I)) akkor DB:=DB+1\n   Ciklus vége\nEljárás vége";
        }
        public string Lenyeg()
        {
            return "A megszámolás (vagy számlálás) programozási tétel egy olyan algoritmus, amely egy adott feltételnek megfelelő elemek számát számolja meg egy adatsorban (például egy tömbben vagy listában). ";
        }
        public string Feladat()
        {
            return "Írjon be egy szöveget, vagy egy fájl első sorába írjon be egy szöveget, a program megadja a benne található magánhangzók számát,";
        }
        public int Eredmeny(string szoveg)
        {
            int db = 0;
            char[] tomb = szoveg.ToCharArray();
            char[] mh = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (tomb[i].CompareTo(mh[j]) == 0) {
                        db++;
                    }
                }
            }

            return db;
        }
    }
}
