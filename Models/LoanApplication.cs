using System.ComponentModel.DataAnnotations;

namespace FutureFinans.Models
{
    public class LoanApplication
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Namn är obligatoriskt")]
        public string ApplicantName { get; set; }

        [Range(1000, 1000000, ErrorMessage = "Ange ett belopp mellan 1000 och 1 000 000 kr")]
        public decimal LoanAmount { get; set; }

        [Range(1, 30, ErrorMessage = "Ange antal år mellan 1 och 30")]
        public int LoanYears { get; set; }

        [Required]
        public string LoanPurpose { get; set; } // Samla lån, Nytt lån, Renovering...

        [Required]
        public string MaritalStatus { get; set; } // Gift, Sambo, Singel, Skild

        [Range(0, 10, ErrorMessage = "Antal barn kan inte vara negativt")]
        public int ChildrenUnder21 { get; set; }

        [Required]
        public string HousingType { get; set; } // Villa, Bostadsrätt, Hyresrätt...

        [Range(0, 1000000)]
        public decimal MonthlyIncome { get; set; }

        public string Status { get; set; } = "Pending"; // Approved / Rejected / Pending
    }
}
