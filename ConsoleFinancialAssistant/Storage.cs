using System.Collections.Generic;

namespace ConsoleFinancialAssistant
{
    public class Storage : IStoragable
    {
        private readonly IJsonStoragable jsonStorage;

        private readonly IUIProvider consoleProvider;

        public Storage(IUIProvider consoleProvider, IJsonStoragable jsonStorage)
        {
            this.jsonStorage = jsonStorage;
            this.consoleProvider = consoleProvider;
        }

        public void AddData(List<FinancialStatement> finances)
        {
            var income = consoleProvider.InputNumber(Resources.InputIncome);

            var exspense = consoleProvider.InputNumber(Resources.InputExspense);

            var comments = consoleProvider.InputString(Resources.InputComment);

            finances.Add(new FinancialStatement(income, exspense, comments));
        }

        public void EditData(List<FinancialStatement> finances)
        {
            var tableNumber = consoleProvider.InputNumber(finances.Count, Resources.InputNumber);

            var income = consoleProvider.InputNumber(Resources.InputIncome);

            var exspense = consoleProvider.InputNumber(Resources.InputExspense);

            finances[tableNumber - Resources.Index] = new FinancialStatement(income, exspense);
        }

        public void DeleteIncome(List<FinancialStatement> finances)
        {
            var tableNumber = consoleProvider.InputNumber(finances.Count, Resources.InputNumber);

            finances[tableNumber - Resources.Index] = new FinancialStatement(Resources.IncomeValue, finances[tableNumber - Resources.Index].Expense);
        }

        public void DeleteExpense(List<FinancialStatement> finances)
        {
            var tableNumber = consoleProvider.InputNumber(finances.Count, Resources.InputNumber);

            finances[tableNumber - Resources.Index] = new FinancialStatement(finances[tableNumber - Resources.Index].Income, Resources.ExspenseValue);
        }

        public void DeleteData(List<FinancialStatement> finances)
        {
            var tableNumber = consoleProvider.InputNumber(finances.Count, Resources.InputNumber);

            finances.RemoveAt(tableNumber - Resources.Index);
        }

        public void WriteFinancesInFile(List<FinancialStatement> finances)
        {
            jsonStorage.WriteDataInFile(finances);
        }
    }
}
