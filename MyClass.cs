using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MyClass : IPerson 
    {
        private String name;
        
        public MyClass() 
        {
            name = "Figgle Wiggle";
            Console.WriteLine(name);
        }

        public String getName()
        {
            return name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }
    }
}
