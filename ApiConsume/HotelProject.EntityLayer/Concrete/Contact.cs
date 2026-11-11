using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
	public class Contact
	{
		public int ContactID { get; set; }
		public string ContactAddress { get; set; }
		public string ContactCity { get; set; }
		public string ContactDistrict { get; set; }
		public string ContactCountry { get; set; }
		public string ContactPhone { get; set; }
		public string ContactMail { get; set; }
	}
}
