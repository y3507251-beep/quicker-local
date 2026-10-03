using CommunityToolkit.Mvvm.ComponentModel;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Public.Extensions;
using r3EUytwSQ9vNYu3Es8s;

namespace Quicker.Settings.Pages.Basic;

public class ObservableCommonTriggerTask : ObservableObject
{
	private readonly CommonTriggerTask UJVTVuK46y;

	internal static ObservableCommonTriggerTask RGAvaw79WCjfFVABLJ5;

	public CommonTriggerTask Value => UJVTVuK46y;

	public string EventType => UJVTVuK46y.EventType;

	public string EventTypeDesc
	{
		get
		{
			oXLGvbwTuCxD9pGrbDD oXLGvbwTuCxD9pGrbDD = AppState.uICt7cXc7Qs().QS1f3oYkWA(UJVTVuK46y.EventType);
			object obj;
			if (oXLGvbwTuCxD9pGrbDD == null)
			{
				obj = null;
			}
			else
			{
				obj = oXLGvbwTuCxD9pGrbDD.wSbM2zcwFbs(UJVTVuK46y.EventType);
				if (obj != null)
				{
					goto IL_0036;
				}
			}
			obj = EventType;
			goto IL_0036;
			IL_0036:
			return (string)obj;
		}
	}

	public string Note
	{
		get
		{
			if (!UJVTVuK46y.Note.IsNullOrEmpty())
			{
				return UJVTVuK46y.Note;
			}
			return "-";
		}
	}

	public string ValidForMachines => UJVTVuK46y.ValidForMachines;

	public string ActionIdOrName => UJVTVuK46y.ActionIdOrName;

	public string ActionParam => UJVTVuK46y.ActionParam;

	public string EventSummary => AppState.uICt7cXc7Qs().QS1f3oYkWA(UJVTVuK46y.EventType)?.KDDMjfoUuvt(UJVTVuK46y);

	public bool IsEnabled
	{
		get
		{
			return UJVTVuK46y.IsEnabled;
		}
		set
		{
			UJVTVuK46y.IsEnabled = value;
			OnPropertyChanged("IsEnabled");
		}
	}

	public ObservableCommonTriggerTask(CommonTriggerTask task)
	{
		UJVTVuK46y = task;
	}

	static ObservableCommonTriggerTask()
	{
	}

	internal static bool LoNJnE7LTSnAyeswO5n()
	{
		return RGAvaw79WCjfFVABLJ5 == null;
	}

	internal static void Ap6w0A7ft6cAF4J8xUV()
	{
	}
}
