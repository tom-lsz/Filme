using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;
using FilmeSchauspieler.DataManagement;

namespace FilmeSchauspieler.SystemSpecification
{
    public class SystemSpecificationDesc
    {
        private IDataManagement dataManagement;

        public SystemSpecificationDesc(IDataManagement dataManagement)
        {
            this.dataManagement = dataManagement;
        }

        public List<String> getMovies()
        {
            return this.getMockupMovies();
        }

        public List<String> getActors()
        {
            return this.getMockupActors();
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

        protected List<String> getMockupMovies(int count = 3)
        {
            List<string> test = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                test.Add("movie" + count * i);
            }

            return test;
        }

        protected List<String> getMockupActors(int count = 4)
        {
            List<string> test = new List<string>();
            int randomNr;
            Random rnd = new Random();

            for (int i = 1; i <= count; i++ )
            {                
                randomNr = rnd.Next(1, count*count);
                test.Add("actor" + randomNr.ToString());
            }

            return test;
        }
    }
}
