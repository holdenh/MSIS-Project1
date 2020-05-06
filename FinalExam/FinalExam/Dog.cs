using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class dog
    {

        public string Name { get; set; }

        public dog(string n)
        {
            Name = n;
        }

        public dog() { }

        public virtual void bark()
        {
            Console.WriteLine("BORK BORK!");
        }

    }
}