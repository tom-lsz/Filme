using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler
{
    interface ISystemSpecification
    {
        List<Movie> getMovies();
        List<Actor> getActors();
        Actor getActor(int id);
        Movie getMovie(int id);
        bool createActor(string name);
        bool createMovie(string name);
        bool alterActor(Actor actor);
        bool alterMovie(Movie movie);
        bool deleteActor(Actor actor);
        bool deleteMovie(Movie movie);
        List<Actor> getActors(Movie movie);
        List<Movie> getMovies(Actor actor);
        bool addActorToMovie(Actor actor, Movie movie);
        bool removeActorFromMovie(Actor actor, Movie movie);

    }
}
