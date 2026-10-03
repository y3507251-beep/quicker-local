using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ko4fe7AdlIHVfm4LNc6;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Images;

namespace Jp6YuAAO2nOBQFwcNUf;

internal static class UQpehvAn0sgnYNEpfrQ
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec gO6vY0jBioP;

		public static Func<string, bool> YlgvYCIK9I9;

		public static Func<KeyValuePair<string, object>, string> hD2vYPSlgaG;

		public static Func<KeyValuePair<string, object>, object> uPavYEXxNr7;

		private static _003C_003Ec trwQu0cixoQsD5wXDYMN;

		static _003C_003Ec()
		{
			gO6vY0jBioP = new _003C_003Ec();
		}

		internal bool bwkvYu1ZDOB(string x)
		{
			return !File.Exists(x);
		}

		internal string uVbvYNDg4sC(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object IEjvYJCe8Y7(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal static bool asfM1wciIPjYyBV59QVT()
		{
			return trwQu0cixoQsD5wXDYMN == null;
		}
	}

	private static object j0L3NkQVIgg3IVO0AeAF;

	public static bool Execute(CommonOperationItem item, ActionExecuteContext context)
	{
		int num = 5;
		string text2 = default(string);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		char c = default(char);
		string text3 = default(string);
		while (true)
		{
			string text = item.Operation.ToLower();
			num = 4;
			while (true)
			{
				int num2;
				if (text != null)
				{
					switch (text.Length)
					{
					case 2:
						break;
					case 6:
						goto IL_00c3;
					case 9:
						goto IL_0101;
					case 10:
						goto IL_013f;
					case 3:
						if (text == "run")
						{
							AppHelper.ExecuteText(item.Data);
							return true;
						}
						goto IL_0642;
					case 4:
						goto IL_0228;
					case 5:
						goto IL_0237;
					case 8:
						if (text == "sendkeys")
						{
							SendKeys.SendWait(item.Data);
							return true;
						}
						goto IL_0642;
					case 11:
						if (text == "inputscript")
						{
							if (item.Data != null)
							{
								if (item.Data.Contains('\n'))
								{
									D3mwCbAmx8tANGphaEi.ExecuteScript(item.Data);
								}
								else
								{
									D3mwCbAmx8tANGphaEi.ExecuteScript(item.Data.Replace(";;", "\r\n"));
								}
							}
							return true;
						}
						goto IL_0642;
					default:
						goto IL_0642;
					}
					if (text == "sp")
					{
						if (context != null)
						{
							text2 = item.SpName;
							if (string.IsNullOrEmpty(text2))
							{
								if (item.ExtraData == null || !item.ExtraData.ContainsKey("spname"))
								{
									AppHelper.ShowWarning("未指定要执行的子程序名称。");
									return false;
								}
								text2 = item.ExtraData["spname"].ToString();
								num2 = 0;
								if (j0L3NkQVIgg3IVO0AeAF == null)
								{
									goto IL_018f;
								}
							}
							goto IL_0306;
						}
						AppHelper.ShowWarning("没有动作上下文时，不能执行子程序。");
						return false;
					}
				}
				goto IL_0642;
				IL_0306:
				dictionary = ((item.ExtraData == null) ? new Dictionary<string, object>() : item.ExtraData.ToDictionary(_003C_003Ec.hD2vYPSlgaG ?? (_003C_003Ec.hD2vYPSlgaG = _003C_003Ec.gO6vY0jBioP.uVbvYNDg4sC), _003C_003Ec.uPavYEXxNr7 ?? (_003C_003Ec.uPavYEXxNr7 = _003C_003Ec.gO6vY0jBioP.IEjvYJCe8Y7)));
				if (!dictionary.ContainsKey("data"))
				{
					goto IL_04d2;
				}
				goto IL_04e4;
				IL_0237:
				c = text[0];
				if (c != 'i')
				{
					if (c == 'p' && text == "paste")
					{
						if (!string.IsNullOrEmpty(item.Data))
						{
							ActionHelper.SendTextToWindow(item.Data, true, false, 50, 50);
						}
						return true;
					}
				}
				else if (text == "input")
				{
					goto IL_02e0;
				}
				goto IL_0642;
				IL_02e0:
				ActionHelper.SendTextToWindow(item.Data, false, false, 0, 0);
				return true;
				IL_018b:
				num2 = num;
				goto IL_018f;
				IL_041c:
				switch (c)
				{
				case 'o':
					if (text == "open")
					{
						AppHelper.TryOpenUrlOrFile(item.Data);
						return true;
					}
					break;
				case 'n':
					if (text == "none")
					{
						return true;
					}
					break;
				case 'c':
					if (text == "copy")
					{
						if (string.IsNullOrEmpty(item.Data))
						{
							ClipboardHelper.Clear();
						}
						else
						{
							ClipboardHelper.SetText(item.Data);
						}
						return true;
					}
					break;
				}
				goto IL_0642;
				IL_05ef:
				return true;
				IL_018f:
				switch (num2)
				{
				case 4:
					break;
				case 5:
					goto end_IL_01c5;
				default:
					goto IL_0306;
				case 1:
					try
					{
						string[] array = item.Data.Split(new string[4] { "\r\n", "\r", "\n", ";" }, StringSplitOptions.RemoveEmptyEntries);
						if (!array.HasData() || array.Any(_003C_003Ec.YlgvYCIK9I9 ?? (_003C_003Ec.YlgvYCIK9I9 = _003C_003Ec.gO6vY0jBioP.bwkvYu1ZDOB)))
						{
							AppHelper.ShowWarning("要粘贴的文件为空或不存在");
							return false;
						}
						ClipboardHelper.SetFile(array);
						AppHelper.SendPasteKeys();
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("粘贴文件出错：" + ex.Message);
					}
					return true;
				case 3:
					goto IL_041c;
				case 6:
					goto IL_04a1;
				case 8:
					goto IL_04d2;
				case 10:
					goto IL_0562;
				case 2:
					goto IL_057d;
				case 9:
					goto IL_05ef;
				case 7:
					goto IL_0642;
				}
				continue;
				IL_00c3:
				if (text == "action")
				{
					text3 = item.Action;
					if (!(text3 == "_this_"))
					{
						goto IL_04ac;
					}
					num2 = 6;
					if (j0L3NkQVIgg3IVO0AeAF == null)
					{
						goto IL_018f;
					}
					goto IL_057d;
				}
				goto IL_0642;
				IL_0228:
				c = text[0];
				goto IL_041c;
				IL_013f:
				c = text[0];
				if (c != 'p')
				{
					if (c == 's' && text == "selectfile")
					{
						if (!File.Exists(item.Data))
						{
							num2 = 10;
							if (j0L3NkQVIgg3IVO0AeAF != null)
							{
								goto IL_018b;
							}
							goto IL_018f;
						}
						goto IL_0571;
					}
				}
				else if (text == "pasteimage")
				{
					try
					{
						string text4 = item.Data.Trim();
						if (text4.IsNullOrWhiteSpace() || !File.Exists(text4))
						{
							AppHelper.ShowWarning("要粘贴的图片路径不存在。");
							return false;
						}
						ClipboardHelper.SetImage(ImageHelper.ReadImageFromFileWithoutLock(text4));
						AppHelper.SendPasteKeys();
					}
					catch (Exception ex2)
					{
						AppHelper.ShowWarning("粘贴文件出错：" + ex2.Message);
					}
					goto IL_05ef;
				}
				goto IL_0642;
				IL_0562:
				if (!Directory.Exists(item.Data))
				{
					return false;
				}
				goto IL_0571;
				IL_0571:
				AppHelper.SelectFileInExplorer(item.Data, false);
				goto IL_057d;
				IL_057d:
				return true;
				IL_04a1:
				if (context != null)
				{
					text3 = context.ActionId;
				}
				goto IL_04ac;
				IL_04d2:
				dictionary["data"] = item.Data;
				goto IL_04e4;
				IL_0642:
				AppHelper.ShowWarning("不支持的操作类型：" + item.Operation + "\r\n可能您使用的Quicker版本过旧。");
				return false;
				IL_0101:
				c = text[0];
				if (c != 'i')
				{
					if (c == 'p' && text == "pastefile")
					{
						num2 = 1;
						if (j0L3NkQVIgg3IVO0AeAF != null)
						{
							goto IL_018b;
						}
						goto IL_018f;
					}
				}
				else if (text == "inputtext")
				{
					goto IL_02e0;
				}
				goto IL_0642;
				IL_04ac:
				AppState.AppServer.ExecuteActionByIdOrName(text3, null, false, false, true, item.Data, ActionTrigger.Extern);
				return true;
				IL_04e4:
				if (!dictionary.ContainsKey("spname"))
				{
					dictionary["spname"] = text2;
				}
				try
				{
					SubProgramHelper.RunStandaloneSubprogram(text2, dictionary, context, context.ParentWindow, true, true).GetAwaiter().GetResult();
				}
				catch (Exception ex3)
				{
					AppHelper.ShowWarning("执行子程序" + text2 + "出错：" + ex3.Message + "。");
				}
				return true;
				continue;
				end_IL_01c5:
				break;
			}
		}
	}

	internal static bool m2dewKQV64yrEBDYP6sW()
	{
		return j0L3NkQVIgg3IVO0AeAF == null;
	}
}
