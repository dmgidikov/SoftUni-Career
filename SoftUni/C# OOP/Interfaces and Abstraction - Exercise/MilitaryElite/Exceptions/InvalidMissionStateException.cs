using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Exceptions
{
    public class InvalidMissionStateException : Exception
    {
        private const string INV_MSN_STATE = "Invalid mission state";

        public InvalidMissionStateException()
            :base(INV_MSN_STATE)
        {
            
        }
    }
}
