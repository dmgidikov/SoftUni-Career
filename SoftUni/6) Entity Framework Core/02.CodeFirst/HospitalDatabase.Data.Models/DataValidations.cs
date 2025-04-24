namespace HospitalDatabase.Data.Models
{
    using Models;

    public static class DataValidations
    {
        public static class Patient
        {
            public const int NameMaxLengt = 50;
            public const int AddressMaxLenght = 250;
            public const int EmailMaxLenght = 80;
        }

        public static class Visitation
        {
            public const int CommentsMaxLenght = 250;
        }

        public static class Diagnose
        {
            public const int NameMaxLenght = 50;
            public const int CommentsMaxLenght = 250;
        }

        public static class Medicament
        {
            public const int NameMaxLenght = 50;
        }

        public static class Doctor
        {
            public const int NameMaxLenght = 100;
            public const int SpecialityMaxLenght = 100;
        }
    }
}