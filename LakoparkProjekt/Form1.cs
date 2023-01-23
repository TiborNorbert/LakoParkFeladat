using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        HappyLiving happyliving = new HappyLiving(@"..\..\lakoparkok.txt");
        readonly int buttonSize = 50;
        int aktPark = 0;
        List<Image> szintek = new List<Image>();
        Form statick = new stat();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szintek.Add(Image.FromFile(@"Kepek\kereszt.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz1.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz2.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz3.jpg"));
            PanelUpdate();
        }
        void PanelUpdate()
        {
            this.Text = happyliving.Parkok[aktPark].Nev + " lakópark";
            if (aktPark == 0)
            {
                bal_button.Enabled = false;
                bal_button.Hide();
            }
            else if (aktPark == happyliving.Parkok.Count - 1)
            {
                jobb_button.Enabled = false;
                jobb_button.Hide();
            }
            else
            {
                bal_button.Enabled = true;
                bal_button.Show();
                jobb_button.Enabled = true;
                jobb_button.Show();

            }
            pictureBox1.BackgroundImage = happyliving.Parkok[aktPark].Nevado;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            tarolo.Controls.Clear();
            for (int i = 0; i < happyliving.Parkok[aktPark].Hazak.GetLength(1); i++)
            {
                for (int j = 0; j < happyliving.Parkok[aktPark].Hazak.GetLength(0); j++)
                {
                    Button g = new Button();
                    g.BackgroundImage = szintek[happyliving.Parkok[aktPark].Hazak[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                    int utca = j;
                    int haz = i;
                    g.Click += (o, e) =>
                    {
                        happyliving.Parkok[aktPark].next(utca, haz);
                        PanelUpdate();
                    };
                    tarolo.Controls.Add(g);
                }
            }
        }
        private void bal_button_Click(object sender, EventArgs e)
        {
            aktPark--;
            PanelUpdate();
        }
        private void jobb_button_Click(object sender, EventArgs e)
        {
            aktPark++;
            PanelUpdate();
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (happyliving.Mentes())
            {
                MessageBox.Show("Sikeres Mentés");
            }
            else
            {
                MessageBox.Show("Adatok mentése nem sikerült!");
            }
        }
        private void statisz_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("statisztika_" + DateTime.Now.ToString("yyyyMMdd") + ".txt"))
                {
                    sw.WriteLine("Statisztika");
                    foreach (LakoPark item in happyliving.Parkok)
                    {
                        item.aranyszamolasok();
                        item.teljesbeepitette();
                    }
                    sw.WriteLine();
                    bool nincsTeljesenBeepitett = true;
                    foreach (LakoPark item in happyliving.Parkok)
                    {
                        if (item.vanteljesutca)
                        {
                            sw.WriteLine($"A {item.Nev} lakópark {item.elsoteljesutca}. utcája teljesen beépített");
                            nincsTeljesenBeepitett = false;
                            break;
                        }
                    }
                    if (nincsTeljesenBeepitett)
                    {
                        sw.WriteLine("Nincs Teljesen Beépitve");
                    }
                    sw.WriteLine();
                    LakoPark legjobbanBeepitett = happyliving.Parkok.OrderBy(s => s.aranyszamolas).Last();
                    sw.WriteLine($"\nA legjobban beépített a {legjobbanBeepitett.Nev} lakópark {legjobbanBeepitett.aranyszamolas * 100:N1} % beépítettséggel.");

                    sw.WriteLine();
                    sw.WriteLine($"\nA HappyLiving cégnek az összes bevétele {happyliving.Parkok.Sum(a => a.ertekesitesiOsszeg()):N0} Ft");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("A statisztikai adatok mentése sikertelen!\n\n" + ex.Message);
                return;
            }
            statick.ShowDialog();
        }
    }
}
