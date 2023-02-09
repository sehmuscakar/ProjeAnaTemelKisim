using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
   public class Notlar:BaseEntity
    {
        public string İsim { get; set; }
        public string Soyadı { get; set; }
        public string Ders { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public int Bütünleme { get; set; }
    }
}
