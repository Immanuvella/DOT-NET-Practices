using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace Requirement3
{
    public class Songs

    {
        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private string _artist;

		public string Artist
		{
			get { return _artist; }
			set { _artist = value; }
		}
		private string _songType;

		public string SongType
		{
			get { return _songType; }
			set { _songType = value; }
		}
		private double _rating;

		public double Rating
		{
			get { return _rating; }
			set { _rating = value; }
		}
		private int _numberOfDownloads;

		public int NumberofDownloads
		{
			get { return _numberOfDownloads; }
			set { _numberOfDownloads = value; }

		}
		private DateTime _dateDownloaded;

		public DateTime DateDownloaded
		{
			get { return _dateDownloaded; }
			set { _dateDownloaded = value; }
		}
        public Songs()
        {

        }

        public Songs(string _name, string _artist, string _songType, double _rating, int _numberOfDownload, DateTime _dateDownloaded)
        {
            Name = _name;
            Artist = _artist;
            SongType = _songType;
            Rating = _rating;
            NumberofDownloads = _numberOfDownload;
            DateDownloaded = _dateDownloaded;
            
        }
        public override string ToString()
        {
            return string.Format("{0} \t{1}  \t{2} \t{3} \t{4} \t\t\t\t{5}", Name, Artist, SongType, Rating, NumberofDownloads, DateDownloaded.ToString("dd-MM-yyyy", null));
        }
        public int CompareTo(Songs other)
        {
            return Name.CompareTo(other.Name);
        }
        public static SortedDictionary<string, int> CalculateTypeCount(List<Songs> list)
        {
            SortedDictionary<string, int> typeCount = new SortedDictionary<string, int>();

            foreach (Songs song in list)
            {
                if (!typeCount.ContainsKey(song.SongType))
                {
                    typeCount.Add(song.SongType, 1);
                }
                else
                {
                    typeCount[song.SongType]++;
                }
            }

            Console.WriteLine("{0} {1,15}", "Song type", "Count");

            foreach (KeyValuePair<string, int> pair in typeCount)
            {
                Console.WriteLine("{0} {1,15}", pair.Key, pair.Value);
            }
            return typeCount;
        }
    }




       
    }





    
