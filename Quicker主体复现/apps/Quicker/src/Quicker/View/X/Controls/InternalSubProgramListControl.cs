using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.View.X.Controls;

public class InternalSubProgramListControl : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public InternalSubProgramListControl L8fSUTcieMO;

		public SubProgram zxKSUMyHTTo;

		private static _003C_003Ec__DisplayClass16_0 IQ2q1byFgQdixK71eQlN;

		internal void V9ZSUo1KJoQ()
		{
			L8fSUTcieMO.qCPLXJ1gVg4(zxKSUMyHTTo);
		}

		internal static bool oRliwhyFP8PrWih5ArqL()
		{
			return IQ2q1byFgQdixK71eQlN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public SubProgram yUiSUOolJcL;

		internal static _003C_003Ec__DisplayClass22_0 OL1y47yFUEkX2aF7fSIP;

		internal bool rP1SUAnSKaj(SubProgram x)
		{
			return string.Equals(x.Name, yUiSUOolJcL.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool rdipMOyFxMZNRSM5XRoL()
		{
			return OL1y47yFUEkX2aF7fSIP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public SubProgram oLmSUUFZVCd;

		internal static _003C_003Ec__DisplayClass23_0 PyaChbyF6faUkvSdFZg8;

		internal bool P6TSUFWKFsh(SubProgram x)
		{
			return string.Equals(x.Name, oLmSUUFZVCd.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool eNU8FyyFtODmVJGjSYWr()
		{
			return PyaChbyF6faUkvSdFZg8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public SubProgram SOkSUiIT2JN;

		private static _003C_003Ec__DisplayClass24_0 mJxc6OyFTslMD6572LDk;

		internal bool KIISUltCk7p(SubProgram x)
		{
			return string.Equals(x.Name, SOkSUiIT2JN.Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool sI4RsMyFmgjpigi24u3L()
		{
			return mJxc6OyFTslMD6572LDk == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDownloadSubProgram_OnClick_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InternalSubProgramListControl _003C_003E4__this;

		private TaskAwaiter<ApiResult<SharedActionDto>> _003C_003Eu__1;

		internal static object ry6pYeyF70718BYFAYFv;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InternalSubProgramListControl internalSubProgramListControl = _003C_003E4__this;
			try
			{
        string text = default;
				if (num == 0)
				{
					goto IL_0040;
				}
				text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
				if (!string.IsNullOrEmpty(text))
				{
					goto IL_0040;
				}
				AppHelper.ShowWarning("请先复制子程序网址后再点击下载。");
				AppHelper.TryOpenUrlOrFile("https://getquicker.net/Share/SubPrograms");
				goto end_IL_0010;
				IL_0040:
				try
				{
					TaskAwaiter<ApiResult<SharedActionDto>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.zWGtbRbRnCk(text).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<SharedActionDto>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<SharedActionDto> result = awaiter.GetResult();
					_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_;
					int num2;
					if (result.IsSuccess)
					{
						if (!string.IsNullOrEmpty(result.Message)) AppHelper.ShowWarning(result.Message);
						_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0
						{
							oLmSUUFZVCd = JsonConvert.DeserializeObject<SubProgram>(result.Data.Data)
						};
						num2 = 1;
						if (ry6pYeyF70718BYFAYFv != null)
						{
							goto IL_00df;
						}
						goto IL_012a;
					}
					goto IL_0236;
					IL_012a:
					switch (num2)
					{
					case 1:
						break;
					default:
						goto end_IL_0040;
					case 2:
						goto IL_0236;
					}
					goto IL_00df;
					IL_00df:
					if (_003C_003Ec__DisplayClass23_.oLmSUUFZVCd == null || (!_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Steps.HasData() && !_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Variables.HasData()))
					{
						AppHelper.ShowWarning("子程序内容为空！");
						num2 = 0;
						if (!xqqfp0yF4198ObVv09Zv())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_012a;
					}
					_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Name = result.Data.Title;
					_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Description = result.Data.Description;
					_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.TemplateId = result.Data.Id.ToString();
					_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.TemplateRevision = result.Data.Revision;
					_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.CreateTimeUtc = DateTime.UtcNow;
					if (internalSubProgramListControl.SubPrograms.Any(_003C_003Ec__DisplayClass23_.P6TSUFWKFsh))
					{
						AppHelper.ShowWarning("子程序 " + _003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Name + " 已存在，不能导入或创建重名的子程序。");
					}
					else
					{
						_003C_003Ec__DisplayClass23_.oLmSUUFZVCd.Id = Guid.NewGuid().ToString();
						internalSubProgramListControl.SubPrograms.Add(_003C_003Ec__DisplayClass23_.oLmSUUFZVCd);
					}
					goto end_IL_0040;
					IL_0236:
					AppHelper.ShowWarning("下载子程序失败。" + result.Message);
					end_IL_0040:;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("下载子程序失败。" + exception.GetMessageWithInner());
					AppHelper.TryOpenUrlOrFile("https://getquicker.net/Share/SubPrograms");
				}
				end_IL_0010:;
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

		internal static bool xqqfp0yF4198ObVv09Zv()
		{
			return ry6pYeyF70718BYFAYFv == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuCreateCopy_OnClick_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InternalSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DCDpewycV1TvAqKxI7gN;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InternalSubProgramListControl internalSubProgramListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c4;
				}
				int num2 = 0;
				if (!uQGhX3ycQRegAP9sMiQ4())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (internalSubProgramListControl.IsReadonly)
				{
					AppHelper.ShowWarning("只读动作不支持此功能。");
				}
				else if (internalSubProgramListControl.LvSubprograms.SelectedItem is SubProgram subProgram)
				{
					awaiter = internalSubProgramListControl.reZLX0hwkKt().DuplicateInternalSubProgramAsync(subProgram).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c4;
				}
				goto end_IL_0010;
				IL_00c4:
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

		internal static bool uQGhX3ycQRegAP9sMiQ4()
		{
			return DCDpewycV1TvAqKxI7gN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuPasteSp_OnClick_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InternalSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object RIfjPeycWPp0p2MWbHCy;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InternalSubProgramListControl internalSubProgramListControl = _003C_003E4__this;
			try
			{
				if (num != 0 && internalSubProgramListControl.IsReadonly)
				{
					AppHelper.ShowWarning("只读动作不支持此功能。");
				}
				else
				{
					try
					{
						TaskAwaiter awaiter;
						if (num == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_00d9;
						}
						if (hvlKifycy7MPLqU2re7m())
						{
							switch (0)
							{
							}
						}
						if (ClipboardHelper.ContainsData("quicker-subprogram-item"))
						{
							string value = ClipboardHelper.GetData("quicker-subprogram-item") as string;
							if (!string.IsNullOrEmpty(value))
							{
								SubProgram sp = JsonConvert.DeserializeObject<SubProgram>(value);
								awaiter = internalSubProgramListControl.reZLX0hwkKt().PasteSubProgramAsync(sp).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00d9;
							}
						}
						else
						{
							AppHelper.ShowWarning("剪贴板中没有子程序。");
						}
						goto end_IL_002a;
						IL_00d9:
						awaiter.GetResult();
						end_IL_002a:;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning(ex.Message);
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

		internal static bool hvlKifycy7MPLqU2re7m()
		{
			return RIfjPeycWPp0p2MWbHCy == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuRename_OnClick_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InternalSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object umXTBFyc2oOUk6tNRQZc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InternalSubProgramListControl internalSubProgramListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c4;
				}
				if (internalSubProgramListControl.IsReadonly)
				{
					int num2 = 0;
					if (!gfFSXkycAk60oP0gHjqD())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						AppHelper.ShowWarning("只读动作不支持此功能。");
						break;
					}
				}
				else if (internalSubProgramListControl.LvSubprograms.SelectedItem is SubProgram subProgram)
				{
					awaiter = internalSubProgramListControl.reZLX0hwkKt().RenameInternalSubProgramAsync(subProgram).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c4;
				}
				goto end_IL_0010;
				IL_00c4:
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

		internal static bool gfFSXkycAk60oP0gHjqD()
		{
			return umXTBFyc2oOUk6tNRQZc == null;
		}
	}

	private static readonly ILog ts1LXX0pWoU;

	[CompilerGenerated]
	private SmartCollection<SubProgram> QIaLXmsCplo;

	[CompilerGenerated]
	private XAction xNwLXKToTtN;

	[CompilerGenerated]
	private bool kOULXx6EgxF;

	private ListCollectionView s0DLXrfr9By;

	internal TextBox TxtFilter;

	internal Button BtnClearFilter;

	internal ListBox LvSubprograms;

	internal ContextMenu ListContextMenu;

	internal MenuItem MenuPasteSp;

	internal Button BtnDownloadSubProgram;

	internal Button BtnImportSubProgram;

	internal Button BtnClearSubPrograms;

	private bool XvWLXprBlYU;

	private static InternalSubProgramListControl YX4C26F9aPR3XKL0p1Co;

	public SmartCollection<SubProgram> SubPrograms
	{
		[CompilerGenerated]
		get
		{
			return QIaLXmsCplo;
		}
		[CompilerGenerated]
		private set
		{
			QIaLXmsCplo = value;
		}
	}

	public XAction Action
	{
		[CompilerGenerated]
		get
		{
			return xNwLXKToTtN;
		}
		[CompilerGenerated]
		private set
		{
			xNwLXKToTtN = value;
		}
	}

	public bool IsReadonly
	{
		[CompilerGenerated]
		get
		{
			return kOULXx6EgxF;
		}
		[CompilerGenerated]
		set
		{
			kOULXx6EgxF = value;
		}
	}

	public void SetData(SmartCollection<SubProgram> subPrograms, XAction action)
	{
		SubPrograms = subPrograms;
		Action = action;
		mhMLXZQMcP9();
	}

	public InternalSubProgramListControl()
	{
		InitializeComponent();
	}

	private void MWnLXNFtdtl(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.L8fSUTcieMO = this;
		if (e.ClickCount >= 2)
		{
			_003C_003Ec__DisplayClass16_.zxKSUMyHTTo = (sender as FrameworkElement).Tag as SubProgram;
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass16_.V9ZSUo1KJoQ);
		}
	}

	private void qCPLXJ1gVg4(SubProgram subProgram_0)
	{
		reZLX0hwkKt().EditSubProgram(subProgram_0);
	}

	private ActionDesignerWindow reZLX0hwkKt()
	{
		return Window.GetWindow(this) as ActionDesignerWindow;
	}

	private void CXfLXCjAnM9(object sender, RoutedEventArgs e)
	{
		if (IsReadonly)
		{
			AppHelper.ShowWarning("只读动作不支持此功能。");
			return;
		}
		SubProgram internalSubProgram = LvSubprograms.SelectedItem as SubProgram;
		reZLX0hwkKt().ConvertToGlobalSubProgram(internalSubProgram);
	}

	private void f14LXPhYwpy(object sender, RoutedEventArgs e)
	{
		if (IsReadonly)
		{
			AppHelper.ShowWarning("只读动作不支持此功能。");
			return;
		}
		SubProgram subProgram = LvSubprograms.SelectedItem as SubProgram;
		reZLX0hwkKt().DeleteInternalSubProgram(subProgram);
	}

	private void X3GLXEa9Giv(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			ClipboardHelper.SetText(subProgram.Name);
		}
	}

	private void nioLXyxXr78(object sender, RoutedEventArgs e)
	{
		if (IsReadonly)
		{
			AppHelper.ShowWarning("只读动作不支持此功能。");
			return;
		}
		SubProgramEditWindow subProgramEditWindow = new SubProgramEditWindow(null, SubPrograms)
		{
			Owner = reZLX0hwkKt()
		};
		if (subProgramEditWindow.ShowDialog() != true)
		{
			return;
		}
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		if (YX4C26F9aPR3XKL0p1Co == null)
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass22_.yUiSUOolJcL = new SubProgram
		{
			Id = Guid.NewGuid().ToString(),
			Name = subProgramEditWindow.SubProgramName,
			Description = subProgramEditWindow.SubProgramDesc,
			CreateTimeUtc = DateTime.UtcNow
		};
		if (SubPrograms.Any(_003C_003Ec__DisplayClass22_.rP1SUAnSKaj))
		{
			AppHelper.ShowWarning("子程序 " + _003C_003Ec__DisplayClass22_.yUiSUOolJcL.Name + " 已存在，不能导入或创建重名的子程序。");
			return;
		}
		SubPrograms.Add(_003C_003Ec__DisplayClass22_.yUiSUOolJcL);
		qCPLXJ1gVg4(_003C_003Ec__DisplayClass22_.yUiSUOolJcL);
	}

	[AsyncStateMachine(typeof(_003CBtnDownloadSubProgram_OnClick_003Ed__23))]
	private void xIdLX8cBpi3(object sender, RoutedEventArgs e)
	{
		_003CBtnDownloadSubProgram_OnClick_003Ed__23 stateMachine = default(_003CBtnDownloadSubProgram_OnClick_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void GbjLXa7hhmf(object sender, RoutedEventArgs e)
	{
		{
			(bool, string) tuple = AppHelper.ShowSelectFileDialog("*.qka|*.qka", ".qka", "", "", "导入动作定义");
			if (!tuple.Item1)
			{
				return;
			}
			try
			{
				_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				string value = File.ReadAllText(tuple.Item2);
				int num = 0;
				if (YX4C26F9aPR3XKL0p1Co != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				_003C_003Ec__DisplayClass24_.SOkSUiIT2JN = JsonConvert.DeserializeObject<SubProgram>(value);
				if (_003C_003Ec__DisplayClass24_.SOkSUiIT2JN != null && (_003C_003Ec__DisplayClass24_.SOkSUiIT2JN.Steps.HasData() || _003C_003Ec__DisplayClass24_.SOkSUiIT2JN.Variables.HasData()))
				{
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass24_.SOkSUiIT2JN.Name))
					{
						AppHelper.ShowWarning("子程序名为空。可能导入了动作文件。");
						return;
					}
					if (SubPrograms.Any(_003C_003Ec__DisplayClass24_.KIISUltCk7p))
					{
						AppHelper.ShowWarning("子程序 " + _003C_003Ec__DisplayClass24_.SOkSUiIT2JN.Name + " 已存在，不能导入或创建重名的子程序。");
						return;
					}
					_003C_003Ec__DisplayClass24_.SOkSUiIT2JN.Id = Guid.NewGuid().ToString();
					SubPrograms.Add(_003C_003Ec__DisplayClass24_.SOkSUiIT2JN);
				}
				else
				{
					AppHelper.ShowWarning("文件内容为空！");
				}
				return;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("导入子程序定义出错：" + ex.Message);
				return;
			}
		}

	}

	private void jhaLX7bDpHi(object sender, RoutedEventArgs e)
	{
		reZLX0hwkKt().ClearNotUsedInternalSubPrograms();
	}

	private void D1rLXRLMXX9(object sender, RoutedEventArgs e)
	{
		SubProgram subProgram_ = (sender as FrameworkElement).Tag as SubProgram;
		qCPLXJ1gVg4(subProgram_);
	}

	private void rGYLXqFE50f(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			reZLX0hwkKt().HighlightText(subProgram.Name);
		}
	}

	private void JxBLXcJs94e(object sender, RoutedEventArgs e)
	{
		if (IsReadonly)
		{
			AppHelper.ShowWarning("只读动作不支持此功能。");
		}
		else if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			AppState.lWutartRfUY().ShareSubProgram(subProgram, Window.GetWindow(this), false);
		}
	}

	private void fxNLXVlb6KM(object sender, TextChangedEventArgs e)
	{
		HsHLX9aagMb();
	}

	private void mhMLXZQMcP9()
	{
		s0DLXrfr9By = new ListCollectionView(SubPrograms);
		s0DLXrfr9By.CustomSort = new SortBySubProgramName();
		s0DLXrfr9By.Filter = Filter;
		LvSubprograms.ItemsSource = s0DLXrfr9By;
		LvSubprograms.SelectedItem = null;
	}

	private bool Filter(object obj)
	{
		if (string.IsNullOrEmpty(TxtFilter.Text))
		{
			return true;
		}
		string text = TxtFilter.Text;
		if (!(obj is SubProgram subProgram))
		{
			return false;
		}
		if (tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(subProgram.Name, text) == null && !text.ContainedInAny(subProgram.Description))
		{
			return subProgram.Id == text;
		}
		return true;
	}

	private void HsHLX9aagMb()
	{
		if (LvSubprograms.ItemsSource == null)
		{
			mhMLXZQMcP9();
		}
		if (s0DLXrfr9By != null && AppState.DataService.GlobalSubPrograms != null)
		{
			try
			{
				s0DLXrfr9By.Refresh();
			}
			catch (Exception ex)
			{
				ts1LXX0pWoU.Warn(ex);
				AppHelper.ShowWarning("程序异常：" + ex.GetMessageWithInner());
			}
		}
	}

	private void Q94LXhppd0V(object sender, RoutedEventArgs e)
	{
		TxtFilter.Text = "";
	}

	private void ohULXep0O03(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(fSdLX1HKtd5);
	}

	private void pI5LXYQncuV(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			e.Handled = true;
		}
	}

	private void fnHLXIxPZO1(object sender, RoutedEventArgs e)
	{
		SubProgram subProgram = LvSubprograms.SelectedItem as SubProgram;
		string value = "\"" + subProgram.Name + "\"";
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("子程序 “" + subProgram.Name + "” 在这些位置被使用了：");
		int num = 0;
		if (JsonConvert.SerializeObject(Action.Steps).Contains(value))
		{
			num++;
			stringBuilder.AppendLine("主程序");
		}
		foreach (SubProgram subProgram2 in SubPrograms)
		{
			if (subProgram != subProgram2 && JsonConvert.SerializeObject(subProgram2).Contains(value))
			{
				num++;
				stringBuilder.AppendLine(subProgram2.Name);
			}
		}
		if (num == 0)
		{
			AppHelper.ShowInformation("未找到使用了此子程序的地方。");
			int num2 = 0;
			if (!L2JOvWF9rZrTjvymEa89())
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
			AppHelper.ShowTextWindow("子程序使用情况", stringBuilder.ToString(), Window.GetWindow(this), false);
		}
	}

	[AsyncStateMachine(typeof(_003CMenuCreateCopy_OnClick_003Ed__37))]
	private void agmLXWhVytR(object sender, RoutedEventArgs e)
	{
		_003CMenuCreateCopy_OnClick_003Ed__37 stateMachine = default(_003CMenuCreateCopy_OnClick_003Ed__37);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CMenuRename_OnClick_003Ed__38))]
	private void yBDLXk3tpnw(object sender, RoutedEventArgs e)
	{
		_003CMenuRename_OnClick_003Ed__38 stateMachine = default(_003CMenuRename_OnClick_003Ed__38);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void vQfLXGL2Xau(object sender, RoutedEventArgs e)
	{
		if (IsReadonly)
		{
			AppHelper.ShowWarning("只读动作不支持此功能。");
		}
		else if (LvSubprograms.SelectedItem is SubProgram obj)
		{
			ClipboardHelper.SetData("quicker-subprogram-item", obj.ToJson());
			AppHelper.ShowSuccess("已复制。");
		}
	}

	[AsyncStateMachine(typeof(_003CMenuPasteSp_OnClick_003Ed__40))]
	private void KylLXs6WSJw(object sender, RoutedEventArgs e)
	{
		_003CMenuPasteSp_OnClick_003Ed__40 stateMachine = default(_003CMenuPasteSp_OnClick_003Ed__40);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Tn2LXHX4lJT(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H))
		{
			rGYLXqFE50f(this, e);
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!XvWLXprBlYU)
		{
			XvWLXprBlYU = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/internalsubprogramlistcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			XvWLXprBlYU = true;
			break;
		case 17:
			((Button)target).Click += nioLXyxXr78;
			break;
		case 18:
			BtnDownloadSubProgram = (Button)target;
			BtnDownloadSubProgram.Click += xIdLX8cBpi3;
			break;
		case 19:
			BtnImportSubProgram = (Button)target;
			BtnImportSubProgram.Click += GbjLXa7hhmf;
			break;
		case 20:
			BtnClearSubPrograms = (Button)target;
			num = 1;
			if (!L2JOvWF9rZrTjvymEa89())
			{
				break;
			}
			goto IL_0144;
		case 1:
			TxtFilter = (TextBox)target;
			TxtFilter.GotFocus += ohULXep0O03;
			TxtFilter.PreviewKeyDown += pI5LXYQncuV;
			TxtFilter.TextChanged += fxNLXVlb6KM;
			break;
		case 2:
			BtnClearFilter = (Button)target;
			BtnClearFilter.Click += Q94LXhppd0V;
			num = 0;
			if (!L2JOvWF9rZrTjvymEa89())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0144;
		case 3:
			LvSubprograms = (ListBox)target;
			LvSubprograms.PreviewKeyDown += Tn2LXHX4lJT;
			break;
		case 4:
			ListContextMenu = (ContextMenu)target;
			break;
		case 5:
			{
				MenuPasteSp = (MenuItem)target;
				MenuPasteSp.Click += KylLXs6WSJw;
				break;
			}
			IL_0144:
			switch (num)
			{
			case 1:
				BtnClearSubPrograms.Click += jhaLX7bDpHi;
				break;
			}
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 6:
			((Grid)target).PreviewMouseDown += MWnLXNFtdtl;
			break;
		case 7:
			((MenuItem)target).Click += rGYLXqFE50f;
			break;
		case 8:
			((MenuItem)target).Click += fnHLXIxPZO1;
			break;
		case 9:
			((MenuItem)target).Click += yBDLXk3tpnw;
			break;
		case 10:
			((MenuItem)target).Click += CXfLXCjAnM9;
			break;
		case 11:
			((MenuItem)target).Click += agmLXWhVytR;
			break;
		case 12:
			((MenuItem)target).Click += vQfLXGL2Xau;
			break;
		case 13:
		{
			((MenuItem)target).Click += X3GLXEa9Giv;
			int num = 0;
			if (YX4C26F9aPR3XKL0p1Co != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 14:
			((MenuItem)target).Click += JxBLXcJs94e;
			break;
		case 15:
			((MenuItem)target).Click += f14LXPhYwpy;
			break;
		case 16:
			((Button)target).Click += D1rLXRLMXX9;
			break;
		}
	}

	static InternalSubProgramListControl()
	{
		ts1LXX0pWoU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void fSdLX1HKtd5()
	{
		TxtFilter.SelectAll();
	}

	internal static bool L2JOvWF9rZrTjvymEa89()
	{
		return YX4C26F9aPR3XKL0p1Co == null;
	}

	internal static void aw8Uf9F9ig61KQ4WKDi0()
	{
	}
}
