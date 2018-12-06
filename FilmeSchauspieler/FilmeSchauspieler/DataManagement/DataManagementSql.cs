using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using FilmeSchauspieler.Model;

namespace FilmeSchauspieler.DataManagement
{
    class DataManagementSql : IDataManagement
    {
        public string path { get; set; }
        private SQLiteConnection data_dbConnection { get; set; }
        public DataManagementSql()
        {
            try
            {
                string travelUpTwo = @".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar;
                this.path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, travelUpTwo, "Data"));
                Console.WriteLine(path);
                string fileActorsMovies = Path.Combine(this.path, "data.sqlite");
                if (!File.Exists(fileActorsMovies))
                {
                    SQLiteConnection.CreateFile(fileActorsMovies);
                }
                SQLiteConnection data_dbConnection = new SQLiteConnection("Data Source=" + fileActorsMovies + ";Version=3;");
                this.data_dbConnection = data_dbConnection;
                data_dbConnection.Open();
                if (!tableExists(data_dbConnection, "Actor"))
                {
                    using (SQLiteCommand command = data_dbConnection.CreateCommand())
                    {
                        command.CommandText = "CREATE TABLE Actor (uid int, name varchar(30))";
                        command.ExecuteNonQuery();
                    }
                }
                if (!tableExists(data_dbConnection, "Movie"))
                {
                    using (SQLiteCommand command = data_dbConnection.CreateCommand())
                    {
                        command.CommandText = "CREATE TABLE Movie (uid int, title varchar(40))";
                        command.ExecuteNonQuery();
                    }
                }
                if (!tableExists(data_dbConnection, "Connection"))
                {
                    using (SQLiteCommand command = data_dbConnection.CreateCommand())
                    {
                        command.CommandText = "CREATE TABLE Connection (uid_Actor int, uid_Movie int)";
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        public bool tableExists(SQLiteConnection data_dbConnection, string tableName)
        {
            try
            {
                using (SQLiteCommand command = data_dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT name FROM sqlite_master WHERE name='" + tableName + "'";
                    var name = command.ExecuteScalar();
                    return (name != null && name.ToString() == tableName) ? true : false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public int countActors()
        {
            data_dbConnection.Open();
            int count;
            using (SQLiteCommand command = data_dbConnection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Actor";
                count = command.ExecuteNonQuery();
            }
            return count;
        }

        public int countMovies()
        {
            data_dbConnection.Open();
            int count;
            using (SQLiteCommand command = data_dbConnection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Movie";
                count = command.ExecuteNonQuery();
            }
            return count;
        }

        public List<Actor> getActors()
        {
            List<Actor> actors = new List<Actor>();
            return actors;
        }

        public List<Movie> getMovies()
        {
            List<Movie> movies = new List<Movie>();
            return movies;
        }

        public Actor getActor(int id)
        {
            return null;
        }

        public Movie getMovie(int id)
        {
            return null;
        }

        public bool addActor(Actor actor)
        {
            return true;
        }
        public bool addMovie(Movie movie)
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
    }
}
