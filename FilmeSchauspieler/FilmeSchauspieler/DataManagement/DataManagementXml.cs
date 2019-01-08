using CsvHelper;
using FilmeSchauspieler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmeSchauspieler.DataManagement
{
    class DataManagementCsv
    {
        public string path { get; set; }
        string actorPath { get; set; }
        string moviePath { get; set; }
        string actorMoviePath { get; set; }

        public DataManagementCsv()
        {
            try
            {
                string travelUpTwo = @".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar;
                path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, travelUpTwo, "Data"));
                string actorFile = Path.Combine(path, "Actor.csv");
                actorPath = actorFile;
                string movieFile = Path.Combine(path, "Movie.csv");
                moviePath = movieFile;
                string actorMovieFile = Path.Combine(path, "ActorMovie.csv");
                actorMoviePath = actorMovieFile;
                if (!File.Exists(actorFile))
                {
                    using (File.Create(actorFile)) { }
                }
                if (!File.Exists(movieFile))
                {
                    using (File.Create(movieFile)) { }
                }
                if (!File.Exists(actorMovieFile))
                {
                    using (File.Create(actorMovieFile)) { }
                }
                MessageBox.Show(getActors()[0].ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public int countActors()
        {
            int length;
            using (var reader = new StreamReader(actorPath))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.HasHeaderRecord = false;
                var records = csv.GetRecords<string>();
                length = records.ToList().Count();
            }
            return length;
        }
        public int countMovies()
        {
            int length;
            using (var reader = new StreamReader(moviePath))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.HasHeaderRecord = false;
                var records = csv.GetRecords<string>();
                length = records.ToList().Count();
            }
            return length;
        }
        public List<string[][]> getActors()
        {
            List<string[][]> actors = new List<string[][]>();
            string[][] actor = new string[2][];
            int count = 0;

            using (var reader = new StreamReader(actorPath))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.HasHeaderRecord = false;
                var records = csv.GetRecords<Actor>();
                foreach (Actor record in records)
                {
                    actor[0][count] = record.getUid().ToString();
                    actor[1][count] = record.getName();
                    count++;
                }
            }
            return actors;
        }
    }
}
