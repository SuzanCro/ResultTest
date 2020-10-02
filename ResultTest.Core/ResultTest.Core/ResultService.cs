using System;
using System.Collections.Generic;
using System.Text;

namespace ResultTest.Core
{
  public  class ResultService
    {
        public StudentDetails details { get; set; }
        public StudentMarks marks { get; set; }
        public double Percentage(StudentMarks marks)
        {
            double total = 400;
            double percentage = ((marks.Math + marks.Nepali + marks.Science + marks.English) / total) * 100;
            return percentage;
        }
        public bool CheckIfPassed(StudentMarks marks)
        {
          if(marks.English<40 && marks.Math<40 && marks.Nepali<40 && marks.Science<40)
            {
                return false;
            }
          else if(Percentage(marks)<40)
            {
                return false;

            }
          else
            {
                return true;

            }
        }
    }
}
