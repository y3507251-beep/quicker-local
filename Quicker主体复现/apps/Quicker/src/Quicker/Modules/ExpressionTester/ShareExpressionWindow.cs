using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Expression;
using Quicker.Utilities;

namespace Quicker.Modules.ExpressionTester;

public class ShareExpressionWindow : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nZdvYgoA0bd;

		public static Func<ExpressionInputParam, bool> IdXvYLkf4hi;

		public static Func<ExpressionInputParam, bool> US3vYvy1WVV;

		internal static _003C_003Ec K8BxaQciJqGA2oDFnAiv;

		static _003C_003Ec()
		{
			nZdvYgoA0bd = new _003C_003Ec();
		}

		internal bool BrsvYwpwkyf(ExpressionInputParam x)
		{
			return x.IsKeyParam;
		}

		internal bool lTLvYtQNkwO(ExpressionInputParam x)
		{
			return x.IsKeyParam;
		}

		internal static bool z2NZxVcikndvM8eyagqj()
		{
			return K8BxaQciJqGA2oDFnAiv == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareExpressionWindow _003C_003E4__this;

		private TaskAwaiter<ApiResult<SharedExpressionDto>> _003C_003Eu__1;

		internal static object NSROZIcir0N4PGc6fDKW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareExpressionWindow shareExpressionWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_016f;
				}
				if (shareExpressionWindow.TxtTitle.EnsureNotEmpty("标题"))
				{
					if (FRIo3LciNORIU8ui6gW9())
					{
						switch (0)
						{
						case 1:
							goto IL_005c;
						}
					}
					if (shareExpressionWindow.TxtDescription.EnsureNotEmpty("描述"))
					{
						goto IL_005c;
					}
				}
				goto end_IL_000e;
				IL_016f:
				try
				{
					if (num != 0)
					{
						shareExpressionWindow.FneUEkawSJ.Title = shareExpressionWindow.TxtTitle.Text;
						shareExpressionWindow.FneUEkawSJ.Description = shareExpressionWindow.TxtDescription.Text;
						shareExpressionWindow.FneUEkawSJ.Keywords = shareExpressionWindow.TxtKeyWords.Text;
						shareExpressionWindow.FneUEkawSJ.ResultDescription = shareExpressionWindow.TxtResultDesc.Text;
						shareExpressionWindow.FneUEkawSJ.IsPublic = shareExpressionWindow.ChkIsPublic.IsChecked == true;
						int num2 = 0;
						if (!FRIo3LciNORIU8ui6gW9())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						shareExpressionWindow.FneUEkawSJ.ResultSampleValue = ((shareExpressionWindow.BN4UyP74uL == null) ? "" : JsonConvert.SerializeObject(shareExpressionWindow.BN4UyP74uL));
					}
					try
					{
						TaskAwaiter<ApiResult<SharedExpressionDto>> awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.s1tt1yIFlwj(shareExpressionWindow.FneUEkawSJ).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								int num4 = 0;
								if (!FRIo3LciNORIU8ui6gW9())
								{
									int num5 = default(int);
									num4 = num5;
								}
								switch (num4)
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
							_003C_003Eu__1 = default(TaskAwaiter<ApiResult<SharedExpressionDto>>);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<SharedExpressionDto> result = awaiter.GetResult();
						if (result.IsSuccess)
						{
							shareExpressionWindow.FneUEkawSJ.Id = result.Data.Id;
							AppHelper.ShowSuccess("保存成功！");
							shareExpressionWindow.ThNvuM5Q9GQ(true);
						}
						else
						{
							AppHelper.ShowWarning(result.Message, true);
						}
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("保存出错。" + ex.Message, true);
					}
				}
				finally
				{
					if (num < 0)
					{
						shareExpressionWindow.BtnShare.IsEnabled = true;
						shareExpressionWindow.LoadingCircle.Visibility = Visibility.Collapsed;
						shareExpressionWindow.LoadingCircle.IsRunning = false;
					}
				}
				goto end_IL_000e;
				IL_005c:
				if (shareExpressionWindow.FneUEkawSJ.InputParams.Count <= 0)
				{
					goto IL_0143;
				}
				IEnumerator<ExpressionInputParam> enumerator = shareExpressionWindow.FneUEkawSJ.InputParams.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ExpressionInputParam current = enumerator.Current;
						current.IsKeyParam = shareExpressionWindow.CbKeyParam.SelectedItem == current;
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
				if (shareExpressionWindow.CbKeyParam.SelectedItem != null || AppHelper.Confirm("尚未指定关键变量。\n关键变量表示此表达式针对此变量进行处理得到结果。\n您确认这个表达式没有关键变量么？"))
				{
					ExpressionInputParam expressionInputParam = shareExpressionWindow.FneUEkawSJ.InputParams.FirstOrDefault(_003C_003Ec.US3vYvy1WVV ?? (_003C_003Ec.US3vYvy1WVV = _003C_003Ec.nZdvYgoA0bd.lTLvYtQNkwO));
					if (expressionInputParam != null)
					{
						shareExpressionWindow.FneUEkawSJ.ForVarType = expressionInputParam.VarType;
					}
					else
					{
						shareExpressionWindow.FneUEkawSJ.ForVarType = null;
					}
					goto IL_0143;
				}
				goto end_IL_000e;
				IL_0143:
				shareExpressionWindow.BtnShare.IsEnabled = false;
				shareExpressionWindow.LoadingCircle.Visibility = Visibility.Visible;
				shareExpressionWindow.LoadingCircle.IsRunning = true;
				goto IL_016f;
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

		static _003CBtnShare_OnClick_003Ed__5()
		{
		}

		internal static bool FRIo3LciNORIU8ui6gW9()
		{
			return NSROZIcir0N4PGc6fDKW == null;
		}

		internal static void YTQ80aciuq7lag6VRsPT()
		{
		}
	}

	private ShareExpressionVm FneUEkawSJ;

	private readonly ExpressionSampleResult BN4UyP74uL;

	private static readonly ILog QXmU8hQpB3;

	internal System.Windows.Controls.TextBox TxtTitle;

	internal System.Windows.Controls.TextBox TxtDescription;

	internal System.Windows.Controls.TextBox TxtKeyWords;

	internal System.Windows.Controls.ComboBox CbKeyParam;

	internal System.Windows.Controls.TextBox TxtResultDesc;

	internal CheckBox ChkIsPublic;

	internal Row ChangeLogRow;

	internal System.Windows.Controls.TextBox TxtUpdateLog;

	internal LoadingCircle LoadingCircle;

	internal Button BtnShare;

	internal Button BtnCancel;

	private bool t6RUad5qAB;

	internal static ShareExpressionWindow V1GiBRzHqYtjZEME0vh;

	public ShareExpressionWindow(ShareExpressionVm dto, ExpressionSampleResult sampleResult)
	{
		InitializeComponent();
		FneUEkawSJ = dto;
		BN4UyP74uL = sampleResult;
		TxtTitle.Text = dto.Title;
		TxtDescription.Text = dto.Description;
		TxtKeyWords.Text = dto.Keywords;
		TxtResultDesc.Text = dto.ResultDescription;
		CbKeyParam.ItemsSource = FneUEkawSJ.InputParams;
		ExpressionInputParam expressionInputParam = FneUEkawSJ.InputParams.FirstOrDefault(_003C_003Ec.IdXvYLkf4hi ?? (_003C_003Ec.IdXvYLkf4hi = _003C_003Ec.nZdvYgoA0bd.BrsvYwpwkyf));
		if (expressionInputParam != null)
		{
			CbKeyParam.SelectedItem = expressionInputParam;
		}
		if (FneUEkawSJ.Id.HasValue)
		{
			ChangeLogRow.Visibility = Visibility.Visible;
		}
		else
		{
			ChangeLogRow.Visibility = Visibility.Collapsed;
		}
		base.Loaded += rUFU02juvH;
	}

	private void rUFU02juvH(object sender, RoutedEventArgs e)
	{
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__5))]
	private void c3SUC5S2mB(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__5 stateMachine = default(_003CBtnShare_OnClick_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void IEKUPboeb0(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!t6RUad5qAB)
		{
			t6RUad5qAB = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/expressiontester/shareexpressionwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtTitle = (System.Windows.Controls.TextBox)target;
				return;
			case 2:
				TxtDescription = (System.Windows.Controls.TextBox)target;
				return;
			case 3:
				TxtKeyWords = (System.Windows.Controls.TextBox)target;
				return;
			case 4:
				CbKeyParam = (System.Windows.Controls.ComboBox)target;
				return;
			case 5:
				TxtResultDesc = (System.Windows.Controls.TextBox)target;
				return;
			case 6:
				ChkIsPublic = (CheckBox)target;
				return;
			case 7:
				ChangeLogRow = (Row)target;
				return;
			case 8:
				TxtUpdateLog = (System.Windows.Controls.TextBox)target;
				return;
			case 9:
				LoadingCircle = (LoadingCircle)target;
				return;
			case 10:
				BtnShare = (Button)target;
				BtnShare.Click += c3SUC5S2mB;
				return;
			case 11:
				BtnCancel = (Button)target;
				BtnCancel.Click += IEKUPboeb0;
				return;
			}
			if (V1GiBRzHqYtjZEME0vh == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			t6RUad5qAB = true;
			return;
		}
	}

	static ShareExpressionWindow()
	{
		QXmU8hQpB3 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool jEWZ43zzegBHqR0KIwV()
	{
		return V1GiBRzHqYtjZEME0vh == null;
	}
}
