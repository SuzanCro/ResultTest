using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class StudentMarks
    {
        public int Id { get; set; }
        public int English { get; set; }
        public int Science { get; set; }
        public int Nepali { get; set; }
        public int Math { get; set; }
        public int Total { get { return (English + Science + Nepali + Math); } }
    }
}
