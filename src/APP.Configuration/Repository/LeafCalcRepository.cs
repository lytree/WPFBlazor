using Microsoft.Extensions.Logging;
using APP.Configuration.Enums;
using APP.Configuration.Entity;
using FreeSql;
using APP.Infrastructure;

namespace APP.Configuration;

public class LeafCalcRepository : BaseRepository<LeafCalcInfo>
{

	public LeafCalcRepository(IFreeSql<ConfigurationSQLite> freeSql) : base(freeSql, null, null)
	{

	}
}
