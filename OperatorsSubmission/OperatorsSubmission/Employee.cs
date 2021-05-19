using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperatorsSubmission
{ 
    public class Employees//our class employees

    {
        public string Id { get; set; }// string is set and retrieved
        public string fname { get; set; }//first name is set and retrieved
        public string lname { get; set; }//last name is set and retrieved

        public static bool operator == (Employees theEmployee, Employees theEmployee2)//comparing the emp 
        {
            return theEmployee.Id == theEmployee2.Id;//if id is true it will return true to screen
             
        }

        public static bool operator != (Employees theEmployee, Employees theEmployee2)
        {
            return theEmployee.Id != theEmployee2.Id;//return false
        }

    }
}
