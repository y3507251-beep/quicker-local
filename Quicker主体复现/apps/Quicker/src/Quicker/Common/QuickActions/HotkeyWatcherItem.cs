using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using Newtonsoft.Json;
using Quicker.Utilities.Hooks;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Common.QuickActions;

public class HotkeyWatcherItem : INotifyPropertyChanged, IQuickActionItem
{
	private string OaBt8NcEsnw;

	private string R04t8JU4GQS;

	private bool urSt80eRBhZ = true;

	private string gkRt8CjL1aO;

	private int WiGt8Pw77b1;

	private string ktmt8EnuAkT;

	private string yk7t8yZvEtB;

	[CompilerGenerated]
	private string jW0t88x7I7u;

	[CompilerGenerated]
	private QuickActionType EY0t8aK7cR2;

	[CompilerGenerated]
	private string Jk3t87Zy7M6;

	[CompilerGenerated]
	private string Nrft8Rx6NxN;

	[CompilerGenerated]
	private string FjKt8qcaWDC;

	[CompilerGenerated]
	private Hotkey dx9t8cmvZY8;

	[CompilerGenerated]
	private Hotkey VjDt8VqEguu;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static HotkeyWatcherItem watMOZQEVU3u4Zyqv29j;

	public bool IsEnabled
	{
		get
		{
			return urSt80eRBhZ;
		}
		set
		{
			if (value != urSt80eRBhZ)
			{
				urSt80eRBhZ = value;
				OnPropertyChanged("IsEnabled");
			}
		}
	}

	public string Description
	{
		get
		{
			return gkRt8CjL1aO;
		}
		set
		{
			if (!(value == gkRt8CjL1aO))
			{
				gkRt8CjL1aO = value;
				OnPropertyChanged("Description");
			}
		}
	}

	public string Hotkey1Data
	{
		get
		{
			return OaBt8NcEsnw;
		}
		set
		{
			OaBt8NcEsnw = value;
			Hotkey1 = (string.IsNullOrEmpty(OaBt8NcEsnw) ? null : new Hotkey(OaBt8NcEsnw));
			OnPropertyChanged("Hotkey1Data");
			OnPropertyChanged("KeyName");
		}
	}

	public string Hotkey2Data
	{
		get
		{
			return R04t8JU4GQS;
		}
		set
		{
			R04t8JU4GQS = value;
			Hotkey2 = (string.IsNullOrEmpty(R04t8JU4GQS) ? null : new Hotkey(R04t8JU4GQS));
			OnPropertyChanged("Hotkey2Data");
			OnPropertyChanged("KeyName");
		}
	}

	public int DelayMs
	{
		get
		{
			return WiGt8Pw77b1;
		}
		set
		{
			if (value != WiGt8Pw77b1)
			{
				WiGt8Pw77b1 = value;
				OnPropertyChanged("DelayMs");
			}
		}
	}

	public string BindingProcessName
	{
		get
		{
			return ktmt8EnuAkT;
		}
		set
		{
			if (!(value == ktmt8EnuAkT))
			{
				ktmt8EnuAkT = value;
				OnPropertyChanged("BindingProcessName");
			}
		}
	}

	public string BlackList
	{
		get
		{
			return yk7t8yZvEtB;
		}
		set
		{
			if (!(value == yk7t8yZvEtB))
			{
				yk7t8yZvEtB = value;
				OnPropertyChanged("BlackList");
			}
		}
	}

	public string ValidForMachines
	{
		[CompilerGenerated]
		get
		{
			return jW0t88x7I7u;
		}
		[CompilerGenerated]
		set
		{
			jW0t88x7I7u = value;
		}
	}

	public QuickActionType ActionType
	{
		[CompilerGenerated]
		get
		{
			return EY0t8aK7cR2;
		}
		[CompilerGenerated]
		set
		{
			EY0t8aK7cR2 = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return Jk3t87Zy7M6;
		}
		[CompilerGenerated]
		set
		{
			Jk3t87Zy7M6 = value;
		}
	}

	public string ParamData
	{
		[CompilerGenerated]
		get
		{
			return Nrft8Rx6NxN;
		}
		[CompilerGenerated]
		set
		{
			Nrft8Rx6NxN = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return FjKt8qcaWDC;
		}
		[CompilerGenerated]
		set
		{
			FjKt8qcaWDC = value;
		}
	}

	[JsonIgnore]
	public Hotkey Hotkey1
	{
		[CompilerGenerated]
		get
		{
			return dx9t8cmvZY8;
		}
		[CompilerGenerated]
		private set
		{
			dx9t8cmvZY8 = value;
		}
	}

	[JsonIgnore]
	public Hotkey Hotkey2
	{
		[CompilerGenerated]
		get
		{
			return VjDt8VqEguu;
		}
		[CompilerGenerated]
		private set
		{
			VjDt8VqEguu = value;
		}
	}

	[JsonIgnore]
	public string KeyName
	{
		get
		{
			object obj;
			if (Hotkey2 == null)
			{
				Hotkey hotkey = Hotkey1;
				if (hotkey == null)
				{
					obj = null;
				}
				else
				{
					obj = hotkey.ToString();
					if (obj != null)
					{
						goto IL_0023;
					}
				}
				obj = "";
				goto IL_0023;
			}
			return $"{Hotkey1}, {Hotkey2}".Replace(" ", "");
			IL_0023:
			return (string)obj;
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

	public bool IsMatchHotkey1(HookKeyEventArgs e, ModifierKeys modifierKeys)
	{
		if (Hotkey1 != null && Hotkey1.Key == (VirtualKeyCode)e.KeyCode)
		{
			return Hotkey1.Modifiers == modifierKeys;
		}
		return false;
	}

	public bool IsMatchHotkey2(HookKeyEventArgs e, ModifierKeys modifierKeys)
	{
		if (Hotkey2 != null && Hotkey2.Key == (VirtualKeyCode)e.KeyCode)
		{
			return Hotkey2.Modifiers == modifierKeys;
		}
		return false;
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		OnPropertyChanged(propertyName);
		return true;
	}

	internal static bool NpMbJFQEQ6PeKyFwJhY8()
	{
		return watMOZQEVU3u4Zyqv29j == null;
	}
}
