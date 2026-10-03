using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using GEs2Jejr6IXgOTY0tM8;
using log4net;
using NamedPipeWrapper;
using Quicker.Common;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Profiles;

public class ProfileSwitcher
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public ActionProfile UB9vmtbKH2H;

		private static _003C_003Ec__DisplayClass28_0 o3ZAnnctv76J24oCVdeG;

		internal bool mJyvmwjkORk(ActionProfile x)
		{
			return x.Id == UB9vmtbKH2H.Id;
		}

		internal static bool sOjqcmctdBTheXyDNLYT()
		{
			return o3ZAnnctv76J24oCVdeG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_1
	{
		public string lN2vmLynhMw;

		private static _003C_003Ec__DisplayClass28_1 AFb8bTctkxkUcYtAHOpG;

		internal bool NYuvmgyfSqj(ActionProfile x)
		{
			return x.Id == lN2vmLynhMw;
		}

		internal static bool iHOasDctaXGmmcOXGK7V()
		{
			return AFb8bTctkxkUcYtAHOpG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass43_0
	{
		public string WUHvmSOKk5V;

		private static _003C_003Ec__DisplayClass43_0 qcTjaHctN6CMq7I6923k;

		internal bool V4vvmvuUVlI(ActionProfile x)
		{
			return x.Id == WUHvmSOKk5V;
		}

		internal static bool REuycYct9H3pKuvw9gIN()
		{
			return qcTjaHctN6CMq7I6923k == null;
		}
	}

	private static readonly ILog Kg6tquHjJFY;

	private readonly ProfileManager LE8tqNcPBOn;

	private readonly PanelState bfDtqJ3xIjZ;

	private readonly DataService l9Dtq0kZ7wl;

	private readonly IDictionary<string, string> HdOtqCNcI8c = new ConcurrentDictionary<string, string>();

	[CompilerGenerated]
	private string tqWtqPRnteX;

	private IList<ActionProfile> V28tqELSNS2 = new List<ActionProfile>();

	private ActionProfile JtUtqy97nho;

	private IList<ActionProfile> DSotq8utwFW = new List<ActionProfile>();

	private ActionProfile UehtqaPvfcZ;

	[CompilerGenerated]
	private string Gmdtq7MiSkq;

	private long qqstqR12U32;

	private static ProfileSwitcher XWuo6rQGvJ36PbAHQ18I;

	public string CurrentExe
	{
		[CompilerGenerated]
		get
		{
			return tqWtqPRnteX;
		}
		[CompilerGenerated]
		set
		{
			tqWtqPRnteX = value;
		}
	}

	public ActionProfile CurrentContextProfile => JtUtqy97nho;

	public IList<ActionProfile> AllGlobalProfiles => DSotq8utwFW ?? new List<ActionProfile>();

	public IList<ActionProfile> AllContextProfiles => V28tqELSNS2 ?? new List<ActionProfile>();

	public string RealExe
	{
		[CompilerGenerated]
		get
		{
			return Gmdtq7MiSkq;
		}
		[CompilerGenerated]
		private set
		{
			Gmdtq7MiSkq = value;
		}
	}

	public ProfileSwitcher(ProfileManager profileManager, PanelState panelState, ITinyMessengerHub hub, DataService dataService)
	{
		LE8tqNcPBOn = profileManager;
		bfDtqJ3xIjZ = panelState;
		l9Dtq0kZ7wl = dataService;
		hub.Subscribe<RequestChangePageMessage>(swctqtxOhD1);
	}

	private void swctqtxOhD1(RequestChangePageMessage requestChangePageMessage_0)
	{
		if (requestChangePageMessage_0.IsGlobal)
		{
			if (requestChangePageMessage_0.GoLeft)
			{
				GlobalGoLeft();
			}
			else
			{
				GlobalGoRight();
			}
		}
		else if (requestChangePageMessage_0.GoLeft)
		{
			GoLeft();
		}
		else
		{
			GoRight();
		}
	}

	public string GetExeLastProfileId(string exe)
	{
		if (HdOtqCNcI8c.ContainsKey(exe))
		{
			return HdOtqCNcI8c[exe];
		}
		return null;
	}

	public void UpdateExeLastProfile(string exe, string profileId)
	{
		HdOtqCNcI8c[exe] = profileId;
	}

	public void StartUp()
	{
		LoadGlobalProfiles();
		ChangeExe("");
	}

	public bool ChangeExe(string exe, bool refresh = false, string currentUrl = null)
	{
		int num = 5;
		ActionProfile actionProfile = default(ActionProfile);
		int num3 = default(int);
		while (exe != null)
		{
			exe = ((!exe.EndsWith(".exe") || exe.IndexOfAny(new char[2] { '\\', '/' }) <= -1) ? exe.ToLowerInvariant() : Path.GetFileName(exe).ToLowerInvariant());
			exe = LE8tqNcPBOn.GetAliasedExe(exe);
			IList<ActionProfile> list = null;
			if (string.Equals(exe, CurrentExe, StringComparison.OrdinalIgnoreCase))
			{
				if (!refresh)
				{
					return false;
				}
				list = V28tqELSNS2.ToList();
			}
			CurrentExe = exe;
			if (exe != "common")
			{
				RealExe = exe;
			}
			IList<ActionProfile> validProfilesByExe = LE8tqNcPBOn.GetValidProfilesByExe(exe, true);
			int num2 = 2;
			if (!k6O540QGdT0WZSR3VcgK())
			{
				goto IL_0140;
			}
			goto IL_0287;
			IL_0287:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 2:
					goto IL_0149;
				default:
					goto IL_025f;
				case 5:
					goto end_IL_0287;
				case 1:
					goto IL_02f9;
				case 4:
					goto end_IL_02a6;
				}
				goto IL_00bd;
				IL_025f:
				if (actionProfile != null)
				{
					num3 = V28tqELSNS2.IndexOf(actionProfile);
					num2 = 1;
					if (k6O540QGdT0WZSR3VcgK())
					{
						continue;
					}
					goto IL_0140;
				}
				goto IL_02f9;
				IL_00bd:
				if (validProfilesByExe.Count == 0)
				{
					goto IL_02b3;
				}
				num3 = 0;
				ExeSettings exeSettings = l9Dtq0kZ7wl.yQWt6ownR4Z(exe);
				if (exeSettings == null || !exeSettings.ReturnToFirstPage)
				{
					_003C_003Ec__DisplayClass28_1 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_1();
					_003C_003Ec__DisplayClass28_.lN2vmLynhMw = GetExeLastProfileId(CurrentExe);
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass28_.lN2vmLynhMw))
					{
						actionProfile = V28tqELSNS2.FirstOrDefault(_003C_003Ec__DisplayClass28_.NYuvmgyfSqj);
						num2 = 0;
						if (k6O540QGdT0WZSR3VcgK())
						{
							continue;
						}
						goto IL_0140;
					}
				}
				goto IL_02f9;
				IL_0149:
				if (list != null)
				{
					using IEnumerator<ActionProfile> enumerator = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_2 = new _003C_003Ec__DisplayClass28_0();
						_003C_003Ec__DisplayClass28_2.UB9vmtbKH2H = enumerator.Current;
						if (!validProfilesByExe.Any(_003C_003Ec__DisplayClass28_2.mJyvmwjkORk) && !_003C_003Ec__DisplayClass28_2.UB9vmtbKH2H.ExeFile.StartsWith("@_"))
						{
							validProfilesByExe.Add(_003C_003Ec__DisplayClass28_2.UB9vmtbKH2H);
						}
					}
				}
				V28tqELSNS2 = validProfilesByExe.ToList();
				if (!string.IsNullOrEmpty(currentUrl))
				{
					Tvotqgp4ymN(currentUrl);
				}
				else
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(exe);
					WsnAlhjCfHjoVZXu241 wsnAlhjCfHjoVZXu = AppState.vjAt7Seco0Y();
					if (wsnAlhjCfHjoVZXu != null && wsnAlhjCfHjoVZXu.m8ItGmyxjPV(AppState.CurrentProcessName))
					{
						int browserMainProcess = ProcessHelper.GetBrowserMainProcess(AppState.CurrentProcessId, AppState.CurrentProcessName);
						NamedPipeConnection<string, string> namedPipeConnection = AppState.vjAt7Seco0Y().fFCtGxElp5Z(fileNameWithoutExtension, browserMainProcess);
						if (namedPipeConnection != null && namedPipeConnection.Tag is BrowserConnectionInfo { ActiveTabUrl: { } activeTabUrl })
						{
							Tvotqgp4ymN(activeTabUrl);
						}
					}
				}
				goto IL_00bd;
				continue;
				end_IL_0287:
				break;
			}
			continue;
			IL_0324:
			return true;
			IL_02b3:
			if (!string.Equals(exe, "et.exe", StringComparison.OrdinalIgnoreCase) && !string.Equals(exe, "wpp.exe", StringComparison.OrdinalIgnoreCase))
			{
				if (!string.Equals(exe, "common", StringComparison.OrdinalIgnoreCase))
				{
					return ChangeExe("common", refresh);
				}
				goto IL_0324;
			}
			return ChangeExe("wps.exe");
			IL_02f9:
			if (num3 < V28tqELSNS2.Count)
			{
				hHotqLM9SkL(V28tqELSNS2[num3], validProfilesByExe.Count, num3);
				goto IL_0324;
			}
			Kg6tquHjJFY.Warn($"动作页序号{num3}超过了数量{V28tqELSNS2.Count}，exe={exe}。");
			return false;
			IL_0140:
			num2 = num;
			goto IL_0287;
			continue;
			end_IL_02a6:
			break;
		}
		return ChangeExe("");
	}

	private void Tvotqgp4ymN(string string_2)
	{
		foreach (ExeSettings item in AppState.DataService.Q0ltmmbUTMB())
		{
			if (!item.Exe.StartsWith("@_") || !WsnAlhjCfHjoVZXu241.XRmtGdDumUX(string_2, item.UrlPattern))
			{
				continue;
			}
			IList<ActionProfile> validProfilesByExe = LE8tqNcPBOn.GetValidProfilesByExe(item.Exe, false);
			int num = 0;
			int count = validProfilesByExe.Count;
			foreach (ActionProfile item2 in validProfilesByExe)
			{
				V28tqELSNS2.Insert(num++, item2);
			}
		}
	}

	private void hHotqLM9SkL(ActionProfile actionProfile_1, int int_0, int int_1)
	{
		JtUtqy97nho = actionProfile_1;
		if (!string.IsNullOrEmpty(CurrentExe))
		{
			UpdateExeLastProfile(CurrentExe, actionProfile_1.Id);
		}
		bfDtqJ3xIjZ.SwitchContextProfileFromSwitcher(actionProfile_1, int_0, int_1);
	}

	public void LoadGlobalProfiles()
	{
		ActionProfile uehtqaPvfcZ = UehtqaPvfcZ;
		DSotq8utwFW = LE8tqNcPBOn.GetGlobalProfiles(true);
		int num = 0;
		if (!k6O540QGdT0WZSR3VcgK())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!DSotq8utwFW.HasData())
		{
			Kg6tquHjJFY.Warn("配置错误！没有可用的全局动作页，尝试加载所有全局动作页...");
			AppHelper.ShowWarning("配置错误！没有可用的全局动作页，尝试加载所有全局动作页...");
			DSotq8utwFW = LE8tqNcPBOn.GetGlobalProfiles(false);
			if (!DSotq8utwFW.HasData())
			{
				Kg6tquHjJFY.Error("配置错误！没有可用的全局动作页。");
				AppHelper.ShowError("配置错误！没有可用的全局动作页。");
				return;
			}
		}
		if (DSotq8utwFW.Contains(uehtqaPvfcZ))
		{
			hMytqvd53by(uehtqaPvfcZ);
		}
		else
		{
			hMytqvd53by(DSotq8utwFW[0]);
		}
	}

	private void hMytqvd53by(ActionProfile actionProfile_1)
	{
		actionProfile_1.IsGlobalProfile();
		UehtqaPvfcZ = actionProfile_1;
		bfDtqJ3xIjZ.SwitchGlobalProfileFromSwitcher(actionProfile_1, DSotq8utwFW.Count, DSotq8utwFW.IndexOf(actionProfile_1));
	}

	public void RequestSwitchProfile(string profileId, bool isEditing)
	{
		ActionProfile profileById = LE8tqNcPBOn.GetProfileById(profileId);
		if (profileById == null)
		{
			AppHelper.ShowWarning("动作页 " + profileId + " 不存在。");
			return;
		}
		if (profileById.IsGlobalProfile())
		{
			hMytqvd53by(profileById);
			return;
		}
		if (isEditing)
		{
			V28tqELSNS2 = new List<ActionProfile>();
			CurrentExe = "";
		}
		else if (V28tqELSNS2.Count > 0 && !V28tqELSNS2.Contains(profileById))
		{
			V28tqELSNS2.Add(profileById);
		}
		if (!isEditing && V28tqELSNS2.Count > 0)
		{
			int num = 0;
			if (XWuo6rQGvJ36PbAHQ18I != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			hHotqLM9SkL(profileById, V28tqELSNS2.Count, V28tqELSNS2.IndexOf(profileById));
		}
		else
		{
			hHotqLM9SkL(profileById, 0, 0);
		}
	}

	public bool IsShouldShowCreateProfileButton()
	{
		if (CurrentExe == "common" && !string.IsNullOrEmpty(RealExe) && !string.Equals("unknown-proc.exe", RealExe) && !string.Equals(RealExe, "desktop", StringComparison.OrdinalIgnoreCase))
		{
			return !l9Dtq0kZ7wl.TxrtXFmcoEV().ContainsKey(RealExe);
		}
		return false;
	}

	public bool GoLeft()
	{
		if (!V28tqELSNS2.HasData())
		{
			return false;
		}
		int num = V28tqELSNS2.IndexOf(JtUtqy97nho) - 1;
		if (num < 0)
		{
			if (!l9Dtq0kZ7wl.CpItmVISR7P().EnableCyclePaging)
			{
				return false;
			}
			num = V28tqELSNS2.Count - 1;
		}
		hHotqLM9SkL(V28tqELSNS2[num], V28tqELSNS2.Count, num);
		return true;
	}

	public bool GoRight()
	{
		if (!V28tqELSNS2.HasData())
		{
			return false;
		}
		int num = V28tqELSNS2.IndexOf(JtUtqy97nho);
		int num2 = num + 1;
		if (num >= 0)
		{
			if (num2 < V28tqELSNS2.Count)
			{
				goto IL_007a;
			}
			if (!k6O540QGdT0WZSR3VcgK())
			{
				switch (0)
				{
				}
			}
		}
		if (!l9Dtq0kZ7wl.CpItmVISR7P().EnableCyclePaging)
		{
			return false;
		}
		num2 = 0;
		goto IL_007a;
		IL_007a:
		hHotqLM9SkL(V28tqELSNS2[num2], V28tqELSNS2.Count, num2);
		return true;
	}

	public bool ContextGoToPage(int pageIndex)
	{
		if (pageIndex >= 0 && pageIndex < V28tqELSNS2.Count)
		{
			hHotqLM9SkL(V28tqELSNS2[pageIndex], V28tqELSNS2.Count, pageIndex);
			return true;
		}
		return false;
	}

	public bool GlobalGoLeft()
	{
		if (!DSotq8utwFW.HasData())
		{
			return false;
		}
		int num = DSotq8utwFW.IndexOf(UehtqaPvfcZ) - 1;
		if (num < 0)
		{
			if (!l9Dtq0kZ7wl.CpItmVISR7P().EnableCyclePaging)
			{
				return false;
			}
			num = DSotq8utwFW.Count - 1;
		}
		hMytqvd53by(DSotq8utwFW[num]);
		return true;
	}

	public bool GlobalGoToPage(int pageIndex, bool refresh = true)
	{
		if (DSotq8utwFW.Count > pageIndex)
		{
			if (refresh || DSotq8utwFW[pageIndex] != UehtqaPvfcZ)
			{
				hMytqvd53by(DSotq8utwFW[pageIndex]);
			}
			return true;
		}
		return false;
	}

	public bool GlobalGoRight()
	{
		if (DSotq8utwFW.HasData())
		{
			int num = DSotq8utwFW.IndexOf(UehtqaPvfcZ) + 1;
			if (num < 0 || num > DSotq8utwFW.Count - 1)
			{
				if (!l9Dtq0kZ7wl.CpItmVISR7P().EnableCyclePaging)
				{
					return false;
				}
				num = 0;
				int num2 = 0;
				if (XWuo6rQGvJ36PbAHQ18I != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			hMytqvd53by(DSotq8utwFW[num]);
			return true;
		}
		return false;
	}

	public void OnSyncComplete()
	{
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
		_003C_003Ec__DisplayClass43_.WUHvmSOKk5V = UehtqaPvfcZ?.Id;
		LoadGlobalProfiles();
		ActionProfile actionProfile = DSotq8utwFW.FirstOrDefault(_003C_003Ec__DisplayClass43_.V4vvmvuUVlI);
		if (actionProfile != null)
		{
			hMytqvd53by(actionProfile);
		}
		ChangeExe(CurrentExe);
	}

	public void ReloadProfilesIfNeeded(string exeSettingsExe)
	{
		if (exeSettingsExe == "_global")
		{
			LoadGlobalProfiles();
		}
		else if (CurrentExe == exeSettingsExe)
		{
			ChangeExe(exeSettingsExe, true);
		}
	}

	public void ReloadAll()
	{
		LoadGlobalProfiles();
		ChangeExe(CurrentExe, true);
	}

	public void ReloadOnUrlChange(string browserProcessName, string url)
	{
		if (string.Equals(browserProcessName, AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase))
		{
			ChangeExe(CurrentExe, true, url);
		}
	}

	static ProfileSwitcher()
	{
		Kg6tquHjJFY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool k6O540QGdT0WZSR3VcgK()
	{
		return XWuo6rQGvJ36PbAHQ18I == null;
	}
}
