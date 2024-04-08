using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class metszet
    {
        public string Kod()
        {
            return "Metszet(N,X,M,Y,DB,Z) :\n   DB :=0\n   Ciklus I=1-től N-ig\n      J:=1\n      Ciklus amíg J<=M és X(I)!=Y(J)\n         J:=J+1\n      Ciklus vége\n      Ha J<=M akkor DB : =DB+1 : Z (DB) : =X(I)\n   Ciklus vége\nEljárás vége .";
        }
        public string Lenyeg()
        {
            return "A metszet programozási tétel lényege azon elemek megtalálása két halmaz között, amelyek mindkét halmazban szerepelnek.";
        }
        public string Feladat()
        {
            return "Írja be két szám osztót vesszővel elválasztva, vagy egy fájl első két sorába vesszővel elválasztva, a program megmondja a két szám közös osztóit.";
        }
        public string Eredmeny(int[] X, int n, int[] Y, int m)
        {
            List<string> metsz = new List<string>();
            int y = 0;
            for (int i = 0; i < m; i++)
            {
                int j = 0;
                while (j < n && X[j] != Y[i]) //eldöntés
                {
                    j++;
                }
                if (j < n)
                {
                    metsz.Add(Y[i].ToString());
                    y++;
                }

            }
            string kif = "";
            for (int i = 0; i < y-1; i++)
            {
                kif+= metsz[i].ToString()+",";
            }
            kif += metsz[y - 1];
            return kif;
        }
    }
}
