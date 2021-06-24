using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WorkManager>().As<IWorkService>().SingleInstance();
            builder.RegisterType<WorkDal>().As<IWorkDal>().SingleInstance();

            builder.RegisterType<ResonStopManager>().As<IResonStopService>().SingleInstance();
            builder.RegisterType<ResonStopDal>().As<IResonStopDal>().SingleInstance();

            builder.RegisterType<StatuManager>().As<IStatuService>().SingleInstance();
            builder.RegisterType<StatuDal>().As<IStatuDal>().SingleInstance();
        }
    }
}
