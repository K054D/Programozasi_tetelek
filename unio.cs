using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class unio
    {
        public string Kod()
        {
            return "Egyasítés (N, X , M , Y , DB , Z ) :\r\nZ:=X: DB : =N\r\nCiklus J=l -tól M-ig\r\nI:=l\r\nCiklus amíg I� és X ( I)*Y ( J)\r\nI : =I+l\r\nCiklus yége\r\nHa I>N akkor DB : =DB+l : Z ( DB ) : =X ( I)\r\nCiklus vége\r\nEljárás vége . ";
        }
        public string Lenyeg()
        {
            return "A programozási tétel lényege, hogy két halmazt összefűz egy harmadik  halmazzá úgy, hogy az új halmazban minden elem csak egyszer szerepeljen.";
        }
        public string Feladat()
        {
            return "Írja be két szám osztót vesszővel elválasztva, vagy egy fájl első két sorába vesszővel elválasztva, a program megmondja a két szám közös osztóit.";
        }
        public string Eredmeny(int[] X, int n, int[] Y, int m)
        {
            List<int> unio = new List<int>();
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                unio.Add(X[i]);
            }
            y = n;
            for (int i = 0; i < m; i++)
            {
                int j = 0;
                while (j < n && unio[j]!=Y[i])
                {
                    j++;
                }
                if (j >= n)
                {
                    unio.Add(Y[i]);
                    y++;
                }
            }
            string kif = "";
            for (int i = 0; i < y - 1; i++)
            {
                kif += unio[i].ToString() + ",";
            }
            kif += unio[y - 1].ToString();
            return kif;
        }
        }
}
