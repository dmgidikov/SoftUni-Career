namespace _03_Hospital
{
    public class Doctor
    {       
        public Doctor(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }
    }
}