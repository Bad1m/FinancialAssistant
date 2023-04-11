using System;

namespace ConsoleFinancialAssistant
{
    public class ConsoleProvider : IUIProvider
    {
        public decimal InputNumber(string typingMessage)
        {
            Console.WriteLine(typingMessage);

            decimal value;

            while (!decimal.TryParse(Console.ReadLine(), out value) || value < Resources.LimitingValue)
            {
                ShowIncorrectMessage();
            }

            return value;
        }

        public int InputNumber(int limitingValue, string typingMessage)
        {
            Console.WriteLine(typingMessage);

            int value;

            while (!int.TryParse(Console.ReadLine(), out value) || value > limitingValue)
            {
                ShowIncorrectMessage();
            }

            return value;
        }

        public string InputString(string typingMessage)
        {
            Console.WriteLine(typingMessage);

            string value = Console.ReadLine();

            return value;
        }

        public void ShowIncorrectMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Resources.IncorrectValue);
            Console.ResetColor();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLine(string text, decimal value)
        {
            Console.WriteLine(text, value);
        }

        public void Write(int value)
        {
            Console.Write(value);
        }

        public void WriteLine(FinancialStatement item)
        {
            Console.WriteLine(item);
        }
    }
}
