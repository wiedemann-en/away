using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Models.Infraestructure
{
    public class JwtIssuerOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpireMinutes { get; set; }
    }
}
