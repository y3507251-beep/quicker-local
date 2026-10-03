using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Common.Annotations;

namespace Quicker.Common.QuickActions;

public class KeyActionItem : INotifyPropertyChanged
{
	private bool z3lt8Zc1Ssg;

	private string IGJt895m9eU;

	private bool qCTt8h7bYOH;

	private int yRot8ee3ELd;

	private string H0Lt8Yyd8Ab;

	private string VlHt8I5MpPG;

	[CompilerGenerated]
	private TempQuickActionItem mcYt8Whs2WW;

	[CompilerGenerated]
	private TempQuickActionItem RIZt8k2eZeO;

	[CompilerGenerated]
	private TempQuickActionItem pG9t8GbPgXj;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static KeyActionItem l5oaq9QEcGf1kxvtgey5;

	public int Key
	{
		get
		{
			return yRot8ee3ELd;
		}
		set
		{
			yRot8ee3ELd = value;
			OnPropertyChanged("Key");
		}
	}

	public bool IsDisabled
	{
		get
		{
			return qCTt8h7bYOH;
		}
		set
		{
			qCTt8h7bYOH = value;
			OnPropertyChanged("IsDisabled");
		}
	}

	public string Description
	{
		get
		{
			return IGJt895m9eU;
		}
		set
		{
			IGJt895m9eU = value;
			OnPropertyChanged("Description");
		}
	}

	public string BindingProcessName
	{
		get
		{
			return H0Lt8Yyd8Ab;
		}
		set
		{
			if (!(value == H0Lt8Yyd8Ab))
			{
				H0Lt8Yyd8Ab = value;
				OnPropertyChanged("BindingProcessName");
			}
		}
	}

	public string BlackList
	{
		get
		{
			return VlHt8I5MpPG;
		}
		set
		{
			if (!(value == VlHt8I5MpPG))
			{
				VlHt8I5MpPG = value;
				OnPropertyChanged("BlackList");
			}
		}
	}

	public TempQuickActionItem DoubleClickAction
	{
		[CompilerGenerated]
		get
		{
			return mcYt8Whs2WW;
		}
		[CompilerGenerated]
		set
		{
			mcYt8Whs2WW = value;
		}
	}

	public TempQuickActionItem LongPressAction
	{
		[CompilerGenerated]
		get
		{
			return RIZt8k2eZeO;
		}
		[CompilerGenerated]
		set
		{
			RIZt8k2eZeO = value;
		}
	}

	public TempQuickActionItem SingleClickAction
	{
		[CompilerGenerated]
		get
		{
			return pG9t8GbPgXj;
		}
		[CompilerGenerated]
		set
		{
			pG9t8GbPgXj = value;
		}
	}

	public bool AutoBackspace
	{
		get
		{
			return z3lt8Zc1Ssg;
		}
		set
		{
			z3lt8Zc1Ssg = value;
			OnPropertyChanged("AutoBackspace");
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

	internal static bool CbJ4vZQEWo3uogr85dNW()
	{
		return l5oaq9QEcGf1kxvtgey5 == null;
	}
}
