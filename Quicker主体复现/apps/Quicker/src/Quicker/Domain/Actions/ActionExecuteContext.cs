using System;
using System.Collections.Generic;
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
using System.Windows.Media;
using HandyControl.Tools;
using Jp6YuAAO2nOBQFwcNUf;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Public.Interfaces;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using w5LCTEXj6yVVSrHtf2R;
using Z.Expressions;

namespace Quicker.Domain.Actions;

public class ActionExecuteContext : IDisposable, IActionContext, IVariableContext
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass122_0
	{
		public WaitUserWindow wpPvAbLrS4k;

		internal static _003C_003Ec__DisplayClass122_0 kF9KGpWXDcMhAnfKo2gx;

		internal void PxSvA1PMv55()
		{
			wpPvAbLrS4k.CloseFromCode();
		}

		internal static bool uHfndVWX32TrwGbXUvPm()
		{
			return kF9KGpWXDcMhAnfKo2gx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass130_0
	{
		public string OH2vAXoctMv;

		internal static _003C_003Ec__DisplayClass130_0 S4CqJpWX0DObJuQCxBsY;

		internal bool XHUvA6N40dg(ActionVariable x)
		{
			return x.Key == OH2vAXoctMv;
		}

		internal static void fEYXaJWXBMOFLUm5ahgg()
		{
		}

		internal static bool JgOgD8WX19XaYPAGLkOB()
		{
			return S4CqJpWX0DObJuQCxBsY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass205_0
	{
		public string k1yvAKt7kt6;

		public ActionExecuteContext GA3vAxFMryF;

		public object zVevArjtkst;

		internal static _003C_003Ec__DisplayClass205_0 B5h7Q1WXv0OrKAMtpvKO;

		internal void SFAvAm2uBuM()
		{
			zVevArjtkst = XActionHelper.cHBtDkjh5TG(k1yvAKt7kt6, GA3vAxFMryF);
		}

		internal static bool JfOZrOWXdEF8q8S0L5BZ()
		{
			return B5h7Q1WXv0OrKAMtpvKO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass206_0
	{
		public CommonOperationItem WNdvABejbeb;

		public ActionExecuteContext MLovAQX7B7O;

		private static _003C_003Ec__DisplayClass206_0 B0vAdUWXJyZsYEWVQRlv;

		internal void CFJvAppNLmP()
		{
			try
			{
				UQpehvAn0sgnYNEpfrQ.Execute(WNdvABejbeb, MLovAQX7B7O);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行通用操作项出错：" + ex.Message);
				AjYtn6gcRFh.Warn("执行通用操作项出错：" + ex.Message, ex);
			}
		}

		internal static bool wLsVkMWXkXvl3n1xdK7j()
		{
			return B0vAdUWXJyZsYEWVQRlv == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunSpAsync_003Ed__217 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

		public string spName;

		public IDictionary<string, object> inputParams;

		public ActionExecuteContext _003C_003E4__this;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		private static object F7LQS1WX97XrW5TUNwwI;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionExecuteContext actionExecuteContext = _003C_003E4__this;
			IDictionary<string, object> result;
			try
			{
				TaskAwaiter<IDictionary<string, object>> awaiter;
				if (num != 0)
				{
					awaiter = SubProgramHelper.RunStandaloneSubprogram(spName, inputParams ?? new Dictionary<string, object>(), actionExecuteContext, actionExecuteContext.ParentWindow, false, true).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<IDictionary<string, object>>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (F7LQS1WX97XrW5TUNwwI != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
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

		internal static bool SUiDEfWXLhpI9ZeagXFP()
		{
			return F7LQS1WX97XrW5TUNwwI == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunSpAsync_003Ed__218 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

		public ActionExecuteContext _003C_003E4__this;

		public string spName;

		public object inputParams;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		private static object vpmsrkWXoNeZpbNOtHMu;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionExecuteContext actionExecuteContext = _003C_003E4__this;
			IDictionary<string, object> result;
			try
			{
				TaskAwaiter<IDictionary<string, object>> awaiter;
				if (num != 0)
				{
					awaiter = actionExecuteContext.RunSpAsync(spName, inputParams.ToDictionary()).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<IDictionary<string, object>>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
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

		internal static bool cxOLA4WXfp4oVKAWsJWQ()
		{
			return vpmsrkWXoNeZpbNOtHMu == null;
		}
	}

	private static readonly ILog AjYtn6gcRFh;

	[CompilerGenerated]
	private ActionTrigger BCytnXar3aC;

	private static int ovvtnmXCd0s;

	[CompilerGenerated]
	private int Ah8tnK5IUPh;

	[CompilerGenerated]
	private DateTime Oebtnxv4kNv;

	[CompilerGenerated]
	private bool rdmtnr8IoMs;

	[CompilerGenerated]
	private bool vKctnpZHZF8;

	[CompilerGenerated]
	private ActionExecuteContext tUPtnBMJt72;

	[CompilerGenerated]
	private ActionExecuteContext H43tnQOQAWK;

	[CompilerGenerated]
	private CancellationToken? zkmtnjWvV2u;

	[CompilerGenerated]
	private CancellationTokenSource XIvtnn85QZj;

	[CompilerGenerated]
	private ActionItem Vqwtn4KWaPD;

	[CompilerGenerated]
	private Window YSItn5ybObJ;

	[CompilerGenerated]
	private IXProgram xv6tnD1IN9g;

	[CompilerGenerated]
	private ActionDataType fhEtndH2waT;

	[CompilerGenerated]
	private AppServer SgjtnoAmBKE;

	[CompilerGenerated]
	private string jZPtnTn0p7x;

	private string LujtnMUY7Ay;

	private Image M78tnAIabIG;

	[CompilerGenerated]
	private readonly IList<int> VVCtnOl9MA3 = new List<int>();

	[CompilerGenerated]
	private bool T28tnFcI9p3;

	[CompilerGenerated]
	private IActionLogger kLxtnUu5QfG = new NopActionLogger();

	[CompilerGenerated]
	private readonly IDictionary<string, object> hnUtnlJoh2L = new Dictionary<string, object>();

	[CompilerGenerated]
	private ActionStopFlag T2GtniUIdpy;

	[CompilerGenerated]
	private bool HDwtn3vInxO;

	[CompilerGenerated]
	private bool SjytnfOl9fW;

	[CompilerGenerated]
	private string adatnzCfNPh;

	[CompilerGenerated]
	private IntPtr Q9pt4wAcodF;

	private readonly IDictionary<string, WaitUserWindow> Gtat4tvwQcr = new Dictionary<string, WaitUserWindow>();

	[CompilerGenerated]
	private System.Windows.Point? RGot4gAc64p;

	[CompilerGenerated]
	private string VAmt4LsVJFp;

	[CompilerGenerated]
	private bool X3Yt4viYqD6;

	private MediaPlayer txSt4St4adQ;

	[CompilerGenerated]
	private PointTargetInfo lglt425c0Aj;

	[CompilerGenerated]
	private string ASUt4ur3mgU;

	[CompilerGenerated]
	private bool wFjt4NqkKrB;

	[CompilerGenerated]
	private bool hVJt4J2CS05;

	[CompilerGenerated]
	private bool? Na1t40qc3jr;

	[CompilerGenerated]
	private IDictionary<string, object> eV0t4C2BZNc = new Dictionary<string, object>();

	[CompilerGenerated]
	private ActionExecuteContext Wa2t4P2r35f;

	[CompilerGenerated]
	private bool jl7t4E2x8Ls;

	[CompilerGenerated]
	private string x7ft4yUSEvq = string.Empty;

	[CompilerGenerated]
	private object imQt48LCXLP;

	[CompilerGenerated]
	private string dJRt4aItyfj;

	private EvalContext M1Mt47SHm8L;

	private IList<WeakReference<IDisposable>> mf6t4RUXTcu = new List<WeakReference<IDisposable>>();

	[CompilerGenerated]
	private bool NOTt4qug8dW;

	private ActionExtraContextData LbXt4ceBfLl;

	[CompilerGenerated]
	private int vTpt4VgPtMU;

	internal static ActionExecuteContext RaEKlfQut9TXLZNSQrRH;

	public ActionTrigger ActionTrigger
	{
		[CompilerGenerated]
		get
		{
			return BCytnXar3aC;
		}
		[CompilerGenerated]
		set
		{
			BCytnXar3aC = value;
		}
	}

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return Ah8tnK5IUPh;
		}
		[CompilerGenerated]
		private set
		{
			Ah8tnK5IUPh = value;
		}
	}

	public DateTime StartTime
	{
		[CompilerGenerated]
		get
		{
			return Oebtnxv4kNv;
		}
		[CompilerGenerated]
		set
		{
			Oebtnxv4kNv = value;
		}
	}

	public bool IsRootContext
	{
		[CompilerGenerated]
		get
		{
			return rdmtnr8IoMs;
		}
		[CompilerGenerated]
		set
		{
			rdmtnr8IoMs = value;
		}
	}

	public bool IsReadonly
	{
		[CompilerGenerated]
		get
		{
			return vKctnpZHZF8;
		}
		[CompilerGenerated]
		set
		{
			vKctnpZHZF8 = value;
		}
	}

	[JsonIgnore]
	public ActionExecuteContext RootContext
	{
		[CompilerGenerated]
		get
		{
			return tUPtnBMJt72;
		}
		[CompilerGenerated]
		private set
		{
			tUPtnBMJt72 = value;
		}
	}

	[JsonIgnore]
	public ActionExecuteContext ParentContext
	{
		[CompilerGenerated]
		get
		{
			return H43tnQOQAWK;
		}
		[CompilerGenerated]
		private set
		{
			H43tnQOQAWK = value;
		}
	}

	public CancellationToken? CancellationToken
	{
		[CompilerGenerated]
		get
		{
			return zkmtnjWvV2u;
		}
		[CompilerGenerated]
		set
		{
			zkmtnjWvV2u = value;
		}
	}

	public CancellationTokenSource Cts
	{
		[CompilerGenerated]
		get
		{
			return XIvtnn85QZj;
		}
		[CompilerGenerated]
		set
		{
			XIvtnn85QZj = value;
		}
	}

	[JsonIgnore]
	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return Vqwtn4KWaPD;
		}
		[CompilerGenerated]
		private set
		{
			Vqwtn4KWaPD = value;
		}
	}

	[JsonIgnore]
	public Window ParentWindow
	{
		[CompilerGenerated]
		get
		{
			return YSItn5ybObJ;
		}
		[CompilerGenerated]
		set
		{
			YSItn5ybObJ = value;
		}
	}

	[JsonIgnore]
	public IXProgram XProgram
	{
		[CompilerGenerated]
		get
		{
			return xv6tnD1IN9g;
		}
		[CompilerGenerated]
		set
		{
			xv6tnD1IN9g = value;
		}
	}

	public string ActionTitle => Action.Title;

	public string ActionId => Action.Id;

	public ActionDataType LastDataType
	{
		[CompilerGenerated]
		get
		{
			return fhEtndH2waT;
		}
		[CompilerGenerated]
		set
		{
			fhEtndH2waT = value;
		}
	}

	[JsonIgnore]
	public AppServer AppServer
	{
		[CompilerGenerated]
		get
		{
			return SgjtnoAmBKE;
		}
		[CompilerGenerated]
		private set
		{
			SgjtnoAmBKE = value;
		}
	}

	public string InputParam
	{
		[CompilerGenerated]
		get
		{
			return jZPtnTn0p7x;
		}
		[CompilerGenerated]
		set
		{
			jZPtnTn0p7x = value;
		}
	}

	public string TextData
	{
		get
		{
			return LujtnMUY7Ay;
		}
		set
		{
			LujtnMUY7Ay = value;
			LastDataType = ActionDataType.Text;
		}
	}

	public Image ImageData
	{
		get
		{
			return M78tnAIabIG;
		}
		set
		{
			M78tnAIabIG = value;
			LastDataType = ActionDataType.Image;
		}
	}

	public IList<int> CurrentCodeLine
	{
		[CompilerGenerated]
		get
		{
			return VVCtnOl9MA3;
		}
	}

	public bool IsDebugging
	{
		[CompilerGenerated]
		get
		{
			return T28tnFcI9p3;
		}
		[CompilerGenerated]
		private set
		{
			T28tnFcI9p3 = value;
		}
	}

	public IActionLogger ActionLogger
	{
		[CompilerGenerated]
		get
		{
			return kLxtnUu5QfG;
		}
		[CompilerGenerated]
		set
		{
			kLxtnUu5QfG = value;
		}
	}

	public IDictionary<string, object> CustomData
	{
		[CompilerGenerated]
		get
		{
			return hnUtnlJoh2L;
		}
	}

	public ActionStopFlag StopFlag
	{
		[CompilerGenerated]
		get
		{
			return T2GtniUIdpy;
		}
		[CompilerGenerated]
		set
		{
			T2GtniUIdpy = value;
		}
	}

	public bool BreakFlag
	{
		[CompilerGenerated]
		get
		{
			return HDwtn3vInxO;
		}
		[CompilerGenerated]
		set
		{
			HDwtn3vInxO = value;
		}
	}

	public bool HideWarning
	{
		[CompilerGenerated]
		get
		{
			return SjytnfOl9fW;
		}
		[CompilerGenerated]
		set
		{
			SjytnfOl9fW = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return adatnzCfNPh;
		}
		[CompilerGenerated]
		set
		{
			adatnzCfNPh = value;
		}
	}

	public IntPtr ActiveWindowHwnd
	{
		[CompilerGenerated]
		get
		{
			return Q9pt4wAcodF;
		}
		[CompilerGenerated]
		set
		{
			Q9pt4wAcodF = value;
		}
	}

	public System.Windows.Point? WaiteUserWindowTopLeft
	{
		[CompilerGenerated]
		get
		{
			return RGot4gAc64p;
		}
		[CompilerGenerated]
		private set
		{
			RGot4gAc64p = value;
		}
	}

	public string SuccessMessage
	{
		[CompilerGenerated]
		get
		{
			return VAmt4LsVJFp;
		}
		[CompilerGenerated]
		set
		{
			VAmt4LsVJFp = value;
		}
	}

	public bool ContinueFlag
	{
		[CompilerGenerated]
		get
		{
			return X3Yt4viYqD6;
		}
		[CompilerGenerated]
		set
		{
			X3Yt4viYqD6 = value;
		}
	}

	public PointTargetInfo TargetInfo
	{
		[CompilerGenerated]
		get
		{
			return lglt425c0Aj;
		}
		[CompilerGenerated]
		set
		{
			lglt425c0Aj = value;
		}
	}

	public string WaiteUserWindowResult
	{
		[CompilerGenerated]
		get
		{
			return ASUt4ur3mgU;
		}
		[CompilerGenerated]
		set
		{
			ASUt4ur3mgU = value;
		}
	}

	public bool IsStoppedByUser
	{
		[CompilerGenerated]
		get
		{
			return wFjt4NqkKrB;
		}
		[CompilerGenerated]
		set
		{
			wFjt4NqkKrB = value;
		}
	}

	public bool SkipStopWarning
	{
		[CompilerGenerated]
		get
		{
			return hVJt4J2CS05;
		}
		[CompilerGenerated]
		set
		{
			hVJt4J2CS05 = value;
		}
	}

	public bool? IsImeEnabled
	{
		[CompilerGenerated]
		get
		{
			return Na1t40qc3jr;
		}
		[CompilerGenerated]
		private set
		{
			Na1t40qc3jr = value;
		}
	}

	public IDictionary<string, object> States
	{
		[CompilerGenerated]
		get
		{
			return eV0t4C2BZNc;
		}
		[CompilerGenerated]
		private set
		{
			eV0t4C2BZNc = value;
		}
	}

	public ActionExecuteContext ChildContext
	{
		[CompilerGenerated]
		get
		{
			return Wa2t4P2r35f;
		}
		[CompilerGenerated]
		set
		{
			Wa2t4P2r35f = value;
		}
	}

	public bool ReturnError
	{
		[CompilerGenerated]
		get
		{
			return jl7t4E2x8Ls;
		}
		[CompilerGenerated]
		set
		{
			jl7t4E2x8Ls = value;
		}
	}

	public string ReturnResult
	{
		[CompilerGenerated]
		get
		{
			return x7ft4yUSEvq;
		}
		[CompilerGenerated]
		set
		{
			x7ft4yUSEvq = value;
		}
	}

	public object ReturnResultObject
	{
		[CompilerGenerated]
		get
		{
			return imQt48LCXLP;
		}
		[CompilerGenerated]
		set
		{
			imQt48LCXLP = value;
		}
	}

	public string Browser
	{
		[CompilerGenerated]
		get
		{
			return dJRt4aItyfj;
		}
		[CompilerGenerated]
		set
		{
			dJRt4aItyfj = value;
		}
	}

	public bool HasImageParamUsed
	{
		[CompilerGenerated]
		get
		{
			return NOTt4qug8dW;
		}
		[CompilerGenerated]
		set
		{
			NOTt4qug8dW = value;
		}
	}

	public ActionExtraContextData ExtraData
	{
		get
		{
			if (RootContext != this && RootContext != null)
			{
				return RootContext.ExtraData;
			}
			return LbXt4ceBfLl;
		}
	}

	public int ClipboardSeqBeforeCtrlC
	{
		[CompilerGenerated]
		get
		{
			return vTpt4VgPtMU;
		}
		[CompilerGenerated]
		set
		{
			vTpt4VgPtMU = value;
		}
	}

	public IActionContext GetRootContext()
	{
		return RootContext ?? this;
	}

	public IActionContext GetParentContext()
	{
		return ParentContext;
	}

	public ActionExecuteContext(ActionItem action, PointTargetInfo targetInfo, AppServer appServer, bool isDebugging, int parentId, ActionExtraContextData actionExtraContextData = null, CancellationToken? cancellationToken = null)
		: this(null, action, targetInfo, appServer, isDebugging, parentId, actionExtraContextData, cancellationToken)
	{
	}

	public ActionExecuteContext(ActionExecuteContext parentContext, ActionItem action, PointTargetInfo targetInfo, AppServer appServer, bool isDebugging, int parentId, ActionExtraContextData actionExtraContextData = null, CancellationToken? cancellationToken = null)
	{
		Action = action;
		StartTime = DateTime.Now;
		Id = ((parentId > 0) ? parentId : Interlocked.Increment(ref ovvtnmXCd0s));
		TargetInfo = targetInfo;
		AppServer = appServer;
		IsDebugging = isDebugging;
		ParentContext = parentContext;
		object obj;
		if (parentContext != null)
		{
			if (parentContext == null)
			{
				obj = null;
			}
			else
			{
				obj = parentContext.RootContext;
				if (obj != null)
				{
					goto IL_00b1;
				}
			}
			obj = parentContext;
			goto IL_00b1;
		}
		RootContext = this;
		goto IL_00dd;
		IL_00dd:
		if (isDebugging)
		{
			ActionLogger = new HtmlActionLogger(action, this);
		}
		LbXt4ceBfLl = actionExtraContextData;
		CancellationToken = cancellationToken;
		return;
		IL_00b1:
		RootContext = (ActionExecuteContext)obj;
		InputParam = parentContext?.InputParam;
		Browser = parentContext.Browser;
		goto IL_00dd;
	}

	public IDictionary<string, object> GetVariables()
	{
		return CustomData;
	}

	public void AddWaiteWindow(string key, WaitUserWindow waitWindow)
	{
		Gtat4tvwQcr.Add(key, waitWindow);
	}

	public void UpdateWaiteWindowLocation(System.Windows.Point windowTopLeft)
	{
		WaiteUserWindowTopLeft = windowTopLeft;
	}

	public void OnWaitWindowClosed(string key, string selectedOperation)
	{
		Gtat4tvwQcr.Remove(key);
		WaiteUserWindowResult = selectedOperation;
	}

	public bool IsWaitWindowClosed(string key)
	{
		return !Gtat4tvwQcr.ContainsKey(key);
	}

	public void CloseWaitWin(string key)
	{
		_003C_003Ec__DisplayClass122_0 _003C_003Ec__DisplayClass122_ = new _003C_003Ec__DisplayClass122_0();
		if (Gtat4tvwQcr.TryGetValue(key, out _003C_003Ec__DisplayClass122_.wpPvAbLrS4k))
		{
			try
			{
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass122_.PxSvA1PMv55);
			}
			catch
			{
			}
		}
	}

	public WaitUserWindow GetWaitWindow(string key)
	{
		if (!Gtat4tvwQcr.TryGetValue(key, out var value))
		{
			return null;
		}
		return value;
	}

	public void SetVarValue(string varName, object value)
	{
		varName = yxQtnV13B8X(varName);
		JpFtnc6NQwS(varName, value);
	}

	public void SetVarValueWithoutConvert(string varName, object value)
	{
		if (IsReadonly)
		{
			throw new InvalidOperationException("当前上下文为只读模式，不能为变量赋值。");
		}
		varName = yxQtnV13B8X(varName);
		CustomData[varName] = value;
	}

	private void JpFtnc6NQwS(string string_7, object object_1)
	{
		_003C_003Ec__DisplayClass130_0 _003C_003Ec__DisplayClass130_ = new _003C_003Ec__DisplayClass130_0();
		_003C_003Ec__DisplayClass130_.OH2vAXoctMv = string_7;
		if (IsReadonly)
		{
			throw new InvalidOperationException("当前上下文为只读模式，不能为变量赋值。");
		}
		ActionVariable actionVariable = XProgram?.Variables?.FirstOrDefault(_003C_003Ec__DisplayClass130_.XHUvA6N40dg);
		int num = 0;
		if (RaEKlfQut9TXLZNSQrRH != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (actionVariable == null)
		{
			SetVarValueWithoutConvert(_003C_003Ec__DisplayClass130_.OH2vAXoctMv, object_1);
		}
		else
		{
			SetVarValueWithoutConvert(_003C_003Ec__DisplayClass130_.OH2vAXoctMv, VariableHelper.ConvertToType(actionVariable.Type, object_1));
		}
	}

	public object GetVarValue(string varName)
	{
		varName = yxQtnV13B8X(varName);
		if (!CustomData.TryGetValue(varName, out var value))
		{
			throw new InvalidOperationException("变量不存在：" + varName);
		}
		return value;
	}

	private static string yxQtnV13B8X(string string_7)
	{
		if (string_7.StartsWith("{") && string_7.EndsWith("}"))
		{
			return string_7.Substring(1, string_7.Length - 2);
		}
		return string_7;
	}

	public object TryGetValue(string var, object defaultValue)
	{
		var = yxQtnV13B8X(var);
		if (CustomData.ContainsKey(var))
		{
			return CustomData[var];
		}
		return defaultValue;
	}

	public bool IsVarExists(string varName)
	{
		return CustomData.ContainsKey(varName);
	}

	public void StopAction(ActionStopFlag stopFlag, string reason, bool skipCloseWaitWindow = false)
	{
		if (stopFlag == ActionStopFlag.ForceStop && Cts != null)
		{
			Cts.Cancel();
		}
		if (ChildContext != null)
		{
			int num = 0;
			if (!pIwkKOQuSQ4S0fILNqlF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			ChildContext.StopAction(stopFlag, reason);
		}
		StopFlag = stopFlag;
		CloseWaitWin("");
		if (IsDebugging)
		{
			ActionLogger.LogWarning("停止动作：" + reason);
		}
	}

	public void SetBreakFlag()
	{
		BreakFlag = true;
		if (IsDebugging)
		{
			ActionLogger.LogWarning("设置跳出循环标记");
		}
	}

	public bool IsShouldBreak()
	{
		return BreakFlag;
	}

	public void ClearBreakFlag()
	{
		if (BreakFlag && IsDebugging)
		{
			ActionLogger.LogWarning("清除跳出循环标记");
		}
		BreakFlag = false;
	}

	public bool IsShouldStopAction()
	{
		return StopFlag != ActionStopFlag.NoStop;
	}

	public void SetContinueFlag()
	{
		ContinueFlag = true;
		if (IsDebugging)
		{
			ActionLogger.LogWarning("设置跳过后续步骤标记");
		}
	}

	public bool ShouldContinue()
	{
		return ContinueFlag;
	}

	public void ClearContinueFlag()
	{
		if (ContinueFlag && IsDebugging)
		{
			ActionLogger.LogWarning("清除跳过后续步骤标记");
		}
		ContinueFlag = false;
	}

	public MediaPlayer GetMediaPlayer()
	{
		if (txSt4St4adQ == null)
		{
			txSt4St4adQ = new MediaPlayer();
			txSt4St4adQ.MediaFailed += zQ4tnZRUk1C;
		}
		return txSt4St4adQ;
	}

	private void zQ4tnZRUk1C(object sender, ExceptionEventArgs e)
	{
		AppHelper.ShowWarning("媒体播放错误：" + e.ErrorException?.Message);
	}

	public void ShowWarning(string message, ActionStep step)
	{
		if (!HideWarning)
		{
			AppHelper.ShowWarning(message);
		}
	}

	public void SaveImeState(bool isEnabled)
	{
		if (!IsImeEnabled.HasValue)
		{
			IsImeEnabled = isEnabled;
		}
	}

	public EvalContext GetEvalContext()
	{
		if (RootContext != null && RootContext != this)
		{
			EvalContext evalContext = RootContext.GetEvalContext();
			if (evalContext != null)
			{
				return evalContext;
			}
		}
		if (M1Mt47SHm8L == null)
		{
			if (RootContext != null)
			{
				int num = 0;
				if (!pIwkKOQuSQ4S0fILNqlF())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (RootContext != this)
				{
					M1Mt47SHm8L = RootContext.GetEvalContext().Clone();
					M1Mt47SHm8L.UseLocalCache = true;
					goto IL_009b;
				}
			}
			M1Mt47SHm8L = EvalManager.DefaultContext.Clone();
			M1Mt47SHm8L.UseLocalCache = true;
			goto IL_009b;
		}
		goto IL_00b3;
		IL_009b:
		M1Mt47SHm8L.RegisterGlobalVariable("_eval", M1Mt47SHm8L);
		goto IL_00b3;
		IL_00b3:
		return M1Mt47SHm8L;
	}

	public void SaveTextWindowLocation(string autoCloseKey, Window w)
	{
		States[IhetnhZ1vg6(autoCloseKey)] = w.WindowState;
		if (w.WindowState == WindowState.Normal)
		{
			int num = 0;
			if (!pIwkKOQuSQ4S0fILNqlF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(w.GetHandle());
			States[g82tn9mYaPm(autoCloseKey)] = new Rect(new System.Windows.Point(windowRectangle.Left, windowRectangle.Top), new System.Windows.Size(windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top));
		}
		else
		{
			NativeMethods.oY8KsdDc7bANQ7gQUvM oY8KsdDc7bANQ7gQUvM_ = default(NativeMethods.oY8KsdDc7bANQ7gQUvM);
			if (NativeMethods.MI7LULeHOWE(w.GetHandle(), ref oY8KsdDc7bANQ7gQUvM_))
			{
				NativeMethods.RECT eF222pD9gCa = oY8KsdDc7bANQ7gQUvM_.EF222pD9gCa;
				States[g82tn9mYaPm(autoCloseKey)] = new Rect(new System.Windows.Point(eF222pD9gCa.Left, eF222pD9gCa.Top), new System.Windows.Size(eF222pD9gCa.Right - eF222pD9gCa.Left, eF222pD9gCa.Bottom - eF222pD9gCa.Top));
			}
			else
			{
				States[g82tn9mYaPm(autoCloseKey)] = w.RestoreBounds;
			}
		}
	}

	private static string g82tn9mYaPm(string string_7)
	{
		return "textwindow_" + string_7;
	}

	private static string IhetnhZ1vg6(string string_7)
	{
		return "textwindow_state_" + string_7;
	}

	public Rect? GetTextWindowLocation(string autoCloseKey)
	{
		if (string.IsNullOrEmpty(autoCloseKey))
		{
			return null;
		}
		string key = g82tn9mYaPm(autoCloseKey);
		if (States.ContainsKey(key))
		{
			return (Rect?)States[key];
		}
		return null;
	}

	public WindowState? GetTextWindowState(string autoCloseKey)
	{
		if (string.IsNullOrEmpty(autoCloseKey))
		{
			return null;
		}
		string key = IhetnhZ1vg6(autoCloseKey);
		if (States.ContainsKey(key))
		{
			return (WindowState?)States[key];
		}
		return null;
	}

	public void RegisterDisposable(IDisposable disposableObject)
	{
		if (RootContext != null && RootContext != this)
		{
			RootContext.RegisterDisposable(disposableObject);
		}
		else
		{
			mf6t4RUXTcu.Add(new WeakReference<IDisposable>(disposableObject));
		}
	}

	public object EvalExpression(string expression, bool onUiThread = false)
	{
		_003C_003Ec__DisplayClass205_0 _003C_003Ec__DisplayClass205_ = new _003C_003Ec__DisplayClass205_0();
		_003C_003Ec__DisplayClass205_.k1yvAKt7kt6 = expression;
		_003C_003Ec__DisplayClass205_.GA3vAxFMryF = this;
		if (_003C_003Ec__DisplayClass205_.k1yvAKt7kt6.StartsWith("$="))
		{
			_003C_003Ec__DisplayClass205_.k1yvAKt7kt6 = _003C_003Ec__DisplayClass205_.k1yvAKt7kt6.Substring(2);
		}
		if (onUiThread)
		{
			_003C_003Ec__DisplayClass205_.zVevArjtkst = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass205_.SFAvAm2uBuM);
			return _003C_003Ec__DisplayClass205_.zVevArjtkst;
		}
		return XActionHelper.cHBtDkjh5TG(_003C_003Ec__DisplayClass205_.k1yvAKt7kt6, this);
	}

	public void ExecuteCommonOperationItem(CommonOperationItem item)
	{
		_003C_003Ec__DisplayClass206_0 _003C_003Ec__DisplayClass206_ = new _003C_003Ec__DisplayClass206_0();
		_003C_003Ec__DisplayClass206_.WNdvABejbeb = item;
		_003C_003Ec__DisplayClass206_.MLovAQX7B7O = this;
		if (_003C_003Ec__DisplayClass206_.WNdvABejbeb == null)
		{
			AppHelper.ShowWarning("操作项对象为空。");
		}
		else
		{
			Task.Run((Action)_003C_003Ec__DisplayClass206_.CFJvAppNLmP);
		}
	}

	public void TryDisposeObjects()
	{
		int num = 0;
		foreach (WeakReference<IDisposable> item in mf6t4RUXTcu)
		{
			if (item.TryGetTarget(out var target))
			{
				try
				{
					num++;
					target.Dispose();
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public void Dispose()
	{
		TryDisposeObjects();
		M1Mt47SHm8L?.UnregisterAll();
		M1Mt47SHm8L?.Dispose();
		M1Mt47SHm8L = null;
	}

	public IDictionary<string, object> RunSp(string spName, IDictionary<string, object> inputParams)
	{
		return SubProgramHelper.RunStandaloneSubprogram(spName, inputParams ?? new Dictionary<string, object>(), this, ParentWindow, false, true).GetAwaiter().GetResult();
	}

	[AsyncStateMachine(typeof(_003CRunSpAsync_003Ed__217))]
	public Task<IDictionary<string, object>> RunSpAsync(string spName, IDictionary<string, object> inputParams)
	{
		_003CRunSpAsync_003Ed__217 stateMachine = default(_003CRunSpAsync_003Ed__217);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDictionary<string, object>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spName = spName;
		stateMachine.inputParams = inputParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRunSpAsync_003Ed__218))]
	public Task<IDictionary<string, object>> RunSpAsync(string spName, object inputParams)
	{
		_003CRunSpAsync_003Ed__218 stateMachine = default(_003CRunSpAsync_003Ed__218);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDictionary<string, object>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spName = spName;
		stateMachine.inputParams = inputParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public IDictionary<string, object> RunSp(string spName, object inputParams)
	{
		return RunSp(spName, inputParams.ToDictionary());
	}

	public void WriteState(string key, string value)
	{
		QQhtne4VlvC();
		ActionStateWriter.WriteActionState(ActionId, key, value);
	}

	public string ReadState(string key, string defaultValue)
	{
		QQhtne4VlvC();
		(bool, string) tuple = ActionStateWriter.ReadActionStateValue(ActionId, key);
		if (tuple.Item1)
		{
			return tuple.Item2;
		}
		return defaultValue;
	}

	private void QQhtne4VlvC()
	{
		if (string.IsNullOrEmpty(ActionId))
		{
			throw new InvalidDataException("动作ID不存在。可能您尚未保存动作。");
		}
	}

	public void WriteCache(string key, object value, int maxKeepSeconds)
	{
		QQhtne4VlvC();
		sgZXFSX2DQ8Gk2Ze1QT.IRAtHfKNUsU(ActionId, key, value, maxKeepSeconds);
	}

	public object RemoveCache(string key)
	{
		QQhtne4VlvC();
		return sgZXFSX2DQ8Gk2Ze1QT.YOAtHzKx8UL(ActionId, key);
	}

	public void ClearCache()
	{
		QQhtne4VlvC();
		sgZXFSX2DQ8Gk2Ze1QT.reLt1w0o395(ActionId);
	}

	public T ReadCache<T>(string key, T defaultValue)
	{
		QQhtne4VlvC();
		object obj = sgZXFSX2DQ8Gk2Ze1QT.LMGt1tijCk4(ActionId, key, defaultValue);
		if (obj == null)
		{
			return defaultValue;
		}
		if (!(obj is T))
		{
			throw new InvalidDataException("缓存中的内容(key:" + key + ")不是指定的类型。");
		}
		return (T)obj;
	}

	public void UpdateVariablesFromDict(IDictionary<string, object> dict)
	{
		if (dict == null)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in dict)
		{
			SetVarValue(item.Key, item.Value);
		}
	}

	public void UpdateVariablesFromJson(string dictJson)
	{
		if (!string.IsNullOrEmpty(dictJson))
		{
			IDictionary<string, object> dict = JsonConvert.DeserializeObject<IDictionary<string, object>>(dictJson);
			UpdateVariablesFromDict(dict);
		}
	}

	public bool IsSubProgramSuccess()
	{
		if (!ReturnError && !StopFlag.IsEither(ActionStopFlag.ForceStop, ActionStopFlag.OperationFailed, ActionStopFlag.UserCancel))
		{
			return true;
		}
		return false;
	}

	static ActionExecuteContext()
	{
		AjYtn6gcRFh = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ovvtnmXCd0s = 1;
	}

	internal static bool pIwkKOQuSQ4S0fILNqlF()
	{
		return RaEKlfQut9TXLZNSQrRH == null;
	}
}
