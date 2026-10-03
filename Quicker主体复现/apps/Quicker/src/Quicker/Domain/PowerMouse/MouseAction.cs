using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Quicker.Annotations;
using Quicker.Common.QuickActions;

namespace Quicker.Domain.PowerMouse;

public class MouseAction : INotifyPropertyChanged, IQuickActionItem
{
	private bool JD0tIGw4XuW = true;

	[CompilerGenerated]
	private Guid j8ptIsG6A34 = Guid.NewGuid();

	[CompilerGenerated]
	private MouseActionType Fo5tIHOL3ro;

	[CompilerGenerated]
	private int? C6XtI1tspUG;

	[CompilerGenerated]
	private int? WfjtIbas7C4;

	[CompilerGenerated]
	private MouseButtons? EqftI6YuQpP;

	[CompilerGenerated]
	private bool KjgtIXGwOrR;

	[CompilerGenerated]
	private int NV5tImvHAh4;

	[CompilerGenerated]
	private MouseActionLocation ql6tIKa58sx;

	[CompilerGenerated]
	private bool jRytIxugPRY;

	[CompilerGenerated]
	private bool wpQtIrI9CyW;

	[CompilerGenerated]
	private string[] HLHtIpRQ71W;

	[CompilerGenerated]
	private string[] LWttIBLwRAb;

	[CompilerGenerated]
	private string EIDtIQKEtM2;

	[CompilerGenerated]
	private MouseOperationType Ev3tIjuChf4;

	[CompilerGenerated]
	private bool quDtIndA3F0;

	[CompilerGenerated]
	private DateTime? ljCtI4JmiiR;

	[CompilerGenerated]
	private int lhbtI5dOdpl;

	[CompilerGenerated]
	private QuickActionType N8WtIDP6BmI;

	[CompilerGenerated]
	private string BijtIdTrtLd;

	[CompilerGenerated]
	private string Pe1tIoG95p7;

	[CompilerGenerated]
	private string jsKtITKMBYR;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	[CompilerGenerated]
	private int wNttIMrXNr0;

	internal static MouseAction aFMsPYQJXOb214aO1AJE;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return j8ptIsG6A34;
		}
		[CompilerGenerated]
		set
		{
			j8ptIsG6A34 = value;
		}
	}

	public MouseActionType MouseActionType
	{
		[CompilerGenerated]
		get
		{
			return Fo5tIHOL3ro;
		}
		[CompilerGenerated]
		set
		{
			Fo5tIHOL3ro = value;
		}
	}

	public int? ControlKey
	{
		[CompilerGenerated]
		get
		{
			return C6XtI1tspUG;
		}
		[CompilerGenerated]
		set
		{
			C6XtI1tspUG = value;
		}
	}

	public int? AdornKey
	{
		[CompilerGenerated]
		get
		{
			return WfjtIbas7C4;
		}
		[CompilerGenerated]
		set
		{
			WfjtIbas7C4 = value;
		}
	}

	public MouseButtons? MouseButton
	{
		[CompilerGenerated]
		get
		{
			return EqftI6YuQpP;
		}
		[CompilerGenerated]
		set
		{
			EqftI6YuQpP = value;
		}
	}

	public bool HasMouseButton
	{
		get
		{
			if (MouseButton.HasValue)
			{
				return MouseButton.Value != MouseButtons.None;
			}
			return false;
		}
	}

	public bool DisableInFullScreen
	{
		[CompilerGenerated]
		get
		{
			return KjgtIXGwOrR;
		}
		[CompilerGenerated]
		set
		{
			KjgtIXGwOrR = value;
		}
	}

	public int TriggerDistance
	{
		[CompilerGenerated]
		get
		{
			return NV5tImvHAh4;
		}
		[CompilerGenerated]
		set
		{
			NV5tImvHAh4 = value;
		}
	}

	public MouseActionLocation Location
	{
		[CompilerGenerated]
		get
		{
			return ql6tIKa58sx;
		}
		[CompilerGenerated]
		set
		{
			ql6tIKa58sx = value;
		}
	}

	public bool LimitOnPrimaryScreen
	{
		[CompilerGenerated]
		get
		{
			return jRytIxugPRY;
		}
		[CompilerGenerated]
		set
		{
			jRytIxugPRY = value;
		}
	}

	public bool ActivatePointingWindow
	{
		[CompilerGenerated]
		get
		{
			return wpQtIrI9CyW;
		}
		[CompilerGenerated]
		set
		{
			wpQtIrI9CyW = value;
		}
	}

	public string[] BlackList
	{
		[CompilerGenerated]
		get
		{
			return HLHtIpRQ71W;
		}
		[CompilerGenerated]
		set
		{
			HLHtIpRQ71W = value;
		}
	}

	public string[] WhiteList
	{
		[CompilerGenerated]
		get
		{
			return LWttIBLwRAb;
		}
		[CompilerGenerated]
		set
		{
			LWttIBLwRAb = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return EIDtIQKEtM2;
		}
		[CompilerGenerated]
		set
		{
			EIDtIQKEtM2 = value;
		}
	}

	public bool IsEnabled
	{
		get
		{
			return JD0tIGw4XuW;
		}
		set
		{
			JD0tIGw4XuW = value;
			OnPropertyChanged("IsEnabled");
		}
	}

	public MouseOperationType Operation
	{
		[CompilerGenerated]
		get
		{
			return Ev3tIjuChf4;
		}
		[CompilerGenerated]
		set
		{
			Ev3tIjuChf4 = value;
		}
	}

	public bool TriggerActionWhenMouseUp
	{
		[CompilerGenerated]
		get
		{
			return quDtIndA3F0;
		}
		[CompilerGenerated]
		set
		{
			quDtIndA3F0 = value;
		}
	}

	public DateTime? LastEditTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return ljCtI4JmiiR;
		}
		[CompilerGenerated]
		set
		{
			ljCtI4JmiiR = value;
		}
	}

	public int DebounceMs
	{
		[CompilerGenerated]
		get
		{
			return lhbtI5dOdpl;
		}
		[CompilerGenerated]
		set
		{
			lhbtI5dOdpl = value;
		}
	}

	public QuickActionType ActionType
	{
		[CompilerGenerated]
		get
		{
			return N8WtIDP6BmI;
		}
		[CompilerGenerated]
		set
		{
			N8WtIDP6BmI = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return BijtIdTrtLd;
		}
		[CompilerGenerated]
		set
		{
			BijtIdTrtLd = value;
		}
	}

	public string ParamData
	{
		[CompilerGenerated]
		get
		{
			return Pe1tIoG95p7;
		}
		[CompilerGenerated]
		set
		{
			Pe1tIoG95p7 = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return jsKtITKMBYR;
		}
		[CompilerGenerated]
		set
		{
			jsKtITKMBYR = value;
		}
	}

	[JsonIgnore]
	public int Priority
	{
		[CompilerGenerated]
		get
		{
			return wNttIMrXNr0;
		}
		[CompilerGenerated]
		set
		{
			wNttIMrXNr0 = value;
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

	internal static bool LASaGWQJ26qhWm3WKgnv()
	{
		return aFMsPYQJXOb214aO1AJE == null;
	}
}
