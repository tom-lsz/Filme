using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeSchauspieler.Model
{
    public class Movie
    {
        private string title;
        private List<Movie> movies;
        private int uid;

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return title;    
        }

    }
}
