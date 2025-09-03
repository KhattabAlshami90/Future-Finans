using FutureFinans.Models;
using FutureFinans.Data;

namespace FutureFinans.Services
{
    public class LoanService
    {
        private readonly ApplicationDbContext _context;

        public LoanService(ApplicationDbContext context)
        {
            _context = context;
        }

        public LoanApplication EvaluateLoan(LoanApplication loan)
        {
            // Grundläggande regler för godkännande
            bool approved = true;
            string reason = "";

            if (loan.LoanAmount > loan.MonthlyIncome * 10)
            {
                approved = false;
                reason = "Lånebeloppet är för högt jämfört med din inkomst.";
            }

            if (loan.ChildrenUnder21 > 3)
            {
                approved = false;
                reason = "För många barn under 21 år.";
            }

            if (loan.LoanYears > 20)
            {
                approved = false;
                reason = "Lånetid är för lång.";
            }

            // Sätt status
            loan.Status = approved ? "Approved" : "Rejected";

            if (!approved)
            {
                loan.LoanPurpose += " - " + reason;
            }

            // Spara i databasen
            _context.LoanApplications.Add(loan);
            _context.SaveChanges();

            return loan;
        }

        // Hämta alla ansökningar
        public List<LoanApplication> GetAllLoans()
        {
            return _context.LoanApplications.ToList();
        }
        public void UpdateLoan(LoanApplication loan)
        {
            var existingLoan = _context.LoanApplications.Find(loan.Id);
            if (existingLoan != null)
            {
                existingLoan.Status = loan.Status;
                _context.SaveChanges();
            }
        }


        public void DeleteLoan(int id)
        {
            var loan = _context.LoanApplications.Find(id);
            if (loan != null)
            {
                _context.LoanApplications.Remove(loan);
                _context.SaveChanges();
            }
        }

    }


}
