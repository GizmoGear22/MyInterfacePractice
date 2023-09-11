using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelsInterface
{
    internal class WarriorClass : charClasses, IPlayClasses
    {
        public WarriorClass(string name)
        {
            this.Name = name;
            this.Level = 1;
        }


    }
}
