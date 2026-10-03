using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using aqQpqiYgxsE6yEqgoVK;
using EOqy55MyMeuU2apYyog;
using FontAwesome5;
using GongSolutions.Wpf.DragDrop;
using GongSolutions.Wpf.DragDrop.Utilities;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Common.Vm.SubPrograms;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View.Controls;
using xrMRsqY47xNH06m5F9X;

namespace Quicker.View.X.Nodes;

public class StepListControl : System.Windows.Controls.Control, GongSolutions.Wpf.DragDrop.IDropTarget
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nJtSF0xYuLW;

		public static Func<StepNode, bool> YECSFCJs37g;

		public static Func<StepInParamDef, bool> Q6dSFPlVcdX;

		public static Func<SubProgram, SimpleOperationItem> zM9SFEgyhSI;

		public static Func<StepNode, ActionStep> GegSFyP5Be1;

		public static Func<ActionStep, bool> YiKSF8eqA8y;

		public static Func<StepNode, ActionStep> P7NSFa02r5V;

		public static Func<StepNode, ActionStep> z3GSF7oDZvU;

		public static Func<StepNode, ActionStep> HioSFRayLws;

		internal static _003C_003Ec R6Ne9XyVLIsjBG8nUBgk;

		static _003C_003Ec()
		{
			nJtSF0xYuLW = new _003C_003Ec();
		}

		internal bool UnBSFg3GemB(StepNode x)
		{
			return x.Step.StepType.IsEither(StepType.If, StepType.Loop);
		}

		internal bool UJRSFLkebCf(StepInParamDef x)
		{
			return x.IsControlField;
		}

		internal SimpleOperationItem Q36SFvTwp35(SubProgram x)
		{
			return new SimpleOperationItem
			{
				Data = x,
				Description = x.Description,
				Name = x.Name,
				Key = x.Name
			};
		}

		internal ActionStep V4fSFS1jaFH(StepNode x)
		{
			return x.Step;
		}

		internal bool evOSF2T3Jt9(ActionStep s)
		{
			return s.Disabled;
		}

		internal ActionStep tA1SFue9vw1(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep sJVSFNTcHUE(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep e2qSFJ3vIC0(StepNode x)
		{
			return x.Step;
		}

		internal static bool o4OKduyVunvp5EM9Cjey()
		{
			return R6Ne9XyVLIsjBG8nUBgk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public StepListControl q7XSFcscIVM;

		public StepNodeControl I1XSFVsO85R;

		internal static _003C_003Ec__DisplayClass13_0 l2YgepyVq9UT3YwkjnC0;

		internal void omhSFqsY4Y0()
		{
			q7XSFcscIVM.CEgL1CNT5vH(I1XSFVsO85R.StepNode);
		}

		internal static bool whBR3yyViZPhH9lhUv7d()
		{
			return l2YgepyVq9UT3YwkjnC0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public StepListControl laySFs9Ruuf;

		public StepNode yS0SFHDjxTx;

		internal static _003C_003Ec__DisplayClass17_0 V3Wq4LyVZjNwEDdEDKIR;

		internal void JuDSFZxxsWy(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.Paste(laySFs9Ruuf._stepList.IndexOf(yS0SFHDjxTx));
		}

		internal void yxySF9IZrDJ(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.Paste(laySFs9Ruuf._stepList.IndexOf(yS0SFHDjxTx) + 1);
		}

		internal void KQqSFh217Uk(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.tkcL1EowB31();
		}

		internal void x8vSFeyTMBP(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.bLhL1W9Hfvu("sys:each", true);
		}

		internal void UWySFYrMys1(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.bLhL1W9Hfvu("sys:repeat", true);
		}

		internal void cFcSFI97Flx(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.bLhL1W9Hfvu("sys:if", true);
		}

		internal void BuQSFWIpVlo(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.bLhL1W9Hfvu("sys:if", false);
		}

		internal void VTmSFk5Qdfi(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.bLhL1W9Hfvu("sys:simpleIf", true);
		}

		internal void lX0SFGEVue6(object sender, RoutedEventArgs e)
		{
			laySFs9Ruuf.vEIL1P4rWt2();
		}

		internal static bool v9bvlkyV5sjxn7h76QhN()
		{
			return V3Wq4LyVZjNwEDdEDKIR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_1
	{
		public StepNode ohlSFKIblq4;

		public _003C_003Ec__DisplayClass17_0 GFVSFxZH1uM;

		internal static _003C_003Ec__DisplayClass17_1 KQtRLtyV85DiKMTuYaFe;

		internal void QOqSF1k1KCA(object sender, RoutedEventArgs e)
		{
			int num = GFVSFxZH1uM.laySFs9Ruuf._stepList.IndexOf(ohlSFKIblq4);
			if (num >= 0)
			{
				GFVSFxZH1uM.laySFs9Ruuf._stepList.RemoveAt(num);
				ActionStep step = ohlSFKIblq4.Step;
				step.StepRunnerKey = "sys:if";
				step.ElseSteps = new List<ActionStep>();
				StepNode item = step.CreateNode();
				GFVSFxZH1uM.laySFs9Ruuf._stepList.Insert(num, item);
			}
			else
			{
				pFYL1QYJiaD.Warn("增加否则分支出错，未找到步骤序号:" + num);
				AppHelper.ShowWarning($"增加否则分支出错，未找到序号为{num}的步骤。");
			}
		}

		internal void JdCSFbiZOgW(object sender, RoutedEventArgs e)
		{
			int num = GFVSFxZH1uM.laySFs9Ruuf._stepList.IndexOf(ohlSFKIblq4);
			if (num >= 0)
			{
				GFVSFxZH1uM.laySFs9Ruuf._stepList.RemoveAt(num);
				ActionStep step = ohlSFKIblq4.Step;
				step.StepRunnerKey = "sys:simpleIf";
				step.ElseSteps = new List<ActionStep>();
				StepNode item = step.CreateNode();
				GFVSFxZH1uM.laySFs9Ruuf._stepList.Insert(num, item);
			}
			else
			{
				pFYL1QYJiaD.Warn("增加否则分支出错，未找到步骤序号:" + num);
				AppHelper.ShowWarning($"增加否则分支出错，未找到序号为{num}的步骤。");
			}
		}

		internal void acOSF6aHovG(object sender, RoutedEventArgs e)
		{
			(Window.GetWindow(GFVSFxZH1uM.laySFs9Ruuf) as ActionDesignerWindow).OpenSubProgram(ohlSFKIblq4.Step);
		}

		internal void TGxSFXNvqnS(object sender, RoutedEventArgs e)
		{
			try
			{
				System.Windows.Forms.Clipboard.SetData("step-params", ohlSFKIblq4.Step.ToJson(true));
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("复制出错：" + ex.Message);
			}
		}

		internal void fsaSFm9TYYv(object sender, RoutedEventArgs e)
		{
			try
			{
				string value = System.Windows.Forms.Clipboard.GetData("step-params") as string;
				if (string.IsNullOrEmpty(value))
				{
					return;
				}
				ActionStep actionStep = JsonConvert.DeserializeObject<ActionStep>(value);
				if (actionStep.InputParams != null && ohlSFKIblq4.Step.InputParams != null)
				{
					foreach (KeyValuePair<string, ActionStepParam> inputParam in actionStep.InputParams)
					{
						if (ohlSFKIblq4.Step.InputParams.ContainsKey(inputParam.Key))
						{
							ohlSFKIblq4.Step.InputParams[inputParam.Key] = inputParam.Value;
						}
					}
				}
				if (actionStep.OutputParams != null && ohlSFKIblq4.Step.OutputParams != null)
				{
					foreach (KeyValuePair<string, string> outputParam in actionStep.OutputParams)
					{
						if (ohlSFKIblq4.Step.OutputParams.ContainsKey(outputParam.Key))
						{
							ohlSFKIblq4.Step.OutputParams[outputParam.Key] = outputParam.Value;
						}
					}
				}
				ohlSFKIblq4.NotifyStepDataChange();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("粘贴参数设置出错：" + ex.Message);
			}
		}

		internal static bool lDAA21yVRx7oQgkeftl3()
		{
			return KQtRLtyV85DiKMTuYaFe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct R8gX8FkZyCJKIAE4ymv : IAsyncStateMachine
		{
			public int NR12Z2vxZmL;

			public AsyncVoidMethodBuilder tqT2Zudv5Tc;

			public _003C_003Ec__DisplayClass17_2 syf2ZNbG1LE;

			private (Guid id, int version, string title) n9D2ZJmsYPP;

			private TaskAwaiter<ApiResult<CheckActionUpdatesDto>> MUk2Z0Ev1vD;

			private static object jiVyu1yqjYJnnOlmahid;

			private void MoveNext()
			{
				int num = NR12Z2vxZmL;
				_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_ = syf2ZNbG1LE;
				try
				{
					CheckActionUpdatesVm checkActionUpdatesVm_ = default(CheckActionUpdatesVm);
					if (num != 0)
					{
						n9D2ZJmsYPP = SubProgramHelper.ParseNetSharedSpIdentifier(_003C_003Ec__DisplayClass17_.dAGSFQhLSKg);
						checkActionUpdatesVm_ = new CheckActionUpdatesVm
						{
							SharedActions = new List<Guid> { n9D2ZJmsYPP.id }
						};
					}
					try
					{
        CheckActionUpdatesDto.SharedActionInfo sharedActionInfo = default;
						TaskAwaiter<ApiResult<CheckActionUpdatesDto>> awaiter;
						int num2;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.jKQtbNcw92B(checkActionUpdatesVm_).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								NR12Z2vxZmL = 0;
								MUk2Z0Ev1vD = awaiter;
								tqT2Zudv5Tc.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num2 = 2;
								if (!CXHRogyqDjlpjtMc11hu())
								{
									goto IL_00ee;
								}
								goto IL_01f8;
							}
						}
						else
						{
							awaiter = MUk2Z0Ev1vD;
							MUk2Z0Ev1vD = default(TaskAwaiter<ApiResult<CheckActionUpdatesDto>>);
							num = -1;
							NR12Z2vxZmL = -1;
						}
						ApiResult<CheckActionUpdatesDto> result = awaiter.GetResult();
						sharedActionInfo = default(CheckActionUpdatesDto.SharedActionInfo);
						if (result.IsSuccess)
						{
							sharedActionInfo = result.Data.SharedActions.FirstOrDefault();
							num2 = 0;
							if (jiVyu1yqjYJnnOlmahid != null)
							{
								goto IL_00ee;
							}
							goto IL_01f8;
						}
						AppHelper.ShowWarning("检查更新失败！" + result.Message);
						goto end_IL_004a;
						IL_00ee:
						if (sharedActionInfo != null)
						{
							int revision = sharedActionInfo.Revision;
							if (revision > n9D2ZJmsYPP.version)
							{
								if (AppHelper.Confirm($"此子程序最新版为 {revision} 当前版本为 {n9D2ZJmsYPP.version}，是否更新？"))
								{
									int num3 = _003C_003Ec__DisplayClass17_.UYOSFjE5BUu.GFVSFxZH1uM.laySFs9Ruuf._stepList.IndexOf(_003C_003Ec__DisplayClass17_.UYOSFjE5BUu.ohlSFKIblq4);
									if (num3 >= 0)
									{
										_003C_003Ec__DisplayClass17_.UYOSFjE5BUu.GFVSFxZH1uM.laySFs9Ruuf._stepList.RemoveAt(num3);
										ActionStep step = _003C_003Ec__DisplayClass17_.UYOSFjE5BUu.ohlSFKIblq4.Step;
										string netSharedSpIdentifier = SubProgramHelper.GetNetSharedSpIdentifier(n9D2ZJmsYPP.id, revision, sharedActionInfo.Title);
										SubProgramStep.SetSubprogramIdentifier(step, netSharedSpIdentifier);
										StepNode item = step.CreateNode();
										_003C_003Ec__DisplayClass17_.UYOSFjE5BUu.GFVSFxZH1uM.laySFs9Ruuf._stepList.Insert(num3, item);
										num2 = 1;
										if (jiVyu1yqjYJnnOlmahid != null)
										{
											int num4 = default(int);
											num2 = num4;
										}
										goto IL_01f8;
									}
									AppHelper.ShowWarning("错误：未找到节点对象。");
								}
							}
							else
							{
								AppHelper.ShowInformation("此子程序已经是最新版。");
							}
						}
						else
						{
							AppHelper.ShowInformation("未找到此子程序。");
						}
						goto end_IL_004a;
						IL_01f8:
						switch (num2)
						{
						case 1:
							AppHelper.ShowSuccess("子程序已更新！");
							goto end_IL_004a;
						case 2:
							return;
						}
						goto IL_00ee;
						end_IL_004a:;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("检查子程序更新出错，请检查您的网络情况。错误：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					NR12Z2vxZmL = -2;
					n9D2ZJmsYPP = default((Guid, int, string));
					tqT2Zudv5Tc.SetException(exception);
					return;
				}
				NR12Z2vxZmL = -2;
				n9D2ZJmsYPP = default((Guid, int, string));
				tqT2Zudv5Tc.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				tqT2Zudv5Tc.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool CXHRogyqDjlpjtMc11hu()
			{
				return jiVyu1yqjYJnnOlmahid == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct cOepjOkBbhBVNLjutK8 : IAsyncStateMachine
		{
			public int PEn2ZCkGbLP;

			public AsyncVoidMethodBuilder kNh2ZPh7kBw;

			public _003C_003Ec__DisplayClass17_2 WbR2ZE92tET;

			private TaskAwaiter xMs2Zy78Dn6;

			internal static object MsbiCJyqGZ0jukOCkGe2;

			private void MoveNext()
			{
				int num = PEn2ZCkGbLP;
				_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_ = WbR2ZE92tET;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = xMs2Zy78Dn6;
						xMs2Zy78Dn6 = default(TaskAwaiter);
						num = -1;
						PEn2ZCkGbLP = -1;
						if (MsbiCJyqGZ0jukOCkGe2 == null)
						{
							switch (0)
							{
							}
						}
					}
					else
					{
						awaiter = (Window.GetWindow(_003C_003Ec__DisplayClass17_.UYOSFjE5BUu.GFVSFxZH1uM.laySFs9Ruuf) as ActionDesignerWindow).ConvertNetworkSharedSubprogramToInternalSp(_003C_003Ec__DisplayClass17_.dAGSFQhLSKg).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							PEn2ZCkGbLP = 0;
							xMs2Zy78Dn6 = awaiter;
							kNh2ZPh7kBw.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					PEn2ZCkGbLP = -2;
					kNh2ZPh7kBw.SetException(exception);
					return;
				}
				PEn2ZCkGbLP = -2;
				kNh2ZPh7kBw.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				kNh2ZPh7kBw.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool hIJEvkyq0rohkGqNVKW6()
			{
				return MsbiCJyqGZ0jukOCkGe2 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct tCb0CVkQJ9Kw8QvtAbB : IAsyncStateMachine
		{
			public int Vj12Z8kmIgg;

			public AsyncVoidMethodBuilder q0o2ZadoC6e;

			public _003C_003Ec__DisplayClass17_2 xBD2Z7L1cvA;

			private TaskAwaiter mby2ZRV2W6l;

			internal static object UgGef3yqKUvS0qCQomH1;

			private void MoveNext()
			{
				int num = Vj12Z8kmIgg;
				_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_ = xBD2Z7L1cvA;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = mby2ZRV2W6l;
						if (PNer9vyqB72x0Og1godY())
						{
							switch (0)
							{
							}
						}
						mby2ZRV2W6l = default(TaskAwaiter);
						num = -1;
						Vj12Z8kmIgg = -1;
					}
					else
					{
						string globalSpId = _003C_003Ec__DisplayClass17_.dAGSFQhLSKg.Substring("%%".Length);
						awaiter = (Window.GetWindow(_003C_003Ec__DisplayClass17_.UYOSFjE5BUu.GFVSFxZH1uM.laySFs9Ruuf) as ActionDesignerWindow).ConvertGlobalSpToLocalSpAsync(globalSpId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							Vj12Z8kmIgg = 0;
							mby2ZRV2W6l = awaiter;
							q0o2ZadoC6e.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					Vj12Z8kmIgg = -2;
					q0o2ZadoC6e.SetException(exception);
					return;
				}
				Vj12Z8kmIgg = -2;
				q0o2ZadoC6e.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				q0o2ZadoC6e.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool PNer9vyqB72x0Og1godY()
			{
				return UgGef3yqKUvS0qCQomH1 == null;
			}
		}

		public string dAGSFQhLSKg;

		public _003C_003Ec__DisplayClass17_1 UYOSFjE5BUu;

		private static _003C_003Ec__DisplayClass17_2 asH3fAyVU7n2w5Tgagjr;

		[AsyncStateMachine(typeof(R8gX8FkZyCJKIAE4ymv))]
		internal void uCOSFrMrq1B(object sender, RoutedEventArgs e)
		{
			R8gX8FkZyCJKIAE4ymv stateMachine = default(R8gX8FkZyCJKIAE4ymv);
			stateMachine.tqT2Zudv5Tc = AsyncVoidMethodBuilder.Create();
			stateMachine.syf2ZNbG1LE = this;
			stateMachine.NR12Z2vxZmL = -1;
			stateMachine.tqT2Zudv5Tc.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(cOepjOkBbhBVNLjutK8))]
		internal void oHpSFpL1xJw(object sender, RoutedEventArgs e)
		{
			cOepjOkBbhBVNLjutK8 stateMachine = default(cOepjOkBbhBVNLjutK8);
			stateMachine.kNh2ZPh7kBw = AsyncVoidMethodBuilder.Create();
			stateMachine.WbR2ZE92tET = this;
			stateMachine.PEn2ZCkGbLP = -1;
			stateMachine.kNh2ZPh7kBw.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(tCb0CVkQJ9Kw8QvtAbB))]
		internal void xyRSFBQw2Ph(object sender, RoutedEventArgs e)
		{
			tCb0CVkQJ9Kw8QvtAbB stateMachine = default(tCb0CVkQJ9Kw8QvtAbB);
			stateMachine.q0o2ZadoC6e = AsyncVoidMethodBuilder.Create();
			stateMachine.xBD2Z7L1cvA = this;
			stateMachine.Vj12Z8kmIgg = -1;
			stateMachine.q0o2ZadoC6e.Start(ref stateMachine);
		}

		internal static bool uTZZQhyVxSWSlnPYWhsm()
		{
			return asH3fAyVU7n2w5Tgagjr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public ActionVariable bUWSF4gjvI1;

		private static _003C_003Ec__DisplayClass30_0 jg7yOCyV6IIrDRXi2MmR;

		internal bool iXXSFn9TDvH(ActionVariable x)
		{
			return x.Key.Equals(bUWSF4gjvI1.Key, StringComparison.Ordinal);
		}

		internal static bool RoHaWNyVtyXABxk41xZV()
		{
			return jg7yOCyV6IIrDRXi2MmR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public Window ffsSFdCZ5WO;

		public Action yJLSFog8KcE;

		private static _003C_003Ec__DisplayClass39_0 Rv0LiEyVwIR1kTj4wSgG;

		internal void FefSF5hOQJq()
		{
			AppHelper.RunOnUiThread(false, yJLSFog8KcE ?? (yJLSFog8KcE = O6NSFDXeHZR));
		}

		internal void O6NSFDXeHZR()
		{
			try
			{
				if (ffsSFdCZ5WO.WindowState == WindowState.Minimized)
				{
					ffsSFdCZ5WO.WindowState = WindowState.Normal;
					ffsSFdCZ5WO.Show();
					ffsSFdCZ5WO.Activate();
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner());
			}
		}

		internal static bool AmPr7VyVTqjEqL2cm9pV()
		{
			return Rv0LiEyVwIR1kTj4wSgG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass43_0
	{
		public StepListControl Rs9SFMtSneM;

		public StepNode rWASFAKhIKj;

		private static _003C_003Ec__DisplayClass43_0 CPACvcyVCBwPSotgf6LV;

		internal void k2NSFT20ZJp()
		{
			int index = Rs9SFMtSneM._stepList.IndexOf(rWASFAKhIKj);
			ScrollViewer visualAncestor = Rs9SFMtSneM.TheListBox.GetVisualAncestor<ScrollViewer>();
			if (visualAncestor == null)
			{
				return;
			}
			int num = 0;
			if (!c48dc4yV7QlxD3HaeyLm())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (Rs9SFMtSneM.TheListBox.ItemContainerGenerator.ContainerFromIndex(index) is ListBoxItem listBoxItem)
			{
				Rect rect = listBoxItem.TransformToAncestor(visualAncestor).TransformBounds(new Rect(new Point(0.0, 0.0), listBoxItem.RenderSize));
				if (rect.Top < 0.0)
				{
					visualAncestor.ScrollToVerticalOffset(visualAncestor.VerticalOffset + rect.Top - 10.0);
				}
				else if (rect.Bottom > visualAncestor.ViewportHeight)
				{
					visualAncestor.ScrollToVerticalOffset(visualAncestor.VerticalOffset + rect.Bottom - visualAncestor.ViewportHeight + 10.0);
				}
			}
		}

		internal static void GbWKx7yVhmj99k8spevn()
		{
		}

		internal static bool c48dc4yV7QlxD3HaeyLm()
		{
			return CPACvcyVCBwPSotgf6LV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public SubProgram Cc1SFUQ7tFn;

		public IList<string> MCOSFlybeXx;

		private static _003C_003Ec__DisplayClass44_0 Op3AmTyVzwZ3JT21y6WD;

		internal bool uS0SFOVH4xg(SubProgram x)
		{
			return string.Equals(x.Name, Cc1SFUQ7tFn.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal bool YCWSFFev0OA(ActionVariable x)
		{
			if (!MCOSFlybeXx.Contains(x.Key))
			{
				return !x.SaveState;
			}
			return false;
		}

		internal static bool aIKBrcyQVE4LKWI0Erym()
		{
			return Op3AmTyVzwZ3JT21y6WD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_1
	{
		public string zs5SFf1k5R2;

		private static _003C_003Ec__DisplayClass44_1 oFS5oRyQcCtXi6lwMhmr;

		internal bool DA6SFiO3Mmo(ActionVariable x)
		{
			return x.Key == zs5SFf1k5R2;
		}

		internal bool L8oSF3rdKVk(ActionVariable x)
		{
			return x.Key == zs5SFf1k5R2;
		}

		internal static bool UeVPgMyQW6ALJjh4i80p()
		{
			return oFS5oRyQcCtXi6lwMhmr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public StepListControl c0dSFzT1MeN;

		public IDropInfo dVdSUwm8Byl;

		internal static _003C_003Ec__DisplayClass51_0 z7BUkwyQXqEiIY3eALKK;

		static _003C_003Ec__DisplayClass51_0()
		{
		}

		internal static bool YSNL6IyQ267MSfH2gQme()
		{
			return z7BUkwyQXqEiIY3eALKK == null;
		}

		internal static void cJfNgTyQnVGZDpZeM07D()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mCjWjGkt9afD14ENBMt : IAsyncStateMachine
		{
			public int QiH2ZqXwXY8;

			public AsyncTaskMethodBuilder oa72ZcNBPuS;

			public _003C_003Ec__DisplayClass51_1 gSu2ZVUtyes;

			private TaskAwaiter WQq2ZZFHDNQ;

			internal static object MjKj3Pyqdaea8mUDvx8n;

			private void MoveNext()
			{
				int num = QiH2ZqXwXY8;
				_003C_003Ec__DisplayClass51_1 _003C_003Ec__DisplayClass51_ = gSu2ZVUtyes;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass51_.eSpSULpUVk6.c0dSFzT1MeN.CreateStep(_003C_003Ec__DisplayClass51_.UawSUga5OZm.Key, _003C_003Ec__DisplayClass51_.eSpSULpUVk6.dVdSUwm8Byl.InsertIndex).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							QiH2ZqXwXY8 = 0;
							WQq2ZZFHDNQ = awaiter;
							oa72ZcNBPuS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = WQq2ZZFHDNQ;
						WQq2ZZFHDNQ = default(TaskAwaiter);
						num = -1;
						QiH2ZqXwXY8 = -1;
					}
					awaiter.GetResult();
					int num2 = 0;
					if (!RPieIGyqOjG2ZEZYgJac())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				catch (Exception exception)
				{
					QiH2ZqXwXY8 = -2;
					oa72ZcNBPuS.SetException(exception);
					return;
				}
				QiH2ZqXwXY8 = -2;
				oa72ZcNBPuS.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				oa72ZcNBPuS.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool RPieIGyqOjG2ZEZYgJac()
			{
				return MjKj3Pyqdaea8mUDvx8n == null;
			}
		}

		public XToolboxItem UawSUga5OZm;

		public _003C_003Ec__DisplayClass51_0 eSpSULpUVk6;

		private static _003C_003Ec__DisplayClass51_1 WD4jfIyQerqhQV8bu4So;

		[AsyncStateMachine(typeof(mCjWjGkt9afD14ENBMt))]
		internal Task GN6SUtMPEet()
		{
			mCjWjGkt9afD14ENBMt stateMachine = default(mCjWjGkt9afD14ENBMt);
			stateMachine.oa72ZcNBPuS = AsyncTaskMethodBuilder.Create();
			stateMachine.gSu2ZVUtyes = this;
			stateMachine.QiH2ZqXwXY8 = -1;
			stateMachine.oa72ZcNBPuS.Start(ref stateMachine);
			return stateMachine.oa72ZcNBPuS.Task;
		}

		internal static void LkxtYjyQ3NhJNblX44ck()
		{
		}

		internal static bool c5ZDxgyQjV6j0KMNRf33()
		{
			return WD4jfIyQerqhQV8bu4So == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct vsjTy7kxLKA5F9aMUnv : IAsyncStateMachine
		{
			public int JxV2Z9Fqrq1;

			public AsyncTaskMethodBuilder xxy2Zhieh3g;

			public _003C_003Ec__DisplayClass51_2 tde2ZeTakeZ;

			private TaskAwaiter xqA2ZYZurjF;

			private static object EnLpPayqaY55GkopkNRq;

			private void MoveNext()
			{
				int num = JxV2Z9Fqrq1;
				_003C_003Ec__DisplayClass51_2 _003C_003Ec__DisplayClass51_ = tde2ZeTakeZ;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass51_.QmbSU2sC72p.c0dSFzT1MeN.CreateStep(_003C_003Ec__DisplayClass51_.oYYSUSqVAZE.Key, _003C_003Ec__DisplayClass51_.QmbSU2sC72p.dVdSUwm8Byl.InsertIndex).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							JxV2Z9Fqrq1 = 0;
							xqA2ZYZurjF = awaiter;
							xxy2Zhieh3g.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = xqA2ZYZurjF;
						xqA2ZYZurjF = default(TaskAwaiter);
						num = -1;
						JxV2Z9Fqrq1 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					JxV2Z9Fqrq1 = -2;
					xxy2Zhieh3g.SetException(exception);
					return;
				}
				JxV2Z9Fqrq1 = -2;
				xxy2Zhieh3g.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				xxy2Zhieh3g.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool LyoN05yqrl19FZbwK172()
			{
				return EnLpPayqaY55GkopkNRq == null;
			}
		}

		public FlFLPuYyXT5lnwN12if oYYSUSqVAZE;

		public _003C_003Ec__DisplayClass51_0 QmbSU2sC72p;

		internal static _003C_003Ec__DisplayClass51_2 wsoZeyyQEFfZsKUy3Eli;

		[AsyncStateMachine(typeof(vsjTy7kxLKA5F9aMUnv))]
		internal Task biGSUvkFQP5()
		{
			vsjTy7kxLKA5F9aMUnv stateMachine = default(vsjTy7kxLKA5F9aMUnv);
			stateMachine.xxy2Zhieh3g = AsyncTaskMethodBuilder.Create();
			stateMachine.tde2ZeTakeZ = this;
			stateMachine.JxV2Z9Fqrq1 = -1;
			stateMachine.xxy2Zhieh3g.Start(ref stateMachine);
			return stateMachine.xxy2Zhieh3g.Task;
		}

		static _003C_003Ec__DisplayClass51_2()
		{
		}

		internal static bool xipKN4yQG0sPPFO9y4rx()
		{
			return wsoZeyyQEFfZsKUy3Eli == null;
		}

		internal static void X0csMSyQ1RamR9EvCeeg()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_3
	{
		[StructLayout(LayoutKind.Auto)]
		private struct TlAn5kkClKHXelPdG3u : IAsyncStateMachine
		{
			public int F6e2ZIoOOHZ;

			public AsyncTaskMethodBuilder uVW2ZW77W7j;

			public _003C_003Ec__DisplayClass51_3 fFr2Zk4nApf;

			private TaskAwaiter W2b2ZGGTmxO;

			private static object FVKeeRyq9gcDw6AvVOlr;

			private void MoveNext()
			{
				int num = F6e2ZIoOOHZ;
				_003C_003Ec__DisplayClass51_3 _003C_003Ec__DisplayClass51_ = fFr2Zk4nApf;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass51_.UFuSUJ4I1mx.c0dSFzT1MeN.CreateStep(_003C_003Ec__DisplayClass51_.iOiSUNb1GAs.TOdL6WbHTbf(), _003C_003Ec__DisplayClass51_.UFuSUJ4I1mx.dVdSUwm8Byl.InsertIndex, _003C_003Ec__DisplayClass51_.iOiSUNb1GAs.Key).GetAwaiter();
						if (qOM4DFyqLbC9nmNb07y7())
						{
							switch (0)
							{
							}
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							F6e2ZIoOOHZ = 0;
							W2b2ZGGTmxO = awaiter;
							uVW2ZW77W7j.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = W2b2ZGGTmxO;
						W2b2ZGGTmxO = default(TaskAwaiter);
						num = -1;
						F6e2ZIoOOHZ = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					F6e2ZIoOOHZ = -2;
					uVW2ZW77W7j.SetException(exception);
					return;
				}
				F6e2ZIoOOHZ = -2;
				uVW2ZW77W7j.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				uVW2ZW77W7j.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool qOM4DFyqLbC9nmNb07y7()
			{
				return FVKeeRyq9gcDw6AvVOlr == null;
			}
		}

		public LNofqKYUdVwgyXju86h iOiSUNb1GAs;

		public _003C_003Ec__DisplayClass51_0 UFuSUJ4I1mx;

		internal static _003C_003Ec__DisplayClass51_3 NnPTuSyQKP5aYJsjX4Og;

		[AsyncStateMachine(typeof(TlAn5kkClKHXelPdG3u))]
		internal Task yD6SUut4fbZ()
		{
			TlAn5kkClKHXelPdG3u stateMachine = default(TlAn5kkClKHXelPdG3u);
			stateMachine.uVW2ZW77W7j = AsyncTaskMethodBuilder.Create();
			stateMachine.fFr2Zk4nApf = this;
			stateMachine.F6e2ZIoOOHZ = -1;
			stateMachine.uVW2ZW77W7j.Start(ref stateMachine);
			return stateMachine.uVW2ZW77W7j.Task;
		}

		internal static void YgVr9LyQdCXSxXUd5S2J()
		{
		}

		internal static bool fdj712yQBVj4rOeATVFE()
		{
			return NnPTuSyQKP5aYJsjX4Og == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_4
	{
		[StructLayout(LayoutKind.Auto)]
		private struct QP9cFHkrNu9rr36IuJW : IAsyncStateMachine
		{
			public int gif2Zsw3fsT;

			public AsyncTaskMethodBuilder HIm2ZHcYX4F;

			public _003C_003Ec__DisplayClass51_4 p452Z1gqTC1;

			private TaskAwaiter zxL2ZbYGLnj;

			internal static object ELpHq4yqbYaYiN9anbWj;

			private void MoveNext()
			{
				int num = gif2Zsw3fsT;
				_003C_003Ec__DisplayClass51_4 _003C_003Ec__DisplayClass51_ = p452Z1gqTC1;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass51_.csUSUPmlR8v.c0dSFzT1MeN.CreateStep("sys:runAction", _003C_003Ec__DisplayClass51_.csUSUPmlR8v.dVdSUwm8Byl.InsertIndex, null, null, new Dictionary<string, ActionStepParam>
						{
							{
								"type",
								new ActionStepParam
								{
									Value = "StartAction"
								}
							},
							{
								"actionId",
								new ActionStepParam
								{
									Value = _003C_003Ec__DisplayClass51_.IymSUCV6Wfh.Id
								}
							}
						}, _003C_003Ec__DisplayClass51_.IymSUCV6Wfh.Title).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							gif2Zsw3fsT = 0;
							zxL2ZbYGLnj = awaiter;
							HIm2ZHcYX4F.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = zxL2ZbYGLnj;
						zxL2ZbYGLnj = default(TaskAwaiter);
						num = -1;
						gif2Zsw3fsT = -1;
						if (RehuOWyqqcjGI47Sb7KT())
						{
							switch (0)
							{
							}
						}
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					gif2Zsw3fsT = -2;
					HIm2ZHcYX4F.SetException(exception);
					return;
				}
				gif2Zsw3fsT = -2;
				HIm2ZHcYX4F.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				HIm2ZHcYX4F.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool RehuOWyqqcjGI47Sb7KT()
			{
				return ELpHq4yqbYaYiN9anbWj == null;
			}
		}

		public ActionItem IymSUCV6Wfh;

		public _003C_003Ec__DisplayClass51_0 csUSUPmlR8v;

		private static _003C_003Ec__DisplayClass51_4 GIUh5TyQOiFqHfcinqcJ;

		[AsyncStateMachine(typeof(QP9cFHkrNu9rr36IuJW))]
		internal Task IspSU0YJqQZ()
		{
			QP9cFHkrNu9rr36IuJW stateMachine = default(QP9cFHkrNu9rr36IuJW);
			stateMachine.HIm2ZHcYX4F = AsyncTaskMethodBuilder.Create();
			stateMachine.p452Z1gqTC1 = this;
			stateMachine.gif2Zsw3fsT = -1;
			stateMachine.HIm2ZHcYX4F.Start(ref stateMachine);
			return stateMachine.HIm2ZHcYX4F.Task;
		}

		internal static bool jIsfG4yQJ0i2wDmHS7eg()
		{
			return GIUh5TyQOiFqHfcinqcJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_5
	{
		[StructLayout(LayoutKind.Auto)]
		private struct zQFe37kIiJFwxPR17qV : IAsyncStateMachine
		{
			public int MKn2Z6u7C7Q;

			public AsyncTaskMethodBuilder Fie2ZXLLeWw;

			public _003C_003Ec__DisplayClass51_5 LRw2ZmVvrNd;

			private TaskAwaiter r2H2ZK4b3TN;

			internal static object GbcEBNyqZpSoy8aPMwaB;

			private void MoveNext()
			{
				int num = MKn2Z6u7C7Q;
				_003C_003Ec__DisplayClass51_5 _003C_003Ec__DisplayClass51_ = LRw2ZmVvrNd;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = r2H2ZK4b3TN;
						r2H2ZK4b3TN = default(TaskAwaiter);
						num = -1;
						MKn2Z6u7C7Q = -1;
					}
					else
					{
						awaiter = _003C_003Ec__DisplayClass51_.PTJSU8e7hyh.c0dSFzT1MeN.sVbL1aKWrN8(_003C_003Ec__DisplayClass51_.lY0SUybmC28, _003C_003Ec__DisplayClass51_.PTJSU8e7hyh.dVdSUwm8Byl.InsertIndex).GetAwaiter();
						if (AkB0ctyq5xtfgYvRRnbx())
						{
							switch (0)
							{
							}
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							MKn2Z6u7C7Q = 0;
							r2H2ZK4b3TN = awaiter;
							Fie2ZXLLeWw.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					MKn2Z6u7C7Q = -2;
					Fie2ZXLLeWw.SetException(exception);
					return;
				}
				MKn2Z6u7C7Q = -2;
				Fie2ZXLLeWw.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Fie2ZXLLeWw.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool AkB0ctyq5xtfgYvRRnbx()
			{
				return GbcEBNyqZpSoy8aPMwaB == null;
			}
		}

		public SubProgram lY0SUybmC28;

		public _003C_003Ec__DisplayClass51_0 PTJSU8e7hyh;

		internal static _003C_003Ec__DisplayClass51_5 vuWwNkyQafYYkP0wXwK0;

		[AsyncStateMachine(typeof(zQFe37kIiJFwxPR17qV))]
		internal Task aiJSUEna3ME()
		{
			zQFe37kIiJFwxPR17qV stateMachine = default(zQFe37kIiJFwxPR17qV);
			stateMachine.Fie2ZXLLeWw = AsyncTaskMethodBuilder.Create();
			stateMachine.LRw2ZmVvrNd = this;
			stateMachine.MKn2Z6u7C7Q = -1;
			stateMachine.Fie2ZXLLeWw.Start(ref stateMachine);
			return stateMachine.Fie2ZXLLeWw.Task;
		}

		internal static bool IaThY7yQr7XTErwgIvLp()
		{
			return vuWwNkyQafYYkP0wXwK0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_6
	{
		[StructLayout(LayoutKind.Auto)]
		private struct TFipRakGO3WbCpDWE0W : IAsyncStateMachine
		{
			public int LNc2ZxB20oS;

			public AsyncTaskMethodBuilder fS22Zrw2faW;

			public _003C_003Ec__DisplayClass51_6 JPE2ZpwimjI;

			private TaskAwaiter gvT2ZByWs4O;

			private static object ohVZmKyq8FG11vWllHmJ;

			private void MoveNext()
			{
				int num = LNc2ZxB20oS;
				_003C_003Ec__DisplayClass51_6 _003C_003Ec__DisplayClass51_ = JPE2ZpwimjI;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = gvT2ZByWs4O;
						gvT2ZByWs4O = default(TaskAwaiter);
						num = -1;
						LNc2ZxB20oS = -1;
					}
					else
					{
						awaiter = _003C_003Ec__DisplayClass51_.MdISUR7GDjT.PTJSU8e7hyh.c0dSFzT1MeN.BPRL17uunmS(_003C_003Ec__DisplayClass51_.BkjSU7vu75L, _003C_003Ec__DisplayClass51_.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.InsertIndex).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							LNc2ZxB20oS = 0;
							gvT2ZByWs4O = awaiter;
							fS22Zrw2faW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
					int num2 = 0;
					if (!pdKynqyqR2nu6Ro6PyKb())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				catch (Exception exception)
				{
					LNc2ZxB20oS = -2;
					fS22Zrw2faW.SetException(exception);
					return;
				}
				LNc2ZxB20oS = -2;
				fS22Zrw2faW.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				fS22Zrw2faW.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool pdKynqyqR2nu6Ro6PyKb()
			{
				return ohVZmKyq8FG11vWllHmJ == null;
			}
		}

		public SharedSubProgramListItemDto BkjSU7vu75L;

		public _003C_003Ec__DisplayClass51_5 MdISUR7GDjT;

		private static _003C_003Ec__DisplayClass51_6 FdXEAvyQ9ygHmnyjcXQo;

		[AsyncStateMachine(typeof(TFipRakGO3WbCpDWE0W))]
		internal Task MMeSUadjsOr()
		{
			TFipRakGO3WbCpDWE0W stateMachine = default(TFipRakGO3WbCpDWE0W);
			stateMachine.fS22Zrw2faW = AsyncTaskMethodBuilder.Create();
			stateMachine.JPE2ZpwimjI = this;
			stateMachine.LNc2ZxB20oS = -1;
			stateMachine.fS22Zrw2faW.Start(ref stateMachine);
			return stateMachine.fS22Zrw2faW.Task;
		}

		internal static bool gIjJknyQLVZKsXMJvA6T()
		{
			return FdXEAvyQ9ygHmnyjcXQo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_7
	{
		[StructLayout(LayoutKind.Auto)]
		private struct yYFsxfkLMJjnaa0dLZ0 : IAsyncStateMachine
		{
			public int Coy2ZQCmFoD;

			public AsyncTaskMethodBuilder ne92ZjKdD6S;

			public _003C_003Ec__DisplayClass51_7 RJo2ZntWYTx;

			private TaskAwaiter SeO2Z44V3QD;

			private static object w2jqA6yqMlb8e2NvuLD7;

			private void MoveNext()
			{
				int num = Coy2ZQCmFoD;
				_003C_003Ec__DisplayClass51_7 _003C_003Ec__DisplayClass51_ = RJo2ZntWYTx;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = SeO2Z44V3QD;
							SeO2Z44V3QD = default(TaskAwaiter);
							num = -1;
							Coy2ZQCmFoD = -1;
							goto IL_01c9;
						}
						if (_003C_003Ec__DisplayClass51_.e2GSUceVbKZ.Type == VarType.List && Keyboard.Modifiers == ModifierKeys.Control)
						{
							awaiter = _003C_003Ec__DisplayClass51_.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.c0dSFzT1MeN.CreateStep("sys:each", _003C_003Ec__DisplayClass51_.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.InsertIndex, null, null, new Dictionary<string, ActionStepParam> { 
							{
								EachStepRunner.IMvtzp3FVfv.Key,
								new ActionStepParam
								{
									VarKey = _003C_003Ec__DisplayClass51_.e2GSUceVbKZ.Key
								}
							} }).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								Coy2ZQCmFoD = 0;
								SeO2Z44V3QD = awaiter;
								ne92ZjKdD6S.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01dc;
						}
					}
					else
					{
						awaiter = SeO2Z44V3QD;
						SeO2Z44V3QD = default(TaskAwaiter);
						int num2 = 1;
						if (!Fe4ocZyqUNYvajtLy8wY())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						case 1:
							goto IL_01d2;
						}
					}
					awaiter = _003C_003Ec__DisplayClass51_.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.c0dSFzT1MeN.CreateStep("sys:assign", _003C_003Ec__DisplayClass51_.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.InsertIndex, null, new Dictionary<string, string> { 
					{
						"output",
						_003C_003Ec__DisplayClass51_.e2GSUceVbKZ.Key
					} }).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						Coy2ZQCmFoD = 1;
						SeO2Z44V3QD = awaiter;
						ne92ZjKdD6S.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01c9;
					IL_01d2:
					num = -1;
					Coy2ZQCmFoD = -1;
					goto IL_01dc;
					IL_01dc:
					awaiter.GetResult();
					goto end_IL_0010;
					IL_01c9:
					awaiter.GetResult();
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					Coy2ZQCmFoD = -2;
					ne92ZjKdD6S.SetException(exception);
					return;
				}
				Coy2ZQCmFoD = -2;
				ne92ZjKdD6S.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				ne92ZjKdD6S.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Fe4ocZyqUNYvajtLy8wY()
			{
				return w2jqA6yqMlb8e2NvuLD7 == null;
			}
		}

		public ActionVariable e2GSUceVbKZ;

		public _003C_003Ec__DisplayClass51_6 LrtSUVTfTOb;

		internal static _003C_003Ec__DisplayClass51_7 a3jSuIyQoyPLAcG7t9PG;

		[AsyncStateMachine(typeof(yYFsxfkLMJjnaa0dLZ0))]
		internal Task mVFSUqnQYjy()
		{
			yYFsxfkLMJjnaa0dLZ0 stateMachine = default(yYFsxfkLMJjnaa0dLZ0);
			stateMachine.ne92ZjKdD6S = AsyncTaskMethodBuilder.Create();
			stateMachine.RJo2ZntWYTx = this;
			stateMachine.Coy2ZQCmFoD = -1;
			stateMachine.ne92ZjKdD6S.Start(ref stateMachine);
			return stateMachine.ne92ZjKdD6S.Task;
		}

		internal static bool dPOs0KyQfKHDbW2q52Pr()
		{
			return a3jSuIyQoyPLAcG7t9PG == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvertToChildSteps_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public StepListControl _003C_003E4__this;

		public string stepTypeKey;

		public bool addToIfSteps;

		private StepNode _003CparentNode_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object oe0nUtyQiQG3mHENmp05;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				int num2;
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					IList<StepNode> list = stepListControl.ac3L1RpRgxF();
					if (list.Count < 1)
					{
						num2 = 0;
						if (oe0nUtyQiQG3mHENmp05 != null)
						{
							goto IL_01f4;
						}
						goto IL_0203;
					}
					ActionStep step = new ActionStep
					{
						StepRunnerKey = stepTypeKey,
						IfSteps = (addToIfSteps ? list.Select(_003C_003Ec.P7NSFa02r5V ?? (_003C_003Ec.P7NSFa02r5V = _003C_003Ec.nJtSF0xYuLW.tA1SFue9vw1)).ToList() : new List<ActionStep>()),
						ElseSteps = (addToIfSteps ? new List<ActionStep>() : list.Select(_003C_003Ec.z3GSF7oDZvU ?? (_003C_003Ec.z3GSF7oDZvU = _003C_003Ec.nJtSF0xYuLW.sJVSFNTcHUE)).ToList())
					};
					int index = ((IEnumerable<StepNode>)list).Min((Func<StepNode, int>)stepListControl.sJnL1xMECKr);
					List<StepNode>.Enumerator enumerator = stepListControl.ac3L1RpRgxF().ToList().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							StepNode current = enumerator.Current;
							stepListControl._stepList.Remove(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					_003CparentNode_003E5__2 = step.CreateNode();
					stepListControl._stepList.Insert(index, _003CparentNode_003E5__2);
					if (!(stepTypeKey != "sys:group"))
					{
						goto IL_01bc;
					}
					awaiter = stepListControl.RrVL1cLrGo5(_003CparentNode_003E5__2).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				goto IL_01bc;
				IL_01bc:
				stepListControl.TheListBox.SelectedItem = _003CparentNode_003E5__2;
				stepListControl.Dispatcher.InvokeAsync(stepListControl.vXJL1r3jc5b);
				num2 = 0;
				if (!dg1xeUyQlaDZOR8en3wv())
				{
					goto IL_01f4;
				}
				goto end_IL_000e;
				IL_01f4:
				switch (num2)
				{
				default:
					goto end_IL_000e;
				case 1:
					break;
				}
				goto IL_0203;
				IL_0203:
				AppHelper.ShowWarning("请选择节点后操作。");
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CparentNode_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CparentNode_003E5__2 = null;
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

		internal static bool dg1xeUyQlaDZOR8en3wv()
		{
			return oe0nUtyQiQG3mHENmp05 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateStep_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string runnerKey;

		public string controlFieldKey;

		public IDictionary<string, ActionStepParam> presetInput;

		public IDictionary<string, string> presetOutput;

		public string stepNote;

		public StepListControl _003C_003E4__this;

		public int? insertIndex;

		private StepNode _003Cnode_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object BZpPn9yQYePhV3bft1am;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_02cf;
				}
				IStepRunner runner = StepRunnerRegistry.GetRunner(runnerKey);
				bool flag;
				while (true)
				{
					ActionStep actionStep;
					if (runner != null)
					{
						actionStep = new ActionStep
						{
							StepRunnerKey = runner.Key
						};
						if (runner.StepType == StepType.If)
						{
							actionStep.IfSteps = new List<ActionStep>();
							actionStep.ElseSteps = new List<ActionStep>();
							goto IL_005c;
						}
						goto IL_0163;
					}
					pFYL1QYJiaD.Warn("CreateStep：不支持的步骤类型：" + runnerKey);
					break;
					IL_01e3:
					if (presetOutput != null)
					{
						IEnumerator<KeyValuePair<string, string>> enumerator = presetOutput.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<string, string> current = enumerator.Current;
								actionStep.OutputParams[current.Key] = current.Value;
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
					}
					if (!string.IsNullOrEmpty(stepNote))
					{
						actionStep.Note = stepNote;
					}
					if (!(flag = !runner.InputParams.HasData() && !runner.OutputParams.HasData()))
					{
						awaiter = stepListControl.RrVL1cLrGo5(_003Cnode_003E5__2).GetAwaiter();
						goto IL_0285;
					}
					goto IL_02d8;
					IL_0297:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_0198:
					IEnumerator<string> enumerator2;
					try
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							actionStep.InputParams[current2] = presetInput[current2] ?? new ActionStepParam();
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator2?.Dispose();
						}
					}
					goto IL_01e3;
					IL_0163:
					if (runner.StepType == StepType.Loop)
					{
						actionStep.IfSteps = new List<ActionStep>();
					}
					goto IL_005c;
					IL_0285:
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						goto IL_0297;
					}
					goto IL_02cf;
					IL_005c:
					_003Cnode_003E5__2 = null;
					try
					{
						_003Cnode_003E5__2 = actionStep.CreateNode();
					}
					catch (Exception ex)
					{
						pFYL1QYJiaD.Error("创建步骤出错：" + ex.Message, ex);
						AppHelper.ShowWarning("创建步骤出错：" + ex.Message);
						break;
					}
					if (!string.IsNullOrEmpty(controlFieldKey))
					{
						StepInParamDef stepInParamDef = runner.InputParams.FirstOrDefault(_003C_003Ec.Q6dSFPlVcdX ?? (_003C_003Ec.Q6dSFPlVcdX = _003C_003Ec.nJtSF0xYuLW.UJRSFLkebCf));
						if (stepInParamDef != null)
						{
							actionStep.InputParams[stepInParamDef.Key] = new ActionStepParam
							{
								Value = controlFieldKey
							};
						}
					}
					if (presetInput != null)
					{
						enumerator2 = presetInput.Keys.GetEnumerator();
						if (!Ahj0KCyQ85wwpHyLlF1v())
						{
							switch (1)
							{
							case 3:
								continue;
							case 1:
								goto IL_0198;
							case 2:
								goto IL_0285;
							case 4:
								goto IL_0297;
							}
							goto IL_0163;
						}
						goto IL_0198;
					}
					goto IL_01e3;
				}
				goto end_IL_000e;
				IL_02cf:
				flag = awaiter.GetResult();
				goto IL_02d8;
				IL_02d8:
				if (flag)
				{
					if (insertIndex.HasValue)
					{
						stepListControl._stepList.Insert(insertIndex.Value, _003Cnode_003E5__2);
					}
					else
					{
						stepListControl._stepList.Add(_003Cnode_003E5__2);
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cnode_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cnode_003E5__2 = null;
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

		internal static bool Ahj0KCyQ85wwpHyLlF1v()
		{
			return BZpPn9yQYePhV3bft1am == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSubProgramStep_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgram subProgram;

		public StepListControl _003C_003E4__this;

		public int? insertIndex;

		private StepNode _003Cnode_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object DIYT6kyQU55CwkqMbicp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				ActionStep actionStep;
				int num2;
				string text;
				if (num != 0)
				{
					SubProgramStep subProgramStep = new SubProgramStep();
					actionStep = new ActionStep
					{
						StepRunnerKey = subProgramStep.Key
					};
					_003Cnode_003E5__2 = actionStep.CreateNode();
					text = "";
					if (AppState.DataService.GlobalSubPrograms.Contains(subProgram))
					{
						num2 = 1;
						if (!wDwi1dyQxWDSN8TCkVhh())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_012a;
					}
					text = subProgram.Name;
					goto IL_0083;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_016b;
				IL_012a:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_013a;
				}
				text = "%%" + subProgram.Id;
				actionStep.InputParams[SubProgramStep.S7RtAEq85H5.Key] = new ActionStepParam
				{
					Value = "1"
				};
				goto IL_0083;
				IL_016b:
				if (awaiter.GetResult())
				{
					if (insertIndex.HasValue)
					{
						stepListControl._stepList.Insert(insertIndex.Value, _003Cnode_003E5__2);
					}
					else
					{
						stepListControl._stepList.Add(_003Cnode_003E5__2);
					}
				}
				goto end_IL_0010;
				IL_0083:
				actionStep.InputParams[SubProgramStep.SubProgramNameParam.Key] = new ActionStepParam
				{
					Value = text
				};
				awaiter = stepListControl.RrVL1cLrGo5(_003Cnode_003E5__2, text).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					num2 = 0;
					if (DIYT6kyQU55CwkqMbicp != null)
					{
						goto IL_012a;
					}
					goto IL_013a;
				}
				goto IL_016b;
				IL_013a:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cnode_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cnode_003E5__2 = null;
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

		internal static bool wDwi1dyQxWDSN8TCkVhh()
		{
			return DIYT6kyQU55CwkqMbicp == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSubProgramStepFromSharedSubProgram_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListItemDto sharedSubProgramListItemDto;

		public StepListControl _003C_003E4__this;

		public int? insertIndex;

		private StepNode _003Cnode_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object TsFYxUyQ6ND6veyLYXog;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				ActionStep actionStep = default(ActionStep);
				string text = default(string);
				int num2;
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num != 0)
				{
					SubProgramStep subProgramStep = new SubProgramStep();
					actionStep = new ActionStep
					{
						StepRunnerKey = subProgramStep.Key
					};
					_003Cnode_003E5__2 = actionStep.CreateNode();
					text = $"@@{sharedSubProgramListItemDto.Id}@{sharedSubProgramListItemDto.Revision}@{sharedSubProgramListItemDto.Title}";
					actionStep.InputParams[SubProgramStep.SubProgramNameParam.Key] = new ActionStepParam
					{
						Value = text
					};
					num2 = 1;
					if (TsFYxUyQ6ND6veyLYXog != null)
					{
						goto IL_00bd;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num2 = 0;
					if (TsFYxUyQ6ND6veyLYXog != null)
					{
						goto IL_00bd;
					}
				}
				goto IL_00c1;
				IL_00c1:
				switch (num2)
				{
				default:
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					break;
				case 1:
					actionStep.InputParams[SubProgramStep.S7RtAEq85H5.Key] = new ActionStepParam
					{
						Value = "1"
					};
					awaiter = stepListControl.RrVL1cLrGo5(_003Cnode_003E5__2, text).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				}
				if (awaiter.GetResult())
				{
					if (insertIndex.HasValue)
					{
						stepListControl._stepList.Insert(insertIndex.Value, _003Cnode_003E5__2);
					}
					else
					{
						stepListControl._stepList.Add(_003Cnode_003E5__2);
					}
				}
				goto end_IL_0010;
				IL_00bd:
				int num3 = default(int);
				num2 = num3;
				goto IL_00c1;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cnode_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cnode_003E5__2 = null;
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

		internal static bool ifHeIbyQt1SuRY0b8eNY()
		{
			return TsFYxUyQ6ND6veyLYXog == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDebugMenuItem_Click_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public StepListControl _003C_003E4__this;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		private bool _003Cdebug_003E5__2;

		private ActionItem _003Caction_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		internal static object Gp7uy9yQmxQlAiwOD1Ow;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
        List<string> list2 = default;
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_02f7;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass39_0();
				_003Cdebug_003E5__2 = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
				List<ActionStep> list = stepListControl.ac3L1RpRgxF().Select(_003C_003Ec.GegSFyP5Be1 ?? (_003C_003Ec.GegSFyP5Be1 = _003C_003Ec.nJtSF0xYuLW.V4fSFS1jaFH)).ToList();
				if (list.Count != 1 || !(list[0].StepRunnerKey == "sys:comment"))
				{
					if (list.Count == 1 && list.All(_003C_003Ec.YiKSF8eqA8y ?? (_003C_003Ec.YiKSF8eqA8y = _003C_003Ec.nJtSF0xYuLW.evOSF2T3Jt9)))
					{
						list = AppHelper.Clone(list);
						List<ActionStep>.Enumerator enumerator = list.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Disabled = false;
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
					XAction value = new XAction
					{
						Steps = list,
						Variables = stepListControl.ActionVariables,
						SubPrograms = stepListControl.SubPrograms.ToList(),
						LimitSingleInstance = false
					};
					_003Caction_003E5__3 = new ActionItem
					{
						Id = Guid.Empty.ToString(),
						Title = "临时动作",
						ActionType = ActionType.XAction,
						Data = JsonConvert.SerializeObject(value),
						EnableEvaluateVariable = ((Window.GetWindow(stepListControl) as ActionDesignerWindow)?.CurrentOptionEnableEvaluateVariable ?? true)
					};
					_003C_003E8__1.ffsSFdCZ5WO = Window.GetWindow(stepListControl);
					if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
					{
						_003C_003E8__1.ffsSFdCZ5WO.WindowState = WindowState.Minimized;
						goto IL_0254;
					}
					goto IL_02fe;
				}
				list2 = default(List<string>);
				int num2;
				if (list[0].InputParams.ContainsKey(CommentStep.tFBgyzt1kKa.Key))
				{
					string value2 = list[0].InputParams[CommentStep.tFBgyzt1kKa.Key].Value;
					if (!string.IsNullOrEmpty(value2))
					{
						list2 = value2.ExtractUrls();
						num2 = 1;
						if (!uFn8KWyQsEuOusiEPjeu())
						{
							goto IL_023d;
						}
						goto IL_0285;
					}
				}
				goto end_IL_000e;
				IL_0285:
				if (list2.HasData())
				{
					List<string>.Enumerator enumerator2 = list2.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							AppHelper.TryOpenUrlOrFile(enumerator2.Current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
						}
					}
				}
				goto end_IL_000e;
				IL_02fe:
				AppState.AppServer.ExecuteAction(_003Caction_003E5__3, -1, null, _003Cdebug_003E5__2, false, false, "", ActionTrigger.ActionEditor, _003C_003E8__1.FefSF5hOQJq);
				goto end_IL_000e;
				IL_0273:
				num = 0;
				_003C_003E1__state = 0;
				_003C_003Eu__1 = awaiter;
				goto IL_02c8;
				IL_023d:
				switch (num2)
				{
				case 3:
					break;
				default:
					goto IL_0273;
				case 1:
					goto IL_0285;
				case 2:
					goto IL_02c8;
				}
				goto IL_0254;
				IL_02c8:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				IL_02f7:
				awaiter.GetResult();
				goto IL_02fe;
				IL_0254:
				awaiter = Task.Delay(3000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num2 = 0;
					if (!uFn8KWyQsEuOusiEPjeu())
					{
						goto IL_023d;
					}
					goto IL_0273;
				}
				goto IL_02f7;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003Caction_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003Caction_003E5__3 = null;
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

		internal static bool uFn8KWyQsEuOusiEPjeu()
		{
			return Gp7uy9yQmxQlAiwOD1Ow == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditStep_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public StepNode stepNode;

		public StepListControl _003C_003E4__this;

		public string subprogramIdentifier;

		private ActionStepEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object Ro9FfEyQ4butee7vtsGJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			bool result = default(bool);
			try
			{
				if (num == 0)
				{
					goto IL_0066;
				}
				if (stepNode == null)
				{
					AppHelper.ShowWarning("stepNode 为空！");
					result = false;
					int num2 = 0;
					if (Ro9FfEyQ4butee7vtsGJ != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				else
				{
					if (Window.GetWindow(stepListControl).OwnedWindows.Count <= 0)
					{
						goto IL_0066;
					}
					result = false;
				}
				goto end_IL_0010;
				IL_0066:
				try
				{
        SubProgram subProgram = default;
        Window window = default;
					TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool?>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0334;
					}
					bool? flag = default(bool?);
					int num4;
					if (stepNode.Step.StepType == StepType.Keyboard)
					{
						KeyboardStepEditorWindow keyboardStepEditorWindow = new KeyboardStepEditorWindow(stepNode.Step)
						{
							Owner = Window.GetWindow(stepListControl)
						};
						flag = keyboardStepEditorWindow.ShowDialog();
						if (flag == true)
						{
							stepNode.UpdateNode(keyboardStepEditorWindow.ResultStep);
							result = true;
							num4 = 4;
							if (!xasaoryQhE4nHlyi1gaB())
							{
								goto IL_03d6;
							}
							goto IL_03ea;
						}
						goto IL_0492;
					}
					if (subprogramIdentifier != null || !(stepNode.Step.StepRunnerKey == "sys:subprogram"))
					{
						goto IL_026f;
					}
					ActionStepParam actionStepParam = (stepNode.Step.InputParams.ContainsKey(SubProgramStep.SubProgramNameParam.Key) ? stepNode.Step.InputParams[SubProgramStep.SubProgramNameParam.Key] : null);
					if (actionStepParam != null)
					{
						subprogramIdentifier = actionStepParam.Value;
						goto IL_0243;
					}
					List<SimpleOperationItem> list = stepListControl.SubPrograms.Select(_003C_003Ec.zM9SFEgyhSI ?? (_003C_003Ec.zM9SFEgyhSI = _003C_003Ec.nJtSF0xYuLW.Q36SFvTwp35)).ToList();
					if (list.Count < 1)
					{
						AppHelper.ShowWarning("没有可用的子程序，请先创建子程序。", true);
						num4 = 1;
						if (Ro9FfEyQ4butee7vtsGJ != null)
						{
							goto IL_03d6;
						}
						goto IL_03ea;
					}
					SelectOperationWindow selectOperationWindow = new SelectOperationWindow(list, ShowWindowLocation.CenterOwner, true, false, true)
					{
						Title = "请选择子程序",
						Owner = Window.GetWindow(stepListControl)
					};
					flag = selectOperationWindow.ShowDialog();
					if (flag == true)
					{
						subprogramIdentifier = selectOperationWindow.SelectedItem?.Name;
						if (!string.IsNullOrEmpty(subprogramIdentifier))
						{
							goto IL_0243;
						}
						AppHelper.ShowWarning("无法确定子程序名!", true);
						result = false;
					}
					else
					{
						result = false;
					}
					goto end_IL_0066;
					IL_0465:
					_003Cdlg_003E5__2 = null;
					goto IL_0492;
					IL_0334:
					flag = awaiter.GetResult();
					goto IL_033d;
					IL_03dc:
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0334;
					IL_040e:
					stepNode.UpdateNode(_003Cdlg_003E5__2.ResultStep);
					result = true;
					goto end_IL_0066;
					IL_03ea:
					switch (num4)
					{
					case 2:
						break;
					case 5:
						goto IL_035d;
					case 3:
						goto IL_03dc;
					default:
						goto IL_040e;
					case 1:
						result = false;
						goto end_IL_0066;
					case 4:
						goto end_IL_0066;
					case 6:
						goto IL_0465;
					}
					goto IL_033d;
					IL_026f:
					subProgram = null;
					if (!string.IsNullOrWhiteSpace(subprogramIdentifier))
					{
						try
						{
							subProgram = SubProgramHelper.GetSubProgramByIdentifier(subprogramIdentifier, stepListControl.SubPrograms);
							if (subProgram != null)
							{
								goto end_IL_0280;
							}
							AppHelper.ShowWarning("无法找到子程序：" + subprogramIdentifier, true);
							result = false;
							goto end_IL_0066;
							end_IL_0280:;
						}
						catch (Exception exception)
						{
							string message = "无法找到子程序：" + subprogramIdentifier + "\r\n" + exception.GetMessageWithInner();
							pFYL1QYJiaD.Warn(message, exception);
							AppHelper.ShowWarning(message, true);
							result = false;
							goto end_IL_0066;
						}
					}
					window = Window.GetWindow(stepListControl);
					if (window != null)
					{
						goto IL_035d;
					}
					AppHelper.ShowWarning("异常：获取的窗口对象为空！");
					result = false;
					goto end_IL_0066;
					IL_0243:
					if (!string.IsNullOrWhiteSpace(subprogramIdentifier))
					{
						goto IL_026f;
					}
					AppHelper.ShowWarning("无法找到子程序：" + actionStepParam.Value, true);
					result = false;
					goto end_IL_0066;
					IL_03d6:
					int num5 = default(int);
					num4 = num5;
					goto IL_03ea;
					IL_033d:
					if (flag == true)
					{
						num4 = 0;
						if (Ro9FfEyQ4butee7vtsGJ == null)
						{
							goto IL_03ea;
						}
						goto IL_040e;
					}
					goto IL_0465;
					IL_035d:
					if (window.IsLoaded)
					{
						_003Cdlg_003E5__2 = new ActionStepEditorWindow(stepNode.Step, stepListControl.ActionVariables, stepListControl.OL6L1qphqa4(), subprogramIdentifier, subProgram)
						{
							Owner = Window.GetWindow(stepListControl)
						};
						if (!stepListControl.FX6L101CnBr())
						{
							_003Cdlg_003E5__2.SetReadonly();
						}
						awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
						num4 = 3;
						if (!xasaoryQhE4nHlyi1gaB())
						{
							goto IL_03d6;
						}
						goto IL_03ea;
					}
					AppHelper.ShowWarning("异常：窗口对象状态不正确！");
					result = false;
					end_IL_0066:;
				}
				catch (Exception ex)
				{
					pFYL1QYJiaD.Warn(ex.Message, ex);
					AppHelper.ShowWarning(ex.Message);
					goto IL_0492;
				}
				goto end_IL_0010;
				IL_0492:
				result = false;
				end_IL_0010:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool xasaoryQhE4nHlyi1gaB()
		{
			return Ro9FfEyQ4butee7vtsGJ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnButtonClick_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RoutedEventArgs e;

		public StepListControl _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object pNL3ZPyFcKsuuGqol5ik;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_019b;
				}
				System.Windows.Controls.Primitives.ButtonBase buttonBase = e.OriginalSource as System.Windows.Controls.Primitives.ButtonBase;
				if (buttonBase?.Tag is StepNode stepNode)
				{
					int num2;
					if (buttonBase.Name == "BtnEdit")
					{
						awaiter = stepListControl.RrVL1cLrGo5(stepNode).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_019b;
						}
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (pNL3ZPyFcKsuuGqol5ik == null)
						{
							goto IL_0144;
						}
					}
					else
					{
						if (buttonBase.Name == "BtnDelete")
						{
							stepListControl._stepList.Remove(stepNode);
							goto IL_01a4;
						}
						if (buttonBase.Name == "CollapseButton")
						{
							num2 = 0;
							if (sDs7NByFW58bH8CmJVFO())
							{
								goto IL_015e;
							}
						}
						else
						{
							if (!(buttonBase.Name == "BtnOpenSubProgram"))
							{
								goto IL_01a4;
							}
							num2 = 0;
							if (!sDs7NByFW58bH8CmJVFO())
							{
								goto IL_0107;
							}
						}
					}
					switch (num2)
					{
					case 1:
						goto IL_0144;
					case 2:
						goto IL_015e;
					}
					goto IL_0107;
				}
				goto end_IL_000e;
				IL_019b:
				if (awaiter.GetResult())
				{
				}
				goto IL_01a4;
				IL_0107:
				if (stepListControl.FX6L101CnBr())
				{
					(Window.GetWindow(stepListControl) as ActionDesignerWindow).OpenSubProgram(stepNode.Step);
					goto IL_01a4;
				}
				AppHelper.ShowWarning("只读动作不支持此功能。");
				e.Handled = true;
				goto end_IL_000e;
				IL_01a4:
				e.Handled = true;
				goto end_IL_000e;
				IL_0144:
				_003C_003Eu__1 = awaiter;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				IL_015e:
				ToggleButton toggleButton = buttonBase as ToggleButton;
				stepNode.Collapsed = toggleButton.IsChecked == true;
				goto IL_01a4;
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

		internal static bool sDs7NByFW58bH8CmJVFO()
		{
			return pNL3ZPyFcKsuuGqol5ik == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnNodeTriggerEdit_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RoutedEventArgs e;

		public StepListControl _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object udtCvxyF2ZMhon5vheP0;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					if (!tHmfcxyFAW0nHGvLfyKe())
					{
						switch (0)
						{
						}
					}
					goto IL_0098;
				}
				if (e.OriginalSource is StepNodeControl stepNodeControl)
				{
					awaiter = stepListControl.RrVL1cLrGo5(stepNodeControl.StepNode).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0098;
				}
				goto end_IL_000e;
				IL_0098:
				awaiter.GetResult();
				e.Handled = true;
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

		static _003COnNodeTriggerEdit_003Ed__12()
		{
		}

		internal static bool tHmfcxyFAW0nHGvLfyKe()
		{
			return udtCvxyF2ZMhon5vheP0 == null;
		}

		internal static void U4GkDxyFjsWWqGsv0vLZ()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTheListBox_OnKeyDown_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public System.Windows.Input.KeyEventArgs e;

		public StepListControl _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object tQcu6dyFD005QaM7Iyki;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			StepListControl stepListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0327;
				}
				TaskAwaiter awaiter2 = default(TaskAwaiter);
				int num2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num2 = 3;
					if (!eLhFbsyF3mIMAd5sC2G7())
					{
						goto IL_02d3;
					}
					goto IL_02d7;
				}
				switch (e.Key)
				{
				case Key.E:
					break;
				case Key.H:
					stepListControl.vEIL1P4rWt2();
					goto end_IL_0010;
				case Key.Delete:
				case Key.D:
					if (stepListControl.TheListBox.SelectedItems.Count > 0)
					{
						List<StepNode>.Enumerator enumerator = stepListControl.TheListBox.SelectedItems.Cast<StepNode>().ToList().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								StepNode current = enumerator.Current;
								if (stepListControl._stepList.Contains(current))
								{
									stepListControl._stepList.Remove(current);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						e.Handled = true;
					}
					goto end_IL_0010;
				case Key.Oem2:
					goto IL_0179;
				case Key.F2:
					goto IL_01ed;
				default:
					goto end_IL_0010;
				}
				if (stepListControl.TheListBox.SelectedItems.Count == 1)
				{
					awaiter = stepListControl.RrVL1cLrGo5(stepListControl.TheListBox.SelectedItems.Cast<StepNode>().First()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (tQcu6dyFD005QaM7Iyki != null)
						{
							goto IL_02d3;
						}
						goto IL_02d7;
					}
					goto IL_0327;
				}
				goto end_IL_0010;
				IL_0179:
				if (stepListControl.TheListBox.SelectedItems.Count == 1)
				{
					int selectedIndex = stepListControl.TheListBox.SelectedIndex;
					awaiter2 = stepListControl.CreateStep("sys:comment", selectedIndex).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_02fe;
				}
				goto end_IL_0010;
				IL_02d3:
				int num3 = default(int);
				num2 = num3;
				goto IL_02d7;
				IL_02d7:
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_02b0;
					case 1:
						return;
					case 3:
						num = -1;
						_003C_003E1__state = -1;
						break;
					case 4:
						return;
					case 2:
						goto end_IL_02d7;
					}
					goto IL_02fe;
					IL_02b0:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					num2 = 1;
					if (eLhFbsyF3mIMAd5sC2G7())
					{
						continue;
					}
					goto IL_02d3;
					continue;
					end_IL_02d7:
					break;
				}
				goto end_IL_0010;
				IL_0327:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_01ed:
				if (stepListControl.TheListBox.SelectedItems.Count == 1 && stepListControl.TheListBox.SelectedItem is StepNode stepNode)
				{
					if (stepNode.Step.StepRunnerKey == "sys:subprogram")
					{
						(Window.GetWindow(stepListControl) as ActionDesignerWindow).OpenSubProgram(stepNode.Step);
					}
					else if (stepNode.Runner.StepType.IsEither(StepType.If, StepType.Loop))
					{
						stepNode.Collapsed = !stepNode.Collapsed;
					}
				}
				goto end_IL_0010;
				IL_02fe:
				awaiter2.GetResult();
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

		internal static bool eLhFbsyF3mIMAd5sC2G7()
		{
			return tQcu6dyFD005QaM7Iyki == null;
		}
	}

	private StepListBox TheListBox;

	public FullyObservableCollection<StepNode> _stepList;

	private bool mq4L1BciAMn;

	private static readonly ILog pFYL1QYJiaD;

	private DefaultDropHandler mj1L1jUHtF9;

	internal static StepListControl xC9jf6FrmyQ31mElCRE6;

	public ObservableCollection<ActionVariable> ActionVariables => (ObservableCollection<ActionVariable>)GetValue(ActionStepsWrapper.ActionVariablesProperty);

	public SmartCollection<SubProgram> SubPrograms => ((ActionDesignerWindow)Window.GetWindow(this)).SubPrograms;

	public XAction Action => (XAction)GetValue(ActionDesignerWindow.ActionProperty);

	public void SetSteps(FullyObservableCollection<StepNode> steps)
	{
		_stepList = steps;
		if (TheListBox != null)
		{
			TheListBox.ItemsSource = steps;
		}
	}

	public override void OnApplyTemplate()
	{
		if (TheListBox != null)
		{
			return;
		}
		base.OnApplyTemplate();
		TheListBox = GetTemplateChild("TheListBox") as StepListBox;
		int num = 0;
		if (!FeN3WXFrsKvjAjlF2DsK())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (_stepList != null)
		{
			TheListBox.ItemsSource = _stepList;
		}
		TheListBox.KeyDown += y1xL1y9wVbJ;
		TheListBox.MouseRightButtonDown += Q0ZL1JBUhgh;
		TheListBox.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new RoutedEventHandler(H5ZL1Nqic2a));
		TheListBox.AddHandler(StepNodeControl.TriggerContextMenuEvent, new RoutedEventHandler(oCOL1uYqexA));
		TheListBox.AddHandler(StepNodeControl.TriggerEditEvent, new RoutedEventHandler(eXhL12tyspJ));
	}

	[AsyncStateMachine(typeof(_003COnNodeTriggerEdit_003Ed__12))]
	private void eXhL12tyspJ(object sender, RoutedEventArgs e)
	{
		_003COnNodeTriggerEdit_003Ed__12 stateMachine = default(_003COnNodeTriggerEdit_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void oCOL1uYqexA(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.q7XSFcscIVM = this;
		_003C_003Ec__DisplayClass13_.I1XSFVsO85R = e.OriginalSource as StepNodeControl;
		if (_003C_003Ec__DisplayClass13_.I1XSFVsO85R != null)
		{
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass13_.omhSFqsY4Y0);
			e.Handled = true;
		}
	}

	[AsyncStateMachine(typeof(_003COnButtonClick_003Ed__14))]
	private void H5ZL1Nqic2a(object sender, RoutedEventArgs e)
	{
		_003COnButtonClick_003Ed__14 stateMachine = default(_003COnButtonClick_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Q0ZL1JBUhgh(object sender, MouseButtonEventArgs e)
	{
		bool num = ClipboardHelper.ContainsData("quicker-action-steps");
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
		if (num)
		{
			System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem
			{
				Header = "粘贴(_V)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Paste}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem.Click += r0sL1KmGka7;
			contextMenu.Items.Add(menuItem);
		}
		if (contextMenu.Items.Count > 0)
		{
			TheListBox.ContextMenu = contextMenu;
		}
		else
		{
			TheListBox.ContextMenu = null;
		}
	}

	private bool FX6L101CnBr()
	{
		if (Window.GetWindow(this) is ActionDesignerWindow actionDesignerWindow)
		{
			return actionDesignerWindow.GO3LhQ2nfmk();
		}
		return false;
	}

	private void CEgL1CNT5vH(StepNode stepNode_0)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.laySFs9Ruuf = this;
		_003C_003Ec__DisplayClass17_.yS0SFHDjxTx = stepNode_0;
		if (!FX6L101CnBr())
		{
			return;
		}
		bool num = ClipboardHelper.ContainsData("quicker-action-steps");
		bool num2 = TheListBox.SelectedItems.Count > 0;
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
		if (num2)
		{
			System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem
			{
				Header = "复制(_C)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Copy}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem.Click += bKkL1VQrQFL;
			contextMenu.Items.Add(menuItem);
			AppHelper.AddMenuItem(contextMenu.Items, "剪切(_X)", "剪切选中的步骤", $"fa:{EFontAwesomeIcon.Light_Cut}:#6aaded", oxdL1ZjqN6y);
		}
		if (num)
		{
			System.Windows.Controls.MenuItem menuItem2 = new System.Windows.Controls.MenuItem
			{
				Header = "在前面粘贴(_B)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Paste}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem2.Click += _003C_003Ec__DisplayClass17_.JuDSFZxxsWy;
			contextMenu.Items.Add(menuItem2);
			System.Windows.Controls.MenuItem menuItem3 = new System.Windows.Controls.MenuItem
			{
				Header = "在后面粘贴(_A)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Paste}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem3.Click += _003C_003Ec__DisplayClass17_.yxySF9IZrDJ;
			contextMenu.Items.Add(menuItem3);
		}
		contextMenu.Items.Add(new Separator());
		int num3;
		if (TheListBox.SelectedItems.Count == 1)
		{
			num3 = 1;
			if (xC9jf6FrmyQ31mElCRE6 != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			goto IL_0421;
		}
		goto IL_094b;
		IL_0421:
		_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_2 = default(_003C_003Ec__DisplayClass17_1);
		_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_3 = default(_003C_003Ec__DisplayClass17_2);
		switch (num3)
		{
		case 3:
			break;
		case 1:
		{
			_003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_1();
			int num4 = 6;
			goto case 6;
		}
		case 6:
		{
			_003C_003Ec__DisplayClass17_2.GFVSFxZH1uM = _003C_003Ec__DisplayClass17_;
			_003C_003Ec__DisplayClass17_2.ohlSFKIblq4 = TheListBox.SelectedItem as StepNode;
			if (!(_003C_003Ec__DisplayClass17_2.ohlSFKIblq4.Step.StepRunnerKey == "sys:simpleIf"))
			{
				goto case 2;
			}
			System.Windows.Controls.MenuItem menuItem4 = new System.Windows.Controls.MenuItem
			{
				Header = "增加 “否则” 分支(_E)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_ArrowAltRight}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem4.Click += _003C_003Ec__DisplayClass17_2.QOqSF1k1KCA;
			contextMenu.Items.Add(menuItem4);
			goto IL_094b;
		}
		case 2:
		{
			if (!(_003C_003Ec__DisplayClass17_2.ohlSFKIblq4.Step.StepRunnerKey == "sys:if") || _003C_003Ec__DisplayClass17_2.ohlSFKIblq4.Step.ElseSteps.HasData())
			{
				goto default;
			}
			System.Windows.Controls.MenuItem menuItem5 = new System.Windows.Controls.MenuItem
			{
				Header = "隐藏 “否则” 分支(_E)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_ArrowAltRight}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem5.Click += _003C_003Ec__DisplayClass17_2.JdCSFbiZOgW;
			contextMenu.Items.Add(menuItem5);
			goto IL_094b;
		}
		default:
			if (_003C_003Ec__DisplayClass17_2.ohlSFKIblq4.Step.StepRunnerKey == "sys:subprogram")
			{
				_003C_003Ec__DisplayClass17_3 = new _003C_003Ec__DisplayClass17_2();
				_003C_003Ec__DisplayClass17_3.UYOSFjE5BUu = _003C_003Ec__DisplayClass17_2;
				AppHelper.AddMenuItem(contextMenu.Items, "打开子程序(_O)", "", $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#6aaded", _003C_003Ec__DisplayClass17_3.UYOSFjE5BUu.acOSF6aHovG);
				_003C_003Ec__DisplayClass17_3.dAGSFQhLSKg = SubProgramStep.GetSubProgramIdentifier(_003C_003Ec__DisplayClass17_3.UYOSFjE5BUu.ohlSFKIblq4.Step);
				if (_003C_003Ec__DisplayClass17_3.dAGSFQhLSKg.StartsWith("@@"))
				{
					int num4 = 5;
					goto case 5;
				}
				goto IL_0725;
			}
			goto IL_094b;
		case 5:
			AppHelper.AddMenuItem(contextMenu.Items, "检查更新(_U)", "", $"fa:{EFontAwesomeIcon.Light_ArrowUp}:#6aaded", _003C_003Ec__DisplayClass17_3.uCOSFrMrq1B);
			AppHelper.AddMenuItem(contextMenu.Items, "转换为动作内子程序(_I)", "", $"fa:{EFontAwesomeIcon.Light_Exchange}:#6aaded", _003C_003Ec__DisplayClass17_3.oHpSFpL1xJw);
			goto IL_0725;
		case 4:
			goto IL_09b4;
		case 7:
			goto IL_0c2c;
			IL_0725:
			if (_003C_003Ec__DisplayClass17_3.dAGSFQhLSKg.StartsWith("%%"))
			{
				AppHelper.AddMenuItem(contextMenu.Items, "转换为动作内子程序(_I)", "", $"fa:{EFontAwesomeIcon.Light_Exchange}:#6aaded", _003C_003Ec__DisplayClass17_3.xyRSFBQw2Ph);
			}
			AppHelper.AddMenuItem(contextMenu.Items, "复制步骤参数", "复制输入输出参数，方便迁移到另一个子程序步骤", "", _003C_003Ec__DisplayClass17_3.UYOSFjE5BUu.TGxSFXNvqnS);
			try
			{
				if (System.Windows.Forms.Clipboard.ContainsData("step-params"))
				{
					AppHelper.AddMenuItem(contextMenu.Items, "粘贴步骤参数", "粘贴已复制的输入输出参数设置", "", _003C_003Ec__DisplayClass17_3.UYOSFjE5BUu.fsaSFm9TYYv);
				}
			}
			catch (Exception ex)
			{
				pFYL1QYJiaD.Warn(ex.Message, ex);
				AppHelper.ShowWarning(ex.Message);
			}
			goto IL_094b;
		}
		goto IL_02e4;
		IL_0243:
		if (TheListBox.SelectedItems.Count > 0)
		{
			System.Windows.Controls.MenuItem menuItem6 = new System.Windows.Controls.MenuItem
			{
				Header = "转换成子程序(_S)",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Cube}:#6aaded",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem6.Click += z98L1HMfcnQ;
			contextMenu.Items.Add(menuItem6);
			num3 = 4;
			if (!FeN3WXFrsKvjAjlF2DsK())
			{
				goto IL_0421;
			}
		}
		goto IL_09b4;
		IL_02e4:
		System.Windows.Controls.MenuItem menuItem7 = default(System.Windows.Controls.MenuItem);
		AppHelper.AddMenuItem(menuItem7.Items, "循环：重复(_R)", "快捷键：Ctrl+R", $"fa:{EFontAwesomeIcon.Light_Repeat}:#6aaded", _003C_003Ec__DisplayClass17_.UWySFYrMys1);
		AppHelper.AddMenuItem(menuItem7.Items, "如果/否则 的 “如果” 分支(_I)", "快捷键：Ctrl+I", $"fa:{EFontAwesomeIcon.Light_ProjectDiagram}:#6aaded", _003C_003Ec__DisplayClass17_.cFcSFI97Flx);
		AppHelper.AddMenuItem(menuItem7.Items, "如果/否则 的 “否则” 分支(_F)", "", $"fa:{EFontAwesomeIcon.Light_ProjectDiagram}:#6aaded", _003C_003Ec__DisplayClass17_.BuQSFWIpVlo);
		AppHelper.AddMenuItem(menuItem7.Items, "如果(_S)", "快捷键：Ctrl+Shift+I", $"fa:{EFontAwesomeIcon.Light_ProjectDiagram}:#6aaded", _003C_003Ec__DisplayClass17_.VTmSFk5Qdfi);
		goto IL_0243;
		IL_094b:
		AppHelper.AddMenuItem(contextMenu.Items, "插入延时(_T)", "选择一个模块，在模块后插入延时;选择多个模块，在模块中间插入延时;", $"fa:{EFontAwesomeIcon.Light_Clock}:#6aaded", l06L1evb5ly);
		if (TheListBox.SelectedItems.Count <= 0)
		{
			goto IL_0243;
		}
		menuItem7 = new System.Windows.Controls.MenuItem
		{
			Header = "放入...(_F)",
			Icon = new IconControl
			{
				Icon = $"fa:{EFontAwesomeIcon.Light_ObjectGroup}:#6aaded",
				Width = 16.0,
				Height = 16.0
			}
		};
		contextMenu.Items.Add(menuItem7);
		AppHelper.AddMenuItem(menuItem7.Items, "步骤组(_G)", "快捷键：Ctrl+G", $"fa:{EFontAwesomeIcon.Light_LayerGroup}:#6aaded", _003C_003Ec__DisplayClass17_.KQqSFh217Uk);
		AppHelper.AddMenuItem(menuItem7.Items, "循环：每个(_E)", "", $"fa:{EFontAwesomeIcon.Light_Repeat}:#6aaded", _003C_003Ec__DisplayClass17_.x8vSFeyTMBP);
		goto IL_02e4;
		IL_0c2c:
		contextMenu.Items.Add(new Separator());
		AppHelper.AddMenuItem(contextMenu.Items, "查看模块文档(_Q)", "打开模块文档网页", $"fa:{EFontAwesomeIcon.Light_QuestionCircle}:#6aaded", My9L1hQxGbM);
		AppHelper.AddMenuItem(contextMenu.Items, "高亮相似步骤(_H)", "高亮相同模块的步骤", $"fa:{EFontAwesomeIcon.Light_Highlighter}:#FF3333", _003C_003Ec__DisplayClass17_.lX0SFGEVue6);
		goto IL_0cd9;
		IL_09b4:
		if (TheListBox.SelectedItems.Count > 0)
		{
			System.Windows.Controls.MenuItem menuItem8 = new System.Windows.Controls.MenuItem
			{
				Header = "运行(_R)",
				ToolTip = "运行选中的步骤，Shift+点击以调试方式运行",
				Icon = new IconControl
				{
					Icon = $"fa:{EFontAwesomeIcon.Light_Play}:#f5b042",
					Width = 16.0,
					Height = 16.0
				}
			};
			menuItem8.Click += AloL1ICqroo;
			contextMenu.Items.Add(menuItem8);
		}
		if (TheListBox.SelectedItems.Cast<StepNode>().Any(_003C_003Ec.YECSFCJs37g ?? (_003C_003Ec.YECSFCJs37g = _003C_003Ec.nJtSF0xYuLW.UnBSFg3GemB)))
		{
			AppHelper.AddMenuItem(contextMenu.Items, "展开", "展开选中节点的所有级别子项", $"fa:{EFontAwesomeIcon.Light_ExpandAlt}:#6aaded", WbML11vV0ZK);
			AppHelper.AddMenuItem(contextMenu.Items, "折叠", "折叠选中节点的所有级别子项", $"fa:{EFontAwesomeIcon.Light_CompressAlt}:#6aaded", RxeL1YBBTRC);
		}
		System.Windows.Controls.MenuItem menuItem9 = new System.Windows.Controls.MenuItem
		{
			Header = "停用/取消停用(_P)",
			Icon = new IconControl
			{
				Icon = $"fa:{EFontAwesomeIcon.Light_Ban}:#E00000",
				Width = 16.0,
				Height = 16.0
			}
		};
		menuItem9.Click += vtIL1bNZf9r;
		contextMenu.Items.Add(menuItem9);
		System.Windows.Controls.MenuItem menuItem10 = new System.Windows.Controls.MenuItem
		{
			Header = "删除(_D)",
			Icon = new IconControl
			{
				Icon = $"fa:{EFontAwesomeIcon.Light_TrashAlt}:#E00000",
				Width = 16.0,
				Height = 16.0
			}
		};
		menuItem10.Click += TEJL19GQ9Ay;
		contextMenu.Items.Add(menuItem10);
		if (TheListBox.SelectedItems.Count == 1)
		{
			int num4 = 7;
			goto IL_0c2c;
		}
		goto IL_0cd9;
		IL_0cd9:
		if (contextMenu.Items.Count > 0)
		{
			TheListBox.ContextMenu = contextMenu;
		}
		else
		{
			TheListBox.ContextMenu = null;
		}
	}

	private void vEIL1P4rWt2()
	{
		StepNode stepNode = TheListBox.SelectedItems.Cast<StepNode>().FirstOrDefault();
		if (stepNode != null && Window.GetWindow(this) is ActionDesignerWindow actionDesignerWindow)
		{
			actionDesignerWindow.HighlightText(stepNode.Runner.Name);
		}
	}

	internal void tkcL1EowB31()
	{
		bLhL1W9Hfvu("sys:group", true);
	}

	[AsyncStateMachine(typeof(_003CTheListBox_OnKeyDown_003Ed__20))]
	private void y1xL1y9wVbJ(object sender, System.Windows.Input.KeyEventArgs e)
	{
		_003CTheListBox_OnKeyDown_003Ed__20 stateMachine = default(_003CTheListBox_OnKeyDown_003Ed__20);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void mS9L18fFFd5(object sender, MouseButtonEventArgs e)
	{
		if (sender is ListBoxItem && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
		{
			ListBoxItem listBoxItem = sender as ListBoxItem;
			e.Handled = listBoxItem.IsSelected;
		}
	}

	[AsyncStateMachine(typeof(_003CCreateStep_003Ed__22))]
	public Task CreateStep(string runnerKey, int? insertIndex, string controlFieldKey = null, IDictionary<string, string> presetOutput = null, IDictionary<string, ActionStepParam> presetInput = null, string stepNote = null)
	{
		_003CCreateStep_003Ed__22 stateMachine = default(_003CCreateStep_003Ed__22);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.runnerKey = runnerKey;
		stateMachine.insertIndex = insertIndex;
		stateMachine.controlFieldKey = controlFieldKey;
		stateMachine.presetOutput = presetOutput;
		stateMachine.presetInput = presetInput;
		stateMachine.stepNote = stepNote;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateSubProgramStep_003Ed__23))]
	private Task sVbL1aKWrN8(SubProgram subProgram_0, int? nullable_0)
	{
		_003CCreateSubProgramStep_003Ed__23 stateMachine = default(_003CCreateSubProgramStep_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.subProgram = subProgram_0;
		stateMachine.insertIndex = nullable_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateSubProgramStepFromSharedSubProgram_003Ed__24))]
	private Task BPRL17uunmS(SharedSubProgramListItemDto sharedSubProgramListItemDto_0, int? nullable_0)
	{
		_003CCreateSubProgramStepFromSharedSubProgram_003Ed__24 stateMachine = default(_003CCreateSubProgramStepFromSharedSubProgram_003Ed__24);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sharedSubProgramListItemDto = sharedSubProgramListItemDto_0;
		stateMachine.insertIndex = nullable_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private IList<StepNode> ac3L1RpRgxF()
	{
		IList<StepNode> list = new List<StepNode>();
		foreach (StepNode step in _stepList)
		{
			if (TheListBox.SelectedItems.Contains(step))
			{
				list.Add(step);
			}
		}
		return list;
	}

	private bool OL6L1qphqa4()
	{
		ActionDesignerWindow actionDesignerWindow = (ActionDesignerWindow)Window.GetWindow(this);
		if (actionDesignerWindow != null)
		{
			if (!actionDesignerWindow.IsSubProgram)
			{
				return actionDesignerWindow.IsEditingSubProgram;
			}
			return true;
		}
		return false;
	}

	[AsyncStateMachine(typeof(_003CEditStep_003Ed__28))]
	private Task<bool> RrVL1cLrGo5(StepNode stepNode_0, string string_0 = null)
	{
		_003CEditStep_003Ed__28 stateMachine = default(_003CEditStep_003Ed__28);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.stepNode = stepNode_0;
		stateMachine.subprogramIdentifier = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void Paste()
	{
		int index = TheListBox.Items.Count;
		if (TheListBox.SelectedItems.Count > 0)
		{
			index = -1;
			foreach (object selectedItem in TheListBox.SelectedItems)
			{
				int num = TheListBox.Items.IndexOf(selectedItem);
				if (num > index)
				{
					index = num;
				}
			}
			index++;
		}
		Paste(index);
	}

	private void Paste(int index)
	{
		ActionStepsDto actionStepsDto = null;
		try
		{
			if (!ClipboardHelper.ContainsData("quicker-action-steps"))
			{
				AppHelper.ShowWarning("剪贴板中没有数据。");
				return;
			}
			actionStepsDto = JsonConvert.DeserializeObject<ActionStepsDto>((string)ClipboardHelper.GetData("quicker-action-steps"));
			if (actionStepsDto == null || actionStepsDto.Steps == null || actionStepsDto.Steps.Count == 0)
			{
				AppHelper.ShowWarning("要粘贴的步骤数量为0。");
				return;
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("读取剪贴板失败，数据格式不正确！" + exception.GetMessageWithInner());
			return;
		}
		if (ActionVariables == null)
		{
			AppHelper.ShowWarning("变量列表为Null，请重试。\r\n如果问题持续存在，可能是软件遇到了BUG，请联系我们获得支持。", true);
			return;
		}
		new StringBuilder();
		IList<string> list = new List<string>();
		IEnumerator<ActionVariable> enumerator = actionStepsDto.Variables.GetEnumerator();
		if (FeN3WXFrsKvjAjlF2DsK())
		{
			switch (0)
			{
			}
		}
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
				_003C_003Ec__DisplayClass30_.bUWSF4gjvI1 = enumerator.Current;
				ActionVariable actionVariable = ActionVariables.FirstOrDefault(_003C_003Ec__DisplayClass30_.iXXSFn9TDvH);
				if (actionVariable == null)
				{
					if (!OL6L1qphqa4())
					{
						_003C_003Ec__DisplayClass30_.bUWSF4gjvI1.IsInput = false;
						if (!FeN3WXFrsKvjAjlF2DsK())
						{
							switch (0)
							{
							}
						}
						_003C_003Ec__DisplayClass30_.bUWSF4gjvI1.IsOutput = false;
						_003C_003Ec__DisplayClass30_.bUWSF4gjvI1.InputParamInfo = null;
						_003C_003Ec__DisplayClass30_.bUWSF4gjvI1.OutputParamInfo = null;
					}
					else
					{
						_003C_003Ec__DisplayClass30_.bUWSF4gjvI1.SaveState = false;
					}
					ActionVariables.Add(_003C_003Ec__DisplayClass30_.bUWSF4gjvI1);
				}
				else if (actionVariable.Type != _003C_003Ec__DisplayClass30_.bUWSF4gjvI1.Type)
				{
					list.Add(actionVariable.Key);
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		if (list.Count > 0)
		{
			AppHelper.ShowWarning("无法粘贴步骤，以下变量存在冲突：" + string.Join(",", list) + "。", true);
			return;
		}
		try
		{
			int num = Math.Min(index, _stepList.Count);
			IList<StepNode> list2 = new List<StepNode>();
			foreach (ActionStep step in actionStepsDto.Steps)
			{
				StepNode item = step.CreateNode();
				list2.Add(item);
				_stepList.Insert(num++, item);
			}
			TheListBox.SelectedItems.Clear();
			foreach (StepNode item2 in list2)
			{
				TheListBox.SelectedItems.Add(item2);
			}
		}
		catch (Exception ex)
		{
			pFYL1QYJiaD.Warn($"粘贴步骤出错,位置{index}/{_stepList.Count}：{ex.Message}", ex);
			AppHelper.ShowWarning($"粘贴步骤出错,位置{index}/{_stepList.Count}：{ex.Message}");
		}
	}

	public void Copy()
	{
		if (TheListBox.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要复制的步骤。");
			return;
		}
		if (!FX6L101CnBr())
		{
			AppHelper.ShowWarning("本动作不支持编辑。");
			if (xC9jf6FrmyQ31mElCRE6 == null)
			{
				switch (0)
				{
				}
			}
			return;
		}
		ActionStepsDto actionStepsDto = new ActionStepsDto
		{
			Steps = new List<ActionStep>()
		};
		foreach (StepNode step in _stepList)
		{
			if (TheListBox.SelectedItems.Contains(step))
			{
				actionStepsDto.Steps.Add(step.Step);
			}
		}
		IList<string> list = new List<string>();
		try
		{
			XActionUiHelper.AddUsedVarKeys(ActionVariables, actionStepsDto.Steps, list);
		}
		catch (Exception ex)
		{
			pFYL1QYJiaD.Warn("查找使用过的变量出错:" + ex.Message, ex);
			AppHelper.ShowWarning("查找使用过的变量出错。" + ex.Message);
			return;
		}
		foreach (ActionVariable actionVariable in ActionVariables)
		{
			if (list.Contains(actionVariable.Key))
			{
				actionStepsDto.Variables.Add(actionVariable);
			}
		}
		string data = JsonConvert.SerializeObject(actionStepsDto, Formatting.Indented);
		ClipboardHelper.SetData("quicker-action-steps", data);
	}

	private void bKkL1VQrQFL(object sender, RoutedEventArgs e)
	{
		Copy();
	}

	public void Cut()
	{
		if (!FX6L101CnBr())
		{
			AppHelper.ShowWarning("本动作不支持编辑。");
			return;
		}
		Copy();
		foreach (StepNode item in TheListBox.SelectedItems.Cast<StepNode>().ToList())
		{
			_stepList.Remove(item);
		}
	}

	private void oxdL1ZjqN6y(object sender, RoutedEventArgs e)
	{
		Cut();
	}

	private void TEJL19GQ9Ay(object sender, RoutedEventArgs e)
	{
		foreach (StepNode item in TheListBox.SelectedItems.Cast<StepNode>().ToList())
		{
			_stepList.Remove(item);
		}
	}

	private void My9L1hQxGbM(object sender, RoutedEventArgs e)
	{
		object selectedItem = TheListBox.SelectedItem;
		if (selectedItem != null)
		{
			IStepRunner runner = StepRunnerRegistry.GetRunner((selectedItem as StepNode).Step.StepRunnerKey);
			if (runner != null)
			{
				AppHelper.TryOpenUrlOrFile(runner.HelpLink);
			}
		}
	}

	private void l06L1evb5ly(object sender, RoutedEventArgs e)
	{
		if (TheListBox.SelectedItems.Count == 1)
		{
			_stepList.Insert(TheListBox.SelectedIndex + 1, WaitTimeRunner.CreateStep(100).CreateNode());
		}
		else
		{
			if (TheListBox.SelectedItems.Count <= 1)
			{
				return;
			}
			IList<StepNode> list = ac3L1RpRgxF();
			int num = list.Count - 1;
			int num3 = default(int);
			while (num >= 0 && num != 0)
			{
				if (list[num].Step.StepRunnerKey != "sys:delay" && list[num - 1].Step.StepRunnerKey != "sys:delay")
				{
					int index = _stepList.IndexOf(list[num]);
					int num2 = 0;
					if (!FeN3WXFrsKvjAjlF2DsK())
					{
						num2 = num3;
					}
					switch (num2)
					{
					default:
						_stepList.Insert(index, WaitTimeRunner.CreateStep(100).CreateNode());
						break;
					}
				}
				num--;
			}
		}
	}

	private void RxeL1YBBTRC(object sender, RoutedEventArgs e)
	{
		wclL1mlwyRH(true);
	}

	[AsyncStateMachine(typeof(_003CDebugMenuItem_Click_003Ed__39))]
	private void AloL1ICqroo(object sender, RoutedEventArgs e)
	{
		_003CDebugMenuItem_Click_003Ed__39 stateMachine = default(_003CDebugMenuItem_Click_003Ed__39);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CConvertToChildSteps_003Ed__40))]
	internal Task bLhL1W9Hfvu(string string_0, bool bool_1)
	{
		_003CConvertToChildSteps_003Ed__40 stateMachine = default(_003CConvertToChildSteps_003Ed__40);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.stepTypeKey = string_0;
		stateMachine.addToIfSteps = bool_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static void ewjL1kyhI95(System.Windows.Controls.ListBox listBox_0)
	{
		if (listBox_0.SelectedItem != null)
		{
			((ListBoxItem)listBox_0.ItemContainerGenerator.ContainerFromItem(listBox_0.SelectedItem))?.Focus();
		}
	}

	internal void AwxL1GKy4g5(int int_0)
	{
		IList<StepNode> list = ac3L1RpRgxF();
		if (list.Count < 1)
		{
			AppHelper.ShowWarning("请选择节点后操作。");
			return;
		}
		if (int_0 < 0)
		{
			int num = _stepList.IndexOf(list.First());
			if (num > 0)
			{
				StepNode item = _stepList[num - 1];
				foreach (StepNode item3 in list)
				{
					_stepList.Remove(item3);
				}
				foreach (StepNode item4 in list)
				{
					_stepList.Insert(_stepList.IndexOf(item), item4);
				}
			}
			E44L1sYuinA(list.First());
		}
		else
		{
			int num2 = _stepList.IndexOf(list.Last());
			if (num2 < _stepList.Count - 1)
			{
				StepNode item2 = _stepList[num2 + 1];
				foreach (StepNode item5 in list)
				{
					_stepList.Remove(item5);
				}
				int num3 = _stepList.IndexOf(item2) + 1;
				foreach (StepNode item6 in list)
				{
					_stepList.Insert(num3++, item6);
				}
			}
			E44L1sYuinA(list.Last());
		}
		foreach (StepNode item7 in list)
		{
			TheListBox.SelectedItems.Add(item7);
		}
	}

	private void E44L1sYuinA(StepNode stepNode_0)
	{
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
		_003C_003Ec__DisplayClass43_.Rs9SFMtSneM = this;
		_003C_003Ec__DisplayClass43_.rWASFAKhIKj = stepNode_0;
		base.Dispatcher.BeginInvoke(new Action(_003C_003Ec__DisplayClass43_.k2NSFT20ZJp), DispatcherPriority.Loaded);
	}

	private void z98L1HMfcnQ(object sender, RoutedEventArgs e)
	{
        IEnumerator<ActionVariable> enumerator3 = default;
        ActionStep actionStep = default;
		IList<StepNode> list = ac3L1RpRgxF();
		if (list.Count < 1)
		{
			AppHelper.ShowWarning("请选择节点后操作。");
			return;
		}
		List<ActionStep> steps = list.Select(_003C_003Ec.HioSFRayLws ?? (_003C_003Ec.HioSFRayLws = _003C_003Ec.nJtSF0xYuLW.e2qSFJ3vIC0)).ToList();
		SubProgramEditWindow subProgramEditWindow = new SubProgramEditWindow(null, SubPrograms)
		{
			Owner = Window.GetWindow(this)
		};
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_;
		IList<string> list2;
		IList<string> list3;
		IList<string> list4;
		int index;
		List<StepNode>.Enumerator enumerator;
		int num;
		if (subProgramEditWindow.ShowDialog() == true)
		{
			_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
			_003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn = new SubProgram
			{
				Id = Guid.NewGuid().ToString(),
				Name = subProgramEditWindow.SubProgramName,
				Description = subProgramEditWindow.SubProgramDesc,
				CreateTimeUtc = DateTime.UtcNow
			};
			SmartCollection<SubProgram> subPrograms = SubPrograms;
			if (subPrograms != null && subPrograms.Any(_003C_003Ec__DisplayClass44_.uS0SFOVH4xg))
			{
				AppHelper.ShowWarning("子程序 " + _003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn.Name + " 已存在，不能导入或创建重名的子程序。");
				return;
			}
			list2 = new DistinctList<string>();
			list3 = new DistinctList<string>();
			list4 = new DistinctList<string>();
			try
			{
				XActionUiHelper.AddUsedVarKeys(ActionVariables, steps, list2, list3, list4);
			}
			catch (Exception ex)
			{
				pFYL1QYJiaD.Warn("查找使用过的变量出错:" + ex.Message, ex);
				AppHelper.ShowWarning("查找使用过的变量出错。" + ex.Message);
				return;
			}
			index = ((IEnumerable<StepNode>)list).Min((Func<StepNode, int>)E9DL1pBGxtN);
			enumerator = TheListBox.SelectedItems.Cast<StepNode>().ToList().GetEnumerator();
			num = 0;
			if (xC9jf6FrmyQ31mElCRE6 != null)
			{
				goto IL_01a9;
			}
			goto IL_01f3;
		}
		return;
		IL_0207:
		IList<string> inputVarList = new DistinctList<string>();
		IList<string> outputVarList = new DistinctList<string>();
		try
		{
			XActionUiHelper.AddUsedVarKeys(Action.Variables, Action.Steps, _003C_003Ec__DisplayClass44_.MCOSFlybeXx, inputVarList, outputVarList);
		}
		catch (Exception ex2)
		{
			pFYL1QYJiaD.Warn("查找使用过的变量出错:" + ex2.Message, ex2);
			AppHelper.ShowWarning("查找使用过的变量出错。" + ex2.Message);
			return;
		}
		using (IEnumerator<string> enumerator2 = list2.GetEnumerator())
		{
			int num3 = default(int);
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_2 = new _003C_003Ec__DisplayClass44_1();
				_003C_003Ec__DisplayClass44_2.zs5SFf1k5R2 = enumerator2.Current;
				int num2 = 0;
				if (!FeN3WXFrsKvjAjlF2DsK())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (!ActionVariables.Any(_003C_003Ec__DisplayClass44_2.DA6SFiO3Mmo))
				{
					continue;
				}
				ActionVariable actionVariable = ActionVariables.FirstOrDefault(_003C_003Ec__DisplayClass44_2.L8oSF3rdKVk);
				if (actionVariable != null)
				{
					ActionVariable actionVariable2 = JsonConvert.DeserializeObject<ActionVariable>(JsonConvert.SerializeObject(actionVariable));
					actionVariable2.SaveState = false;
					if (list3.Contains(actionVariable2.Key))
					{
						actionVariable2.IsInput = true;
					}
					if (list4.Contains(actionVariable2.Key))
					{
						actionVariable2.IsOutput = true;
					}
					_003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn.Variables.Add(actionVariable2);
				}
			}
		}
		_003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn.Steps = steps;
		SubPrograms.Add(_003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn);
		actionStep = new ActionStep
		{
			StepRunnerKey = "sys:subprogram",
			InputParams = new Dictionary<string, ActionStepParam>(),
			OutputParams = new Dictionary<string, string>()
		};
		actionStep.InputParams[SubProgramStep.SubProgramNameParam.Key] = new ActionStepParam
		{
			Value = _003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn.Name
		};
		enumerator3 = _003C_003Ec__DisplayClass44_.Cc1SFUQ7tFn.Variables.GetEnumerator();
		goto IL_03dc;
		IL_03dc:
		try
		{
			while (enumerator3.MoveNext())
			{
				ActionVariable current = enumerator3.Current;
				if (current.IsInput)
				{
					actionStep.InputParams[SubProgramStep.CreateStepInParam(current).Key] = new ActionStepParam
					{
						VarKey = current.Key
					};
				}
				if (current.IsOutput)
				{
					actionStep.OutputParams[SubProgramStep.CreateStepOutParam(current).Key] = current.Key;
				}
			}
		}
		finally
		{
			enumerator3?.Dispose();
		}
		_stepList.Insert(index, actionStep.CreateNode());
		ActionVariables.Where(_003C_003Ec__DisplayClass44_.YCWSFFev0OA).ToList();
		MessageBoxHelper.Show("转换完成了。您还需要:\n 手动设置子程序变量的输入和输出选项;\n 在主程序中清理不使用的变量。", "转换子程序");
		return;
		IL_01f3:
		switch (num)
		{
		case 1:
			goto IL_0207;
		case 2:
			goto IL_03dc;
		}
		goto IL_01a9;
		IL_01a9:
		try
		{
			while (enumerator.MoveNext())
			{
				StepNode current2 = enumerator.Current;
				_stepList.Remove(current2);
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
		_003C_003Ec__DisplayClass44_.MCOSFlybeXx = new DistinctList<string>();
		num = 1;
		if (!FeN3WXFrsKvjAjlF2DsK())
		{
			goto IL_01f3;
		}
		goto IL_0207;
	}

	private void WbML11vV0ZK(object sender, RoutedEventArgs e)
	{
		wclL1mlwyRH(false);
	}

	private void vtIL1bNZf9r(object sender, RoutedEventArgs e)
	{
		List<StepNode> list = TheListBox.SelectedItems.Cast<StepNode>().ToList();
		if (list.Count == 0)
		{
			return;
		}
		bool disabled = !list[0].Step.Disabled;
		foreach (StepNode item in list)
		{
			item.Disabled = disabled;
		}
	}

	private DefaultDropHandler oShL16MKOH2()
	{
		if (mj1L1jUHtF9 == null)
		{
			mj1L1jUHtF9 = new DefaultDropHandler();
		}
		return mj1L1jUHtF9;
	}

	private static bool tgIL1XbtXAW(UIElement uielement_0, UIElement uielement_1)
	{
		if (uielement_0 != null && uielement_1 != null)
		{
			if (uielement_0 == uielement_1)
			{
				return false;
			}
			DependencyObject parent = VisualTreeHelper.GetParent(uielement_0);
			while (parent != null)
			{
				if (FeN3WXFrsKvjAjlF2DsK())
				{
					switch (0)
					{
					}
				}
				if (parent is Window)
				{
					break;
				}
				if (parent != uielement_1)
				{
					parent = VisualTreeHelper.GetParent(parent);
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public new void DragOver(IDropInfo dropInfo)
	{
		if (_stepList.Count != 0)
		{
			if (dropInfo.Data is StepNode)
			{
				oShL16MKOH2().DragOver(dropInfo);
			}
			int num;
			if (dropInfo.Data is IList { Count: >0 } list && list[0] is ActionVariable)
			{
				dropInfo.Effects = System.Windows.DragDropEffects.None;
				num = 0;
				if (xC9jf6FrmyQ31mElCRE6 == null)
				{
					return;
				}
			}
			else
			{
				if (dropInfo.Data is ActionItemDragObject)
				{
					dropInfo.Effects = System.Windows.DragDropEffects.Copy;
					dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
					return;
				}
				if (dropInfo.Effects != System.Windows.DragDropEffects.None)
				{
					return;
				}
				dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
				dropInfo.Effects = System.Windows.DragDropEffects.All;
				num = 1;
				if (!FeN3WXFrsKvjAjlF2DsK())
				{
					int num2 = default(int);
					num = num2;
				}
			}
			switch (num)
			{
			case 1:
				break;
			}
		}
		else
		{
			dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
			dropInfo.Effects = System.Windows.DragDropEffects.All;
		}
	}

	public new void Drop(IDropInfo dropInfo)
	{
		int num = 3;
		_003C_003Ec__DisplayClass51_4 _003C_003Ec__DisplayClass51_2 = default(_003C_003Ec__DisplayClass51_4);
		_003C_003Ec__DisplayClass51_7 _003C_003Ec__DisplayClass51_3 = default(_003C_003Ec__DisplayClass51_7);
		object data = default(object);
		while (true)
		{
			IL_01e9:
			_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
			int num2 = 1;
			if (FeN3WXFrsKvjAjlF2DsK())
			{
				goto IL_000b;
			}
			goto IL_01ca;
			IL_01ca:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto IL_00c9;
				default:
					goto IL_019f;
				case 3:
					goto IL_01e9;
				case 4:
					if (_003C_003Ec__DisplayClass51_2.IymSUCV6Wfh != null)
					{
						base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_2.IspSU0YJqQZ);
					}
					return;
				case 5:
					return;
				}
				break;
				IL_019f:
				data = _003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.Data;
				num2 = 1;
				if (FeN3WXFrsKvjAjlF2DsK())
				{
					continue;
				}
				goto IL_019c;
			}
			goto IL_000b;
			IL_000b:
			_003C_003Ec__DisplayClass51_.c0dSFzT1MeN = this;
			_003C_003Ec__DisplayClass51_.dVdSUwm8Byl = dropInfo;
			if (_003C_003Ec__DisplayClass51_.dVdSUwm8Byl.Data is System.Windows.DataObject dataObject)
			{
				if (dataObject.GetDataPresent(typeof(XToolboxItem)))
				{
					_003C_003Ec__DisplayClass51_1 _003C_003Ec__DisplayClass51_4 = new _003C_003Ec__DisplayClass51_1();
					_003C_003Ec__DisplayClass51_4.eSpSULpUVk6 = _003C_003Ec__DisplayClass51_;
					_003C_003Ec__DisplayClass51_4.UawSUga5OZm = dataObject.GetData(typeof(XToolboxItem)) as XToolboxItem;
					base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_4.GN6SUtMPEet);
					break;
				}
				if (dataObject.GetDataPresent(typeof(FlFLPuYyXT5lnwN12if)))
				{
					_003C_003Ec__DisplayClass51_2 _003C_003Ec__DisplayClass51_5 = new _003C_003Ec__DisplayClass51_2();
					_003C_003Ec__DisplayClass51_5.QmbSU2sC72p = _003C_003Ec__DisplayClass51_;
					_003C_003Ec__DisplayClass51_5.oYYSUSqVAZE = dataObject.GetData(typeof(FlFLPuYyXT5lnwN12if)) as FlFLPuYyXT5lnwN12if;
					if (_003C_003Ec__DisplayClass51_5.oYYSUSqVAZE != null)
					{
						base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_5.biGSUvkFQP5);
					}
					break;
				}
				if (dataObject.GetDataPresent(typeof(LNofqKYUdVwgyXju86h)))
				{
					_003C_003Ec__DisplayClass51_3 _003C_003Ec__DisplayClass51_6 = new _003C_003Ec__DisplayClass51_3();
					_003C_003Ec__DisplayClass51_6.UFuSUJ4I1mx = _003C_003Ec__DisplayClass51_;
					_003C_003Ec__DisplayClass51_6.iOiSUNb1GAs = dataObject.GetData(typeof(LNofqKYUdVwgyXju86h)) as LNofqKYUdVwgyXju86h;
					if (_003C_003Ec__DisplayClass51_6.iOiSUNb1GAs != null)
					{
						base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_6.yD6SUut4fbZ);
					}
					break;
				}
				if (!dataObject.GetDataPresent("quicker-action-drag-item"))
				{
					break;
				}
				_003C_003Ec__DisplayClass51_2 = new _003C_003Ec__DisplayClass51_4();
				_003C_003Ec__DisplayClass51_2.csUSUPmlR8v = _003C_003Ec__DisplayClass51_;
				ActionItemDragObject actionItemDragObject = (ActionItemDragObject)dataObject.GetData("quicker-action-drag-item");
				_003C_003Ec__DisplayClass51_2.IymSUCV6Wfh = actionItemDragObject.Action;
				num2 = 4;
				if (xC9jf6FrmyQ31mElCRE6 != null)
				{
					goto IL_00c9;
				}
			}
			else
			{
				_003C_003Ec__DisplayClass51_5 _003C_003Ec__DisplayClass51_7 = new _003C_003Ec__DisplayClass51_5();
				_003C_003Ec__DisplayClass51_7.PTJSU8e7hyh = _003C_003Ec__DisplayClass51_;
				data = _003C_003Ec__DisplayClass51_7.PTJSU8e7hyh.dVdSUwm8Byl.Data;
				_003C_003Ec__DisplayClass51_7.lY0SUybmC28 = data as SubProgram;
				if (_003C_003Ec__DisplayClass51_7.lY0SUybmC28 != null)
				{
					base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_7.aiJSUEna3ME);
					break;
				}
				_003C_003Ec__DisplayClass51_6 _003C_003Ec__DisplayClass51_8 = new _003C_003Ec__DisplayClass51_6();
				_003C_003Ec__DisplayClass51_8.MdISUR7GDjT = _003C_003Ec__DisplayClass51_7;
				data = _003C_003Ec__DisplayClass51_8.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.Data;
				_003C_003Ec__DisplayClass51_8.BkjSU7vu75L = data as SharedSubProgramListItemDto;
				if (_003C_003Ec__DisplayClass51_8.BkjSU7vu75L != null)
				{
					base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_8.MMeSUadjsOr);
					break;
				}
				_003C_003Ec__DisplayClass51_3 = new _003C_003Ec__DisplayClass51_7();
				_003C_003Ec__DisplayClass51_3.LrtSUVTfTOb = _003C_003Ec__DisplayClass51_8;
				num2 = 0;
				if (!FeN3WXFrsKvjAjlF2DsK())
				{
					goto IL_019c;
				}
			}
			goto IL_01ca;
			IL_019c:
			num2 = num;
			goto IL_01ca;
			IL_00c9:
			_003C_003Ec__DisplayClass51_3.e2GSUceVbKZ = data as ActionVariable;
			if (_003C_003Ec__DisplayClass51_3.e2GSUceVbKZ != null)
			{
				base.Dispatcher.InvokeAsync((Func<Task>)_003C_003Ec__DisplayClass51_3.mVFSUqnQYjy);
				num2 = 5;
				if (!FeN3WXFrsKvjAjlF2DsK())
				{
					goto IL_019c;
				}
				goto IL_01ca;
			}
			if (_003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.DragInfo == null)
			{
				break;
			}
			try
			{
				UIElement visualTarget = _003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.VisualTarget;
				UIElement visualSourceItem = _003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.DragInfo.VisualSourceItem;
				if (Window.GetWindow(visualTarget) != Window.GetWindow(visualSourceItem))
				{
					_003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.Effects = System.Windows.DragDropEffects.None;
					AppHelper.ShowWarning("不能跨窗口拖放步骤。可以尝试复制粘贴方式。");
				}
				else if (tgIL1XbtXAW(visualTarget, visualSourceItem))
				{
					_003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl.Effects = System.Windows.DragDropEffects.None;
					AppHelper.ShowWarning("不能拖放到子节点。");
				}
				else
				{
					DoDropItems(_003C_003Ec__DisplayClass51_3.LrtSUVTfTOb.MdISUR7GDjT.PTJSU8e7hyh.dVdSUwm8Byl);
				}
				break;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法完成拖放：" + ex.Message);
				break;
			}
		}
	}

	public static void DoDropItems(IDropInfo dropInfo)
	{
		if (dropInfo == null || dropInfo.DragInfo == null)
		{
			return;
		}
		int num = dropInfo.UnfilteredInsertIndex;
		ItemsControl itemsControl = dropInfo.VisualTarget as ItemsControl;
		IEditableCollectionView items = default(IEditableCollectionView);
		if (itemsControl != null)
		{
			items = itemsControl.Items;
			if (items != null)
			{
				goto IL_0060;
			}
		}
		goto IL_0031;
		IL_0060:
		NewItemPlaceholderPosition newItemPlaceholderPosition = items.NewItemPlaceholderPosition;
		if (newItemPlaceholderPosition != NewItemPlaceholderPosition.AtBeginning || num != 0)
		{
			if (newItemPlaceholderPosition == NewItemPlaceholderPosition.AtEnd && num == itemsControl.Items.Count)
			{
				num--;
			}
			goto IL_0031;
		}
		goto IL_0070;
		IL_0070:
		num++;
		goto IL_0031;
		IL_024b:
		List<object> list = default(List<object>);
		if (itemsControl is System.Windows.Controls.TabControl || (itemsControl != null && GongSolutions.Wpf.DragDrop.DragDrop.GetSelectDroppedItems(itemsControl)))
		{
			DefaultDropHandler.SelectDroppedItems(dropInfo, list);
		}
		return;
		IL_0031:
		IList list2 = dropInfo.TargetCollection.TryGetList();
		if (xC9jf6FrmyQ31mElCRE6 == null)
		{
			switch (0)
			{
			case 3:
				break;
			case 2:
				goto IL_0070;
			default:
				goto IL_0090;
			case 1:
				goto IL_024b;
			}
			goto IL_0060;
		}
		goto IL_0090;
		IL_0090:
		List<object> list3 = DefaultDropHandler.ExtractData(dropInfo.Data).OfType<object>().ToList();
		IList list4 = dropInfo.DragInfo.SourceCollection.TryGetList();
		List<object> list5 = new List<object>(list3.Count);
		foreach (object item in list4)
		{
			if (list3.Contains(item))
			{
				list5.Add(item);
			}
		}
		if (!DefaultDropHandler.ShouldCopyData(dropInfo) && list4 != null)
		{
			int num4 = default(int);
			foreach (object item2 in list3)
			{
				int num2 = list4.IndexOf(item2);
				if (num2 == -1)
				{
					continue;
				}
				list4.RemoveAt(num2);
				if (list2 == null || !object.Equals(list4, list2))
				{
					continue;
				}
				int num3 = 0;
				if (!FeN3WXFrsKvjAjlF2DsK())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				if (num2 < num)
				{
					num--;
				}
			}
		}
		if (list2 == null)
		{
			return;
		}
		list = new List<object>();
		bool flag = dropInfo.Effects.HasFlag(System.Windows.DragDropEffects.Copy) || dropInfo.Effects.HasFlag(System.Windows.DragDropEffects.Link);
		int num6 = default(int);
		foreach (object item3 in list5)
		{
			object obj = item3;
			if (flag && item3 is ICloneable cloneable)
			{
				obj = cloneable.Clone();
			}
			list.Add(obj);
			int num5 = 0;
			if (!FeN3WXFrsKvjAjlF2DsK())
			{
				num5 = num6;
			}
			switch (num5)
			{
			}
			list2.Insert(num++, obj);
		}
		goto IL_024b;
	}

	public void CollapseAll()
	{
	}

	private void wclL1mlwyRH(bool bool_1)
	{
		foreach (StepNode item in TheListBox.SelectedItems.Cast<StepNode>())
		{
			item.ExpandOrCollapse(bool_1);
		}
	}

	void GongSolutions.Wpf.DragDrop.IDropTarget.DragEnter(IDropInfo dropInfo)
	{
	}

	void GongSolutions.Wpf.DragDrop.IDropTarget.DragLeave(IDropInfo dropInfo)
	{
	}

	static StepListControl()
	{
		pFYL1QYJiaD = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void r0sL1KmGka7(object sender, RoutedEventArgs e)
	{
		Paste(_stepList.Count);
	}

	[CompilerGenerated]
	private int sJnL1xMECKr(StepNode stepNode_0)
	{
		return _stepList.IndexOf(stepNode_0);
	}

	[CompilerGenerated]
	private void vXJL1r3jc5b()
	{
		ewjL1kyhI95(TheListBox);
	}

	[CompilerGenerated]
	private int E9DL1pBGxtN(StepNode stepNode_0)
	{
		return _stepList.IndexOf(stepNode_0);
	}

	internal static bool FeN3WXFrsKvjAjlF2DsK()
	{
		return xC9jf6FrmyQ31mElCRE6 == null;
	}
}
