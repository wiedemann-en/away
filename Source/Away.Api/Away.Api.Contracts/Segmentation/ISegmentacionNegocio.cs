using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Segmentation
{
    public interface ISegmentacionNegocio
    {
        SegmentacionNegocioDto Negocio { get; set; }
    }
}
