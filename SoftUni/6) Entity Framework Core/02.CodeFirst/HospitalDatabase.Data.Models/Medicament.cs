namespace HospitalDatabase.Data.Models
{
    using static DataValidations.Medicament;
    using System.ComponentModel.DataAnnotations;

    public class Medicament
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; }
    }
}