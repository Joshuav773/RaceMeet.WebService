using Autofac;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utune.WebService.Config;
using Utune.WebService.Util;

namespace DetailersApp.WebService.Bootstrap
{
    public class ServiceBootstrap : BaseBootstrapModule
    {
        protected override void RegisterAdditionalDependencies(ContainerBuilder builder)
        {
            
        }
    }
}
