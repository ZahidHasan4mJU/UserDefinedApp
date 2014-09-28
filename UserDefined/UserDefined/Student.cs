using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefined
{
    class Student
    {
        public string reg;
        public string fName;
        public string lName;

        public string print()
        {
            return (fName + " " + lName + " - " + reg);
        }

    }
}
