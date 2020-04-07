using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Logger.Infrastructure
{
    public class LoggerAppSettings
    {
        public bool LogActive { get; set; }
        public string LogMode { get; set; }
        public string LogPath { get; set; }
        public string LogFileName { get; set; }
    }
}
