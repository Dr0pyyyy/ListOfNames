using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
	internal class Record
	{
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

		public Record(int id, string firstname, string lastname)
		{
			Id = id;
			Firstname = firstname;
			Lastname = lastname;
		}
	}
}
