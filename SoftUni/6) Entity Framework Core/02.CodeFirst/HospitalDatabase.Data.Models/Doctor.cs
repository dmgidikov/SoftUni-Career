namespace HospitalDatabase.Data.Models
{
    using static DataValidations.Doctor;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; }

        [Required]
        [MaxLength(SpecialityMaxLenght)]
        public string Speciality { get; set; }

        [ForeignKey("Visitation")]
        public int VisitationId { get; set; }
        public ICollection<Visitation> Visitations = new HashSet<Visitation>();
    }
}