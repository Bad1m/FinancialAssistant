using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface IJsonStoragable
    {
        decimal GetTaxFromFile();

        void ChangeTax();

        void WriteDataInFile(List<FinancialStatement> finances);

        List<FinancialStatement> ReadDataFromFile();
    }
}
