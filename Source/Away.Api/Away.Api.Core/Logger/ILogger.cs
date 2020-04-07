using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Away.Api.Core.Logger
{
    public interface ILogger
    {
        void Info(string origin, string message, [CallerMemberName]string sourceMember = "", [CallerLineNumber]int lineNumber = 0, [CallerFilePath]string filePath = "");
        void Warning(string origin, string message, [CallerMemberName]string sourceMember = "", [CallerLineNumber]int lineNumber = 0, [CallerFilePath]string filePath = "");
        void Error(string origin, string message, Exception ex = null, [CallerMemberName]string sourceMember = "", [CallerLineNumber]int lineNumber = 0, [CallerFilePath]string filePath = "", bool global = false, bool generateMessage = true);
    }
}
