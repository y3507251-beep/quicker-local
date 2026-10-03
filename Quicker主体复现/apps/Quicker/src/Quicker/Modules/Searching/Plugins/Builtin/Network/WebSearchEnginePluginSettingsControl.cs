using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GongSolutions.Wpf.DragDrop;
using Newtonsoft.Json;
using qlCEFf26DxbmIE2RAgM;
using Quicker.Common.Vm;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.X;

namespace Quicker.Modules.Searching.Plugins.Builtin.Network;

public class WebSearchEnginePluginSettingsControl : UserControl, IComponentConnector, IStyleConnector, IPluginSettingsControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ePr1AVHCSVFD3RUqidq : IAsyncStateMachine
		{
			public int a9027eP1MNN;

			public AsyncVoidMethodBuilder q6e27YhnMYC;

			public _003C_003Ec__DisplayClass11_0 zZw27IbWuAU;

			private TaskAwaiter<bool> CGf27WEhGRK;

			private static object TR8LQlyuFi7bfUypmrh6;

			private void MoveNext()
			{
				int num = a9027eP1MNN;
				_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = zZw27IbWuAU;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass11_.NCwv6VurAkk.andtEMIBG8D(_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (!HfEiAYyucPi8ceagDGS0())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							a9027eP1MNN = 0;
							CGf27WEhGRK = awaiter;
							q6e27YhnMYC.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = CGf27WEhGRK;
						CGf27WEhGRK = default(TaskAwaiter<bool>);
						num = -1;
						a9027eP1MNN = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					a9027eP1MNN = -2;
					q6e27YhnMYC.SetException(exception);
					return;
				}
				a9027eP1MNN = -2;
				q6e27YhnMYC.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				q6e27YhnMYC.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool HfEiAYyucPi8ceagDGS0()
			{
				return TR8LQlyuFi7bfUypmrh6 == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct zXp5WvHrayRM8NSdXHE : IAsyncStateMachine
		{
			public int XOs27kyS4s9;

			public AsyncVoidMethodBuilder vq727Gk1xf8;

			public _003C_003Ec__DisplayClass11_0 aRL27s09yFZ;

			internal static object zKFFWIyuyT7pvbnjyoJP;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = aRL27s09yFZ;
				try
				{
					_003C_003Ec__DisplayClass11_.NCwv6VurAkk.EnFtE3SSfsq.Remove(_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a);
				}
				catch (Exception exception)
				{
					XOs27kyS4s9 = -2;
					vq727Gk1xf8.SetException(exception);
					return;
				}
				XOs27kyS4s9 = -2;
				vq727Gk1xf8.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				vq727Gk1xf8.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool H80VFXyupcsaoOL9EWeH()
			{
				return zKFFWIyuyT7pvbnjyoJP == null;
			}
		}

		public WebSearchEnginePluginSettingsControl NCwv6VurAkk;

		public WebSearchEngine RQ9v6Zenw8a;

		internal static _003C_003Ec__DisplayClass11_0 iAuBIQcx0kcVnFlLm7Fi;

		[AsyncStateMachine(typeof(ePr1AVHCSVFD3RUqidq))]
		internal void KjCv6R7mUp2(object sender, RoutedEventArgs e)
		{
			ePr1AVHCSVFD3RUqidq stateMachine = default(ePr1AVHCSVFD3RUqidq);
			stateMachine.q6e27YhnMYC = AsyncVoidMethodBuilder.Create();
			stateMachine.zZw27IbWuAU = this;
			stateMachine.a9027eP1MNN = -1;
			stateMachine.q6e27YhnMYC.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(zXp5WvHrayRM8NSdXHE))]
		internal void JFQv6qJLeCF(object sender, RoutedEventArgs e)
		{
			zXp5WvHrayRM8NSdXHE stateMachine = default(zXp5WvHrayRM8NSdXHE);
			stateMachine.vq727Gk1xf8 = AsyncVoidMethodBuilder.Create();
			stateMachine.aRL27s09yFZ = this;
			stateMachine.XOs27kyS4s9 = -1;
			stateMachine.vq727Gk1xf8.Start(ref stateMachine);
		}

		internal bool kJLv6cnwQ28(WebSearchEngine x)
		{
			if (x.Name == RQ9v6Zenw8a.Name)
			{
				return x.QueryUrl == RQ9v6Zenw8a.QueryUrl;
			}
			return false;
		}

		internal static void FA7EhhcxBpMjqqYW9qbb()
		{
		}

		internal static bool VoqbHQcx1p5hEwaYULZu()
		{
			return iAuBIQcx0kcVnFlLm7Fi == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAddFromWeb_OnClick_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebSearchEnginePluginSettingsControl _003C_003E4__this;

		private SelectSearchEngineWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		internal static object JFD87acxvfAgWbwJ0vFH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebSearchEnginePluginSettingsControl webSearchEnginePluginSettingsControl = _003C_003E4__this;
			try
			{
        bool? result = default;
				TaskAwaiter<bool> awaiter;
				TaskAwaiter<bool?> awaiter2;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_01b9;
					}
					_003Cdlg_003E5__2 = new SelectSearchEngineWindow
					{
						Owner = Window.GetWindow(webSearchEnginePluginSettingsControl)
					};
					awaiter2 = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num2 = 1;
						if (JFD87acxvfAgWbwJ0vFH == null)
						{
							goto IL_00da;
						}
						goto IL_00e7;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter2.GetResult();
				num2 = 0;
				if (!g3LBFEcxd1TXKGICx5Pc())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00da;
				IL_01b9:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_00e7:
				if (result == true)
				{
					SearchEngineDto selectedSearchEngine = _003Cdlg_003E5__2.SelectedSearchEngine;
					WebSearchEngine webSearchEngine_ = new WebSearchEngine
					{
						SearchEngineId = selectedSearchEngine.Id,
						EngineRevision = selectedSearchEngine.Revision,
						Name = selectedSearchEngine.Title,
						QueryUrl = selectedSearchEngine.QueryUrl,
						Icon = selectedSearchEngine.Icon,
						TriggerWords = selectedSearchEngine.TriggerWords.Or("trigger"),
						CompletionUrl = selectedSearchEngine.CompletionUrl,
						CompletionXPath = selectedSearchEngine.CompletionXPath
					};
					awaiter = webSearchEnginePluginSettingsControl.andtEMIBG8D(webSearchEngine_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01b9;
				}
				goto end_IL_0010;
				IL_00da:
				switch (num2)
				{
				case 1:
					return;
				}
				goto IL_00e7;
				end_IL_0010:;
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

		internal static bool g3LBFEcxd1TXKGICx5Pc()
		{
			return JFD87acxvfAgWbwJ0vFH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAdd_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebSearchEnginePluginSettingsControl _003C_003E4__this;

		private EditSearchEngineWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object nVULghcxNldaS54odXVc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebSearchEnginePluginSettingsControl webSearchEnginePluginSettingsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					_003Cdlg_003E5__2 = new EditSearchEngineWindow(null)
					{
						Owner = Window.GetWindow(webSearchEnginePluginSettingsControl)
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (nVULghcxNldaS54odXVc == null)
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
				if (awaiter.GetResult() == true)
				{
					webSearchEnginePluginSettingsControl.EnFtE3SSfsq.Add(_003Cdlg_003E5__2.Engine);
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

		internal static bool syY5Rfcx9R54CmfV0NGC()
		{
			return nVULghcxNldaS54odXVc == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEdit_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public WebSearchEnginePluginSettingsControl _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object J6ipyYcxuhLDm5Iy6Ipn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebSearchEnginePluginSettingsControl webSearchEnginePluginSettingsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					int num2 = 0;
					if (!LbAJILcxoI3TnTkV6dUr())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a9;
				}
				if ((sender as Button)?.DataContext is WebSearchEngine webSearchEngine_)
				{
					awaiter = webSearchEnginePluginSettingsControl.andtEMIBG8D(webSearchEngine_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a9;
				}
				goto end_IL_0010;
				IL_00a9:
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

		static _003CBtnEdit_OnClick_003Ed__6()
		{
		}

		internal static bool LbAJILcxoI3TnTkV6dUr()
		{
			return J6ipyYcxuhLDm5Iy6Ipn == null;
		}

		internal static void TlOicqcxb6fbJJhPSd88()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItem_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public WebSearchEngine item;

		public WebSearchEnginePluginSettingsControl _003C_003E4__this;

		private EditSearchEngineWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object rBOemUcxqplG1dcJfWAD;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebSearchEnginePluginSettingsControl webSearchEnginePluginSettingsControl = _003C_003E4__this;
			bool result = default(bool);
			try
			{
				TaskAwaiter<bool?> awaiter;
				int num2;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					_003Cdlg_003E5__2 = new EditSearchEngineWindow(item)
					{
						Owner = Window.GetWindow(webSearchEnginePluginSettingsControl)
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (!Lc1rG5cxiR2XIHO8lyPj())
						{
							goto IL_00f6;
						}
						goto IL_00fa;
					}
				}
				if (awaiter.GetResult() == true)
				{
					if (webSearchEnginePluginSettingsControl.EnFtE3SSfsq.Contains(item))
					{
						webSearchEnginePluginSettingsControl.EnFtE3SSfsq.Replace(item, _003Cdlg_003E5__2.Engine);
					}
					else
					{
						webSearchEnginePluginSettingsControl.EnFtE3SSfsq.Add(_003Cdlg_003E5__2.Engine);
					}
					result = true;
					num2 = 1;
					if (rBOemUcxqplG1dcJfWAD != null)
					{
						goto IL_00f6;
					}
					goto IL_00fa;
				}
				result = false;
				goto end_IL_0010;
				IL_00f6:
				int num3 = default(int);
				num2 = num3;
				goto IL_00fa;
				IL_00fa:
				switch (num2)
				{
				default:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				case 1:
					break;
				}
				end_IL_0010:;
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

		internal static bool Lc1rG5cxiR2XIHO8lyPj()
		{
			return rBOemUcxqplG1dcJfWAD == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnItem_MouseDoubleClick_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public WebSearchEnginePluginSettingsControl _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object dhW2hOcxZGLi6MXCt3g3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebSearchEnginePluginSettingsControl webSearchEnginePluginSettingsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a9;
				}
				if ((sender as ListViewItem)?.DataContext is WebSearchEngine webSearchEngine_)
				{
					awaiter = webSearchEnginePluginSettingsControl.andtEMIBG8D(webSearchEngine_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (dhW2hOcxZGLi6MXCt3g3 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						return;
					}
					goto IL_00a9;
				}
				goto end_IL_0010;
				IL_00a9:
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

		static _003COnItem_MouseDoubleClick_003Ed__10()
		{
		}

		internal static bool VVmDvvcx5v7C4bWovC8J()
		{
			return dhW2hOcxZGLi6MXCt3g3 == null;
		}

		internal static void Ll3uHZcx8CAiZFRyJ2bk()
		{
		}
	}

	private SmartCollection<WebSearchEngine> EnFtE3SSfsq = new SmartCollection<WebSearchEngine>();

	internal Button BtnAdd;

	internal Button BtnAddFromWeb;

	internal ListView LvEngines;

	private bool vBWtEfTAiAk;

	internal static WebSearchEnginePluginSettingsControl EFeUJDQD5gdtn4FlS3YI;

	public WebSearchEnginePluginSettingsControl()
	{
		InitializeComponent();
		LvEngines.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		if (settings != null && settings.ContainsKey("SEARCH_ENGINES"))
		{
			string value = settings["SEARCH_ENGINES"];
			EnFtE3SSfsq.Reset(JsonConvert.DeserializeObject<IList<WebSearchEngine>>(value));
		}
		else
		{
			EnFtE3SSfsq.Reset(dZSAja2f6LA1pH5RUmY.DcwtJdPNyVc());
		}
		LvEngines.ItemsSource = EnFtE3SSfsq;
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["SEARCH_ENGINES"] = JsonConvert.SerializeObject(EnFtE3SSfsq);
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[AsyncStateMachine(typeof(_003CEditItem_003Ed__5))]
	private Task<bool> andtEMIBG8D(WebSearchEngine webSearchEngine_0)
	{
		_003CEditItem_003Ed__5 stateMachine = default(_003CEditItem_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = webSearchEngine_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnEdit_OnClick_003Ed__6))]
	private void yFotEAh3y1R(object sender, RoutedEventArgs e)
	{
		_003CBtnEdit_OnClick_003Ed__6 stateMachine = default(_003CBtnEdit_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void jUwtEOyKasQ(object sender, RoutedEventArgs e)
	{
		if ((sender as Button)?.DataContext is WebSearchEngine item)
		{
			EnFtE3SSfsq.Remove(item);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnAdd_OnClick_003Ed__8))]
	private void VCOtEFvQTWH(object sender, RoutedEventArgs e)
	{
		_003CBtnAdd_OnClick_003Ed__8 stateMachine = default(_003CBtnAdd_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnAddFromWeb_OnClick_003Ed__9))]
	private void W72tEUyxAou(object sender, RoutedEventArgs e)
	{
		_003CBtnAddFromWeb_OnClick_003Ed__9 stateMachine = default(_003CBtnAddFromWeb_OnClick_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnItem_MouseDoubleClick_003Ed__10))]
	private void hjQtEldjD0C(object sender, MouseButtonEventArgs e)
	{
		_003COnItem_MouseDoubleClick_003Ed__10 stateMachine = default(_003COnItem_MouseDoubleClick_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void LvHtEihJpQi(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.NCwv6VurAkk = this;
		_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a = (sender as ListViewItem)?.DataContext as WebSearchEngine;
		if (_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a != null)
		{
			ContextMenu contextMenu = new ContextMenu();
			contextMenu.Items.Clear();
			AppHelper.AddMenuItem(contextMenu.Items, "编辑", "", "fa:Light_Edit", _003C_003Ec__DisplayClass11_.KjCv6R7mUp2);
			AppHelper.AddMenuItem(contextMenu.Items, "删除", "", "fa:Light_Times:#FF0000", _003C_003Ec__DisplayClass11_.JFQv6qJLeCF);
			if (!_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a.SearchEngineId.HasValue || !(_003C_003Ec__DisplayClass11_.RQ9v6Zenw8a.SearchEngineId != Guid.Empty))
			{
				dZSAja2f6LA1pH5RUmY.DcwtJdPNyVc().Any(_003C_003Ec__DisplayClass11_.kJLv6cnwQ28);
			}
			contextMenu.IsOpen = true;
		}
		e.Handled = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!vBWtEfTAiAk)
		{
			vBWtEfTAiAk = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/network/websearchenginepluginsettingscontrol.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			vBWtEfTAiAk = true;
			break;
		case 1:
			BtnAdd = (Button)target;
			BtnAdd.Click += VCOtEFvQTWH;
			break;
		case 2:
			BtnAddFromWeb = (Button)target;
			BtnAddFromWeb.Click += W72tEUyxAou;
			break;
		case 3:
			LvEngines = (ListView)target;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			default:
			{
				int num2 = 0;
				if (!fML93tQDYFxqhKCAJR0l())
				{
					num2 = num;
				}
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				break;
			}
			case 4:
				((Button)target).Click += yFotEAh3y1R;
				return;
			case 5:
				((Button)target).Click += jUwtEOyKasQ;
				return;
			case 6:
			{
				EventSetter eventSetter = new EventSetter();
				eventSetter.Event = Control.MouseDoubleClickEvent;
				eventSetter.Handler = new MouseButtonEventHandler(hjQtEldjD0C);
				((Style)target).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseRightButtonUpEvent;
				eventSetter.Handler = new MouseButtonEventHandler(LvHtEihJpQi);
				((Style)target).Setters.Add(eventSetter);
				return;
			}
			}
		}
	}

	internal static void MUHKR5QDRX6yPEnGQaKy()
	{
	}

	internal static bool fML93tQDYFxqhKCAJR0l()
	{
		return EFeUJDQD5gdtn4FlS3YI == null;
	}
}
