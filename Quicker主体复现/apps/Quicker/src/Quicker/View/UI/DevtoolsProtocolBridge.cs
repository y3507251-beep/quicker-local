using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;

namespace Quicker.View.UI;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDual)]
public class DevtoolsProtocolBridge
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec XjWS5wqtvys;

		public static Func<string, string> rZBS5tGg8uW;

		internal static _003C_003Ec RuHniBWwdNQ4Zv7dBFLJ;

		static _003C_003Ec()
		{
			XjWS5wqtvys = new _003C_003Ec();
		}

		internal string sRLS4zeuEdM(string x)
		{
			return x.Trim();
		}

		internal static bool z9lEQnWwOre0pZ5vpRnr()
		{
			return RuHniBWwdNQ4Zv7dBFLJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public DevtoolsProtocolBridge rTlS5LRBon4;

		public string FktS5v1ABi4;

		private static _003C_003Ec__DisplayClass8_0 qnbg7XWwaEiHhEeC8alA;

		internal void WKHS5gQbVjA(object sender, CoreWebView2DevToolsProtocolEventReceivedEventArgs e)
		{
			rTlS5LRBon4.cTbLEysAhHl(FktS5v1ABi4, e.ParameterObjectAsJson);
		}

		internal static bool NMDeFeWwrNDlB8pR9jGl()
		{
			return qnbg7XWwaEiHhEeC8alA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRun_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DevtoolsProtocolBridge _003C_003E4__this;

		public string checkCode;

		public string methodName;

		public string identifier;

		public string paramAsJson;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object rbSQRIWwL3rs5TPksp9b;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DevtoolsProtocolBridge devtoolsProtocolBridge = _003C_003E4__this;
			try
			{
				if (num != 0 && !devtoolsProtocolBridge.check(checkCode, methodName, out var errorMessage))
				{
					devtoolsProtocolBridge.cTbLEysAhHl(identifier, new _003C_003Ef__AnonymousType51<bool, string>(false, errorMessage));
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						if (!UwlfP6WwuMbX2FmCDkO7())
						{
							switch (0)
							{
							}
						}
						awaiter = devtoolsProtocolBridge.CmoLE8tt6to.CallDevToolsProtocolMethodAsync(methodName, paramAsJson).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result = awaiter.GetResult();
					devtoolsProtocolBridge.cTbLEysAhHl(identifier, new _003C_003Ef__AnonymousType52<bool, string>(true, result));
				}
				catch (Exception ex)
				{
					devtoolsProtocolBridge.cTbLEysAhHl(identifier, new _003C_003Ef__AnonymousType53<bool, _003C_003Ef__AnonymousType54<string, string>>(false, new _003C_003Ef__AnonymousType54<string, string>(ex.Message, ex.StackTrace)));
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

		internal static bool UwlfP6WwuMbX2FmCDkO7()
		{
			return rbSQRIWwL3rs5TPksp9b == null;
		}
	}

	private CoreWebView2 CmoLE8tt6to;

	private string[] uTALEaGG6WP;

	private string UcbLE7RXcm7;

	private Dictionary<string, CoreWebView2DevToolsProtocolEventReceiver> aUULERIIJBZ = new Dictionary<string, CoreWebView2DevToolsProtocolEventReceiver>();

	private Dictionary<CoreWebView2DevToolsProtocolEventReceiver, Dictionary<string, EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>>> YybLEqvLXvY = new Dictionary<CoreWebView2DevToolsProtocolEventReceiver, Dictionary<string, EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>>>();

	internal static DevtoolsProtocolBridge rPsYEZFEhqUhgOwQbXAC;

	public DevtoolsProtocolBridge(CoreWebView2 webView2, string checkCode, IEnumerable<string> whiteList)
	{
		CmoLE8tt6to = webView2;
		object obj;
		if (whiteList == null)
		{
			obj = null;
		}
		else
		{
			obj = whiteList.Select(_003C_003Ec.rZBS5tGg8uW ?? (_003C_003Ec.rZBS5tGg8uW = _003C_003Ec.XjWS5wqtvys.sRLS4zeuEdM)).ToArray();
			if (obj != null)
			{
				goto IL_005e;
			}
		}
		obj = new string[0];
		goto IL_005e;
		IL_005e:
		uTALEaGG6WP = (string[])obj;
		UcbLE7RXcm7 = checkCode;
	}

	private bool check(string code, string methodOrEventName, out string errorMessage)
	{
		errorMessage = "";
		if (code != UcbLE7RXcm7)
		{
			errorMessage = "check code error";
			return false;
		}
		return true;
	}

	[AsyncStateMachine(typeof(_003CRun_003Ed__7))]
	public Task Run(string checkCode, string methodName, string identifier, string paramAsJson = "{}")
	{
		_003CRun_003Ed__7 stateMachine = default(_003CRun_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.checkCode = checkCode;
		stateMachine.methodName = methodName;
		stateMachine.identifier = identifier;
		stateMachine.paramAsJson = paramAsJson;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public string On(string checkCode, string eventName, string identifier)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.rTlS5LRBon4 = this;
		_003C_003Ec__DisplayClass8_.FktS5v1ABi4 = identifier;
		if (!check(checkCode, eventName, out var errorMessage))
		{
			int num = 0;
			if (!rxaLtvFEHBxZu6pYJW7Z())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new Exception(errorMessage);
			}
		}
		string key = _003C_003Ec__DisplayClass8_.FktS5v1ABi4;
		CoreWebView2DevToolsProtocolEventReceiver coreWebView2DevToolsProtocolEventReceiver = null;
		if (aUULERIIJBZ.ContainsKey(eventName))
		{
			coreWebView2DevToolsProtocolEventReceiver = aUULERIIJBZ[eventName];
		}
		else
		{
			coreWebView2DevToolsProtocolEventReceiver = CmoLE8tt6to.GetDevToolsProtocolEventReceiver(eventName);
			aUULERIIJBZ[eventName] = coreWebView2DevToolsProtocolEventReceiver;
		}
		if (!YybLEqvLXvY.ContainsKey(coreWebView2DevToolsProtocolEventReceiver))
		{
			YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver] = new Dictionary<string, EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>>();
		}
		if (!YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver].ContainsKey(key))
		{
			EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> value = _003C_003Ec__DisplayClass8_.WKHS5gQbVjA;
			coreWebView2DevToolsProtocolEventReceiver.DevToolsProtocolEventReceived += value;
			YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver][key] = value;
		}
		return _003C_003Ec__DisplayClass8_.FktS5v1ABi4;
	}

	public string Off(string eventName, string identifier)
	{
		if (!aUULERIIJBZ.ContainsKey(eventName))
		{
			throw new ArgumentException("未订阅过该事件处理器");
		}
		CoreWebView2DevToolsProtocolEventReceiver coreWebView2DevToolsProtocolEventReceiver = aUULERIIJBZ[eventName];
		if (!YybLEqvLXvY.ContainsKey(coreWebView2DevToolsProtocolEventReceiver) || !YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver].ContainsKey(identifier))
		{
			throw new ArgumentException("未订阅过该事件处理器");
		}
		coreWebView2DevToolsProtocolEventReceiver.DevToolsProtocolEventReceived -= YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver][identifier];
		YybLEqvLXvY[coreWebView2DevToolsProtocolEventReceiver].Remove(identifier);
		return identifier;
	}

	private void cTbLEysAhHl(string string_2, object object_0)
	{
		CmoLE8tt6to.PostWebMessageAsJson(JsonConvert.SerializeObject(new _003C_003Ef__AnonymousType55<string, object>(string_2, object_0)));
	}

	internal static bool rxaLtvFEHBxZu6pYJW7Z()
	{
		return rPsYEZFEhqUhgOwQbXAC == null;
	}
}
