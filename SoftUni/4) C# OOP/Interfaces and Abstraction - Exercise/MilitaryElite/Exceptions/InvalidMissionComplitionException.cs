using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Exceptions
{
    public class InvalidMissionComplitionException : Exception
    {
        private const string DEF_EXC_MSG = "Mission already completed!";

        public InvalidMissionComplitionException()
            :base(DEF_EXC_MSG)
        {
            
        }
    }
}
