using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class Standard
    {
		

		
		private string _standardName;

		public string StandardName
        {
			get { return _standardName; }
			set { _standardName = value; }
		}
        private int _standardID;
        public int StandardID
        {
            get { return _standardID; }
            set { _standardID = value; }
        }


    }
}
