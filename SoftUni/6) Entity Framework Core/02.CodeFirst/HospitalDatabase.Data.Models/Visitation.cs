namespace HospitalDatabase.Data.Models
{
    using static DataValidations.Visitation;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Visitation
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [MaxLength(CommentsMaxLenght)]
        public string Comments { get; set; }


        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}