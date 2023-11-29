﻿using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APP.Configuration;

[Table(Name = "config_item")]
[Index("config_item_key", "item_group_key,item_key", IsUnique = true)]
public class ConfigItem
{
	[Column(Name = "id", IsPrimary = true, IsIdentity = true)]
	public int? Id { get; set; }
	[Column(Name = "item_name")]
	public string Name { get; set; }
	[Column(Name = "item_key")]
	public string Key { get; set; }

	[Column(Name = "item_group_key")]
	public string GroupKey { get; set; }
	[Column(Name = "item_value")]
	public string? Value { get; set; }
	[Column(Name = "item_status")]
	public int Status { get; set; }

	[Column(Name = "item_context")]
	public string? Context { get; set; }

	[Column(Name = "item_desc")]
	public string? Description { get; set; }

	public virtual ConfigGroup ConfigGroup { get; }
}
