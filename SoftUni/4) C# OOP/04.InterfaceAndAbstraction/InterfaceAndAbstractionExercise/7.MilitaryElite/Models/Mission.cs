namespace _7.MilitaryElite.Models
{
    using Contracts;
    using Exceptions;
    using Enumerations;

    public class Mission : IMission
    {
        public Mission(string codeName, string state) 
        {
            this.CodeName = codeName;
            this.State = TryParseState(state);
        }    

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (State == State.Finished)
            {
                throw new InvalidMissionCompletionException();
            }

            State = State.Finished;
        }

        private State TryParseState(string stateString)
        {
            State state;

            bool parsed = Enum.TryParse(stateString, out state);

            if (parsed == false)
            {
                throw new InvalidMissionStateException();
            }

            return state;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State.ToString()}";
        }
    }
}