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

            cmb_select.Items.Add("Filme");
            cmb_select.Items.Add("Schauspieler");
            cmb_select.SelectedItem = "Filme";

            this.systemSpecification = systemSpecification;
        }        

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if (cmb_select.Text == "Filme")
            {
                List<Movie> temp = systemSpecification.getMovies();             
                
                foreach(Movie m in temp)
                {
                    lib_all.Items.Add(m);
                }
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                //lib_all.Items.Add(systemSpecification.getActors());
            }
            else
            {
                MessageBox.Show("Filme oder Schauspieler auswählen!");
            }
        }

        private void lib_all_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select.Text == "Filme")
            {
                object temp = lib_all.SelectedItem;
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                //lib_properly.Items.Add(systemSpecification.getMovies(lib_all.SelectedItem));
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
