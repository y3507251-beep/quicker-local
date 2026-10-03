using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using CodeCompletionServer.Entities;
using CommunityToolkit.Mvvm.Messaging;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using k7aPL5fDWhslvV5ur2A;
using log4net;
using lpE7rGAgh7wj22W4qWU;
using mhan9VA4t36nUXE7ZEi;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;
using Quicker.View.UI;
using t7wokwYFlDgjUncgQNA;
using Waf.DotNetPad.Presentation.Controls;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.View.Controls;

public class CodeEditor : TextEditor
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<string, string, int> owvSlciJ3Fs;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec IMcSlhNXDVg;

		public static Func<ActionVariable, string> Dn6SlecWj1I;

		public static Func<ActionVariable, string> abgSlYFIs8n;

		public static Func<ActionVariable, string> qvHSlIuYuJH;

		private static _003C_003Ec yNHYTCycTBFcqxEuOhJL;

		static _003C_003Ec()
		{
			IMcSlhNXDVg = new _003C_003Ec();
		}

		internal string q3ESlV9ljmw(ActionVariable x)
		{
			return x.Key;
		}

		internal string j13SlZCW9Ya(ActionVariable x)
		{
			return x.Key;
		}

		internal string EIiSl95Lqdv(ActionVariable x)
		{
			return VarTypeInfo.GetCsTypeName(x.Type);
		}

		internal static void h8q2Q7ycCyKqrRmQMh3x()
		{
		}

		internal static bool MZyxdJycm1U5GScB1RWv()
		{
			return yNHYTCycTBFcqxEuOhJL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public CancellationToken R04Slk1e8tw;

		public CodeEditor DAoSlGWsSH3;

		internal static _003C_003Ec__DisplayClass46_0 qfcSNyyc7hKELOoeElui;

		internal void dONSlW4Ushs(object sender, EventArgs e)
		{
			DAoSlGWsSH3.HeTLKHCLApu = null;
		}

		internal static bool YMLjvQyc4dKVwFijoVxZ()
		{
			return qfcSNyyc7hKELOoeElui == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct GZe0TykpiPL2Wbf5s8c : IAsyncStateMachine
		{
			public int WxB2Z59oiEf;

			public AsyncTaskMethodBuilder<CompletionResponse> hng2ZDpkfWW;

			public _003C_003Ec__DisplayClass46_1 Mxt2ZdjT9mI;

			private TaskAwaiter<CompletionResponse> bsA2ZoSVHAn;

			private static object XXPnSryq6ftkjiReJiVd;

			private void MoveNext()
			{
				int num = WxB2Z59oiEf;
				_003C_003Ec__DisplayClass46_1 _003C_003Ec__DisplayClass46_ = Mxt2ZdjT9mI;
				CompletionResponse result;
				try
				{
					TaskAwaiter<CompletionResponse> awaiter;
					if (num != 0)
					{
						int num2 = 0;
						if (!veSaqVyqt7hE8ldisZAK())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = N3fyKuAyxGkZEcSSS2n.RYkl6t8Icv(_003C_003Ec__DisplayClass46_.h24SlHewTlW, _003C_003Ec__DisplayClass46_.uKcSl1aItj9.R04Slk1e8tw).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							WxB2Z59oiEf = 0;
							bsA2ZoSVHAn = awaiter;
							hng2ZDpkfWW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = bsA2ZoSVHAn;
						bsA2ZoSVHAn = default(TaskAwaiter<CompletionResponse>);
						num = -1;
						WxB2Z59oiEf = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					WxB2Z59oiEf = -2;
					hng2ZDpkfWW.SetException(exception);
					return;
				}
				WxB2Z59oiEf = -2;
				hng2ZDpkfWW.SetResult(result);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				hng2ZDpkfWW.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool veSaqVyqt7hE8ldisZAK()
			{
				return XXPnSryq6ftkjiReJiVd == null;
			}
		}

		public CompletionRequest h24SlHewTlW;

		public _003C_003Ec__DisplayClass46_0 uKcSl1aItj9;

		private static _003C_003Ec__DisplayClass46_1 C2ofRpycH0U3Jc70dow5;

		[AsyncStateMachine(typeof(GZe0TykpiPL2Wbf5s8c))]
		internal Task<CompletionResponse> XhISlsVAbHE()
		{
			GZe0TykpiPL2Wbf5s8c stateMachine = default(GZe0TykpiPL2Wbf5s8c);
			stateMachine.hng2ZDpkfWW = AsyncTaskMethodBuilder<CompletionResponse>.Create();
			stateMachine.Mxt2ZdjT9mI = this;
			stateMachine.WxB2Z59oiEf = -1;
			stateMachine.hng2ZDpkfWW.Start(ref stateMachine);
			return stateMachine.hng2ZDpkfWW.Task;
		}

		internal static bool iMVmVuyczZTkFWysbBiq()
		{
			return C2ofRpycH0U3Jc70dow5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_2
	{
		public CompletionItem Q1JSl6FYXLW;

		public _003C_003Ec__DisplayClass46_1 KrqSlX1MGQU;

		internal static _003C_003Ec__DisplayClass46_2 Bi7TCDyWQXEicqSkbXrK;

		internal Task<ItemDescriptionResult> qk0Slb1Wofu()
		{
			return KrqSlX1MGQU.uKcSl1aItj9.DAoSlGWsSH3.nVWLK76xKT6(Q1JSl6FYXLW.Text);
		}

		internal static bool jW1vPDyWFTgra5Q2rJXI()
		{
			return Bi7TCDyWQXEicqSkbXrK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct XALdyvkaJ2vsRHkWfWN : IAsyncStateMachine
		{
			public int SE52ZTApYHV;

			public AsyncTaskMethodBuilder<ItemDescriptionResult> u2s2ZM1l4xy;

			public _003C_003Ec__DisplayClass47_0 Md32ZAM4BV1;

			private TaskAwaiter<ItemDescriptionResult> pj02ZOhtYbm;

			private static object Lbr3LHyqwe1bksoyUfeg;

			private void MoveNext()
			{
				int num = SE52ZTApYHV;
				_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = Md32ZAM4BV1;
				ItemDescriptionResult result;
				try
				{
					TaskAwaiter<ItemDescriptionResult> awaiter;
					if (num != 0)
					{
						awaiter = N3fyKuAyxGkZEcSSS2n.iltlXtrqWw(_003C_003Ec__DisplayClass47_.FY9SlKrjD4V, _003C_003Ec__DisplayClass47_.KWySlxt3O6c).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							SE52ZTApYHV = 0;
							pj02ZOhtYbm = awaiter;
							int num2 = 0;
							if (Lbr3LHyqwe1bksoyUfeg != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							u2s2ZM1l4xy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = pj02ZOhtYbm;
						pj02ZOhtYbm = default(TaskAwaiter<ItemDescriptionResult>);
						num = -1;
						SE52ZTApYHV = -1;
					}
					result = awaiter.GetResult();
				}
				catch (Exception exception)
				{
					SE52ZTApYHV = -2;
					u2s2ZM1l4xy.SetException(exception);
					return;
				}
				SE52ZTApYHV = -2;
				u2s2ZM1l4xy.SetResult(result);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				u2s2ZM1l4xy.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Fua6byyqTa8XyJJENAZf()
			{
				return Lbr3LHyqwe1bksoyUfeg == null;
			}
		}

		public ItemDescriptionRequest FY9SlKrjD4V;

		public CancellationToken KWySlxt3O6c;

		private static _003C_003Ec__DisplayClass47_0 A9M11CyWWQ6hjMZXUTgj;

		[AsyncStateMachine(typeof(XALdyvkaJ2vsRHkWfWN))]
		internal Task<ItemDescriptionResult> y5ZSlmZSuCn()
		{
			XALdyvkaJ2vsRHkWfWN stateMachine = default(XALdyvkaJ2vsRHkWfWN);
			stateMachine.u2s2ZM1l4xy = AsyncTaskMethodBuilder<ItemDescriptionResult>.Create();
			stateMachine.Md32ZAM4BV1 = this;
			stateMachine.SE52ZTApYHV = -1;
			stateMachine.u2s2ZM1l4xy.Start(ref stateMachine);
			return stateMachine.u2s2ZM1l4xy.Task;
		}

		internal static bool Gct0KYyWyIZSNE0npehT()
		{
			return A9M11CyWWQ6hjMZXUTgj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass61_0
	{
		public CodeEditor dWgSlpKkBQa;

		public CompletionResponse YEgSlBMt6cm;

		internal static _003C_003Ec__DisplayClass61_0 KqJGGtyWXs5oshI9uK9C;

		internal void y7ASlrajI9E()
		{
			if (YEgSlBMt6cm != null && YEgSlBMt6cm.ErrorItems.HasData())
			{
				dWgSlpKkBQa.QynLKeyBRHm(YEgSlBMt6cm.ErrorItems);
			}
			else
			{
				dWgSlpKkBQa.KXMLK1BfSuE.Clear();
			}
		}

		internal static bool BR0Wy1yW2mdBEkIPUY9g()
		{
			return KqJGGtyWXs5oshI9uK9C == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetDescriptionAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ItemDescriptionResult> _003C_003Et__builder;

		public CodeEditor _003C_003E4__this;

		public string completionItemText;

		private TaskAwaiter<ItemDescriptionResult> _003C_003Eu__1;

		private static object nfll2CyWncm5HFrx8jDV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CodeEditor codeEditor = _003C_003E4__this;
			ItemDescriptionResult result;
			try
			{
				TaskAwaiter<ItemDescriptionResult> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
					codeEditor.mL9LKXxQrLO?.Cancel();
					codeEditor.mL9LKXxQrLO = new CancellationTokenSource();
					_003C_003Ec__DisplayClass47_.KWySlxt3O6c = codeEditor.mL9LKXxQrLO.Token;
					_003C_003Ec__DisplayClass47_.FY9SlKrjD4V = new ItemDescriptionRequest
					{
						SessionId = codeEditor.dLaLK6Y2Nuj,
						RequestId = Guid.NewGuid(),
						Text = completionItemText
					};
					awaiter = Task.Run((Func<Task<ItemDescriptionResult>>)_003C_003Ec__DisplayClass47_.y5ZSlmZSuCn).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!fArQ0fyWe2dInZ5vkIpd())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ItemDescriptionResult>);
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

		internal static bool fArQ0fyWe2dInZ5vkIpd()
		{
			return nfll2CyWncm5HFrx8jDV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowCompletionAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CodeEditor _003C_003E4__this;

		public char? triggerChar;

		public TriggerMode triggerMode;

		private _003C_003Ec__DisplayClass46_1 _003C_003E8__1;

		private int _003Cposition_003E5__2;

		private ConfiguredTaskAwaitable<CompletionResponse>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object GaeWcMyW3ub7F9hjGLmt;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CodeEditor codeEditor = _003C_003E4__this;
			try
			{
				_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = default(_003C_003Ec__DisplayClass46_0);
				if (num != 0)
				{
					_003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0
					{
						DAoSlGWsSH3 = _003C_003E4__this
					};
					CancellationTokenSource mL9LKXxQrLO = codeEditor.mL9LKXxQrLO;
					if (mL9LKXxQrLO == null)
					{
						int num2 = 0;
						if (GaeWcMyW3ub7F9hjGLmt != null)
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
						mL9LKXxQrLO.Cancel();
					}
					codeEditor.mL9LKXxQrLO = new CancellationTokenSource();
					_003C_003Ec__DisplayClass46_.R04Slk1e8tw = codeEditor.mL9LKXxQrLO.Token;
					if (!triggerChar.HasValue && codeEditor.Text.Length > 1)
					{
						triggerChar = codeEditor.Document.GetCharAt(codeEditor.CaretOffset - 1);
					}
				}
				try
				{
        int? num6 = default;
        CompletionResponse result = default;
					ConfiguredTaskAwaitable<CompletionResponse>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<CompletionResponse>.ConfiguredTaskAwaiter);
					int num4;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<CompletionResponse>.ConfiguredTaskAwaiter);
						num4 = 0;
						if (!Ce4biTyWEDx0txK2Py8r())
						{
							int num5 = default(int);
							num4 = num5;
						}
						goto IL_01a2;
					}
					num6 = default(int?);
					if (codeEditor.ifOLKsbHgQx == null)
					{
						if (triggerChar.HasValue)
						{
							num6 = triggerChar;
							if (num6 != 46)
							{
								num6 = triggerChar;
								if (num6 != 40)
								{
									num6 = triggerChar;
									int num5 = 7;
									goto IL_01d0;
								}
							}
						}
						goto IL_02da;
					}
					goto end_IL_00a4;
					IL_0255:
					result = awaiter.GetResult();
					if (result != null && result.ResultType != TriggerMode.Text)
					{
						goto IL_0271;
					}
					goto end_IL_00a4;
					IL_04a8:
					if (result.ResultType == TriggerMode.SignatureHelp && result.SignatureHelpResult != null)
					{
						aSdmBLAU9LVrSYKhpt4 aSdmBLAU9LVrSYKhpt = new aSdmBLAU9LVrSYKhpt4(result.SignatureHelpResult)
						{
							SelectedIndex = result.SignatureHelpResult.SelectedItemIndex.GetValueOrDefault()
						};
						if (codeEditor.HeTLKHCLApu != null && codeEditor.HeTLKHCLApu.IsVisible)
						{
							codeEditor.HeTLKHCLApu.Provider = aSdmBLAU9LVrSYKhpt;
						}
						else
						{
							codeEditor.HeTLKHCLApu = new OverloadInsightWindow(codeEditor.TextArea)
							{
								Provider = aSdmBLAU9LVrSYKhpt
							};
							codeEditor.HeTLKHCLApu.Closed += _003C_003E8__1.uKcSl1aItj9.dONSlW4Ushs;
							codeEditor.HeTLKHCLApu.Show();
						}
						aSdmBLAU9LVrSYKhpt.Refresh();
					}
					else
					{
						if (result.ErrorItems.HasData())
						{
							codeEditor.QynLKeyBRHm(result.ErrorItems);
						}
						_003C_003E8__1 = null;
					}
					goto end_IL_00a4;
					IL_02cc:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0255;
					IL_02da:
					_003C_003E8__1 = new _003C_003Ec__DisplayClass46_1();
					_003C_003E8__1.uKcSl1aItj9 = _003C_003Ec__DisplayClass46_;
					_003Cposition_003E5__2 = codeEditor.CaretOffset;
					_003C_003E8__1.h24SlHewTlW = codeEditor.sRRLKyKho1E();
					_003C_003E8__1.h24SlHewTlW.TriggerChar = triggerChar;
					_003C_003E8__1.h24SlHewTlW.TriggerMode = triggerMode;
					awaiter = Task.Run((Func<Task<CompletionResponse>>)_003C_003E8__1.XhISlsVAbHE, _003C_003E8__1.uKcSl1aItj9.R04Slk1e8tw).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0255;
					IL_01d0:
					if (num6 == 44)
					{
						goto IL_02da;
					}
					num6 = triggerChar;
					if (num6 == 91)
					{
						goto IL_02da;
					}
					if (s8yLKZLXvEn(triggerChar.Value))
					{
						num4 = 1;
						if (GaeWcMyW3ub7F9hjGLmt == null)
						{
							goto IL_01a2;
						}
						goto IL_02da;
					}
					goto end_IL_00a4;
					IL_01a2:
					(int, string) tuple = default((int, string));
					while (true)
					{
						switch (num4)
						{
						case 7:
							break;
						case 6:
							goto IL_0271;
						case 5:
							if (result.CompletionResult.CompletionItems.HasData())
							{
								goto case 3;
							}
							goto IL_04a8;
						case 3:
							codeEditor.CloseInsightWindow();
							num4 = 8;
							if (Ce4biTyWEDx0txK2Py8r())
							{
								continue;
							}
							goto end_IL_00a4;
						default:
							goto IL_02cc;
						case 1:
							goto IL_02da;
						case 8:
						{
							tuple = codeEditor.GEULKV1sKcR(_003Cposition_003E5__2);
							codeEditor.mWZLKClv49n(false);
							IEnumerator<CompletionItem> enumerator = result.CompletionResult.CompletionItems.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									_003C_003Ec__DisplayClass46_2 _003C_003Ec__DisplayClass46_2 = new _003C_003Ec__DisplayClass46_2
									{
										KrqSlX1MGQU = _003C_003E8__1,
										Q1JSl6FYXLW = enumerator.Current
									};
									codeEditor.ifOLKsbHgQx.CompletionList.CompletionData.Add(new CodeCompletionData(_003C_003Ec__DisplayClass46_2.Q1JSl6FYXLW.Text, _003C_003Ec__DisplayClass46_2.Q1JSl6FYXLW.Tags, _003C_003Ec__DisplayClass46_2.qk0Slb1Wofu));
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
							if (!triggerChar.HasValue || s8yLKZLXvEn(triggerChar.Value))
							{
								goto case 2;
							}
							goto IL_049d;
						}
						case 2:
							codeEditor.ifOLKsbHgQx.StartOffset = tuple.Item1;
							codeEditor.ifOLKsbHgQx.CompletionList.SelectItem(tuple.Item2);
							goto IL_049d;
						case 4:
							goto end_IL_00a4;
							IL_049d:
							codeEditor.ifOLKsbHgQx.Show();
							goto IL_04a8;
						}
						break;
					}
					goto IL_01d0;
					IL_0271:
					if (result.ResultType == TriggerMode.Completion && result.CompletionResult != null)
					{
						num4 = 5;
						if (GaeWcMyW3ub7F9hjGLmt == null)
						{
							goto IL_01a2;
						}
						goto IL_02da;
					}
					goto IL_04a8;
					end_IL_00a4:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (Exception ex2)
				{
					JbCLKGmgkvO.Warn(ex2.Message, ex2);
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

		internal static bool Ce4biTyWEDx0txK2Py8r()
		{
			return GaeWcMyW3ub7F9hjGLmt == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTextAreaOnTextEntered_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCompositionEventArgs e;

		public CodeEditor _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object gyK5fTyWB4hhcLDnSiA6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CodeEditor codeEditor = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0246;
				}
				int num2;
				if (e.Text == "{")
				{
					codeEditor.mWZLKClv49n(true);
					num2 = 0;
					if (!IUhrL5yWvNP2TS9kg1qe())
					{
						goto IL_00b8;
					}
					goto IL_0137;
				}
				if (codeEditor.Text.StartsWith("$="))
				{
					goto IL_00cb;
				}
				goto end_IL_0010;
				IL_00cb:
				if (AppState.HHxtaMaoqJr().EnableExpressionCompletion)
				{
					if (!(e.Text == ")") && !(e.Text == ";"))
					{
						awaiter = codeEditor.xubLKa34Edf(e.Text.FirstOrDefault()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0246;
					}
					codeEditor.CloseInsightWindow();
					CompletionWindow ifOLKsbHgQx = codeEditor.ifOLKsbHgQx;
					if (ifOLKsbHgQx != null)
					{
						ifOLKsbHgQx.Close();
						num2 = 1;
						if (gyK5fTyWB4hhcLDnSiA6 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00b8;
					}
				}
				goto end_IL_0010;
				IL_00b8:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_0137;
				case 1:
					goto end_IL_0010;
				}
				goto IL_00cb;
				IL_0137:
				codeEditor.ifOLKsbHgQx.CustomGetMatchQualityFunc = _003C_003EO.owvSlciJ3Fs ?? (_003C_003EO.owvSlciJ3Fs = ka2whMfuvIXVT20tX6H.udRLiqMmXfF);
				IList<ICompletionData> completionData = codeEditor.ifOLKsbHgQx.CompletionList.CompletionData;
				if (codeEditor.ActionVariables != null)
				{
					IEnumerator<ActionVariable> enumerator = codeEditor.ActionVariables.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ActionVariable current = enumerator.Current;
							completionData.Add(new VariableCompletionData(current.Key, current.Desc, current.Type, current.Group));
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
				if (codeEditor.SupportClipTextParam)
				{
					completionData.Add(new VariableCompletionData("[cliptext]", "*剪贴板文本*", VarType.Text, null));
				}
				if (codeEditor.SupportQuickerInParam)
				{
					completionData.Add(new VariableCompletionData("quicker_in_param", "*动作参数*", VarType.Text, null));
				}
				codeEditor.ifOLKsbHgQx.Show();
				goto end_IL_0010;
				IL_0246:
				awaiter.GetResult();
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

		internal static bool IUhrL5yWvNP2TS9kg1qe()
		{
			return gyK5fTyWB4hhcLDnSiA6 == null;
		}
	}

	private static readonly ILog JbCLKGmgkvO;

	private CompletionWindow ifOLKsbHgQx;

	private OverloadInsightWindow? HeTLKHCLApu;

	private readonly ErrorTextMarkerService KXMLK1BfSuE;

	[CompilerGenerated]
	private IEnumerable<ActionVariable> Sl5LKbKGc1K;

	private Guid dLaLK6Y2Nuj = Guid.NewGuid();

	private CancellationTokenSource mL9LKXxQrLO;

	[CompilerGenerated]
	private bool LEJLKmOpslq = true;

	private SearchReplacePanel? o5YLKKhltam;

	[CompilerGenerated]
	private bool vU2LKxQ2c9v = true;

	[CompilerGenerated]
	private bool iTQLKrs6CHu = true;

	[CompilerGenerated]
	private static Brush P6uLKpSa4M5;

	private DebounceTimer xWnLKBYbiZY = new DebounceTimer();

	private CancellationTokenSource rGsLKQcWesU = new CancellationTokenSource();

	private IHighlightingDefinition lPhLKjq3Uk3;

	internal static CodeEditor H4GsIXFuyACNudZsod56;

	public IEnumerable<ActionVariable> ActionVariables
	{
		[CompilerGenerated]
		get
		{
			return Sl5LKbKGc1K;
		}
		[CompilerGenerated]
		set
		{
			Sl5LKbKGc1K = value;
		}
	}

	public bool AutoChangeHighlighting
	{
		[CompilerGenerated]
		get
		{
			return LEJLKmOpslq;
		}
		[CompilerGenerated]
		set
		{
			LEJLKmOpslq = value;
		}
	}

	public IHighlightingDefinition DefaultHighlightType
	{
		get
		{
			return lPhLKjq3Uk3;
		}
		set
		{
			lPhLKjq3Uk3 = value;
			UpdateEditorHighlighting();
		}
	}

	public bool SupportQuickerInParam
	{
		[CompilerGenerated]
		get
		{
			return vU2LKxQ2c9v;
		}
		[CompilerGenerated]
		set
		{
			vU2LKxQ2c9v = value;
		}
	}

	public bool SupportClipTextParam
	{
		[CompilerGenerated]
		get
		{
			return iTQLKrs6CHu;
		}
		[CompilerGenerated]
		set
		{
			iTQLKrs6CHu = value;
		}
	}

	private static Brush NonPrintableCharacterBrush
	{
		[CompilerGenerated]
		set
		{
			P6uLKpSa4M5 = value;
		}
	}

	public bool IsCompletionWindowOpen => ifOLKsbHgQx != null;

	public bool IsSearchPanelOpen
	{
		get
		{
			SearchReplacePanel searchReplacePanel = o5YLKKhltam;
			if (searchReplacePanel != null)
			{
				return !searchReplacePanel.IsClosed;
			}
			return false;
		}
	}

	public bool IsInsightWindowOpen => HeTLKHCLApu?.IsVisible ?? false;

	public CodeEditor()
	{
		mL9LKXxQrLO = new CancellationTokenSource();
		base.Options.ShowSpaces = true;
		base.Options.ShowTabs = true;
		base.Options.ShowBoxForControlCharacters = true;
		base.TextArea.TextEntered += Oq8LKEAwr2Z;
		base.TextArea.TextEntering += cT1LK05SJtJ;
		base.KeyDown += EnDLKJ6w4tg;
		base.TextChanged += fF7LKRhSXJT;
		base.IsVisibleChanged += BWhLKcxGLJo;
		KXMLK1BfSuE = new ErrorTextMarkerService(this);
		base.Loaded += cc2LKN2C1vS;
		base.Unloaded += OsBLKutqfnW;
		this.uLyLiY4NBYN();
	}

	private void OsBLKutqfnW(object sender, RoutedEventArgs e)
	{
		base.Unloaded -= OsBLKutqfnW;
		if (ifOLKsbHgQx != null)
		{
			ifOLKsbHgQx.Close();
			ifOLKsbHgQx = null;
		}
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
		y6xLKqQlX4W();
	}

	private void cc2LKN2C1vS(object sender, RoutedEventArgs e)
	{
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, rmiLKYHdO8u);
	}

	private void EnDLKJ6w4tg(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.System)
		{
			switch (e.SystemKey)
			{
			case Key.Down:
				this.BDsLiWpgApB();
				break;
			case Key.Up:
				this.GNBLiIGOd2f();
				break;
			}
		}
		if (e.Key != Key.F1)
		{
			return;
		}
		if (H4GsIXFuyACNudZsod56 != null)
		{
			switch (0)
			{
			}
		}
		ToggleInputMode();
	}

	public void CloseSearchPanel()
	{
		o5YLKKhltam?.Close();
	}

	private void cT1LK05SJtJ(object sender, TextCompositionEventArgs e)
	{
		if (base.CaretOffset == 1 && (e.Text == "=" || e.Text == "￥") && base.Text[0] == '￥')
		{
			base.Document.Replace(0, 1, "$");
			if (e.Text == "￥")
			{
				base.Document.Insert(1, "$");
				e.Handled = true;
			}
		}
		if (string.IsNullOrEmpty(e.Text))
		{
			return;
		}
		int num = 0;
		if (H4GsIXFuyACNudZsod56 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (ifOLKsbHgQx != null && !s8yLKZLXvEn(e.Text[0]))
		{
			if (e.Text[0].IsEither('\t', '\n'))
			{
				ifOLKsbHgQx.CompletionList.RequestInsertion(e);
			}
			else
			{
				ifOLKsbHgQx.Close();
			}
		}
	}

	public void ToggleInputMode()
	{
		int caretOffset = base.CaretOffset;
		int length = base.Text.Length;
		try
		{
			if (base.Text.StartsWith("$="))
			{
				base.Text = "$$" + base.Text.Substring(2);
			}
			else if (base.Text.StartsWith("$$"))
			{
				base.Text = base.Text.Substring(2);
			}
			else
			{
				base.Text = "$=" + base.Text;
			}
			base.CaretOffset = Math.Max(0, caretOffset + (base.Text.Length - length));
		}
		catch (Exception ex)
		{
			JbCLKGmgkvO.Warn("切换输入模式出错：" + ex.Message, ex);
			AppHelper.ShowWarning("操作失败，请重试。错误：" + ex.Message);
		}
	}

	private void mWZLKClv49n(bool bool_3)
	{
		while (ifOLKsbHgQx != null)
		{
			if (H4GsIXFuyACNudZsod56 != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			try
			{
				ifOLKsbHgQx.Close();
				ifOLKsbHgQx = null;
			}
			catch (Exception)
			{
			}
			break;
		}
		ifOLKsbHgQx = new CompletionWindow(base.TextArea)
		{
			WindowStyle = WindowStyle.None,
			AllowsTransparency = true
		};
		ifOLKsbHgQx.Closed += ePQLKI4HXaD;
		if (bool_3)
		{
			ifOLKsbHgQx.ResizeMode = ResizeMode.CanResizeWithGrip;
			if (dDh7g7Xw7JyQPUTbYwJ.CompletionWindowWidth.HasValue)
			{
				ifOLKsbHgQx.Width = dDh7g7Xw7JyQPUTbYwJ.CompletionWindowWidth.Value;
			}
			ifOLKsbHgQx.SizeChanged += MYcLKPsT6OI;
		}
	}

	private void MYcLKPsT6OI(object sender, SizeChangedEventArgs e)
	{
		if (ifOLKsbHgQx != null && e.WidthChanged)
		{
			double actualWidth = ifOLKsbHgQx.ActualWidth;
			if (actualWidth > 100.0 && actualWidth < 600.0)
			{
				dDh7g7Xw7JyQPUTbYwJ.CompletionWindowWidth = actualWidth;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CTextAreaOnTextEntered_003Ed__43))]
	private void Oq8LKEAwr2Z(object sender, TextCompositionEventArgs e)
	{
		_003CTextAreaOnTextEntered_003Ed__43 stateMachine = default(_003CTextAreaOnTextEntered_003Ed__43);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private CompletionRequest sRRLKyKho1E()
	{
		CompletionRequest obj = new CompletionRequest
		{
			SessionId = dLaLK6Y2Nuj,
			RequestId = Guid.NewGuid(),
			OriginCode = (base.Text ?? ""),
			Position = base.CaretOffset
		};
		IEnumerable<ActionVariable> actionVariables = ActionVariables;
		object obj2;
		if (actionVariables == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = actionVariables.Distinct(_003C_003Ec.Dn6SlecWj1I ?? (_003C_003Ec.Dn6SlecWj1I = _003C_003Ec.IMcSlhNXDVg.q3ESlV9ljmw)).ToDictionary(_003C_003Ec.abgSlYFIs8n ?? (_003C_003Ec.abgSlYFIs8n = _003C_003Ec.IMcSlhNXDVg.j13SlZCW9Ya), _003C_003Ec.qvHSlIuYuJH ?? (_003C_003Ec.qvHSlIuYuJH = _003C_003Ec.IMcSlhNXDVg.EIiSl95Lqdv));
			if (obj2 != null)
			{
				goto IL_00bb;
			}
		}
		obj2 = new Dictionary<string, string>();
		goto IL_00bb;
		IL_00bb:
		obj.Variables = (IDictionary<string, string>)obj2;
		obj.GetErrors = false;
		CompletionRequest completionRequest = obj;
		if (SupportClipTextParam)
		{
			completionRequest.OriginCode = completionRequest.OriginCode.Replace("{[cliptext]}", "{_cliptext_}");
			completionRequest.Variables["_cliptext_"] = "string";
		}
		if (SupportQuickerInParam)
		{
			completionRequest.Variables["quicker_in_param"] = "string";
		}
		return completionRequest;
	}

	internal void NvPLK8JcZm3()
	{
		o5YLKKhltam = SearchReplacePanel.Install(this);
		o5YLKKhltam.Localization = SearchPanelCnLocalization.Instance;
	}

	[AsyncStateMachine(typeof(_003CShowCompletionAsync_003Ed__46))]
	private Task xubLKa34Edf(char? nullable_0, TriggerMode triggerMode_0 = TriggerMode.Text)
	{
		_003CShowCompletionAsync_003Ed__46 stateMachine = default(_003CShowCompletionAsync_003Ed__46);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.triggerChar = nullable_0;
		stateMachine.triggerMode = triggerMode_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetDescriptionAsync_003Ed__47))]
	private Task<ItemDescriptionResult> nVWLK76xKT6(string string_0)
	{
		_003CGetDescriptionAsync_003Ed__47 stateMachine = default(_003CGetDescriptionAsync_003Ed__47);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ItemDescriptionResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.completionItemText = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void fF7LKRhSXJT(object sender, EventArgs e)
	{
		UpdateEditorHighlighting();
		if (AppState.HHxtaMaoqJr().EnableExpressionValidation && base.IsLoaded)
		{
			t22LK9ANULK();
		}
	}

	public void UpdateEditorHighlighting()
	{
		if (!AutoChangeHighlighting)
		{
			return;
		}
		if (base.Text.StartsWith("$$"))
		{
			int num = 0;
			if (H4GsIXFuyACNudZsod56 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (base.SyntaxHighlighting != UGNZKrYVGqgfWZbLcQj.QuickerInterpolation)
			{
				base.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.QuickerInterpolation;
			}
		}
		else if (base.Text.StartsWith("$="))
		{
			if (base.SyntaxHighlighting != UGNZKrYVGqgfWZbLcQj.QuickerExpression)
			{
				base.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.QuickerExpression;
			}
		}
		else if (base.SyntaxHighlighting != DefaultHighlightType)
		{
			base.SyntaxHighlighting = DefaultHighlightType;
		}
	}

	private void y6xLKqQlX4W()
	{
		if (mL9LKXxQrLO != null)
		{
			try
			{
				mL9LKXxQrLO.Cancel();
				mL9LKXxQrLO.Dispose();
				mL9LKXxQrLO = null;
			}
			catch (Exception)
			{
			}
		}
		if (rGsLKQcWesU != null)
		{
			try
			{
				rGsLKQcWesU.Cancel();
				rGsLKQcWesU.Dispose();
				rGsLKQcWesU = null;
			}
			catch (Exception)
			{
			}
		}
	}

	private void BWhLKcxGLJo(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (!base.IsVisible)
		{
			mL9LKXxQrLO?.Cancel();
			rGsLKQcWesU?.Cancel();
		}
		else
		{
			UpdateEditorHighlighting();
		}
		CloseInsightWindow();
	}

	private (int wordStart, string text) GEULKV1sKcR(int int_0)
	{
		int nextCaretPosition = TextUtilities.GetNextCaretPosition(base.TextArea.Document, int_0, LogicalDirection.Backward, CaretPositioningMode.WordStart);
		string text = base.TextArea.Document.GetText(nextCaretPosition, int_0 - nextCaretPosition);
		return (wordStart: nextCaretPosition, text: text);
	}

	private static bool s8yLKZLXvEn(char char_0)
	{
		return TextUtilities.GetCharacterClass(char_0) == CharacterClass.IdentifierPart;
	}

	public void CloseInsightWindow()
	{
		if (HeTLKHCLApu != null)
		{
			HeTLKHCLApu.Close();
			HeTLKHCLApu = null;
		}
	}

	private void t22LK9ANULK()
	{
		if (base.Text.StartsWith("$="))
		{
			CompletionRequest completionRequest = sRRLKyKho1E();
			completionRequest.GetErrors = true;
			xWnLKBYbiZY.Debounce(2000, iJ6LKhkTyyh, completionRequest);
		}
		else
		{
			xWnLKBYbiZY.Clear();
			KXMLK1BfSuE.Clear();
		}
	}

	private void iJ6LKhkTyyh(object object_0)
	{
		_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
		_003C_003Ec__DisplayClass61_.dWgSlpKkBQa = this;
		try
		{
			CompletionRequest completionRequest_ = (CompletionRequest)object_0;
			rGsLKQcWesU?.Cancel();
			rGsLKQcWesU = new CancellationTokenSource();
			CancellationToken token = rGsLKQcWesU.Token;
			_003C_003Ec__DisplayClass61_.YEgSlBMt6cm = N3fyKuAyxGkZEcSSS2n.RYkl6t8Icv(completionRequest_, token).GetAwaiter().GetResult();
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass61_.y7ASlrajI9E);
		}
		catch (Exception ex)
		{
			JbCLKGmgkvO.Warn("检查语法错误出错！" + ex.Message);
		}
	}

	private void QynLKeyBRHm(IList<ErrorListItem> ilist_0)
	{
		KXMLK1BfSuE.Clear();
		foreach (ErrorListItem item in ilist_0)
		{
			if (item.EndLine >= 0)
			{
				try
				{
					int offset = base.Document.GetOffset(new TextLocation(item.StartLine + 1, item.StartColumn + 1));
					int offset2 = base.Document.GetOffset(new TextLocation(item.EndLine + 1, item.EndColumn + 1));
					KXMLK1BfSuE.Create(offset, offset2 - offset, item.Description);
				}
				catch (Exception ex)
				{
					JbCLKGmgkvO.Warn(ex.Message, ex);
				}
			}
		}
	}

	static CodeEditor()
	{
		JbCLKGmgkvO = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		P6uLKpSa4M5 = new SolidColorBrush(Color.FromArgb(80, 128, 128, 128));
	}

	[CompilerGenerated]
	private void rmiLKYHdO8u(object object_0, ThemeChangedMessage themeChangedMessage_0)
	{
		if (base.SyntaxHighlighting != null)
		{
			base.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(base.SyntaxHighlighting.Name);
		}
	}

	[CompilerGenerated]
	private void ePQLKI4HXaD(object sender, EventArgs e)
	{
		ifOLKsbHgQx = null;
	}

	internal static bool TUFsPpFupTknIAARkIHv()
	{
		return H4GsIXFuyACNudZsod56 == null;
	}
}
