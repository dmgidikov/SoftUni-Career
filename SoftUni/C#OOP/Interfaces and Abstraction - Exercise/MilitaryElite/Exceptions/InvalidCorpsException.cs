using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string DEF_EXC_MSG = "Invalid corps!";

        public InvalidCorpsException()
            : base(DEF_EXC_MSG)
        {

        }
    }
}
