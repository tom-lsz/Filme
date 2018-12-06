using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;
using FilmeSchauspieler.DataManagement;


namespace FilmeSchauspieler.SystemSpecification
{
    public class SystemSpecificationAsc:ISystemSpecification
    {
        private IDataManagement dataManagement;
        
        public SystemSpecificationAsc(IDataManagement dataManagement)
        {
            this.dataManagement = dataManagement;
        }

        public Dictionary<int, string> getMovies()
        {
            Dictionary<int, string> returnMovies = this.getMockupMovies(100);           

            return returnMovies;
        }

        public Dictionary<int, string> getActors()
        {
            Dictionary<int, string> returnActors = this.getMockupActors();

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

        public Dictionary<int, string> getActors(int movieId)
        {
            return new Dictionary<int, string>();
        }

        public Dictionary<int, string> getMovies(int actorId)
        {
            return new Dictionary<int, string>();
        }

        public bool addActorToMovie(Actor actor, Movie movie)
        {
            return true;
        }

        public bool removeActorFromMovie(Actor actor, Movie movie)
        {
            return true;
        }

        protected Dictionary<int, string> getMockupMovies(int count = 3)
        {
            Dictionary<int, string> test = new Dictionary<int, string>();

            for (int i = 1; i <= count; i++)
            {
                test.Add(i, "movie" + count * i);
            }           

            return test;
        }

        protected Dictionary<int, string> getMockupActors(int count = 4)
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            int randomNr;
            Random rnd = new Random();

            for (int i = 1; i <= count; i++ )
            {                
                randomNr = rnd.Next(1, count*count);
                test.Add(i, "actor" + randomNr.ToString());
            }

            return test;
        }
    }
}
