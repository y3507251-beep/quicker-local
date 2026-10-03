using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Expression;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.X;
using Z.Expressions;
using Z.Expressions.Compiler.Shared;

namespace Quicker.Modules.ExpressionTester;

public class ExpressionTesterWindow : Window, IComponentConnector, IStyleConnector, IMockModalWindow
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<ExpressionInputParam, ActionVariable> nUjvedGOYPl;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct geOgboHF6ZftFQ0lgaE : IAsyncStateMachine
		{
			public int nHE2aqWHpyG;

			public AsyncTaskMethodBuilder TxO2acFE8J3;

			private TaskAwaiter<ApiResult<IList<ExpressionHelpItem>>> x8k2aVGnwjQ;

			private static object PHbpQ9yLVMHe7QgTeuoV;

			private void MoveNext()
			{
				int num = nHE2aqWHpyG;
				try
				{
					try
					{
						TaskAwaiter<ApiResult<IList<ExpressionHelpItem>>> awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.Bt1t1PiujYn().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								nHE2aqWHpyG = 0;
								x8k2aVGnwjQ = awaiter;
								TxO2acFE8J3.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = x8k2aVGnwjQ;
							x8k2aVGnwjQ = default(TaskAwaiter<ApiResult<IList<ExpressionHelpItem>>>);
							num = -1;
							nHE2aqWHpyG = -1;
						}
						bool isSuccess = awaiter.GetResult().IsSuccess;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("加载变量帮助出错：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					nHE2aqWHpyG = -2;
					TxO2acFE8J3.SetException(exception);
					return;
				}
				nHE2aqWHpyG = -2;
				TxO2acFE8J3.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				TxO2acFE8J3.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool YONgcuyLQ4fj2lc1SZpM()
			{
				return PHbpQ9yLVMHe7QgTeuoV == null;
			}
		}

		public static readonly _003C_003Ec mNXveTcfW4d;

		public static Func<Task> hjJveMFYmSE;

		private static _003C_003Ec DeZ2pDcqhoZIDX2OgSBO;

		static _003C_003Ec()
		{
			mNXveTcfW4d = new _003C_003Ec();
		}

		[AsyncStateMachine(typeof(geOgboHF6ZftFQ0lgaE))]
		internal Task jDkveoK8nhD()
		{
			geOgboHF6ZftFQ0lgaE stateMachine = default(geOgboHF6ZftFQ0lgaE);
			stateMachine.TxO2acFE8J3 = AsyncTaskMethodBuilder.Create();
			stateMachine.nHE2aqWHpyG = -1;
			stateMachine.TxO2acFE8J3.Start(ref stateMachine);
			return stateMachine.TxO2acFE8J3.Task;
		}

		internal static void GOQSyJciVn6eE1Tgg9tV()
		{
		}

		internal static bool fhk2ggcqHvp3iCR8iV16()
		{
			return DeZ2pDcqhoZIDX2OgSBO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public ActionVariable zcTveOur4MX;

		private static _003C_003Ec__DisplayClass19_0 fcWFTNciQByRfS4ihoLn;

		internal bool R9VveASTa2N(ExpressionInputParam x)
		{
			return x.Key == zcTveOur4MX.Key;
		}

		internal static bool jUFqyZciF5BaLaq87bwb()
		{
			return fcWFTNciQByRfS4ihoLn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public ExpressionTesterWindow SIkveUC5XEj;

		public string I4wvelyBGT0;

		public IDictionary<string, object> acWveiAmSFZ;

		internal static _003C_003Ec__DisplayClass21_0 JS6gaLciWLt4xn3ZJH80;

		internal void rUnveFrquIw()
		{
			try
			{
				object obj = SIkveUC5XEj.iqhUg9UCBm.Execute(I4wvelyBGT0, acWveiAmSFZ);
				if (obj == null)
				{
					SIkveUC5XEj.Bt6U2QWgkY = false;
					SIkveUC5XEj.bbWFDQ8xxf("null");
					return;
				}
				SIkveUC5XEj.Bt6U2QWgkY = false;
				SIkveUC5XEj.RyVUvWGOlx = new ExpressionSampleResult
				{
					TypeName = obj.GetType().FullName,
					StrValue = VariableHelper.ConvertToType(VarType.Text, obj).ToString(),
					ObjValue = obj
				};
				StringBuilder stringBuilder = new StringBuilder();
				int num = 1;
				if (JS6gaLciWLt4xn3ZJH80 != null)
				{
					goto IL_0184;
				}
				goto IL_0188;
				IL_0188:
				do
				{
					switch (num)
					{
					case 1:
						if (!SIkveUC5XEj.MWmF5nwNWl(obj.GetType()))
						{
							stringBuilder.AppendLine("Text==============");
							stringBuilder.AppendLine(SIkveUC5XEj.RyVUvWGOlx.StrValue);
							stringBuilder.AppendLine();
							stringBuilder.AppendLine("Json==============");
							stringBuilder.AppendLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
						}
						else
						{
							stringBuilder.AppendLine(SIkveUC5XEj.RyVUvWGOlx.StrValue);
						}
						break;
					default:
						SIkveUC5XEj.bbWFDQ8xxf(stringBuilder.ToString());
						return;
					}
					stringBuilder.AppendLine();
					stringBuilder.AppendLine();
					stringBuilder.AppendLine("----");
					stringBuilder.AppendLine(obj.GetType().CSharpTypeToVarType().GetEnumDisplayName() + " (C#类型：" + obj.GetType().Name + ")");
					num = 0;
				}
				while (JS6gaLciWLt4xn3ZJH80 == null);
				goto IL_0184;
				IL_0184:
				int num2 = default(int);
				num = num2;
				goto IL_0188;
			}
			catch (EvalException ex)
			{
				SIkveUC5XEj.bbWFDQ8xxf("Error：解析表达式错误。\n" + ex.Message + "\n开始位置：" + ex.StartPosition);
			}
			catch (Exception)
			{
				SIkveUC5XEj.bbWFDQ8xxf("Error：解析表达式错误。");
			}
		}

		internal static bool Oic9ytciyMFvaEkEbCYU()
		{
			return JS6gaLciWLt4xn3ZJH80 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public ExpressionTesterWindow PxjvefkWh5x;

		public string L4Hvez2gjf3;

		private static _003C_003Ec__DisplayClass23_0 x8GfZhcieaBSLkNI5hHV;

		internal void e90ve3CeTRH()
		{
			PxjvefkWh5x.TxtResult.Text = L4Hvez2gjf3;
		}

		internal static bool s32S3AcijgRlgunoayYZ()
		{
			return x8GfZhcieaBSLkNI5hHV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAddVar_OnClick_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExpressionTesterWindow _003C_003E4__this;

		private ExpressionVariableEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object Wv02acci33u6u1FLqsP6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionTesterWindow expressionTesterWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new ExpressionVariableEditorWindow(expressionTesterWindow.FljUww12gT)
					{
						Owner = Window.GetWindow(expressionTesterWindow)
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					int num2 = 0;
					if (Wv02acci33u6u1FLqsP6 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
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
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					expressionTesterWindow.FljUww12gT.Add(_003Cdlg_003E5__2.ResultVariable);
					expressionTesterWindow.LuEFzVaoVx.Add(new ActionVariable
					{
						Key = _003Cdlg_003E5__2.ResultVariable.Key,
						Type = _003Cdlg_003E5__2.ResultVariable.VarType,
						Desc = _003Cdlg_003E5__2.ResultVariable.Description
					});
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool cyaYIAciEtt4bsPCv76T()
		{
			return Wv02acci33u6u1FLqsP6 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditVar_OnClick_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public ExpressionTesterWindow _003C_003E4__this;

		private ExpressionInputParam _003Citem_003E5__2;

		private ExpressionVariableEditorWindow _003Cdlg_003E5__3;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object fYU7MYci0ubugXxsoVMC;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionTesterWindow expressionTesterWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Citem_003E5__2 = (sender as Button).Tag as ExpressionInputParam;
					_003Cdlg_003E5__3 = new ExpressionVariableEditorWindow(expressionTesterWindow.FljUww12gT)
					{
						Owner = Window.GetWindow(expressionTesterWindow),
						EditingVariable = _003Citem_003E5__2
					};
					awaiter = _003Cdlg_003E5__3.MjdLOXIjD10(true).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				bool? result = awaiter.GetResult();
				int num2 = 1;
				if (!CgNNQtci11vpdaM7IZJ9())
				{
					goto IL_011a;
				}
				goto IL_011e;
				IL_011e:
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (result != true)
						{
							break;
						}
						goto IL_00e0;
					default:
						if (!string.Equals(_003Cdlg_003E5__3.ResultVariable.Key, _003Citem_003E5__2.Key))
						{
							expressionTesterWindow.CodeEditor.Text = expressionTesterWindow.CodeEditor.Text.Replace("{" + _003Citem_003E5__2.Key + "}", "{" + _003Cdlg_003E5__3.ResultVariable.Key + "}");
						}
						expressionTesterWindow.oMfFnJWMWX();
						break;
					}
					break;
					IL_00e0:
					int index = expressionTesterWindow.FljUww12gT.IndexOf(_003Citem_003E5__2);
					expressionTesterWindow.FljUww12gT[index] = _003Cdlg_003E5__3.ResultVariable;
					num2 = 0;
					if (fYU7MYci0ubugXxsoVMC == null)
					{
						continue;
					}
					goto IL_011a;
				}
				goto end_IL_0010;
				IL_011a:
				int num3 = default(int);
				num2 = num3;
				goto IL_011e;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Citem_003E5__2 = null;
				_003Cdlg_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Citem_003E5__2 = null;
			_003Cdlg_003E5__3 = null;
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

		internal static bool CgNNQtci11vpdaM7IZJ9()
		{
			return fYU7MYci0ubugXxsoVMC == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExpressionTesterWindow _003C_003E4__this;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object DoCIw8civJ6ZQIK8grou;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionTesterWindow expressionTesterWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0152;
				}
				int num2;
				if (!expressionTesterWindow.Bt6U2QWgkY && expressionTesterWindow.CodeEditor.Text.Length >= 3)
				{
					expressionTesterWindow.qEqULoAXGO.Expression = expressionTesterWindow.CodeEditor.Text;
					expressionTesterWindow.qEqULoAXGO.InputParams = expressionTesterWindow.FljUww12gT;
					num2 = 1;
					if (!Rw2XE1cidjTaheJgTlZ8())
					{
						goto IL_00eb;
					}
					goto IL_00ef;
				}
				AppHelper.ShowWarning("表达式不完整或有错误。", true);
				goto end_IL_0010;
				IL_0152:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_00eb:
				int num3 = default(int);
				num2 = num3;
				goto IL_00ef;
				IL_00ef:
				while (true)
				{
					ShareExpressionVm qEqULoAXGO;
					VarType value;
					switch (num2)
					{
					case 1:
						qEqULoAXGO = expressionTesterWindow.qEqULoAXGO;
						value = ((expressionTesterWindow.RyVUvWGOlx == null || expressionTesterWindow.RyVUvWGOlx.ObjValue == null) ? VarType.Any : expressionTesterWindow.RyVUvWGOlx.ObjValue.GetType().CSharpTypeToVarType());
						goto IL_00ac;
					}
					break;
					IL_00ac:
					qEqULoAXGO.ResultType = value;
					awaiter = new ShareExpressionWindow(expressionTesterWindow.qEqULoAXGO, expressionTesterWindow.RyVUvWGOlx)
					{
						Owner = expressionTesterWindow
					}.MjdLOXIjD10(true).GetAwaiter();
					num2 = 0;
					if (DoCIw8civJ6ZQIK8grou == null)
					{
						continue;
					}
					goto IL_00eb;
				}
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0152;
				end_IL_0010:;
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

		internal static bool Rw2XE1cidjTaheJgTlZ8()
		{
			return DoCIw8civJ6ZQIK8grou == null;
		}
	}

	private SmartCollection<ActionVariable> LuEFzVaoVx = new SmartCollection<ActionVariable>();

	private FullyObservableCollection<ExpressionInputParam> FljUww12gT = new FullyObservableCollection<ExpressionInputParam>();

	private bool jWRUtTqFMX;

	private EvalContext iqhUg9UCBm;

	private ShareExpressionVm qEqULoAXGO = new ShareExpressionVm();

	private ExpressionSampleResult RyVUvWGOlx;

	[CompilerGenerated]
	private string rDKUShkkL8;

	private bool Bt6U2QWgkY = true;

	private DebounceDispatcher yFxUu6lvDs = new DebounceDispatcher();

	[CompilerGenerated]
	private bool? ymGUNt5D5K;

	internal Grid NavWrapper;

	internal Button BtnShare;

	internal Button BtnSave;

	internal CodeEditor CodeEditor;

	internal CodeEditor TxtResult;

	internal Button BtnAddVar;

	internal ListBox LbVariables;

	private bool lrcUJEvkt7;

	internal static ExpressionTesterWindow Q9NUOxzUGJvZwdpVc73;

	public string ResultExpression
	{
		[CompilerGenerated]
		get
		{
			return rDKUShkkL8;
		}
		[CompilerGenerated]
		set
		{
			rDKUShkkL8 = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return ymGUNt5D5K;
		}
		[CompilerGenerated]
		set
		{
			ymGUNt5D5K = value;
		}
	}

	private static IList<ExpressionHelpItem> bO9FKjhpWm()
	{
		return new List<ExpressionHelpItem>
		{
			new ExpressionHelpItem
			{
				ForVarType = VarType.Text,
				Title = "是否为空",
				HelpOperation = ExpressionHelpOperation.Replace,
				HelpOperationData = "String.IsNullOrEmpty(%%)",
				ResultType = VarType.Boolean
			},
			new ExpressionHelpItem
			{
				ForVarType = VarType.Text,
				Title = "转大写",
				HelpOperation = ExpressionHelpOperation.Replace,
				HelpOperationData = "%%.ToUpper()",
				ResultType = VarType.Text
			},
			new ExpressionHelpItem
			{
				ForVarType = VarType.Number,
				Title = "解析Json文本",
				HelpOperation = ExpressionHelpOperation.Replace,
				HelpOperationData = "JsonConvert.DeserializeObject(%%)"
			},
			new ExpressionHelpItem
			{
				ForVarType = VarType.Number,
				Title = "四舍五入",
				HelpOperation = ExpressionHelpOperation.Replace,
				HelpOperationData = "Math.Max(%%, 小数点后位数)"
			}
		};
	}

	public ExpressionTesterWindow(IList<ActionVariable> variables, bool forAction = false, string expression = "$=")
	{
		if (variables.HasData())
		{
			LuEFzVaoVx.Reset(AppHelper.Clone(variables));
			jWRUtTqFMX = true;
		}
		InitializeComponent();
		if (forAction)
		{
			NavWrapper.Children.Clear();
			NavWrapper.Visibility = Visibility.Collapsed;
			BtnShare.Visibility = Visibility.Collapsed;
		}
		else
		{
			BtnSave.Visibility = Visibility.Collapsed;
		}
		iqhUg9UCBm = EvalManager.DefaultContext.Clone();
		CodeEditor.ActionVariables = LuEFzVaoVx;
		LbVariables.ItemsSource = FljUww12gT;
		CodeEditor.Text = (string.IsNullOrEmpty(expression) ? "$=" : expression);
		CodeEditor.TextArea.Caret.PositionChanged += vJfFprRNXb;
		CodeEditor.TextChanged += hJQFQOR6gJ;
		base.Loaded += upbFrXIBK2;
		FljUww12gT.ItemPropertyChanged += v4rFxBZoMo;
		if (forAction)
		{
			bNyFjifY04();
			oMfFnJWMWX();
		}
	}

	private void v4rFxBZoMo(object sender, ItemPropertyChangedEventArgs e)
	{
		oMfFnJWMWX();
	}

	private void upbFrXIBK2(object sender, RoutedEventArgs e)
	{
		Task.Run(_003C_003Ec.hjJveMFYmSE ?? (_003C_003Ec.hjJveMFYmSE = _003C_003Ec.mNXveTcfW4d.jDkveoK8nhD));
	}

	private void vJfFprRNXb(object sender, EventArgs e)
	{
	}

	private void vp9FB2dG4o()
	{
	}

	private void hJQFQOR6gJ(object sender, EventArgs e)
	{
		bNyFjifY04();
		oMfFnJWMWX();
	}

	private void bNyFjifY04()
	{
		string text = CodeEditor.Text;
		if (!LuEFzVaoVx.HasData())
		{
			return;
		}
		using IEnumerator<ActionVariable> enumerator = LuEFzVaoVx.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
			_003C_003Ec__DisplayClass19_.zcTveOur4MX = enumerator.Current;
			if (!FljUww12gT.Any(_003C_003Ec__DisplayClass19_.R9VveASTa2N) && text.Contains("{" + _003C_003Ec__DisplayClass19_.zcTveOur4MX.Key + "}"))
			{
				FljUww12gT.Add(new ExpressionInputParam
				{
					Key = _003C_003Ec__DisplayClass19_.zcTveOur4MX.Key,
					Description = _003C_003Ec__DisplayClass19_.zcTveOur4MX.Desc,
					VarType = _003C_003Ec__DisplayClass19_.zcTveOur4MX.Type,
					SampleValue = _003C_003Ec__DisplayClass19_.zcTveOur4MX.DefaultValue,
					IsKeyParam = (FljUww12gT.Count == 0)
				});
			}
		}
	}

	private void oMfFnJWMWX()
	{
		yFxUu6lvDs.Debounce(1000, uobF4dlGNV);
	}

	private void uobF4dlGNV(object object_0)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.SIkveUC5XEj = this;
		RyVUvWGOlx = null;
		Bt6U2QWgkY = true;
		int num = 0;
		if (Q9NUOxzUGJvZwdpVc73 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (string.IsNullOrEmpty(CodeEditor.Text) || !CodeEditor.Text.StartsWith("$="))
		{
			bbWFDQ8xxf("Error：表达式应该以$=开始");
			return;
		}
		_003C_003Ec__DisplayClass21_.I4wvelyBGT0 = CodeEditor.Text.Substring(2);
		_003C_003Ec__DisplayClass21_.acWveiAmSFZ = new Dictionary<string, object>();
		foreach (ExpressionInputParam item in FljUww12gT)
		{
			string text = "v_" + item.Key;
			if (_003C_003Ec__DisplayClass21_.I4wvelyBGT0.Contains("{" + item.Key + "}"))
			{
				_003C_003Ec__DisplayClass21_.I4wvelyBGT0 = _003C_003Ec__DisplayClass21_.I4wvelyBGT0.Replace("{" + item.Key + "}", text);
				object value = VariableHelper.ConvertVarDefaultValue(item.VarType, item.SampleValue ?? "");
				_003C_003Ec__DisplayClass21_.acWveiAmSFZ.Add(text, value);
			}
		}
		Task.Run((Action)_003C_003Ec__DisplayClass21_.rUnveFrquIw);
	}

	private bool MWmF5nwNWl(Type type_0)
	{
		if (!type_0.IsPrimitive)
		{
			return type_0.Equals(typeof(string));
		}
		return true;
	}

	private void bbWFDQ8xxf(string string_1)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.PxjvefkWh5x = this;
		_003C_003Ec__DisplayClass23_.L4Hvez2gjf3 = string_1;
		base.Dispatcher.Invoke(_003C_003Ec__DisplayClass23_.e90ve3CeTRH);
	}

	[AsyncStateMachine(typeof(_003CBtnEditVar_OnClick_003Ed__24))]
	private void AWMFd9wFSZ(object sender, RoutedEventArgs e)
	{
		_003CBtnEditVar_OnClick_003Ed__24 stateMachine = default(_003CBtnEditVar_OnClick_003Ed__24);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnAddVar_OnClick_003Ed__25))]
	private void t9SFoUUQkN(object sender, RoutedEventArgs e)
	{
		_003CBtnAddVar_OnClick_003Ed__25 stateMachine = default(_003CBtnAddVar_OnClick_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void kWAFTPhV88(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement)?.Tag is ExpressionInputParam item)
		{
			FljUww12gT.Remove(item);
		}
	}

	private void sWvFMVHG04(object sender, MouseEventArgs e)
	{
		if (Mouse.LeftButton == MouseButtonState.Pressed && (sender as FrameworkElement)?.Tag is ActionVariable actionVariable)
		{
			AppHelper.DoDragDropWrap(sender as FrameworkElement, "{" + actionVariable.Key + "}", DragDropEffects.Copy);
		}
	}

	private void sSmFACYAil(object sender, RoutedEventArgs e)
	{
		ExpressionHelpItem expressionHelpItem_ = (sender as Button).Tag as ExpressionHelpItem;
		SxWFFvvo2d(expressionHelpItem_);
	}

	private void HsMFOBiI1w(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && e.ClickCount >= 2)
		{
			ExpressionHelpItem expressionHelpItem_ = (sender as Grid).Tag as ExpressionHelpItem;
			SxWFFvvo2d(expressionHelpItem_);
			e.Handled = true;
		}
	}

	private void SxWFFvvo2d(ExpressionHelpItem expressionHelpItem_0)
	{
		(string, int, int) tuple = LT5FUNV5HJ();
		if (!string.IsNullOrEmpty(tuple.Item1))
		{
			string text = expressionHelpItem_0.HelpOperationData.Replace("%%", "{" + tuple.Item1 + "}");
			CodeEditor.Document.Replace(tuple.Item2, tuple.Item1.Length + 2, text);
		}
	}

	private (string varName, int startPos, int endPos) LT5FUNV5HJ()
	{
		int caretOffset = CodeEditor.CaretOffset;
		string text = CodeEditor.Text;
		int num = -1;
		int num2 = caretOffset - 1;
		while (num2 >= 0)
		{
			if (text[num2] != '{')
			{
				num2--;
				continue;
			}
			num = num2;
			break;
		}
		if (num < 0)
		{
			return (varName: null, startPos: 0, endPos: 0);
		}
		int num3 = -1;
		for (int i = num + 1; i < text.Length; i++)
		{
			if (text[i] == '}')
			{
				num3 = i;
			}
		}
		if (num3 >= caretOffset - 1 && num3 < text.Length)
		{
			return (varName: text.Substring(num + 1, num3 - num - 1), startPos: num, endPos: num3);
		}
		return (varName: null, startPos: 0, endPos: 0);
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__32))]
	private void aUAFlocBmc(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__32 stateMachine = default(_003CBtnShare_OnClick_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void EPDFiRbkNG(object sender, RoutedEventArgs e)
	{
	}

	private void ExpressionLibControl_OnExpressionSelected(object sender, SharedExpressionDto e)
	{
		wsAF30Dm1L(e);
	}

	private void wsAF30Dm1L(SharedExpressionDto sharedExpressionDto_0)
	{
		qEqULoAXGO.Id = sharedExpressionDto_0.Id;
		qEqULoAXGO.Title = sharedExpressionDto_0.Title;
		qEqULoAXGO.Description = sharedExpressionDto_0.Expression;
		qEqULoAXGO.Keywords = sharedExpressionDto_0.Keywords;
		qEqULoAXGO.InputParams = AppHelper.Clone(sharedExpressionDto_0.InputParams);
		qEqULoAXGO.Expression = sharedExpressionDto_0.Expression;
		qEqULoAXGO.ResultType = sharedExpressionDto_0.ResultType;
		int num = 0;
		if (!Qigd5wzxZ1vU0IkxBKc())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		qEqULoAXGO.IsPublic = sharedExpressionDto_0.IsPublic;
		qEqULoAXGO.ResultDescription = sharedExpressionDto_0.ResultDescription;
		qEqULoAXGO.ForVarType = sharedExpressionDto_0.ForVarType;
		FljUww12gT.Reset(qEqULoAXGO.InputParams);
		LuEFzVaoVx.Reset(qEqULoAXGO.InputParams.Select(_003C_003EO.nUjvedGOYPl ?? (_003C_003EO.nUjvedGOYPl = ExpressionParamToActionVariable)));
		CodeEditor.Text = qEqULoAXGO.Expression;
		oMfFnJWMWX();
	}

	public static ActionVariable ExpressionParamToActionVariable(ExpressionInputParam inParam)
	{
		return new ActionVariable
		{
			Key = inParam.Key,
			Desc = inParam.Description,
			Type = inParam.VarType,
			DefaultValue = inParam.SampleValue
		};
	}

	private void W2uFf3DRIJ(object sender, RoutedEventArgs e)
	{
		ResultExpression = CodeEditor.Text;
		this.ThNvuM5Q9GQ(true);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lrcUJEvkt7)
		{
			lrcUJEvkt7 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/expressiontester/expressiontesterwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			NavWrapper = (Grid)target;
			return;
		case 2:
			BtnShare = (Button)target;
			BtnShare.Click += aUAFlocBmc;
			return;
		case 3:
			BtnSave = (Button)target;
			BtnSave.Click += W2uFf3DRIJ;
			return;
		case 4:
			CodeEditor = (CodeEditor)target;
			return;
		case 5:
			TxtResult = (CodeEditor)target;
			return;
		case 6:
			BtnAddVar = (Button)target;
			BtnAddVar.Click += t9SFoUUQkN;
			return;
		case 7:
			LbVariables = (ListBox)target;
			return;
		}
		lrcUJEvkt7 = true;
		if (Qigd5wzxZ1vU0IkxBKc())
		{
			switch (0)
			{
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 8:
			((Grid)target).MouseMove += sWvFMVHG04;
			break;
		case 9:
			((Button)target).Click += AWMFd9wFSZ;
			break;
		case 10:
			((Button)target).Click += kWAFTPhV88;
			break;
		}
	}

	internal static bool Qigd5wzxZ1vU0IkxBKc()
	{
		return Q9NUOxzUGJvZwdpVc73 == null;
	}
}
