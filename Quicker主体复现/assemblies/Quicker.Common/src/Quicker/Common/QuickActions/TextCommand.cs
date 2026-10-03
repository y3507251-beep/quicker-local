using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Common.Annotations;

namespace Quicker.Common.QuickActions;

public class TextCommand : IQuickActionItem, INotifyPropertyChanged
{
	public Guid Id { get; set; }

	public string CmdText { get; set; }

	public bool UseRegex { get; set; }

	public string BindingProcessName { get; set; }

	public string Title { get; set; }

	public QuickActionType ActionType { get; set; }

	public string Data { get; set; }

	public string ParamData { get; set; }

	public string Message { get; set; }

	public bool IsDisabled { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }

	public bool UseBackspaceWhenImeOpen { get; set; }

	public string Group { get; set; }

	public int? TriggerKey { get; set; }

	public bool ExtractFirstMatchGroup { get; set; }

	public bool IgnoreCase { get; set; }

	[JsonIgnore]
	public bool IsDirectInputTrigger => TriggerKey == 0;

	public event PropertyChangedEventHandler PropertyChanged;

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
