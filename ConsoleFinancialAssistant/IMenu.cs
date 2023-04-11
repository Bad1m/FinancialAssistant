using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface IMenu
    {
        void SelectMenuItem(List<FinancialStatement> finances);
    }
}
