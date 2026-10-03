using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Domain.Actions.X;

namespace Quicker.View.X;

internal class SubProgramNavItem : INotifyPropertyChanged
{
	[CompilerGenerated]
	private bool F7MLYlu7Esc;

	[CompilerGenerated]
	private string ty3LYi3J2Ai;

	[CompilerGenerated]
	private string vAALY3NH1oh;

	[CompilerGenerated]
	private string YpULYfqOXf1;

	[CompilerGenerated]
	private string KcmLYznsShq;

	[CompilerGenerated]
	private WeakReference<SubProgram> bfPLIw9NoB2;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static SubProgramNavItem cn16u3FOz7B9gS8L7C1c;

	public bool IsMain
	{
		[CompilerGenerated]
		get
		{
			return F7MLYlu7Esc;
		}
		[CompilerGenerated]
		set
		{
			F7MLYlu7Esc = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ty3LYi3J2Ai;
		}
		[CompilerGenerated]
		set
		{
			ty3LYi3J2Ai = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return vAALY3NH1oh;
		}
		[CompilerGenerated]
		set
		{
			vAALY3NH1oh = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return YpULYfqOXf1;
		}
		[CompilerGenerated]
		set
		{
			YpULYfqOXf1 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return KcmLYznsShq;
		}
		[CompilerGenerated]
		set
		{
			KcmLYznsShq = value;
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

	[SpecialName]
	[CompilerGenerated]
	public WeakReference<SubProgram> aUHLYOSR7GK()
	{
		return bfPLIw9NoB2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void Uw7LYFHq947(WeakReference<SubProgram> weakReference_1)
	{
		bfPLIw9NoB2 = weakReference_1;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool dwWe22FJVgrDMcXNBOBm()
	{
		return cn16u3FOz7B9gS8L7C1c == null;
	}

	internal static void EEZkVWFJFA4kgGtB4rFv()
	{
	}
}
