using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Ulfi
{
    public partial class Mainform : Form
    {
        private StringCollection Excludes = new StringCollection();
        private StringCollection Includes = new StringCollection();
        private String[] Logzeilen;
        private String Neuerfilter;
        private String Syntax = "+[String] includes all lines containing [String]." + Environment.NewLine + "-[String] excludes all lines containing [String]." + Environment.NewLine + "If no include filters are defined, everything is included, otherwise only what's specified.";

        public Mainform()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ulfi 1.2" + Environment.NewLine + "Universal log filter (Ulfi) is a tool I've written for myself to ease watching through painfully long error logs." + Environment.NewLine + Environment.NewLine + "Made by Kirill Illenseer" + Environment.NewLine + @"http://ulfi.codeplex.com");
        }

        private void AddFilter(String Prompt)
        {
            Neuerfilter = Prompt;
            do
            {
                Neuerfilter = Interaction.InputBox(Syntax, "Add filter", Neuerfilter);
                if (Neuerfilter == "")
                    break;
            } while (!FilterValid(Neuerfilter));
            if (FilterValid(Neuerfilter))
            {
                Filterliste.Items.Add(Neuerfilter);
                Umkopieren();
            }
        }

        private void addFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFilter("");
        }

        private void Bauelisten()
        {
            Includes.Clear();
            Excludes.Clear();
            foreach (String Filterzeile in Filterliste.Items)
            {
                if (Filterzeile.StartsWith("+"))
                {
                    Includes.Add(Filterzeile.TrimStart('+'));
                }
                else if (Filterzeile.StartsWith("-"))
                {
                    Excludes.Add(Filterzeile.TrimStart('-'));
                }
            }
        }

        private void Clearfilters()
        {
            Filterliste.Items.Clear();
            Umkopieren();
        }

        private void EditFilter()
        {
            if (Filterliste.SelectedIndex != -1)
            {
                Neuerfilter = Filterliste.Items[Filterliste.SelectedIndex].ToString();
                do
                {
                    Neuerfilter = Interaction.InputBox(Syntax, "Edit filter", Neuerfilter);
                    if (Neuerfilter == "")
                        break;
                }
                while (!FilterValid(Neuerfilter));
                if (FilterValid(Neuerfilter))
                {
                    Filterliste.Items[Filterliste.SelectedIndex] = (Neuerfilter);
                    Umkopieren();
                }
            }
        }

        private void editFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFilter();
        }

        private void exportFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speichere(Filterexportdialog, Filterliste);
        }

        private void Filterliste_DoubleClick(object sender, EventArgs e)
        {
            EditFilter();
        }

        private void Filterliste_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int iIndex = Filterliste.IndexFromPoint(e.Location);
                if (iIndex != ListBox.NoMatches)
                {
                    Filterliste.SelectedIndex = iIndex;
                }
            }
        }

        private bool FilterValid(String Filter)
        {
            return (Filter != "") && (Filter.StartsWith("+") || Filter.StartsWith("-"));
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clearfilters();
        }

        private void importFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Filterimportdialog.ShowDialog() == DialogResult.OK)
            {
                Filterliste.Items.AddRange(File.ReadAllLines(Filterimportdialog.FileName));
                Umkopieren();
            }
        }

        private bool LineMatchesList(String Zeile, StringCollection Liste)
        {
            foreach (String Listeneintrag in Liste)
            {
                if (Zeile.Contains(Listeneintrag))
                {
                    return true;
                }
            }
            return false;
        }

        private void Logdatei_DoubleClick(object sender, EventArgs e)
        {
            Newfilter("");
        }

        private void Logdatei_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int iIndex = Logdatei.IndexFromPoint(e.Location);
                if (iIndex != ListBox.NoMatches)
                {
                    Logdatei.SelectedIndex = iIndex;
                }
            }
        }

        private void Newfilter(String Operator)
        {
            if (Logdatei.SelectedIndex != -1)
            {
                AddFilter(Operator + Logdatei.SelectedItem.ToString());
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dateiaufmachdialog.ShowDialog() == DialogResult.OK)
            {
                Logzeilen = File.ReadAllLines(Dateiaufmachdialog.FileName);
                Gesamtelemente.Text = Logzeilen.Length.ToString() + " lines total";
                Umkopieren();
                openInNotepadToolStripMenuItem.Enabled = true;
                this.Text = Path.GetFileName(Dateiaufmachdialog.FileName) + " - Universal log filter";
            }
        }

        private void openInNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Dateiaufmachdialog.FileName);
        }

        private void Removefilter()
        {
            if (Filterliste.SelectedIndex != -1)
            {
                Filterliste.Items.RemoveAt(Filterliste.SelectedIndex);
                Umkopieren();
            }
        }

        private void removeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removefilter();
        }

        private void saveFilteredFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Erweiterung = (Path.GetExtension(Dateiaufmachdialog.FileName)).ToLower();
            if (Erweiterung == ".txt")
            {
                Dateispeicherdialog.FilterIndex = 1;
            }
            else if (Erweiterung == ".log")
            {
                Dateispeicherdialog.FilterIndex = 2;
            }
            else
            {
                Dateispeicherdialog.FilterIndex = 3;
                Dateispeicherdialog.DefaultExt = Erweiterung;
            }
            Speichere(Dateispeicherdialog, Logdatei);
        }

        private void Speichere(SaveFileDialog Speicherdialog, ListBox Liste)
        {
            if (Speicherdialog.ShowDialog() == DialogResult.OK)
            {
                String[] Ausgang = new String[Liste.Items.Count];
                Liste.Items.CopyTo(Ausgang, 0);
                File.WriteAllLines(Speicherdialog.FileName, Ausgang);
            }
        }

        private void syntaxHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Syntax);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AddFilter("");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Removefilter();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditFilter();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Clearfilters();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Newfilter("");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Newfilter("+");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Newfilter("-");
        }

        private void Umkopieren()
        {
            if (Logzeilen != null)
            {
                Bauelisten();
                Logdatei.Items.Clear();
                Logdatei.BeginUpdate();
                foreach (string Logzeile in Logzeilen)
                {
                    if (!LineMatchesList(Logzeile, Excludes))
                    {
                        if ((LineMatchesList(Logzeile, Includes)) || Includes.Count == 0)
                        {
                            Logdatei.Items.Add(Logzeile);
                        }
                    }
                }
                Logdatei.EndUpdate();
                Anzeigelemente.Text = Logdatei.Items.Count.ToString() + " lines shown";
            }
        }

        private void GUI_Shown(object sender, EventArgs e)
        {
            try
            {
                Logzeilen = File.ReadAllLines(Environment.GetCommandLineArgs()[1]);
                Gesamtelemente.Text = Logzeilen.Length.ToString() + " lines total";
                Umkopieren();
                openInNotepadToolStripMenuItem.Enabled = true;
                Dateiaufmachdialog.FileName = Environment.GetCommandLineArgs()[1];
                this.Text = Path.GetFileName(Dateiaufmachdialog.FileName) + " - Universal log filter";
            }
            catch { }
        }
    }
}