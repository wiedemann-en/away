using Away.Api.Core.Logger;
using Away.Api.Logger.Infrastructure;
using Away.Api.Misc.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Away.Api.Logger.Logic
{
    public class LoggerFile : ILogger
    {
        #region Constants
        private const string _SourceFormat = "Source: {0}/LineNumber: {1}/File: {2}";
        #endregion

        #region Private Attributes
        private readonly LoggerAppSettings _loggerAppSettings;
        #endregion

        #region Constructors
        public LoggerFile(LoggerAppSettings loggerAppSettings)
        {
            _loggerAppSettings = loggerAppSettings;
        }
        #endregion

        #region ILogger
        public void Error(string origin, string message, Exception ex = null, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", bool global = false, bool generateMessage = true)
        {
            try
            {
                var fileName = Guid.NewGuid() + "_error_" + _loggerAppSettings.LogFileName;
                var path = Path.Combine(_loggerAppSettings.LogPath, fileName);
                var sb = new StringBuilder();

                if (ex != null)
                {
                    sb.AppendLine("Origin: " + origin);
                    sb.AppendLine("Description: " + ((!generateMessage && string.IsNullOrWhiteSpace(ex.Message)) ? message : ex.GetDescription()));
                    sb.AppendLine("Detail: " + ex.GetDetail());
                    sb.AppendLine("StackTrace: " + ex.GetStackTrace());
                    sb.AppendLine("Source: " + string.Format(_SourceFormat, sourceMember, lineNumber, filePath.GetResumePath()) + " || Exception Source: " + ex.Source);
                    sb.AppendLine("TargetSite: " + ex.TargetSite != null ? ex.TargetSite.Name : string.Empty);
                }
                else
                {
                    sb.AppendLine("Origin: " + origin);
                    sb.AppendLine("Source: " + string.Format(_SourceFormat, sourceMember, lineNumber, filePath));
                    sb.AppendLine("Description: " + message);
                }

                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception)
            {
            }
        }

        public void Info(string origin, string message, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            try
            {
                var fileName = Guid.NewGuid() + "_info_" + _loggerAppSettings.LogFileName;
                var path = Path.Combine(_loggerAppSettings.LogPath, fileName);
                var sb = new StringBuilder();

                sb.AppendLine("Origin: " + origin);
                sb.AppendLine("Source: " + string.Format(_SourceFormat, sourceMember, lineNumber, filePath));
                sb.AppendLine("Description: " + message);

                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception)
            {
            }
        }

        public void Warning(string origin, string message, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            try
            {
                var fileName = Guid.NewGuid() + "_warning_" + _loggerAppSettings.LogFileName;
                var path = Path.Combine(_loggerAppSettings.LogPath, fileName);
                var sb = new StringBuilder();

                sb.AppendLine("Origin: " + origin);
                sb.AppendLine("Source: " + string.Format(_SourceFormat, sourceMember, lineNumber, filePath));
                sb.AppendLine("Description: " + message);

                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
