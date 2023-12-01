using Autofac;
using APP.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using APP.Shared;

namespace APP.Extensions
{
	internal static class AppServiceCollectionExtension
	{
		public static void AddAppService(this ContainerBuilder builder)
		{

			builder.AddConfigurationFeeSQL();
		
			builder.RegisterType<PlatformsService>().As<IPlatformsService>();
		}
	}
}
