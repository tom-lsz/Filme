using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.SystemSpecification
{
    class SystemSpecificationAsc:ISystemSpecification
    {
        public List<Movie> getMovies()
        {
            return new List<Movie>();
        }

        public List<Actor> getActors()
        {
            return new List<Actor>();
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
            return new List<Actor>();
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
    }
}
