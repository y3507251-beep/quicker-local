using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using Quicker.Annotations;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace XVYgmtWxau9GCu4LbWf;

internal class bs268GWtdlAMtSyu6IQ : INotifyPropertyChanged
{
	public enum KU82POuUC1eXe0CyqSN
	{

	}

	[CompilerGenerated]
	private readonly SearchResultItem G3PtNulKhbY;

	[CompilerGenerated]
	private SmartCollection<MenuItemInfo> WZjtNN3MaBX = new SmartCollection<MenuItemInfo>();

	[CompilerGenerated]
	private readonly ICommand TiPtNJ4KH93;

	[CompilerGenerated]
	private readonly ICommand jAPtN0t0N6A;

	[CompilerGenerated]
	private bool QHetNC0PLSG;

	[CompilerGenerated]
	private bool p9MtNP2pYER;

	private bool MestNEV945y;

	private int EvNtNyEM13i;

	private bool hXbtN8Qhech;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static bs268GWtdlAMtSyu6IQ N89AgkQAGpfrqylNg3IG;

	public SearchResultItem Result
	{
		[CompilerGenerated]
		get
		{
			return G3PtNulKhbY;
		}
	}

	public bool IsSelected
	{
		[CompilerGenerated]
		get
		{
			return QHetNC0PLSG;
		}
		[CompilerGenerated]
		private set
		{
			QHetNC0PLSG = value;
		}
	}

	public bool AreContextButtonsActive
	{
		get
		{
			return MestNEV945y;
		}
		set
		{
			if (MestNEV945y != value)
			{
				MestNEV945y = value;
				OnPropertyChanged("AreContextButtonsActive");
			}
		}
	}

	public int ContextMenuSelectedIndex
	{
		get
		{
			return EvNtNyEM13i;
		}
		set
		{
			if (EvNtNyEM13i != value)
			{
				EvNtNyEM13i = value;
				OnPropertyChanged("ContextMenuSelectedIndex");
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

	[SpecialName]
	[CompilerGenerated]
	public SmartCollection<MenuItemInfo> n5EtuAAaXvD()
	{
		return WZjtNN3MaBX;
	}

	[SpecialName]
	[CompilerGenerated]
	public void PCGtuOYlO4H(SmartCollection<MenuItemInfo> smartCollection_1)
	{
		WZjtNN3MaBX = smartCollection_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ICommand VdbtuU8kaGU()
	{
		return TiPtNJ4KH93;
	}

	[SpecialName]
	[CompilerGenerated]
	public ICommand smwtuiWB69e()
	{
		return jAPtN0t0N6A;
	}

	public bs268GWtdlAMtSyu6IQ(SearchResultItem searchResultItem_1)
	{
		G3PtNulKhbY = searchResultItem_1;
		TiPtNJ4KH93 = new RelayCommand(mYYtuDrkAyI);
		jAPtN0t0N6A = new RelayCommand(pAStuoKI2kT);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool HKstNwN6OVm()
	{
		return p9MtNP2pYER;
	}

	[SpecialName]
	[CompilerGenerated]
	private void hOstNt7vA6e(bool bool_4)
	{
		p9MtNP2pYER = bool_4;
	}

	private void mYYtuDrkAyI(object object_0)
	{
		pootudHkGRA((KU82POuUC1eXe0CyqSN)1);
	}

	public void pootudHkGRA(KU82POuUC1eXe0CyqSN ku82POuUC1eXe0CyqSN_0)
	{
		while (!hXbtN8Qhech)
		{
			if (!OVF5bXQA0yw83RKSemkQ())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			hXbtN8Qhech = true;
			if (Result.QueryContext.PluginItem.Plugin is IQuickButtons quickButtons)
			{
				IList<MenuItemInfo> quickButtons2 = quickButtons.GetQuickButtons(Result);
				if (quickButtons2.HasData())
				{
					n5EtuAAaXvD().Reset(quickButtons2);
				}
				break;
			}
			return;
		}
		if (n5EtuAAaXvD().Count <= 0)
		{
			AreContextButtonsActive = false;
		}
		else
		{
			AreContextButtonsActive = true;
		}
		switch (ku82POuUC1eXe0CyqSN_0)
		{
		case (KU82POuUC1eXe0CyqSN)0:
			IsSelected = true;
			break;
		case (KU82POuUC1eXe0CyqSN)1:
			hOstNt7vA6e(true);
			break;
		}
	}

	private void pAStuoKI2kT(object object_0)
	{
		dGctuTndNE2((KU82POuUC1eXe0CyqSN)1);
	}

	public void dGctuTndNE2(KU82POuUC1eXe0CyqSN ku82POuUC1eXe0CyqSN_0)
	{
		int num = 1;
		while (true)
		{
			switch (ku82POuUC1eXe0CyqSN_0)
			{
			case (KU82POuUC1eXe0CyqSN)0:
			{
				int num2 = 0;
				if (N89AgkQAGpfrqylNg3IG != null)
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				IsSelected = false;
				break;
			}
			case (KU82POuUC1eXe0CyqSN)1:
				hOstNt7vA6e(false);
				break;
			}
			break;
		}
		SmartCollection<MenuItemInfo> smartCollection = n5EtuAAaXvD();
		if (smartCollection != null && smartCollection.Count > 0)
		{
			AreContextButtonsActive = IsSelected || HKstNwN6OVm();
		}
		else
		{
			AreContextButtonsActive = false;
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool OVF5bXQA0yw83RKSemkQ()
	{
		return N89AgkQAGpfrqylNg3IG == null;
	}
}
