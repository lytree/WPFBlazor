using Autofac;
using Autofac.Builder;
using FreeSql;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Configuration
{
    public static class ConfigurationExtension
    {
        public static void AddConfigurationFeeSQL(this ContainerBuilder builder, string connect = "db.db")
        {
            Console.WriteLine("------------------");
            builder.Register<IFreeSql>((c) =>
            {
                var logger = c.IsRegistered<ILogger>() ? c.Resolve<ILogger>() : NullLogger.Instance;
                var fsql1 = new FreeSqlBuilder().UseConnectionString(DataType.Sqlite, $"Data Source={connect};Version=3").UseAutoSyncStructure(true).UseMonitorCommand(str => (c.Resolve<ILogger>() ?? NullLogger.Instance).LogInformation(str.CommandText)).Build();
                return fsql1;
            });
        }
    }

}
