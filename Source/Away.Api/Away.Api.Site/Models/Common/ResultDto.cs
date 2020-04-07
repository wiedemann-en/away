using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Models.Common
{
    public class ResultDto<T>
    {
        public ResultDto()
        {
            Errors = new List<string>();
        }

        public T Data { get; set; }
        public bool Success => Errors.Count() == 0;
        public List<string> Errors { get; }

        public void AddError(string error)
        {
            Errors.Add(error);
        }
        public void AddErrors(List<string> errors)
        {
            Errors.AddRange(errors);
        }
    }

    public class ResultDto
    {
        public ResultDto()
        {
            Errors = new List<string>();
        }

        public object Data { get; set; }
        public bool Success => Errors.Count() == 0;
        public List<string> Errors { get; }

        public void AddError(string error)
        {
            Errors.Add(error);
        }
        public void AddErrors(List<string> errors)
        {
            Errors.AddRange(errors);
        }
    }
}
