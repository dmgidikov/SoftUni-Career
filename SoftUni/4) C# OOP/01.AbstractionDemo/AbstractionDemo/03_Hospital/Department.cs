namespace _03_Hospital
{
    public class Department
    {
        private List<Doctor> doctors;
        private List<Patient> patients;

        public Department(string type, List<Doctor> doctors, List<Patient> patients)
        {
            this.Type = type;
            this.patients = patients;
            this.doctors = doctors;
        }
        public string Type { get; }

        public IReadOnlyCollection<Doctor> Doctors => doctors;

        public IReadOnlyCollection<Patient> Patients => patients;
    }
}