using System;
namespace ConstructorAssignment
{
    public class petInfo
    {
            //declaring variables
            public string petName;
            public int age;
            //constructors used for initializing the class variable with values
            // 2 argument constructors
            public petInfo(string petName, int age)
            {

            }
            //a argument constructor
            public petInfo(string petName) : this(petName, 5)
            {   //initializing name
                this.petName = petName;
            }
            //another argument constructor
            public petInfo(int age) : this("", age)
            {   //initializing age
                this.age = age;
            }
            // default constructor
            public petInfo()
            {

            }


        
    }
}
