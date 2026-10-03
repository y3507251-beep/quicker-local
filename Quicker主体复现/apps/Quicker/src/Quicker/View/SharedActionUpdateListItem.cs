using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Common;

namespace Quicker.View;

public class SharedActionUpdateListItem : INotifyPropertyChanged
{
	private bool FAlgFSFFZgN;

	[CompilerGenerated]
	private ActionItem DQkgF2vhk7Z;

	[CompilerGenerated]
	private string pGsgFuwr1vh;

	[CompilerGenerated]
	private string ofXgFNWGqrZ;

	[CompilerGenerated]
	private string a7RgFJKmKYg;

	[CompilerGenerated]
	private string UeGgF0Hbush;

	[CompilerGenerated]
	private ActionProfile b32gFCvCw7W;

	[CompilerGenerated]
	private string sTRgFPQe6ca;

	[CompilerGenerated]
	private string PeSgFEigYiq;

	[CompilerGenerated]
	private int c40gFyqRPS8;

	[CompilerGenerated]
	private int BqIgF8gTJSc;

	[CompilerGenerated]
	private DateTime? hmrgFaf5eK6;

	[CompilerGenerated]
	private DateTime? uRvgF7HnvG3;

	[CompilerGenerated]
	private int P6rgFRSd164;

	[CompilerGenerated]
	private int LsRgFqWlbqc;

	[CompilerGenerated]
	private DateTime? vT2gFcBu7lJ;

	[CompilerGenerated]
	private string PrggFVDmCh4;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static SharedActionUpdateListItem oqgpmQFWPDNp6H9DMJbG;

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return DQkgF2vhk7Z;
		}
		[CompilerGenerated]
		set
		{
			DQkgF2vhk7Z = value;
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return pGsgFuwr1vh;
		}
		[CompilerGenerated]
		set
		{
			pGsgFuwr1vh = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ofXgFNWGqrZ;
		}
		[CompilerGenerated]
		set
		{
			ofXgFNWGqrZ = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return a7RgFJKmKYg;
		}
		[CompilerGenerated]
		set
		{
			a7RgFJKmKYg = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return UeGgF0Hbush;
		}
		[CompilerGenerated]
		set
		{
			UeGgF0Hbush = value;
		}
	}

	public ActionProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return b32gFCvCw7W;
		}
		[CompilerGenerated]
		set
		{
			b32gFCvCw7W = value;
		}
	}

	public string ProfileId
	{
		[CompilerGenerated]
		get
		{
			return sTRgFPQe6ca;
		}
		[CompilerGenerated]
		set
		{
			sTRgFPQe6ca = value;
		}
	}

	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return PeSgFEigYiq;
		}
		[CompilerGenerated]
		set
		{
			PeSgFEigYiq = value;
		}
	}

	public int Row
	{
		[CompilerGenerated]
		get
		{
			return c40gFyqRPS8;
		}
		[CompilerGenerated]
		set
		{
			c40gFyqRPS8 = value;
		}
	}

	public int Col
	{
		[CompilerGenerated]
		get
		{
			return BqIgF8gTJSc;
		}
		[CompilerGenerated]
		set
		{
			BqIgF8gTJSc = value;
		}
	}

	public DateTime? CreateTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return hmrgFaf5eK6;
		}
		[CompilerGenerated]
		set
		{
			hmrgFaf5eK6 = value;
		}
	}

	public DateTime? LastEditTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return uRvgF7HnvG3;
		}
		[CompilerGenerated]
		set
		{
			uRvgF7HnvG3 = value;
		}
	}

	public int CurrentRevision
	{
		[CompilerGenerated]
		get
		{
			return P6rgFRSd164;
		}
		[CompilerGenerated]
		set
		{
			P6rgFRSd164 = value;
		}
	}

	public int LastRevision
	{
		[CompilerGenerated]
		get
		{
			return LsRgFqWlbqc;
		}
		[CompilerGenerated]
		set
		{
			LsRgFqWlbqc = value;
		}
	}

	public DateTime? LastUpdateTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return vT2gFcBu7lJ;
		}
		[CompilerGenerated]
		set
		{
			vT2gFcBu7lJ = value;
		}
	}

	public string LastUpdateNote
	{
		[CompilerGenerated]
		get
		{
			return PrggFVDmCh4;
		}
		[CompilerGenerated]
		set
		{
			PrggFVDmCh4 = value;
		}
	}

	public bool SkipCheckUpdate => Action.SkipCheckUpdate;

	public bool AutoUpdate => Action.AutoUpdate;

	public bool IsChecked
	{
		get
		{
			return FAlgFSFFZgN;
		}
		set
		{
			FAlgFSFFZgN = value;
			OnPropertyChanged("IsChecked");
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

	internal static bool dQA3DOFWMMAqvKFIUvY9()
	{
		return oqgpmQFWPDNp6H9DMJbG == null;
	}

	internal static void ggRGMJFWILJfEGaTW6Bb()
	{
	}
}
