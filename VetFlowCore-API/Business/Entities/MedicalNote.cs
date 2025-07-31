using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Veterinarian_Management_System_API.Business.Models;

namespace VetFlowCore_API.Business.Entities
{
    public class MedicalNote
    {
        [Key]
        public int NoteID { get; set; }

        [ForeignKey(nameof(Visit))]
        public int VisitID { get; set; }

        public DateTime DateWritten { get; set; }

        [ForeignKey(nameof(EnteredBy))]
        public int EnteredByID { get; set; }

        [MaxLength(50)]
        public string? NoteType { get; set; }

        public string? NoteText { get; set; }

        // Navigation
        public Visit Visit { get; set; } = null!;
        public Employee EnteredBy { get; set; } = null!;
    }
}
