using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EnumsAssignment
{
    public class Days
    {
        public Day TheDay { get; set; } //get and set 
        
    }

    public enum Day //enum for the days of the week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
