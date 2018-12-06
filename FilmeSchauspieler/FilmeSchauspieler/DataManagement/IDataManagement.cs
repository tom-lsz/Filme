using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.DataManagement { 
    public interface IDataManagement
    {
        int countActors();
        int countMovies();
        List<string[][]> getActors();
        List<string[][]> getMovies();
        string[] getActor(int id);
        string[] getMovie(int id);
        bool addActor(Actor actor);
        bool addMovie(Movie movie);
        bool alterActor(Actor actor);
        bool alterMovie(Movie movie);
        bool deleteActor(Actor actor);
        bool deleteMovie(Movie movie);

    }
}
