using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Configuration.Enums
{
	public enum CalcTypes
	{
		[Description("结冰指数")]
		FreezeIndex,
		[Description("呼啸因子")]
		HowlFactor,
		[Description("拟态")]
		NaturalFreqsAmp,
		[Description("结构损伤指数")]
		StructDamage,
		[Description("叶尖损伤指数")]
		TipDamage,
		[Description("不平衡指数")]
		DeviationFactor,
		[Description("结冰指数修正")]
		FreezeIndexModify,
		[Description("呼啸因子修正")]
		HowlFactorModify,
		[Description("拟态修正")]
		NaturalFreqsAmpModify,
		[Description("结构损伤指数修正")]
		StructDamageModify,
		[Description("叶尖损伤指数修正")]
		TipDamageModify,
		[Description("不平衡指数修正")]
		DeviationFactorModify,
	}
}
