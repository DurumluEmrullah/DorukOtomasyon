using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Statu:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
