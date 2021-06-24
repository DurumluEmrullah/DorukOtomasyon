using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ResonStop:IEntity
    {
        public int Id { get; set; }
        public int StatuId { get; set; }
        public int WorkId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
