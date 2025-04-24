namespace HospitalDatabase.Data.Models
{
    using static DataValidations.Patient;
    using System.ComponentModel.DataAnnotations;

    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLengt)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(NameMaxLengt)]
        public string LastName{ get; set; }

        [Required]
        [MaxLength(EmailMaxLenght)]
        public string Address { get; set; }

        [Required]
        [MaxLength(EmailMaxLenght)]
        public string Email { get; set; }

        public bool HasInsurance { get; set; }
    }
}