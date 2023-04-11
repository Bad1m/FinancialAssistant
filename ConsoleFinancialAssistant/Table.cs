using System;
using System.Collections.Generic;

namespace ConsoleFinancialAssistant
{
    public class Table : ITable
    {
        private readonly IUIProvider consoleProvider;

        public Table(IUIProvider consoleProvider)
        {
            this.consoleProvider = consoleProvider;
        }

        public void ShowTable(List<FinancialStatement> finances)
        {
            decimal totalProfit = Resources.InitialSum;

            int id = Resources.StartId;

            consoleProvider.WriteLine(Resources.TableHeader);

            foreach (FinancialStatement item in finances)
            {
                totalProfit += item.Profit;

                consoleProvider.Write(id++);

                consoleProvider.WriteLine(item);
            }

            consoleProvider.WriteLine(Resources.TotalProfit, totalProfit);
        }
    }
}
