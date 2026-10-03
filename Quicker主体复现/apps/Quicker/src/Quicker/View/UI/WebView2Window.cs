using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Shell;
using HandyControl.Controls;
using HandyControl.Tools;
using log4net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using upLrfmibGdtSX9dWuOT;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View.UI;

public class WebView2Window : HandyControl.Controls.Window, IComponentConnector, iTHRNJY2ZQQokysD4pN
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec vBmS53Afghn;

		public static Func<CoreWebView2Cookie, string> goTS5fDPCoa;

		private static _003C_003Ec EfnCkiWT0twmmt8uSVTW;

		static _003C_003Ec()
		{
			vBmS53Afghn = new _003C_003Ec();
		}

		internal string mOYS5iyKSCN(CoreWebView2Cookie x)
		{
			return x.Name + "=" + x.Value;
		}

		internal static void MGKAPEWTBwKUDnPEBXjf()
		{
		}

		internal static bool B5k00LWT1Fbs8TrqhCxe()
		{
			return EfnCkiWT0twmmt8uSVTW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass111_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct t6JRZAk0Lst7a1U1J67 : IAsyncStateMachine
		{
			public int OMw2V490DuA;

			public AsyncVoidMethodBuilder IY52V5G8BLP;

			public _003C_003Ec__DisplayClass111_0 O3l2VDkamdl;

			private TaskAwaiter<string> wvV2VdsNGNi;

			internal static object vx1010ybwS89lQk8CCgQ;

			private void MoveNext()
			{
				int num = OMw2V490DuA;
				_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = O3l2VDkamdl;
				try
				{
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							awaiter = _003C_003Ec__DisplayClass111_.KenSDw5yjF5.webView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								OMw2V490DuA = 0;
								wvV2VdsNGNi = awaiter;
								IY52V5G8BLP.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = wvV2VdsNGNi;
							wvV2VdsNGNi = default(TaskAwaiter<string>);
							int num2 = 0;
							if (!NT2ovfybTDc9r9DRPcyZ())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = -1;
							OMw2V490DuA = -1;
						}
						string result = awaiter.GetResult();
						_003C_003Ec__DisplayClass111_.pkpSDtox84Y = result;
						_003C_003Ec__DisplayClass111_.pkpSDtox84Y = JsonConvert.DeserializeObject<string>(_003C_003Ec__DisplayClass111_.pkpSDtox84Y);
					}
					catch (Exception ex)
					{
						_003C_003Ec__DisplayClass111_.pkpSDtox84Y = "ERROR:" + ex.Message;
					}
					_003C_003Ec__DisplayClass111_.PSrSDglgqEb.Set();
				}
				catch (Exception exception)
				{
					OMw2V490DuA = -2;
					IY52V5G8BLP.SetException(exception);
					return;
				}
				OMw2V490DuA = -2;
				IY52V5G8BLP.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IY52V5G8BLP.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool NT2ovfybTDc9r9DRPcyZ()
			{
				return vx1010ybwS89lQk8CCgQ == null;
			}
		}

		public WebView2Window KenSDw5yjF5;

		public string pkpSDtox84Y;

		public AutoResetEvent PSrSDglgqEb;

		internal static _003C_003Ec__DisplayClass111_0 JpFp12WTvJHNSHDRkSo8;

		[AsyncStateMachine(typeof(t6JRZAk0Lst7a1U1J67))]
		internal void jQFS5zJ73Uy()
		{
			t6JRZAk0Lst7a1U1J67 stateMachine = default(t6JRZAk0Lst7a1U1J67);
			stateMachine.IY52V5G8BLP = AsyncVoidMethodBuilder.Create();
			stateMachine.O3l2VDkamdl = this;
			stateMachine.OMw2V490DuA = -1;
			stateMachine.IY52V5G8BLP.Start(ref stateMachine);
		}

		internal static bool Fx3hF1WTdUbSPjGnZGQF()
		{
			return JpFp12WTvJHNSHDRkSo8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass112_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ewp58rkTihoJ2VdLhyM : IAsyncStateMachine
		{
			public int NAS2Vo813ES;

			public AsyncVoidMethodBuilder fY22VTyIwqS;

			public _003C_003Ec__DisplayClass112_0 hXR2VMrEL4X;

			private TaskAwaiter<List<CoreWebView2Cookie>> tRi2VApdTcI;

			internal static object inORJBybs96KpwSpcqyM;

			private void MoveNext()
			{
				int num = NAS2Vo813ES;
				_003C_003Ec__DisplayClass112_0 _003C_003Ec__DisplayClass112_ = hXR2VMrEL4X;
				try
				{
					try
					{
						TaskAwaiter<List<CoreWebView2Cookie>> awaiter;
						if (num != 0)
						{
							int num2 = 0;
							if (inORJBybs96KpwSpcqyM != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							awaiter = _003C_003Ec__DisplayClass112_.cNkSDvM2fgA.webView.CoreWebView2.CookieManager.GetCookiesAsync(_003C_003Ec__DisplayClass112_.cNkSDvM2fgA.webView.Source.ToString()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								NAS2Vo813ES = 0;
								tRi2VApdTcI = awaiter;
								fY22VTyIwqS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = tRi2VApdTcI;
							tRi2VApdTcI = default(TaskAwaiter<List<CoreWebView2Cookie>>);
							num = -1;
							NAS2Vo813ES = -1;
						}
						List<CoreWebView2Cookie> result = awaiter.GetResult();
						_003C_003Ec__DisplayClass112_.LCqSDSOJHAw = string.Join("; ", result.Select(_003C_003Ec.goTS5fDPCoa ?? (_003C_003Ec.goTS5fDPCoa = _003C_003Ec.vBmS53Afghn.mOYS5iyKSCN)));
					}
					catch (Exception ex)
					{
						_003C_003Ec__DisplayClass112_.LCqSDSOJHAw = "ERROR:" + ex.Message;
					}
					_003C_003Ec__DisplayClass112_.xiwSD2ahjpk.Set();
				}
				catch (Exception exception)
				{
					NAS2Vo813ES = -2;
					fY22VTyIwqS.SetException(exception);
					return;
				}
				NAS2Vo813ES = -2;
				fY22VTyIwqS.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				fY22VTyIwqS.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool OpQVGAybCZ8KcvJGala8()
			{
				return inORJBybs96KpwSpcqyM == null;
			}
		}

		public WebView2Window cNkSDvM2fgA;

		public string LCqSDSOJHAw;

		public AutoResetEvent xiwSD2ahjpk;

		internal static _003C_003Ec__DisplayClass112_0 ArvQesWTJKPRa3EmgCkK;

		[AsyncStateMachine(typeof(ewp58rkTihoJ2VdLhyM))]
		internal void zl5SDLA2HbB()
		{
			ewp58rkTihoJ2VdLhyM stateMachine = default(ewp58rkTihoJ2VdLhyM);
			stateMachine.fY22VTyIwqS = AsyncVoidMethodBuilder.Create();
			stateMachine.hXR2VMrEL4X = this;
			stateMachine.NAS2Vo813ES = -1;
			stateMachine.fY22VTyIwqS.Start(ref stateMachine);
		}

		internal static bool tXcW0PWTk1h4Cg0LT2Pj()
		{
			return ArvQesWTJKPRa3EmgCkK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass139_0
	{
		public WebView2Window QiUSDNn7GmM;

		public Task<string> FS3SDJsk7vk;

		public string tKNSD0LmpmP;

		private static _003C_003Ec__DisplayClass139_0 FU5eFMWTrAYYv1tH6HW0;

		internal void niqSDuQi9ru()
		{
			try
			{
				if (QiUSDNn7GmM.webView.CoreWebView2 == null)
				{
					FS3SDJsk7vk = Task.FromResult("");
				}
				FS3SDJsk7vk = QiUSDNn7GmM.webView.CoreWebView2.ExecuteScriptAsync(tKNSD0LmpmP);
			}
			catch (Exception ex)
			{
				FS3SDJsk7vk = Task.FromResult("ERROR:" + ex.Message);
			}
		}

		internal static bool f73OcxWTNfZQSa6ElZi2()
		{
			return FU5eFMWTrAYYv1tH6HW0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass147_0
	{
		public WebView2Window XrZSDPGRn9y;

		public MemoryStream Gy5SDEMdcoy;

		public Exception KoESDyW7IjY;

		public Task d0xSD8xlfqL;

		private static _003C_003Ec__DisplayClass147_0 NPl7rUWTLqhb83MrK0rb;

		internal void c75SDCC1DWS()
		{
			if (!XrZSDPGRn9y.IsLoaded)
			{
				KoESDyW7IjY = new Exception("窗口已关闭或未打开");
				return;
			}
			try
			{
				d0xSD8xlfqL = XrZSDPGRn9y.webView.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, Gy5SDEMdcoy);
			}
			catch (Exception koESDyW7IjY)
			{
				KoESDyW7IjY = koESDyW7IjY;
			}
		}

		internal static bool rXsLaBWTutdqqRmN0Ori()
		{
			return NPl7rUWTLqhb83MrK0rb == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCoreWebView2OnFaviconChanged_003Ed__126 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebView2Window _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		internal static object XVs7NHWTf26tC4KRnTnl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebView2Window webView2Window = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Stream> awaiter;
					if (num != 0)
					{
						awaiter = webView2Window.webView.CoreWebView2.GetFaviconAsync(CoreWebView2FaviconImageFormat.Png).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Stream>);
						num = -1;
						_003C_003E1__state = -1;
					}
					Stream result = awaiter.GetResult();
					if (result == null)
					{
						goto IL_00bc;
					}
					if (result.Length == 0L)
					{
						int num2 = 0;
						if (XVs7NHWTf26tC4KRnTnl != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						goto IL_00bc;
					}
					webView2Window.Icon = BitmapFrame.Create(result);
					goto end_IL_0011;
					IL_00bc:
					webView2Window.Icon = null;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					nZ3L8an85XX.Warn("设置图标出错：" + ex.Message + " uri:" + webView2Window.webView.CoreWebView2?.FaviconUri, ex);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool qTkYkRWTbFbSx1q5nrwk()
		{
			return XVs7NHWTf26tC4KRnTnl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToPageCmdExecuted_003Ed__165 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExecutedRoutedEventArgs e;

		public WebView2Window _003C_003E4__this;

		private static object Pl7WiZWTZ947wJG6DiJL;

		private void MoveNext()
		{
			WebView2Window webView2Window = _003C_003E4__this;
			try
			{
				try
				{
					string text = (string)e.Parameter;
					Uri uri = null;
					uri = (Uri.IsWellFormedUriString(text, UriKind.Absolute) ? new Uri(text) : ((text.Contains(" ") || !text.Contains(".")) ? new Uri("https://bing.com/search?q=" + string.Join("+", Uri.EscapeDataString(text).Split(new string[1] { "%20" }, StringSplitOptions.RemoveEmptyEntries))) : new Uri("http://" + text)));
					webView2Window.webView.CoreWebView2.Navigate(uri.ToString());
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning(ex.Message);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool yJ6rQ2WT5vmtQVUq003j()
		{
			return Pl7WiZWTZ947wJG6DiJL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__122 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebView2Window _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object UEph2eWTgJ0TkmQTexaC;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebView2Window webView2Window = _003C_003E4__this;
			try
			{
				try
				{
					CoreWebView2CreationProperties coreWebView2CreationProperties = default(CoreWebView2CreationProperties);
					TaskAwaiter awaiter2 = default(TaskAwaiter);
					string text;
					int num2;
					TaskAwaiter<string> awaiter;
					int num3 = default(int);
					switch (num)
					{
					default:
						coreWebView2CreationProperties = new CoreWebView2CreationProperties
						{
							UserDataFolder = V1kWZri8vrLTHgNDH0k.NoGvS8R8WYG()
						};
						if (!string.IsNullOrEmpty(webView2Window.AdditionalBrowserArguments))
						{
							coreWebView2CreationProperties.AdditionalBrowserArguments = webView2Window.AdditionalBrowserArguments;
							goto IL_00d4;
						}
						goto IL_010e;
					case 0:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						goto IL_03d4;
					case 1:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_04ac;
					case 2:
						goto IL_0576;
						IL_0412:
						if (webView2Window.wqEL88PZLXV)
						{
							webView2Window.EtoL8ja9FNE = new DevtoolsProtocolBridge(webView2Window.webView.CoreWebView2, webView2Window.Context.RootContext.ActionId, webView2Window.DevtoolWhiteList);
							webView2Window.webView.CoreWebView2.AddHostObjectToScript("devtool", webView2Window.EtoL8ja9FNE);
						}
						text = "\r\nwindow.$quickerSync =  window.chrome.webview.hostObjects.sync.v;\r\nwindow.$quicker = window.chrome.webview.hostObjects.v;\r\nwindow.$quickerSp = (spName, dataObj, callback) => {\r\n\tlet dataJson = ((typeof dataObj) === 'string') ? dataObj : JSON.stringify(dataObj);\r\n\tif (!callback) return new Promise((res, rej) => {\r\n\t\t$quicker.subprogram(spName, dataJson, false, (success, resultJson) => {\r\n\t\t\tif (success) res(JSON.parse(resultJson));\r\n\t\t\telse rej(resultJson);\r\n\t\t});\r\n\t});\r\n\telse return Promise.resolve($quicker.subprogram(spName, dataJson, false, (success, dataJson) => {\r\n\t\tcallback(success, JSON.parse(dataJson))\r\n\t}));\r\n};";
						if (webView2Window.wqEL88PZLXV)
						{
							text += "\r\n// 对 devtools protocol bridge 的封装\r\nwindow.$devtool = {\r\n    _bridge: window.chrome.webview.hostObjects.sync.devtool,\r\n    _getGuid () {\r\n        let guid = \"\";\r\n        for (let i = 1; i <= 32; i++) {\r\n            let n = Math.floor(Math.random() * 16.0).toString(16);\r\n            guid += n;\r\n            if ((i === 8) || (i === 12) || (i === 16) || (i === 20))\r\n                guid += \"-\";\r\n        }\r\n        return guid;\r\n    },\r\n    _getResult(callback) {\r\n        // set identifier to random guid\r\n        let identifier = this._getGuid();\r\n        window.chrome.webview.addEventListener(\"message\", (e) => {\r\n            if (e.data.identifier === identifier) {\r\n                callback(e.data.data);\r\n            }\r\n        });\r\n        return identifier;\r\n    },\r\n    run(code, method, dataObj) {\r\n        // if (!Number.isInteger(code))\r\n        //     throw (\"第一个参数应该为整数校验码\");\r\n        dataObj = dataObj || {};\r\n\r\n        let dataJson = ((typeof dataObj) === 'string') ? dataObj : JSON.stringify(dataObj);\r\n        return new Promise((res, rej) => {\r\n            let identifier = this._getResult((data) => {\r\n                // debugger\r\n                let {success, result, error} = data;\r\n                if (success) res(JSON.parse(result));\r\n                else rej(error);\r\n            });\r\n            return this._bridge.Run(code, method, identifier, dataJson);\r\n        });\r\n    },\r\n    on(code, event, handler) {\r\n        // if (!Number.isInteger(code))\r\n        //     throw (\"第一个参数应该为整数校验码\");\r\n        let identifier = this._getResult((data) => {\r\n            handler(JSON.parse(data));\r\n        });\r\n        return this._bridge.On(code, event, identifier);\r\n    },\r\n    off(event, identifier) {\r\n        return this._bridge.Off(event, identifier);\r\n    }\r\n}\r\n";
						}
						awaiter = webView2Window.webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(text).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_04ac;
						IL_010e:
						if (!string.IsNullOrEmpty(webView2Window.ProfileName))
						{
							coreWebView2CreationProperties.ProfileName = webView2Window.ProfileName;
						}
						webView2Window.webView.CreationProperties = coreWebView2CreationProperties;
						awaiter2 = webView2Window.webView.EnsureCoreWebView2Async(null, null).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_00b4;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num2 = 3;
						if (!hf3UeCWTPDNjJWSxxJu2())
						{
							goto IL_00cb;
						}
						goto IL_03e3;
						IL_04ac:
						awaiter.GetResult();
						if (webView2Window.VirtualHostNameToFolderMappingsDict.HasData())
						{
							Dictionary<string, string>.Enumerator enumerator = webView2Window.VirtualHostNameToFolderMappingsDict.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									KeyValuePair<string, string> current = enumerator.Current;
									webView2Window.webView.CoreWebView2.SetVirtualHostNameToFolderMapping(current.Key, current.Value, CoreWebView2HostResourceAccessKind.Allow);
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								}
							}
						}
						if (string.IsNullOrEmpty(webView2Window.ScriptAfterLoaded))
						{
							goto IL_0536;
						}
						awaiter = webView2Window.webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(webView2Window.ScriptAfterLoaded).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_056c;
						IL_0536:
						if (webView2Window.NoActivate)
						{
							webView2Window.SAVLyl6jZFA();
						}
						webView2Window.dc6Ly4hIjhr(webView2Window.Url);
						num2 = 1;
						if (!hf3UeCWTPDNjJWSxxJu2())
						{
							goto IL_00cb;
						}
						goto IL_03e3;
						IL_056c:
						awaiter.GetResult();
						goto IL_0536;
						IL_00b4:
						awaiter2.GetResult();
						num2 = 6;
						if (UEph2eWTgJ0TkmQTexaC != null)
						{
							goto IL_00cb;
						}
						goto IL_03e3;
						IL_03e3:
						while (true)
						{
							switch (num2)
							{
							case 8:
								break;
							case 7:
								goto IL_00d4;
							case 4:
								goto IL_010e;
							case 6:
								goto IL_018e;
							case 5:
								goto IL_03d4;
							case 2:
								goto IL_0412;
							default:
								goto IL_0576;
							case 1:
								webView2Window.IsWebViewReady = true;
								goto end_IL_0013;
							case 3:
								return;
							}
							break;
							IL_018e:
							if (webView2Window.webView.CoreWebView2 != null)
							{
								webView2Window.webView.CoreWebView2.WebMessageReceived += webView2Window.wpVLyM3OTrb;
								webView2Window.webView.CoreWebView2.WindowCloseRequested += webView2Window.s68LyTy6dNW;
								webView2Window.webView.CoreWebView2.NewWindowRequested += webView2Window.R7mLynqG5Fv;
								webView2Window.webView.CoreWebView2.ContainsFullScreenElementChanged += webView2Window.Ga1LyjDHlda;
								webView2Window.webView.CoreWebView2.SourceChanged += webView2Window.CLpLyQ1goOY;
								webView2Window.webView.CoreWebView2.HistoryChanged += webView2Window.AaHLypwCE9o;
								if (webView2Window.webView.CoreWebView2.Profile == null)
								{
									nZ3L8an85XX.Warn("WebView.CoreWebView2.Profile 为NULL");
								}
								else
								{
									webView2Window.webView.CoreWebView2.Profile.PreferredColorScheme = CoreWebView2PreferredColorScheme.Auto;
									if (!string.IsNullOrEmpty(webView2Window.DefaultDownloadFolderPath))
									{
										webView2Window.webView.CoreWebView2.Profile.DefaultDownloadFolderPath = webView2Window.DefaultDownloadFolderPath;
									}
								}
								if (string.IsNullOrEmpty(webView2Window.IconStr))
								{
									webView2Window.webView.CoreWebView2.FaviconChanged += webView2Window.a2pLyBf6FMO;
								}
								webView2Window.webView.NavigationCompleted += webView2Window.PUaLyDO1x18;
								webView2Window.webView.NavigationStarting += webView2Window.cfmLy5h9Yyw;
								webView2Window.webView.KeyDown += webView2Window.gQaLyoos3uE;
								if (!string.IsNullOrEmpty(webView2Window.UserAgent))
								{
									webView2Window.webView.CoreWebView2.Settings.UserAgent = webView2Window.UserAgent;
								}
								if (webView2Window.DefaultBgColor.HasValue)
								{
									webView2Window.webView.DefaultBackgroundColor = webView2Window.DefaultBgColor.Value;
								}
								webView2Window.XJuL8YkMXTX = new QuickerWebViewBridge(webView2Window.Context, webView2Window.Action, webView2Window);
								webView2Window.webView.CoreWebView2.AddHostObjectToScript("v", webView2Window.XJuL8YkMXTX);
								num2 = 2;
								if (hf3UeCWTPDNjJWSxxJu2())
								{
									continue;
								}
								goto IL_00cb;
							}
							AppHelper.ShowWarning("无法启动WebView组件。\r\n如果您尚未安装，请先安装该组件。\r\n如果您刚安装了组件，请重启电脑后再试。", true);
							goto end_IL_0013;
						}
						goto IL_00b4;
						IL_0576:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_056c;
						IL_03d4:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00b4;
						IL_00d4:
						if (!(webView2Window.AdditionalBrowserArguments != " --enable-features=msWebView2EnableDraggableRegions"))
						{
							goto IL_010e;
						}
						coreWebView2CreationProperties.UserDataFolder = V1kWZri8vrLTHgNDH0k.rBBvS7i0YGN(webView2Window.AdditionalBrowserArguments);
						num2 = 4;
						if (hf3UeCWTPDNjJWSxxJu2())
						{
							goto IL_03e3;
						}
						goto IL_0412;
						IL_00cb:
						num2 = num3;
						goto IL_03e3;
						end_IL_0013:
						break;
					}
				}
				catch (Exception exception)
				{
					nZ3L8an85XX.Error("初始化WebView2组件失败。", exception);
					AppHelper.ShowWarning("无法初始化WebView2组件，最低需要Edge 87版本。\r\n" + exception.GetMessageWithInner(), true);
					AppHelper.RunOnUiThread(false, webView2Window.H91L80DTL3e);
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool hf3UeCWTPDNjJWSxxJu2()
		{
			return UEph2eWTgJ0TkmQTexaC == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnClosed_003Ed__141 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebView2Window _003C_003E4__this;

		private TaskAwaiter<List<CoreWebView2Cookie>> _003C_003Eu__1;

		private static object CsQYimWTIDkj82tNgp70;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebView2Window webView2Window = _003C_003E4__this;
			try
			{
				if (num == 0 || webView2Window.ClearCookies)
				{
					try
					{
						TaskAwaiter<List<CoreWebView2Cookie>> awaiter;
						if (num != 0)
						{
							string uri = webView2Window.webView.Source.ToString();
							awaiter = webView2Window.webView.CoreWebView2.CookieManager.GetCookiesAsync(uri).GetAwaiter();
							if (xBDeV5WT6vnEbos2wlJu())
							{
								switch (0)
								{
								}
							}
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<CoreWebView2Cookie>>);
							num = -1;
							_003C_003E1__state = -1;
						}
						List<CoreWebView2Cookie>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CoreWebView2Cookie current = enumerator.Current;
								webView2Window.webView.CoreWebView2.CookieManager.DeleteCookie(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						nZ3L8an85XX.Warn("删除cookie出错：" + ex.Message, ex);
						AppHelper.ShowWarning("删除cookie出错：" + ex.Message);
					}
				}
				try
				{
					if (!AppState.sD1t7gME9aw())
					{
						webView2Window.zXmLyrpPTEK();
						webView2Window.webView.Dispose();
					}
				}
				catch (Exception ex2)
				{
					nZ3L8an85XX.Warn("释放WebView2出错：" + ex2.Message, ex2);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool xBDeV5WT6vnEbos2wlJu()
		{
			return CsQYimWTIDkj82tNgp70 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		internal static object cmQEG9WTmZKvylDvUhjT;

		private void MoveNext()
		{
			try
			{
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003COnLoaded_003Ed__120()
		{
		}

		internal static bool nsNM7HWTs5mPtAovc12n()
		{
			return cmQEG9WTmZKvylDvUhjT == null;
		}

		internal static void Too2yxWT7eeX4EP8bfSt()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnWindowClosing_003Ed__114 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebView2Window _003C_003E4__this;

		private static object vqrO6XWT4T2aPry3Gn3e;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebView2Window webView2Window = _003C_003E4__this;
			try
			{
				webView2Window.Deactivated -= webView2Window.WPpLyObYdv5;
				if (webView2Window.OwnedWindows.Count > 0)
				{
					IEnumerator enumerator = webView2Window.OwnedWindows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							System.Windows.Window window = (System.Windows.Window)enumerator.Current;
							try
							{
								window.Close();
							}
							catch (Exception ex)
							{
								nZ3L8an85XX.Warn("关闭子窗口出错：" + ex.Message);
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool LNgEIjWThk8On3gEguQW()
		{
			return vqrO6XWT4T2aPry3Gn3e == null;
		}
	}

	private readonly bool wqEL88PZLXV;

	private static readonly ILog nZ3L8an85XX;

	public static readonly DependencyProperty ShowToolbarProperty;

	[CompilerGenerated]
	private string dltL87C48xm;

	[CompilerGenerated]
	private ShowWindowLocation YQeL8Ronwno = ShowWindowLocation.CenterScreen;

	[CompilerGenerated]
	private string zh8L8qg3a64;

	[CompilerGenerated]
	private string GCdL8cndvSH;

	[CompilerGenerated]
	private bool iCEL8VQ1H8P;

	[CompilerGenerated]
	private string BlvL8ZagnXU;

	[CompilerGenerated]
	private ActionExecuteContext jcPL89lkt2n;

	[CompilerGenerated]
	private XAction xU3L8hl2Yur;

	[CompilerGenerated]
	private string IaJL8ecT35f;

	private QuickerWebViewBridge XJuL8YkMXTX;

	[CompilerGenerated]
	private bool OrQL8I5tQPm;

	[CompilerGenerated]
	private string ad7L8WmkhRY = "";

	[CompilerGenerated]
	private string a1BL8kaYbNN = "";

	[CompilerGenerated]
	private bool piJL8Gy3CQp;

	[CompilerGenerated]
	private bool jTFL8siBIda;

	[CompilerGenerated]
	private Dictionary<string, string> pSkL8HcusXM;

	[CompilerGenerated]
	private string r43L81mPU1b;

	[CompilerGenerated]
	private bool vCHL8bNdrGf;

	private WindowLocationRecorder AcYL868VZPV;

	[CompilerGenerated]
	private IList<string> LMSL8XBsARh = new List<string>();

	[CompilerGenerated]
	private string KwRL8m6Xo6A;

	[CompilerGenerated]
	private Color? BwIL8KeBXek;

	[CompilerGenerated]
	private bool OvjL8xbmbeu;

	[CompilerGenerated]
	private bool fq0L8rPpumF;

	[CompilerGenerated]
	private string IeDL8pavKRQ;

	[CompilerGenerated]
	private string tEuL8BOvycL;

	[CompilerGenerated]
	private string xpcL8Q7fj3x;

	private DevtoolsProtocolBridge EtoL8ja9FNE;

	private bool T1wL8nXGwBl = true;

	private bool e2wL84VpptZ;

	[CompilerGenerated]
	private CancellationTokenRegistration? tieL85P1Nwh;

	internal WebView2Window TheWindow;

	internal System.Windows.Controls.TextBox url;

	internal Grid Layout;

	internal WebView2 webView;

	private bool UNwL8D0OZJ8;

	internal static WebView2Window KHtfNsFG6YtyCoAtYBWi;

	public bool ShowToolbar
	{
		get
		{
			return (bool)GetValue(ShowToolbarProperty);
		}
		set
		{
			SetValue(ShowToolbarProperty, value);
		}
	}

	public string AutoCloseKey
	{
		[CompilerGenerated]
		get
		{
			return dltL87C48xm;
		}
		[CompilerGenerated]
		set
		{
			dltL87C48xm = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return YQeL8Ronwno;
		}
		[CompilerGenerated]
		set
		{
			YQeL8Ronwno = value;
		}
	}

	public string WindowSizeStr
	{
		[CompilerGenerated]
		get
		{
			return zh8L8qg3a64;
		}
		[CompilerGenerated]
		set
		{
			zh8L8qg3a64 = value;
		}
	}

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return GCdL8cndvSH;
		}
		[CompilerGenerated]
		set
		{
			GCdL8cndvSH = value;
		}
	}

	public bool PresetTitle
	{
		[CompilerGenerated]
		get
		{
			return iCEL8VQ1H8P;
		}
		[CompilerGenerated]
		set
		{
			iCEL8VQ1H8P = value;
		}
	}

	public string CloseWhenLostFocus
	{
		[CompilerGenerated]
		get
		{
			return BlvL8ZagnXU;
		}
		[CompilerGenerated]
		set
		{
			BlvL8ZagnXU = value;
		}
	}

	public ActionExecuteContext Context
	{
		[CompilerGenerated]
		get
		{
			return jcPL89lkt2n;
		}
		[CompilerGenerated]
		set
		{
			jcPL89lkt2n = value;
		}
	}

	public XAction Action
	{
		[CompilerGenerated]
		get
		{
			return xU3L8hl2Yur;
		}
		[CompilerGenerated]
		set
		{
			xU3L8hl2Yur = value;
		}
	}

	public string ScriptAfterLoaded
	{
		[CompilerGenerated]
		get
		{
			return IaJL8ecT35f;
		}
		[CompilerGenerated]
		set
		{
			IaJL8ecT35f = value;
		}
	}

	public bool IsNavigationCompleted
	{
		[CompilerGenerated]
		get
		{
			return OrQL8I5tQPm;
		}
		[CompilerGenerated]
		private set
		{
			OrQL8I5tQPm = value;
		}
	}

	public string DocTitle
	{
		[CompilerGenerated]
		get
		{
			return ad7L8WmkhRY;
		}
		[CompilerGenerated]
		set
		{
			ad7L8WmkhRY = value;
		}
	}

	public string CurrentUri
	{
		[CompilerGenerated]
		get
		{
			return a1BL8kaYbNN;
		}
		[CompilerGenerated]
		private set
		{
			a1BL8kaYbNN = value;
		}
	}

	public bool SetTopmost
	{
		[CompilerGenerated]
		get
		{
			return piJL8Gy3CQp;
		}
		[CompilerGenerated]
		set
		{
			piJL8Gy3CQp = value;
		}
	}

	public bool NoActivate
	{
		[CompilerGenerated]
		get
		{
			return jTFL8siBIda;
		}
		[CompilerGenerated]
		set
		{
			jTFL8siBIda = value;
		}
	}

	public Dictionary<string, string> VirtualHostNameToFolderMappingsDict
	{
		[CompilerGenerated]
		get
		{
			return pSkL8HcusXM;
		}
		[CompilerGenerated]
		set
		{
			pSkL8HcusXM = value;
		}
	}

	public WebView2 WebView2 => webView;

	public string IconStr
	{
		[CompilerGenerated]
		get
		{
			return r43L81mPU1b;
		}
		[CompilerGenerated]
		set
		{
			r43L81mPU1b = value;
		}
	}

	public bool EscClose
	{
		[CompilerGenerated]
		get
		{
			return vCHL8bNdrGf;
		}
		[CompilerGenerated]
		set
		{
			vCHL8bNdrGf = value;
		}
	}

	public IList<string> DevtoolWhiteList
	{
		[CompilerGenerated]
		get
		{
			return LMSL8XBsARh;
		}
		[CompilerGenerated]
		set
		{
			LMSL8XBsARh = value;
		}
	}

	public string UserAgent
	{
		[CompilerGenerated]
		get
		{
			return KwRL8m6Xo6A;
		}
		[CompilerGenerated]
		set
		{
			KwRL8m6Xo6A = value;
		}
	}

	public Color? DefaultBgColor
	{
		[CompilerGenerated]
		get
		{
			return BwIL8KeBXek;
		}
		[CompilerGenerated]
		set
		{
			BwIL8KeBXek = value;
		}
	}

	public bool IsWebViewReady
	{
		[CompilerGenerated]
		get
		{
			return OvjL8xbmbeu;
		}
		[CompilerGenerated]
		private set
		{
			OvjL8xbmbeu = value;
		}
	}

	public bool ClearCookies
	{
		[CompilerGenerated]
		get
		{
			return fq0L8rPpumF;
		}
		[CompilerGenerated]
		set
		{
			fq0L8rPpumF = value;
		}
	}

	public string DefaultDownloadFolderPath
	{
		[CompilerGenerated]
		get
		{
			return IeDL8pavKRQ;
		}
		[CompilerGenerated]
		set
		{
			IeDL8pavKRQ = value;
		}
	}

	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return tEuL8BOvycL;
		}
		[CompilerGenerated]
		set
		{
			tEuL8BOvycL = value;
		}
	}

	public string AdditionalBrowserArguments
	{
		[CompilerGenerated]
		get
		{
			return xpcL8Q7fj3x;
		}
		[CompilerGenerated]
		set
		{
			xpcL8Q7fj3x = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return tieL85P1Nwh;
		}
		[CompilerGenerated]
		set
		{
			tieL85P1Nwh = value;
		}
	}

	public string GetLastLocation()
	{
		WindowLocationRecorder acYL868VZPV = AcYL868VZPV;
		object obj;
		if (acYL868VZPV != null)
		{
			obj = acYL868VZPV.GetLastLocation();
			if (obj != null)
			{
				goto IL_001b;
			}
		}
		else
		{
			obj = null;
		}
		obj = "";
		goto IL_001b;
		IL_001b:
		return (string)obj;
	}

	public string GetSourceCode()
	{
		_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
		_003C_003Ec__DisplayClass111_.KenSDw5yjF5 = this;
		_003C_003Ec__DisplayClass111_.pkpSDtox84Y = "";
		_003C_003Ec__DisplayClass111_.PSrSDglgqEb = new AutoResetEvent(false);
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass111_.jQFS5zJ73Uy);
		if (_003C_003Ec__DisplayClass111_.PSrSDglgqEb.WaitOne(1000))
		{
			return _003C_003Ec__DisplayClass111_.pkpSDtox84Y;
		}
		return "错误：无法获得结果。";
	}

	public string GetCookies()
	{
		_003C_003Ec__DisplayClass112_0 _003C_003Ec__DisplayClass112_ = new _003C_003Ec__DisplayClass112_0();
		_003C_003Ec__DisplayClass112_.cNkSDvM2fgA = this;
		_003C_003Ec__DisplayClass112_.LCqSDSOJHAw = "";
		_003C_003Ec__DisplayClass112_.xiwSD2ahjpk = new AutoResetEvent(false);
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass112_.zl5SDLA2HbB);
		if (_003C_003Ec__DisplayClass112_.xiwSD2ahjpk.WaitOne(1000))
		{
			return _003C_003Ec__DisplayClass112_.LCqSDSOJHAw;
		}
		return "错误：无法获得结果。";
	}

	public WebView2Window(bool addDevToolBridge, string additionalBrowserArguments, string profileName)
	{
		wqEL88PZLXV = addDevToolBridge;
		AdditionalBrowserArguments = additionalBrowserArguments;
		ProfileName = profileName;
		InitializeComponent();
		base.SourceInitialized += vOYLymC5exC;
		base.Loaded += yiFLyK82ObU;
		base.Deactivated += WPpLyObYdv5;
		base.Activated += vJ7LyXW43rq;
		base.StateChanged += o0XLy1huQeC;
		base.Closing += oI3LyH0ZokB;
		base.Closed += dmrLyA0ZaWJ;
		base.PreviewKeyDown += JfCLy6PbjOp;
		AcYL868VZPV = new WindowLocationRecorder(this);
		cpxLybxbcGH(true);
		JoWLyxtUwF7();
	}

	[AsyncStateMachine(typeof(_003COnWindowClosing_003Ed__114))]
	private void oI3LyH0ZokB(object sender, CancelEventArgs e)
	{
		_003COnWindowClosing_003Ed__114 stateMachine = default(_003COnWindowClosing_003Ed__114);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void o0XLy1huQeC(object sender, EventArgs e)
	{
		if (base.WindowState == WindowState.Maximized)
		{
			cpxLybxbcGH(false);
		}
		else
		{
			cpxLybxbcGH(true);
		}
		if (base.WindowState != WindowState.Minimized)
		{
			WebView2.Focus();
		}
	}

	private void cpxLybxbcGH(bool bool_11)
	{
		WindowChrome windowChrome = WindowChrome.GetWindowChrome(this);
		if (bool_11)
		{
			windowChrome.ResizeBorderThickness = new Thickness(5.0);
			windowChrome.NonClientFrameEdges = NonClientFrameEdges.Left | NonClientFrameEdges.Right | NonClientFrameEdges.Bottom;
			Layout.Margin = new Thickness(2.0, 0.0, 2.0, 2.0);
		}
		else
		{
			windowChrome.ResizeBorderThickness = new Thickness(0.0);
			windowChrome.NonClientFrameEdges = NonClientFrameEdges.None;
			Layout.Margin = new Thickness(0.0);
		}
	}

	private void JfCLy6PbjOp(object sender, KeyEventArgs e)
	{
		if (EscClose && e.Key == Key.Escape)
		{
			Close();
			e.Handled = true;
		}
	}

	private void vJ7LyXW43rq(object sender, EventArgs e)
	{
	}

	private void vOYLymC5exC(object sender, EventArgs e)
	{
		SAVLyl6jZFA();
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false, false);
		Fa9Lyi8ghGM("after OnSourceInitialized");
		if (!string.IsNullOrEmpty(IconStr))
		{
			AppHelper.SetWindowIcon(this, IconStr, false);
		}
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__120))]
	private void yiFLyK82ObU(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__120 stateMachine = default(_003COnLoaded_003Ed__120);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__122))]
	private void JoWLyxtUwF7()
	{
		_003CInitializeAsync_003Ed__122 stateMachine = default(_003CInitializeAsync_003Ed__122);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void zXmLyrpPTEK()
	{
		webView.CoreWebView2InitializationCompleted -= mO3Ly3G7Tai;
		webView.CoreWebView2.WebMessageReceived -= wpVLyM3OTrb;
		webView.CoreWebView2.WindowCloseRequested -= s68LyTy6dNW;
		webView.CoreWebView2.NewWindowRequested -= R7mLynqG5Fv;
		webView.CoreWebView2.ContainsFullScreenElementChanged -= Ga1LyjDHlda;
		webView.CoreWebView2.SourceChanged -= CLpLyQ1goOY;
		webView.CoreWebView2.HistoryChanged -= AaHLypwCE9o;
		webView.CoreWebView2.FaviconChanged -= a2pLyBf6FMO;
		webView.NavigationCompleted -= PUaLyDO1x18;
		webView.NavigationStarting -= cfmLy5h9Yyw;
		webView.CoreWebView2.DocumentTitleChanged -= YVILyfREqnS;
		webView.KeyDown -= gQaLyoos3uE;
		webView.CoreWebView2.RemoveHostObjectFromScript("v");
		if (wqEL88PZLXV)
		{
			webView.CoreWebView2.RemoveHostObjectFromScript("devtool");
			int num = 0;
			if (KHtfNsFG6YtyCoAtYBWi != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void AaHLypwCE9o(object object_0, object object_1)
	{
		sUnLydAdkJV();
	}

	[AsyncStateMachine(typeof(_003CCoreWebView2OnFaviconChanged_003Ed__126))]
	private void a2pLyBf6FMO(object object_0, object object_1)
	{
		_003CCoreWebView2OnFaviconChanged_003Ed__126 stateMachine = default(_003CCoreWebView2OnFaviconChanged_003Ed__126);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void CLpLyQ1goOY(object sender, CoreWebView2SourceChangedEventArgs e)
	{
		CurrentUri = webView.CoreWebView2.Source;
	}

	private void Ga1LyjDHlda(object object_0, object object_1)
	{
		if (webView.CoreWebView2.ContainsFullScreenElement)
		{
			base.WindowState = WindowState.Maximized;
			base.WindowStyle = WindowStyle.None;
			base.ResizeMode = ResizeMode.NoResize;
		}
		else
		{
			base.WindowState = WindowState.Normal;
			base.WindowStyle = WindowStyle.SingleBorderWindow;
			base.ResizeMode = ResizeMode.CanResize;
		}
	}

	private void R7mLynqG5Fv(object sender, CoreWebView2NewWindowRequestedEventArgs e)
	{
		if (e.Uri.StartsWith("http", StringComparison.OrdinalIgnoreCase) && e.Uri.IndexOf("ext=true", StringComparison.OrdinalIgnoreCase) > 0)
		{
			e.Handled = true;
			AppHelper.TryOpenUrlOrFile(e.Uri);
		}
	}

	private void dc6Ly4hIjhr(string string_12)
	{
		if (string.IsNullOrEmpty(string_12))
		{
			return;
		}
		IsNavigationCompleted = false;
		if (!string_12.Contains("\n") && (Uri.IsWellFormedUriString(string_12, UriKind.Absolute) || string_12.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || string_12.StartsWith("https://", StringComparison.OrdinalIgnoreCase) || File.Exists(string_12)))
		{
			webView.CoreWebView2.Navigate(string_12);
			return;
		}
		webView.CoreWebView2.NavigateToString(string_12);
		int num = 0;
		if (!CDc7qjFGtT72mWWfo297())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void cfmLy5h9Yyw(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		e2wL84VpptZ = true;
		IsNavigationCompleted = false;
		sUnLydAdkJV();
	}

	private void PUaLyDO1x18(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		if (base.IsLoaded)
		{
			e2wL84VpptZ = false;
			IsNavigationCompleted = true;
			if (T1wL8nXGwBl)
			{
				AppHelper.RunOnUiThread(false, L2DL8CWo3VH);
			}
			T1wL8nXGwBl = false;
			sUnLydAdkJV();
		}
	}

	private void sUnLydAdkJV()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	private void gQaLyoos3uE(object sender, KeyEventArgs e)
	{
		if (e.IsRepeat)
		{
			return;
		}
		bool flag = e.KeyboardDevice.IsKeyDown(Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(Key.RightCtrl);
		if (!CDc7qjFGtT72mWWfo297())
		{
			switch (0)
			{
			}
		}
		bool flag2 = e.KeyboardDevice.IsKeyDown(Key.LeftAlt) || e.KeyboardDevice.IsKeyDown(Key.RightAlt);
		bool flag3 = e.KeyboardDevice.IsKeyDown(Key.LeftShift) || e.KeyboardDevice.IsKeyDown(Key.RightShift);
		if (e.Key == Key.W && flag && !flag2 && !flag3)
		{
			Close();
			e.Handled = true;
		}
	}

	private void s68LyTy6dNW(object object_0, object object_1)
	{
		Close();
	}

	public void PostMessage(string messageAsJson)
	{
		webView.CoreWebView2?.PostWebMessageAsJson(messageAsJson);
	}

	public string ExecuteScript(string script)
	{
		_003C_003Ec__DisplayClass139_0 _003C_003Ec__DisplayClass139_ = new _003C_003Ec__DisplayClass139_0();
		_003C_003Ec__DisplayClass139_.QiUSDNn7GmM = this;
		_003C_003Ec__DisplayClass139_.tKNSD0LmpmP = script;
		_003C_003Ec__DisplayClass139_.FS3SDJsk7vk = null;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass139_.niqSDuQi9ru);
		_003C_003Ec__DisplayClass139_.FS3SDJsk7vk.Wait();
		return _003C_003Ec__DisplayClass139_.FS3SDJsk7vk.Result;
	}

	private void wpVLyM3OTrb(object sender, CoreWebView2WebMessageReceivedEventArgs e)
	{
		try
		{
			JObject jObject = JObject.Parse(e.WebMessageAsJson);
			string text = jObject["op"]?.Value<string>();
			if (text == "setVar")
			{
				string text2 = jObject.SelectToken("data.name")?.Value<string>();
				string text3 = jObject.SelectToken("data.value")?.Value<string>();
				if (text2 != null && text3 != null)
				{
					XActionHelper.OutputResultToVariable(text2, text3, Context, Action);
				}
				else
				{
					AppHelper.ShowWarning("参数或值为空!");
				}
			}
			else if (text == "close")
			{
				Close();
				int num = 0;
				if (!CDc7qjFGtT72mWWfo297())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		catch (Exception ex)
		{
			nZ3L8an85XX.Warn("处理网页消息出错：" + ex.Message + " 消息内容：" + e.WebMessageAsJson, ex);
			AppHelper.ShowWarning("处理网页消息出错：" + ex.Message);
		}
	}

	[AsyncStateMachine(typeof(_003COnClosed_003Ed__141))]
	private void dmrLyA0ZaWJ(object sender, EventArgs e)
	{
		_003COnClosed_003Ed__141 stateMachine = default(_003COnClosed_003Ed__141);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void WPpLyObYdv5(object sender, EventArgs e)
	{
		string text = CloseWhenLostFocus?.ToLower();
		if (text == null)
		{
			return;
		}
		int num2 = default(int);
		while (true)
		{
			int num;
			switch (text.Length)
			{
			case 4:
			{
				char c = text[0];
				if (c == 'h')
				{
					if (text == "hide" && base.IsLoaded && base.OwnedWindows.Count == 0)
					{
						num = 0;
						if (!CDc7qjFGtT72mWWfo297())
						{
							goto IL_006e;
						}
						goto IL_0072;
					}
					return;
				}
				if (c == 't')
				{
					goto IL_01f9;
				}
				return;
			}
			case 19:
				if (text == "hide_if_not_topmost" && base.IsLoaded && base.OwnedWindows.Count == 0 && !base.Topmost)
				{
					Hide();
					num = 1;
					if (!CDc7qjFGtT72mWWfo297())
					{
						goto IL_006e;
					}
					goto IL_0072;
				}
				return;
			case 20:
				if (text == "close_if_not_topmost" && base.IsLoaded && base.OwnedWindows.Count == 0 && !base.Topmost)
				{
					rnRLyF6y1Os();
				}
				return;
			case 23:
				if (text == "minimize_if_not_topmost" && base.IsLoaded && base.OwnedWindows.Count == 0 && !base.Topmost)
				{
					base.WindowState = WindowState.Minimized;
				}
				return;
			case 8:
				if (text == "minimize" && base.IsLoaded && base.OwnedWindows.Count == 0)
				{
					base.WindowState = WindowState.Minimized;
				}
				return;
			case 1:
				if (!(text == "1"))
				{
					return;
				}
				goto IL_0217;
			case 5:
				if (!(text == "close"))
				{
					return;
				}
				goto IL_0217;
			default:
				return;
				IL_006e:
				num = num2;
				goto IL_0072;
				IL_0072:
				switch (num)
				{
				case 2:
					goto end_IL_0110;
				default:
					Hide();
					return;
				case 1:
					return;
				case 3:
					break;
				}
				goto IL_01f9;
				IL_01f9:
				if (!(text == "true"))
				{
					return;
				}
				goto IL_0217;
				IL_0217:
				if (base.IsLoaded && base.OwnedWindows.Count == 0)
				{
					rnRLyF6y1Os();
				}
				return;
				end_IL_0110:
				break;
			}
		}
	}

	private void rnRLyF6y1Os()
	{
		try
		{
			Close();
		}
		catch (Exception ex)
		{
			nZ3L8an85XX.Warn("关闭窗口出错：" + ex.Message, ex);
		}
	}

	public void UpdateUrl(string url)
	{
		dc6Ly4hIjhr(url);
	}

	public void Reload()
	{
		try
		{
			webView.Reload();
		}
		catch (Exception ex)
		{
			nZ3L8an85XX.Warn(ex.Message, ex);
		}
	}

	public void Stop()
	{
		webView.Stop();
	}

	public Bitmap CapturePreview()
	{
		_003C_003Ec__DisplayClass147_0 _003C_003Ec__DisplayClass147_ = new _003C_003Ec__DisplayClass147_0();
		_003C_003Ec__DisplayClass147_.XrZSDPGRn9y = this;
		_003C_003Ec__DisplayClass147_.Gy5SDEMdcoy = new MemoryStream();
		try
		{
			_003C_003Ec__DisplayClass147_.d0xSD8xlfqL = null;
			_003C_003Ec__DisplayClass147_.KoESDyW7IjY = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass147_.c75SDCC1DWS);
			int num3;
			if (_003C_003Ec__DisplayClass147_.d0xSD8xlfqL != null)
			{
				int num = 0;
				if (KHtfNsFG6YtyCoAtYBWi != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				num3 = (_003C_003Ec__DisplayClass147_.d0xSD8xlfqL.Wait(2000) ? 1 : 0);
			}
			else
			{
				num3 = 0;
			}
			if (_003C_003Ec__DisplayClass147_.KoESDyW7IjY != null)
			{
				throw _003C_003Ec__DisplayClass147_.KoESDyW7IjY;
			}
			if (num3 != 0)
			{
				return new Bitmap(_003C_003Ec__DisplayClass147_.Gy5SDEMdcoy);
			}
			return null;
		}
		finally
		{
			if (_003C_003Ec__DisplayClass147_.Gy5SDEMdcoy != null)
			{
				((IDisposable)_003C_003Ec__DisplayClass147_.Gy5SDEMdcoy).Dispose();
			}
		}
	}

	public void UpdateUrlAndPosition(string url, ShowWindowLocation location, string winsizeStr)
	{
		dc6Ly4hIjhr(url);
		Location = location;
		WindowSizeStr = winsizeStr;
		csKLyUDtjHL();
	}

	public void SetNoActivate(bool noActivate)
	{
		NoActivate = noActivate;
		SAVLyl6jZFA();
	}

	private void csKLyUDtjHL()
	{
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false, false);
	}

	private void SAVLyl6jZFA()
	{
		if (NoActivate)
		{
			NativeMethods.SetWindowNoActivate(this);
			webView.Focusable = false;
			NativeMethods.SetWindowNoActivate(webView.Handle);
			NativeMethods.SetWindowNoActivate(NativeMethods.GetWindow(webView.Handle, NativeMethods.GetWindowType.GW_CHILD));
			return;
		}
		NativeMethods.UnsetWindowNoActivate(this);
		webView.Focusable = true;
		NativeMethods.UnsetWindowNoActivate(webView.Handle);
		int num = 0;
		if (!CDc7qjFGtT72mWWfo297())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		NativeMethods.UnsetWindowNoActivate(NativeMethods.GetWindow(webView.Handle, NativeMethods.GetWindowType.GW_CHILD));
	}

	private void Fa9Lyi8ghGM(string string_12)
	{
		NativeMethods.GetWindowLong(this.GetHandle(), -20);
	}

	private void mO3Ly3G7Tai(object sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			if (NoActivate)
			{
				SAVLyl6jZFA();
			}
			webView.CoreWebView2.DocumentTitleChanged += YVILyfREqnS;
		}
		else
		{
			MessageBoxHelper.Show(this, $"WebView2 创建出错： {e.InitializationException}");
		}
	}

	private void YVILyfREqnS(object object_0, object object_1)
	{
		if (!PresetTitle)
		{
			base.Title = webView.CoreWebView2.DocumentTitle;
		}
		DocTitle = webView.CoreWebView2.DocumentTitle;
	}

	private void Ei0LyzkUiYR(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoBack;
	}

	private void lTCL8w2OUQd(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoBack();
	}

	private void vspL8tVxd1p(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoForward;
	}

	private void VcpL8gr1sgh(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoForward();
	}

	private void qgTL8LjN0HE(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = vKQL8uxtUUb() && !e2wL84VpptZ;
	}

	private void exyL8vNa6R2(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Reload();
	}

	private void S1QL8SDiekt(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = vKQL8uxtUUb() && e2wL84VpptZ;
	}

	private void v57L82bFw7P(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Stop();
	}

	private bool vKQL8uxtUUb()
	{
		try
		{
			return webView != null && webView.CoreWebView2 != null;
		}
		catch (Exception ex) when (ex is ObjectDisposedException || ex is InvalidOperationException)
		{
			return false;
		}
	}

	private void KvsL8N35BOl(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && !e2wL84VpptZ;
	}

	[AsyncStateMachine(typeof(_003CGoToPageCmdExecuted_003Ed__165))]
	private void hJXL8JpelHp(object sender, ExecutedRoutedEventArgs e)
	{
		_003CGoToPageCmdExecuted_003Ed__165 stateMachine = default(_003CGoToPageCmdExecuted_003Ed__165);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!UNwL8D0OZJ8)
		{
			UNwL8D0OZJ8 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/webview2window.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			UNwL8D0OZJ8 = true;
			break;
		case 1:
			TheWindow = (WebView2Window)target;
			break;
		case 2:
			((CommandBinding)target).CanExecute += Ei0LyzkUiYR;
			((CommandBinding)target).Executed += lTCL8w2OUQd;
			num = 1;
			if (!CDc7qjFGtT72mWWfo297())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_013b;
		case 3:
			((CommandBinding)target).CanExecute += vspL8tVxd1p;
			((CommandBinding)target).Executed += VcpL8gr1sgh;
			break;
		case 4:
			((CommandBinding)target).CanExecute += qgTL8LjN0HE;
			((CommandBinding)target).Executed += exyL8vNa6R2;
			break;
		case 5:
			((CommandBinding)target).CanExecute += S1QL8SDiekt;
			((CommandBinding)target).Executed += v57L82bFw7P;
			break;
		case 6:
			((CommandBinding)target).CanExecute += KvsL8N35BOl;
			num = 0;
			if (CDc7qjFGtT72mWWfo297())
			{
				goto IL_013b;
			}
			goto IL_0148;
		case 7:
			url = (System.Windows.Controls.TextBox)target;
			break;
		case 8:
			Layout = (Grid)target;
			break;
		case 9:
			{
				webView = (WebView2)target;
				webView.CoreWebView2InitializationCompleted += mO3Ly3G7Tai;
				break;
			}
			IL_013b:
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_0148;
			IL_0148:
			((CommandBinding)target).Executed += hJXL8JpelHp;
			break;
		}
	}

	static WebView2Window()
	{
		nZ3L8an85XX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ShowToolbarProperty = DependencyProperty.Register("ShowToolbar", typeof(bool), typeof(WebView2Window), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	private void H91L80DTL3e()
	{
		try
		{
			Close();
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void L2DL8CWo3VH()
	{
		try
		{
			if (SetTopmost)
			{
				base.Topmost = true;
			}
			if (!NoActivate && base.IsLoaded && webView.IsLoaded)
			{
				webView.Focus();
			}
		}
		catch (Exception)
		{
			nZ3L8an85XX.Warn("设置焦点失败。");
		}
	}

	internal static bool CDc7qjFGtT72mWWfo297()
	{
		return KHtfNsFG6YtyCoAtYBWi == null;
	}
}
