using System.ComponentModel.DataAnnotations;

namespace FutureFinans.Models
{
    public class LoanApplication

    {
        public int Id { get; set; }

        [Required]
        public string ApplicantName { get; set; }

        [Range(1000, 100000)]
        public decimal LoanAmount { get; set; }

        [Range(1, 30)]
        public int Years { get; set; }

        [Range(0, 100000)]
        public decimal MonthlyIncome { get; set; }

        public string Status { get; set; } // Approved / Rejected
    }
}