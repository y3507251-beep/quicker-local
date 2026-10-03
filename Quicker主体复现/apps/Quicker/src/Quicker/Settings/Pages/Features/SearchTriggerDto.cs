using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Public.Searching;

namespace Quicker.Settings.Pages.Features;

public class SearchTriggerDto : INotifyPropertyChanged
{
	private string C7CdP6X17p;

	private string lfTdEwoAvW;

	private string Se3dyTMC79;

	private double gKVd86pXqq;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static SearchTriggerDto bMfLlws8c6hTIvfku1G;

	public string TriggerWord
	{
		get
		{
			return C7CdP6X17p;
		}
		set
		{
			if (!(value == C7CdP6X17p))
			{
				C7CdP6X17p = value;
				OnPropertyChanged("TriggerWord");
			}
		}
	}

	public string Condition
	{
		get
		{
			return lfTdEwoAvW;
		}
		set
		{
			if (!(value == lfTdEwoAvW))
			{
				lfTdEwoAvW = value;
				OnPropertyChanged("Condition");
			}
		}
	}

	public string Note
	{
		get
		{
			return Se3dyTMC79;
		}
		set
		{
			if (!(value == Se3dyTMC79))
			{
				Se3dyTMC79 = value;
				OnPropertyChanged("Note");
			}
		}
	}

	public double Weight
	{
		get
		{
			return gKVd86pXqq;
		}
		set
		{
			if (!value.Equals(gKVd86pXqq))
			{
				gKVd86pXqq = value;
				OnPropertyChanged("Weight");
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

	public SearchTriggerDto()
	{
		Weight = 1.0;
	}

	public SearchTriggerDto(SearchTrigger searchTrigger)
	{
		TriggerWord = searchTrigger.TriggerWord.Replace(' ', '⎵');
		Condition = searchTrigger.Condition;
		Note = searchTrigger.Note;
		Weight = searchTrigger.Weight;
	}

	public SearchTrigger ToSearchTrigger()
	{
		return new SearchTrigger
		{
			TriggerWord = TriggerWord.Replace('⎵', ' '),
			Condition = Condition,
			Note = Note,
			Weight = Weight
		};
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool WgYimusRGTyw09x540V()
	{
		return bMfLlws8c6hTIvfku1G == null;
	}
}
