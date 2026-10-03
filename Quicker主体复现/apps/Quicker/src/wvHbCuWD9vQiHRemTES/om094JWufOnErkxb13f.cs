using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Modules.TextTools;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.UI;

namespace wvHbCuWD9vQiHRemTES;

internal class om094JWufOnErkxb13f : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct RRfMLIHnMkCyeRZtoH8 : IAsyncStateMachine
		{
			public int vR82aGs3kkp;

			public AsyncVoidMethodBuilder E5J2asWsgPh;

			public _003C_003Ec__DisplayClass1_0 L7Y2aHr4B6r;

			private OperationEditorWindow QpL2a1MEZy0;

			private TaskAwaiter<bool?> pjH2abmig3D;

			private static object nVxci0yLeajObt3g69aa;

			private void MoveNext()
			{
				int num = vR82aGs3kkp;
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = L7Y2aHr4B6r;
				try
				{
					int num2;
					if (num != 0)
					{
						QpL2a1MEZy0 = new OperationEditorWindow(_003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.OperationItem_OnlyData, _003C_003Ec__DisplayClass1_.VwlvGQF8gQU);
						num2 = 0;
						if (nVxci0yLeajObt3g69aa != null)
						{
							goto IL_0047;
						}
						goto IL_00a0;
					}
					TaskAwaiter<bool?> awaiter = pjH2abmig3D;
					pjH2abmig3D = default(TaskAwaiter<bool?>);
					num = -1;
					vR82aGs3kkp = -1;
					goto IL_0138;
					IL_00d9:
					awaiter = QpL2a1MEZy0.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						vR82aGs3kkp = 0;
						pjH2abmig3D = awaiter;
						E5J2asWsgPh.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0138;
					IL_0138:
					if (awaiter.GetResult() == true)
					{
						string indentTextData = QpL2a1MEZy0.GetIndentTextData();
						_003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.ProcessSelectedTextFunc(indentTextData, true);
					}
					else
					{
						_003C_003Ec__DisplayClass1_.PydvGB98gs8.CancelSelection("");
					}
					goto end_IL_0010;
					IL_0047:
					if (_003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.ParentWindow.zmGvuiv40H0() && _003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.ParentWindow != AppState.HS2taepcAbc() && _003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.ParentWindow.IsVisible)
					{
						num2 = 1;
						if (nVxci0yLeajObt3g69aa != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00a0;
					}
					QpL2a1MEZy0.WindowStartupLocation = WindowStartupLocation.CenterScreen;
					goto IL_00d9;
					IL_00a0:
					switch (num2)
					{
					case 1:
						goto IL_00bd;
					}
					goto IL_0047;
					IL_00bd:
					QpL2a1MEZy0.Owner = _003C_003Ec__DisplayClass1_.PydvGB98gs8.Context.ParentWindow;
					goto IL_00d9;
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					vR82aGs3kkp = -2;
					QpL2a1MEZy0 = null;
					E5J2asWsgPh.SetException(exception);
					return;
				}
				vR82aGs3kkp = -2;
				QpL2a1MEZy0 = null;
				E5J2asWsgPh.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				E5J2asWsgPh.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static RRfMLIHnMkCyeRZtoH8()
			{
			}

			internal static bool jYWsK2yLjjn2UNwDqj8J()
			{
				return nVxci0yLeajObt3g69aa == null;
			}

			internal static void AACmL1yL3YMePqZJoXwe()
			{
			}
		}

		public om094JWufOnErkxb13f PydvGB98gs8;

		public IList<CommonOperationItem> VwlvGQF8gQU;

		internal static _003C_003Ec__DisplayClass1_0 JnaYx1c8rxV6pP6ogyh6;

		[AsyncStateMachine(typeof(RRfMLIHnMkCyeRZtoH8))]
		internal void U0CvGpfDQmg()
		{
			RRfMLIHnMkCyeRZtoH8 stateMachine = default(RRfMLIHnMkCyeRZtoH8);
			stateMachine.E5J2asWsgPh = AsyncVoidMethodBuilder.Create();
			stateMachine.L7Y2aHr4B6r = this;
			stateMachine.vR82aGs3kkp = -1;
			stateMachine.E5J2asWsgPh.Start(ref stateMachine);
		}

		internal static bool fJg3J9c8N2PHYEjoF49K()
		{
			return JnaYx1c8rxV6pP6ogyh6 == null;
		}
	}

	private static om094JWufOnErkxb13f Fn4R4HQpunDSI8rirBIG;

	public om094JWufOnErkxb13f(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseUp(object sender)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.PydvGB98gs8 = this;
		base.OnMouseUp(sender);
		string allText = base.Context.TextControl.GetAllText();
		if (!allText.StartsWith("$=") && !allText.StartsWith("$$"))
		{
			_003C_003Ec__DisplayClass1_.VwlvGQF8gQU = new List<CommonOperationItem>();
			try
			{
				if (!allText.IsNullOrEmpty())
				{
					string text = allText.Trim();
					if (text.StartsWith("[") && text.EndsWith("]"))
					{
						_003C_003Ec__DisplayClass1_.VwlvGQF8gQU = JsonConvert.DeserializeObject<IList<CommonOperationItem>>(text);
					}
					else
					{
						_003C_003Ec__DisplayClass1_.VwlvGQF8gQU = CommonOperationItem.ParseLinesWithSubItems(text, true);
					}
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message ?? "");
				return;
			}
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass1_.U0CvGpfDQmg);
		}
		else
		{
			AppHelper.ShowWarning("不支持编辑使用插值或表达式的内容。");
		}
	}

	internal static bool Bha0xWQpoDEWR6f32gfo()
	{
		return Fn4R4HQpunDSI8rirBIG == null;
	}
}
