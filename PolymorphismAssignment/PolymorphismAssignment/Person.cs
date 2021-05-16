using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public abstract class Person //abstract class
    {
        public string fname { get; set; }//string name is returned and set
        public string lname { get; set; }//string l name is returned and set
        public abstract void SayName();
    }

}