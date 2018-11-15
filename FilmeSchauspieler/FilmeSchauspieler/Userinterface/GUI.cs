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
            cmb_select.SelectedItem = "Filme";
        }

        public GUI(ISystemSpecification systemSpecification)
        {
            InitializeComponent();
            this.systemSpecification = systemSpecification;

            cmb_select.Items.Add("Filme");
            cmb_select.Items.Add("Schauspieler");
            cmb_select.SelectedItem = "Filme";
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

            if (cmb_select.Text == "Filme")
            {
                List<Movie> temp = systemSpecification.getMovies();
                lb_countall.Text = "Anzahl der Filme " + temp.Count.ToString();
                lib_all.Items.Clear();
                foreach (Movie m in temp)
                {
                    lib_all.Items.Add(m);
                }
            }
            else
            {
                List<Actor> temp = systemSpecification.getActors();
                lb_countall.Text = "Anzahl der Schauspieler " + temp.Count.ToString();
                lib_all.Items.Clear();
                foreach (Actor m in temp)
                {
                    lib_all.Items.Add(m);
                }
            }

            lib_properly.Items.Clear();
        }
    }
}
