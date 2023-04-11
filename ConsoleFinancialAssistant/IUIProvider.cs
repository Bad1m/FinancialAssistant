using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface IUIProvider
    {
        decimal InputNumber(string typingMessage);

        string InputString(string typingMessage);

        int InputNumber(int limitingValue, string typingMessage);

        void ShowIncorrectMessage();

        void WriteLine(string text);

        void WriteLine(string text, decimal value);

        void Write(int value);

        void WriteLine(FinancialStatement item);
    }
}
