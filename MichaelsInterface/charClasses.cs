using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelsInterface
{
    internal class charClasses : IPlayClasses
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public void IncreaseLevel()
        {
            Level += 1;
        }
    }
}
