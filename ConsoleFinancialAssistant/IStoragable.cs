using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface IStoragable
    {
        void AddData(List<FinancialStatement> finances);

        void EditData(List<FinancialStatement> finances);

        void DeleteData(List<FinancialStatement> finances);

        void DeleteIncome(List<FinancialStatement> finances);

        void DeleteExpense(List<FinancialStatement> finances);

        void WriteFinancesInFile(List<FinancialStatement> finances);
    }
}
