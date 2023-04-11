using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface ITable
    {
        void ShowTable(List<FinancialStatement> finances);
    }
}
