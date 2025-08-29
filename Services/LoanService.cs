using FutureFinans.Models;

namespace FutureFinans.Services
{
    public class LoanService
    {
        public LoanApplication EvaluateLoan(LoanApplication loan)
        {
            // Grundläggande regler för godkännande
            bool approved = true;
            string reason = "";

            // Exempel: max lånebelopp = 10 gånger månadslön
            if (loan.LoanAmount > loan.MonthlyIncome * 10)
            {
                approved = false;
                reason = "Lånebeloppet är för högt jämfört med din inkomst.";
            }

            // Exempel: om många barn under 21, riskbedömning
            if (loan.ChildrenUnder21 > 3)
            {
                approved = false;
                reason = "För många barn under 21 år.";
            }

            // Exempel: lånetid längre än 20 år
            if (loan.LoanYears > 20)
            {
                approved = false;
                reason = "Lånetid är för lång.";
            }

            // Sätt status
            loan.Status = approved ? "Approved" : "Rejected";

            // Spara anledningen (valfritt)
            if (!approved)
            {
                loan.LoanPurpose += " - " + reason;
            }

            return loan;
        }
    }
}
