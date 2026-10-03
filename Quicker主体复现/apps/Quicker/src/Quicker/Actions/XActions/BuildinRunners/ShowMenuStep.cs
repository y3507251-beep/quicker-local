using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using FontAwesome5;
using Jp6YuAAO2nOBQFwcNUf;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.CircleMenu;
using Quicker.View.Main;
using SnipInsight.Util;

namespace Quicker.Actions.XActions.BuildinRunners;

public class ShowMenuStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public ActionStep tmlSsGj8I3v;

		public ActionExecuteContext bHJSssAaihy;

		public ShowMenuStep PqDSsHiffu7;

		public XAction TETSs15PTuV;

		internal static _003C_003Ec__DisplayClass46_0 Y7cWVdWqjYGcZ7unIj5o;

		internal (bool isSuccess, string message, ActionStopFlag failReason) kMnSskG0FhB()
		{
			_003C_003Ec__DisplayClass46_1 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_1
			{
				pv5Ss5NHwjY = this,
				hljSsnVoUId = null
			};
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(hxCgXAPywLS, tmlSsGj8I3v, bHJSssAaihy);
			_003C_003Ec__DisplayClass46_.gvuSspgr7Ho = XActionHelper.GetNumberParamValue(C8qgXoBisB0, tmlSsGj8I3v, bHJSssAaihy);
			_003C_003Ec__DisplayClass46_.NdnSs4pElaZ = XActionHelper.GetNumberParamValue(ddWgXTQbGkS, tmlSsGj8I3v, bHJSssAaihy);
			_003C_003Ec__DisplayClass46_.AQJSsrDeJq2 = XActionHelper.GetBooleanParamValue(z4qgXObgSuA, tmlSsGj8I3v, bHJSssAaihy);
			_003C_003Ec__DisplayClass46_.nbLSsBX6pgw = 0.0;
			string text = XActionHelper.GetTextParamValue(RCmgXMevTTL, tmlSsGj8I3v, bHJSssAaihy).Trim();
			if (!string.IsNullOrEmpty(text) && text != "0")
			{
				if (text.EndsWith("%"))
				{
					double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint();
					Screen screen = Screen.FromPoint(System.Windows.Forms.Cursor.Position);
					double num = Convert.ToDouble(text.TrimEnd('%')) / 100.0;
					_003C_003Ec__DisplayClass46_.nbLSsBX6pgw = (double)screen.WorkingArea.Height * dpiScaleByPoint * num;
				}
				else
				{
					_003C_003Ec__DisplayClass46_.nbLSsBX6pgw = Convert.ToDouble(text);
				}
			}
			if (XActionHelper.GetParamValue(fW8gXdbh05O, tmlSsGj8I3v, bHJSssAaihy, false, true) is IList<CommonOperationItem> hljSsnVoUId)
			{
				_003C_003Ec__DisplayClass46_.hljSsnVoUId = hljSsnVoUId;
			}
			else
			{
				string textParamValue = XActionHelper.GetTextParamValue(fW8gXdbh05O, tmlSsGj8I3v, bHJSssAaihy);
				if (string.IsNullOrEmpty(textParamValue))
				{
					return (isSuccess: false, message: "缺少菜单数据", failReason: ActionStopFlag.OperationFailed);
				}
				if (textParamValue.StartsWith("[") && textParamValue.EndsWith("]"))
				{
					_003C_003Ec__DisplayClass46_.hljSsnVoUId = JsonConvert.DeserializeObject<IList<CommonOperationItem>>(textParamValue);
				}
				else
				{
					_003C_003Ec__DisplayClass46_.hljSsnVoUId = CommonOperationItem.ParseLinesWithSubItems(textParamValue, true);
				}
			}
			if (!_003C_003Ec__DisplayClass46_.hljSsnVoUId.HasData())
			{
				return (isSuccess: false, message: "菜单数量为0", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass46_.BOQSsjaLofI = false;
			_003C_003Ec__DisplayClass46_.wusSsQL5f0r = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass46_.bFjSsbL7be8);
			if (booleanParamValue)
			{
				while (!_003C_003Ec__DisplayClass46_.BOQSsjaLofI && !bHJSssAaihy.IsShouldStopAction())
				{
					Thread.Sleep(20);
				}
				if (_003C_003Ec__DisplayClass46_.wusSsQL5f0r == null)
				{
					return (isSuccess: false, message: "未点击菜单项", failReason: ActionStopFlag.UserCancel);
				}
				XActionHelper.OutputResult(NhXgXi3k5Y1, tmlSsGj8I3v, bHJSssAaihy, _003C_003Ec__DisplayClass46_.wusSsQL5f0r.Data, TETSs15PTuV);
				XActionHelper.OutputResult(zM0gX3j7ASR, tmlSsGj8I3v, bHJSssAaihy, _003C_003Ec__DisplayClass46_.wusSsQL5f0r, TETSs15PTuV);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool xkoMLTWqD28Fc38udhLQ()
		{
			return Y7cWVdWqjYGcZ7unIj5o == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_1
	{
		public bool AQJSsrDeJq2;

		public double gvuSspgr7Ho;

		public double nbLSsBX6pgw;

		public CommonOperationItem wusSsQL5f0r;

		public bool BOQSsjaLofI;

		public IList<CommonOperationItem> hljSsnVoUId;

		public double NdnSs4pElaZ;

		public _003C_003Ec__DisplayClass46_0 pv5Ss5NHwjY;

		public Action V5pSsDA22h5;

		public RoutedEventHandler VrDSsd0D2Fu;

		public System.Windows.Input.KeyEventHandler NlkSsom4eLa;

		public RoutedEventHandler NXdSsTtCYYr;

		private static _003C_003Ec__DisplayClass46_1 xFYaOsWqEMtytCPtdyU2;

		internal void bFjSsbL7be8()
		{
        System.Windows.Controls.ContextMenu contextMenu = default;
			_003C_003Ec__DisplayClass46_2 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_2
			{
				PGGSsA9kqvi = null
			};
			if (AQJSsrDeJq2)
			{
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi = new Window();
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.WindowStyle = WindowStyle.None;
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.AllowsTransparency = true;
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Background = Brushes.Transparent;
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Height = 0.0;
				goto IL_0170;
			}
			goto IL_024b;
			IL_024b:
			contextMenu = new System.Windows.Controls.ContextMenu
			{
				PlacementTarget = pv5Ss5NHwjY.PqDSsHiffu7.v2CgXpIaYSj(pv5Ss5NHwjY.bHJSssAaihy.ActionTrigger)
			};
			contextMenu.FontSize = gvuSspgr7Ho;
			if (!(nbLSsBX6pgw > 20.0))
			{
				if (nbLSsBX6pgw > 0.0)
				{
					pv5Ss5NHwjY.bHJSssAaihy.ActionLogger.LogInfo("最小高度为20");
				}
				goto IL_0096;
			}
			int num = 0;
			if (!mLbQCVWqGoKIoGc861cx())
			{
				goto IL_01e7;
			}
			goto IL_01fe;
			IL_0170:
			_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Width = 0.0;
			_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Left = 300.0;
			_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Top = 300.0;
			_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.ShowInTaskbar = false;
			_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.ShowActivated = true;
			InputMethod.SetPreferredImeState(_003C_003Ec__DisplayClass46_.PGGSsA9kqvi, InputMethodState.Off);
			num = 0;
			if (xFYaOsWqEMtytCPtdyU2 != null)
			{
				goto IL_01e3;
			}
			goto IL_01e7;
			IL_01e3:
			int num2 = default(int);
			num = num2;
			goto IL_01e7;
			IL_01e7:
			switch (num)
			{
			case 2:
				break;
			case 3:
				goto IL_01fe;
			default:
				goto IL_022d;
			case 1:
				contextMenu.IsOpen = true;
				try
				{
					(contextMenu.Items[0] as System.Windows.Controls.MenuItem)?.Focus();
				}
				catch
				{
				}
				contextMenu.Closed += _003C_003Ec__DisplayClass46_.JxqSsMncJ8h;
				return;
			}
			goto IL_0170;
			IL_0096:
			contextMenu.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, VrDSsd0D2Fu ?? (VrDSsd0D2Fu = i2nSsmBqLjm));
			if (AQJSsrDeJq2)
			{
				contextMenu.AddHandler(UIElement.PreviewKeyDownEvent, NlkSsom4eLa ?? (NlkSsom4eLa = bVBSsKWy6un));
			}
			contextMenu.Closed += NXdSsTtCYYr ?? (NXdSsTtCYYr = sNbSsxnWBeS);
			pv5Ss5NHwjY.PqDSsHiffu7.kvlgXQ0VmSn(contextMenu.Items, hljSsnVoUId, NdnSs4pElaZ);
			if (_003C_003Ec__DisplayClass46_.PGGSsA9kqvi != null)
			{
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.ContextMenu = contextMenu;
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Show();
				_003C_003Ec__DisplayClass46_.PGGSsA9kqvi.Activate();
				num = 1;
				if (xFYaOsWqEMtytCPtdyU2 != null)
				{
					goto IL_01e3;
				}
				goto IL_01e7;
			}
			AppState.RegisterContextMenu(contextMenu);
			contextMenu.IsOpen = true;
			return;
			IL_01fe:
			contextMenu.MaxHeight = nbLSsBX6pgw;
			goto IL_0096;
			IL_022d:
			InputMethod.SetIsInputMethodEnabled(_003C_003Ec__DisplayClass46_.PGGSsA9kqvi, false);
			goto IL_024b;
		}

		internal void SkoSs6TMUyL(System.Windows.Controls.MenuItem menuItem)
		{
			if (menuItem != null)
			{
				CommonOperationItem commonOperationItem = menuItem.Tag as CommonOperationItem;
				wusSsQL5f0r = commonOperationItem;
				if (!string.IsNullOrEmpty(wusSsQL5f0r?.Operation))
				{
					Task.Run(V5pSsDA22h5 ?? (V5pSsDA22h5 = xD9SsXQtDfY));
				}
			}
		}

		internal void xD9SsXQtDfY()
		{
			try
			{
				UQpehvAn0sgnYNEpfrQ.Execute(wusSsQL5f0r, pv5Ss5NHwjY.bHJSssAaihy);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行菜单操作出错：" + ex.Message);
			}
		}

		internal void i2nSsmBqLjm(object sender, RoutedEventArgs e)
		{
			SkoSs6TMUyL(e.OriginalSource as System.Windows.Controls.MenuItem);
		}

		internal void bVBSsKWy6un(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == System.Windows.Input.Key.Space && sender is System.Windows.Controls.ContextMenu contextMenu)
			{
				SkoSs6TMUyL(e.OriginalSource as System.Windows.Controls.MenuItem);
				contextMenu.IsOpen = false;
			}
		}

		internal void sNbSsxnWBeS(object sender, RoutedEventArgs e)
		{
			BOQSsjaLofI = true;
		}

		internal static bool mLbQCVWqGoKIoGc861cx()
		{
			return xFYaOsWqEMtytCPtdyU2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_2
	{
		public Window PGGSsA9kqvi;

		private static _003C_003Ec__DisplayClass46_2 U3WEOsWqO9PixWwFaPrx;

		internal void JxqSsMncJ8h(object sender, RoutedEventArgs e)
		{
			PGGSsA9kqvi.Close();
		}

		internal static bool u7UsAwWqJLVV3W4Xved7()
		{
			return U3WEOsWqO9PixWwFaPrx == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> zxcgXjA475S = new List<string> { "menu" };

	[CompilerGenerated]
	private readonly string jemgXnPAqDu = $"fa:{EFontAwesomeIcon.Light_Bars}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> vLPgX4Aev4P;

	[CompilerGenerated]
	private readonly string IK9gX5pDBjv = "https://getquicker.net/KC/Help/Doc/showmenu";

	private static readonly StepInParamDef xIbgXDFNUkP;

	private static readonly StepInParamDef fW8gXdbh05O;

	private static readonly StepInParamDef C8qgXoBisB0;

	private static readonly StepInParamDef ddWgXTQbGkS;

	private static readonly StepInParamDef RCmgXMevTTL;

	private static readonly StepInParamDef hxCgXAPywLS;

	private static readonly StepInParamDef z4qgXObgSuA;

	private static readonly StepInParamDef kGpgXFUbHBa;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Sq4gXUwlxc0 = new List<StepInParamDef> { fW8gXdbh05O, C8qgXoBisB0, ddWgXTQbGkS, RCmgXMevTTL, z4qgXObgSuA, hxCgXAPywLS, kGpgXFUbHBa };

	private static readonly StepOutParamDef Y2XgXlUVjVL;

	private static readonly StepOutParamDef NhXgXi3k5Y1;

	private static readonly StepOutParamDef zM0gX3j7ASR;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> IsUgXf8Bn7Y = new List<StepOutParamDef> { Y2XgXlUVjVL, NhXgXi3k5Y1, zM0gX3j7ASR };

	private static ShowMenuStep DEQ9aWQ7c5hbLQXOhl9i;

	public string Key => "sys:showmenu";

	public string Name => "显示菜单";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return zxcgXjA475S;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return jemgXnPAqDu;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return vLPgX4Aev4P;
		}
	}

	public string Description => "显示一个菜单";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return IK9gX5pDBjv;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Sq4gXUwlxc0;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return IsUgXf8Bn7Y;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	private UIElement v2CgXpIaYSj(ActionTrigger actionTrigger_0)
	{
		return actionTrigger_0 switch
		{
			ActionTrigger.Gesture => AppHelper.FindRootWindow<GestureWindow>(), 
			ActionTrigger.CircleMenu => AppHelper.FindRootWindow<CircleMenuWindow>(), 
			ActionTrigger.Panel => AppState.HS2taepcAbc(), 
			_ => null, 
		};
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.tmlSsGj8I3v = step;
		_003C_003Ec__DisplayClass46_.bHJSssAaihy = context;
		_003C_003Ec__DisplayClass46_.PqDSsHiffu7 = this;
		_003C_003Ec__DisplayClass46_.TETSs15PTuV = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass46_.bHJSssAaihy, _003C_003Ec__DisplayClass46_.tmlSsGj8I3v, _003C_003Ec__DisplayClass46_.TETSs15PTuV, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass46_.kMnSskG0FhB, (Action)null, (Action)null, kGpgXFUbHBa, Y2XgXlUVjVL);
	}

	private void mYtgXBfGyhb(object sender, RoutedEventArgs e)
	{
	}

	private void kvlgXQ0VmSn(ItemCollection itemCollection_0, IList<CommonOperationItem> ilist_2, double double_0)
	{
		foreach (CommonOperationItem item in ilist_2)
		{
			if (item.IsSeparator)
			{
				AppHelper.AddMenuSeparator(itemCollection_0);
				continue;
			}
			System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, item.Title, item.Description, item.Icon, null, null, null, null, double_0);
			menuItem.Tag = item;
			if (item.Children.HasData())
			{
				kvlgXQ0VmSn(menuItem.Items, item.Children, double_0);
			}
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(fW8gXdbh05O, step) ?? "";
	}

	static ShowMenuStep()
	{
		xIbgXDFNUkP = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "contextmenu",
			SelectionItems = new SelectionItem[1]
			{
				new SelectionItem("contextmenu", "显示一个纵向菜单")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		fW8gXdbh05O = new StepInParamDef
		{
			Key = "menuData",
			Name = "菜单数据",
			Description = "可以为Json/菜单文本格式/IList<CommonOperationItem>对象，详情请参考文档",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		C8qgXoBisB0 = new StepInParamDef
		{
			Key = "fontsize",
			Name = "字体大小",
			Description = "",
			DefaultValue = 12,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		ddWgXTQbGkS = new StepInParamDef
		{
			Key = "iconsize",
			Name = "图标大小",
			Description = "图标的宽度/高度像素数",
			DefaultValue = 16,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		RCmgXMevTTL = new StepInParamDef
		{
			Key = "maxHeight",
			Name = "最大高度",
			Description = "可以为百分比（如:50%）或固定数值（如:500）。",
			DefaultValue = 0,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		hxCgXAPywLS = new StepInParamDef
		{
			Key = "waitMenuClose",
			Name = "等待菜单关闭",
			DefaultValue = true,
			Description = "是否等待菜单关闭后再运行后续步骤",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		z4qgXObgSuA = new StepInParamDef
		{
			Key = "useFocus",
			Name = "占用焦点",
			DefaultValue = false,
			Description = "是否允许菜单占用焦点（从而可以键盘选择菜单项）",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		kGpgXFUbHBa = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		Y2XgXlUVjVL = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		NhXgXi3k5Y1 = new StepOutParamDef
		{
			Key = "selectedItemData",
			Name = "选择的菜单项数据",
			Description = "选择的菜单项的data属性数据",
			Type = VarType.Text
		};
		zM0gX3j7ASR = new StepOutParamDef
		{
			Key = "selectedItem",
			Name = "选择的菜单项",
			Description = "选择的菜单项的CommonOperationItem对象",
			Type = VarType.Object
		};
	}

	internal static bool peDhGVQ7WatVa5xLqBuQ()
	{
		return DEQ9aWQ7c5hbLQXOhl9i == null;
	}

	internal static void rKcPZxQ7pWOTJ7ChNKrm()
	{
	}

	internal static void AVHxObQ7Xbcfcw0iHG7f()
	{
	}
}
