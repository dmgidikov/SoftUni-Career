using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Data.Models
{
    public class PatientMedicament
    {
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public int MedicamentId { get; set; }

        public string MedicamentName { get; set; }
    }
}
