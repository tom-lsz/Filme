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
            List<Movie> returnMovies = this.getMockupMovies();

            foreach(Movie m in returnMovies)
            {
                List<Actor> tempActors = this.getMockupActors();
                m.setActors(tempActors);
            }

            return returnMovies;
        }

        public List<Actor> getActors()
        {
            List<Actor> returnActors = this.getMockupActors();

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

        protected List<Movie> getMockupMovies()
        {
            List<string> test = new List<string> { "movie1", "movie2", "movie3", "movie4" };
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

        protected List<Actor> getMockupActors()
        {
            List<string> test = new List<string> { "actor1", "actor2", "actor3", "actor4" };
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
