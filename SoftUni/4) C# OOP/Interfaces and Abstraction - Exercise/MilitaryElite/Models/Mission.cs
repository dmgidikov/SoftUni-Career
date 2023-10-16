using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state) 
        {
            this.CodeName = codeName;
            this.State = this.TryParseState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (this.State == State.Finished)
            {
                throw new Exceptions.InvalidMissionComplitionException();
            }

            this.State = State.Finished;
        }

        private State TryParseState(string stateStr)
        {
            State state;

            var parsed = Enum.TryParse(stateStr, out state);

            if (!parsed)
            {
                throw new Exceptions.InvalidMissionStateException();
            }

            return state;
        }
    }
}
