namespace Veterinarian_Management_System_API.Business.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Animal? Pet { get; set; }
        public string? Description { get; set; }
        public string? InvoiceNumber { get; set; }
        public decimal? InvoiceAmount { get; set; } = null;

    }
}
