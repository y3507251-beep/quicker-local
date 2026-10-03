using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Windows.Networking;
using Windows.Networking.Connectivity;
using YDnFyFwG4PlN0Cedwny;

namespace u8oQ2EwZU09ckNFKKpC;

internal class dRyrhtwRWUqEAEUvLhs : kWjRPcwItwkeAamARyg
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public ConnectionProfile n4wvIM1XsEG;

		private static _003C_003Ec__DisplayClass18_0 we62cocZbYWyMI7G5tUG;

		internal bool AdnvITEYD97(HostName hn)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Invalid comparison between Unknown and I4
			if (hn.IPInformation != null && hn.IPInformation.NetworkAdapter != null && hn.IPInformation.NetworkAdapter.NetworkAdapterId == n4wvIM1XsEG.NetworkAdapter.NetworkAdapterId)
			{
				return (int)hn.Type == 1;
			}
			return false;
		}

		internal static bool jp39bHcZqJlLimq4Nxcs()
		{
			return we62cocZbYWyMI7G5tUG == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> DN3ttmNC7nv = new Dictionary<string, string>
	{
		{ "NetworkConnected", "网络连接了" },
		{ "NetworkDisconnected", "网络断开了" }
	};

	private FormField o07ttK7g1KN = new FormField
	{
		FieldKey = "NetworkName",
		Label = "网络名",
		DictVarType = VarType.Text,
		HelpText = "可选。连接的网络名称，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = $"{TextToolType.SelectNetworkProfile}"
	};

	private FormField ASWttxWJ7LP = new FormField
	{
		FieldKey = "MinConnectivityLevel",
		Label = "最低连接级别",
		DictVarType = VarType.Text,
		InputMethod = InputMethod.DropDown,
		SelectionItems = $"1 本地(局域网)连接|{1}\r\n2 受限的Internet连接|{2}\r\n3 Internet连接|{3}",
		DefaultValue = 1
	};

	private string XZettrr7Wlc = "";

	private static dRyrhtwRWUqEAEUvLhs XbyexqQcoKKSeOX7346v;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return DN3ttmNC7nv;
	}

	public dRyrhtwRWUqEAEUvLhs()
		: base(new string[2] { "NetworkConnected", "NetworkDisconnected" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_2)
	{
		if (!(string_2 == "NetworkConnected"))
		{
			if (!(string_2 == "NetworkDisconnected"))
			{
				throw new InvalidDataException("不支持的事件类型。");
			}
			return Array.Empty<FormField>();
		}
		return new List<FormField> { o07ttK7g1KN, ASWttxWJ7LP };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_2)
	{
		if (string_2 == "NetworkConnected")
		{
			return new List<ActionVariable>
			{
				new ActionVariable
				{
					Key = "NetworkName",
					Desc = "网络名称",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "ConnectivityLevel",
					Desc = "连接级别",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "IPAddress",
					Desc = "网址",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "IsWlan",
					Desc = "是否为wifi连接",
					Type = VarType.Boolean
				},
				new ActionVariable
				{
					Key = "IsWwan",
					Desc = "是否为移动连接",
					Type = VarType.Boolean
				},
				new ActionVariable
				{
					Key = "InterfaceType",
					Desc = "IANA连接类型(网卡)",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "InBps",
					Desc = "下行带宽(bps)",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "SSID",
					Desc = "无线网络SSID",
					Type = VarType.Text
				}
			};
		}
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "NetworkName",
				Desc = "网络名称",
				Type = VarType.Text
			}
		};
	}

	protected unsafe override void fb3M2Rxtx1E()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		NetworkInformation.NetworkStatusChanged -= nLttt1dOlWv;
		NetworkInformation.NetworkStatusChanged += nLttt1dOlWv;
	}

	protected unsafe override void C5rM2eDjuIN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		NetworkInformation.NetworkStatusChanged -= nLttt1dOlWv;
	}

	private void nLttt1dOlWv(object object_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		ConnectionProfile internetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();
		if (internetConnectionProfile == null || (int)internetConnectionProfile.GetNetworkConnectivityLevel() == 0)
		{
			lT3tt6ZFvT7();
			XZettrr7Wlc = "";
			return;
		}
		OTittbGNhIg(internetConnectionProfile);
		object obj;
		if (internetConnectionProfile == null)
		{
			obj = null;
		}
		else
		{
			obj = internetConnectionProfile.ProfileName;
			if (obj != null)
			{
				goto IL_004c;
			}
		}
		obj = "";
		goto IL_004c;
		IL_004c:
		XZettrr7Wlc = (string)obj;
	}

	private void OTittbGNhIg(ConnectionProfile connectionProfile_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected I4, but got Unknown
		int num = 1;
		while (true)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			int num2 = 0;
			if (XbyexqQcoKKSeOX7346v != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			dictionary.Add("NetworkName", connectionProfile_0.ProfileName);
			dictionary.Add("IPAddress", yuBttXuS1Pk(connectionProfile_0));
			dictionary.Add("ConnectivityLevel", (int)connectionProfile_0.GetNetworkConnectivityLevel());
			dictionary.Add("IsWlan", connectionProfile_0.IsWlanConnectionProfile);
			dictionary.Add("IsWwan", connectionProfile_0.IsWwanConnectionProfile);
			dictionary.Add("InterfaceType", connectionProfile_0.NetworkAdapter.IanaInterfaceType);
			dictionary.Add("InBps", connectionProfile_0.NetworkAdapter.InboundMaxBitsPerSecond);
			if (connectionProfile_0.IsWlanConnectionProfile)
			{
				dictionary.Add("SSID", connectionProfile_0.WlanConnectionProfileDetails.GetConnectedSsid());
			}
			else
			{
				dictionary.Add("SSID", "");
			}
			int num3 = (int)connectionProfile_0.GetNetworkConnectivityLevel();
			foreach (CommonTriggerTask item in jpqtg8Grl0b)
			{
				if (!(item.EventType == "NetworkConnected"))
				{
					continue;
				}
				int num4 = item.TryGetParamValue("MinConnectivityLevel", 1);
				if (num3 >= num4)
				{
					string text = item.TryGetParamValue("NetworkName", "");
					if ((text.IsNullOrEmpty() || GFGFgbwXKocENyrCUx4.ibMflIV9C4(text, connectionProfile_0.ProfileName)) && iJ2tguv8HCS(item, dictionary) && item.SkipFurtherTasks)
					{
						break;
					}
				}
			}
			return;
		}
	}

	private void lT3tt6ZFvT7()
	{
		Dictionary<string, object> idictionary_ = new Dictionary<string, object> { 
		{
			"NetworkName",
			XZettrr7Wlc ?? ""
		} };
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.EventType == "NetworkDisconnected" && iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private static string yuBttXuS1Pk(ConnectionProfile connectionProfile_0)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.n4wvIM1XsEG = connectionProfile_0;
		if (_003C_003Ec__DisplayClass18_.n4wvIM1XsEG != null && _003C_003Ec__DisplayClass18_.n4wvIM1XsEG.NetworkAdapter != null)
		{
			HostName val = NetworkInformation.GetHostNames().Where(_003C_003Ec__DisplayClass18_.AdnvITEYD97).ToList()
				.FirstOrDefault();
			if (val != null)
			{
				return val.CanonicalName;
			}
		}
		return string.Empty;
	}

	internal static bool aG4wGhQcf2AoMdPK13bV()
	{
		return XbyexqQcoKKSeOX7346v == null;
	}
}
