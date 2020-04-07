using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Misc.Extensions
{
    public static class FilePathExtensions
    {
        public static string GetResumePath(this string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return string.Empty;

            var paths = filePath.Split('\\');
            return paths.SkipWhile(f => !f.Contains("Away.Api")).Aggregate
            (
                new StringBuilder(),
                (acc, itm) => acc.Append(itm).Append('\\'),
                f => f.Remove(f.Length - 1, 1).ToString()
            );
        }
    }
}
