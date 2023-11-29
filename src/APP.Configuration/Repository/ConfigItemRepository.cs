using APP.Configuration.Entity;
using APP.Infrastructure;
using FreeSql;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Configuration;

public class ConfigItemRepository : BaseRepository<ConfigItem, int>
{
	public ConfigItemRepository(IFreeSql<ConfigurationSQLite> fsql) : base(fsql, null, null)
	{
	
	}
}
