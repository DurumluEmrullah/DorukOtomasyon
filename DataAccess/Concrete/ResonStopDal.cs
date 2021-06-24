using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ResonStopDal:IResonStopDal
    {
        private List<ResonStop> workStatus = new List<ResonStop>()
        {
            new ResonStop()
            {
                Id = 1,StatuId = 1,WorkId = 1, StartTime = new DateTime(2017, 1, 1, 10, 0, 0), EndTime = new DateTime(2017, 1, 1, 10, 10, 0)
            },
            new ResonStop()
            {
                Id = 2,StatuId = 2,WorkId = 3, StartTime = new DateTime(2017, 1, 1, 10, 30, 0), EndTime = new DateTime(2017, 1, 1, 11, 0, 0)
            },
            new ResonStop()
            {
                Id = 3,StatuId = 1,WorkId = 7, StartTime = new DateTime(2017, 1, 1, 12, 0, 0), EndTime = new DateTime(2017, 1, 1, 12, 30, 0)
            },
            new ResonStop()
            {
                Id = 4,StatuId = 1,WorkId = 8, StartTime = new DateTime(2017, 1, 1, 14, 0, 0), EndTime = new DateTime(2017, 1, 1, 14, 10, 0)
            },
            new ResonStop()
            {
                Id = 5,StatuId = 3,WorkId = 8, StartTime = new DateTime(2017, 1, 1, 15, 0, 0), EndTime = new DateTime(2017, 1, 1, 16, 30, 0)
            },
            new ResonStop()
            {
                Id = 6,StatuId = 1,WorkId = 1, StartTime = new DateTime(2017, 1, 1, 18, 0, 0), EndTime = new DateTime(2017, 1, 1, 18, 10, 0)
            },
            new ResonStop()
            {
                Id = 7,StatuId = 1,WorkId = 2, StartTime = new DateTime(2017, 1, 1, 20, 0, 0), EndTime = new DateTime(2017, 1, 1, 20, 30, 0)
            },
            new ResonStop()
            {
                Id = 8,StatuId = 1,WorkId = 5, StartTime = new DateTime(2017, 1, 1, 22, 0, 0), EndTime = new DateTime(2017, 1, 1, 22, 10, 0)
            },
            new ResonStop()
            {
                Id = 9,StatuId = 3,WorkId = 5, StartTime = new DateTime(2017, 1, 1, 23, 0, 0), EndTime = new DateTime(2017, 1, 2, 8, 30, 0)
            },
            new ResonStop()
            {
                Id = 10,StatuId = 1,WorkId = 4, StartTime = new DateTime(2017, 1, 2, 10, 0, 0), EndTime = new DateTime(2017, 1, 2, 10, 10, 0)
            },
            new ResonStop()
            {
                Id = 11,StatuId = 2,WorkId = 3, StartTime = new DateTime(2017, 1, 2, 12, 0, 0), EndTime = new DateTime(2017, 1, 2, 12, 30, 0)
            },
            new ResonStop()
            {
                Id = 12,StatuId = 2,WorkId = 6, StartTime = new DateTime(2017, 1, 2, 13, 0, 0), EndTime = new DateTime(2017, 1, 2, 13, 45, 0)
            },
            new ResonStop()
            {
                Id = 13,StatuId = 1,WorkId = 7, StartTime = new DateTime(2017, 1, 2, 14, 0, 0), EndTime = new DateTime(2017, 1, 2, 14, 10, 0)
            },
            new ResonStop()
            {
                Id = 14,StatuId = 1,WorkId = 2, StartTime = new DateTime(2017, 1, 2, 18, 0, 0), EndTime = new DateTime(2017, 1, 2, 18, 10, 0)
            },
            new ResonStop()
            {
                Id = 15,StatuId = 4,WorkId = 4, StartTime = new DateTime(2017, 1, 2, 20, 0, 0), EndTime = new DateTime(2017, 1, 3, 2, 10, 0)
            },
            new ResonStop()
            {
                Id = 16,StatuId = 1,WorkId = 4, StartTime = new DateTime(2017, 1, 3, 4, 0, 0), EndTime = new DateTime(2017, 1, 3, 4, 30, 0)
            },
            new ResonStop()
            {
                Id = 17,StatuId = 3,WorkId = 6, StartTime = new DateTime(2017, 1, 3, 6, 0, 0), EndTime = new DateTime(2017, 1, 3, 9, 30, 0)
            },
            new ResonStop()
            {
                Id = 18,StatuId = 1,WorkId = 9, StartTime = new DateTime(2017, 1, 3, 10, 0, 0), EndTime = new DateTime(2017, 1, 3, 10, 10, 0)
            },
            new ResonStop()
            {
                Id = 19,StatuId = 1,WorkId = 2, StartTime = new DateTime(2017, 1, 3, 12, 0, 0), EndTime = new DateTime(2017, 1, 3, 12, 30, 0)
            },
            new ResonStop()
            {
                Id = 20,StatuId = 1,WorkId = 1, StartTime = new DateTime(2017, 1, 3, 14, 0, 0), EndTime = new DateTime(2017, 1, 3, 14, 10, 0)
            },
            new ResonStop()
            {
                Id = 21,StatuId = 2,WorkId = 7, StartTime = new DateTime(2017, 1, 3, 15, 0, 0), EndTime = new DateTime(2017, 1, 3, 18, 45, 0)
            },
            new ResonStop()
            {
                Id = 22,StatuId = 1,WorkId = 5, StartTime = new DateTime(2017, 1, 3, 20, 0, 0), EndTime = new DateTime(2017, 1, 3, 20, 30, 0)
            },
            new ResonStop()
            {
                Id = 23,StatuId = 1,WorkId = 5, StartTime = new DateTime(2017, 1, 3, 22, 0, 0), EndTime = new DateTime(2017, 1, 3, 22, 10, 0)
            }
         

        };
        public List<ResonStop> getAll()
        {
            return workStatus;
        }

        public void Add(ResonStop entity)
        {
            entity.Id = workStatus.Count + 1;
            workStatus.Add(entity);
        }

        public void Update(ResonStop entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ResonStop entity)
        {
            throw new NotImplementedException();
        }
    }
}
