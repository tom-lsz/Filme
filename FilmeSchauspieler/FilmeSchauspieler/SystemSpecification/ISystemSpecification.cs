using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.SystemSpecification
{
    public interface ISystemSpecification
    {
        Dictionary<int, String> getMovies();
        Dictionary<int,String> getActors();
        Actor getActor(int id);
        Movie getMovie(int id);
        bool createActor(string name);
        bool createMovie(string name);
        bool alterActor(Actor actor);
        bool alterMovie(Movie movie);
        bool deleteActor(Actor actor);
        bool deleteMovie(Movie movie);
        Dictionary<int, String> getActors(int movieId);
        Dictionary<int, String> getMovies(int actorId);
        bool addActorToMovie(Actor actor, Movie movie);
        bool removeActorFromMovie(Actor actor, Movie movie);   
    }
}
