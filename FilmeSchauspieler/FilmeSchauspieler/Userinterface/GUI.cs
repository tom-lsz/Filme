using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmeSchauspieler.SystemSpecification;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.Userinterface
{
    public partial class GUI : Form
    {
        private ISystemSpecification systemSpecification;

        public GUI()
        {
            InitializeComponent();

            cmb_select.Items.Add("Filme");
            cmb_select.Items.Add("Schauspieler");
            cmb_select.SelectedItem = null;

            cmb_newrecord.Items.Add("Filme");
            cmb_newrecord.Items.Add("Schauspieler");
        }

        public GUI(ISystemSpecification systemSpecification)
        {
            InitializeComponent();
            this.systemSpecification = systemSpecification;

            cmb_select.Items.Add("Filme");
            cmb_select.Items.Add("Schauspieler");
            cmb_select.SelectedItem = null;

            cmb_newrecord.Items.Add("Filme");
            cmb_newrecord.Items.Add("Schauspieler");
        }

        private void lib_all_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select.Text == "Filme")
            {
                KeyValuePair<int, string> tempMovie = (KeyValuePair<int, string>) lib_all.SelectedItem;
                Dictionary<int, string> curActors = this.systemSpecification.getActors();
                lb_countprop.Text = "Anzahl der Schauspieler " + curActors.Count.ToString();
                lib_properly.DataSource = new List<string>();

                lib_properly.DataSource = curActors.ToList();
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                KeyValuePair<int, string> tempActor = (KeyValuePair<int, string>) lib_all.SelectedItem;
                Dictionary<int, string> curMovies = this.systemSpecification.getMovies();
                lb_countprop.Text = "Anzahl der Filme " + curMovies.Count.ToString();
                lib_properly.DataSource = new List<String>();

                lib_properly.DataSource = curMovies.ToList();
            }
        }

        private void cmb_select_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_countprop.Text = "";
            lib_all.DataSource = new List<string>();

            Dictionary<int, string> content; 

            if (cmb_select.Text == "Filme")
            {
                content = systemSpecification.getMovies();
                lb_countall.Text = "Anzahl der Filme ";
            }
            else
            {
                content = systemSpecification.getActors();
                lb_countall.Text = "Anzahl der Schauspieler ";
            }

            lb_countall.Text = lb_countall.Text + content.Count.ToString();
            lib_all.DataSource = content.ToList();

            lib_properly.DataSource = new List<string>();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            pl_create.Visible = true;

            lib_existingrecords.DataSource = new List<String>();
            lib_electedrecords.Items.Clear();
        }

        private void cmb_newrecord_SelectedValueChanged(object sender, EventArgs e)
        {
            lib_existingrecords.DataSource = new List<String>();
            lib_electedrecords.Items.Clear();

            if (cmb_newrecord.Text == "Filme")
            {
                lb_addentry.Text = "vorhandene Schauspieler";
                lb_electedrecords.Text = "ausgewählte Schauspieler";
                lib_existingrecords.DataSource = systemSpecification.getActors().ToList();
            }
            else
            {
                lb_addentry.Text = "vorhandene Filme";
                lb_electedrecords.Text = "ausgewählte Filme";
                lib_existingrecords.DataSource = systemSpecification.getMovies().ToList();
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            pl_create.Visible = false;
            cmb_newrecord.SelectedItem = null;
            cmb_select.SelectedItem = null;
            lib_all.DataSource = new List<String>();
        }

        private void btn_addelectedrecord_Click(object sender, EventArgs e)
        {
            string add;
            if (cmb_newrecord.Text == "")
            {
                MessageBox.Show("Bitte eine Kategorie auswählen (Film/Schauspieler");
            }
            else
            {
                add = lib_existingrecords.SelectedItem.ToString();
                if (lib_electedrecords.Items.Contains(add) == true)
                {
                    if (cmb_newrecord.Text == "Filme")
                    {
                        MessageBox.Show("Der Schauspieler wurde bereits hinzugefügt!");
                    }
                    else
                    {
                        MessageBox.Show("Der Film wurde bereits hinzugefügt!");
                    }

                }
                else
                {
                    lib_electedrecords.Items.Add(add);
                }
            }
            lib_electedrecords.Sorted = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_newrecord.Text == "")
            {
                if (tb_name.Text == "")
                {
                    MessageBox.Show("Bitte Kategorie auswählen und Namen eintragen!");
                }
                else
                {
                    MessageBox.Show("Bitte Kategorie auswählen!");
                }
            }
            else
            {
                if (tb_name.Text == "")
                {
                    MessageBox.Show("Bitte Namen eintragen!");
                }
                else
                {
                    string name;

                    if (cmb_newrecord.Text == "Filme")
                    {
                        List<string> actors = new List<string>();
                        foreach (string a in lib_electedrecords.Items)
                        {
                            actors.Add(a);
                        }
                        name = tb_name.Text;
                    }
                    else
                    {
                        List<string> movies = new List<string>();
                        foreach (string m in lib_electedrecords.Items)
                        {
                            movies.Add(m);
                        }
                        name = tb_name.Text;
                    }
                }
            }
        }
    }
}
