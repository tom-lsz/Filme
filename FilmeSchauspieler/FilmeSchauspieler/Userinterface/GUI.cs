using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmeSchauspieler.Userinterface
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();

            cmb_select.Items.Add("Filme");
            cmb_select.Items.Add("Schauspieler");
            cmb_select.SelectedItem = "Filme";
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if (cmb_select.Text == "Filme")
            {
                lib_all.Items.Add(.getMovies());
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                lib_all.Items.Add(.getActors());
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
                lib_properly.Items.Add(.getActors(lib_all.SelectedItem));
            }
            else if (cmb_select.Text == "Schauspieler")
            {
                lib_properly.Items.Add(.getMovies(lib_all.SelectedItem));
            }
        }
    }
}
