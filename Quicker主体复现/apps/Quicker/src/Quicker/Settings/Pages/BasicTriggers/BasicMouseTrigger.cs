using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Quicker.Annotations;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;

namespace Quicker.Settings.Pages.BasicTriggers;

public class BasicMouseTrigger : INotifyPropertyChanged
{
	private MouseAction B24DASwBK7;

	[CompilerGenerated]
	private MouseActionType aECDOqXDvf;

	[CompilerGenerated]
	private MouseButtons NEvDFNNMMP;

	[CompilerGenerated]
	private int? rCmDU55m7l;

	[CompilerGenerated]
	private bool hNsDlJTDlS;

	[CompilerGenerated]
	private string zwvDiPUMM2;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static BasicMouseTrigger PCE91bsJ7JhvEk8sH5W;

	public MouseActionType MouseActionType
	{
		[CompilerGenerated]
		get
		{
			return aECDOqXDvf;
		}
		[CompilerGenerated]
		set
		{
			aECDOqXDvf = value;
		}
	}

	public MouseButtons MouseButton
	{
		[CompilerGenerated]
		get
		{
			return NEvDFNNMMP;
		}
		[CompilerGenerated]
		set
		{
			NEvDFNNMMP = value;
		}
	}

	public int? ControlKey
	{
		[CompilerGenerated]
		get
		{
			return rCmDU55m7l;
		}
		[CompilerGenerated]
		set
		{
			rCmDU55m7l = value;
		}
	}

	public MouseAction MouseAction
	{
		get
		{
			return B24DASwBK7;
		}
		set
		{
			B24DASwBK7 = value;
			OnPropertyChanged("MouseAction");
			OnPropertyChanged("IsEnabledStr");
			OnPropertyChanged("ActionSummary");
		}
	}

	public bool IsLocked
	{
		[CompilerGenerated]
		get
		{
			return hNsDlJTDlS;
		}
		[CompilerGenerated]
		set
		{
			hNsDlJTDlS = value;
		}
	}

	public string LockReason
	{
		[CompilerGenerated]
		get
		{
			return zwvDiPUMM2;
		}
		[CompilerGenerated]
		set
		{
			zwvDiPUMM2 = value;
		}
	}

	public string MouseActionName => MouseActionType.GetEnumDisplayName().Replace("鼠标键", "");

	public string ActionSummary
	{
		get
		{
			if (IsLocked)
			{
				return LockReason ?? "";
			}
			if (MouseAction == null)
			{
				return "-";
			}
			if (MouseAction.Operation == MouseOperationType.QuickAction)
			{
				return MouseAction.GetSummary();
			}
			return "【内置】" + MouseAction.Operation.GetEnumDisplayName();
		}
	}

	public string IsEnabledStr
	{
		get
		{
			if (MouseAction == null)
			{
				return "";
			}
			if (!MouseAction.IsEnabled)
			{
				return "否";
			}
			return "是";
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool QyY6JMskkCihVf8ln1S()
	{
		return PCE91bsJ7JhvEk8sH5W == null;
	}
}
