using System;
using System.Collections.Generic;
using System.Text;

namespace ResultTest.Core
{
   public class StudentDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SymbolNo { get; set; }
       public string Name { get { return string.Format($"{0} {1}", FirstName, LastName); } }
    }
}
