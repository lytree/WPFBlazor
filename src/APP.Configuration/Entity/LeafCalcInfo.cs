
using System;
using System.Collections.Generic;
using FreeSql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;
using System.ComponentModel;
using APP.Configuration.Enums;

namespace APP.Configuration;

[Table(Name = "leaf_calc_info")]
[Index("machine_time", "machine_id,start_time,end_time,calc_type", IsUnique = true)]
public class LeafCalcInfo
{
	[Column(Name = "id", IsPrimary = true, IsIdentity = true)]
	public long Id { get; set; }

	[Column(Name = "machine_id")]
	[DisplayName("机组id")]
	public string MachineId { get; set; }
	[Column(Name = "start_time")]
	[DisplayName("计算开始时间")]
	public DateTime StartTime { get; set; }
	[Column(Name = "end_time")]
	[DisplayName("计算结束时间")]
	public DateTime EndTime { get; set; }
	[Column(Name = "calc_type")]
	[DisplayName("计算类型")]
	public CalcTypes CalcType { get; set; }
	[Column(Name = "machine_name")]
	[DisplayName("机组名称")]
	public string MachineName { get; set; }
	[Column(Name = "tree_name")]
	[DisplayName("组织名")]
	public string TreeName { get; set; }
	[Column(Name = "curr_time")]
	[DisplayName("当前计算时间")]
	public DateTime CurrTime { get; set; }
	[Column(Name = "create_time")]
	[DisplayName("创建时间")]
	public DateTime CreateTime { get; set; }
	[Column(Name = "modify_value")]
	[DisplayName("修正倍数")]
	public float? ModifyValue { get; set; }
	[Column(IsIgnore = true)]
	[DisplayName("进度")]
	public double? Percent { get; set; }

}
