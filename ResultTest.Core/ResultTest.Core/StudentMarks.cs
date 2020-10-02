using System;
using System.Collections.Generic;
using System.Text;

namespace ResultTest.Core
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
