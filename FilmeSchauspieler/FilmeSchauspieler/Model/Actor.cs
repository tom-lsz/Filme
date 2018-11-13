using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeSchauspieler.Model
{
	public class Actor
	{
		/**
		 * unique identifier
		 */
		private int uid;

		/**
		 * name of actor
		 */
		private string name;

		/**
		 * list of movies with actor
		 */
		private List<Movie> movies;

		/**
		 * constructor of Actor class
		 */
		public Actor(int uid, string name, List<Movie> movies)
		{
			this.uid = uid;
			this.name = name;
			this.movies = movies;
		}

        /**
		 * parameterless constructor of Actor class
		 */
        public Actor()
        {
            this.uid = 0;
            this.name = "";
            this.movies = new List<Movie>();
        }
        

		/**
		 * setter uid
		 */
		public void setUid(int uid)
		{
			this.uid = uid;
		}

		/**
		 * getter uid
		 */
		public int getUid() 
		{
			return this.uid;
		}

		/**
		 * setter name
		 */
		public void setName(string name)
		{
			this.name = name;
		}

		/**
		 * getter name
		 */
		public string getName()
		{
			return this.name;
		}

		/**
		 * setter movies
		 */
		public void setMovies(List<Movie> movies)
		{
			this.movies = movies;
		}

		/**
		 * getter movies
		 */
		public List<Movie> getMovies()
		{
			return this.movies;
		}

		/**
		 * ToString methode of actor class
		 */
		public override string ToString()
		{
			return name;
		}

	}
}
