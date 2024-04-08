using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    internal class szetvalogatas
    {
        public string Kod()
        {
            return "Szétválogatás (N,X, DBY , Y , Z , DB Z ) :\n    DBY:=O: DBZ : =O\n    Ciklus I=1 -től N-ig\n    Ha T ( X ( I ) ) akkor DBY : =DBY+ 1: Y(DBY) : =X (I)\n        különben DBZ : =DBZ+1 : Z ( DBZ ) : =X (I)\n    Ciklus vége\nEljárás vége";
        }
        public string Lenyeg()
        {
            return "A szétválogatás (vagy osztályozás) programozási tétel lényege a beolvasott adatok két csoportba rendezése egy adott feltétel alapján.";
        }
        public string Feladat()
        {
            return "Írjon be számokat vesszővel elválasztva, vagy egy fájl első sorába vesszővel elválasztva, a program szétválogatja a párosakat és páratlanokat";
        }
        public string Eredmeny(int[] X, int n)
        {
            List<string> Y = new List<string>();
            List<string> Z = new List<string>();
            int DBY = 0;
            int DBZ = 0;
            for (int i = 0; i < n; i++)
            {
                
                if (X[i] % 2 == 0)
                {

                    Y.Add($"{X[i].ToString()}");
                    DBY++;
                }
                else
                {

                    Z.Add($"{X[i].ToString()}");
                    DBZ++;
                }
                
            }
            string kifparos = "";
            for (int j = 0; j < DBY-1; j++)
            {
                kifparos += Y[j] + ",";
            }
            kifparos += Y[DBY - 1];
            string kifptlan = "";
            for (int j = 0; j < DBZ - 1; j++)
            {
                kifptlan += Z[j] + ",";
            }
            kifptlan += Z[DBZ - 1];
            return kifparos+"\n"+kifptlan;
        }
    }
}
