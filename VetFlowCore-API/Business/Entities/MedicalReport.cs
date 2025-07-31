namespace Veterinarian_Management_System_API.Business.Models
{
    public class MedicalReport
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public DateTime DateWritten { get; set; }
        public int EnteredBy { get; set; }
        public string? NoteType { get; set; }
        public string? NoteText { get; set; }
    }
}
