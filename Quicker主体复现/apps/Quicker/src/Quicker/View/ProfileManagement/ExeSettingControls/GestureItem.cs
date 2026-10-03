using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Quicker.Domain.PowerMouse;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd.Gestures;

namespace Quicker.View.ProfileManagement.ExeSettingControls;

public class GestureItem : INotifyPropertyChanged
{
	private bool C5SLJ8H3676;

	private bool Pi8LJant0Yd;

	private GestureAction snbLJ7JMi48;

	[CompilerGenerated]
	private int uoDLJRyBTwg;

	private bool rARLJqSYVr3;

	private Gesture yAPLJcxUeX1;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static GestureItem iGEZQfFDohNWkvyKcruD;

	public Gesture Gesture
	{
		get
		{
			return yAPLJcxUeX1;
		}
		set
		{
			yAPLJcxUeX1 = value;
			OnPropertyChanged("Gesture");
		}
	}

	public string Name => Gesture?.Name;

	public IList<Point> Points => Gesture?.WindowsPoints;

	public bool IsPreset => Gesture.Id.StartsWith("preset:");

	public bool HasDefaultAction
	{
		get
		{
			return C5SLJ8H3676;
		}
		set
		{
			C5SLJ8H3676 = value;
			OnPropertyChanged("HasDefaultAction");
		}
	}

	public bool HasExeAction
	{
		get
		{
			return Pi8LJant0Yd;
		}
		set
		{
			Pi8LJant0Yd = value;
			OnPropertyChanged("HasExeAction");
		}
	}

	public GestureAction GestureAction
	{
		get
		{
			return snbLJ7JMi48;
		}
		set
		{
			snbLJ7JMi48 = value;
			HasSubAction = snbLJ7JMi48?.SubActions?.HasData() == true;
			OnPropertyChanged("GestureAction");
		}
	}

	public int ExeActionCount
	{
		[CompilerGenerated]
		get
		{
			return uoDLJRyBTwg;
		}
		[CompilerGenerated]
		set
		{
			uoDLJRyBTwg = value;
		}
	}

	public bool HasSubAction
	{
		get
		{
			return rARLJqSYVr3;
		}
		set
		{
			rARLJqSYVr3 = value;
			OnPropertyChanged("HasSubAction");
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

	internal static bool pR1MDhFDfTKR9D1t9Tos()
	{
		return iGEZQfFDohNWkvyKcruD == null;
	}
}
