using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class osszefuttatas
    {
        public string Kod()
        {
            return "Összefuttatás(N,X,M,Y,DB,Z):\n    I:=1 : J:=1: DB:=0\n    Ciklus amíg I<=N és J<=M\n      DB:=DB+1\n      Elágazás\n        X(I)<Y(J) esetén Z (DB):=X(I) : I:=I+1\n        X(I)=Y(J) esetén Z(DB):=X(I) : I:=I+1 : J:=J+1\n        X(I)>Y(J) esetén Z(DB):=Y(J) : J:=J+1\n      Elágazás vége\n    Ciklus vége\n    Ciklus amíg I<=N\n      DB:=DB+1 : Z(DB):=X(I) : I:=I+1\n    Ciklus vége\n    Ciklus amíg J<=M\n      DB:=DB+1 : Z(DB):=Y(J) : J:=J+1\n    Ciklus vége\nEljárás vége";
        }
        public string Lenyeg()
        {
            return "A programozási tétel arra szolgál, hogy két vagy több rendezett listát egyesít egyetlen rendezett listává. A tétel lényege, hogy az összefuttatás során az elemeket úgy illesztjük össze, hogy a végeredmény továbbra is rendezett maradjon.";
        }
        public string Feladat()
        {
            return "Írja be két rendezett adathalmaz elemeit vesszővel elválasztva vagy egy fájlban két sorba, a program összefuttatja ezeket egy rendezett adathalmazba.";
        }
        public string Eredmeny(int[] X, int n, int[] Y, int m)
        {
            List<int> runio = new List<int>();
            int i = 0, j = 0, y = 0;
            while (i < n && j < m)
            {

                if (X[i] < Y[j]) { runio.Add(X[i]); i++; }
                else if (X[i] == Y[j]) { runio.Add(X[i]); i++; j++; }
                else { runio.Add(Y[j]); j++; }
                y++;

            }
            while (i < n)
            {
                runio.Add(X[i]);
                i++;
                y++;
            }
            while (j < m)
            {
                runio.Add(Y[j]);
                j++;
                y++;
            }
            string kif = "";
            for (int k = 0; k < y-1; k++)
            {
                kif += runio[k].ToString() + ",";
            }
            kif += runio[y - 1];
            return kif;
        }
    }
}
