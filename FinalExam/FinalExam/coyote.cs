using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class coyote : dog
    {
        public coyote()
        {
            this.Name = "A coyote";
        }

        public override void bark()
        {
            Console.WriteLine("AWOO!");
        }
    }
}