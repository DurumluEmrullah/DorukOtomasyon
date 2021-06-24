using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkService workService = new WorkManager(new WorkDal());
            IStatuService statuService = new StatuManager(new StatuDal());
            IResonStopService resonStopService = new ResonStopManager(new ResonStopDal());

            List<Work> works = workService.GetAll().Data;
            List<Statu> status = statuService.GetAll().Data;
            List<ResonStop> resonStops = resonStopService.GetAll().Data;
            List<WorkDetailDto> workDetailDtos = workService.GetAllWorkDetails().Data;
            foreach (var work in works)
            {
                Console.WriteLine(work.Id+" | "+work.Name+" | "+work.StartTime+" | "+work.EndTime);

            }

            Console.WriteLine("--------------------------------------------------------");
            foreach (var statu in status)
            {
                Console.WriteLine(statu.Id+" "+statu.Name);
            }

            foreach (var resonStop in resonStops)
            {
                Console.WriteLine(resonStop.Id+" | "+resonStop.StatuId+" | "+resonStop.StartTime+" | "+resonStop.EndTime);
            }
            Console.WriteLine("------------------------------------------------------------------");

            foreach (var workDetailDto in workDetailDtos)
            {
                Console.WriteLine(workDetailDto.Name +" "+workDetailDto.ResonStops.Count);
                foreach (var resonStop in workDetailDto.ResonStops)
                {
                    Console.WriteLine(resonStop.WorkId+" "+resonStop.Id);
                }
                Console.WriteLine("------------------------------");
            }


        }
    }
}
