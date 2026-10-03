using System;
using System.Collections.Generic;

namespace Quicker.Common.Entities;

public class CommonTriggerTask
{
	public Guid Id { get; set; }

	public string Note { get; set; }

	public bool IsEnabled { get; set; }

	public string EventType { get; set; }

	public int DebounceMs { get; set; }

	public int ThrottleMs { get; set; }

	public IDictionary<string, object> Params { get; set; }

	public DateTime? LastEditTimeUtc { get; set; }

	public string ValidForMachines { get; set; }

	public string ActionIdOrName { get; set; }

	public string ActionParam { get; set; }

	public bool SkipFurtherTasks { get; set; }

	public int DelayMs { get; set; }

	public string EventFilterExpression { get; set; }

	public CommonTriggerTask()
	{
		Id = Guid.NewGuid();
	}

	public T TryGetParamValue<T>(string paramName, T defaultValue)
	{
		if (Params == null || !Params.ContainsKey(paramName))
		{
			return defaultValue;
		}
		object obj = Params[paramName];
		if (obj == null)
		{
			return defaultValue;
		}
		if (obj is T)
		{
			return (T)obj;
		}
		try
		{
			return (T)Convert.ChangeType(obj, typeof(T));
		}
		catch (Exception)
		{
			return defaultValue;
		}
	}
}
