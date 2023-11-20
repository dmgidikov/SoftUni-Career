using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models
{
    public class Medicament
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<PatientMedicament> Prescription { get; set; } = new List<PatientMedicament>();
    }
}
