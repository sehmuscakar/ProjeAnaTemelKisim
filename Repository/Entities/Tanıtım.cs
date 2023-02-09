using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Tanıtım:BaseEntity
	{
		public string İsim { get; set; }
		public string Soyisim { get; set; }
		public int Yaş { get; set; }
		public  string şehir { get; set; }
		public  string Meslek { get; set; }
	}
}
