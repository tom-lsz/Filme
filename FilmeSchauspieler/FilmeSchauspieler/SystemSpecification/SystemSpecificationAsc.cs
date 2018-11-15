using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.SystemSpecification
{
    public class SystemSpecificationAsc:ISystemSpecification
    {
        public List<Movie> getMovies()
        {
            List<Movie> returnMovies = this.getMockupMovies(100);

            int counter = 1;
            int cAct;
            foreach(Movie m in returnMovies)
            {
                cAct = 2 * counter;
                List<Actor> tempActors = this.getMockupActors(cAct);
                m.setActors(tempActors);
                counter++;
            }

            return returnMovies;
        }

        public List<Actor> getActors()
        {
            List<Actor> returnActors = this.getMockupActors();

            int counter = 1;
            int cMovie;
            foreach (Actor a in returnActors)
            {
                cMovie = 2 * counter;
                List<Movie> tempMocvie = this.getMockupMovies(cMovie);
                a.setMovies(tempMocvie);
                counter++;
            }

            return returnActors;
        }

        public Actor getActor(int id)
        {
            return new Actor();
        }

        public Movie getMovie(int id)
        {
            return new Movie();
        }

        public bool createActor(string name)
        {
            return true;
        }

        public bool createMovie(string name)
        {
            return true;
        }

        public bool alterActor(Actor actor)
        {
            return true;
        }

        public bool alterMovie(Movie movie)
        {
            return true;
        }

        public bool deleteActor(Actor actor)
        {
            return true;
        }

        public bool deleteMovie(Movie movie)
        {
            return true;
        }

        public List<Actor> getActors(Movie movie)
        {
            return movie.getActors();
        }

        public List<Movie> getMovies(Actor actor)
        {
            return new List<Movie>();
        }

        public bool addActorToMovie(Actor actor, Movie movie)
        {
            return true;
        }

        public bool removeActorFromMovie(Actor actor, Movie movie)
        {
            return true;
        }

        protected List<Movie> getMockupMovies(int count = 3)
        {
            List<string> test = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                test.Add("movie" + count * i);
            }

            List<Movie> returnMovies = new List<Movie>();

            int c = 1;
            foreach (string s in test)
            {
                Movie temp = new Movie(c, s, new List<Actor>());
                returnMovies.Add(temp);
                c++;
            }

            return returnMovies;
        }

        protected List<Actor> getMockupActors(int count = 4)
        {
            List<string> test = new List<string>();
            int randomNr;
            Random rnd = new Random();

            for (int i = 1; i <= count; i++ )
            {                
                randomNr = rnd.Next(1, count*count);
                test.Add("actor" + randomNr.ToString());
            }
            List<Actor> returnActors = new List<Actor>();

            int c = 1;
            foreach (string s in test)
            {
                Actor temp = new Actor(c, s, new List<Movie>());
                returnActors.Add(temp);
                c++;
            }

            return returnActors;
        }
    }
}
