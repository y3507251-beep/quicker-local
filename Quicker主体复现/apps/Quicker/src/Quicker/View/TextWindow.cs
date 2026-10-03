using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Xps;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EOqy55MyMeuU2apYyog;
using FindReplace;
using HandyControl.Controls;
using HandyControl.Tools;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Indentation;
using ICSharpCode.AvalonEdit.Search;
using ICSharpCode.AvalonEdit.Utils;
using k7aPL5fDWhslvV5ur2A;
using log4net;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Domain.ContextMenus;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Texting;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.UI;
using t7wokwYFlDgjUncgQNA;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View;

public class TextWindow : HandyControl.Controls.Window, IComponentConnector, IDisposable, IStyleConnector, iTHRNJY2ZQQokysD4pN
{
	public enum ResultOperation
	{
		None,
		ReplaceAll,
		ReplaceSelection,
		Copy,
		InsertAfter,
		Append,
		CaretTo
	}

	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static DataObjectSettingDataEventHandler sqQSxY1NmdJ;

		static _003C_003EO()
		{
		}

		internal static void S64OXcWRBFEWSOsUtSIg()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec QQDSx1oYmde;

		public static Func<ActionVariable, bool> YiUSxbbr0nB;

		public static Func<ActionVariable, bool> OysSx6EB51R;

		public static Func<ActionVariable, bool> AfgSxXtWtQh;

		public static Func<ActionVariable, bool> BJBSxmpRTrl;

		public static Func<ActionVariable, bool> xDDSxKmmI79;

		public static Func<ITextAreaInputHandler, bool> LCwSxxt7ON9;

		internal static _003C_003Ec q5AEEqWRvBpAiYJmR9mX;

		static _003C_003Ec()
		{
			QQDSx1oYmde = new _003C_003Ec();
		}

		internal bool wKfSxIUTfVj(ActionVariable x)
		{
			if (x.IsInput)
			{
				return string.Equals(x.Key, "_editor", StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		internal bool CMASxWlcAj1(ActionVariable x)
		{
			return string.Equals(x.Key, "input", StringComparison.OrdinalIgnoreCase);
		}

		internal bool eA0Sxk6sWsh(ActionVariable x)
		{
			return string.Equals(x.Key, "params", StringComparison.OrdinalIgnoreCase);
		}

		internal bool un4SxGLnqjf(ActionVariable x)
		{
			return string.Equals(x.Key, "output", StringComparison.OrdinalIgnoreCase);
		}

		internal bool m9PSxsSpDYg(ActionVariable x)
		{
			if (x.IsOutput)
			{
				return string.Equals(x.Key, "caretOffset", StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		internal bool k6USxHyBVOa(ITextAreaInputHandler x)
		{
			return x is SearchInputHandler;
		}

		internal static bool j3MyA0WRdKANV8qa3US2()
		{
			return q5AEEqWRvBpAiYJmR9mX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass120_0
	{
		public ResultOperation WW8Sxp9cjv8;

		public TextWindow THUSxBhClbf;

		public string vNtSxQYqQhb;

		public int? xQUSxjWMpmb;

		public bool sRlSxnZ2fhZ;

		public bool jB3Sx4tVqtA;

		public bool raXSx5a6wYA;

		private static _003C_003Ec__DisplayClass120_0 lZFMpAWRaTCuiTbOcD7L;

		internal void hxOSxrjfyTG()
		{
			int num4 = default(int);
			int num3;
			int? num;
			int num2;
			switch (WW8Sxp9cjv8)
			{
			case ResultOperation.None:
				if (xQUSxjWMpmb.HasValue)
				{
					int int_ = THUSxBhClbf.TheText.CaretOffset + xQUSxjWMpmb.Value;
					THUSxBhClbf.jVqgUyX0xeZ(int_);
				}
				break;
			case ResultOperation.ReplaceAll:
				THUSxBhClbf.TheText.SelectAll();
				THUSxBhClbf.TheText.SelectedText = vNtSxQYqQhb;
				goto IL_041d;
			case ResultOperation.ReplaceSelection:
				if (jB3Sx4tVqtA)
				{
					DocumentLine lineByOffset = THUSxBhClbf.TheText.Document.GetLineByOffset(THUSxBhClbf.TheText.SelectionStart);
					DocumentLine lineByOffset2 = THUSxBhClbf.TheText.Document.GetLineByOffset(THUSxBhClbf.TheText.SelectionStart + THUSxBhClbf.TheText.SelectionLength);
					THUSxBhClbf.TheText.Select(lineByOffset.Offset, lineByOffset2.EndOffset - lineByOffset.Offset);
				}
				THUSxBhClbf.TheText.SelectedText = vNtSxQYqQhb;
				num = xQUSxjWMpmb;
				goto IL_0228;
			case ResultOperation.Copy:
				ClipboardHelper.SetText(vNtSxQYqQhb);
				break;
			case ResultOperation.InsertAfter:
				if (!string.IsNullOrEmpty(vNtSxQYqQhb))
				{
					num4 = THUSxBhClbf.TheText.SelectionStart + THUSxBhClbf.TheText.SelectionLength;
					THUSxBhClbf.TheText.Document.Insert(num4, vNtSxQYqQhb);
					num = xQUSxjWMpmb;
					num2 = 0;
					if (!(num > 0))
					{
						num = xQUSxjWMpmb;
						num2 = 0;
						if (!((num.GetValueOrDefault() == 0) & num.HasValue) || sRlSxnZ2fhZ)
						{
							num = xQUSxjWMpmb;
							num3 = 0;
							if (lZFMpAWRaTCuiTbOcD7L != null)
							{
								goto IL_025b;
							}
							goto IL_0280;
						}
					}
					THUSxBhClbf.jVqgUyX0xeZ(num4 + xQUSxjWMpmb.Value);
					goto IL_02fd;
				}
				AppHelper.ShowInformation("要插入的内容为空。");
				break;
			case ResultOperation.Append:
				if (!string.IsNullOrEmpty(vNtSxQYqQhb))
				{
					THUSxBhClbf.TheText.AppendText(vNtSxQYqQhb);
				}
				break;
			case ResultOperation.CaretTo:
				{
					if (xQUSxjWMpmb.HasValue)
					{
						num = xQUSxjWMpmb;
						goto IL_0563;
					}
					break;
				}
				IL_041d:
				if (!xQUSxjWMpmb.HasValue)
				{
					break;
				}
				THUSxBhClbf.TheText.TextArea.ClearSelection();
				num = xQUSxjWMpmb;
				num2 = 0;
				if (!(num < 0))
				{
					num = xQUSxjWMpmb;
					num2 = 0;
					if (!((num.GetValueOrDefault() == 0) & num.HasValue & sRlSxnZ2fhZ))
					{
						num = xQUSxjWMpmb;
						num2 = 0;
						if (!(num > 0))
						{
							num = xQUSxjWMpmb;
							num2 = 0;
							if (!((num.GetValueOrDefault() == 0) & num.HasValue) || sRlSxnZ2fhZ)
							{
								break;
							}
						}
						THUSxBhClbf.jVqgUyX0xeZ(xQUSxjWMpmb.Value);
						break;
					}
				}
				THUSxBhClbf.jVqgUyX0xeZ(THUSxBhClbf.TheText.Text.Length + xQUSxjWMpmb.Value);
				break;
				IL_025b:
				switch (num3)
				{
				case 3:
					break;
				default:
					goto IL_0280;
				case 2:
					goto IL_02fd;
				case 1:
					return;
				case 6:
					goto IL_0323;
				case 7:
					goto IL_041d;
				case 4:
					goto IL_0563;
				case 5:
					goto IL_057a;
				}
				goto IL_0228;
				IL_0563:
				num2 = 0;
				if (num < 0)
				{
					goto IL_057a;
				}
				goto IL_05c3;
				IL_0342:
				THUSxBhClbf.jVqgUyX0xeZ(THUSxBhClbf.TheText.SelectionStart + xQUSxjWMpmb.Value);
				THUSxBhClbf.TheText.TextArea.ClearSelection();
				break;
				IL_05c3:
				THUSxBhClbf.jVqgUyX0xeZ(xQUSxjWMpmb.Value);
				break;
				IL_02fd:
				THUSxBhClbf.TheText.TextArea.ClearSelection();
				num3 = 1;
				if (VZPo8jWRrDnfLHfSyZM2())
				{
					break;
				}
				goto IL_025b;
				IL_057a:
				xQUSxjWMpmb = THUSxBhClbf.TheText.Text.Length + xQUSxjWMpmb;
				goto IL_05c3;
				IL_0280:
				num2 = 0;
				if (!(num < 0))
				{
					num = xQUSxjWMpmb;
					num2 = 0;
					if (!((num.GetValueOrDefault() == 0) & num.HasValue & sRlSxnZ2fhZ))
					{
						THUSxBhClbf.jVqgUyX0xeZ(num4 + vNtSxQYqQhb.Length);
						goto IL_02fd;
					}
				}
				THUSxBhClbf.jVqgUyX0xeZ(num4 + vNtSxQYqQhb.Length + xQUSxjWMpmb.Value);
				goto IL_02fd;
				IL_0323:
				num2 = 0;
				if (!((num.GetValueOrDefault() == 0) & num.HasValue) || sRlSxnZ2fhZ)
				{
					if (raXSx5a6wYA)
					{
						num = xQUSxjWMpmb;
						num2 = 0;
						if (!(num < 0))
						{
							num = xQUSxjWMpmb;
							num2 = 0;
							if (!((num.GetValueOrDefault() == 0) & num.HasValue & sRlSxnZ2fhZ))
							{
								break;
							}
						}
					}
					THUSxBhClbf.jVqgUyX0xeZ(THUSxBhClbf.TheText.SelectionStart + THUSxBhClbf.TheText.SelectionLength + xQUSxjWMpmb.GetValueOrDefault());
					THUSxBhClbf.TheText.TextArea.ClearSelection();
					break;
				}
				goto IL_0342;
				IL_0228:
				num2 = 0;
				if (!(num > 0))
				{
					num = xQUSxjWMpmb;
					num3 = 6;
					if (!VZPo8jWRrDnfLHfSyZM2())
					{
						int num5 = default(int);
						num3 = num5;
					}
					goto IL_025b;
				}
				goto IL_0342;
			}
		}

		internal static bool VZPo8jWRrDnfLHfSyZM2()
		{
			return lZFMpAWRaTCuiTbOcD7L == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass124_0
	{
		public SubProgram MOcSxdtqq51;

		public ActionExecuteContext YRpSxocJAJy;

		public TextWindow cnYSxTHrVcy;

		public string hYhSxMtM2PZ;

		public string QQKSxAIBbgJ;

		public bool XhUSxOhYFqs;

		public string P6JSxFXEYCN;

		public ActionExecuteContext HYkSxUhwxw6;

		public string rJ5SxlyH6RR;

		internal static _003C_003Ec__DisplayClass124_0 u9lANOWRokDcUMqeFgxa;

		internal void AiqSxDHfSeE()
		{
			try
			{
				XAction xAction = new XAction
				{
					Steps = MOcSxdtqq51.Steps,
					Variables = MOcSxdtqq51.Variables,
					SubPrograms = YRpSxocJAJy.XProgram.SubPrograms
				};
				HYkSxUhwxw6.XProgram = xAction;
				HYkSxUhwxw6.ActionLogger = YRpSxocJAJy.ActionLogger;
				if (MOcSxdtqq51.Variables.HasData())
				{
					foreach (ActionVariable variable in MOcSxdtqq51.Variables)
					{
						HYkSxUhwxw6.SetVarValueWithoutConvert(variable.Key, VariableHelper.ConvertVarDefaultValue(variable.Type, variable.DefaultValue));
					}
				}
				while (true)
				{
					HYkSxUhwxw6.SetVarValueWithoutConvert("quicker_in_param", HYkSxUhwxw6.RootContext.InputParam ?? string.Empty);
					ActionVariable actionVariable = MOcSxdtqq51.Variables.FirstOrDefault(_003C_003Ec.YiUSxbbr0nB ?? (_003C_003Ec.YiUSxbbr0nB = _003C_003Ec.QQDSx1oYmde.wKfSxIUTfVj));
					if (actionVariable != null)
					{
						HYkSxUhwxw6.SetVarValueWithoutConvert(actionVariable.Key, cnYSxTHrVcy.TheText);
					}
					while (true)
					{
						IL_0140:
						ActionVariable actionVariable2 = MOcSxdtqq51.Variables.FirstOrDefault(_003C_003Ec.OysSx6EB51R ?? (_003C_003Ec.OysSx6EB51R = _003C_003Ec.QQDSx1oYmde.CMASxWlcAj1));
						if (actionVariable2 == null)
						{
							if (!string.IsNullOrEmpty(hYhSxMtM2PZ))
							{
								throw new InvalidOperationException("子程序缺少作为输入的Input变量.");
							}
						}
						else
						{
							if (!actionVariable2.IsInput)
							{
								throw new InvalidOperationException("Input变量需要自用作为子程序输入使用的选项.");
							}
							HYkSxUhwxw6.SetVarValueWithoutConvert(actionVariable2.Key, VariableHelper.ConvertToType(actionVariable2.Type, hYhSxMtM2PZ));
						}
						ActionVariable actionVariable3 = MOcSxdtqq51.Variables.FirstOrDefault(_003C_003Ec.AfgSxXtWtQh ?? (_003C_003Ec.AfgSxXtWtQh = _003C_003Ec.QQDSx1oYmde.eA0Sxk6sWsh));
						if (actionVariable3 != null || string.IsNullOrEmpty(QQKSxAIBbgJ))
						{
							if (actionVariable3 != null && !string.IsNullOrEmpty(QQKSxAIBbgJ))
							{
								if (actionVariable3.Type != VarType.Dict)
								{
									goto IL_02d7;
								}
								Dictionary<string, object> dictionary = new Dictionary<string, object>();
								NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(QQKSxAIBbgJ);
								string[] allKeys = nameValueCollection.AllKeys;
								foreach (string text in allKeys)
								{
									dictionary.Add(text, nameValueCollection[text]);
								}
								HYkSxUhwxw6.SetVarValueWithoutConvert(actionVariable3.Key, dictionary);
							}
							goto IL_02f9;
						}
						throw new InvalidOperationException("子程序缺少作为输入的Params变量.");
						IL_02d7:
						HYkSxUhwxw6.SetVarValueWithoutConvert(actionVariable3.Key, VariableHelper.ConvertToType(actionVariable3.Type, QQKSxAIBbgJ));
						goto IL_02f9;
						IL_02f9:
						XActionRunner.RunChildSteps(MOcSxdtqq51.Steps, 0, HYkSxUhwxw6, xAction, "");
						if (!HYkSxUhwxw6.ReturnError)
						{
							ActionVariable actionVariable4 = MOcSxdtqq51.Variables.FirstOrDefault(_003C_003Ec.BJBSxmpRTrl ?? (_003C_003Ec.BJBSxmpRTrl = _003C_003Ec.QQDSx1oYmde.un4SxGLnqjf));
							while (true)
							{
								if (XhUSxOhYFqs)
								{
									if (u9lANOWRokDcUMqeFgxa != null)
									{
										switch (0)
										{
										case 2:
											break;
										case 4:
											goto IL_0140;
										case 3:
											continue;
										case 1:
											goto IL_02d7;
										default:
											goto IL_0391;
										}
										break;
									}
									goto IL_0391;
								}
								rJ5SxlyH6RR = "";
								goto IL_03d0;
								IL_0391:
								if (actionVariable4 == null)
								{
									throw new Exception("子程序缺少输出变量Output");
								}
								rJ5SxlyH6RR = Convert.ToString(VariableHelper.ConvertToType(VarType.Text, HYkSxUhwxw6.GetVarValue(actionVariable4.Key)));
								goto IL_03d0;
								IL_03d0:
								ActionVariable actionVariable5 = MOcSxdtqq51.Variables.FirstOrDefault(_003C_003Ec.xDDSxKmmI79 ?? (_003C_003Ec.xDDSxKmmI79 = _003C_003Ec.QQDSx1oYmde.m9PSxsSpDYg));
								if (actionVariable5 != null)
								{
									P6JSxFXEYCN = Convert.ToString(VariableHelper.ConvertToType(VarType.Text, HYkSxUhwxw6.GetVarValue(actionVariable5.Key)));
								}
								goto end_IL_00c8;
							}
							break;
						}
						throw new Exception("子程序 " + MOcSxdtqq51.Name + " 运行失败：" + HYkSxUhwxw6.ReturnResult);
					}
					continue;
					end_IL_00c8:
					break;
				}
			}
			finally
			{
				YRpSxocJAJy.ChildContext = null;
			}
			cnYSxTHrVcy.Gqagl2xRlaf = null;
		}

		internal static bool yQpPFnWRfHUm0MpRPGLx()
		{
			return u9lANOWRokDcUMqeFgxa == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCallSubProgramAsync_003Ed__124 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string result, string caretOffset)> _003C_003Et__builder;

		public TextWindow _003C_003E4__this;

		public string input;

		public string operationParams;

		public bool requireOutput;

		public string subProgramName;

		private _003C_003Ec__DisplayClass124_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object b2ilcqWRlWxZ0ZPPImp6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			(bool, string, string) result;
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass124_0();
					_003C_003E8__1.cnYSxTHrVcy = _003C_003E4__this;
					_003C_003E8__1.hYhSxMtM2PZ = input;
					_003C_003E8__1.QQKSxAIBbgJ = operationParams;
					_003C_003E8__1.XhUSxOhYFqs = requireOutput;
					_003C_003E8__1.YRpSxocJAJy = textWindow.ActionContext;
					_003C_003E8__1.P6JSxFXEYCN = null;
					if (!EXji2kWRZKGr1aMY1jiS())
					{
						switch (0)
						{
						}
					}
					_003C_003E8__1.MOcSxdtqq51 = SubProgramStep.GetSubProgram(_003C_003E8__1.YRpSxocJAJy, subProgramName);
					if (_003C_003E8__1.MOcSxdtqq51 == null)
					{
						throw new InvalidOperationException("无法找到子程序：" + _003C_003E8__1.MOcSxdtqq51);
					}
					_003C_003E8__1.HYkSxUhwxw6 = new ActionExecuteContext(_003C_003E8__1.YRpSxocJAJy, _003C_003E8__1.YRpSxocJAJy.Action, _003C_003E8__1.YRpSxocJAJy.TargetInfo, _003C_003E8__1.YRpSxocJAJy.AppServer, _003C_003E8__1.YRpSxocJAJy.IsDebugging, _003C_003E8__1.YRpSxocJAJy.Id, null, _003C_003E8__1.YRpSxocJAJy.CancellationToken);
				}
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003E8__1.HYkSxUhwxw6.ParentWindow = textWindow;
						_003C_003E8__1.YRpSxocJAJy.ChildContext = _003C_003E8__1.HYkSxUhwxw6;
						textWindow.Gqagl2xRlaf = _003C_003E8__1.HYkSxUhwxw6;
						_003C_003E8__1.rJ5SxlyH6RR = "";
						ConfiguredTaskAwaitable configuredTaskAwaitable = GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(_003C_003E8__1.AiqSxDHfSeE, "textwindow:sp:" + subProgramName).ConfigureAwait(true);
						int num2 = 0;
						if (b2ilcqWRlWxZ0ZPPImp6 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = configuredTaskAwaitable.GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
					result = (_003C_003E8__1.HYkSxUhwxw6.IsSubProgramSuccess(), _003C_003E8__1.rJ5SxlyH6RR, _003C_003E8__1.P6JSxFXEYCN);
				}
				finally
				{
					if (num < 0 && _003C_003E8__1.HYkSxUhwxw6 != null)
					{
						((IDisposable)_003C_003E8__1.HYkSxUhwxw6).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		static _003CCallSubProgramAsync_003Ed__124()
		{
		}

		internal static bool EXji2kWRZKGr1aMY1jiS()
		{
			return b2ilcqWRlWxZ0ZPPImp6 == null;
		}

		internal static void RCgIFCWRRBdRAUoYh3Fw()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteSp_003Ed__101 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string spName;

		public TextWindow _003C_003E4__this;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		internal static object m0LlGpWRgKsUIXowbgs2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				if (num == 0 || !string.IsNullOrWhiteSpace(spName))
				{
					try
					{
						TaskAwaiter<IDictionary<string, object>> awaiter;
						if (num != 0)
						{
							awaiter = textWindow.ActionContext.RunSpAsync(spName, new Dictionary<string, object>
							{
								{
									"_handle",
									textWindow.GetHandle()
								},
								{ "_windowId", textWindow.AutoCloseKey },
								{ "_window", textWindow },
								{ "_windowLocation", textWindow.LastWindowLocation }
							}).GetAwaiter();
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
							if (wdRX0bWRPxNk5oUCYd0m())
							{
								switch (0)
								{
								}
							}
						}
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						JPRgUjETnjT.Warn("执行Onloaded子程序" + spName + "出错：" + ex.Message, ex);
						AppHelper.ShowWarning("执行Onloaded子程序" + spName + "出错：" + ex.Message);
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

		internal static bool wdRX0bWRPxNk5oUCYd0m()
		{
			return m0LlGpWRgKsUIXowbgs2 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToLine_003Ed__147 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextWindow _003C_003E4__this;

		private GoToLineWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object Kb6gUsWRUTw3ZedbGciQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					int lineCount = textWindow.TheText.LineCount;
					int line = textWindow.TheText.TextArea.Document.GetLocation(textWindow.TheText.CaretOffset).Line;
					_003Cdlg_003E5__2 = new GoToLineWindow(lineCount, line)
					{
						Owner = textWindow
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
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
					int num2 = 0;
					if (Kb6gUsWRUTw3ZedbGciQ != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						textWindow.X3sgU1tckBT(_003Cdlg_003E5__2.GoToLineNumber);
						break;
					}
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

		internal static bool y9FK01WRxEV6paDTuQRm()
		{
			return Kb6gUsWRUTw3ZedbGciQ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__116 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object w9TjfXWRt9bHofkKky2m;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00de;
				}
				if (!textWindow.ShowBuildInToolbar)
				{
					int num2 = 0;
					if (!sMXTOVWRSsSY5YM86c1D())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					textWindow.BuildInToolBar.Visibility = Visibility.Collapsed;
				}
				textWindow.Activate();
				try
				{
					textWindow.TheText.Focus();
				}
				catch (Exception ex)
				{
					JPRgUjETnjT.Warn("焦点设置出错：" + ex.Message);
				}
				textWindow.MoPgU0KwMF0();
				if (!string.IsNullOrEmpty(textWindow.AutoSaveStateKey))
				{
					textWindow.SaveState();
					textWindow.I9SgUBV8V9N(new DebounceDispatcher());
				}
				textWindow.xgxglSsMUqZ = textWindow.Topmost;
				WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(textWindow, textWindow.ak4gUKQq8fw);
				if (!string.IsNullOrEmpty(textWindow.SpWhenWindowLoaded))
				{
					goto IL_00de;
				}
				goto end_IL_0010;
				IL_00de:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = textWindow.Y8IgFfjwo5l(textWindow.SpWhenWindowLoaded).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							int num4 = 0;
							if (!sMXTOVWRSsSY5YM86c1D())
							{
								int num5 = default(int);
								num4 = num5;
							}
							switch (num4)
							{
							}
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception ex2)
				{
					JPRgUjETnjT.Warn("执行Onloaded子程序" + textWindow.SpWhenWindowLoaded + "出错：" + ex2.Message, ex2);
					AppHelper.ShowWarning("执行Onloaded子程序" + textWindow.SpWhenWindowLoaded + "出错：" + ex2.Message);
				}
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

		internal static bool sMXTOVWRSsSY5YM86c1D()
		{
			return w9TjfXWRt9bHofkKky2m == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnWindowClosing_003Ed__100 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object QfjZllWRC7iZEj4p1xtZ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num != 0)
				{
					textWindow.Deactivated -= textWindow.MDWgUvqsqII;
					textWindow.nJIgUggTdFN();
					int num2 = 1;
					if (!oXgKsPWR7YapLB77u2bI())
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (textWindow.OwnedWindows.Count > 0)
							{
								IEnumerator enumerator = textWindow.OwnedWindows.GetEnumerator();
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
											JPRgUjETnjT.Warn("关闭子窗口出错：" + ex.Message);
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
							if (textWindow.Gqagl2xRlaf != null)
							{
								textWindow.Gqagl2xRlaf.StopAction(ActionStopFlag.ForceStop, "父窗口已关闭");
							}
							awaiter = textWindow.Y8IgFfjwo5l(textWindow.SpWhenWindowClosing).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								break;
							}
							num2 = 0;
							if (!oXgKsPWR7YapLB77u2bI())
							{
								continue;
							}
							goto default;
						default:
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool oXgKsPWR7YapLB77u2bI()
		{
			return QfjZllWRC7iZEj4p1xtZ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COperationItemOnClick_003Ed__118 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TextWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object OQLL3VWRz5epyHpVMgu3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (OQLL3VWRz5epyHpVMgu3 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					string string_ = ((sender as FrameworkElement).Tag as string) ?? "";
					awaiter = textWindow.o8ggUPkS1Tl(string_).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool A6xwx4WgVUm6nKdtOVUr()
		{
			return OQLL3VWRz5epyHpVMgu3 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessAction_003Ed__119 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string key;

		public TextWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object qTFbJ4WgFhwFVM7gOr5B;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c2;
				}
				if (key.StartsWith("call:", StringComparison.OrdinalIgnoreCase))
				{
					ConfiguredTaskAwaitable configuredTaskAwaitable = textWindow.Iv7gUE0RXAA(key.Substring("call:".Length)).ConfigureAwait(true);
					if (qTFbJ4WgFhwFVM7gOr5B != null)
					{
						switch (0)
						{
						}
					}
					awaiter = configuredTaskAwaitable.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c2;
				}
				textWindow.SelectedOperation = key;
				textWindow.Close();
				goto end_IL_000e;
				IL_00c2:
				awaiter.GetResult();
				end_IL_000e:;
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

		internal static bool SQyITyWgcwQo5sw7rnNF()
		{
			return qTFbJ4WgFhwFVM7gOr5B == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessButtonAsync_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TextWindow _003C_003E4__this;

		public string command;

		private _003C_003Ec__DisplayClass120_0 _003C_003E8__1;

		private TaskAwaiter<(bool isSuccess, string result, string caretOffset)> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object kZ7KsoWgpcPdetnoFTMU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextWindow textWindow = _003C_003E4__this;
			try
			{
				string[] array = default(string[]);
				string text = default(string);
				string text4 = default(string);
				string text5 = default(string);
				switch (num)
				{
				default:
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass120_0();
					_003C_003E8__1.THUSxBhClbf = _003C_003E4__this;
					array = command.Split(new char[1] { '$' }, 4, StringSplitOptions.None);
					if (array.Length == 4)
					{
						text = "";
						bool flag = false;
						_003C_003E8__1.raXSx5a6wYA = false;
						_003C_003E8__1.jB3Sx4tVqtA = false;
						string text2 = array[0].ToLower();
						if (!UubT35WgXd8FOe7xbw0U())
						{
							goto IL_0b10;
						}
						string[] array2 = default(string[]);
						string text3 = default(string);
						TextDocument document;
						DocumentLine lineByOffset2;
						DocumentLine lineByOffset3;
						char c = default(char);
						switch (18)
						{
						case 8:
							break;
						case 18:
							switch (text2)
							{
							case "a":
							case "all":
								break;
							case "n":
							case "none":
								goto IL_01f0;
							case "l":
							case "line":
								goto IL_020d;
							case "o":
							case "auto":
								goto IL_0289;
							case "s":
							case "selected":
							case "selection":
								goto IL_02f1;
							default:
								goto IL_06e9;
							}
							text = textWindow.TheText.Text;
							flag = false;
							goto case 5;
						case 15:
							if (text2 == "auto")
							{
								goto IL_0289;
							}
							goto IL_06e9;
						case 10:
							flag = false;
							goto case 5;
						case 5:
						case 14:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.None;
							_003C_003E8__1.xQUSxjWMpmb = null;
							_003C_003E8__1.sRlSxnZ2fhZ = true;
							if (array[1].Contains('-'))
							{
								array2 = array[1].ToLower().Split('-');
								text3 = array2[0];
								goto case 12;
							}
							if (array[1].Contains('+'))
							{
								string[] array3 = array[1].ToLower().Split('+');
								text3 = array3[0];
								if (!string.IsNullOrEmpty(array3[1]))
								{
									_003C_003E8__1.xQUSxjWMpmb = Convert.ToInt32(array3[1]);
								}
								else
								{
									_003C_003E8__1.xQUSxjWMpmb = 0;
								}
								_003C_003E8__1.sRlSxnZ2fhZ = false;
							}
							else
							{
								text3 = array[1];
							}
							goto IL_0486;
						case 12:
							if (!string.IsNullOrEmpty(array2[1]))
							{
								_003C_003E8__1.xQUSxjWMpmb = -1 * Convert.ToInt32(array2[1]);
							}
							else
							{
								_003C_003E8__1.xQUSxjWMpmb = 0;
							}
							_003C_003E8__1.sRlSxnZ2fhZ = true;
							goto IL_0486;
						case 4:
							if (c == 'o')
							{
								goto IL_0715;
							}
							if (c == 's')
							{
								goto IL_056e;
							}
							goto IL_0813;
						case 11:
							if (c == 's' && text3 == "rs")
							{
								goto IL_056e;
							}
							goto IL_0813;
						case 3:
							goto IL_05a6;
						default:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.Copy;
							goto case 1;
						case 19:
							if (text3 == "ro")
							{
								goto IL_0715;
							}
							goto IL_0813;
						case 1:
						{
							string[] array4 = array[3].Split(new char[1] { '?' }, 2);
							text4 = array4[0];
							text5 = ((array4.Length > 1) ? array4[1] : "");
							_003C_003E8__1.vNtSxQYqQhb = "";
							text2 = array[2].ToLower();
							goto case 9;
						}
						case 9:
							if (!(text2 == "sp"))
							{
								goto case 17;
							}
							goto IL_082c;
						case 17:
							if (!(text2 == "in"))
							{
								goto case 7;
							}
							goto case 13;
						case 7:
							switch (text2)
							{
							default:
								textWindow.QDAgUan3Qmc("不支持的文本处理操作类型。值:" + array[2]);
								goto end_IL_000e;
							case "internal":
								break;
							case "cloud":
								goto IL_0975;
							case "url":
								goto IL_0a26;
							}
							goto case 13;
						case 13:
							try
							{
								_003C_003E8__1.vNtSxQYqQhb = InternalTextProcessor.ProcessText(text4, text, text5);
							}
							catch (Exception exception)
							{
								textWindow.QDAgUan3Qmc("转换文本出错。" + exception.GetMessageWithInner());
								goto end_IL_000e;
							}
							goto IL_0ad3;
						case 6:
						case 20:
							goto IL_0813;
						case 16:
							goto end_IL_000e;
						case 2:
							goto IL_0b10;
							IL_06e9:
							textWindow.QDAgUan3Qmc("文本处理命令格式不正确。值:" + command);
							goto end_IL_000e;
							IL_02f1:
							text = textWindow.TheText.SelectedText;
							if (string.IsNullOrEmpty(text) && textWindow.CopyWholeLine)
							{
								DocumentLine lineByOffset = textWindow.TheText.Document.GetLineByOffset(textWindow.TheText.CaretOffset);
								text = textWindow.TheText.Document.GetText(lineByOffset.Offset, lineByOffset.EndOffset - lineByOffset.Offset);
								_003C_003E8__1.jB3Sx4tVqtA = true;
							}
							flag = true;
							_003C_003E8__1.raXSx5a6wYA = !string.IsNullOrEmpty(text);
							goto case 5;
							IL_0605:
							c = text3[0];
							if (c != 'c')
							{
								if (c == 'r' && text3 == "rauto")
								{
									goto IL_0715;
								}
							}
							else if (text3 == "caret")
							{
								_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.CaretTo;
								goto case 1;
							}
							goto IL_0813;
							IL_06db:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.InsertAfter;
							goto case 1;
							IL_05d2:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.None;
							goto case 1;
							IL_0289:
							if (textWindow.TheText.SelectionLength > 0)
							{
								text = textWindow.TheText.SelectedText;
								flag = true;
								_003C_003E8__1.raXSx5a6wYA = true;
								goto case 5;
							}
							text = textWindow.TheText.Text;
							goto case 10;
							IL_068b:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.ReplaceAll;
							goto case 1;
							IL_020d:
							document = textWindow.TheText.Document;
							lineByOffset2 = document.GetLineByOffset(textWindow.TheText.SelectionStart);
							lineByOffset3 = document.GetLineByOffset(textWindow.TheText.SelectionStart + textWindow.TheText.SelectionLength);
							text = document.GetText(lineByOffset2.Offset, lineByOffset3.EndOffset - lineByOffset2.Offset);
							_003C_003E8__1.jB3Sx4tVqtA = true;
							goto case 5;
							IL_01f0:
							text = "";
							goto case 5;
							IL_0658:
							if (text3 == "append")
							{
								_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.Append;
								goto case 1;
							}
							goto IL_0813;
							IL_05a6:
							c = text3[0];
							if (c != 'c')
							{
								if (c == 'n' && text3 == "none")
								{
									goto IL_05d2;
								}
							}
							else if (text3 == "copy")
							{
								goto default;
							}
							goto IL_0813;
							IL_0715:
							_003C_003E8__1.WW8Sxp9cjv8 = ((!flag) ? ResultOperation.ReplaceAll : ResultOperation.ReplaceSelection);
							goto case 1;
							IL_0539:
							c = text3[1];
							if (c != 'a')
							{
								if (c != 'o')
								{
									goto case 11;
								}
								goto case 19;
							}
							if (text3 == "ra")
							{
								goto IL_068b;
							}
							if (text3 == "ia")
							{
								goto IL_06db;
							}
							goto IL_0813;
							IL_056e:
							_003C_003E8__1.WW8Sxp9cjv8 = ResultOperation.ReplaceSelection;
							goto case 1;
							IL_0486:
							if (text3 != null)
							{
								switch (text3.Length)
								{
								case 16:
									break;
								case 1:
									goto IL_04ec;
								case 2:
									goto IL_0539;
								case 4:
									goto IL_05a6;
								case 5:
									goto IL_0605;
								case 6:
									goto IL_0658;
								case 10:
									goto IL_067a;
								case 11:
									goto IL_069c;
								default:
									goto IL_0813;
								}
								if (text3 == "replaceselection")
								{
									goto IL_056e;
								}
							}
							goto IL_0813;
							IL_0813:
							textWindow.QDAgUan3Qmc("不支持的文本结果处理操作，可能您的软件版本比较旧。值:" + array[1]);
							goto end_IL_000e;
							IL_069c:
							c = text3[0];
							if (c != 'i')
							{
								if (c == 'r' && text3 == "replaceauto")
								{
									goto IL_0715;
								}
							}
							else if (text3 == "insertafter")
							{
								goto IL_06db;
							}
							goto IL_0813;
							IL_04ec:
							c = text3[0];
							if ((uint)c <= 105u)
							{
								if (c == 'a')
								{
									goto IL_068b;
								}
								if (c == 'c')
								{
									goto default;
								}
								if (c == 'i')
								{
									goto IL_06db;
								}
								goto IL_0813;
							}
							if (c != 'n')
							{
								goto case 4;
							}
							goto IL_05d2;
							IL_067a:
							if (text3 == "replaceall")
							{
								goto IL_068b;
							}
							goto IL_0813;
						}
					}
					string string_ = "文本处理命令格式不正确。值：" + command;
					textWindow.QDAgUan3Qmc(string_);
					goto end_IL_000e;
				}
				case 0:
					goto IL_082c;
				case 1:
					goto IL_0975;
				case 2:
					goto IL_0a26;
					IL_0ad3:
					if (!string.IsNullOrEmpty(_003C_003E8__1.vNtSxQYqQhb) || _003C_003E8__1.xQUSxjWMpmb.HasValue)
					{
						if (!(_003C_003E8__1.vNtSxQYqQhb == "*NULL*"))
						{
							break;
						}
						goto IL_0b10;
					}
					goto end_IL_000e;
					IL_0b10:
					_003C_003E8__1.vNtSxQYqQhb = "";
					break;
					IL_0a26:
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 2)
						{
							awaiter = WebTextProcessor.CallUrlServiceAsync(array[3], text).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								int num2 = 0;
								if (!UubT35WgXd8FOe7xbw0U())
								{
									int num3 = default(int);
									num2 = num3;
								}
								switch (num2)
								{
								}
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result = awaiter.GetResult();
						_003C_003E8__1.vNtSxQYqQhb = result;
					}
					catch (Exception exception2)
					{
						textWindow.QDAgUan3Qmc("调用Web文本处理服务出错。" + exception2.GetMessageWithInner());
						goto end_IL_000e;
					}
					goto IL_0ad3;
					IL_0975:
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 1)
						{
							awaiter = WebTextProcessor.CallCloudServiceAsync(array[3], text).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								int num4 = 0;
								if (kZ7KsoWgpcPdetnoFTMU != null)
								{
									int num5 = default(int);
									num4 = num5;
								}
								switch (num4)
								{
								}
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result = awaiter.GetResult();
						_003C_003E8__1.vNtSxQYqQhb = result;
					}
					catch (Exception exception3)
					{
						textWindow.QDAgUan3Qmc("调用Web文本处理服务出错。" + exception3.GetMessageWithInner());
						goto end_IL_000e;
					}
					goto IL_0ad3;
					IL_082c:
					try
					{
        (bool, string, string) result2 = default;
						TaskAwaiter<(bool, string, string)> awaiter2;
						if (num != 0)
						{
							awaiter2 = textWindow.nV8gU80T4u9(text4, text5, text, _003C_003E8__1.WW8Sxp9cjv8 != ResultOperation.None).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<(bool, string, string)>);
							num = -1;
							_003C_003E1__state = -1;
							int num6 = 0;
							if (!UubT35WgXd8FOe7xbw0U())
							{
								int num7 = default(int);
								num6 = num7;
							}
							switch (num6)
							{
							case 1:
								goto IL_08cd;
							}
						}
						result2 = awaiter2.GetResult();
						if (result2.Item1)
						{
							goto IL_08cd;
						}
						goto end_IL_082c;
						IL_08cd:
						_003C_003E8__1.vNtSxQYqQhb = result2.Item2;
						if (!result2.Item3.IsNullOrWhiteSpace())
						{
							string text6 = result2.Item3.Trim();
							if (text6.StartsWith("-"))
							{
								_003C_003E8__1.xQUSxjWMpmb = Convert.ToInt32(text6);
								_003C_003E8__1.sRlSxnZ2fhZ = true;
							}
							else
							{
								_003C_003E8__1.xQUSxjWMpmb = Convert.ToInt32(text6);
								_003C_003E8__1.sRlSxnZ2fhZ = false;
							}
						}
						goto IL_0ad3;
						end_IL_082c:;
					}
					catch (Exception exception4)
					{
						textWindow.QDAgUan3Qmc("执行子程序出错。" + exception4.GetMessageWithInner());
					}
					goto end_IL_000e;
				}
				AppHelper.RunOnUiThread(true, _003C_003E8__1.hxOSxrjfyTG);
				end_IL_000e:;
			}
			catch (Exception exception5)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception5);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool UubT35WgXd8FOe7xbw0U()
		{
			return kZ7KsoWgpcPdetnoFTMU == null;
		}
	}

	private static readonly ILog JPRgUjETnjT;

	private SpeechSynthesizer SKAgUnnU8I9;

	[CompilerGenerated]
	private ShowWindowLocation uf3gU46DPpT = ShowWindowLocation.CenterScreen;

	[CompilerGenerated]
	private IList<SimpleOperationItem> TqbgU5T0iLf;

	[CompilerGenerated]
	private string RKCgUD5lAVr = string.Empty;

	[CompilerGenerated]
	private ActionExecuteContext m2xgUdSqS6f;

	[CompilerGenerated]
	private string LBsgUoEM7y1;

	[CompilerGenerated]
	private string K6IgUT6LjJ9;

	[CompilerGenerated]
	private bool JOXgUMIiJk6;

	[CompilerGenerated]
	private bool h2ogUAviD14;

	[CompilerGenerated]
	private string EjLgUOMXUcr;

	[CompilerGenerated]
	private bool aSGgUFG360P;

	[CompilerGenerated]
	private string tjcgUUaqgEw;

	[CompilerGenerated]
	private string aMqgUlex0N6;

	[CompilerGenerated]
	private string gyvgUipdnx2;

	[CompilerGenerated]
	private bool D3RgU3KwRiO;

	private object hBjgUfWwQeX;

	private FoldingManager voNgUzsWKZ9;

	private FindReplaceMgr QOPglwH76cj = new FindReplaceMgr();

	[CompilerGenerated]
	private string JtQglte0NkY;

	[CompilerGenerated]
	private bool tZRglgoH8dU;

	[CompilerGenerated]
	private DebounceDispatcher APVglLKGKB9;

	private SearchReplacePanel SwqglvbXM97;

	private bool xgxglSsMUqZ;

	private ActionExecuteContext Gqagl2xRlaf;

	private string ycHgluZI1Rb;

	[CompilerGenerated]
	private CancellationTokenRegistration? FanglNPkQJo;

	internal TextWindow TheWindow;

	internal ToolBar BuildInToolBar;

	internal Button BtnFontLarger;

	internal Button BtnFontSamller;

	internal Button BtnCopy;

	internal Button BtnRead;

	internal ToolBar ToolbarOperations;

	internal TextEditor TheText;

	internal MenuItem MenuTextProcess;

	internal MenuItem MenuRestoreText;

	internal MenuItem HighlightingMenuItem;

	internal MenuItem MenuPrint;

	internal MenuItem MenuSave;

	private bool kWZglJ35Rbo;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.3.0.0")]
	private CommunityToolkit.Mvvm.Input.RelayCommand? w4hgl0CmXEh;

	private static TextWindow gff5LLFyFVUSecRJeU5Z;

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return uf3gU46DPpT;
		}
		[CompilerGenerated]
		set
		{
			uf3gU46DPpT = value;
		}
	}

	public IList<SimpleOperationItem> Operations
	{
		[CompilerGenerated]
		get
		{
			return TqbgU5T0iLf;
		}
		[CompilerGenerated]
		set
		{
			TqbgU5T0iLf = value;
		}
	}

	public string SelectedOperation
	{
		[CompilerGenerated]
		get
		{
			return RKCgUD5lAVr;
		}
		[CompilerGenerated]
		set
		{
			RKCgUD5lAVr = value;
		}
	}

	public string ResultText => TheText.Text;

	public ActionExecuteContext ActionContext
	{
		[CompilerGenerated]
		get
		{
			return m2xgUdSqS6f;
		}
		[CompilerGenerated]
		set
		{
			m2xgUdSqS6f = value;
		}
	}

	public string AutoCloseKey
	{
		[CompilerGenerated]
		get
		{
			return LBsgUoEM7y1;
		}
		[CompilerGenerated]
		set
		{
			LBsgUoEM7y1 = value;
		}
	}

	public string AutoSaveStateKey
	{
		[CompilerGenerated]
		get
		{
			return K6IgUT6LjJ9;
		}
		[CompilerGenerated]
		set
		{
			K6IgUT6LjJ9 = value;
		}
	}

	public bool IsClosed
	{
		[CompilerGenerated]
		get
		{
			return JOXgUMIiJk6;
		}
		[CompilerGenerated]
		set
		{
			JOXgUMIiJk6 = value;
		}
	}

	public bool DisableCloseByEsc
	{
		[CompilerGenerated]
		get
		{
			return h2ogUAviD14;
		}
		[CompilerGenerated]
		set
		{
			h2ogUAviD14 = value;
		}
	}

	public double TextFontSize
	{
		get
		{
			return TheText.FontSize;
		}
		set
		{
			TheText.FontSize = value;
			IEggUceRYFn();
		}
	}

	public bool WordWrap
	{
		get
		{
			return TheText.WordWrap;
		}
		set
		{
			TheText.WordWrap = value;
		}
	}

	public bool ShowLineNumbers
	{
		get
		{
			return TheText.ShowLineNumbers;
		}
		set
		{
			TheText.ShowLineNumbers = value;
		}
	}

	public bool ShowLineNum
	{
		get
		{
			return TheText.ShowLineNumbers;
		}
		set
		{
			TheText.ShowLineNumbers = value;
		}
	}

	public bool CopyWholeLine
	{
		get
		{
			return TheText.TextArea.Options.CutCopyWholeLine;
		}
		set
		{
			TheText.TextArea.Options.CutCopyWholeLine = value;
		}
	}

	public string LastWindowLocation
	{
		[CompilerGenerated]
		get
		{
			return EjLgUOMXUcr;
		}
		[CompilerGenerated]
		set
		{
			EjLgUOMXUcr = value;
		}
	}

	public bool CloseWhenLostFocus
	{
		[CompilerGenerated]
		get
		{
			return aSGgUFG360P;
		}
		[CompilerGenerated]
		set
		{
			aSGgUFG360P = value;
		}
	}

	public string SpWhenWindowLoaded
	{
		[CompilerGenerated]
		get
		{
			return tjcgUUaqgEw;
		}
		[CompilerGenerated]
		set
		{
			tjcgUUaqgEw = value;
		}
	}

	public string SpWhenWindowClosing
	{
		[CompilerGenerated]
		get
		{
			return aMqgUlex0N6;
		}
		[CompilerGenerated]
		set
		{
			aMqgUlex0N6 = value;
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return gyvgUipdnx2;
		}
		[CompilerGenerated]
		set
		{
			gyvgUipdnx2 = value;
		}
	}

	public bool NoScrollWhenAppendText
	{
		[CompilerGenerated]
		get
		{
			return D3RgU3KwRiO;
		}
		[CompilerGenerated]
		set
		{
			D3RgU3KwRiO = value;
		}
	}

	public string SelectedText => TheText.SelectedText;

	public string WindowSizeStr
	{
		[CompilerGenerated]
		get
		{
			return JtQglte0NkY;
		}
		[CompilerGenerated]
		set
		{
			JtQglte0NkY = value;
		}
	}

	public bool ShowBuildInToolbar
	{
		[CompilerGenerated]
		get
		{
			return tZRglgoH8dU;
		}
		[CompilerGenerated]
		set
		{
			tZRglgoH8dU = value;
		}
	}

	public IList<string> HighlightingDefinitions => UGNZKrYVGqgfWZbLcQj.HighlightingDefinitionNames;

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return FanglNPkQJo;
		}
		[CompilerGenerated]
		set
		{
			FanglNPkQJo = value;
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.3.0.0")]
	public IRelayCommand GoToLineCommand => w4hgl0CmXEh ?? (w4hgl0CmXEh = new CommunityToolkit.Mvvm.Input.RelayCommand(QUlgUH1jAad));

	public void SetBackgroundColor(string color)
	{
		if (!string.IsNullOrWhiteSpace(color))
		{
			try
			{
				TheText.Background = color.GetBrush();
			}
			catch (Exception)
			{
				TheText.Background = Brushes.White;
			}
		}
	}

	public void SetTextColor(string color)
	{
		if (!string.IsNullOrWhiteSpace(color))
		{
			try
			{
				Color color2 = (Color)ColorConverter.ConvertFromString(color);
				TheText.Foreground = new SolidColorBrush(color2);
				color2.A /= 2;
				TheText.LineNumbersForeground = new SolidColorBrush(color2);
			}
			catch (Exception)
			{
				TheText.Foreground = Brushes.Black;
			}
		}
	}

	public void SetSyntaxHighlighting(string name)
	{
		TheText.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(name);
		MoogFlrsksp();
	}

	public void SetSyntaxHighlighting(IHighlightingDefinition highlighting)
	{
		TheText.SyntaxHighlighting = highlighting;
		MoogFlrsksp();
	}

	private void MoogFlrsksp()
	{
		if (TheText.SyntaxHighlighting == null)
		{
			hBjgUfWwQeX = null;
		}
		else
		{
			TheText.TextArea.IndentationStrategy = new DefaultIndentationStrategy();
			hBjgUfWwQeX = TheText.yitLi90LyKV();
		}
		if (hBjgUfWwQeX != null)
		{
			if (voNgUzsWKZ9 == null)
			{
				voNgUzsWKZ9 = FoldingManager.Install(TheText.TextArea);
			}
			hR4gFi1ivAg();
		}
		else
		{
			if (voNgUzsWKZ9 == null)
			{
				return;
			}
			if (oQDAX6FycfYYXxYcdXLa())
			{
				switch (0)
				{
				}
			}
			FoldingManager.Uninstall(voNgUzsWKZ9);
			voNgUzsWKZ9 = null;
		}
	}

	private void hR4gFi1ivAg()
	{
		if (hBjgUfWwQeX != null)
		{
			if (hBjgUfWwQeX is BraceFoldingStrategy)
			{
				((BraceFoldingStrategy)hBjgUfWwQeX).UpdateFoldings(voNgUzsWKZ9, TheText.Document);
			}
			if (hBjgUfWwQeX is XmlFoldingStrategy)
			{
				((XmlFoldingStrategy)hBjgUfWwQeX).UpdateFoldings(voNgUzsWKZ9, TheText.Document);
			}
		}
	}

	public void SetFontFamily(string fontFamily)
	{
		try
		{
			TheText.FontFamily = new FontFamily(fontFamily);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置字体名称(" + fontFamily + ")失败：" + ex.Message);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private DebounceDispatcher feLgUpSRxVs()
	{
		return APVglLKGKB9;
	}

	[SpecialName]
	[CompilerGenerated]
	private void I9SgUBV8V9N(DebounceDispatcher value)
	{
		APVglLKGKB9 = value;
	}

	public TextWindow()
	{
		InitializeComponent();
		TheText.TextArea.TextView.LineSpacing = 1.25;
		TheText.TextArea.TextView.Margin = new Thickness(3.0, 0.0, 2.0, 0.0);
		TheText.SetValue(ScrollViewerAttach.AutoHideProperty, false);
		base.Closed += gZ2gU7lXqmu;
		base.Loaded += IdygUJye3ZK;
		base.PreviewMouseWheel += eK0gU259suv;
		base.LocationChanged += npmgUSFp8DO;
		base.SizeChanged += KhrgULGVPV2;
		base.SourceInitialized += TdCgUuXVZTH;
		base.Activated += iSJgFz4xTrI;
		base.Deactivated += MDWgUvqsqII;
		base.Closing += rDYgF36Txq3;
		base.DataContext = this;
		TheText.Options.CutCopyWholeLine = false;
		TheText.Options.InheritWordWrapIndentation = false;
		TheText.TextChanged += wn1gUtXd3cv;
		DataObject.AddSettingDataHandler(TheText, _003C_003EO.sqQSxY1NmdJ ?? (_003C_003EO.sqQSxY1NmdJ = onTextViewSettingDataHandler));
		TheText.uLyLiY4NBYN();
	}

	[AsyncStateMachine(typeof(_003COnWindowClosing_003Ed__100))]
	private void rDYgF36Txq3(object sender, CancelEventArgs e)
	{
		_003COnWindowClosing_003Ed__100 stateMachine = default(_003COnWindowClosing_003Ed__100);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CExecuteSp_003Ed__101))]
	private Task Y8IgFfjwo5l(string string_8)
	{
		_003CExecuteSp_003Ed__101 stateMachine = default(_003CExecuteSp_003Ed__101);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spName = string_8;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void iSJgFz4xTrI(object sender, EventArgs e)
	{
		try
		{
			TheText.Focus();
		}
		catch (Exception)
		{
		}
	}

	private void T25gUwGg9NA()
	{
		SwqglvbXM97 = SearchReplacePanel.Install(TheText);
		SwqglvbXM97.Localization = SearchPanelCnLocalization.Instance;
	}

	private void wn1gUtXd3cv(object sender, EventArgs e)
	{
		hR4gFi1ivAg();
		if (base.IsLoaded && !string.IsNullOrEmpty(AutoSaveStateKey))
		{
			SaveState();
		}
	}

	private void SaveState()
	{
		try
		{
			if (!string.IsNullOrEmpty(ActionContext?.Action.Id))
			{
				ActionStateWriter.WriteActionState(ActionContext?.Action.Id, AutoSaveStateKey, TheText.Text);
			}
		}
		catch (Exception ex)
		{
			JPRgUjETnjT.Warn("自动保存文本出错：" + ex.Message, ex);
			AppHelper.ShowWarning("自动保存内容出错：" + ex.Message);
		}
	}

	private void nJIgUggTdFN()
	{
		if (base.WindowState != WindowState.Normal || !base.IsLoaded)
		{
			return;
		}
		try
		{
			NativeMethods.RECT lpRect = default(NativeMethods.RECT);
			NativeMethods.GetWindowRect(this.GetHwndSource().Handle, out lpRect);
			if (lpRect.Top >= 0 || lpRect.Left > 0)
			{
				LastWindowLocation = $"{lpRect.Left},{lpRect.Top},{lpRect.Right},{lpRect.Bottom}";
			}
		}
		catch (Exception)
		{
		}
	}

	public static void onTextViewSettingDataHandler(object sender, DataObjectSettingDataEventArgs e)
	{
		if (sender is TextEditor && e.Format == DataFormats.Html)
		{
			e.CancelCommand();
		}
	}

	private void KhrgULGVPV2(object sender, SizeChangedEventArgs e)
	{
		if (base.IsLoaded)
		{
			MoPgU0KwMF0();
		}
	}

	private void MDWgUvqsqII(object sender, EventArgs e)
	{
		if (CloseWhenLostFocus && !xgxglSsMUqZ && !base.Topmost && base.IsLoaded && base.OwnedWindows.Count == 0 && base.WindowState == WindowState.Normal)
		{
			try
			{
				Close();
			}
			catch
			{
			}
		}
	}

	private void npmgUSFp8DO(object sender, EventArgs e)
	{
		QOPglwH76cj.WindowLeft = base.Left;
		QOPglwH76cj.WindowTop = base.Top;
		MoPgU0KwMF0();
	}

	private void eK0gU259suv(object sender, MouseWheelEventArgs e)
	{
		if (!Keyboard.IsKeyDown(Key.LeftCtrl) && !Keyboard.IsKeyDown(Key.RightCtrl))
		{
			return;
		}
		double textFontSize = TextFontSize;
		int num = 0;
		if (!oQDAX6FycfYYXxYcdXLa())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e.Delta < 0)
		{
			if (textFontSize > 8.0)
			{
				textFontSize -= 1.0;
				TextFontSize = textFontSize;
			}
		}
		else if (textFontSize < 60.0)
		{
			textFontSize += 1.0;
			TextFontSize = textFontSize;
		}
	}

	private void TdCgUuXVZTH(object sender, EventArgs e)
	{
		int num = 1;
		string text = default(string);
		Button button = default(Button);
		int num4 = default(int);
		(string, string, string) tuple2 = default((string, string, string));
		while (true)
		{
			UpdateLayout();
			int num2 = 0;
			if (!oQDAX6FycfYYXxYcdXLa())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			IEggUceRYFn();
			IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false);
			T25gUwGg9NA();
			if (Operations != null && Operations.Count != 0)
			{
				ToolbarOperations.Visibility = Visibility.Visible;
				Quicker.Utilities.UI.DropDownButton dropDownButton = null;
				{
					foreach (SimpleOperationItem operation in Operations)
					{
						if (operation.IsSeparator)
						{
							dropDownButton?.Menu.Items.Add(new Separator());
						}
						int num3;
						if (!operation.Name.StartsWith("[+]"))
						{
							if (operation.Name.StartsWith("[-]") && dropDownButton != null)
							{
								text = operation.Name.Substring(3);
								if (text == "----")
								{
									AppHelper.AddMenuSeparator(dropDownButton.Menu.Items);
									continue;
								}
								goto IL_02b7;
							}
							dropDownButton = null;
							(string, string, string) tuple = UIHelper.ExtractIconAndTitle(operation.Name);
							button = new Button
							{
								Tag = operation.Key,
								VerticalContentAlignment = VerticalAlignment.Center
							};
							if (!string.IsNullOrEmpty(tuple.Item3))
							{
								button.ToolTip = tuple.Item3;
							}
							button.Style = (Style)FindResource("ToolbarButton");
							button.Content = UIHelper.CreateButtonContent(tuple.Item1, tuple.Item2);
							button.Click += vlkgUCr0iLN;
							num3 = 1;
							if (gff5LLFyFVUSecRJeU5Z != null)
							{
								num3 = num4;
							}
						}
						else
						{
							tuple2 = UIHelper.ExtractIconAndTitle(operation.Name.Substring(3));
							num3 = 0;
							if (!oQDAX6FycfYYXxYcdXLa())
							{
								goto IL_01fa;
							}
						}
						switch (num3)
						{
						case 1:
							goto IL_02a2;
						case 2:
							goto IL_02b7;
						}
						goto IL_01fa;
						IL_02b7:
						(string, string, string) tuple3 = UIHelper.ExtractIconAndTitle(text);
						AppHelper.AddMenuItem(dropDownButton.Menu.Items, tuple3.Item2, tuple3.Item3, tuple3.Item1, vlkgUCr0iLN).Tag = operation.Key;
						continue;
						IL_01fa:
						dropDownButton = new Quicker.Utilities.UI.DropDownButton
						{
							Menu = new ContextMenu(),
							Content = UIHelper.CreateButtonContent(tuple2.Item1, tuple2.Item2),
							Margin = new Thickness(0.0),
							Padding = new Thickness(4.0),
							BorderThickness = new Thickness(0.0),
							VerticalContentAlignment = VerticalAlignment.Center
						};
						if (!string.IsNullOrEmpty(tuple2.Item3))
						{
							dropDownButton.ToolTip = tuple2.Item3;
						}
						ToolbarOperations.Items.Add(dropDownButton);
						continue;
						IL_02a2:
						ToolbarOperations.Items.Add(button);
					}
					return;
				}
			}
			ToolbarOperations.Visibility = Visibility.Collapsed;
			return;
		}
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowBand")]
	private static extern int MMXgUNPfaUA(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__116))]
	private void IdygUJye3ZK(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__116 stateMachine = default(_003COnLoaded_003Ed__116);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void MoPgU0KwMF0()
	{
		if (!string.IsNullOrEmpty(AutoCloseKey))
		{
			ActionContext?.SaveTextWindowLocation(AutoCloseKey, this);
		}
		nJIgUggTdFN();
	}

	[AsyncStateMachine(typeof(_003COperationItemOnClick_003Ed__118))]
	private void vlkgUCr0iLN(object sender, RoutedEventArgs e)
	{
		_003COperationItemOnClick_003Ed__118 stateMachine = default(_003COperationItemOnClick_003Ed__118);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CProcessAction_003Ed__119))]
	private Task o8ggUPkS1Tl(string string_8)
	{
		_003CProcessAction_003Ed__119 stateMachine = default(_003CProcessAction_003Ed__119);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.key = string_8;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CProcessButtonAsync_003Ed__120))]
	private Task Iv7gUE0RXAA(string string_8)
	{
		_003CProcessButtonAsync_003Ed__120 stateMachine = default(_003CProcessButtonAsync_003Ed__120);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.command = string_8;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void jVqgUyX0xeZ(int int_0)
	{
		if (int_0 < 0)
		{
			TheText.CaretOffset = 0;
		}
		else if (int_0 > TheText.Text.Length)
		{
			TheText.CaretOffset = TheText.Text.Length;
		}
		else
		{
			TheText.CaretOffset = int_0;
		}
		TheText.b8XLihSEUh0();
	}

	[AsyncStateMachine(typeof(_003CCallSubProgramAsync_003Ed__124))]
	private Task<(bool isSuccess, string result, string caretOffset)> nV8gU80T4u9(string string_8, string string_9, string string_10, bool bool_7)
	{
		_003CCallSubProgramAsync_003Ed__124 stateMachine = default(_003CCallSubProgramAsync_003Ed__124);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string, string)>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.subProgramName = string_8;
		stateMachine.operationParams = string_9;
		stateMachine.input = string_10;
		stateMachine.requireOutput = bool_7;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void QDAgUan3Qmc(string string_8)
	{
		ActionContext?.ActionLogger.LogWarning(string_8);
		JPRgUjETnjT.Warn(string_8);
		AppHelper.ShowWarning(string_8);
	}

	private void gZ2gU7lXqmu(object sender, EventArgs e)
	{
		IsClosed = true;
		try
		{
			x07gUR7iE7T();
		}
		catch (Exception exception)
		{
			JPRgUjETnjT.Warn("释放Speech组件错误：" + exception.GetMessageWithInner(), exception);
		}
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
	}

	private void x07gUR7iE7T()
	{
		try
		{
			if (SKAgUnnU8I9 != null)
			{
				SKAgUnnU8I9?.SpeakAsyncCancelAll();
				SKAgUnnU8I9?.Dispose();
				SKAgUnnU8I9 = null;
			}
		}
		catch (Exception ex)
		{
			JPRgUjETnjT.Info("忽略了异常：" + ex.Message, ex);
		}
	}

	public void SetText(string text, int caretPosition = 0)
	{
		TheText.Text = text;
		ycHgluZI1Rb = text;
		if (caretPosition != 0)
		{
			if (caretPosition < 0)
			{
				TheText.CaretOffset = text.Length;
			}
			else
			{
				TheText.CaretOffset = Math.Min(text.Length, caretPosition);
			}
			base.Dispatcher.InvokeAsync(bNbgUx8Ok9h);
		}
		else
		{
			TheText.CaretOffset = 0;
		}
	}

	private void ktAgUq6qoBS(object sender, RoutedEventArgs e)
	{
		TheText.FontSize += 2.0;
		if (TheText.FontSize > 40.0)
		{
			TheText.FontSize = 40.0;
			AppHelper.ShowInformation("不能再大了~");
		}
		IEggUceRYFn();
	}

	private void IEggUceRYFn()
	{
		TheText.TextArea.SetValue(TextBlock.LineHeightProperty, TheText.FontSize * 1.4);
	}

	private void WGkgUVAhhv9(object sender, RoutedEventArgs e)
	{
		double num = TheText.FontSize - 2.0;
		if (num < 6.0)
		{
			num = 6.0;
			AppHelper.ShowInformation("不能再小了~");
		}
		TheText.FontSize = num;
		IEggUceRYFn();
	}

	private void KpdgUZ2DvbF(object sender, RoutedEventArgs e)
	{
		TheText.Copy();
	}

	private void IGKgU9VmQVT(object sender, RoutedEventArgs e)
	{
		string text = TheText.SelectedText;
		if (string.IsNullOrEmpty(text))
		{
			text = TheText.Text;
		}
		if (string.IsNullOrEmpty(text))
		{
			AppHelper.ShowInformation("没有要朗读的内容。");
			return;
		}
		try
		{
			IJngUhJEjAi(text);
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("朗读文本出错了：" + exception.GetMessageWithInner());
		}
	}

	private void IJngUhJEjAi(string string_8)
	{
		try
		{
			if (SKAgUnnU8I9 != null)
			{
				SKAgUnnU8I9.SpeakAsyncCancelAll();
			}
			else
			{
				SKAgUnnU8I9 = new SpeechSynthesizer();
				SKAgUnnU8I9.SetOutputToDefaultAudioDevice();
			}
			SKAgUnnU8I9.SpeakAsync(string_8);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("朗读文本出错了：" + ex.Message);
		}
	}

	private void JCCgUex2g4f(object sender, KeyEventArgs e)
	{
		if (e.Key != Key.Escape)
		{
			return;
		}
		if (SwqglvbXM97 != null && !SwqglvbXM97.IsClosed)
		{
			SwqglvbXM97.Close();
			e.Handled = true;
			int num = 0;
			if (!oQDAX6FycfYYXxYcdXLa())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		ITextAreaInputHandler textAreaInputHandler = TheText.TextArea.DefaultInputHandler.NestedInputHandlers?.FirstOrDefault(_003C_003Ec.LCwSxxt7ON9 ?? (_003C_003Ec.LCwSxxt7ON9 = _003C_003Ec.QQDSx1oYmde.k6USxHyBVOa));
		if (textAreaInputHandler != null)
		{
			SearchInputHandler obj = textAreaInputHandler as SearchInputHandler;
			if (obj != null && obj.TryClose())
			{
				return;
			}
		}
		if (!AppState.HHxtaMaoqJr().DisableCloseTextWindowByEsc && !DisableCloseByEsc)
		{
			Close();
			e.Handled = true;
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			SKAgUnnU8I9?.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	private void OCCgUYxZaF4(object sender, RoutedEventArgs e)
	{
		TheText.SelectAll();
		TheText.dkOLiRNGFGf(ycHgluZI1Rb);
	}

	private void hkAgUIwJPbS(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement).Tag is string string_)
		{
			TheText.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(string_);
		}
		else
		{
			TheText.SyntaxHighlighting = null;
		}
		MoogFlrsksp();
	}

	private void rj7gUWGPB4o(object sender, RoutedEventArgs e)
	{
		TheText.SyntaxHighlighting = null;
		MoogFlrsksp();
	}

	private void tRJgUkKiVHZ(object sender, MouseButtonEventArgs e)
	{
		if (MenuTextProcess.Items.IsEmpty)
		{
			ContentContextMenuService.BuildTextContextMenus(MenuTextProcess.Items, TheText.SelectedText);
		}
	}

	private void I32gUGDssAn(object sender, RoutedEventArgs e)
	{
		FlowDocument flowDocument_ = DocumentPrinter.CreateFlowDocumentForEditor(TheText);
		try
		{
			wBSgUs1mhsX(flowDocument_);
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("打印出错：" + exception.GetMessageWithInner(), true);
		}
	}

	private void wBSgUs1mhsX(FlowDocument flowDocument_0)
	{
		MemoryStream stream = new MemoryStream();
		new TextRange(flowDocument_0.ContentStart, flowDocument_0.ContentEnd).Save(stream, DataFormats.Xaml);
		FlowDocument flowDocument = new FlowDocument();
		new TextRange(flowDocument.ContentStart, flowDocument.ContentEnd).Load(stream, DataFormats.Xaml);
		PrintDocumentImageableArea documentImageableArea = null;
		XpsDocumentWriter xpsDocumentWriter = PrintQueue.CreateXpsDocumentWriter(ref documentImageableArea);
		if (xpsDocumentWriter != null && documentImageableArea != null)
		{
			DocumentPaginator documentPaginator = ((IDocumentPaginatorSource)flowDocument).DocumentPaginator;
			documentPaginator.PageSize = new Size(documentImageableArea.MediaSizeWidth, documentImageableArea.MediaSizeHeight);
			int num = 0;
			if (!oQDAX6FycfYYXxYcdXLa())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			Thickness thickness = new Thickness(72.0);
			flowDocument.PagePadding = new Thickness(Math.Max(documentImageableArea.OriginWidth, thickness.Left), Math.Max(documentImageableArea.OriginHeight, thickness.Top), Math.Max(documentImageableArea.MediaSizeWidth - (documentImageableArea.OriginWidth + documentImageableArea.ExtentWidth), thickness.Right), Math.Max(documentImageableArea.MediaSizeHeight - (documentImageableArea.OriginHeight + documentImageableArea.ExtentHeight), thickness.Bottom));
			flowDocument.ColumnWidth = double.PositiveInfinity;
			xpsDocumentWriter.Write(documentPaginator);
		}
	}

	[AsyncStateMachine(typeof(_003CGoToLine_003Ed__147))]
	[RelayCommand]
	private void QUlgUH1jAad()
	{
		_003CGoToLine_003Ed__147 stateMachine = default(_003CGoToLine_003Ed__147);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void X3sgU1tckBT(int int_0)
	{
		if (int_0 < 0)
		{
			int_0 = 0;
		}
		TheText.TextArea.Caret.Location = new TextLocation(int_0, 0);
		TheText.ScrollToLine(int_0);
	}

	private void dIKgUbdW16L(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSaveFileDialog("文本文件|*.txt|所有文件|*.*", ".txt", "", "", "保存文本为文件");
		if (tuple.Item1)
		{
			try
			{
				File.WriteAllText(tuple.Item2, TheText.Text);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}
	}

	internal void FWqgU6u114f(string string_8)
	{
		try
		{
			TheText.AppendText(string_8);
			TheText.CaretOffset = TheText.Text.Length;
			if (!NoScrollWhenAppendText)
			{
				TheText.b8XLihSEUh0();
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("添加文本出错：" + ex.Message);
		}
	}

	private void QSpgUXiauhI(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.System)
		{
			switch (e.SystemKey)
			{
			case Key.Down:
				TheText.BDsLiWpgApB();
				break;
			case Key.Up:
				TheText.GNBLiIGOd2f();
				break;
			}
		}
	}

	private void O2ngUmIS7fW(object sender, MouseWheelEventArgs e)
	{
		if (e.Delta > 0)
		{
			NoScrollWhenAppendText = true;
		}
		else
		{
			base.Dispatcher.InvokeAsync(XibgUr6nUkk);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!kWZglJ35Rbo)
		{
			kWZglJ35Rbo = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/textwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
		{
			int num2 = default(int);
			while (true)
			{
				TheWindow = (TextWindow)target;
				TheWindow.KeyDown += JCCgUex2g4f;
				TheWindow.PreviewMouseWheel += O2ngUmIS7fW;
				int num = 1;
				if (!oQDAX6FycfYYXxYcdXLa())
				{
					num = num2;
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					return;
				}
			}
		}
		case 2:
			BuildInToolBar = (ToolBar)target;
			break;
		case 3:
			BtnFontLarger = (Button)target;
			BtnFontLarger.Click += ktAgUq6qoBS;
			break;
		case 4:
			BtnFontSamller = (Button)target;
			BtnFontSamller.Click += WGkgUVAhhv9;
			break;
		case 5:
			BtnCopy = (Button)target;
			BtnCopy.Click += KpdgUZ2DvbF;
			break;
		case 6:
			BtnRead = (Button)target;
			BtnRead.Click += IGKgU9VmQVT;
			break;
		case 7:
			ToolbarOperations = (ToolBar)target;
			break;
		case 8:
			TheText = (TextEditor)target;
			TheText.KeyDown += QSpgUXiauhI;
			TheText.PreviewMouseRightButtonDown += tRJgUkKiVHZ;
			break;
		case 9:
			MenuTextProcess = (MenuItem)target;
			break;
		case 10:
			MenuRestoreText = (MenuItem)target;
			MenuRestoreText.Click += OCCgUYxZaF4;
			break;
		case 11:
			HighlightingMenuItem = (MenuItem)target;
			break;
		default:
			kWZglJ35Rbo = true;
			break;
		case 13:
			((MenuItem)target).Click += rj7gUWGPB4o;
			break;
		case 14:
			MenuPrint = (MenuItem)target;
			MenuPrint.Click += I32gUGDssAn;
			break;
		case 15:
			MenuSave = (MenuItem)target;
			MenuSave.Click += dIKgUbdW16L;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 12)
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = MenuItem.ClickEvent;
			eventSetter.Handler = new RoutedEventHandler(hkAgUIwJPbS);
			((Style)target).Setters.Add(eventSetter);
		}
	}

	static TextWindow()
	{
		JPRgUjETnjT = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void ak4gUKQq8fw(object object_1, ThemeChangedMessage themeChangedMessage_0)
	{
		if (TheText.SyntaxHighlighting != null)
		{
			TheText.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(TheText.SyntaxHighlighting.Name);
		}
	}

	[CompilerGenerated]
	private void bNbgUx8Ok9h()
	{
		try
		{
			TheText.b8XLihSEUh0();
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void XibgUr6nUkk()
	{
		if (TheText.TextArea.TextView.VerticalOffset + TheText.TextArea.TextView.ActualHeight + 5.0 >= TheText.TextArea.TextView.DocumentHeight)
		{
			NoScrollWhenAppendText = false;
		}
	}

	internal static bool oQDAX6FycfYYXxYcdXLa()
	{
		return gff5LLFyFVUSecRJeU5Z == null;
	}
}
