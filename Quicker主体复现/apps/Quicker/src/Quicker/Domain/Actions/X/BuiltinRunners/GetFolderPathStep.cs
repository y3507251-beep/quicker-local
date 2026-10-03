using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetFolderPathStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec x3uSvuj0lAP;

		public static Func<SelectionItem, string> VxRSvNV74uT;

		internal static _003C_003Ec dokVubW0x622A1wiJcsL;

		static _003C_003Ec()
		{
			x3uSvuj0lAP = new _003C_003Ec();
		}

		internal string OO6Sv25kC5o(SelectionItem x)
		{
			return x.Value;
		}

		internal static void TK1D93W0tSHZMDdp52eH()
		{
		}

		internal static bool A7PQ5dW0IkATUqTGPjOD()
		{
			return dokVubW0x622A1wiJcsL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ActionStep zaKSv0TCUPS;

		public ActionExecuteContext WBGSvCi2V6X;

		public XAction kaxSvPZLsbs;

		private static _003C_003Ec__DisplayClass38_0 eqCCFWW0SdU7cd9eihYx;

		internal (bool isSuccess, string message, ActionStopFlag failReason) jmsSvJI7Lbd()
		{
			string textParamValue = XActionHelper.GetTextParamValue(HkPgtXXDhyr, zaKSv0TCUPS, WBGSvCi2V6X);
			if (!string.IsNullOrEmpty(textParamValue))
			{
				string text = "";
				text = ((!(textParamValue == "Downloads")) ? Environment.GetFolderPath((Environment.SpecialFolder)Enum.Parse(typeof(Environment.SpecialFolder), textParamValue, true)) : KnownFolders.GetPath(KnownFolder.Downloads));
				XActionHelper.OutputResult(YeXgtKKMCjc, zaKSv0TCUPS, WBGSvCi2V6X, text, kaxSvPZLsbs);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			string item = "未指定要获取的目录路径。";
			return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
		}

		internal static bool s8DQPoW0wDlXgVBvKXCn()
		{
			return eqCCFWW0SdU7cd9eihYx == null;
		}
	}

	private static List<string> txMgtsdymKl;

	public const string Folder_Downloads = "Downloads";

	[CompilerGenerated]
	private readonly string msggtHOc30g = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> M9Igt1C3RLc;

	[CompilerGenerated]
	private readonly string dA6gtbJ62p0 = "https://getquicker.net/KC/Help/Doc/getfolderpath";

	[CompilerGenerated]
	private readonly bool QeOgt60a6pC;

	private static readonly StepInParamDef HkPgtXXDhyr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> jKXgtmuHlmy = new StepInParamDef[1] { HkPgtXXDhyr };

	private static readonly StepOutParamDef YeXgtKKMCjc;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> EncgtxJYwb6 = new StepOutParamDef[1] { YeXgtKKMCjc };

	private static GetFolderPathStep wf88cGQ845F4GYuEKOek;

	public string Key => "sys:getFolderPath";

	public string Name => "获取系统路径";

	public IEnumerable<string> KeyWords => txMgtsdymKl;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return msggtHOc30g;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return M9Igt1C3RLc;
		}
	}

	public string Description => "返回指定的特殊目录路径。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return dA6gtbJ62p0;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return QeOgt60a6pC;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return jKXgtmuHlmy;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return EncgtxJYwb6;
		}
	}

	static GetFolderPathStep()
	{
		txMgtsdymKl = new List<string> { "文件夹", "目录", "mulu", "wenjianjia", "wjj" };
		HkPgtXXDhyr = IrogtkuhVZ3();
		YeXgtKKMCjc = new StepOutParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "返回的完整路径",
			Type = VarType.Text
		};
		foreach (SelectionItem selectionItem in HkPgtXXDhyr.SelectionItems)
		{
			txMgtsdymKl.Add(selectionItem.Name);
			txMgtsdymKl.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.zaKSv0TCUPS = step;
		_003C_003Ec__DisplayClass38_.WBGSvCi2V6X = context;
		_003C_003Ec__DisplayClass38_.kaxSvPZLsbs = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass38_.WBGSvCi2V6X, _003C_003Ec__DisplayClass38_.zaKSv0TCUPS, _003C_003Ec__DisplayClass38_.kaxSvPZLsbs, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass38_.jmsSvJI7Lbd, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(HkPgtXXDhyr, step) ?? "";
	}

	private static StepInParamDef IrogtkuhVZ3()
	{
		StepInParamDef stepInParamDef = new StepInParamDef
		{
			Key = "folder",
			DefaultValue = "",
			Name = "目录类型",
			Description = "Windows的特殊目录类型，详情请搜索“Environment.SpecialFolder”。",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>()
		};
		string[] names = Enum.GetNames(typeof(Environment.SpecialFolder));
		foreach (string text in names)
		{
			stepInParamDef.SelectionItems.Add(new SelectionItem(text, k16gtGHdRhD(text)));
		}
		stepInParamDef.SelectionItems.Add(new SelectionItem("Downloads", "Downloads 下载"));
		stepInParamDef.SelectionItems = stepInParamDef.SelectionItems.OrderBy(_003C_003Ec.VxRSvNV74uT ?? (_003C_003Ec.VxRSvNV74uT = _003C_003Ec.x3uSvuj0lAP.OO6Sv25kC5o)).ToList();
		int num = 0;
		if (wf88cGQ845F4GYuEKOek != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => stepInParamDef, 
		};
	}

	private static string k16gtGHdRhD(string string_2)
	{
		string text = "";
		if (string_2 != null)
		{
			int num2 = default(int);
			while (true)
			{
				IL_01ce:
				int num;
				char c;
				switch (string_2.Length)
				{
				case 12:
					c = string_2[0];
					if (c != 'C')
					{
						goto IL_04b2;
					}
					if (!(string_2 == "CommonVideos"))
					{
						num = 27;
						if (wf88cGQ845F4GYuEKOek == null)
						{
							goto IL_0096;
						}
						goto IL_0819;
					}
					text = "";
					break;
				case 6:
					c = string_2[2];
					if (c != 'c')
					{
						num = 23;
						if (!L6KS65Q8hcwuJn5itQ7g())
						{
							goto IL_0092;
						}
						goto IL_0096;
					}
					if (string_2 == "Recent")
					{
						text = "最近";
					}
					break;
				case 11:
					c = string_2[0];
					if (c != 'C')
					{
						if (c != 'M')
						{
							num = 24;
							if (wf88cGQ845F4GYuEKOek != null)
							{
								goto IL_0092;
							}
							goto IL_0096;
						}
						if (string_2 == "MyDocuments")
						{
							text = "我的文档";
						}
						break;
					}
					if (!(string_2 == "CommonMusic"))
					{
						break;
					}
					goto IL_049a;
				case 9:
					c = string_2[5];
					num = 0;
					if (wf88cGQ845F4GYuEKOek == null)
					{
						goto IL_0096;
					}
					goto IL_03c5;
				case 8:
					c = string_2[0];
					if (c != 'M')
					{
						if (c != 'P')
						{
							num = 6;
							if (wf88cGQ845F4GYuEKOek == null)
							{
								goto IL_0096;
							}
							goto IL_03c5;
						}
						if (string_2 == "Programs")
						{
							text = "";
						}
						break;
					}
					if (string_2 == "MyVideos")
					{
						text = "我的视频";
					}
					break;
				case 7:
					c = string_2[0];
					if ((uint)c <= 72u)
					{
						if (c == 'C')
						{
							if (!(string_2 == "Cookies"))
							{
								num = 19;
								if (wf88cGQ845F4GYuEKOek != null)
								{
									goto IL_0092;
								}
								goto IL_0096;
							}
							text = "";
							break;
						}
						switch (c)
						{
						case 'H':
							if (string_2 == "History")
							{
								text = "网络历史";
							}
							break;
						case 'D':
							if (string_2 == "Desktop")
							{
								text = CommonStrings.CommonExeInfo_Desktop_Name;
							}
							break;
						}
						break;
					}
					if (c != 'M')
					{
						if (c != 'S')
						{
							if (c != 'W')
							{
								break;
							}
							goto IL_04d9;
						}
						goto IL_04f5;
					}
					if (string_2 == "MyMusic")
					{
						text = "我的音乐";
					}
					break;
				case 5:
					if (string_2 == "Fonts")
					{
						text = "字体";
					}
					break;
				case 10:
					switch (string_2[2])
					{
					case 'm':
						if (string_2 == "AdminTools")
						{
							text = "";
						}
						break;
					case 'P':
						if (string_2 == "MyPictures")
						{
							text = "我的照片";
						}
						break;
					case 'C':
						if (string_2 == "MyComputer")
						{
							text = "我的电脑";
						}
						break;
					}
					break;
				case 13:
					switch (string_2[0])
					{
					case 'I':
						if (string_2 == "InternetCache")
						{
							text = "网络缓存";
						}
						break;
					case 'C':
						if (string_2 == "CommonStartup")
						{
							text = "通用启动";
						}
						break;
					}
					break;
				case 14:
					if (string_2 == "CommonPictures")
					{
						text = "";
					}
					break;
				case 15:
					c = string_2[6];
					if ((uint)c <= 83u)
					{
						num2 = 20;
						goto IL_061f;
					}
					if (c != 'T')
					{
						if (c != 'a')
						{
							if (c != 'm')
							{
								break;
							}
							goto IL_067f;
						}
						if (string_2 == "ApplicationData")
						{
							text = "应用数据";
						}
						break;
					}
					if (string_2 == "CommonTemplates")
					{
						text = "";
					}
					break;
				case 16:
					c = string_2[0];
					if ((uint)c <= 68u)
					{
						switch (c)
						{
						case 'D':
							if (string_2 == "DesktopDirectory")
							{
								text = "";
							}
							break;
						case 'C':
							if (string_2 == "CommonAdminTools")
							{
								text = "";
							}
							break;
						}
						break;
					}
					if (c != 'N')
					{
						if (c != 'P' || !(string_2 == "PrinterShortcuts"))
						{
							break;
						}
						goto IL_074c;
					}
					if (!(string_2 == "NetworkShortcuts"))
					{
						break;
					}
					goto IL_0768;
				case 18:
					switch (string_2[0])
					{
					case 'L':
						if (string_2 == "LocalizedResources")
						{
							text = "";
						}
						break;
					case 'C':
						if (string_2 == "CommonProgramFiles")
						{
							text = "";
						}
						break;
					}
					break;
				case 20:
					if (string_2 == "LocalApplicationData")
					{
						text = "本地应用数据";
					}
					break;
				case 21:
					c = string_2[6];
					if (c != 'A')
					{
						if (c == 'P' && string_2 == "CommonProgramFilesX86")
						{
							text = "";
						}
						break;
					}
					if (!(string_2 == "CommonApplicationData"))
					{
						break;
					}
					goto IL_0810;
				case 22:
					goto IL_0819;
					IL_0640:
					text = "通用开始菜单";
					break;
					IL_04d9:
					if (string_2 == "Windows")
					{
						text = "Windows根目录";
					}
					break;
					IL_0092:
					num = num2;
					goto IL_0096;
					IL_04f5:
					if (string_2 == "Startup")
					{
						text = "启动";
					}
					break;
					IL_04b2:
					if (c == 'P' && string_2 == "ProgramFiles")
					{
						text = "";
					}
					break;
					IL_0819:
					if (string_2 == "CommonDesktopDirectory")
					{
						text = "";
					}
					break;
					IL_04a6:
					text = "文档模版";
					break;
					IL_0096:
					while (true)
					{
						switch (num)
						{
						case 23:
							break;
						case 21:
							goto end_IL_0096;
						case 3:
							goto IL_01ce;
						default:
							goto IL_03c5;
						case 10:
							goto IL_049a;
						case 11:
							goto IL_04a6;
						case 13:
							goto IL_04b2;
						case 16:
							goto IL_04d9;
						case 18:
							goto IL_04f5;
						case 24:
							if (c == 'U' && string_2 == "UserProfile")
							{
								text = "";
							}
							goto end_IL_01da;
						case 20:
							goto IL_061f;
						case 14:
							goto IL_0640;
						case 1:
							goto IL_067f;
						case 5:
							goto IL_074c;
						case 2:
							goto IL_0768;
						case 25:
							goto IL_0810;
						case 9:
							goto IL_0819;
						case 4:
						case 6:
						case 7:
						case 8:
						case 12:
						case 15:
						case 17:
						case 19:
						case 22:
						case 26:
						case 27:
							goto end_IL_01da;
						}
						switch (c)
						{
						case 'n':
							if (string_2 == "SendTo")
							{
								text = "发送到";
								break;
							}
							goto IL_0062;
						case 's':
							if (string_2 == "System")
							{
								text = "System目录";
							}
							break;
						}
						goto end_IL_01da;
						IL_0062:
						num = 1;
						if (wf88cGQ845F4GYuEKOek == null)
						{
							goto end_IL_01da;
						}
						continue;
						end_IL_0096:
						break;
					}
					goto case 6;
					IL_0810:
					text = "";
					break;
					IL_074c:
					text = "打印机";
					break;
					IL_049a:
					text = "";
					break;
					IL_0768:
					text = "网络位置";
					break;
					IL_061f:
					if (c != 'D')
					{
						if (c != 'S' || !(string_2 == "CommonStartMenu"))
						{
							break;
						}
						goto IL_0640;
					}
					if (string_2 == "CommonDocuments")
					{
						text = "";
					}
					break;
					IL_067f:
					if (string_2 == "ProgramFilesX86")
					{
						text = "";
					}
					break;
					IL_03c5:
					if ((uint)c <= 105u)
					{
						if (c != 'M')
						{
							if (c != 'a')
							{
								if (c == 'i' && string_2 == "Favorites")
								{
									text = "收藏夹";
								}
								break;
							}
							if (!(string_2 == "Templates"))
							{
								break;
							}
							goto IL_04a6;
						}
						if (string_2 == "StartMenu")
						{
							text = "开始菜单";
						}
						break;
					}
					switch (c)
					{
					case 'r':
						if (string_2 == "Resources")
						{
							text = "";
						}
						break;
					case 'n':
						if (string_2 == "CDBurning")
						{
							text = "";
						}
						break;
					case 'm':
						if (string_2 == "SystemX86")
						{
							text = "";
						}
						break;
					}
					break;
					end_IL_01da:
					break;
				}
				break;
			}
		}
		return string_2 + (string.IsNullOrEmpty(text) ? "" : (" " + text));
	}

	internal static bool L6KS65Q8hcwuJn5itQ7g()
	{
		return wf88cGQ845F4GYuEKOek == null;
	}
}
