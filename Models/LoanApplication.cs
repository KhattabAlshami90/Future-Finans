using System.ComponentModel.DataAnnotations;

namespace FutureFinans.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Namn är obligatoriskt")]
        public string ApplicantName { get; set; }

        [Required(ErrorMessage = "Civilstånd måste anges")]
        public string MaritalStatus { get; set; }

        public int ChildrenUnder21 { get; set; }

        [Required(ErrorMessage = "Boendeform måste anges")]
        public string HousingType { get; set; }

        [Range(1000, 1000000, ErrorMessage = "Ange ett belopp mellan 1000 och 1 000 000 kr")]
        public decimal LoanAmount { get; set; }

        [Range(1, 30, ErrorMessage = "Ange antal år mellan 1 och 30")]
        public int LoanYears { get; set; }

        [Required(ErrorMessage = "Lånesyfte måste anges")]
        public string LoanPurpose { get; set; }

        public decimal MonthlyIncome { get; set; }

        public string Status { get; set; } = "Pending";
    }
}
