using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain.Entities;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Profiles;

public class ProfileManager
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<ActionProfile, bool> tHKvm0hYOuD;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BesvmhcIWOS;

		public static Func<ActionProfile, bool> gQFvmemtXcP;

		public static Func<ActionProfile, bool> W6ivmYHvR7v;

		public static Func<ActionProfile, bool> hQovmIn8qf5;

		public static Func<ActionProfile, bool> WEhvmWXg8nW;

		public static Func<ActionItem, bool> r61vmkCDVW8;

		public static Func<ActionProfile, bool> GEnvmGwX34w;

		public static Func<ActionProfile, bool> JUVvms52KPY;

		public static Func<ActionProfile, int> YauvmH3ZJDC;

		public static Func<ActionProfile, int> agpvm1GNRS3;

		public static Func<ActionProfile, bool> YWUvmbLa5dC;

		public static Func<ActionItem, bool> seJvm6FLwak;

		public static Func<ActionProfile, bool> dc5vmXIi6MO;

		public static Func<ActionProfile, int> bCOvmm341RH;

		internal static _003C_003Ec naeh6Xctl7mofIy7gjk0;

		static _003C_003Ec()
		{
			BesvmhcIWOS = new _003C_003Ec();
		}

		internal bool LSQvmCPNM56(ActionProfile x)
		{
			return !x.IsGlobalProfile();
		}

		internal bool SaVvmPhFFoT(ActionProfile x)
		{
			return x.IsDefaultProfile();
		}

		internal bool kNlvmEEc7nE(ActionProfile p)
		{
			return IsValidForCurrentMachine(p);
		}

		internal bool M3Xvmyp8g2h(ActionProfile p)
		{
			return p != null;
		}

		internal bool GUHvm8kFJPi(ActionItem x)
		{
			return x != null;
		}

		internal bool t2ivmaw8KuU(ActionProfile x)
		{
			return x.Name == "_global";
		}

		internal bool akZvm7HTe57(ActionProfile p)
		{
			return IsProfileMatchExe(p, "quicker.exe");
		}

		internal int bNuvmRSME8M(ActionProfile x)
		{
			return x.ListOrder;
		}

		internal int IBHvmqrwTyu(ActionProfile x)
		{
			return x.ListOrder;
		}

		internal bool jLivmcuhrV6(ActionProfile x)
		{
			return x.Name == "_default";
		}

		internal bool Gd3vmVrclUl(ActionItem x)
		{
			if (x.Row == 0)
			{
				return x.Col == 0;
			}
			return false;
		}

		internal bool J4PvmZXOTPp(ActionProfile x)
		{
			return x.IsCommonProfile();
		}

		internal int JHsvm9vWBpA(ActionProfile x)
		{
			return x.ListOrder;
		}

		internal static bool ait7VyctZ27i1BKMSjPg()
		{
			return naeh6Xctl7mofIy7gjk0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public string puKvmrqrkRC;

		public IList<ActionProfile> YrZvmpOPdaE;

		private static _003C_003Ec__DisplayClass10_0 VlrFHRct8Y02jNveQeSW;

		internal bool pHYvmKdhYD6(ActionProfile p)
		{
			return IsProfileMatchExe(p, puKvmrqrkRC);
		}

		internal bool D3YvmxIAfPU(ActionProfile p)
		{
			if (!IsProfileMatchExe(p, puKvmrqrkRC))
			{
				return false;
			}
			return !YrZvmpOPdaE.Contains(p);
		}

		internal static bool G6DqU1ctRckHn5DF7kYR()
		{
			return VlrFHRct8Y02jNveQeSW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_1
	{
		public string LIovmQERlqa;

		private static _003C_003Ec__DisplayClass10_1 M3SGMactPAjn0s99tCia;

		internal bool G9GvmBCmK1n(ActionProfile p)
		{
			return p.Id != LIovmQERlqa;
		}

		internal static bool FTEifSctMR05esD6GDgw()
		{
			return M3SGMactPAjn0s99tCia == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public string oOovmnrsvTl;

		private static _003C_003Ec__DisplayClass14_0 l6iqrBctx42hRoiVRKw4;

		internal bool UeDvmjsmi23(ActionProfile f)
		{
			return f.Name == oOovmnrsvTl;
		}

		internal static bool gpaw0OctIIk9DrPny9U4()
		{
			return l6iqrBctx42hRoiVRKw4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public IList<ActionProfile> g1gvm53FYh2;

		public ProfileManager kZbvmDRINhr;

		public string vsIvmdaN9UA;

		public bool R8mvmosbkKU;

		private static _003C_003Ec__DisplayClass4_0 yjMkQ3cttlrffaCCdteg;

		internal void KLNvm441AeG()
		{
			g1gvm53FYh2 = kZbvmDRINhr.GetAllProfilesByExe(vsIvmdaN9UA, R8mvmosbkKU).Where(_003C_003Ec.hQovmIn8qf5 ?? (_003C_003Ec.hQovmIn8qf5 = _003C_003Ec.BesvmhcIWOS.kNlvmEEc7nE)).Select(kZbvmDRINhr.cV9tqpT0Lj1)
				.Where(_003C_003Ec.WEhvmWXg8nW ?? (_003C_003Ec.WEhvmWXg8nW = _003C_003Ec.BesvmhcIWOS.M3Xvmyp8g2h))
				.Distinct()
				.ToList();
		}

		internal static bool QHf7eSctSDaGq5ZLeB0n()
		{
			return yjMkQ3cttlrffaCCdteg == null;
		}
	}

	private readonly DataService qFstqjJNogM;

	private static ProfileManager Y3iwRLQGl74u88kZ0eYF;

	public ProfileManager(DataService dataService)
	{
		qFstqjJNogM = dataService;
		AppState.Jr9taHpXS6X(this);
	}

	public ICollection<ActionProfile> GetProfiles(bool includeGlobal)
	{
		if (includeGlobal)
		{
			return qFstqjJNogM.mP6tXA8VyNP().Values;
		}
		return qFstqjJNogM.mP6tXA8VyNP().Values.Where(_003C_003Ec.gQFvmemtXcP ?? (_003C_003Ec.gQFvmemtXcP = _003C_003Ec.BesvmhcIWOS.LSQvmCPNM56)).ToList();
	}

	public static bool IsValidForCurrentMachine(ActionProfile actionProfile)
	{
		if (string.IsNullOrWhiteSpace(actionProfile.Settings.ValidForMachines))
		{
			return true;
		}
		return actionProfile.Settings.ValidForMachines.ListStringContains(";", Environment.MachineName);
	}

	public IList<ActionProfile> GetValidProfilesByExe(string exeFileName, bool attachCommonProfiles)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.kZbvmDRINhr = this;
		_003C_003Ec__DisplayClass4_.vsIvmdaN9UA = exeFileName;
		_003C_003Ec__DisplayClass4_.R8mvmosbkKU = attachCommonProfiles;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass4_.vsIvmdaN9UA))
		{
			return qFstqjJNogM.mP6tXA8VyNP().Values.Where(_003C_003Ec.W6ivmYHvR7v ?? (_003C_003Ec.W6ivmYHvR7v = _003C_003Ec.BesvmhcIWOS.SaVvmPhFFoT)).ToList();
		}
		_003C_003Ec__DisplayClass4_.g1gvm53FYh2 = new List<ActionProfile>();
		DebugHelper.LogExecuteTime(_003C_003Ec__DisplayClass4_.KLNvm441AeG, "加载Profile列表");
		return _003C_003Ec__DisplayClass4_.g1gvm53FYh2;
	}

	private ActionProfile cV9tqpT0Lj1(ActionProfile actionProfile_0)
	{
		if (!string.IsNullOrEmpty(actionProfile_0.AliasOfProfile) && (actionProfile_0.ActionItems == null || !actionProfile_0.ActionItems.Any(_003C_003Ec.r61vmkCDVW8 ?? (_003C_003Ec.r61vmkCDVW8 = _003C_003Ec.BesvmhcIWOS.GUHvm8kFJPi))))
		{
			return GetProfileById(actionProfile_0.AliasOfProfile) ?? actionProfile_0;
		}
		return actionProfile_0;
	}

	public IList<ActionProfile> GetGlobalProfiles(bool filterByMachine)
	{
		if (filterByMachine)
		{
			return GetAllProfilesByExe("_global").Select(cV9tqpT0Lj1).Distinct().Where(_003C_003EO.tHKvm0hYOuD ?? (_003C_003EO.tHKvm0hYOuD = IsValidForCurrentMachine))
				.ToList();
		}
		return GetAllProfilesByExe("_global").Select(cV9tqpT0Lj1).Distinct().ToList();
	}

	private ActionProfile Lb5tqBI6PFZ()
	{
		return qFstqjJNogM.mP6tXA8VyNP().Values.FirstOrDefault(_003C_003Ec.GEnvmGwX34w ?? (_003C_003Ec.GEnvmGwX34w = _003C_003Ec.BesvmhcIWOS.t2ivmaw8KuU));
	}

	public string GetAliasedExe(string exeFileName)
	{
		if (qFstqjJNogM.yQWt6ownR4Z(exeFileName) == null)
		{
			foreach (ExeSettings value in qFstqjJNogM.TxrtXFmcoEV().Values)
			{
				IList<string> aliasExeList = value.AliasExeList;
				if (aliasExeList != null && aliasExeList.Contains(exeFileName, StringComparer.OrdinalIgnoreCase))
				{
					return value.Exe;
				}
			}
		}
		return exeFileName;
	}

	public bool HasQuickerProfile()
	{
		return qFstqjJNogM.mP6tXA8VyNP().Values.Any(_003C_003Ec.JUVvms52KPY ?? (_003C_003Ec.JUVvms52KPY = _003C_003Ec.BesvmhcIWOS.akZvm7HTe57));
	}

	public IList<ActionProfile> GetAllProfilesByExe(string exeFileName, bool attachCommonProfiles = false)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.puKvmrqrkRC = exeFileName;
		ExeSettings exeSettings = qFstqjJNogM.yQWt6ownR4Z(_003C_003Ec__DisplayClass10_.puKvmrqrkRC);
		ICollection<ActionProfile> values = qFstqjJNogM.mP6tXA8VyNP().Values;
		if (exeSettings == null)
		{
			return values.Where(_003C_003Ec__DisplayClass10_.pHYvmKdhYD6).OrderBy(_003C_003Ec.YauvmH3ZJDC ?? (_003C_003Ec.YauvmH3ZJDC = _003C_003Ec.BesvmhcIWOS.bNuvmRSME8M)).ToList();
		}
		_003C_003Ec__DisplayClass10_.YrZvmpOPdaE = new List<ActionProfile>();
		if (exeSettings.ProfileList != null)
		{
			foreach (string profile in exeSettings.ProfileList)
			{
				ActionProfile profileById = GetProfileById(profile);
				if (profileById != null && IsProfileMatchExe(profileById, _003C_003Ec__DisplayClass10_.puKvmrqrkRC))
				{
					_003C_003Ec__DisplayClass10_.YrZvmpOPdaE.Add(profileById);
				}
			}
		}
		foreach (ActionProfile item in values.Where(_003C_003Ec__DisplayClass10_.D3YvmxIAfPU).OrderBy(_003C_003Ec.agpvm1GNRS3 ?? (_003C_003Ec.agpvm1GNRS3 = _003C_003Ec.BesvmhcIWOS.IBHvmqrwTyu)).ToList())
		{
			_003C_003Ec__DisplayClass10_.YrZvmpOPdaE.Add(item);
		}
		if (attachCommonProfiles && exeSettings.AttachProfiles.HasData())
		{
			using IEnumerator<string> enumerator = exeSettings.AttachProfiles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_1();
				_003C_003Ec__DisplayClass10_2.LIovmQERlqa = enumerator.Current;
				if (_003C_003Ec__DisplayClass10_.YrZvmpOPdaE.All(_003C_003Ec__DisplayClass10_2.G9GvmBCmK1n))
				{
					ActionProfile profileById2 = GetProfileById(_003C_003Ec__DisplayClass10_2.LIovmQERlqa);
					if (profileById2 != null)
					{
						_003C_003Ec__DisplayClass10_.YrZvmpOPdaE.Add(profileById2);
					}
				}
			}
		}
		return _003C_003Ec__DisplayClass10_.YrZvmpOPdaE;
	}

	public ActionProfile GetDefaultProfile()
	{
		return qFstqjJNogM.mP6tXA8VyNP().Values.First(_003C_003Ec.YWUvmbLa5dC ?? (_003C_003Ec.YWUvmbLa5dC = _003C_003Ec.BesvmhcIWOS.jLivmcuhrV6));
	}

	public static bool IsProfileMatchExe(ActionProfile profile, string exeFile)
	{
		try
		{
			return IsFileNameEqual(profile.ExeFile, exeFile);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool IsFileNameEqual(string exe1, string exe2)
	{
		if (!string.IsNullOrEmpty(exe1) && !string.IsNullOrEmpty(exe2))
		{
			int num = exe1.LastIndexOf('\\') + 1;
			int num2 = exe2.LastIndexOf('\\') + 1;
			int num3 = exe1.Length - num;
			int num4 = exe2.Length - num2;
			if (num3 != num4)
			{
				return false;
			}
			return string.Compare(exe1, num, exe2, num2, num3, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return false;
	}

	public ActionProfile GetProfileById(string profileId)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.oOovmnrsvTl = profileId;
		ActionProfile actionProfile = null;
		if (!qFstqjJNogM.mP6tXA8VyNP().ContainsKey(_003C_003Ec__DisplayClass14_.oOovmnrsvTl))
		{
			actionProfile = qFstqjJNogM.mP6tXA8VyNP().Values.FirstOrDefault(_003C_003Ec__DisplayClass14_.UeDvmjsmi23);
			if (actionProfile == null && _003C_003Ec__DisplayClass14_.oOovmnrsvTl == "8f2ccb7a-d89e-42cf-a0bc-e632d7398042")
			{
				actionProfile = GetDefaultProfile();
				int num = 0;
				if (!cc7MRRQGZxf2Tp5g6rEF())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		else
		{
			actionProfile = qFstqjJNogM.mP6tXA8VyNP()[_003C_003Ec__DisplayClass14_.oOovmnrsvTl];
		}
		return actionProfile;
	}

	public void SaveProfile(ActionProfile profile)
	{
		if (profile != null)
		{
			bool flag = profile.ActionItems?.Where(_003C_003Ec.seJvm6FLwak ?? (_003C_003Ec.seJvm6FLwak = _003C_003Ec.BesvmhcIWOS.Gd3vmVrclUl)).Count() > 1;
			qFstqjJNogM.xHZt6K2LJ8p(profile);
		}
	}

	public ActionProfile CreateProfile(CreateProfileDto dto)
	{
		ActionProfile actionProfile = new ActionProfile
		{
			Name = dto.ProfileName,
			Id = Guid.NewGuid().ToString(),
			ProfileType = ProfileType.Application,
			ExeFile = (string.IsNullOrEmpty(dto.ExeFile) ? Path.GetFileName(dto.ExeFilePathName) : dto.ExeFile),
			ExeFullpath = dto.ExeFilePathName,
			FileVersionId = null,
			AliasOfProfile = dto.AliasOfProfileId,
			ListOrder = dto.ListOrder,
			Settings = new ProfileSettings
			{
				ValidForMachines = dto.ValidForMachines
			},
			ActionItems = new List<ActionItem>()
		};
		if (dto.CopyOrMoveActions != null)
		{
			int num = 0;
			if (!cc7MRRQGZxf2Tp5g6rEF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (dto.CopyOrMoveFromProfile == null)
			{
				throw new InvalidDataException("来源面板为空！");
			}
			if (!dto.IsMove)
			{
				actionProfile.ActionItems = JsonConvert.DeserializeObject<List<ActionItem>>(JsonConvert.SerializeObject(dto.CopyOrMoveActions));
				if (actionProfile.ActionItems != null)
				{
					foreach (ActionItem actionItem in actionProfile.ActionItems)
					{
						actionItem.Id = Guid.NewGuid().ToString();
					}
				}
			}
			else
			{
				actionProfile.ActionItems = new List<ActionItem>();
				foreach (ActionItem copyOrMoveAction in dto.CopyOrMoveActions)
				{
					actionProfile.ActionItems.Add(copyOrMoveAction);
					dto.CopyOrMoveFromProfile.ActionItems.Remove(copyOrMoveAction);
				}
				SaveProfile(dto.CopyOrMoveFromProfile);
			}
		}
		SaveProfile(actionProfile);
		return actionProfile;
	}

	public bool CanDeleteProfile(ActionProfile profile)
	{
		if (!profile.IsDefaultProfile() && !profile.IsDefaultGlobalProfile())
		{
			foreach (ActionProfile value in qFstqjJNogM.mP6tXA8VyNP().Values)
			{
				if (string.Equals(profile.Id, value.AliasOfProfile, StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	public bool RemoveProfile(ActionProfile profile)
	{
		if (!CanDeleteProfile(profile))
		{
			return false;
		}
		qFstqjJNogM.hC1t6xmuLdZ(profile);
		return true;
	}

	public bool IsActionExists(string id)
	{
		foreach (ActionProfile value in qFstqjJNogM.mP6tXA8VyNP().Values)
		{
			if (NJ4tqQPZQMy(value.ActionItems, id))
			{
				return true;
			}
		}
		return false;
	}

	private static bool NJ4tqQPZQMy(ICollection<ActionItem> icollection_0, string string_0)
	{
		if (icollection_0 == null)
		{
			return false;
		}
		foreach (ActionItem item in icollection_0)
		{
			if (!string.Equals(item.Id, string_0, StringComparison.OrdinalIgnoreCase))
			{
				if (item.Children != null && item.Children.Count > 0 && NJ4tqQPZQMy(item.Children, string_0))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	public IList<ActionProfile> GetCommonProfiles()
	{
		return qFstqjJNogM.mP6tXA8VyNP().Values.Where(_003C_003Ec.dc5vmXIi6MO ?? (_003C_003Ec.dc5vmXIi6MO = _003C_003Ec.BesvmhcIWOS.J4PvmZXOTPp)).OrderBy(_003C_003Ec.bCOvmm341RH ?? (_003C_003Ec.bCOvmm341RH = _003C_003Ec.BesvmhcIWOS.JHsvm9vWBpA)).ToList();
	}

	internal static bool cc7MRRQGZxf2Tp5g6rEF()
	{
		return Y3iwRLQGl74u88kZ0eYF == null;
	}
}
