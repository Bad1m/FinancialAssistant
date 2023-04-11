using System.Collections.Generic;

namespace ConsoleFinancialAssistant
{
    public class JsonStorage : IJsonStoragable
    {
        private readonly ISerializer serializer;
        private readonly IUIProvider consoleProvider;

        public JsonStorage(IUIProvider consoleProvider, ISerializer serializer)
        {
            this.consoleProvider = consoleProvider;
            this.serializer = serializer;
        }

        public decimal GetTaxFromFile()
        {
            return FinancialStatement.TaxPercentage = serializer.Deserialize<decimal>(Resources.SettingFilePath);
        }

        public void ChangeTax()
        {
            FinancialStatement.TaxPercentage = consoleProvider.InputNumber(Resources.InputTax);

            serializer.Serialize(FinancialStatement.TaxPercentage, Resources.SettingFilePath);
        }

        public void WriteDataInFile(List<FinancialStatement> finances)
        {
            serializer.Serialize(finances, Resources.DataFilePath);
        }

        public List<FinancialStatement> ReadDataFromFile()
        {
            return serializer.Deserialize<List<FinancialStatement>>(Resources.DataFilePath);
        }
    }
}
