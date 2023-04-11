namespace ConsoleFinancialAssistant
{
    public static class Resources
    {
        public const bool IsEnabled = true;
        public const int StartId = 1;
        public const decimal InitialSum = 0;
        public const int LimitingValue = 0;
        public const int Index = 1;
        public const decimal ExspenseValue = 0;
        public const decimal IncomeValue = 0;
        public const string TableHeader = "№\tДоходы\tНалог\tОставшийся доход\tРасходы\tКомментарии";
        public const string Tab = "{0,10}{1,8}{2,10}{3,22}{4,8}\n ";
        public const string TotalProfit = "Общая прибыль : {0}";
        public const string ShowTable = "1. Показать таблицу расходов, доходов и прибыли.";
        public const string AddRow = "2. Добавить строку.";
        public const string EditRow = "3. Редактировать строку.";
        public const string DeleteIncome = "4. Удалить доходы.";
        public const string DeleteExpense = "5. Удалить расходы.";
        public const string DeleteRow = "6. Удалить строку.";
        public const string Exit = "8. Выйти и сохранить данные в файле.";
        public const string SelectRow = "Укажите пункт меню: ";
        public const string IncorrectValue = "Неверное значение, повторите ввод: ";
        public const string InputNumber = "Введите номер строки таблицы: ";
        public const string InputIncome = "Введите значение доходов: ";
        public const string InputExspense = "Введите значение расходов: ";
        public const string InputComment = "Введите комментарии (необязательно): ";
        public const string InputTax = "Введите новое значение налога: ";
        public const string ChangeTax = "7. Изменить налог";
        public const string SettingFilePath = "settings.json";
        public const string DataFilePath = "data.json";
    }
}
