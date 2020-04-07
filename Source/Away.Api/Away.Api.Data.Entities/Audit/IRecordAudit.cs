using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Audit
{
    public interface IRecordAudit
    {
        RecordAudit Auditoria { get; set; }
    }
}
