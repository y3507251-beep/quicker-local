using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Domain.Actions.X.StepRunners;

namespace Quicker.View.X;

public class XToolboxItem : INotifyPropertyChanged
{
	private IList<int> rC2LGoDtRaX;

	[CompilerGenerated]
	private string odCLGTnOko1;

	[CompilerGenerated]
	private string cnfLGMHuRFR;

	[CompilerGenerated]
	private string KltLGAwKW88;

	[CompilerGenerated]
	private string KMTLGOJbyPJ;

	[CompilerGenerated]
	private string w8DLGF0dETn;

	[CompilerGenerated]
	private string tbZLGUs917C;

	[CompilerGenerated]
	private string p6JLGl4gGyU;

	[CompilerGenerated]
	private int uNhLGi3pgvF;

	[CompilerGenerated]
	private int ix7LG3Bd9iE;

	[CompilerGenerated]
	private IStepRunner XgeLGfE3hAA;

	[CompilerGenerated]
	private int USHLGzF90jw;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static XToolboxItem NlocIlFap2ut0AxLNkFt;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return odCLGTnOko1;
		}
		[CompilerGenerated]
		set
		{
			odCLGTnOko1 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return cnfLGMHuRFR;
		}
		[CompilerGenerated]
		set
		{
			cnfLGMHuRFR = value;
		}
	}

	public string NamePinyin
	{
		[CompilerGenerated]
		get
		{
			return KltLGAwKW88;
		}
		[CompilerGenerated]
		set
		{
			KltLGAwKW88 = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return KMTLGOJbyPJ;
		}
		[CompilerGenerated]
		set
		{
			KMTLGOJbyPJ = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return w8DLGF0dETn;
		}
		[CompilerGenerated]
		set
		{
			w8DLGF0dETn = value;
		}
	}

	public string Link
	{
		[CompilerGenerated]
		get
		{
			return tbZLGUs917C;
		}
		[CompilerGenerated]
		set
		{
			tbZLGUs917C = value;
		}
	}

	public string Group
	{
		[CompilerGenerated]
		get
		{
			return p6JLGl4gGyU;
		}
		[CompilerGenerated]
		set
		{
			p6JLGl4gGyU = value;
		}
	}

	public int GroupIndex
	{
		[CompilerGenerated]
		get
		{
			return uNhLGi3pgvF;
		}
		[CompilerGenerated]
		set
		{
			uNhLGi3pgvF = value;
		}
	}

	public int UseCount
	{
		[CompilerGenerated]
		get
		{
			return ix7LG3Bd9iE;
		}
		[CompilerGenerated]
		set
		{
			ix7LG3Bd9iE = value;
		}
	}

	public IStepRunner StepRunner
	{
		[CompilerGenerated]
		get
		{
			return XgeLGfE3hAA;
		}
		[CompilerGenerated]
		set
		{
			XgeLGfE3hAA = value;
		}
	}

	public IList<int> MatchPositions
	{
		get
		{
			return rC2LGoDtRaX;
		}
		set
		{
			if (rC2LGoDtRaX != value)
			{
				rC2LGoDtRaX = value;
				OnPropertyChanged("MatchPositions");
			}
		}
	}

	public int MatchScore
	{
		[CompilerGenerated]
		get
		{
			return USHLGzF90jw;
		}
		[CompilerGenerated]
		set
		{
			USHLGzF90jw = value;
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

	internal static bool jPiMhdFaX0BYthFX55SV()
	{
		return NlocIlFap2ut0AxLNkFt == null;
	}
}
