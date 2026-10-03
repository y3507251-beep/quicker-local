using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Quicker.Annotations;

namespace Quicker.View.Settings;

public class QuickTextItem : INotifyPropertyChanged
{
	private string iulL2ouh1D8;

	private string jGvL2TNtUYh;

	private string MGWL2MdYdQf;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static QuickTextItem paLDpUFjQLhlg3VGmgUZ;

	public string Title
	{
		get
		{
			return iulL2ouh1D8;
		}
		set
		{
			if (!(value == iulL2ouh1D8))
			{
				iulL2ouh1D8 = value;
				OnPropertyChanged("Title");
			}
		}
	}

	public string Note
	{
		get
		{
			return jGvL2TNtUYh;
		}
		set
		{
			if (!(value == jGvL2TNtUYh))
			{
				jGvL2TNtUYh = value;
				OnPropertyChanged("Note");
			}
		}
	}

	public string Content
	{
		get
		{
			return MGWL2MdYdQf ?? "";
		}
		set
		{
			if (!(value == MGWL2MdYdQf))
			{
				MGWL2MdYdQf = value;
				OnPropertyChanged("Content");
			}
		}
	}

	public bool IsEmpty => string.IsNullOrEmpty(Title);

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

	public static QuickTextItem FromDataString(string dataString)
	{
        string text = default;
		if (string.IsNullOrEmpty(dataString))
		{
			return null;
		}
		string[] array = dataString.Split(new char[1] { '|' }, 4);
		int num = 1;
		if (paLDpUFjQLhlg3VGmgUZ != null)
		{
			goto IL_002a;
		}
		goto IL_0046;
		IL_0058:
		object obj = null;
		goto IL_005e;
		IL_002a:
		text = default(string);
		if (array.Length >= 4)
		{
			text = array[0];
			if (array.Length <= 1)
			{
				num = 0;
				if (paLDpUFjQLhlg3VGmgUZ == null)
				{
					goto IL_0046;
				}
				goto IL_0058;
			}
			obj = array[1];
			goto IL_005e;
		}
		return null;
		IL_007e:
		object obj2 = "";
		goto IL_0084;
		IL_005e:
		string note = (string)obj;
		string text2 = ((array.Length > 2) ? array[2] : null);
		if (array.Length <= 3)
		{
			obj2 = text;
			if (obj2 == null)
			{
				goto IL_007e;
			}
		}
		else
		{
			obj2 = array[3];
			if (obj2 == null)
			{
				goto IL_007e;
			}
		}
		goto IL_0084;
		IL_0046:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0058;
		}
		goto IL_002a;
		IL_0084:
		string text3 = (string)obj2;
		switch (text2)
		{
		case "S":
		case "s":
			text3 = Regex.Unescape(text3);
			break;
		case "E":
		case "e":
			text3 = Uri.UnescapeDataString(text3);
			break;
		}
		return new QuickTextItem
		{
			Title = text,
			Note = note,
			Content = text3
		};
	}

	public string ToDataString()
	{
		if (Content.Contains("|") || Content.Contains("\r") || Content.Contains("\n"))
		{
			return Title?.Replace("|", "_") + "|" + Note?.Replace("|", "_") + "|E|" + Uri.EscapeDataString(Content ?? "");
		}
		return Title?.Replace("|", "_") + "|" + Note?.Replace("|", "_") + "||" + Content;
	}

	internal static bool lQwUvOFjFJk7XOr5xn6x()
	{
		return paLDpUFjQLhlg3VGmgUZ == null;
	}
}
