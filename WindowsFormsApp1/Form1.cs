using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Mauslager : Form
    {
        public Mauslager()
        {
            InitializeComponent();
        }

        public void Form1_Load()
        {

        }
        List<Maus> mause = new List<Maus>();
        private void Mauslager_Load(object sender, EventArgs e)
        {
            List<string> namen = new List<string>
            {
                "GamingMaus ",
                "Logitechdiesdas ",
                "Razer Maus ",
                "Corsair Maus ",
                "idk"
            };
            List<string> hersteller = new List<string>
            {
                "Gaminghersteller",
                "Logitech",
                "Razer",
                "Corsair",
                "idk Hersteller"
            };
            List<string> extraTastenAnzahl = new List<string>
            {
                "6",
                "1",
                "7",
                "3",
                "0"
            };
            List<string> zustand = new List<string>
            {
                "Neu",
                "Gut",
                "OK",
                "Gebrauchsspuren",
                "Neu"
            };
            List<bool> rad = new List<bool>
            {
                true,
                true,
                true,
                true,
                false
            };
            List<string> verbindung = new List<string>
            {
                "Kabel",
                "Funk",
                "Kabel",
                "Kabel",
                "Bluetooth"
            };

            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Hersteller", typeof(string));
            //table.Columns.Add("extra Tasten", typeof(int));
            //table.Columns.Add("Rad vorhanden", typeof(bool));
            //table.Columns.Add("Zustand", typeof(string));
            for (i = 0; i < namen.Count; i++)
            {
                MausOhneKabel neuMaus = new MausOhneKabel(i, namen[i], hersteller[i], extraTastenAnzahl[i], zustand[i], rad[i]);
                mause.Add(neuMaus);
                dataGridViewMaus.Rows.Add(MausToString(neuMaus));

            }
        }
        private int i = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" && HerstellerBox.Text != "" && TastenBox.Text != "" && RadBox.Text != "" && VerbindungBox.Text != "" && ZustandBox.Text != "")
            {
                Maus neuMaus;
                if (VerbindungBox.Text == "Bluetooth" || VerbindungBox.Text == "Funk")
                {
                    neuMaus = new MausOhneKabel(i, NameBox.Text, HerstellerBox.Text, TastenBox.Text, ZustandBox.Text, RadBox.Checked);
                }
                else
                {
                    neuMaus = new MausMitKabel(i, NameBox.Text, HerstellerBox.Text, TastenBox.Text, ZustandBox.Text, RadBox.Checked);
                }
                dataGridViewMaus.Rows.Add(MausToString(neuMaus));

                mause.Add(neuMaus);

                i++;
            }
            else
            {
                MessageBox.Show("Ein oder mehrere Felder sind nicht ausgefüllt", "Du Idiot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public class Maus
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Hersteller { get; set; }
            public string TastenAnzahl { get; set; }
            public string Zustand { get; set; }
            public bool Akku { get; set; }
            public bool HatRad { get; set; }
            public Maus(int id, string name, string hersteller, string tastenAnzahl, string zustand, bool hatRad)
            {
                this.Id = id;
                this.Name = name;
                this.Hersteller = hersteller;
                this.TastenAnzahl = tastenAnzahl;
                this.Zustand = zustand;
                this.HatRad = hatRad;
            }
        }
        public class MausOhneKabel : Maus
        {
            public string Verbindung { get; set; }

            public MausOhneKabel(int id, string name, string hersteller, string tastenAnzahl, string zustand, bool hatRad)
                : base(id, name, hersteller, tastenAnzahl, zustand, hatRad)
            {
                this.Akku = true;

            }
        }
        public class MausMitKabel : Maus
        {

            public MausMitKabel(int id, string name, string hersteller, string tastenAnzahl, string zustand, bool hatRad)
                : base(id, name, hersteller, tastenAnzahl, zustand, hatRad)
            {
                this.Akku = false;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            dataGridViewMaus.Rows.Clear();
            if (counter > 2)
            {
                mausNameVorher = "";
            }
            string textToSearch = searchItem.Text;
            foreach (Maus maus in mause)
            {
                if (!string.IsNullOrWhiteSpace(textToSearch))
                {
                        Search(maus, maus.Id.ToString(), textToSearch);
                        Search(maus, maus.Name, textToSearch);
                        Search(maus, maus.Hersteller, textToSearch);
                        Search(maus, maus.TastenAnzahl, textToSearch);
                        Search(maus, maus.HatRad.ToString(), textToSearch);
                        Search(maus, maus.Zustand, textToSearch);
                }
                else
                {
                    dataGridViewMaus.Rows.Add(MausToString(maus));
                }
            }
        }
        private string mausNameVorher = "";
        private int counter;
        private void Search(Maus maus, string subject, string textToSearch)
        {

            if (subject.IndexOf(textToSearch, StringComparison.CurrentCultureIgnoreCase) > -1)
            {
                if (mausNameVorher != maus.Name)
                {
                    dataGridViewMaus.Rows.Add(MausToString(maus));
                    mausNameVorher = maus.Name;
                    counter++;
                }
            }

        }

        private string[] MausToString(Maus maus)
        {
            string[] row = { maus.Id.ToString(), maus.Name, maus.Hersteller, maus.TastenAnzahl, maus.HatRad.ToString(), maus.Zustand };
            return row;
        }
    }
}
