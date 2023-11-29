using APP.Configuration.Entity;
using APP.Infrastructure;
using FreeSql;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Configuration;

public class ConfigGroupRepository : BaseRepository<ConfigGroup, int>
{

	public ConfigGroupRepository(ILogger<ConfigGroupRepository> logger, IFreeSql<ConfigurationSQLite> freeSql) : base(freeSql, null, null)
	{
	
	}

}
