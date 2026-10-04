using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Clifton.Core.Pipes;
using gNDpGkYZYbhLdMnAyKv;
using log4net;
using NamedPipeWrapper;
using Quicker.Common;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using soLGR8XA95f82ljopSU;

namespace Quicker.Domain.Services;

public class IpcServer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec O2AvTuZ9nU2;

		public static Func<string, string> N6xvTNDX5nP;

		public static Func<string, string> OYjvTJaQKB5;

		public static Func<string, string> NtGvT0H8oxK;

		public static Func<string, string> v3IvTC3oMIC;

		public static Func<string, string> ibJvTPbuJQv;

		public static Func<string, string> SxivTE39T0c;

		public static Func<string, string> n1avTyAGi6Y;

		public static Func<string, string> WNwvT8ShqZR;

		public static Func<string, string> xUrvTaPKVWp;

		public static Func<string, string> uEvvT7CC8ZQ;

		public static Action VYGvTR3ZvkD;

		public static Func<string, string> wo4vTqjWC4m;

		internal static _003C_003Ec TvWHDmWpAexJGOR0Zy8Z;

		static _003C_003Ec()
		{
			O2AvTuZ9nU2 = new _003C_003Ec();
		}

		internal string iJ1vol0hh2q(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_0
			{
				LQ8vT9gFaD7 = cmd
			}.d2RvTZaPcC4);
			return "OK";
		}

		internal string u4SvoiS1mBk(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_1
			{
				hjcvTeC6OaE = cmd
			}.zNbvThC1UmH);
			return "OK";
		}

		internal string Hyjvo3D6Ueq(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_2
			{
				mmkvTIC0jfT = cmd
			}.gIovTYL8Vr7);
			return "OK";
		}

		internal string Oy1vofB8GXi(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_3
			{
				xrbvTk0O1hu = cmd
			}.e5VvTW9op2I);
			return "OK";
		}

		internal string buMvozRFLRM(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_4
			{
				EKUvTsQen1o = cmd
			}.MgcvTGp9TEn);
			return "OK";
		}

		internal string DYDvTwAqZnr(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_5
			{
				UctvT12PeYG = cmd
			}.kCpvTHT5KD5);
			return "OK";
		}

		internal string qGtvTtYQ5J6(string cmd)
		{
			Task.Run((Action)new _003C_003Ec__DisplayClass9_6
			{
				RZJvT6RZS9c = HttpUtility.UrlDecode(cmd.Substring("selectinexplorer:".Length))
			}.jUgvTbggqde);
			return "OK";
		}

		internal string FiHvTgGduqv(string cmd)
		{
			string text = HttpUtility.UrlDecode(cmd.Substring("copyfile:".Length));
			if (File.Exists(text) || Directory.Exists(text))
			{
				kWsP1bYRVsfaicfjr67.jLxL5KAxPKn(new StringCollection { text });
				AppHelper.ShowInformation("已复制 " + text + " 到剪贴板");
			}
			else
			{
				AppHelper.ShowWarning("文件不存在：" + text);
			}
			return "OK";
		}

		internal string LZEvTLsLLqo(string cmd)
		{
			AppHelper.ByuLTpc7Q9J(new _003C_003Ec__DisplayClass9_7
			{
				GhNvTmoldjJ = HttpUtility.UrlDecode(cmd.Substring("uploaddebugfile:".Length))
			}.sNCvTXe7uXj);
			return "OK";
		}

		internal string gIMvTvwg4VA(string cmd)
		{
			if (!Enum.TryParse<SettingPageId>(cmd.Substring("settings:".Length), out var result))
			{
				AppHelper.ShowWarning("未识别的设置页ID（" + cmd + ")，可能您使用的Quicker版本较旧。");
			}
			else
			{
				AppWindowManager.ShowSettingsWindow(result);
			}
			return "OK";
		}

		internal string jqdvTSj7MP7(string cmd)
		{
			try
			{
				AppHelper.RunOnUiThread(false, VYGvTR3ZvkD ?? (VYGvTR3ZvkD = O2AvTuZ9nU2.m8DvT2UUm5F));
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
			return "OK";
		}

		internal void m8DvT2UUm5F()
		{
			AppState.HS2taepcAbc().ShowExeSettingsWindow(null);
		}

		internal static bool Ob3kNNWpnDCFdnw3hSRp()
		{
			return TvWHDmWpAexJGOR0Zy8Z == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public bool RorvTVTkxtu;

		private static _003C_003Ec__DisplayClass15_0 NYnijxWp3NWnHvZyd5F4;

		internal void IPxvTcr27Mp()
		{
			if (AppWindowManager.IsSettingPageOpened(SettingPageId.UISettingsPage))
			{
				AppHelper.ShowWarning("请先关闭设置窗口后再安装外观。");
				RorvTVTkxtu = true;
			}
		}

		internal static bool scSxZ5WpECXb3PMGBOoY()
		{
			return NYnijxWp3NWnHvZyd5F4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public string LQ8vT9gFaD7;

		internal static _003C_003Ec__DisplayClass9_0 YmRwUFWp0B1PeRREosEd;

		internal void d2RvTZaPcC4()
		{
			AppHelper.PreviewSharedAction(LQ8vT9gFaD7.Substring("previewaction:".Length));
		}

		internal static bool XWxIBmWp1UPEuSU7gsav()
		{
			return YmRwUFWp0B1PeRREosEd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_1
	{
		public string hjcvTeC6OaE;

		internal static _003C_003Ec__DisplayClass9_1 lpJqF9WpBuJq7aakt56e;

		internal void zNbvThC1UmH()
		{
			AppState.AppServer.ShowSearchWindow(hjcvTeC6OaE.Substring("search:".Length), false);
		}

		internal static bool hmXNmTWpvWe9c05h0NI5()
		{
			return lpJqF9WpBuJq7aakt56e == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_2
	{
		public string mmkvTIC0jfT;

		internal static _003C_003Ec__DisplayClass9_2 VsNrT6WpJnlCBIfnO4bw;

		internal void gIovTYL8Vr7()
		{
			AppHelper.zD3LTTOpWv0(mmkvTIC0jfT.Substring("previewtextommand:".Length));
		}

		internal static bool CvZb5YWpkIZYB9OxIYIr()
		{
			return VsNrT6WpJnlCBIfnO4bw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_3
	{
		public string xrbvTk0O1hu;

		internal static _003C_003Ec__DisplayClass9_3 fbJP1JWprvIhQj5bETD1;

		internal void e5VvTW9op2I()
		{
			AppHelper.FBLLTMMEKQm(xrbvTk0O1hu.Substring("previewpowerkey:".Length));
		}

		internal static bool kNmgNkWpN2awX15WZsVN()
		{
			return fbJP1JWprvIhQj5bETD1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_4
	{
		public string EKUvTsQen1o;

		private static _003C_003Ec__DisplayClass9_4 nYRu7IWpLq1IUB0na3IM;

		internal void MgcvTGp9TEn()
		{
			AppHelper.PreviewSharedSubProgram(EKUvTsQen1o.Substring("previewsp:".Length));
		}

		internal static bool pA9G0QWpuEFnTI7MMGn7()
		{
			return nYRu7IWpLq1IUB0na3IM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_5
	{
		public string UctvT12PeYG;

		internal static _003C_003Ec__DisplayClass9_5 HlUQ5AWpf1ZtgCuIQmAB;

		internal void kCpvTHT5KD5()
		{
			AppWindowManager.FindStep(UctvT12PeYG.Substring("findstep:".Length));
		}

		internal static bool BXHJGeWpbbra6WN39nlZ()
		{
			return HlUQ5AWpf1ZtgCuIQmAB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_6
	{
		public string RZJvT6RZS9c;

		private static _003C_003Ec__DisplayClass9_6 uovsT3WpiCWJ4VEnIaOr;

		internal void jUgvTbggqde()
		{
			if (File.Exists(RZJvT6RZS9c))
			{
				AppHelper.SelectFileInExplorer(RZJvT6RZS9c, false);
			}
			else
			{
				AppHelper.ShowWarning("文件不存在：" + RZJvT6RZS9c);
			}
		}

		internal static bool jFDMv1WplF2WW6k0bv9B()
		{
			return uovsT3WpiCWJ4VEnIaOr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_7
	{
		[StructLayout(LayoutKind.Auto)]
		private struct yEmo6HkcWUAKibQgBtb : IAsyncStateMachine
		{
			public int glV2qMnfvO7;

			public AsyncTaskMethodBuilder x422qAarS9o;

			public _003C_003Ec__DisplayClass9_7 LoM2qOu1vW4;

			private _003C_003Ec__DisplayClass9_8 x9s2qFOd2Tv;

			private TaskAwaiter<string> iFT2qUNyjil;

			private static object Hal3uSyfDInJYSnsdJkD;

			private void MoveNext()
			{
				int num = glV2qMnfvO7;
				_003C_003Ec__DisplayClass9_7 _003C_003Ec__DisplayClass9_ = LoM2qOu1vW4;
				try
				{
					if (num == 0)
					{
						goto IL_0068;
					}
					if (File.Exists(_003C_003Ec__DisplayClass9_.GhNvTmoldjJ) && _003C_003Ec__DisplayClass9_.GhNvTmoldjJ.EndsWith("_log.html", StringComparison.OrdinalIgnoreCase))
					{
						if (AppHelper.Confirm("您确认要上传此文件么？\r\n请确保文件内不包含隐私信息！"))
						{
							goto IL_0068;
						}
					}
					else
					{
						AppHelper.ShowWarning("文件不存在或不支持：" + _003C_003Ec__DisplayClass9_.GhNvTmoldjJ);
					}
					goto end_IL_0010;
					IL_0068:
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							x9s2qFOd2Tv = new _003C_003Ec__DisplayClass9_8();
							awaiter = oHyR5LX5l5qeapYlxI6.kaBtHCjYysN(_003C_003Ec__DisplayClass9_.GhNvTmoldjJ, 5.0, true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								glV2qMnfvO7 = 0;
								iFT2qUNyjil = awaiter;
								x422qAarS9o.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = iFT2qUNyjil;
							iFT2qUNyjil = default(TaskAwaiter<string>);
							num = -1;
							glV2qMnfvO7 = -1;
						}
						string result = awaiter.GetResult();
						x9s2qFOd2Tv.url = result;
						int num2 = 0;
						if (Hal3uSyfDInJYSnsdJkD != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						default:
							AppHelper.RunOnUiThread(false, x9s2qFOd2Tv.trsvTKHjOUc);
							x9s2qFOd2Tv = null;
							break;
						}
					}
					catch (Exception ex)
					{
						cDBtBESSKgh.Warn("上传文件出错，" + ex.Message, ex);
						AppHelper.ShowWarning("上传文件出错：" + ex.Message);
					}
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					glV2qMnfvO7 = -2;
					x422qAarS9o.SetException(exception);
					return;
				}
				glV2qMnfvO7 = -2;
				x422qAarS9o.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				x422qAarS9o.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Gh0GH4yf35HwDrWIh83j()
			{
				return Hal3uSyfDInJYSnsdJkD == null;
			}
		}

		public string GhNvTmoldjJ;

		internal static _003C_003Ec__DisplayClass9_7 KLNaCEWp5MDu3t6JhuY5;

		[AsyncStateMachine(typeof(yEmo6HkcWUAKibQgBtb))]
		internal Task sNCvTXe7uXj()
		{
			yEmo6HkcWUAKibQgBtb stateMachine = default(yEmo6HkcWUAKibQgBtb);
			stateMachine.x422qAarS9o = AsyncTaskMethodBuilder.Create();
			stateMachine.LoM2qOu1vW4 = this;
			stateMachine.glV2qMnfvO7 = -1;
			stateMachine.x422qAarS9o.Start(ref stateMachine);
			return stateMachine.x422qAarS9o.Task;
		}

		internal static bool otjhQFWpYFH8JD0quiUq()
		{
			return KLNaCEWp5MDu3t6JhuY5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_8
	{
		public string url;

		private static _003C_003Ec__DisplayClass9_8 yQaO7kWpRSOPFnxcZXmA;

		internal void trsvTKHjOUc()
		{
			try
			{
				kWsP1bYRVsfaicfjr67.RsqL5rdQFty(url);
				AppHelper.ShowSuccess("已复制 " + url + " 到剪贴板");
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("复制出错。");
			}
		}

		internal static bool bMCLF8WpgC8WD36Xl5Yb()
		{
			return yQaO7kWpRSOPFnxcZXmA == null;
		}
	}

	private readonly ITinyMessengerHub mdjtBCy8ueF;

	private readonly DataService a1vtBPHqmsO;

	public const string PIPE_NAME = "QuickerIPCChannel";

	private static readonly ILog cDBtBESSKgh;

	private readonly IDictionary<string, Func<string, string>> CUDtByxw77h = new Dictionary<string, Func<string, string>>();

	private PipeServer YtltB8eiJ21;

	private static IpcServer gCMZjDQ9U3Z85yMLQVFU;

	public IpcServer(ITinyMessengerHub hub, DataService dataService)
	{
		mdjtBCy8ueF = hub;
		a1vtBPHqmsO = dataService;
	}

	private string bbNtp3141IB(string string_0, bool bool_0)
	{
		string param = "";
		string text = AppServer.TryExtractActionAndParam(string_0, ref param);
		try
		{
			(ActionItem, ActionExecuteContext, string) tuple = AppState.AppServer.ExecuteActionByIdOrName(text, null, bool_0, true, false, param, ActionTrigger.Extern);
			if (!string.IsNullOrEmpty(tuple.Item3))
			{
				return "Error：" + tuple.Item3;
			}
			if (tuple.Item1 == null)
			{
				return "Error：找不到动作“" + text + "”";
			}
			if (tuple.Item2 == null)
			{
				return "Error：执行出错，没有输出结果。";
			}
			return tuple.Item2.ReturnResult.Or("OK");
		}
		catch (Exception ex)
		{
			return "执行动作出错：" + ex.Message;
		}
	}

	internal void la4tpfLtwhe()
	{
		CUDtByxw77h.Add("show:", PaxtBS8a7MZ);
		CUDtByxw77h.Add("runaction:", RVYtB2WXgbC);
		CUDtByxw77h.Add("debugaction:", r5btBuilJBe);
		CUDtByxw77h.Add("installskin:", hxhtBNyKHVH);
		CUDtByxw77h.Add("restoreskin", MA3tBJ0lQPk);
		CUDtByxw77h.Add("previewaction:", _003C_003Ec.N6xvTNDX5nP ?? (_003C_003Ec.N6xvTNDX5nP = _003C_003Ec.O2AvTuZ9nU2.iJ1vol0hh2q));
		CUDtByxw77h.Add("search:", _003C_003Ec.OYjvTJaQKB5 ?? (_003C_003Ec.OYjvTJaQKB5 = _003C_003Ec.O2AvTuZ9nU2.u4SvoiS1mBk));
		CUDtByxw77h.Add("previewtextommand:", _003C_003Ec.NtGvT0H8oxK ?? (_003C_003Ec.NtGvT0H8oxK = _003C_003Ec.O2AvTuZ9nU2.Hyjvo3D6Ueq));
		int num = 0;
		if (gCMZjDQ9U3Z85yMLQVFU != null)
		{
			goto IL_02b3;
		}
		goto IL_02b7;
		IL_02b7:
		do
		{
			IDictionary<string, Func<string, string>> cUDtByxw77h;
			Func<string, string> value;
			switch (num)
			{
			default:
				CUDtByxw77h.Add("previewpowerkey:", _003C_003Ec.v3IvTC3oMIC ?? (_003C_003Ec.v3IvTC3oMIC = _003C_003Ec.O2AvTuZ9nU2.Oy1vofB8GXi));
				CUDtByxw77h.Add("previewsp:", _003C_003Ec.ibJvTPbuJQv ?? (_003C_003Ec.ibJvTPbuJQv = _003C_003Ec.O2AvTuZ9nU2.buMvozRFLRM));
				CUDtByxw77h.Add("findstep:", _003C_003Ec.SxivTE39T0c ?? (_003C_003Ec.SxivTE39T0c = _003C_003Ec.O2AvTuZ9nU2.DYDvTwAqZnr));
				CUDtByxw77h.Add("selectinexplorer:", _003C_003Ec.n1avTyAGi6Y ?? (_003C_003Ec.n1avTyAGi6Y = _003C_003Ec.O2AvTuZ9nU2.qGtvTtYQ5J6));
				CUDtByxw77h.Add("copyfile:", _003C_003Ec.WNwvT8ShqZR ?? (_003C_003Ec.WNwvT8ShqZR = _003C_003Ec.O2AvTuZ9nU2.FiHvTgGduqv));
				CUDtByxw77h.Add("uploaddebugfile:", _003C_003Ec.xUrvTaPKVWp ?? (_003C_003Ec.xUrvTaPKVWp = _003C_003Ec.O2AvTuZ9nU2.LZEvTLsLLqo));
				CUDtByxw77h.Add("settings:", _003C_003Ec.uEvvT7CC8ZQ ?? (_003C_003Ec.uEvvT7CC8ZQ = _003C_003Ec.O2AvTuZ9nU2.gIMvTvwg4VA));
				cUDtByxw77h = CUDtByxw77h;
				value = _003C_003Ec.wo4vTqjWC4m ?? (_003C_003Ec.wo4vTqjWC4m = _003C_003Ec.O2AvTuZ9nU2.jqdvTSj7MP7);
				break;
			case 1:
				CUDtByxw77h.Add("showmessage:", kZLtB0dcfcI);
				try
				{
					YtltB8eiJ21 = new PipeServer("QuickerIPCChannel");
					PipeServer ytltB8eiJ = YtltB8eiJ21;
					ytltB8eiJ.MessageReceivedEvent = (EventHandler<PipeEventArgs>)Delegate.Combine(ytltB8eiJ.MessageReceivedEvent, new EventHandler<PipeEventArgs>(lrZtpz4OHCV));
					YtltB8eiJ21.Start();
					return;
				}
				catch (Exception ex)
				{
					cDBtBESSKgh.Error("创建Ipc服务出错：" + ex.Message, ex);
					AppHelper.ShowWarning("创建Ipc服务出错：" + ex.Message + "。将无法继续从外部启动Quicker动作。");
					return;
				}
			}
			cUDtByxw77h.Add("exesettings", value);
			num = 1;
		}
		while (zxmd0BQ9xM592ifHm0Jw());
		goto IL_02b3;
		IL_02b3:
		int num2 = default(int);
		num = num2;
		goto IL_02b7;
	}

	private void lrZtpz4OHCV(object sender, PipeEventArgs e)
	{
		string text = e.String;
		ServerPipe serverPipe = sender as ServerPipe;
		try
		{
			string value = XSttBvUIrvc(text);
			WIKtBwj78ZG(serverPipe, value.Or("."));
		}
		catch (IOException)
		{
		}
		catch (Exception ex2)
		{
			cDBtBESSKgh.Error("处理IPC命令(" + text + ")出错：" + ex2.Message, ex2);
			AppHelper.ShowWarning("处理IPC命令出错：" + ex2.GetMessageWithInner());
			WIKtBwj78ZG(serverPipe, "处理IPC命令出错：" + ex2.GetMessageWithInner());
		}
		finally
		{
			try
			{
				YtltB8eiJ21.ClosePipe(serverPipe);
			}
			catch (Exception ex3)
			{
				cDBtBESSKgh.Warn("关闭ServerPipe出错：" + ex3.Message, ex3);
			}
		}
	}

	private void WIKtBwj78ZG(ServerPipe serverPipe_0, string string_0)
	{
		if (serverPipe_0 == null)
		{
			cDBtBESSKgh.Warn("ServerPipe对象为空。");
			return;
		}
		if (!serverPipe_0.IsConnected)
		{
			cDBtBESSKgh.Warn("ServerPipe已断开。");
			return;
		}
		try
		{
			serverPipe_0.WriteString(string_0).GetAwaiter().GetResult();
		}
		catch (Exception ex)
		{
			cDBtBESSKgh.Warn("ServerPipe发送数据出错。ex=" + ex.Message + " data=" + string_0, ex);
		}
	}

	private void JgatBtchSla(NamedPipeConnection<string, string> namedPipeConnection_0, string string_0)
	{
		try
		{
			string text = XSttBvUIrvc(string_0);
			if (!string.IsNullOrWhiteSpace(text))
			{
				namedPipeConnection_0.PushMessage(text);
				Thread.Sleep(50);
			}
			else
			{
				namedPipeConnection_0.PushMessage(".");
			}
		}
		catch (Exception ex)
		{
			cDBtBESSKgh.Error("处理IPC命令(" + string_0 + ")出错：" + ex.Message, ex);
			AppHelper.ShowWarning("处理IPC命令出错：" + ex.GetMessageWithInner());
			if (namedPipeConnection_0.IsConnected)
			{
				namedPipeConnection_0.PushMessage("处理IPC命令出错：" + ex.GetMessageWithInner());
			}
		}
		finally
		{
			namedPipeConnection_0.Close();
		}
	}

	internal static PipeSecurity RrFtBgpaG2C()
	{
		PipeSecurity pipeSecurity = new PipeSecurity();
		SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
		pipeSecurity.SetAccessRule(new PipeAccessRule(identity, PipeAccessRights.ReadWrite | PipeAccessRights.CreateNewInstance, AccessControlType.Allow));
		return pipeSecurity;
	}

	private void ShowMessage(string msg)
	{
		if (string.IsNullOrEmpty(msg))
		{
			return;
		}
		if (msg.IndexOf("success:", StringComparison.OrdinalIgnoreCase) == 0)
		{
			AppHelper.ShowSuccess(msg.Substring("success:".Length));
			return;
		}
		if (msg.IndexOf("warning:", StringComparison.OrdinalIgnoreCase) == 0)
		{
			AppHelper.ShowWarning(msg.Substring("warning:".Length));
			return;
		}
		if (msg.IndexOf("info:", StringComparison.OrdinalIgnoreCase) != 0)
		{
			if (msg.IndexOf("error:", StringComparison.OrdinalIgnoreCase) == 0)
			{
				AppHelper.ShowError(msg.Substring("error:".Length), false);
			}
			else
			{
				AppHelper.ShowInformation(msg);
			}
			return;
		}
		AppHelper.ShowInformation(msg.Substring("info:".Length));
		if (gCMZjDQ9U3Z85yMLQVFU != null)
		{
			switch (0)
			{
			}
		}
	}

	private void dhStBLieneR(string string_0)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.RorvTVTkxtu = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass15_.IPxvTcr27Mp);
		if (_003C_003Ec__DisplayClass15_.RorvTVTkxtu)
		{
			return;
		}
		bool flag = false;
		int num = 0;
		if (!zxmd0BQ9xM592ifHm0Jw())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		string text = "&size=true";
		if (string_0.EndsWith(text))
		{
			flag = true;
			string_0 = string_0.Substring(0, string_0.Length - text.Length);
		}
		if (Guid.TryParse(string_0, out var result) && result != Guid.Empty)
		{
			try
			{
				string text2 = AppState.AppServer.LoadSkin(result, !flag);
				if (!string.IsNullOrEmpty(text2))
				{
					AppHelper.ShowSuccess("已加载外观：" + text2);
				}
				return;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("获取外观失败！" + ex.Message);
				return;
			}
		}
		AppHelper.ShowWarning("不是合法的皮肤ID");
	}

	private string XSttBvUIrvc(string string_0)
	{
		if (string_0.StartsWith("//"))
		{
			string_0 = string_0.Trim().Trim('/');
			if (string_0.Contains("/?"))
			{
				string_0 = string_0.Replace("/?", "?");
			}
		}
		foreach (KeyValuePair<string, Func<string, string>> item in CUDtByxw77h)
		{
			if (string_0.StartsWith(item.Key, StringComparison.OrdinalIgnoreCase))
			{
				return item.Value(string_0);
			}
		}
		AppHelper.ShowWarning("不支持的指令：" + string_0);
		return Error("不支持的指令：" + string_0);
	}

	private string Error(string message)
	{
		return "ERROR:" + message;
	}

	static IpcServer()
	{
		cDBtBESSKgh = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private string PaxtBS8a7MZ(string string_0)
	{
		mdjtBCy8ueF.NotifyRequestShowPanel(this);
		return "OK";
	}

	[CompilerGenerated]
	private string RVYtB2WXgbC(string string_0)
	{
		{
			string string_1 = string_0.Substring("runaction:".Length);
			return bbNtp3141IB(string_1, false);
		}

	}

	[CompilerGenerated]
	private string r5btBuilJBe(string string_0)
	{
		string string_1 = string_0.Substring("debugaction:".Length);
		return bbNtp3141IB(string_1, true);
	}

	[CompilerGenerated]
	private string hxhtBNyKHVH(string string_0)
	{
		{
			dhStBLieneR(string_0.Substring("installskin:".Length));
			return "OK";
		}

	}

	[CompilerGenerated]
	private string MA3tBJ0lQPk(string string_0)
	{
		{
			AppState.AppServer.sAstRQZr0uL();
			return "OK";
		}

	}

	[CompilerGenerated]
	private string kZLtB0dcfcI(string string_0)
	{
		try
		{
			ShowMessage(string_0.Substring("showmessage:".Length));
		}
		catch (Exception)
		{
		}
		return "OK";
	}

	internal static bool zxmd0BQ9xM592ifHm0Jw()
	{
		return gCMZjDQ9U3Z85yMLQVFU == null;
	}
}
