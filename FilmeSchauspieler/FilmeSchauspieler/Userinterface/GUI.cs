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
                Movie tempMovie = (Movie) lib_all.SelectedItem;
                List<Actor> curActors = tempMovie.getActors();
                lb_countprop.Text = "Anzahl der Schauspieler " + curActors.Count.ToString();
                lib_properly.Items.Clear();

                foreach(Actor a in curActors)
                {
                    lib_properly.Items.Add(a);
                }
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                Actor tempActor = (Actor) lib_all.SelectedItem;
                List<Movie> curMovies = tempActor.getMovies();
                lb_countprop.Text = "Anzahl der Filme " + curMovies.Count.ToString();
                lib_properly.Items.Clear();

                foreach(Movie m in curMovies)
                {
                    lib_properly.Items.Add(m);
                }
            }
        }

        private void cmb_select_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_countprop.Text = "";
            lib_all.Items.Clear();

            if (cmb_select.Text == "Filme")
            {
                List<Movie> temp = systemSpecification.getMovies();
                lb_countall.Text = "Anzahl der Filme " + temp.Count.ToString();
                foreach (Movie m in temp)
                {
                    lib_all.Items.Add(m);
                }
            }
            else
            {
                List<Actor> temp = systemSpecification.getActors();
                lb_countall.Text = "Anzahl der Schauspieler " + temp.Count.ToString();
                foreach (Actor m in temp)
                {
                    lib_all.Items.Add(m);
                }
            }

            lib_properly.Items.Clear();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            pl_create.Visible = true;
            lib_existingrecords.Items.Clear();
            lib_electedrecords.Items.Clear();
        }

        private void cmb_newrecord_SelectedValueChanged(object sender, EventArgs e)
        {
            lib_existingrecords.Items.Clear();
            lib_electedrecords.Items.Clear();

            if (cmb_newrecord.Text == "Filme")
            {
                lb_addentry.Text = "vorhandene Schauspieler";
                lb_electedrecords.Text = "ausgewählte Schauspieler";
                List<Actor> temp = systemSpecification.getActors();
                foreach (Actor m in temp)
                {
                    lib_existingrecords.Items.Add(m);
                }
            }
            else
            {
                lb_addentry.Text = "vorhandene Filme";
                lb_electedrecords.Text = "ausgewählte Filme";
                List<Movie> temp = systemSpecification.getMovies();
                foreach (Movie m in temp)
                {
                    lib_existingrecords.Items.Add(m);
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            pl_create.Visible = false;
            cmb_newrecord.SelectedItem = null;
            cmb_select.SelectedItem = null;
            lib_all.Items.Clear();
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
        }
    }
}
