using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Configuration;

[Table(Name = "leaf_config")]
public class LeafConfig
{
	[Column(Name = "machine_id", IsPrimary = true)]
	[DisplayName("机组id")]
	public string MachineId { get; set; }
	[Column(Name = "tree_name")]
	[DisplayName("组织名称")]
	public string TreeName { get; set; }
	[Column(Name = "machine_name")]
	[DisplayName("机组名称")]
	public string MachineName { get; set; }

	[Column(Name = "position_id_s")]
	[DisplayName("20采样测点")]
	public string PositionIdS { get; set; }
	[Column(Name = "position_name_s")]
	[DisplayName("20采样测点名称")]
	public string PositionNameS { get; set; }
	[Column(Name = "position_id_l")]
	[DisplayName("1k采样测点")]
	public string PositionIdL { get; set; }
	[Column(Name = "position_name_l")]
	[DisplayName("1k采样测点名称")]
	public string PositionNameL { get; set; }

	[Column(Name = "natural_freqs")]
	[DisplayName("固有频率")]
	public string NaturalFreqs { get; set; }
	[Column(Name = "custom_freqs")]
	[DisplayName("自定义频率")]
	public string CustomFreqs { get; set; }
}
