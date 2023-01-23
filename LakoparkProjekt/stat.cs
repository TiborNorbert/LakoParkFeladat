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
using System.Windows.Forms.VisualStyles;

namespace LakoparkProjekt
{
    public partial class stat : Form
    {
        public stat()
        {
            InitializeComponent();
        }

        private void stat_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo legutolso = directory.GetFiles("statisztika_*.txt").OrderByDescending(f => f.LastWriteTime).First();
                statisz.Text = File.ReadAllText(legutolso.Name);
                statisz.Select(0, 0);
            }
            catch (IOException ex)
            {
                statisz.Text = "Statisztika fájl nem jeleníthető meg!";
                throw;
            }
        }
        private void Form_Statisztika_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
