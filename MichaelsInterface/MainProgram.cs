using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MichaelsInterface
{
    
    class MainProgram
    {
        static void Main(string[] args)
        {
            WarriorClass tanky = new WarriorClass("Tanky");
            IPlayClasses swordy = new WarriorClass("Swordy");

            tanky.IncreaseLevel();
            swordy.IncreaseLevel();
              
        }
    }
}
