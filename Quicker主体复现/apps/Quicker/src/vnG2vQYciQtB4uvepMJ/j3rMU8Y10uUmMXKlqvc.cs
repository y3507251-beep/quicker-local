using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Annotations;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;
using xrMRsqY47xNH06m5F9X;

namespace vnG2vQYciQtB4uvepMJ;

internal class j3rMU8Y10uUmMXKlqvc : INotifyPropertyChanged
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public string QDPSUDlxmkn;

		internal static _003C_003Ec__DisplayClass33_0 ku3vHUyFbNxQPsismSjp;

		internal bool eBBSU525xTR(string x)
		{
			return string.Equals(x, QDPSUDlxmkn, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool gOfbgByFquUF4FCf2O9c()
		{
			return ku3vHUyFbNxQPsismSjp == null;
		}
	}

	private bool Qj0L6tkHcOT;

	private bool P02L6gwEcZu;

	[CompilerGenerated]
	private string pTjL6LGcCfs;

	[CompilerGenerated]
	private string RtML6v8IZpI;

	[CompilerGenerated]
	private string Ng1L6Sh0HvA;

	[CompilerGenerated]
	private string DgxL621mIUj;

	[CompilerGenerated]
	private IEnumerable<string> J3PL6uefiBO;

	[CompilerGenerated]
	private bool wCHL6N1hqMf;

	private bool LMNL6Jyt2vO = true;

	[CompilerGenerated]
	private SmartCollection<j3rMU8Y10uUmMXKlqvc> fDoL60fhApj;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static j3rMU8Y10uUmMXKlqvc TktGsUFN4SlnICgcd5sU;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return pTjL6LGcCfs;
		}
		[CompilerGenerated]
		set
		{
			pTjL6LGcCfs = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return RtML6v8IZpI;
		}
		[CompilerGenerated]
		set
		{
			RtML6v8IZpI = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return Ng1L6Sh0HvA;
		}
		[CompilerGenerated]
		set
		{
			Ng1L6Sh0HvA = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return DgxL621mIUj;
		}
		[CompilerGenerated]
		set
		{
			DgxL621mIUj = value;
		}
	}

	public bool IsNodeExpanded
	{
		get
		{
			return P02L6gwEcZu;
		}
		set
		{
			if (value != P02L6gwEcZu)
			{
				P02L6gwEcZu = value;
				OnPropertyChanged("IsNodeExpanded");
			}
		}
	}

	public bool IsMatch
	{
		get
		{
			return Qj0L6tkHcOT;
		}
		set
		{
			if (value != Qj0L6tkHcOT)
			{
				Qj0L6tkHcOT = value;
				OnPropertyChanged("IsMatch");
			}
		}
	}

	public SmartCollection<j3rMU8Y10uUmMXKlqvc> Items
	{
		[CompilerGenerated]
		get
		{
			return fDoL60fhApj;
		}
		[CompilerGenerated]
		protected set
		{
			fDoL60fhApj = value;
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
	public IEnumerable<string> UM6LbTPkwrp()
	{
		return J3PL6uefiBO;
	}

	[SpecialName]
	[CompilerGenerated]
	public void rGYLbMDN29a(IEnumerable<string> ienumerable_1)
	{
		J3PL6uefiBO = ienumerable_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool NovLbipkgIy()
	{
		return wCHL6N1hqMf;
	}

	[SpecialName]
	[CompilerGenerated]
	private void iBhLb3FOpvQ(bool bool_4)
	{
		wCHL6N1hqMf = bool_4;
	}

	public bool H0tLbB30vkB(string string_4)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.QDPSUDlxmkn = string_4;
		bool flag = false;
		if (Items.HasData())
		{
			foreach (j3rMU8Y10uUmMXKlqvc item in Items)
			{
				bool flag2 = item.H0tLbB30vkB(_003C_003Ec__DisplayClass33_.QDPSUDlxmkn);
				flag = flag || flag2;
			}
		}
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass33_.QDPSUDlxmkn))
		{
			LMNL6Jyt2vO = true;
			goto IL_00de;
		}
		int lMNL6Jyt2vO;
		if (!tkxn6HAKAgMT8gvXbyh.IsMatch(Name, _003C_003Ec__DisplayClass33_.QDPSUDlxmkn) && !string.Equals(Key, _003C_003Ec__DisplayClass33_.QDPSUDlxmkn, StringComparison.OrdinalIgnoreCase))
		{
			string text = Description;
			if (text == null || text.IndexOf(_003C_003Ec__DisplayClass33_.QDPSUDlxmkn, StringComparison.OrdinalIgnoreCase) < 0)
			{
				lMNL6Jyt2vO = ((UM6LbTPkwrp() != null && UM6LbTPkwrp().Any(_003C_003Ec__DisplayClass33_.eBBSU525xTR)) ? 1 : 0);
				goto IL_00d9;
			}
		}
		lMNL6Jyt2vO = 1;
		goto IL_00d9;
		IL_0114:
		if (flag && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass33_.QDPSUDlxmkn))
		{
			IsNodeExpanded = true;
			if (LMNL6Jyt2vO && this is FlFLPuYyXT5lnwN12if && Items.HasData())
			{
				foreach (j3rMU8Y10uUmMXKlqvc item2 in Items)
				{
					item2.IsMatch = true;
				}
			}
		}
		IsMatch = flag;
		return IsMatch;
		IL_00d9:
		LMNL6Jyt2vO = (byte)lMNL6Jyt2vO != 0;
		goto IL_00de;
		IL_0100:
		int num = (LMNL6Jyt2vO ? 1 : 0);
		goto IL_0106;
		IL_0106:
		flag = (byte)num != 0;
		int num2 = 0;
		if (!DAsZRMFNhRtJO7NUWwju())
		{
			goto IL_00f3;
		}
		goto IL_0114;
		IL_00de:
		if (!flag)
		{
			num2 = 0;
			if (TktGsUFN4SlnICgcd5sU == null)
			{
				goto IL_00f3;
			}
			goto IL_0100;
		}
		num = 1;
		goto IL_0106;
		IL_00f3:
		switch (num2)
		{
		case 1:
			goto IL_0114;
		}
		goto IL_0100;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool DAsZRMFNhRtJO7NUWwju()
	{
		return TktGsUFN4SlnICgcd5sU == null;
	}
}
