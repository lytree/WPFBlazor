using FreeSql.DataAnnotations;
using System.Xml.Linq;

namespace APP.Configuration;

/// <summary>
/// 配置项目
/// </summary>
[Table(Name = "config_group", DisableSyncStructure = false)]
public class ConfigGroup
{
	[Column(Name = "id", IsPrimary = true, IsIdentity = true)]
	public int? Id { get; set; }
	[Column(Name = "group_name")]
	public string Name { get; set; }
	[Column(Name = "group_key")]
	public string Key { get; set; }
	[Column(Name = "group_status")]
	public int Status { get; set; }

	[Column(Name = "group_desc")]
	public string? Description { get; set; }

	public IEnumerable<ConfigItem> Items { get; } = new List<ConfigItem>();
}