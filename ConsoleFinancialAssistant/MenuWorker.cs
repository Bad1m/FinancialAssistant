using System.Collections.Generic;

namespace ConsoleFinancialAssistant
{
    public class MenuWorker : IMenu
    {
        private readonly IUIProvider consoleProvider;
        private readonly ITable table;
        private readonly IStoragable storage;
        private readonly IJsonStoragable jsonStorage;

        public MenuWorker(IUIProvider consoleProvider, ITable table, IStoragable storage, IJsonStoragable jsonStorage)
        {
            this.consoleProvider = consoleProvider;
            this.storage = storage;
            this.table = table;
            this.jsonStorage = jsonStorage;
        }

        public void SelectMenuItem(List<FinancialStatement> finances)
        {
            var menuText = Resources.ShowTable + "\n" + Resources.AddRow + "\n" + Resources.EditRow + "\n" + Resources.DeleteIncome + "\n" +  Resources.DeleteExpense + "\n" + Resources.DeleteRow + "\n" + Resources.ChangeTax + "\n" + Resources.Exit;

            consoleProvider.WriteLine(menuText);

            while (Resources.IsEnabled)
            {
                int itemNumber = consoleProvider.InputNumber((int)Menu.OutProgram, Resources.SelectRow);

                Menu itemMenu = (Menu)itemNumber;

                switch (itemMenu)
                {
                    case Menu.ShowTable:
                        table.ShowTable(finances);
                        break;

                    case Menu.AddRowTable:
                        storage.AddData(finances);
                        break;

                    case Menu.EditRowTable:
                        storage.EditData(finances);
                        break;

                    case Menu.DeleteIncome:
                        storage.DeleteIncome(finances);
                        break;

                    case Menu.DeleteExpense:
                        storage.DeleteExpense(finances);
                        break;

                    case Menu.DeleteRow:
                        storage.DeleteData(finances);
                        break;

                    case Menu.ChangeTax:
                        jsonStorage.ChangeTax();
                        break;

                    case Menu.OutProgram:
                        storage.WriteFinancesInFile(finances);
                        return;

                    default:
                        consoleProvider.ShowIncorrectMessage();
                        break;
                }
            }
        }
    }
}
