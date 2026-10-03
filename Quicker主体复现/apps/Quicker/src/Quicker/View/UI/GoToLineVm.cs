using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quicker.View.UI;

public class GoToLineVm : INotifyPropertyChanged
{
	private int CN5L0lnGggD;

	private int aoaL0iMsc2t;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static GoToLineVm yl9ZyTF3mOOdQlvi8k10;

	public int MaxLineNumber
	{
		get
		{
			return CN5L0lnGggD;
		}
		set
		{
			if (value != CN5L0lnGggD)
			{
				CN5L0lnGggD = value;
				OnPropertyChanged("MaxLineNumber");
			}
		}
	}

	public int GoToLineNumber
	{
		get
		{
			return aoaL0iMsc2t;
		}
		set
		{
			if (value != aoaL0iMsc2t)
			{
				aoaL0iMsc2t = value;
				OnPropertyChanged("GoToLineNumber");
			}
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

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool o1SbbbF3s5huJPq57fj1()
	{
		return yl9ZyTF3mOOdQlvi8k10 == null;
	}
}
