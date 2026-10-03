using System;
using Quicker.Common.Entities;

namespace DmuKIFwWi8fjDRD9UF8;

internal static class I8ybeJwwP384EDVX62e
{
	internal static object yZQns1QFyDqNeeQOJeEV;

	public static bool z4dfFIlpLc(this CommonTriggerTask commonTriggerTask_0)
	{
		if (!string.IsNullOrEmpty(commonTriggerTask_0.ActionParam) && (commonTriggerTask_0.ActionParam.StartsWith("$$") || commonTriggerTask_0.ActionParam.StartsWith("$=")))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(commonTriggerTask_0.EventFilterExpression))
		{
			return commonTriggerTask_0.EventFilterExpression.StartsWith("$=");
		}
		return false;
	}

	public static bUHQ87w2IoOrheJgNRQ wMFfUsA3YB<bUHQ87w2IoOrheJgNRQ>(this CommonTriggerTask commonTriggerTask_0, string string_0, bUHQ87w2IoOrheJgNRQ XB8wYcwjel3shaYfxD5 = default(bUHQ87w2IoOrheJgNRQ))
	{
		if (commonTriggerTask_0.Params != null && commonTriggerTask_0.Params.ContainsKey(string_0))
		{
			object obj = commonTriggerTask_0.Params[string_0];
			if (obj is bUHQ87w2IoOrheJgNRQ)
			{
				return (bUHQ87w2IoOrheJgNRQ)obj;
			}
			return (bUHQ87w2IoOrheJgNRQ)Convert.ChangeType(obj, typeof(bUHQ87w2IoOrheJgNRQ));
		}
		return XB8wYcwjel3shaYfxD5;
	}

	internal static bool iNy8bdQFpVaS1xMu8MBX()
	{
		return yZQns1QFyDqNeeQOJeEV == null;
	}
}
