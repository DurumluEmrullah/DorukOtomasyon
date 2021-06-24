using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class WorkDal:IWorkDal
    {


        private List<Work> works =
            new List<Work>()
            {
                new Work
                {
                    Id = 1, Name = "1001", StartTime = new DateTime(2017, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(2017, 1, 1, 16, 0, 0)
                },
                new Work
                {
                    Id = 2, Name = "1002", StartTime = new DateTime(2017, 1, 1, 16, 0, 0),
                    EndTime = new DateTime(2017, 1, 2, 0, 0, 0)
                },
                new Work
                {
                    Id = 3, Name = "1003", StartTime = new DateTime(2017, 1, 2, 0, 0, 0),
                    EndTime = new DateTime(2017, 1, 2, 8, 0, 0)
                },
                new Work
                {
                    Id = 4, Name = "1004", StartTime = new DateTime(2017, 1, 2, 0, 0, 0),
                    EndTime = new DateTime(2017, 1, 2, 16, 0, 0)
                },
                new Work
                {
                    Id = 5, Name = "1005", StartTime =  new DateTime(2017, 1, 2, 16, 0, 0),
                    EndTime = new DateTime(2017, 1, 3, 0, 0, 0)
                },
                new Work
                {
                    Id = 6, Name = "1006", StartTime = new DateTime(2017, 1, 3, 0, 0, 0),
                    EndTime = new DateTime(2017, 1, 3, 8, 0, 0)
                },
                new Work
                {
                    Id = 7, Name = "1007", StartTime = new DateTime(2017, 1, 3, 8, 0, 0),
                    EndTime = new DateTime(2017, 1, 3, 16, 0, 0)
                },
                new Work
                {
                    Id = 8, Name = "1008", StartTime = new DateTime(2017, 1, 3, 16, 0, 0),
                    EndTime =  new DateTime(2017, 1, 4, 0, 0, 0)
                },
                new Work
                {
                    Id = 9, Name = "1009", StartTime = new DateTime(2017, 1, 4, 0, 0, 0),
                    EndTime = new DateTime(2017, 1, 4, 8, 0, 0)
                }
            };

        public List<Work> getAll()
        {
            return works;
        }

        public void Add(Work entity)
        {
            entity.Id = works.Count+1;
            works.Add(entity);
        }

        public void Update(Work entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Work entity)
        {
            throw new NotImplementedException();
        }

        public List<WorkDetailDto> getAllWorkDetail()
        {
            IResonStopDal resonStopDal = new ResonStopDal();
            
            
            List<Statu> status = (new StatuDal()).getAll();
            List<WorkDetailDto> workDetailDtos = new List<WorkDetailDto>();
            foreach (var work in works)
            {

                WorkDetailDto workDetail = new WorkDetailDto();
                List<ResonStop> resonStops = new List<ResonStop>();
                workDetail.Name = work.Name;
                foreach (var resonStop in resonStopDal.getAll())
                {
                    if (work.Id == resonStop.WorkId)
                    {
                        resonStops.Add(resonStop);
                    }
                }

                workDetail.ResonStops = resonStops;
                workDetailDtos.Add(workDetail);
                
            }

            return workDetailDtos;
            
        }
    }
}
