using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class eldontes
    {
        public string Kod()
        {
            return "Eldöntés(N,X,VAN):\n    I:=1\n  Cik1us  amíg I<=N  és  nem T(X(I)) \n       I:=I+1\n    Cik1us vége\n   VAN:=(I<=N)\nEljárás  vége. ";
        }
        public string Lenyeg()
        {
            return "Egy adott feltételt alkalmaz egy sorozat vagy kollekció minden elemére, és megállapítja, hogy az adott feltétel igaz-e legalább egy elemre vagy sem.";
        }
        public string Feladat()
        {
            return "Írja be egy tanuló év végi osztályzatait ','-vel elválasztva vagy importáljon be egy fájlt, melynek első sorában ','-kel elválasztott osztályzatok vannak, a program eldönti, hogy a tanuló kitűnő volt-e.";
        }
        public bool Eredmeny(int n, int[] x)
        {
            int i = 0;

            while (i < n && x[i] == 5) {
                i++;        
            }

            return i >= n;
        }
    }
}
