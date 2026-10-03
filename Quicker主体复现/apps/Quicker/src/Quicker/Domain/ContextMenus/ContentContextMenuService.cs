using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using f9a0PHoGPpwjuPg0HoF;
using gNDpGkYZYbhLdMnAyKv;
using jtYKvI2ve9aDjyxS5gf;
using log4net;
using Newtonsoft.Json;
using ntFLI7iwvZZfgRBvVis;
using qIOAiL5tHSq0oBCxwHP;
using QRCoder;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.Actions.X.BuiltinRunners.Text;
using Quicker.Domain.Services;
using Quicker.Modules.OCR;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;
using tQy5b4MZR11HLf8vRkW;

namespace Quicker.Domain.ContextMenus;

public static class ContentContextMenuService
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec g4dvxcl9vXW;

		public static Func<IList<string>, string> PWcvxVC45HR;

		public static Func<string, string> MfPvxZZE7ZA;

		public static Func<IList<string>, string> qOwvx9OhcpO;

		public static Func<string, string> RAkvxhv3H6K;

		public static Func<IList<string>, string> hm2vxeqPdAm;

		public static Func<string, string> nCovxYgQP3G;

		public static Func<IList<string>, string> C9CvxI0PQEG;

		public static Func<IList<string>, string> vRlvxWaWpxA;

		public static Func<IList<string>, string> OSwvxky5mpo;

		public static Func<IList<string>, string> qANvxG6HV90;

		public static Func<IList<string>, string> osIvxsaGwO7;

		public static RoutedEventHandler z48vxHHtlCi;

		public static Action LEjvx10Y4II;

		public static RoutedEventHandler i7Zvxbx98j9;

		public static Func<string, string> tRMvx6JYqG8;

		public static Func<string, string> xhqvxXI7pA7;

		public static Func<string, string> RJ2vxmWdQ7u;

		public static Func<string, string> lhFvxKqJyuo;

		public static Func<string, string> NkgvxxTOBCc;

		public static Func<string, string> SUUvxrYGQSw;

		public static Func<string, string> UpnvxptZQGk;

		public static MatchEvaluator gWnvxBnMWhY;

		public static Func<string, string> SqkvxQovVXl;

		public static Func<string, string> FsMvxjsOUeE;

		public static Func<string, string> yZOvxnVRdof;

		public static Func<string, string> OK3vx4o9mnV;

		public static Func<string, string> BWTvx5KKipb;

		public static RoutedEventHandler SEcvxDkwMc3;

		internal static _003C_003Ec YZeTPTcSYIj48lxFpN9r;

		static _003C_003Ec()
		{
			g4dvxcl9vXW = new _003C_003Ec();
		}

		internal string E1YvKOfSGT7(IList<string> fileList)
		{
			return string.Join("\r\n", fileList);
		}

		internal string E7BvKFAVgGD(IList<string> fileList)
		{
			return string.Join("\r\n", fileList.Select(MfPvxZZE7ZA ?? (MfPvxZZE7ZA = g4dvxcl9vXW.DggvKUbZn6a)));
		}

		internal string DggvKUbZn6a(string x)
		{
			return "\"" + x + "\"";
		}

		internal string dX6vKlwdDlv(IList<string> fileList)
		{
			return string.Join("\r\n", fileList.Select(RAkvxhv3H6K ?? (RAkvxhv3H6K = g4dvxcl9vXW.qebvKiINYX8)));
		}

		internal string qebvKiINYX8(string x)
		{
			return Path.GetFileName(x);
		}

		internal string i72vK3EFj9D(IList<string> fileList)
		{
			return string.Join("\r\n", fileList.Select(nCovxYgQP3G ?? (nCovxYgQP3G = g4dvxcl9vXW.flpvKfFLw1V)));
		}

		internal string flpvKfFLw1V(string x)
		{
			return Path.GetFileNameWithoutExtension(x);
		}

		internal string k5PvKzBXfSu(IList<string> fileList)
		{
			return Path.GetDirectoryName(fileList.First());
		}

		internal string N9WvxwXSQi9(IList<string> fileList)
		{
			string directoryName = Path.GetDirectoryName(fileList.First());
			string string_ = Path.Combine(directoryName, DateTime.Now.ToString("yyyyMMddHHmmss"));
			if (fileList.Count == 1)
			{
				string text = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(fileList[0]));
				if (!File.Exists(text) && !Directory.Exists(text))
				{
					string_ = text;
				}
			}
			eYYte0XBawu(fileList, string_);
			return "";
		}

		internal string O04vxttwD2w(IList<string> fileList)
		{
			UserInputWindow userInputWindow = new UserInputWindow("text", "请输入文件夹名称", "", "新建文件夹");
			if (userInputWindow.ShowDialog() == true)
			{
				string textValue = userInputWindow.TextValue;
				string string_ = Path.Combine(Path.GetDirectoryName(fileList.First()), textValue);
				eYYte0XBawu(fileList, string_);
			}
			return string.Empty;
		}

		internal string xcGvxgtIykv(IList<string> fileList)
		{
			(bool, string) tuple = AppHelper.ShowSelectFolderDialog("", "选择要移动到的文件夹");
			if (tuple.Item1)
			{
				Path.GetDirectoryName(fileList.First());
				string item = tuple.Item2;
				eYYte0XBawu(fileList, item);
			}
			return string.Empty;
		}

		internal void nsZvxLrN8DR(object sender, RoutedEventArgs e)
		{
			AppWindowManager.ShowSettingsWindow(SettingPageId.FileContextMenuSettings);
		}

		internal void K0wvxvhwFU7()
		{
			try
			{
        string textToProcess = default;
        ItemCollection itemCollection = default;
				bool flag = kWsP1bYRVsfaicfjr67.UcRL59pCHNZ();
				bool flag2 = kWsP1bYRVsfaicfjr67.sVUL5ZT60dm();
				bool flag3 = kWsP1bYRVsfaicfjr67.A6vL5VlPSBT();
				int num = (flag ? 1 : 0) + (flag2 ? 1 : 0) + (flag3 ? 1 : 0);
				if (num == 0)
				{
					return;
				}
				bool flag4 = num == 1;
				ContextMenu contextMenu = new ContextMenu();
				if (!flag)
				{
					goto IL_009e;
				}
				textToProcess = kWsP1bYRVsfaicfjr67.n78L5HxDVZd();
				itemCollection = null;
				itemCollection = ((!flag4) ? AppHelper.AddMenuItem(contextMenu.Items, "文本内容", "", "", null).Items : contextMenu.Items);
				goto IL_02de;
				IL_009e:
				if (flag2)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						Y4Pvr274o8c = kWsP1bYRVsfaicfjr67.UyVL5sg3svP()
					};
					if (_003C_003Ec__DisplayClass2_.Y4Pvr274o8c != null)
					{
						ItemCollection itemCollection2 = null;
						itemCollection2 = ((!flag4) ? AppHelper.AddMenuItem(contextMenu.Items, "图片内容", "", "", null).Items : contextMenu.Items);
						BuildImageContextMenu(itemCollection2, _003C_003Ec__DisplayClass2_.BqNvrS6Biaj, Rectangle.Empty, true);
					}
				}
				int num2;
				if (flag3)
				{
					num2 = 0;
					if (YZeTPTcSYIj48lxFpN9r != null)
					{
						goto IL_00c8;
					}
					goto IL_00cc;
				}
				goto IL_023d;
				IL_023d:
				if (contextMenu.Items.Count > 0)
				{
					num2 = 1;
					if (!r1Ng6ocS8Pd6ns0YAWQq())
					{
						goto IL_00c8;
					}
					goto IL_00cc;
				}
				return;
				IL_00cc:
				List<string> list = default(List<string>);
				switch (num2)
				{
				default:
					list = kWsP1bYRVsfaicfjr67.yrAL5GvMK5S().Cast<string>().ToList();
					if (list.HasData())
					{
						ItemCollection items = contextMenu.Items;
						items = ((!flag4) ? AppHelper.AddMenuItem(contextMenu.Items, $"文件内容({list.Count}个)", "", "", null).Items : contextMenu.Items);
						KXCteJAL0Uj(items, list, false);
						if (flag4)
						{
							goto case 3;
						}
					}
					goto IL_023d;
				case 3:
					if (list.Count == 1 && list[0].EndsWithAny(StringComparison.OrdinalIgnoreCase, ".png", ".jpg", ".jpeg", ".bmp", ".gif", ".ico", ".tif", ".tiff"))
					{
						_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_1
						{
							WuXvrNctqT2 = list[0]
						};
						BuildImageContextMenu(AppHelper.AddMenuItem(contextMenu.Items, "图片内容", "图片内容的相关动作", "fa:Light_Image", null, 0).Items, _003C_003Ec__DisplayClass2_2.bjGvruAhHkV, Rectangle.Empty, true, _003C_003Ec__DisplayClass2_2.WuXvrNctqT2);
					}
					goto IL_023d;
				case 2:
					break;
				case 1:
					contextMenu.IsOpen = true;
					AppState.RegisterContextMenu(contextMenu);
					return;
				}
				goto IL_02de;
				IL_00c8:
				int num3 = default(int);
				num2 = num3;
				goto IL_00cc;
				IL_02de:
				BuildTextContextMenus(itemCollection, textToProcess);
				goto IL_009e;
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("生成上下文菜单出错：" + exception.GetMessageWithInner());
			}
		}

		internal void qhNvxSyyku0(object sender, RoutedEventArgs e)
		{
			AppWindowManager.ShowSettingsWindow(SettingPageId.ImageContextMenuSettings);
		}

		internal string iE8vx2KfZHd(string s)
		{
			return s.ToUpper();
		}

		internal string Vy7vxuVZ0WO(string s)
		{
			return s.ToLower();
		}

		internal string IRDvxNonJVe(string s)
		{
			return Uri.EscapeDataString(s);
		}

		internal string sSCvxJ6H1rm(string s)
		{
			return HttpUtility.UrlDecode(s);
		}

		internal string QNIvx0RMTMF(string s)
		{
			return HttpUtility.HtmlEncode(s);
		}

		internal string qO9vxCs2Ur6(string s)
		{
			return HttpUtility.HtmlDecode(s);
		}

		internal string lhgvxPkntox(string s)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in s)
			{
				if (c > '\u007f')
				{
					stringBuilder.AppendFormat("\\u{0:x4}", (int)c);
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		internal string o9yvxEVqj8U(string s)
		{
			return Regex.Replace(s, "\\\\u(?<Value>[a-zA-Z0-9]{4})", gWnvxBnMWhY ?? (gWnvxBnMWhY = g4dvxcl9vXW.CkPvxy2vo00));
		}

		internal string CkPvxy2vo00(Match m)
		{
			return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
		}

		internal string HAlvx8o8TFO(string s)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		}

		internal string R1bvxainRlp(string s)
		{
			return s.DecodeBase64String();
		}

		internal string NDnvx7E9LYS(string s)
		{
			try
			{
				return JsonConvert.DeserializeObject(s, new JsonSerializerSettings
				{
					FloatParseHandling = FloatParseHandling.Decimal,
					Formatting = Formatting.Indented
				}).ToString();
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("格式化json出错，可能不是合法的json内容。");
				return s;
			}
		}

		internal string TrAvxRZyTkJ(string s)
		{
			return s.Unescape();
		}

		internal void v9CvxqErNUB(object sender, RoutedEventArgs e)
		{
			AppWindowManager.ShowSettingsWindow(SettingPageId.TextContextMenuSettings);
		}

		internal static bool r1Ng6ocS8Pd6ns0YAWQq()
		{
			return YZeTPTcSYIj48lxFpN9r == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Cx982QHIQipEGm84wUt : IAsyncStateMachine
		{
			public int aaW27HHvgJ3;

			public AsyncVoidMethodBuilder Cac271iItHv;

			public _003C_003Ec__DisplayClass0_0 w0w27bWttLc;

			private _003C_003Ec__DisplayClass0_3 PFS2764CHPZ;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter HuU27XLvhZb;

			internal static object EkXOHjyu2wIWH14EBpyH;

			private void MoveNext()
			{
				int num = aaW27HHvgJ3;
				_003C_003Ec__DisplayClass0_0 ypUvxfEJGFN = w0w27bWttLc;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						PFS2764CHPZ = new _003C_003Ec__DisplayClass0_3();
						PFS2764CHPZ.YpUvxfEJGFN = ypUvxfEJGFN;
						PFS2764CHPZ.zDovx3BM0pf = new StringBuilder();
						AppHelper.ShowInformation("开始计算，请稍候...");
						awaiter = Task.Run((Action)PFS2764CHPZ.ISSvxiSZhTO).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							aaW27HHvgJ3 = 0;
							HuU27XLvhZb = awaiter;
							Cac271iItHv.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = HuU27XLvhZb;
						HuU27XLvhZb = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						aaW27HHvgJ3 = -1;
					}
					awaiter.GetResult();
					TextWindow textWindow = new TextWindow();
					textWindow.Title = "文件哈希值";
					textWindow.SetText(PFS2764CHPZ.zDovx3BM0pf.ToString());
					textWindow.ShowBuildInToolbar = true;
					textWindow.Show();
					textWindow.Activate();
				}
				catch (Exception exception)
				{
					aaW27HHvgJ3 = -2;
					PFS2764CHPZ = null;
					Cac271iItHv.SetException(exception);
					return;
				}
				aaW27HHvgJ3 = -2;
				PFS2764CHPZ = null;
				Cac271iItHv.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Cac271iItHv.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool yQN3gEyuA1yevcmoxyKG()
			{
				return EkXOHjyu2wIWH14EBpyH == null;
			}
		}

		public List<string> uO4vxMtAusl;

		internal static _003C_003Ec__DisplayClass0_0 Kagfm4cSMLkH0nKF1NnL;

		internal void ngOvxd7jTII(ItemCollection menuCollection, string header, string icon, string tooltip, Func<IList<string>, string> func)
		{
			AppHelper.AddMenuItem(menuCollection, header, tooltip, icon, new _003C_003Ec__DisplayClass0_1
			{
				CI8vxFxYMW3 = this,
				eDpvxOYcQ9M = func
			}.zW9vxAdyPPV);
		}

		internal void RLKvxo8HZ2K(object sender, RoutedEventArgs e)
		{
			if (!ClipboardHelper.SetFile(uO4vxMtAusl))
			{
				AppHelper.ShowWarning("复制失败，请重试。");
			}
		}

		[AsyncStateMachine(typeof(Cx982QHIQipEGm84wUt))]
		internal void APlvxTpuETd(object sender, RoutedEventArgs e)
		{
			Cx982QHIQipEGm84wUt stateMachine = default(Cx982QHIQipEGm84wUt);
			stateMachine.Cac271iItHv = AsyncVoidMethodBuilder.Create();
			stateMachine.w0w27bWttLc = this;
			stateMachine.aaW27HHvgJ3 = -1;
			stateMachine.Cac271iItHv.Start(ref stateMachine);
		}

		internal static bool uyjxZ7cSUsejPtTN5IqB()
		{
			return Kagfm4cSMLkH0nKF1NnL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_1
	{
		public Func<IList<string>, string> eDpvxOYcQ9M;

		public _003C_003Ec__DisplayClass0_0 CI8vxFxYMW3;

		internal static _003C_003Ec__DisplayClass0_1 lVLUSOcSIsVX3C6hlvUS;

		internal void zW9vxAdyPPV(object sender, RoutedEventArgs e)
		{
			string text = "";
			try
			{
				text = eDpvxOYcQ9M(CI8vxFxYMW3.uO4vxMtAusl);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("处理出错：" + exception.GetMessageWithInner());
			}
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					kWsP1bYRVsfaicfjr67.RsqL5rdQFty(text);
					AppHelper.ShowSuccess("结果已写入剪贴板：\n" + text.ToShortString(30));
				}
				catch (Exception exception2)
				{
					AppHelper.ShowWarning("写入剪贴板出错：" + exception2.GetMessageWithInner());
				}
			}
		}

		static _003C_003Ec__DisplayClass0_1()
		{
		}

		internal static bool E4QuDbcS6DXHOiACXpR6()
		{
			return lVLUSOcSIsVX3C6hlvUS == null;
		}

		internal static void NH9MQ9cSSugQq1JteJdT()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_2
	{
		public string bCavxlrNVKF;

		private static _003C_003Ec__DisplayClass0_2 WunYINcSwQYYO51helkx;

		internal string Rj3vxUuinst(IList<string> fileList)
		{
			eYYte0XBawu(fileList, bCavxlrNVKF);
			return "";
		}

		internal static bool ywPHFfcSTEVi5baAiNMx()
		{
			return WunYINcSwQYYO51helkx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_3
	{
		public StringBuilder zDovx3BM0pf;

		public _003C_003Ec__DisplayClass0_0 YpUvxfEJGFN;

		internal static _003C_003Ec__DisplayClass0_3 b058KycSsEd3dUl0Piik;

		internal void ISSvxiSZhTO()
		{
			foreach (string item in YpUvxfEJGFN.uO4vxMtAusl)
			{
				if (File.Exists(item))
				{
					zDovx3BM0pf.AppendLine(Path.GetFileName(item) + ":");
					try
					{
						(string, string, string, string) tuple = eXCKbmiAn2aWIr09iBV.ObIvwbMjsBM(item);
						zDovx3BM0pf.AppendLine("  MD5   : " + tuple.Item1);
						zDovx3BM0pf.AppendLine("  SHA1  : " + tuple.Item2);
						zDovx3BM0pf.AppendLine("  SHA256: " + tuple.Item3);
						zDovx3BM0pf.AppendLine("  CRC32 : " + tuple.Item4);
					}
					catch (Exception exception)
					{
						zDovx3BM0pf.AppendLine("  计算出错：" + exception.GetMessageWithInner());
					}
					zDovx3BM0pf.AppendLine();
				}
			}
		}

		internal static bool AnC9v8cSC3hdTCm9v3EA()
		{
			return b058KycSsEd3dUl0Piik == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_4
	{
		public ActionItem moJvrwp1A9N;

		public _003C_003Ec__DisplayClass0_0 whnvrtAiSIp;

		internal static _003C_003Ec__DisplayClass0_4 rdwXjIcSHcXsyp3N2V8o;

		internal void RXqvxz54CJa(object sender, RoutedEventArgs e)
		{
			AppState.AppServer.ExecuteActionByIdOrName(moJvrwp1A9N.Id, null, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, false, "", ActionTrigger.Association, new ActionExtraContextData
			{
				Files = whnvrtAiSIp.uO4vxMtAusl
			});
		}

		internal static bool IXLrrdcSzn8hxRPtX7tH()
		{
			return rdwXjIcSHcXsyp3N2V8o == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public IList<string> j1bvrL6VYE5;

		public string kiyvrvAGWDK;

		internal static _003C_003Ec__DisplayClass1_0 ePCumPcwQxAPOGVEBAKB;

		internal void CfpvrgKCwZu()
		{
			try
			{
				ContextMenuSettings contextMenuSettings = AppState.HHxtaMaoqJr().ContextMenuSettings;
				if (contextMenuSettings != null && contextMenuSettings.UseWindowsShellMoveInto)
				{
					FileSystemHelper.MoveIntoFolderWithShell(j1bvrL6VYE5.ToArray(), kiyvrvAGWDK);
					return;
				}
				IList<string> list = new List<string>();
				foreach (string item in j1bvrL6VYE5)
				{
					try
					{
						FileSystemHelper.MoveIntoFolder(item, kiyvrvAGWDK, false, true);
					}
					catch (Exception exception)
					{
						list.Add(Path.GetFileName(item) + " " + exception.GetMessageWithInner());
						AppHelper.ShowWarning("移动文件(夹) " + item + " 失败：" + exception.GetMessageWithInner());
						break;
					}
				}
				if (list.HasData())
				{
					AppHelper.ShowWarning("这些文件移动失败了：\r\n" + string.Join("\r\n", list));
					return;
				}
				AppHelper.ShowSuccess("操作完成。");
				if (!hgHshTcwFJnmgw4yrxM8())
				{
					switch (0)
					{
					}
				}
			}
			catch (Exception exception2)
			{
				AppHelper.ShowWarning("操作出错：" + exception2.GetMessageWithInner());
			}
		}

		internal static bool hgHshTcwFJnmgw4yrxM8()
		{
			return ePCumPcwQxAPOGVEBAKB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public System.Drawing.Image Y4Pvr274o8c;

		internal static _003C_003Ec__DisplayClass2_0 EUwWyYcwyxkOCtxnmVoH;

		internal System.Drawing.Image BqNvrS6Biaj()
		{
			return Y4Pvr274o8c;
		}

		internal static bool b3oyrMcwpWCaqhepKlx9()
		{
			return EUwWyYcwyxkOCtxnmVoH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_1
	{
		public string WuXvrNctqT2;

		internal static _003C_003Ec__DisplayClass2_1 pDc8Jtcw25pd9ix8oWbZ;

		internal System.Drawing.Image bjGvruAhHkV()
		{
			return ImageHelper.ReadImageFromFileWithoutLock(WuXvrNctqT2);
		}

		internal static bool WJpndVcwA8D2nQmoP0UC()
		{
			return pDc8Jtcw25pd9ix8oWbZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public System.Drawing.Image GsFvr0iQ9qb;

		public List<SimpleOperationItem> BqAvrCbREGa;

		internal static _003C_003Ec__DisplayClass4_0 B2rbXQcwee6mFGMeTgQw;

		internal void S3wvrJqrakL()
		{
			try
			{
				string text = TempImageBedStep.Ps7g8j76rhb(null, SlOteEFgVge(GsFvr0iQ9qb));
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				foreach (SimpleOperationItem item in BqAvrCbREGa)
				{
					if (!item.IsSeparator)
					{
						AppHelper.TryOpenUrlOrFile(item.Key.Replace("%s", Uri.EscapeDataString(text)).TrimStart());
					}
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("搜图出错：" + exception.GetMessageWithInner());
			}
		}

		internal static bool Rm6EHUcwjPrPo40hI5Cc()
		{
			return B2rbXQcwee6mFGMeTgQw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public System.Drawing.Image g2XvrEPZ2fC;

		public string url;

		private static _003C_003Ec__DisplayClass5_0 Q7aL88cwGvoJWCbMYRix;

		internal void rPavrPCbrwa()
		{
			try
			{
				string text = TempImageBedStep.Ps7g8j76rhb(null, SlOteEFgVge(g2XvrEPZ2fC));
				if (!string.IsNullOrEmpty(text))
				{
					AppHelper.TryOpenUrlOrFile(url.Replace("%s", Uri.EscapeDataString(text)));
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("搜图出错：" + exception.GetMessageWithInner());
			}
		}

		internal static bool RaXEd2cw0BLE4oU4Lnuu()
		{
			return Q7aL88cwGvoJWCbMYRix == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ARLYXyHGDo7TSFHbFdj : IAsyncStateMachine
		{
			public int gb227mpare7;

			public AsyncVoidMethodBuilder yoG27KZVX4K;

			public _003C_003Ec__DisplayClass8_0 jxn27x7oKIO;

			private string lXc27raLRae;

			private System.Drawing.Image UkP27p3D0rq;

			private string zTB27B4Sr1G;

			private TaskAwaiter<(bool success, string result)> dxX27QtiGDZ;

			private Exception F1x27jdlhEM;

			private int clD27nR0wBt;

			private TaskAwaiter<PaddleOcrResult> d9d274jikRa;

			private TaskAwaiter<IList<string>> TH9275kkX7Y;

			internal static object CNc0tMyujgKTWgbtElWG;

			private void MoveNext()
			{
				int num = gb227mpare7;
				_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = jxn27x7oKIO;
				try
				{
					try
					{
						TaskAwaiter<(bool, string)> awaiter2 = default(TaskAwaiter<(bool, string)>);
						int num2;
						TaskAwaiter<IList<string>> awaiter = default(TaskAwaiter<IList<string>>);
						(bool, string) result = default((bool, string));
						IList<string> result3;
						IList<string> result4;
						int num4 = default(int);
						switch (num)
						{
						case 0:
							awaiter2 = dxX27QtiGDZ;
							dxX27QtiGDZ = default(TaskAwaiter<(bool, string)>);
							num = -1;
							gb227mpare7 = -1;
							goto IL_01cd;
						case 1:
						{
							try
							{
								TaskAwaiter<PaddleOcrResult> awaiter3;
								if (num != 1)
								{
									awaiter3 = IIQBbr2FgGR5ONc4nck.tEttyL66DUb(UkP27p3D0rq).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = 1;
										gb227mpare7 = 1;
										d9d274jikRa = awaiter3;
										yoG27KZVX4K.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
								}
								else
								{
									awaiter3 = d9d274jikRa;
									d9d274jikRa = default(TaskAwaiter<PaddleOcrResult>);
									num = -1;
									gb227mpare7 = -1;
								}
								PaddleOcrResult result2 = awaiter3.GetResult();
								lXc27raLRae = result2.Result.Lines;
								if (CNc0tMyujgKTWgbtElWG == null)
								{
									switch (0)
									{
									}
								}
								zTB27B4Sr1G = "Quicker";
							}
							catch (Exception f1x27jdlhEM)
							{
								F1x27jdlhEM = f1x27jdlhEM;
								clD27nR0wBt = 1;
							}
							int num3 = clD27nR0wBt;
							if (num3 == 1)
							{
								Exception exception = F1x27jdlhEM;
								PSgteawPAMQ.Warn("Paddle OCR 识别失败: " + exception.GetMessageWithInner());
								awaiter = KJPvclMRZwxyLnfknnp.e0qLF4C5gse(_003C_003Ec__DisplayClass8_.NNUvraEptNH()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = 4;
									if (!dBCv2kyuDNnt6B8EeBec())
									{
										goto IL_01ca;
									}
									goto IL_0210;
								}
								goto IL_031f;
							}
							goto IL_0345;
						}
						default:
							lXc27raLRae = "";
							UkP27p3D0rq = _003C_003Ec__DisplayClass8_.NNUvraEptNH();
							zTB27B4Sr1G = "";
							if (bfmVNpoIh0N1MPAqJ5v.LprgBF823Fu())
							{
								awaiter2 = bfmVNpoIh0N1MPAqJ5v.YQKgBfPMkG3(UkP27p3D0rq).GetAwaiter();
								if (awaiter2.IsCompleted)
								{
									goto IL_01cd;
								}
								num = 0;
								gb227mpare7 = 0;
								num2 = 0;
								if (CNc0tMyujgKTWgbtElWG != null)
								{
									goto IL_01ca;
								}
								goto IL_0210;
							}
							goto IL_022f;
						case 2:
							goto IL_0303;
						case 3:
							{
								awaiter = TH9275kkX7Y;
								TH9275kkX7Y = default(TaskAwaiter<IList<string>>);
								num = -1;
								gb227mpare7 = -1;
								goto IL_036a;
							}
							IL_01cd:
							result = awaiter2.GetResult();
							num2 = 2;
							if (!dBCv2kyuDNnt6B8EeBec())
							{
								goto IL_01e3;
							}
							goto IL_0210;
							IL_0210:
							switch (num2)
							{
							case 3:
								break;
							case 2:
								goto IL_01e3;
							case 5:
								goto IL_022f;
							default:
								goto IL_027f;
							case 4:
								num = 2;
								gb227mpare7 = 2;
								TH9275kkX7Y = awaiter;
								yoG27KZVX4K.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								goto IL_0303;
							}
							goto default;
							IL_0303:
							awaiter = TH9275kkX7Y;
							TH9275kkX7Y = default(TaskAwaiter<IList<string>>);
							num = -1;
							gb227mpare7 = -1;
							goto IL_031f;
							IL_01e3:
							if (!result.Item1)
							{
								goto IL_022f;
							}
							lXc27raLRae = result.Item2;
							zTB27B4Sr1G = "离线引擎";
							num2 = 5;
							if (dBCv2kyuDNnt6B8EeBec())
							{
								goto IL_0210;
							}
							goto IL_027f;
							IL_0345:
							F1x27jdlhEM = null;
							break;
							IL_027f:
							dxX27QtiGDZ = awaiter2;
							yoG27KZVX4K.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
							IL_031f:
							result3 = awaiter.GetResult();
							lXc27raLRae = result3.JoinToString();
							zTB27B4Sr1G = "Windows";
							goto IL_0345;
							IL_022f:
							if (!string.IsNullOrEmpty(lXc27raLRae))
							{
								break;
							}
							if (UkP27p3D0rq.Width * UkP27p3D0rq.Height < 250000)
							{
								clD27nR0wBt = 0;
								goto case 1;
							}
							awaiter = KJPvclMRZwxyLnfknnp.e0qLF4C5gse(_003C_003Ec__DisplayClass8_.NNUvraEptNH()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 3;
								gb227mpare7 = 3;
								TH9275kkX7Y = awaiter;
								yoG27KZVX4K.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_036a;
							IL_036a:
							result4 = awaiter.GetResult();
							lXc27raLRae = result4.JoinToString();
							zTB27B4Sr1G = "Windows";
							break;
							IL_01ca:
							num2 = num4;
							goto IL_0210;
						}
						TextWindow textWindow = new TextWindow();
						textWindow.ActionContext = null;
						textWindow.ShowBuildInToolbar = true;
						textWindow.Topmost = true;
						textWindow.SetText(lXc27raLRae);
						textWindow.Title = "识别结果（" + zTB27B4Sr1G + "）";
						textWindow.ShowActivated = true;
						textWindow.Show();
						lXc27raLRae = null;
						UkP27p3D0rq = null;
						zTB27B4Sr1G = null;
					}
					catch (Exception exception2)
					{
						PSgteawPAMQ.Warn("OCR出错：" + exception2.GetMessageWithInner(), exception2);
						AppHelper.ShowWarning("OCR出错：" + exception2.GetMessageWithInner());
					}
				}
				catch (Exception exception3)
				{
					gb227mpare7 = -2;
					yoG27KZVX4K.SetException(exception3);
					return;
				}
				gb227mpare7 = -2;
				yoG27KZVX4K.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				yoG27KZVX4K.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool dBCv2kyuDNnt6B8EeBec()
			{
				return CNc0tMyujgKTWgbtElWG == null;
			}
		}

		public Func<System.Drawing.Image> NNUvraEptNH;

		public string JqRvr7mwfw4;

		public Rectangle wNfvrRNUB48;

		private static _003C_003Ec__DisplayClass8_0 SANdrocwBNyn6Z0Uo4oA;

		internal void Qd6vryuWYVb(object sender, RoutedEventArgs e)
		{
			try
			{
				AppHelper.RunOnUiThread(false, new _003C_003Ec__DisplayClass8_1
				{
					CGVvrVKOUcE = this,
					u45vrcXy5V3 = Quicker.Utilities.Images.ImageConverter.ConvertBitmap(GetBitmap(NNUvraEptNH()))
				}.Mqovrq9efwx);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("操作出错：" + exception.GetMessageWithInner());
			}
		}

		[AsyncStateMachine(typeof(ARLYXyHGDo7TSFHbFdj))]
		internal void g9gvr87HtiX(object sender, RoutedEventArgs e)
		{
			ARLYXyHGDo7TSFHbFdj stateMachine = default(ARLYXyHGDo7TSFHbFdj);
			stateMachine.yoG27KZVX4K = AsyncVoidMethodBuilder.Create();
			stateMachine.jxn27x7oKIO = this;
			stateMachine.gb227mpare7 = -1;
			stateMachine.yoG27KZVX4K.Start(ref stateMachine);
		}

		internal static bool mTVhDYcwvU2WiDskE3ql()
		{
			return SANdrocwBNyn6Z0Uo4oA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_1
	{
		public BitmapSource u45vrcXy5V3;

		public _003C_003Ec__DisplayClass8_0 CGVvrVKOUcE;

		private static _003C_003Ec__DisplayClass8_1 dXr9s4cwOcF0CC2nQlQo;

		internal void Mqovrq9efwx()
		{
			ImageViewerWindow imageViewerWindow = new ImageViewerWindow(u45vrcXy5V3)
			{
				ImageFilePath = ""
			};
			if (ERJH2BcwJZdsTXLvS9lx())
			{
				switch (0)
				{
				}
			}
			imageViewerWindow.Location = ShowWindowLocation.Auto;
			imageViewerWindow.InitialScale = 1.0;
			imageViewerWindow.AutoCloseSeconds = 0.0;
			imageViewerWindow.AutoCloseKey = "";
			if (!string.IsNullOrEmpty(CGVvrVKOUcE.JqRvr7mwfw4))
			{
				imageViewerWindow.ImageFilePath = CGVvrVKOUcE.JqRvr7mwfw4;
			}
			imageViewerWindow.Show();
		}

		internal static bool ERJH2BcwJZdsTXLvS9lx()
		{
			return dXr9s4cwOcF0CC2nQlQo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_2
	{
		public List<SimpleOperationItem> jplvr9kkd2y;

		public _003C_003Ec__DisplayClass8_0 KBevrhZnYFG;

		private static _003C_003Ec__DisplayClass8_2 LECQUlcwrg8sqeQYc8MJ;

		internal void oemvrZPiEUC(object sender, RoutedEventArgs e)
		{
			try
			{
				u0iteCvjDhy(jplvr9kkd2y, KBevrhZnYFG.NNUvraEptNH());
			}
			catch (Exception ex)
			{
				PSgteawPAMQ.Warn("批量搜图出错：" + ex.Message, ex);
				AppHelper.ShowWarning("操作出错：" + ex.GetMessageWithInner());
			}
		}

		internal static void NVmjsrcwLaRmTOH3Vfkq()
		{
		}

		internal static bool w5dyxEcwNgZgG36qvYf5()
		{
			return LECQUlcwrg8sqeQYc8MJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_3
	{
		public string VwevrYRXNBC;

		public _003C_003Ec__DisplayClass8_2 wZQvrIm8pQV;

		private static _003C_003Ec__DisplayClass8_3 GZRBSWcwuHwrbL7jxVbq;

		internal void bq9vrepmZFk(object sender, RoutedEventArgs e)
		{
			try
			{
				QbytePHIPvG(VwevrYRXNBC, wZQvrIm8pQV.KBevrhZnYFG.NNUvraEptNH());
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("操作出错：" + exception.GetMessageWithInner());
			}
		}

		internal static bool MPRcxMcwoUjswqvURDwk()
		{
			return GZRBSWcwuHwrbL7jxVbq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_4
	{
		public ActionItem x8mvrkl19Mf;

		public _003C_003Ec__DisplayClass8_0 KcVvrGNCur7;

		private static _003C_003Ec__DisplayClass8_4 aXlSEVcwb8cFvW0oOMeN;

		internal void qaHvrWRME1s(object sender, RoutedEventArgs e)
		{
			try
			{
				AppState.AppServer.ExecuteActionByIdOrName(x8mvrkl19Mf.Id, null, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, false, "", ActionTrigger.Association, new ActionExtraContextData
				{
					CaptureArea = KcVvrGNCur7.wNfvrRNUB48,
					CaptureImage = GetBitmap(KcVvrGNCur7.NNUvraEptNH())
				});
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("操作出错：" + exception.GetMessageWithInner());
			}
		}

		internal static void afWuo9cwli73Rm5apBMy()
		{
		}

		internal static bool uRg3VXcwqg4S82OF7wSt()
		{
			return aXlSEVcwb8cFvW0oOMeN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public string KoUvrKP5Kal;

		public List<SimpleOperationItem> jLTvrx2S7ug;

		public MenuItem LTAvrrw0fJD;

		internal static _003C_003Ec__DisplayClass9_0 SPfgCecwYS4eVwaWDKnE;

		internal void D42vrsvd3Zv(object sender, RoutedEventArgs e)
		{
			yC6teyU115M(jLTvrx2S7ug, KoUvrKP5Kal);
		}

		internal void JDxvrHsS6s4(string header, string tooltip, Func<string, string> func)
		{
			_003C_003Ec__DisplayClass9_2 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_2
			{
				sXDvr44JjBq = this,
				XNsvrn4joea = func
			};
			AppHelper.AddMenuItem(LTAvrrw0fJD.Items, header, tooltip, "", _003C_003Ec__DisplayClass9_.DHOvrjf7Rcv);
		}

		internal void TSlvr1wnC4O(object sender, RoutedEventArgs e)
		{
			TextWindow textWindow = new TextWindow();
			textWindow.SetText(KoUvrKP5Kal);
			textWindow.Show();
		}

		internal void YtqvrbJr84K(object sender, RoutedEventArgs e)
		{
			string tempFileName = Path.GetTempFileName();
			tempFileName = Path.ChangeExtension(tempFileName, ".txt");
			try
			{
				File.WriteAllText(tempFileName, KoUvrKP5Kal);
				AppHelper.OpenTxtFile(tempFileName);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("出错了！" + exception.GetMessageWithInner());
			}
		}

		internal void r64vr6sNPOU(object sender, RoutedEventArgs e)
		{
			string text = KoUvrKP5Kal;
			if (text.Length < 7089)
			{
				try
				{
					AppHelper.ShowBitmap(new QRCode(new QRCodeGenerator().CreateQrCode(text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(4), text);
					return;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("生成二维码出错，可能是因为内容太长了。" + ex.Message);
					return;
				}
			}
			AppHelper.ShowWarning("文本太长了（最大8KB）。");
		}

		internal void mdRvrXTqNSG(object sender, RoutedEventArgs e)
		{
			(int, int, int, int, int) tuple = TextCounterStep.DoCount(KoUvrKP5Kal);
			AppHelper.ShowInformation($"字符数：{tuple.Item2}\r\n" + $"可见字符数：{tuple.Item3}\r\n" + $"汉字数：{tuple.Item4}\r\n" + $"行数：{tuple.Item1}", true);
		}

		internal void X53vrmgukDu(object sender, RoutedEventArgs e)
		{
			string text = KoUvrKP5Kal;
			try
			{
				AppHelper.ExecuteText(text);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message ?? "");
			}
		}

		internal static bool iZwHnFcw8twyreP1bLwD()
		{
			return SPfgCecwYS4eVwaWDKnE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_1
	{
		public string RchvrBPh1LN;

		public _003C_003Ec__DisplayClass9_0 paBvrQ1Rh4c;

		private static _003C_003Ec__DisplayClass9_1 GR0NnScwP9po62upfh1B;

		internal void d1evrpHdoLj(object sender, RoutedEventArgs e)
		{
			mg5te8AVmXu(RchvrBPh1LN, paBvrQ1Rh4c.KoUvrKP5Kal);
		}

		internal static void pOdePPcwx28OyoBwm6Hm()
		{
		}

		internal static bool KdnEstcwMkg7aBnYimv8()
		{
			return GR0NnScwP9po62upfh1B == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_2
	{
		public Func<string, string> XNsvrn4joea;

		public _003C_003Ec__DisplayClass9_0 sXDvr44JjBq;

		private static _003C_003Ec__DisplayClass9_2 u8KY4GcwIpRPe0DXGIp8;

		internal void DHOvrjf7Rcv(object sender, RoutedEventArgs e)
		{
			string text = "";
			try
			{
				text = XNsvrn4joea(sXDvr44JjBq.KoUvrKP5Kal);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("文本处理出错：" + exception.GetMessageWithInner());
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			try
			{
				kWsP1bYRVsfaicfjr67.RsqL5rdQFty(text);
				if (JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control)
				{
					AppHelper.SendPasteKeys();
				}
				else
				{
					AppHelper.ShowSuccess("结果已写入剪贴板：\n" + text.ToShortString(30));
				}
			}
			catch (Exception exception2)
			{
				AppHelper.ShowWarning("写入剪贴板出错：" + exception2.GetMessageWithInner());
			}
		}

		internal static bool h8gRlecw6M8HRvL4J0Ys()
		{
			return u8KY4GcwIpRPe0DXGIp8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_3
	{
		public ActionItem zVyvrDvsbFm;

		public _003C_003Ec__DisplayClass9_0 dRVvrdA8qri;

		private static _003C_003Ec__DisplayClass9_3 MTVbWScwS0bxldY3JUWh;

		internal void Xmevr5hM2eb(object sender, RoutedEventArgs e)
		{
			AppState.AppServer.ExecuteActionByIdOrName(zVyvrDvsbFm.Id, null, JrJWiKYIEBcPm8FFZOl.kBQLD2aG1Qb(), false, false, dRVvrdA8qri.KoUvrKP5Kal, ActionTrigger.Association, new ActionExtraContextData
			{
				Text = dRVvrdA8qri.KoUvrKP5Kal
			});
		}

		internal static bool hsNIsqcww6DkY3o7xUCn()
		{
			return MTVbWScwS0bxldY3JUWh == null;
		}
	}

	private static readonly ILog PSgteawPAMQ;

	private static object g3DB1VQd0FV6Uqm95vLy;

	internal static void KXCteJAL0Uj(ItemCollection itemCollection_0, List<string> list_0, bool bool_0, string string_0 = null)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.uO4vxMtAusl = list_0;
		MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, "复制", "复制路径或文件名", "fa:Light_Copy", null);
		if (bool_0)
		{
			AppHelper.AddMenuItem(menuItem.Items, "复制文件", "复制文件或文件夹本身到剪贴板", "fa:Light_FileCheck", _003C_003Ec__DisplayClass0_.RLKvxo8HZ2K);
		}
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem.Items, "完整路径和文件名", "", "复制文件路径到剪贴板", _003C_003Ec.PWcvxVC45HR ?? (_003C_003Ec.PWcvxVC45HR = _003C_003Ec.g4dvxcl9vXW.E1YvKOfSGT7));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem.Items, "带引号的完整路径和文件名", "", "复制文件路径到剪贴板", _003C_003Ec.qOwvx9OhcpO ?? (_003C_003Ec.qOwvx9OhcpO = _003C_003Ec.g4dvxcl9vXW.E7BvKFAVgGD));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem.Items, "文件名", "", "复制文件名到剪贴板", _003C_003Ec.hm2vxeqPdAm ?? (_003C_003Ec.hm2vxeqPdAm = _003C_003Ec.g4dvxcl9vXW.dX6vKlwdDlv));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem.Items, "去除扩展名的文件名", "", "复制去除扩展名的文件名到剪贴板", _003C_003Ec.C9CvxI0PQEG ?? (_003C_003Ec.C9CvxI0PQEG = _003C_003Ec.g4dvxcl9vXW.i72vK3EFj9D));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem.Items, "所在文件夹路径", "", "复制文件所在文件夹的路径到剪贴板", _003C_003Ec.vRlvxWaWpxA ?? (_003C_003Ec.vRlvxWaWpxA = _003C_003Ec.g4dvxcl9vXW.k5PvKzBXfSu));
		SqoZP75Qt63qQSW6CF1.gJjBGR977Q(_003C_003Ec__DisplayClass0_.uO4vxMtAusl.First(), string_0, menuItem.Items);
		MenuItem menuItem2 = AppHelper.AddMenuItem(itemCollection_0, "移动到...", "将选中的文件移动到选择的目录", "fa:Light_FileExport", null);
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem2.Items, "新建文件夹（自动）", "fa:Light_FolderPlus", "移动到新建文件夹", _003C_003Ec.OSwvxky5mpo ?? (_003C_003Ec.OSwvxky5mpo = _003C_003Ec.g4dvxcl9vXW.N9WvxwXSQi9));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem2.Items, "新建文件夹（指定名称）", "fa:Light_FolderPlus", "移动到指定名称的新建文件夹中", _003C_003Ec.qANvxG6HV90 ?? (_003C_003Ec.qANvxG6HV90 = _003C_003Ec.g4dvxcl9vXW.O04vxttwD2w));
		_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem2.Items, "选择路径...", "fa:Light_FolderOpen", "选择移动到哪个文件夹下", _003C_003Ec.osIvxsaGwO7 ?? (_003C_003Ec.osIvxsaGwO7 = _003C_003Ec.g4dvxcl9vXW.xcGvxgtIykv));
		if (!string.IsNullOrEmpty(AppState.HHxtaMaoqJr().ContextMenuSettings?.FileMoveTargets))
		{
			menuItem2.Items.Add(new Separator());
			foreach (SimpleOperationItem item in AppHelper.StringToOperationItems(AppState.HHxtaMaoqJr().ContextMenuSettings?.FileMoveTargets, true, true))
			{
				if (item.IsSeparator)
				{
					menuItem2.Items.Add(new Separator());
					continue;
				}
				_003C_003Ec__DisplayClass0_2 _003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_2();
				_003C_003Ec__DisplayClass0_2.bCavxlrNVKF = Environment.ExpandEnvironmentVariables(item.Key);
				if (Directory.Exists(_003C_003Ec__DisplayClass0_2.bCavxlrNVKF))
				{
					string icon = (string.IsNullOrEmpty(item.Icon) ? ("icon:" + _003C_003Ec__DisplayClass0_2.bCavxlrNVKF) : item.Icon);
					_003C_003Ec__DisplayClass0_.ngOvxd7jTII(menuItem2.Items, item.Name, icon, "移动到" + _003C_003Ec__DisplayClass0_2.bCavxlrNVKF, _003C_003Ec__DisplayClass0_2.Rj3vxUuinst);
				}
			}
		}
		AppHelper.AddMenuItem(AppHelper.AddMenuItem(itemCollection_0, "工具", "", "fa:Light_Tools", null).Items, "计算文件哈希值", "计算文件的MD5/SHA1/SHA256哈希值", "fa:Light_Hashtag", _003C_003Ec__DisplayClass0_.APlvxTpuETd);
		IList<ActionItem> list = AppState.DataService.yR5t6iJkaBT(_003C_003Ec__DisplayClass0_.uO4vxMtAusl);
		itemCollection_0.Add(new Separator());
		using (IEnumerator<ActionItem> enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass0_4 _003C_003Ec__DisplayClass0_3 = new _003C_003Ec__DisplayClass0_4();
				_003C_003Ec__DisplayClass0_3.whnvrtAiSIp = _003C_003Ec__DisplayClass0_;
				_003C_003Ec__DisplayClass0_3.moJvrwp1A9N = enumerator2.Current;
				AppHelper.AddMenuItem(itemCollection_0, _003C_003Ec__DisplayClass0_3.moJvrwp1A9N.Title, _003C_003Ec__DisplayClass0_3.moJvrwp1A9N.Description, _003C_003Ec__DisplayClass0_3.moJvrwp1A9N.Icon, _003C_003Ec__DisplayClass0_3.RXqvxz54CJa);
			}
		}
		itemCollection_0.Add(new Separator());
		AppHelper.AddMenuItem(itemCollection_0, "设置...", "设置文件操作菜单", "fa:Light_Cog", _003C_003Ec.z48vxHHtlCi ?? (_003C_003Ec.z48vxHHtlCi = _003C_003Ec.g4dvxcl9vXW.nsZvxLrN8DR));
	}

	private static void eYYte0XBawu(IList<string> ilist_0, string string_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.j1bvrL6VYE5 = ilist_0;
		_003C_003Ec__DisplayClass1_.kiyvrvAGWDK = string_0;
		Task.Run((Action)_003C_003Ec__DisplayClass1_.CfpvrgKCwZu);
	}

	public static void ShowClipboardContextMenu()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.LEjvx10Y4II ?? (_003C_003Ec.LEjvx10Y4II = _003C_003Ec.g4dvxcl9vXW.K0wvxvhwFU7));
	}

	private static void u0iteCvjDhy(List<SimpleOperationItem> list_0, System.Drawing.Image image_0)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.GsFvr0iQ9qb = image_0;
		_003C_003Ec__DisplayClass4_.BqAvrCbREGa = list_0;
		Task.Run((Action)_003C_003Ec__DisplayClass4_.S3wvrJqrakL);
	}

	private static void QbytePHIPvG(string string_0, System.Drawing.Image image_0)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.g2XvrEPZ2fC = image_0;
		_003C_003Ec__DisplayClass5_.url = string_0;
		Task.Run((Action)_003C_003Ec__DisplayClass5_.rPavrPCbrwa);
	}

	public static Bitmap GetBitmap(System.Drawing.Image image)
	{
		if (image is Bitmap result)
		{
			return result;
		}
		return new Bitmap(image);
	}

	private static Bitmap SlOteEFgVge(System.Drawing.Image image_0)
	{
		Bitmap bitmap = null;
		Bitmap bitmap2 = GetBitmap(image_0);
		if (bitmap2.Width <= 1200 && bitmap2.Height <= 1200)
		{
			return bitmap2;
		}
		return ImageProcessingHelper.ResizeByMaxWidthOrHeight(bitmap2, 1200, 1200);
	}

	public static void BuildImageContextMenu(ItemCollection menuItems, Func<System.Drawing.Image> getImageFunc, Rectangle rect, bool showPinMenu = false, string filePath = null)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.NNUvraEptNH = getImageFunc;
		_003C_003Ec__DisplayClass8_.JqRvr7mwfw4 = filePath;
		_003C_003Ec__DisplayClass8_.wNfvrRNUB48 = rect;
		if (showPinMenu)
		{
			AppHelper.AddMenuItem(menuItems, "显示图片", "在屏幕上显示图片", "fa:Light_Thumbtack", _003C_003Ec__DisplayClass8_.Qd6vryuWYVb);
		}
		MenuItem menuItem = AppHelper.AddMenuItem(menuItems, "提取文字", "从图片内容中提取文字，使用Windows 10 内置OCR功能，误差较大。", "fa:Light_Text", _003C_003Ec__DisplayClass8_.g9gvr87HtiX);
		if (!NativeMethods.IsOnWindows10OrLater())
		{
			menuItem.IsEnabled = false;
			menuItem.Header = "提取文字（Win7不可用）";
		}
		if (!string.IsNullOrEmpty(AppState.DataService.CpItmVISR7P().ContextMenuSettings?.ImageSearchUrls))
		{
			_003C_003Ec__DisplayClass8_2 _003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_2();
			_003C_003Ec__DisplayClass8_2.KBevrhZnYFG = _003C_003Ec__DisplayClass8_;
			MenuItem menuItem2 = AppHelper.AddMenuItem(menuItems, "搜图", "以图搜图", "fa:Light_Search", null);
			_003C_003Ec__DisplayClass8_2.jplvr9kkd2y = AppHelper.StringToOperationItems(AppState.DataService.CpItmVISR7P().ContextMenuSettings?.ImageSearchUrls, true, true);
			foreach (SimpleOperationItem item in _003C_003Ec__DisplayClass8_2.jplvr9kkd2y)
			{
				if (item.IsSeparator)
				{
					menuItem2.Items.Add(new Separator());
					continue;
				}
				_003C_003Ec__DisplayClass8_3 _003C_003Ec__DisplayClass8_3 = new _003C_003Ec__DisplayClass8_3();
				_003C_003Ec__DisplayClass8_3.wZQvrIm8pQV = _003C_003Ec__DisplayClass8_2;
				string text = item.Icon;
				_003C_003Ec__DisplayClass8_3.VwevrYRXNBC = item.Key;
				if (string.IsNullOrEmpty(text))
				{
					text = AppHelper.GetUrlFavicon(_003C_003Ec__DisplayClass8_3.VwevrYRXNBC);
				}
				AppHelper.AddMenuItem(menuItem2.Items, item.Name, item.Description, text, _003C_003Ec__DisplayClass8_3.bq9vrepmZFk);
			}
			menuItem2.Items.Add(new Separator());
			AppHelper.AddMenuItem(menuItem2.Items, "以上全部", "使用全部搜索搜索引擎搜索图片", "fa:Light_Search", _003C_003Ec__DisplayClass8_2.oemvrZPiEUC);
		}
		IList<ActionItem> list = AppState.DataService.WhOt6lqZteK();
		if (list.Count == 0)
		{
			return;
		}
		menuItems.Add(new Separator());
		using (IEnumerator<ActionItem> enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass8_4 _003C_003Ec__DisplayClass8_4 = new _003C_003Ec__DisplayClass8_4();
				_003C_003Ec__DisplayClass8_4.KcVvrGNCur7 = _003C_003Ec__DisplayClass8_;
				_003C_003Ec__DisplayClass8_4.x8mvrkl19Mf = enumerator2.Current;
				AppHelper.AddMenuItem(menuItems, _003C_003Ec__DisplayClass8_4.x8mvrkl19Mf.Title, _003C_003Ec__DisplayClass8_4.x8mvrkl19Mf.Description, _003C_003Ec__DisplayClass8_4.x8mvrkl19Mf.Icon, _003C_003Ec__DisplayClass8_4.qaHvrWRME1s);
			}
		}
		menuItems.Add(new Separator());
		AppHelper.AddMenuItem(menuItems, "设置...", "设置操作菜单", "fa:Light_Cog", _003C_003Ec.i7Zvxbx98j9 ?? (_003C_003Ec.i7Zvxbx98j9 = _003C_003Ec.g4dvxcl9vXW.qhNvxSyyku0));
	}

	public static void BuildTextContextMenus(ItemCollection menuItems, string textToProcess)
	{
        IEnumerator<ActionItem> enumerator2 = default;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.KoUvrKP5Kal = textToProcess;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass9_.KoUvrKP5Kal))
		{
			return;
		}
		MenuItem menuItem = AppHelper.AddMenuItem(menuItems, "搜索", "", "fa:Light_Search", null);
		_003C_003Ec__DisplayClass9_.jLTvrx2S7ug = AppHelper.StringToOperationItems(AppState.DataService.CpItmVISR7P().ContextMenuSettings?.TextSearchUrls, true, true);
		foreach (SimpleOperationItem item in _003C_003Ec__DisplayClass9_.jLTvrx2S7ug)
		{
			if (item.IsSeparator)
			{
				menuItem.Items.Add(new Separator());
				continue;
			}
			_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_2 = new _003C_003Ec__DisplayClass9_1();
			_003C_003Ec__DisplayClass9_2.paBvrQ1Rh4c = _003C_003Ec__DisplayClass9_;
			if (g3DB1VQd0FV6Uqm95vLy != null)
			{
				switch (0)
				{
				}
			}
			string text = item.Icon;
			_003C_003Ec__DisplayClass9_2.RchvrBPh1LN = item.Key;
			try
			{
				if (string.IsNullOrEmpty(text))
				{
					text = AppHelper.GetUrlFavicon(_003C_003Ec__DisplayClass9_2.RchvrBPh1LN);
				}
			}
			catch (Exception ex)
			{
				PSgteawPAMQ.Warn("获取图标网址出错：" + ex.Message, ex);
			}
			AppHelper.AddMenuItem(menuItem.Items, item.Name, item.Description, text, _003C_003Ec__DisplayClass9_2.d1evrpHdoLj);
		}
		menuItem.Items.Add(new Separator());
		AppHelper.AddMenuItem(menuItem.Items, "以上全部", "使用全部搜索搜索引擎搜索文本", "fa:Light_Search", _003C_003Ec__DisplayClass9_.D42vrsvd3Zv);
		_003C_003Ec__DisplayClass9_.LTAvrrw0fJD = AppHelper.AddMenuItem(menuItems, "文本处理", "", "fa:Light_Cog", null);
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("大写", "将英文内容变为大写", _003C_003Ec.tRMvx6JYqG8 ?? (_003C_003Ec.tRMvx6JYqG8 = _003C_003Ec.g4dvxcl9vXW.iE8vx2KfZHd));
		int num = 0;
		if (g3DB1VQd0FV6Uqm95vLy != null)
		{
			goto IL_0437;
		}
		goto IL_060d;
		IL_0268:
		if (_003C_003Ec__DisplayClass9_.KoUvrKP5Kal.Contains("\\"))
		{
			_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("取消转义(Unescape)", "将内容中的\\r\\n\\t等转换成原始字符。", _003C_003Ec.BWTvx5KKipb ?? (_003C_003Ec.BWTvx5KKipb = _003C_003Ec.g4dvxcl9vXW.TrAvxRZyTkJ));
		}
		MenuItem menuItem2 = AppHelper.AddMenuItem(menuItems, "工具", "", "fa:Light_Tools", null);
		AppHelper.AddMenuItem(menuItem2.Items, "使用文本窗口显示", "使用Quicker的文本窗口显示内容", "fa:Light_StickyNote", _003C_003Ec__DisplayClass9_.TSlvr1wnC4O);
		AppHelper.AddMenuItem(menuItem2.Items, "使用记事本打开", "使用记事本打开选中的内容", "fa:Light_FileAlt", _003C_003Ec__DisplayClass9_.YtqvrbJr84K);
		AppHelper.AddMenuItem(menuItem2.Items, "生成二维码", "生成二维码并打开", "fa:Light_Qrcode", _003C_003Ec__DisplayClass9_.r64vr6sNPOU);
		AppHelper.AddMenuItem(menuItem2.Items, "字数统计", "统计字符数量", "fa:Light_Calculator", _003C_003Ec__DisplayClass9_.mdRvrXTqNSG);
		AppHelper.AddMenuItem(menuItems, "运行", "将内容作为命令运行", "fa:Light_Play", _003C_003Ec__DisplayClass9_.X53vrmgukDu);
		IList<ActionItem> list = AppState.DataService.QVgt6fuEUYI(_003C_003Ec__DisplayClass9_.KoUvrKP5Kal);
		menuItems.Add(new Separator());
		enumerator2 = list.GetEnumerator();
		num = 2;
		if (!MTM0NJQd18WqGmYFbXu9())
		{
			goto IL_060d;
		}
		goto IL_0625;
		IL_0239:
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("格式化JSON", "格式化json代码", _003C_003Ec.OK3vx4o9mnV ?? (_003C_003Ec.OK3vx4o9mnV = _003C_003Ec.g4dvxcl9vXW.NDnvx7E9LYS));
		goto IL_0268;
		IL_0437:
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("小写", "将英文内容变为小写", _003C_003Ec.xhqvxXI7pA7 ?? (_003C_003Ec.xhqvxXI7pA7 = _003C_003Ec.g4dvxcl9vXW.Vy7vxuVZ0WO));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("URL编码", "URL编码选中内容", _003C_003Ec.RJ2vxmWdQ7u ?? (_003C_003Ec.RJ2vxmWdQ7u = _003C_003Ec.g4dvxcl9vXW.IRDvxNonJVe));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("URL解码", "URL解码选中内容", _003C_003Ec.lhFvxKqJyuo ?? (_003C_003Ec.lhFvxKqJyuo = _003C_003Ec.g4dvxcl9vXW.sSCvxJ6H1rm));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("HTML编码", "HTML编码选中内容", _003C_003Ec.NkgvxxTOBCc ?? (_003C_003Ec.NkgvxxTOBCc = _003C_003Ec.g4dvxcl9vXW.QNIvx0RMTMF));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("HTML解码", "HTML解码选中内容", _003C_003Ec.SUUvxrYGQSw ?? (_003C_003Ec.SUUvxrYGQSw = _003C_003Ec.g4dvxcl9vXW.qO9vxCs2Ur6));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("Unicode转义", "将字符转换为其Unicode表示\\uXXXX形式。", _003C_003Ec.UpnvxptZQGk ?? (_003C_003Ec.UpnvxptZQGk = _003C_003Ec.g4dvxcl9vXW.lhgvxPkntox));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("Unicode反转义", "HTML解码选中内容", _003C_003Ec.SqkvxQovVXl ?? (_003C_003Ec.SqkvxQovVXl = _003C_003Ec.g4dvxcl9vXW.o9yvxEVqj8U));
		_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("Base64编码", "Base64编码选中内容", _003C_003Ec.FsMvxjsOUeE ?? (_003C_003Ec.FsMvxjsOUeE = _003C_003Ec.g4dvxcl9vXW.HAlvx8o8TFO));
		string text2 = _003C_003Ec__DisplayClass9_.KoUvrKP5Kal.Trim();
		if (text2.IsBase64())
		{
			_003C_003Ec__DisplayClass9_.JDxvrHsS6s4("Base64解码", "Base64解码选中内容", _003C_003Ec.yZOvxnVRdof ?? (_003C_003Ec.yZOvxnVRdof = _003C_003Ec.g4dvxcl9vXW.R1bvxainRlp));
		}
		if (!text2.IsPossibleJson())
		{
			goto IL_0268;
		}
		num = 0;
		if (MTM0NJQd18WqGmYFbXu9())
		{
			goto IL_0239;
		}
		goto IL_060d;
		IL_0625:
		try
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass9_3 _003C_003Ec__DisplayClass9_3 = new _003C_003Ec__DisplayClass9_3();
				_003C_003Ec__DisplayClass9_3.dRVvrdA8qri = _003C_003Ec__DisplayClass9_;
				_003C_003Ec__DisplayClass9_3.zVyvrDvsbFm = enumerator2.Current;
				AppHelper.AddMenuItem(menuItems, _003C_003Ec__DisplayClass9_3.zVyvrDvsbFm.Title, _003C_003Ec__DisplayClass9_3.zVyvrDvsbFm.Description, _003C_003Ec__DisplayClass9_3.zVyvrDvsbFm.Icon, _003C_003Ec__DisplayClass9_3.Xmevr5hM2eb);
			}
		}
		finally
		{
			enumerator2?.Dispose();
		}
		menuItems.Add(new Separator());
		AppHelper.AddMenuItem(menuItems, "设置...", "设置操作菜单", "fa:Light_Cog", _003C_003Ec.SEcvxDkwMc3 ?? (_003C_003Ec.SEcvxDkwMc3 = _003C_003Ec.g4dvxcl9vXW.v9CvxqErNUB));
		return;
		IL_060d:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0437;
		case 2:
			goto IL_0625;
		}
		goto IL_0239;
	}

	private static void yC6teyU115M(List<SimpleOperationItem> list_0, string string_0)
	{
		foreach (SimpleOperationItem item in list_0)
		{
			if (!item.IsSeparator)
			{
				mg5te8AVmXu(item.Key, string_0);
			}
		}
	}

	private static void mg5te8AVmXu(string string_0, string string_1)
	{
		string text = string_0.Replace("%s", Uri.EscapeDataString(string_1.Trim().ToShortString(100)));
		if (string_1.Contains("%[s]"))
		{
			text = string_0.Replace("%[s]", string_1);
		}
		AppHelper.TryOpenUrlOrFile(text.TrimStart());
	}

	static ContentContextMenuService()
	{
		PSgteawPAMQ = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool MTM0NJQd18WqGmYFbXu9()
	{
		return g3DB1VQd0FV6Uqm95vLy == null;
	}
}
