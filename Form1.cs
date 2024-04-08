using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programozási_tételek
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            takaro.BringToFront();
            BtnMentes.Visible = false;
        }

        private void sorozatszamitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorozatszamitas Sorozatszamitas = new sorozatszamitas();
            LabelLenyeg.Text = Sorozatszamitas.Lenyeg();
            LabelKod.Text = Sorozatszamitas.Kod();
            LabelFeladat.Text = Sorozatszamitas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "sorozatszamitas");
        }
        private void eldöntésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eldontes Eldontes = new eldontes();
            LabelLenyeg.Text = Eldontes.Lenyeg();
            LabelKod.Text = Eldontes.Kod();
            LabelFeladat.Text = Eldontes.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "eldontes");
        }
        private void kIválasztásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kivalasztas Kivalasztas = new kivalasztas();
            LabelLenyeg.Text = Kivalasztas.Lenyeg();
            LabelKod.Text = Kivalasztas.Kod();
            LabelFeladat.Text = Kivalasztas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "kivalasztas");
        }
        private void lineárisKeresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineariskereses Lin = new lineariskereses();
            LabelLenyeg.Text = Lin.Lenyeg();
            LabelKod.Text = Lin.Kod();
            LabelFeladat.Text = Lin.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = true;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "lineariskereses");
        }
        private void megszámolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            megszamolas Megszamolas = new megszamolas();
            LabelLenyeg.Text = Megszamolas.Lenyeg();
            LabelKod.Text = Megszamolas.Kod();
            LabelFeladat.Text = Megszamolas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "megszamolas");
        }
        private void maximumkiválasztásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maximumkivalasztas Max = new maximumkivalasztas();
            LabelLenyeg.Text = Max.Lenyeg();
            LabelKod.Text = Max.Kod();
            LabelFeladat.Text = Max.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "maximumkivalasztas");
        }
        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masolas Masolas = new masolas();
            LabelLenyeg.Text = Masolas.Lenyeg();
            LabelKod.Text = Masolas.Kod();
            LabelFeladat.Text = Masolas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "masolas");
        }
        private void kiválogatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kivalogatas Kivalogatas = new kivalogatas();
            LabelLenyeg.Text = Kivalogatas.Lenyeg();
            LabelKod.Text = Kivalogatas.Kod();
            LabelFeladat.Text = Kivalogatas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "kivalogatas");

        }
        private void szétválogatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szetvalogatas Szetvalogatas = new szetvalogatas();
            LabelLenyeg.Text = Szetvalogatas.Lenyeg();
            LabelKod.Text = Szetvalogatas.Kod();
            LabelFeladat.Text = Szetvalogatas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "szetvalogatas");
        }
        private void metszetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metszet Metszet = new metszet();
            LabelLenyeg.Text = Metszet.Lenyeg();
            LabelKod.Text = Metszet.Kod();
            LabelFeladat.Text = Metszet.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = true;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "metszet");
        }
        private void unióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unio Unio = new unio();
            LabelLenyeg.Text = Unio.Lenyeg();
            LabelKod.Text = Unio.Kod();
            LabelFeladat.Text = Unio.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = true;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "unio");
        }
        private void összefuttatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osszefuttatas Osszefuttatas = new osszefuttatas();
            LabelLenyeg.Text = Osszefuttatas.Lenyeg();
            LabelKod.Text = Osszefuttatas.Kod();
            LabelFeladat.Text = Osszefuttatas.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = true;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "osszefuttatas");
        }
        private void egyszerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            egyszerucseres Egyszerucseres = new egyszerucseres();
            LabelLenyeg.Text = Egyszerucseres.Lenyeg();
            LabelKod.Text = Egyszerucseres.Kod();
            LabelFeladat.Text = Egyszerucseres.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "egyszerucseres");
        }
        private void buborékosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buborekos Buborekos = new buborekos();
            LabelLenyeg.Text = Buborekos.Lenyeg();
            LabelKod.Text = Buborekos.Kod();
            LabelFeladat.Text = Buborekos.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "buborekos");
        }
        private void javítottBuborékosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            javitott_bub Jav_bub = new javitott_bub();
            LabelLenyeg.Text = Jav_bub.Lenyeg();
            LabelKod.Text = Jav_bub.Kod();
            LabelFeladat.Text = Jav_bub.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "jav_bub");
        }
        private void minimumkiválasztásosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            min_rendezes Min_rendezes = new min_rendezes();
            LabelLenyeg.Text = Min_rendezes.Lenyeg();
            LabelKod.Text = Min_rendezes.Kod();
            LabelFeladat.Text = Min_rendezes.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "min_rendezes");
        }
        private void javítottBeillesztésesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jav_beill Jav_beill = new jav_beill();
            LabelLenyeg.Text = Jav_beill.Lenyeg();
            LabelKod.Text = Jav_beill.Kod();
            LabelFeladat.Text = Jav_beill.Feladat();
            TBInput1.Visible = true;
            TBInput2.Visible = false;
            takaro.Visible = false;
            BtnMentes.Visible = false;
            BtnEredmeny.Click += (sender2, e2) => Gombmuvelet(sender2, e2, "jav_beill");
        }
        private void lIneárisKeresésrendezettSorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FajlInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Szöveges fájlok |*.txt";
            ofd.ShowDialog();
            List<string> szoveg = new List<string>();
            StreamReader fo = new StreamReader(ofd.FileName);
            while (!fo.EndOfStream) {
                szoveg.Add(fo.ReadLine());
            }
            if (szoveg.Count == 1)
            {
                TBInput1.Text = szoveg[0];
            }
            else if (szoveg.Count == 2) {
                TBInput1.Text = szoveg[0];
                TBInput2.Text = szoveg[1];
            }
            fo.Close();
            
        }

        private void Gombmuvelet(object sender, EventArgs e, string melyik)
        { 
            switch (melyik) {
                case "sorozatszamitas":
                    sorozatszamitas Sorozatszamitas = new sorozatszamitas();
                    string[] sor_arr = TBInput1.Text.Split(',').ToArray();
                    float[] sor_int = Array.ConvertAll(sor_arr, float.Parse);
                    LabelEredmeny.Text = Sorozatszamitas.Eredmeny(sor_int.Length, sor_int).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "eldontes":
                    eldontes Eldontes = new eldontes();
                    string[] eld_arr = TBInput1.Text.Split(',').ToArray();
                    int[] eld_int = Array.ConvertAll(eld_arr, Int32.Parse);
                    BtnMentes.Visible = true;
                    LabelEredmeny.Text = Eldontes.Eredmeny(eld_int.Length, eld_int).ToString();
                    break;
                case "kivalasztas":
                    kivalasztas Kivalasztas = new kivalasztas();
                    int szam = int.Parse(TBInput1.Text);
                    LabelEredmeny.Text = Kivalasztas.Eredmeny(szam).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "lineariskereses":
                    lineariskereses Lin = new lineariskereses();
                    string[] lin_arrbev = TBInput1.Text.Split(',').ToArray();
                    int[] lin_intbev = Array.ConvertAll(lin_arrbev, Int32.Parse);
                    string[] lin_arrkia = TBInput2.Text.Split(',').ToArray();
                    int[] lin_intkia = Array.ConvertAll(lin_arrkia, Int32.Parse);
                    LabelEredmeny.Text = Lin.Eredmeny(lin_intbev, lin_intkia, lin_intbev.Length).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "megszamolas":
                    megszamolas Megszamolas = new megszamolas();
                    string szovegmegsz = TBInput1.Text;
                    LabelEredmeny.Text = Megszamolas.Eredmeny(szovegmegsz).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "maximumkivalasztas":
                    maximumkivalasztas Max = new maximumkivalasztas();
                    string[] max_arr = TBInput1.Text.Split(',').ToArray();
                    int[] max_int = Array.ConvertAll(max_arr, Int32.Parse);
                    LabelEredmeny.Text = Max.Eredmeny(max_int).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "masolas":
                    masolas Masolas = new masolas();
                    string szovegmas = TBInput1.Text;
                    LabelEredmeny.Text = Masolas.Eredmeny(szovegmas).ToString();
                    BtnMentes.Visible = true;
                    break;
                case "kivalogatas":
                    kivalogatas Kivalogatas = new kivalogatas();
                    string[] kiv_arr = TBInput1.Text.Split(',');
                    double[] kiv_dou = new double[kiv_arr.Length];

                    for (int i = 0; i < kiv_arr.Length; i++)
                    {
                        double result;
                        if (double.TryParse(kiv_arr[i], out result))
                        {
                            kiv_dou[i] = result;
                        }
                       
                    }
                    LabelEredmeny.Text = Kivalogatas.Eredmeny(kiv_dou, kiv_dou.Length);
                    BtnMentes.Visible = true;
                    break;
                case "szetvalogatas":
                    szetvalogatas Szetvalogatas = new szetvalogatas();
                    string[] szet_arr = TBInput1.Text.Split(',').ToArray();
                    int[] szet_int = Array.ConvertAll(szet_arr, Int32.Parse);
                    LabelEredmeny.Text = Szetvalogatas.Eredmeny(szet_int, szet_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "metszet":
                    metszet Metszet = new metszet();
                    string[] met1_arr = TBInput1.Text.Split(',').ToArray();
                    int[] met1_int = Array.ConvertAll(met1_arr, Int32.Parse);
                    string[] met2_arr = TBInput2.Text.Split(',').ToArray();
                    int[] met2_int = Array.ConvertAll(met2_arr, Int32.Parse);
                    LabelEredmeny.Text = Metszet.Eredmeny(met1_int, met1_int.Length, met2_int, met2_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "unio":
                    unio Unio = new unio();
                    string[] uni1_arr = TBInput1.Text.Split(',').ToArray();
                    int[] uni1_int = Array.ConvertAll(uni1_arr, Int32.Parse);
                    string[] uni2_arr = TBInput2.Text.Split(',').ToArray();
                    int[] uni2_int = Array.ConvertAll(uni2_arr, Int32.Parse);
                    LabelEredmeny.Text = Unio.Eredmeny(uni1_int, uni1_int.Length, uni2_int, uni2_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "osszefuttatas":
                    osszefuttatas Osszefuttatas = new osszefuttatas();
                    string[] osz1_arr = TBInput1.Text.Split(',').ToArray();
                    int[] osz1_int = Array.ConvertAll(osz1_arr, Int32.Parse);
                    string[] osz2_arr = TBInput2.Text.Split(',').ToArray();
                    int[] osz2_int = Array.ConvertAll(osz2_arr, Int32.Parse);
                    LabelEredmeny.Text = Osszefuttatas.Eredmeny(osz1_int, osz1_int.Length, osz2_int, osz2_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "egyszerucseres":
                    egyszerucseres Egyszerucseres = new egyszerucseres();
                    string[] egysz_arr = TBInput1.Text.Split(',').ToArray();
                    int[] egysz_int = Array.ConvertAll(egysz_arr, Int32.Parse);
                    LabelEredmeny.Text = Egyszerucseres.Eredmeny(egysz_int, egysz_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "buborekos":
                    buborekos Buborekos = new buborekos();
                    string[] bub_arr = TBInput1.Text.Split(',').ToArray();
                    int[] bub_int = Array.ConvertAll(bub_arr, Int32.Parse);
                    LabelEredmeny.Text = Buborekos.Eredmeny(bub_int, bub_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "jav_bub":
                    javitott_bub Jav_bub = new javitott_bub();
                    string[] javbub_arr = TBInput1.Text.Split(',').ToArray();
                    int[] javbub_int = Array.ConvertAll(javbub_arr, Int32.Parse);
                    LabelEredmeny.Text = Jav_bub.Eredmeny(javbub_int, javbub_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "min_rendezes":
                    min_rendezes Min_rendezes = new min_rendezes();
                    string[] min_arr = TBInput1.Text.Split(',').ToArray();
                    int[] min_int = Array.ConvertAll(min_arr, Int32.Parse);
                    LabelEredmeny.Text = Min_rendezes.Eredmeny(min_int, min_int.Length);
                    BtnMentes.Visible = true;
                    break;
                case "jav_beill":
                    jav_beill Jav_beill = new jav_beill();
                    string[] bei_arr = TBInput1.Text.Split(',').ToArray();
                    int[] bei_int = Array.ConvertAll(bei_arr, Int32.Parse);
                    LabelEredmeny.Text = Jav_beill.Eredmeny(bei_int, bei_int.Length);
                    BtnMentes.Visible = true;
                    break;










            }
        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "Szöveges fájlok (*.txt)|*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                StreamWriter kif = new StreamWriter(filename);
                kif.Write(LabelEredmeny.Text);
                kif.Close();
            }
        }

        
    }
}
