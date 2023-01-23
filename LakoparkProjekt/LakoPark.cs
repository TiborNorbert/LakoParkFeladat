using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    internal class LakoPark
    {
        int[,] hazak;
        readonly int maxHazSzam;
        readonly string nev;
        readonly int utcakSzama;
        private readonly Image nevado;
        public int elsoteljesutca = 0;
        public bool vanteljesutca = false;
        public double aranyszamolas = 0;

        public int[,] Hazak { get => hazak; set => hazak = value; }

        public int MaxHazSzam => maxHazSzam;

        public string Nev => nev;

        public int UtcakSzama => utcakSzama;

        public Image Nevado => nevado;

        public LakoPark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.Hazak = hazak;
            this.maxHazSzam = maxHazSzam;
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.nevado = Image.FromFile(@"Kepek\" + nev + ".jpg");
            teljesbeepitette();
        }

        public void next(int utca, int haz)
        {
            hazak[utca, haz] = (hazak[utca, haz] == 3) ? 0 : ++hazak[utca, haz];
        }

        public void teljesbeepitette()
        {
            bool vanBeepitett;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                vanBeepitett = true;
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    if (hazak[i, j] == 0)
                    {
                        vanBeepitett = false;
                        break;
                    }
                }
                if (vanBeepitett)
                {
                    this.vanteljesutca = true;
                    this.elsoteljesutca = ++i;
                    break;
                }
            }
        }

        public void aranyszamolasok()
        {
            double db = 0;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    if (hazak[i, j] > 0)
                    {
                        db++;
                    }
                }
            }
            this.aranyszamolas = db / (hazak.GetLength(0) * hazak.GetLength(1));
        }

        public double ertekesitesiOsszeg()
        {
            double osszeg = 0;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    osszeg += nm(hazak[i, j]) * 300000;
                }
            }
            return osszeg;
        }

        private double nm(int szintek)
        {
            double nm = 0;
            switch (szintek)
            {
                case 1:
                    nm = 80;
                    break;
                case 2:
                    nm = 80 + 70;
                    break;
                case 3:
                    nm = 80 + 70 + 50;
                    break;
                default:
                    break;
            }
            return nm;
        }
    }
}

