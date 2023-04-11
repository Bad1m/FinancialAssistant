
namespace ConsoleFinancialAssistant
{
    public class FinancialStatement
    {
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public string Comments { get; set; }
        public static decimal TaxPercentage { get; set; }
        private decimal Tax
        {
            get
            {
                return Income * TaxPercentage / 100;
            }
        }
        public decimal RemainingIncome
        {
            get
            {
                return Income - Tax;
            }
        }
        public decimal Profit
        {
            get
            {
                return RemainingIncome - Expense;
            }
        }
        public FinancialStatement(decimal income, decimal expense)
        {
            Income = income;
            Expense = expense;
        }
        public FinancialStatement(decimal income, decimal expense, string comments) :
            this(income, expense)
        {
            Comments = comments;
        }
        public FinancialStatement()
        {
        
        }
        public override string ToString()
        {
            return string.Format(Resources.Tab, Income, Tax, RemainingIncome, Expense, Comments);
        }
    }
}
