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
        private SQLiteConnection connection { get; set; }
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
                this.connection = data_dbConnection;
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
                if (!tableExists(data_dbConnection, "ActorMovie"))
                {
                    using (SQLiteCommand command = data_dbConnection.CreateCommand())
                    {
                        command.CommandText = "CREATE TABLE ActorMovie (uid_Actor int, uid_Movie int)";
                        command.ExecuteNonQuery();
                    }
                }
                data_dbConnection.Close();
                List<Movie> list = new List<Movie>();
                List<Actor> list1 = new List<Actor>();
                Actor test = new Actor(1, "Heinz", list);
                Movie test2 = new Movie(1, "Film", list1);
                addActor(test);
                addMovie(test2);
                
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
            connection.Open();
            int count;
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Actor";
                count = command.ExecuteNonQuery();
            }
            connection.Close();
            return count;
        }

        public int countMovies()
        {
            connection.Open();
            int count;
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Movie";
                count = command.ExecuteNonQuery();
            }
            connection.Close();
            return count;
        }

        public List<string[][]> getActors()
        {
            connection.Open();
            List<string[][]> actors = new List<string[][]>();
            string[][] actor = new string[2][];
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Actor";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        actor[0][count] = reader.GetInt32(0).ToString();
                        actor[1][count] = reader.GetString(1);
                        actors.Add(actor);
                        count++;
                    }
                }
            }
            connection.Close();
            return actors;
        }

        public List<string[][]> getMovies()
        {
            connection.Open();
            List<string[][]> movies = new List<string[][]>();
            string[][] movie = new string[2][];
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Movie";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        movie[0][count] = reader.GetInt32(0).ToString();
                        movie[1][count] = reader.GetString(1);
                        movies.Add(movie);
                        count++;
                    }
                }
            }
            connection.Close();
            return movies;
        }

        public string[] getActor(int id)
        {
            connection.Open();
            string[] actor = new string[2];
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Actor WHERE uid = " + id;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    actor[0] = reader.GetInt32(0).ToString();
                    actor[1] = reader.GetString(1);
                }
            }
            connection.Close();
            return actor;
        }

        public string[] getMovie(int id)
        {
            connection.Open();
            string[] movie = new string[2];
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Actor WHERE uid = " + id;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    movie[0] = reader.GetInt32(0).ToString();
                    movie[1] = reader.GetString(1);
                }
            }
            connection.Close();
            return movie;
        }

        public bool addActor(Actor actor)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Actor (uid,name) VALUES ( @uid, @name)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@uid", actor.getUid());
                command.Parameters.AddWithValue("@name", actor.getName());
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool addMovie(Movie movie)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Movie (uid,title) VALUES ( @uid, @title)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@uid", movie.getUid());
                command.Parameters.AddWithValue("@title", movie.getTitle());
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool alterActor(Actor actor)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Actor SET name = @name WHERE uid = @uid";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", actor.getName());
                command.Parameters.AddWithValue("@uid", actor.getUid());
                command.ExecuteNonQuery();
                query = "DELETE FROM ActorMovie WHERE uid_Actor = @uidActor";
                command.CommandText = query;
                command.Parameters.AddWithValue("@uidActor", actor.getUid());
                command.ExecuteNonQuery();
                foreach (Movie movie in actor.getMovies())
                {
                    query = "INSERT INTO ActorMovie (uid_Actor, uid_Movie) VALUES (@uidActor, @uidMovie)";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@uidActor", actor.getUid());
                    command.Parameters.AddWithValue("@uidMovie", movie.getUid());
                    command.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool alterMovie(Movie movie)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Movie SET title = @title WHERE uid = @uid";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@title", movie.getTitle());
                command.Parameters.AddWithValue("@uid", movie.getUid());
                command.ExecuteNonQuery();
                query = "DELETE FROM ActorMovie WHERE uid_Movie = @uidMovie";
                command.CommandText = query;
                command.Parameters.AddWithValue("@uidMovie", movie.getUid());
                command.ExecuteNonQuery();
                foreach (Actor actor in movie.getActors())
                {
                    query = "INSERT INTO ActorMovie (uid_Actor, uid_Movie) VALUES (@uidActor, @uidMovie)";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@uidActor", actor.getUid());
                    command.Parameters.AddWithValue("@uidMovie", movie.getUid());
                    command.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public bool deleteActor(Actor actor)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Actor WHERE uid = @uid";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@uid", actor.getUid());
                command.ExecuteNonQuery();
                query = "DELETE FROM ActorMovie WHERE uid_Actor = @uidActor";
                command.CommandText = query;
                command.Parameters.AddWithValue("@uidActor", actor.getUid());
                command.ExecuteNonQuery();
                connection.Close();
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool deleteMovie(Movie movie)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Movie WHERE uid = @uid";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@uid", movie.getUid());
                command.ExecuteNonQuery();
                query = "DELETE FROM ActorMovie WHERE uid_Movie = @uidMovie";
                command.CommandText = query;
                command.Parameters.AddWithValue("@uidmovie", movie.getUid());
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
