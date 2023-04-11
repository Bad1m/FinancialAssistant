using System;
using System.Collections.Generic;

namespace ConsoleFinancialAssistant
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var consoleProviderInstance = new ConsoleProvider();
            var tableInstance = new Table(consoleProviderInstance);
            var serializeInstance = new JsonSerializer();
            var jsonStorage = new JsonStorage(consoleProviderInstance, serializeInstance);
            var storageInstance = new Storage(consoleProviderInstance, jsonStorage);
            
            IMenu menu = new MenuWorker(consoleProviderInstance, tableInstance, storageInstance, jsonStorage);

            FinancialStatement.TaxPercentage = jsonStorage.GetTaxFromFile();

            List<FinancialStatement> finances = jsonStorage.ReadDataFromFile();

            menu.SelectMenuItem(finances);

            storageInstance.WriteFinancesInFile(finances);
        }
    }
}
