using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quicker.View.Controls;

public class KeyValuePair : INotifyPropertyChanged
{
	private string N3wLKAE3xjw;

	private string KEnLKOSQrJk;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static KeyValuePair K4d0qrFuJplFOnbwniSv;

	public string Key
	{
		get
		{
			return N3wLKAE3xjw;
		}
		set
		{
			if (!(value == N3wLKAE3xjw))
			{
				N3wLKAE3xjw = value;
				OnPropertyChanged("Key");
			}
		}
	}

	public string Value
	{
		get
		{
			return KEnLKOSQrJk;
		}
		set
		{
			if (!(value == KEnLKOSQrJk))
			{
				KEnLKOSQrJk = value;
				OnPropertyChanged("Value");
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

	public KeyValuePair()
	{
	}

	public KeyValuePair(string key, string value)
	{
		Key = key;
		Value = value;
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

	internal static bool uCgGTUFukMtV1KdS2RxV()
	{
		return K4d0qrFuJplFOnbwniSv == null;
	}
}
