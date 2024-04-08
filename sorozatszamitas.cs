using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class sorozatszamitas
    {
        public string Kod() {
            return "Sorozatszámítás(N:egész,X:tömb,S:egész): \n   össz:=0 \n   Ciklus I=1-től N-ig \n       össz:=össz+X[I] \n   Ciklus vége \n   S:=össz\nEljárás véqe";
        }
        public string Lenyeg() {
            return "Több adatból művelettel egy eredményt képzünk";
        }
        public string Feladat()
        {
            return "Írja be egy osztály osztályzatait ','-vel elválasztva, vagy importáljon be egy ','-kel elválasztott számokat tartalmazó fájlt, a program kiszámolja ezek átlagát.";
        }
        public float Eredmeny(int n, float[] x) {
            float osszeg = 0;

            for (int i = 0; i < n; i++)
            {
                osszeg += x[i];
                
            }

            return (osszeg/n);

        }



    }
}
