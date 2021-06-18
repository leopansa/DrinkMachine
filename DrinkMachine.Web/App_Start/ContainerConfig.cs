using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DrinkMachine.Data;
using DrinkMachine.Data.Services;

namespace DrinkMachine.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            //Autofac API
            var builder = new ContainerBuilder();

            //MvcApplication is define in the class of Global.asax from the start point of the Application
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<InMemoryCoin>().As<ICoinData>().SingleInstance();
            builder.RegisterType<InMemoryBeverage>().As<IBeverageData>().SingleInstance();
            builder.RegisterType<InMemoryMachine>().As<IMachineData>().SingleInstance();
            //.SingleInstance(); //this will never be use in real application because it would be only an one instance from all the users of the data.
            

            var container = builder.Build();
            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //mvc
            
        }
    }
}