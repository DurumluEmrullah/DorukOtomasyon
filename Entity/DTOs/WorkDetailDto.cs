using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class WorkDetailDto
    {
        public string Name { get; set; }
        public List<ResonStop> ResonStops { get; set; }
    }
}
