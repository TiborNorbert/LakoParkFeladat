using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    internal class HappyLiving
    {
        List<LakoPark> parkok = new List<LakoPark>();

        internal List<LakoPark> Parkok { get => parkok; set => parkok = value; }

        public HappyLiving(string filenev)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string parkneve = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int utcakSzama = int.Parse(sor[0]);
                        int hazakSzama = int.Parse(sor[1]);
                        int[,] hazak = new int[utcakSzama, hazakSzama];
                        string ujSor = string.Empty;
                        while ((ujSor = sr.ReadLine()) != "")
                        {
                            sor = ujSor.Split(';');
                            hazak[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = int.Parse(sor[2]);
                        }
                        parkok.Add(new LakoPark(parkneve, utcakSzama, hazakSzama, hazak));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public bool Mentes()
        {
            bool sikeres = false;
            try
            {
                File.Copy("lakoparkok.txt", "lakoparkok_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".txt");
                using (StreamWriter sw = new StreamWriter("lakoparkok.txt"))
                {
                    foreach (LakoPark item in parkok)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.UtcakSzama, item.MaxHazSzam));
                        for (int i = 0; i < item.Hazak.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Hazak.GetLength(1); j++)
                            {
                                sw.WriteLine(string.Join(";", i, j, item.Hazak[i, j]));
                            }
                        }
                        sw.WriteLine();
                    }
                }
                sikeres = true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return sikeres;
        }

        public double OsszesErtekesitesiOsszeg()
        {
            double sum = 0;
            foreach (LakoPark item in parkok)
            {
                sum += item.ertekesitesiOsszeg();
            }
            return sum;
        }
    }
}

