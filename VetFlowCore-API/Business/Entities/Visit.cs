using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetFlowCore.Entities;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Visit
    {
        [Key]
        public int VisitID { get; set; }

        [ForeignKey(nameof(Animal))]
        public int AnimalID { get; set; }

        [ForeignKey(nameof(Vet))]
        public int? VetID { get; set; }

        public DateTime VisitDate { get; set; }

        public string? ReasonForVisit { get; set; }

        public string? History { get; set; }

        public string? Examination { get; set; }

        [ForeignKey(nameof(Diagnosis))]
        public int? DiagnosisID { get; set; }

        public string? TreatmentNotes { get; set; }

        public DateTime? FollowUpDate { get; set; }

        // Navigation
        public Animal Animal { get; set; } = null!;
        public Employee? Vet { get; set; }
        public Diagnosis? Diagnosis { get; set; }
        public ICollection<MedicalNote> MedicalNotes { get; set; } = new List<MedicalNote>();
    }
}
