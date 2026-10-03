using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Common;
using Quicker.Domain.Messages;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Profiles;

public class PanelState
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public int LImvmNcL3je;

		public int YcQvmJT7tDq;

		private static _003C_003Ec__DisplayClass47_0 RWOoWRctuHRjt3aiQGW4;

		internal bool f6Lvm2pM7TA(ActionItem x)
		{
			if (x != null && x.Row == LImvmNcL3je)
			{
				return x.Col == YcQvmJT7tDq;
			}
			return false;
		}

		internal bool rvjvmuNayJJ(ActionItem x)
		{
			if (x != null && x.Row == LImvmNcL3je)
			{
				return x.Col == YcQvmJT7tDq;
			}
			return false;
		}

		internal static bool FNy9kvctoxqucT2LQZ8u()
		{
			return RWOoWRctuHRjt3aiQGW4 == null;
		}
	}

	private readonly ITinyMessengerHub kWltqGcExV0;

	[CompilerGenerated]
	private ActionProfile bNotqsOVARo;

	[CompilerGenerated]
	private IList<ActionItem> TT3tqHftQCL = new List<ActionItem>();

	[CompilerGenerated]
	private ActionProfile BY5tq1MUNa8;

	[CompilerGenerated]
	private IList<ActionItem> tXqtqbUwrWV = new List<ActionItem>();

	[CompilerGenerated]
	private bool FGktq6o8wXN;

	[CompilerGenerated]
	private int T9RtqX5Nbnv;

	[CompilerGenerated]
	private int IxFtqmS0vSv;

	[CompilerGenerated]
	private int hoktqKZ0QPt;

	[CompilerGenerated]
	private int LBltqxosiRc;

	private static readonly ILog pq2tqrJvs7D;

	private static PanelState ph5uV0QGuBtQFNkmRLZx;

	public ActionProfile CurrentGlobalProfile
	{
		[CompilerGenerated]
		get
		{
			return bNotqsOVARo;
		}
		[CompilerGenerated]
		private set
		{
			bNotqsOVARo = value;
		}
	}

	public IList<ActionItem> GlobalActions
	{
		[CompilerGenerated]
		get
		{
			return TT3tqHftQCL;
		}
		[CompilerGenerated]
		private set
		{
			TT3tqHftQCL = value;
		}
	}

	public ActionProfile CurrentContextProfile
	{
		[CompilerGenerated]
		get
		{
			return BY5tq1MUNa8;
		}
		[CompilerGenerated]
		private set
		{
			BY5tq1MUNa8 = value;
		}
	}

	public IList<ActionItem> ContextActions
	{
		[CompilerGenerated]
		get
		{
			return tXqtqbUwrWV;
		}
		[CompilerGenerated]
		private set
		{
			tXqtqbUwrWV = value;
		}
	}

	public bool LockContextPanel
	{
		[CompilerGenerated]
		get
		{
			return FGktq6o8wXN;
		}
		[CompilerGenerated]
		set
		{
			FGktq6o8wXN = value;
		}
	}

	public int GlobalProfileCount
	{
		[CompilerGenerated]
		get
		{
			return T9RtqX5Nbnv;
		}
		[CompilerGenerated]
		private set
		{
			T9RtqX5Nbnv = value;
		}
	}

	public int GlobalProfileIndex
	{
		[CompilerGenerated]
		get
		{
			return IxFtqmS0vSv;
		}
		[CompilerGenerated]
		private set
		{
			IxFtqmS0vSv = value;
		}
	}

	public int ContextProfileCount
	{
		[CompilerGenerated]
		get
		{
			return hoktqKZ0QPt;
		}
		[CompilerGenerated]
		private set
		{
			hoktqKZ0QPt = value;
		}
	}

	public int ContextProfileIndex
	{
		[CompilerGenerated]
		get
		{
			return LBltqxosiRc;
		}
		[CompilerGenerated]
		private set
		{
			LBltqxosiRc = value;
		}
	}

	public PanelState(ITinyMessengerHub hub)
	{
		kWltqGcExV0 = hub;
	}

	private bool awutqqsC201(ActionProfile actionProfile_2)
	{
		if (actionProfile_2 != null)
		{
			CurrentGlobalProfile = actionProfile_2;
			GlobalActions = actionProfile_2.ActionItems;
			AppHelper.FixActionItemPosition(GlobalActions);
			kWltqGcExV0.NotifyPanelUpdate(this, true, false);
			return true;
		}
		return false;
	}

	private bool wcLtqcnq9bl(ActionProfile actionProfile_2)
	{
		if (actionProfile_2 != null)
		{
			CurrentContextProfile = actionProfile_2;
			ContextActions = actionProfile_2.ActionItems;
			AppHelper.FixActionItemPosition(ContextActions);
			kWltqGcExV0.NotifyPanelUpdate(this, false, true);
			return true;
		}
		return false;
	}

	public bool SwitchContextProfileFromSwitcher(ActionProfile profile, int profileCount, int currentProfileIndex)
	{
		ContextProfileCount = profileCount;
		ContextProfileIndex = currentProfileIndex;
		return wcLtqcnq9bl(profile);
	}

	public bool SwitchGlobalProfileFromSwitcher(ActionProfile profile, int profileCount, int currentProfileIndex)
	{
		GlobalProfileCount = profileCount;
		GlobalProfileIndex = currentProfileIndex;
		return awutqqsC201(profile);
	}

	public void OnProfileUpdated(ActionProfile profile)
	{
		if (profile == CurrentGlobalProfile || profile == CurrentContextProfile)
		{
			kWltqGcExV0.NotifyPanelUpdate(this, profile == CurrentGlobalProfile, profile == CurrentContextProfile);
		}
	}

	public ActionProfile GetProfileByButtonIndex(int btnIndex)
	{
		if (AppHelper.IsGlobalButton(btnIndex))
		{
			return CurrentGlobalProfile;
		}
		return CurrentContextProfile;
	}

	public string GetContextProfileName()
	{
		ActionProfile currentContextProfile = CurrentContextProfile;
		object obj;
		if (currentContextProfile == null)
		{
			obj = null;
		}
		else
		{
			obj = currentContextProfile.DisplayName;
			if (obj != null)
			{
				goto IL_001b;
			}
		}
		obj = "";
		goto IL_001b;
		IL_001b:
		return (string)obj;
	}

	public ActionItem GetAction(int btnIndex)
	{
		try
		{
			_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
			(bool, int, int) buttonLocation = AppHelper.GetButtonLocation(btnIndex);
			if (WwrmQIQGotlCys47L9AX())
			{
				switch (0)
				{
				}
			}
			bool flag;
			(flag, _003C_003Ec__DisplayClass47_.LImvmNcL3je, _003C_003Ec__DisplayClass47_.YcQvmJT7tDq) = buttonLocation;
			if (AppState.DataService.Gont6sBnlpf(btnIndex))
			{
				return AppState.DataService.oiEtm1YGfcm();
			}
			if (flag)
			{
				return GlobalActions.FirstOrDefault(_003C_003Ec__DisplayClass47_.f6Lvm2pM7TA);
			}
			return ContextActions.FirstOrDefault(_003C_003Ec__DisplayClass47_.rvjvmuNayJJ);
		}
		catch (Exception ex)
		{
			pq2tqrJvs7D.Warn("获取动作失败。" + ex.Message, ex);
			AppHelper.ShowWarning("获取动作失败！请重试。");
			return null;
		}
	}

	static PanelState()
	{
		pq2tqrJvs7D = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool WwrmQIQGotlCys47L9AX()
	{
		return ph5uV0QGuBtQFNkmRLZx == null;
	}
}
