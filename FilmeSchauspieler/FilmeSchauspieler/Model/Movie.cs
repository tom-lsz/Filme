using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmeSchauspieler.Model
{
	/**
	 * Movie Model
	 */
	public class Movie
	{
		/**
		 * title of movie
		 */
		private string title;

		/**
		 * List of actors
		 */
		private List<Actor> actors;

		/**
		 * unique identifier
		 */
		private int uid;

		/**
		 * constructor of Movie-class
		 */
		public Movie (int uid, string title, List<Actor> actors)
		{
			this.uid = uid;
			this.title = title;
			this.actors = actors;
		}

		/**
		 * setter title
		 */
		public void setTitle(string title)
		{
			this.title = title;
		}

		/**
		 * getter title
		 */
		public string getTitle()
		{
			return title;
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
		 * getter actors
		 */
		public void setActors(List<Actor> actors)
		{
			this.actors = actors;
		}

		/**
		 * setter actors
		 */
		public List<Actor> getActors()
		{
			return this.actors;
		}

		/**
		 * ToString methode of movie class
		 */
		public override string ToString()
		{
			return title;    
		}

	}
}
