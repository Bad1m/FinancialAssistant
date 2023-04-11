using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFinancialAssistant
{
    public interface ISerializer
    {
        void Serialize<T>(T data, string filePath);

        T Deserialize<T>(string filePath);
    }
}
