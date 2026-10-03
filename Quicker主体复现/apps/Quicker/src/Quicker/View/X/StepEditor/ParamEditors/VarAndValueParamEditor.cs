using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using FontAwesome5;
using ICSharpCode.AvalonEdit;
using k7aPL5fDWhslvV5ur2A;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.X.Controls;
using Quicker.View.X.Controls.ParamEditors;
using Quicker.View.X.StepEditor.ParamEditors.ParamControls;
using t7wokwYFlDgjUncgQNA;

namespace Quicker.View.X.StepEditor.ParamEditors;

public class VarAndValueParamEditor : BaseParamEditorCustomControl, ITextControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec S63SOUI4cHv;

		public static RoutedEventHandler EwaSOlhf3yY;

		public static RoutedEventHandler BwpSOifvvG0;

		public static Func<ActionVariable, string> HqUSO3sOn3l;

		internal static _003C_003Ec X4D235yV1Ve6TNxSFTXT;

		static _003C_003Ec()
		{
			S63SOUI4cHv = new _003C_003Ec();
		}

		internal void mTTSOAr2ahL(object sender, RoutedEventArgs e)
		{
			AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(26, "文本插值"));
		}

		internal void ywfSOOHm92U(object sender, RoutedEventArgs e)
		{
			AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(21, "表达式教程"));
		}

		internal string OZhSOFdZwYT(ActionVariable x)
		{
			return x.Group + x.Key;
		}

		internal static bool U3B79dyVKVonxFPVdm16()
		{
			return X4D235yV1Ve6TNxSFTXT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public ActionVariable WGbSOzbDFkE;

		private static _003C_003Ec__DisplayClass45_0 PmMQVnyVdx5qoYsn0L3Y;

		internal bool BG1SOflj4E8(VariableOrValueSelectItem x)
		{
			return x.Key == WGbSOzbDFkE.Key;
		}

		internal static void bQVYuyyVk3JC649CbeMI()
		{
		}

		internal static bool WWruOcyVO2Zt3Qht87ee()
		{
			return PmMQVnyVdx5qoYsn0L3Y == null;
		}
	}

	private static readonly ILog FaRLHepV6N6;

	private readonly ObservableCollection<VariableOrValueSelectItem> iiaLHYEsd0o = new ObservableCollection<VariableOrValueSelectItem>();

	private readonly ObservableCollection<ActionVariable> BWpLHIfG3HS;

	private ActionStepParam KsILHWjtjGn;

	private ParamVarMode BtaLHkswJi1;

	private CodeEditor TxtEditor;

	private GridSplitter Splitter;

	private TextToolsControl TextTools1;

	private VariableInfoControl VariableInfoCtrl;

	private Popup ToggledPopup;

	private Grid PnlTextEditor;

	private EnumParamValueControl EnumParamValueControl1;

	private Border BorderMode;

	private TextBlock LblMode;

	private Border WrapperBorder;

	private ToggleButton TogglePopupButton1;

	private Border SelectorContainer;

	private bool dfpLHGmMjBn;

	private bool ik9LHsR9lCg;

	private static VarAndValueParamEditor ds4JUxFaZYcQpMPkakLk;

	static VarAndValueParamEditor()
	{
		FaRLHepV6N6 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(VarAndValueParamEditor), new FrameworkPropertyMetadata(typeof(VarAndValueParamEditor)));
	}

	public VarAndValueParamEditor(ObservableCollection<ActionVariable> actionVariables, StepInParamDef paramDef, ActionStepParam paramData)
		: base(paramDef, paramData)
	{
		base.Focusable = false;
		BWpLHIfG3HS = actionVariables;
		KsILHWjtjGn = new ActionStepParam
		{
			VarKey = _paramData.VarKey,
			Value = (_paramData.Value ?? "")
		};
		PwWLsTVpi1I();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		TxtEditor = GetTemplateChild("TxtEditor") as CodeEditor;
		Splitter = GetTemplateChild("Splitter") as GridSplitter;
		TextTools1 = GetTemplateChild("TextTools1") as TextToolsControl;
		VariableInfoCtrl = GetTemplateChild("VariableInfoCtrl") as VariableInfoControl;
		ToggledPopup = GetTemplateChild("ToggledPopup") as Popup;
		int num = 0;
		if (!fenqDUFa5KRVl0JWIene())
		{
			int num2 = default(int);
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				PnlTextEditor = GetTemplateChild("PnlTextEditor") as Grid;
				EnumParamValueControl1 = GetTemplateChild("EnumParamValueControl1") as EnumParamValueControl;
				BorderMode = GetTemplateChild("BorderMode") as Border;
				LblMode = GetTemplateChild("LblMode") as TextBlock;
				WrapperBorder = GetTemplateChild("WrapperBorder") as Border;
				TogglePopupButton1 = GetTemplateChild("TogglePopupButton1") as ToggleButton;
				SelectorContainer = GetTemplateChild("SelectorContainer") as Border;
				num = 0;
				if (ds4JUxFaZYcQpMPkakLk != null)
				{
					continue;
				}
				goto case 1;
			case 1:
			{
				AP3LsM4iPEC();
				bool defaultUseExpression = _paramDef.Type != VarType.Text;
				TextTools1.SetVariableList(BWpLHIfG3HS, defaultUseExpression);
				TextTools1.SetupTools(true, _paramDef.TextTools, this, _paramDef.TextToolsContextHint, _paramDef.DefaultHighlightType, null, _paramDef.Type);
				hgILsOmOTDy();
				int num2 = 2;
				goto case 2;
			}
			case 2:
				q8aLsAnrPbi();
				WrapperBorder.MouseDown += V8ILH8GAKwZ;
				base.PreviewKeyDown += tJ7LsdvKyeE;
				BorderMode.PreviewMouseDown += hxqLH0Y3o4s;
				BorderMode.MouseUp += eSbLHCZmgTH;
				TxtEditor.PreviewKeyDown += KuKLslsUDvw;
				TxtEditor.PreviewMouseWheel += SBKLHytBZqJ;
				TxtEditor.ContextMenuOpening += gK4LsoaJgUF;
				break;
			case 3:
				break;
			}
			break;
		}
		TextTools1.ValueSelected += TextToolsControl_OnValueSelected;
		Splitter.DragStarted += YVELHPKIvC0;
		Splitter.DragCompleted += FBaLHEVZiWr;
		VariableInfoCtrl.PreviewMouseDown += cTHLHLTOL3p;
		VariableInfoCtrl.MouseUp += WPrLHvXSrOp;
		VariableInfoCtrl.ContextMenuOpening += na5LHSHVfuN;
		EnumParamValueControl1.MouseDown += u5QLHN9fWwG;
		EnumParamValueControl1.MouseUp += WSgLHJt09f3;
		EnumParamValueControl1.ContextMenuOpening += JYSLs5yJB47;
		ToggledPopup.Opened += cB3LHwG6OSn;
		ToggledPopup.Closed += zNdLsDuxnSA;
		dfpLHGmMjBn = true;
	}

	private void JYSLs5yJB47(object sender, ContextMenuEventArgs e)
	{
		if (EnumParamValueControl1.ContextMenu == null)
		{
			EnumParamValueControl1.ContextMenu = new ContextMenu();
		}
		if (EnumParamValueControl1.ContextMenu.Items.Count == 0)
		{
			ItemCollection items = EnumParamValueControl1.ContextMenu.Items;
			AppHelper.AddMenuItem(items, "手工填写", "手工填写参数值", "", k8dLHaUbgV8);
			AppHelper.AddMenuItem(items, "转换为表达式", "将变量模式转换为表达式$=“值”的形式。", "", UgQLH7Ui2ZM).Icon = new TextBlock
			{
				Text = "$=",
				Foreground = "#198754".GetBrush(),
				FontWeight = FontWeights.Bold,
				FontSize = 14.0
			};
		}
	}

	private void zNdLsDuxnSA(object sender, EventArgs e)
	{
		TogglePopupButton1.Focus();
	}

	private void tJ7LsdvKyeE(object sender, KeyEventArgs e)
	{
		if ((BtaLHkswJi1 != ParamVarMode.EnumValue && BtaLHkswJi1 != ParamVarMode.Variable) || TogglePopupButton1.IsChecked != false)
		{
			return;
		}
		int num = 0;
		if (ds4JUxFaZYcQpMPkakLk != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e.Key == Key.Space || e.Key == Key.Return)
		{
			W4CLHt1pB87();
			tuyLHg3wUG4();
			e.Handled = true;
		}
	}

	private void gK4LsoaJgUF(object sender, ContextMenuEventArgs e)
	{
		if (TxtEditor.ContextMenu == null)
		{
			TxtEditor.ContextMenu = new ContextMenu();
		}
		if (TxtEditor.ContextMenu.Items.Count == 0)
		{
			ItemCollection items = TxtEditor.ContextMenu.Items;
			AppHelper.AddMenuItem(items, "在编辑器中修改", "在编辑器中修改", "fa:Light_ExternalLinkSquare", RbtLsUusqQV);
			AppHelper.AddMenuItem(items, "在外部编辑器中修改", "使用第三方编辑器修改内容", "", kVlLHRY2DDh);
			AppHelper.AddMenuSeparator(items);
			MenuItem menuItem = AppHelper.AddMenuItem(items, "帮助文档", "查看帮助文档", "fa:Light_QuestionCircle:DodgerBlue", null);
			AppHelper.AddMenuItem(menuItem.Items, "文本插值（快速拼接文本）", "将变量值插入文本中", "", _003C_003Ec.EwaSOlhf3yY ?? (_003C_003Ec.EwaSOlhf3yY = _003C_003Ec.S63SOUI4cHv.mTTSOAr2ahL)).Icon = new TextBlock
			{
				Text = "$$",
				Foreground = Brushes.DodgerBlue,
				FontWeight = FontWeights.Bold,
				FontSize = 14.0
			};
			AppHelper.AddMenuItem(menuItem.Items, "表达式（计算公式并得到值）", "使用类似c#的语法编写强大的语句", "", _003C_003Ec.BwpSOifvvG0 ?? (_003C_003Ec.BwpSOifvvG0 = _003C_003Ec.S63SOUI4cHv.ywfSOOHm92U)).Icon = new TextBlock
			{
				Text = "$=",
				Foreground = "#198754".GetBrush(),
				FontWeight = FontWeights.Bold,
				FontSize = 14.0
			};
			AppHelper.AddMenuSeparator(items);
			items.Add(new MenuItem
			{
				Command = ApplicationCommands.Undo
			});
			items.Add(new MenuItem
			{
				Command = ApplicationCommands.Redo
			});
			AppHelper.AddMenuSeparator(items);
			items.Add(new MenuItem
			{
				Command = ApplicationCommands.Copy
			});
			items.Add(new MenuItem
			{
				Command = ApplicationCommands.Cut
			});
			items.Add(new MenuItem
			{
				Command = ApplicationCommands.Paste
			});
		}
	}

	public override ActionStepParam GetParamValue()
	{
		if (!dfpLHGmMjBn)
		{
			return KsILHWjtjGn;
		}
		return BtaLHkswJi1 switch
		{
			ParamVarMode.Input => new ActionStepParam
			{
				Value = TxtEditor.Text
			}, 
			ParamVarMode.Variable => new ActionStepParam
			{
				VarKey = KsILHWjtjGn.VarKey
			}, 
			ParamVarMode.EnumValue => new ActionStepParam
			{
				Value = KsILHWjtjGn.Value
			}, 
			_ => throw new InvalidDataException("位置的变量模式：" + BtaLHkswJi1), 
		};
	}

	private void PwWLsTVpi1I()
	{
        bool flag = default;
		if (iiaLHYEsd0o.HasData())
		{
			return;
		}
		iiaLHYEsd0o.Add(new VariableOrValueSelectItem
		{
			Key = null,
			Type = VarType.NA,
			Icon = $"fa:{EFontAwesomeIcon.Light_ICursor}:#6aaded",
			Desc = "--输入内容(值或表达式)--"
		});
		if (_paramDef.SelectionItems.HasData())
		{
			foreach (SelectionItem selectionItem in _paramDef.SelectionItems)
			{
				iiaLHYEsd0o.Add(new VariableOrValueSelectItem(selectionItem.Value, selectionItem.Name));
			}
		}
		if (_paramDef.Type != VarType.Boolean || _paramDef.SelectionItems.HasData())
		{
			goto IL_0151;
		}
		flag = false;
		int num;
		if (KsILHWjtjGn != null && !string.IsNullOrEmpty(KsILHWjtjGn.Value))
		{
			flag = !KsILHWjtjGn.Value.IsEither("0", "1");
			num = 1;
			if (ds4JUxFaZYcQpMPkakLk != null)
			{
				goto IL_01df;
			}
			goto IL_01e3;
		}
		flag = _paramDef.DefaultValue is bool;
		goto IL_01f5;
		IL_01df:
		int num2 = default(int);
		num = num2;
		goto IL_01e3;
		IL_01e3:
		switch (num)
		{
		case 1:
			break;
		default:
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem(new ActionVariable
			{
				Key = "[cliptext]",
				Type = VarType.Text,
				Desc = "*剪贴板文本*"
			}));
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem(new ActionVariable
			{
				Key = "quicker_in_param",
				Type = VarType.Text,
				Desc = "*动作参数*"
			}));
			return;
		}
		goto IL_01f5;
		IL_01f5:
		if (flag)
		{
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem("true", "是")
			{
				Key = "true"
			});
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem("false", "否")
			{
				Key = "false"
			});
		}
		else
		{
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem("1", "是")
			{
				Key = "1"
			});
			iiaLHYEsd0o.Add(new VariableOrValueSelectItem("0", "否")
			{
				Key = "0"
			});
		}
		goto IL_0151;
		IL_0151:
		foreach (ActionVariable item in BWpLHIfG3HS.OrderBy(_003C_003Ec.HqUSO3sOn3l ?? (_003C_003Ec.HqUSO3sOn3l = _003C_003Ec.S63SOUI4cHv.OZhSOFdZwYT)))
		{
			if (VariableHelper.IsAssignable(item.Type, _paramDef.Type))
			{
				iiaLHYEsd0o.Add(new VariableOrValueSelectItem(item));
			}
		}
		if (VariableHelper.IsAssignable(VarType.Text, _paramDef.Type))
		{
			num = 0;
			if (ds4JUxFaZYcQpMPkakLk != null)
			{
				goto IL_01df;
			}
			goto IL_01e3;
		}
	}

	private void AP3LsM4iPEC()
	{
		while (true)
		{
			TxtEditor.ActionVariables = BWpLHIfG3HS;
			if (!fenqDUFa5KRVl0JWIene())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (!string.IsNullOrEmpty(_paramDef?.DefaultHighlightType))
		{
			TxtEditor.DefaultHighlightType = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(_paramDef.DefaultHighlightType);
		}
		TxtEditor.Options.InheritWordWrapIndentation = false;
		StepInParamDef paramDef = _paramDef;
		if (paramDef != null && paramDef.IsMultiLine)
		{
			PnlTextEditor.RowDefinitions[0].MinHeight = 40.0;
			return;
		}
		Splitter.Visibility = Visibility.Collapsed;
		TxtEditor.Padding = new Thickness(2.0, 5.0, 2.0, 5.0);
		TxtEditor.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
		TxtEditor.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
	}

	private void q8aLsAnrPbi()
	{
		if (!string.IsNullOrEmpty(KsILHWjtjGn.VarKey))
		{
			BtaLHkswJi1 = ParamVarMode.Variable;
		}
		else if (iiaLHYEsd0o.Any(m0uLHqHV4eR))
		{
			BtaLHkswJi1 = ParamVarMode.EnumValue;
		}
		else
		{
			BtaLHkswJi1 = ParamVarMode.Input;
		}
		C6LLsFKX36N(true);
	}

	private void hgILsOmOTDy()
	{
		if (AppState.HHxtaMaoqJr().ShowParamDescAsToolTip)
		{
			base.ToolTip = _paramDef.Description.Or(_paramDef.Name);
		}
	}

	public void SetFiled(ParamVarMode mode, object data)
	{
		MS0Lszwrm9n(mode, data);
	}

	private void C6LLsFKX36N(bool bool_2)
	{
		VariableInfoCtrl.Visibility = (BtaLHkswJi1 == ParamVarMode.Variable).ToVisibility();
		EnumParamValueControl1.Visibility = (BtaLHkswJi1 == ParamVarMode.EnumValue).ToVisibility();
		PnlTextEditor.Visibility = BtaLHkswJi1.IsEither(default(ParamVarMode)).ToVisibility();
		BorderMode.Visibility = BtaLHkswJi1.IsEither(default(ParamVarMode)).ToVisibility();
		int num = 1;
		if (ds4JUxFaZYcQpMPkakLk != null)
		{
			goto IL_0187;
		}
		goto IL_018b;
		IL_0187:
		int num2 = default(int);
		num = num2;
		goto IL_018b;
		IL_018b:
		ActionVariable actionVariable = default(ActionVariable);
		while (true)
		{
			switch (num)
			{
			case 1:
				switch (BtaLHkswJi1)
				{
				case ParamVarMode.Input:
					LblMode.Text = "";
					LblMode.Foreground = Brushes.Gray;
					LblMode.FontWeight = FontWeights.Normal;
					break;
				}
				if (BtaLHkswJi1 == ParamVarMode.Variable)
				{
					VariableOrValueSelectItem variableOrValueSelectItem = iiaLHYEsd0o.FirstOrDefault(dHkLHcVHBHa);
					if (variableOrValueSelectItem == null)
					{
						actionVariable = BWpLHIfG3HS.FirstOrDefault(SxgLHVbLuZP);
						if (actionVariable != null)
						{
							num = 0;
							if (ds4JUxFaZYcQpMPkakLk == null)
							{
								continue;
							}
							break;
						}
						VariableInfoCtrl.SetVarInfo("", VarType.Any, "未找到变量：" + KsILHWjtjGn.VarKey);
						return;
					}
					VariableInfoCtrl.SetVarInfo(variableOrValueSelectItem.Key, variableOrValueSelectItem.Type, variableOrValueSelectItem.Desc);
					return;
				}
				if (BtaLHkswJi1 == ParamVarMode.EnumValue)
				{
					VariableOrValueSelectItem variableOrValueSelectItem2 = iiaLHYEsd0o.FirstOrDefault(MpKLHZbj0GV);
					if (variableOrValueSelectItem2 != null)
					{
						EnumParamValueControl1.SetValueInfo(variableOrValueSelectItem2.Key, variableOrValueSelectItem2.DisplayValue, variableOrValueSelectItem2.Icon);
					}
				}
				if (bool_2)
				{
					num = 2;
					if (ds4JUxFaZYcQpMPkakLk == null)
					{
						continue;
					}
					break;
				}
				goto IL_0218;
			default:
				VariableInfoCtrl.SetVarInfo(actionVariable.Key, actionVariable.Type, actionVariable.Desc);
				return;
			case 2:
				{
					Ae7Lsfb7g3x(KsILHWjtjGn.Value, true);
					goto IL_0218;
				}
				IL_0218:
				if (!bool_2 && TxtEditor.Visibility == Visibility.Visible)
				{
					Task.Run((Action)XlOLH9BQV4N);
				}
				return;
			}
			break;
		}
		goto IL_0187;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return BWpLHIfG3HS;
	}

	public void SetAllText(string text)
	{
		TxtEditor.Text = text;
	}

	public void SetSelectedText(string text)
	{
		TxtEditor.SelectedText = text;
	}

	public void MoveCaretToEnd()
	{
		throw new NotImplementedException();
	}

	public void TriggerCreateVariable()
	{
		MS0Lszwrm9n(ParamVarMode.CreateVariable, null);
	}

	private void RbtLsUusqQV(object sender, RoutedEventArgs e)
	{
		hM8Ls3IT0Oq();
	}

	public string GetAllText()
	{
		return TxtEditor.Text;
	}

	public string GetSelectedText()
	{
		return TxtEditor.SelectedText;
	}

	private void KuKLslsUDvw(object sender, KeyEventArgs e)
	{
		int num = 2;
		while (true)
		{
			int num2;
			if (!TxtEditor.IsCompletionWindowOpen)
			{
				if (!_paramDef.IsMultiLine)
				{
					if (e.Key == Key.Return)
					{
						e.Handled = true;
					}
					else if (e.Key == Key.Tab)
					{
						e.Handled = true;
						if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
						{
							(sender as TextEditor)?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
						}
						else
						{
							(sender as TextEditor)?.TextArea?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
						}
					}
				}
				if (e.Key == Key.F1)
				{
					BC4Lsi2DwUa();
					e.Handled = true;
					return;
				}
				if (e.Key != Key.F2)
				{
					break;
				}
				num2 = 0;
				if (ds4JUxFaZYcQpMPkakLk != null)
				{
					goto IL_00af;
				}
			}
			else
			{
				num2 = 1;
				if (ds4JUxFaZYcQpMPkakLk != null)
				{
					goto IL_00af;
				}
			}
			goto IL_00b3;
			IL_00af:
			num2 = num;
			goto IL_00b3;
			IL_00b3:
			switch (num2)
			{
			case 2:
				continue;
			case 1:
				return;
			}
			hM8Ls3IT0Oq();
			return;
		}
		if (e.Key == Key.Down && Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			TogglePopupButton1.IsChecked = true;
		}
	}

	private void BC4Lsi2DwUa()
	{
		TxtEditor.ToggleInputMode();
		C6LLsFKX36N(false);
	}

	private void hM8Ls3IT0Oq()
	{
		CodeEditorWindow codeEditorWindow = new CodeEditorWindow(BWpLHIfG3HS, false, _paramDef?.DefaultHighlightType);
		codeEditorWindow.Owner = Window.GetWindow(this);
		codeEditorWindow.Text = TxtEditor.Text;
		codeEditorWindow.ShowDialog();
		TxtEditor.SelectAll();
		TxtEditor.dkOLiRNGFGf(codeEditorWindow.Text);
	}

	private void Ae7Lsfb7g3x(string string_0, bool bool_2 = false)
	{
		if (bool_2)
		{
			TxtEditor.Text = string_0;
		}
		else
		{
			TxtEditor.Document.Text = string_0;
		}
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		if (e.IsFullContent)
		{
			Ae7Lsfb7g3x(e.Value);
			return;
		}
		int num;
		switch (_paramDef.ReplaceMode)
		{
		case TextToolsReplaceMode.ReplaceSelected:
			TxtEditor.dkOLiRNGFGf(e.Value);
			break;
		case TextToolsReplaceMode.ReplaceAll:
			Ae7Lsfb7g3x(e.Value);
			break;
		case TextToolsReplaceMode.Append:
			TxtEditor.Text += e.Value;
			break;
		case TextToolsReplaceMode.AppendWithSemicolon:
			if (string.IsNullOrEmpty(TxtEditor.Text))
			{
				Ae7Lsfb7g3x(e.Value);
				break;
			}
			Ae7Lsfb7g3x(TxtEditor.Text.TrimEnd(';') + ";" + e.Value);
			break;
		case TextToolsReplaceMode.AppendWithNewline:
			if (string.IsNullOrEmpty(TxtEditor.Text))
			{
				Ae7Lsfb7g3x(e.Value);
			}
			else if (TxtEditor.Text.EndsWith("\n", StringComparison.OrdinalIgnoreCase))
			{
				Ae7Lsfb7g3x(TxtEditor.Text + e.Value);
			}
			else
			{
				Ae7Lsfb7g3x(TxtEditor.Text + "\r\n" + e.Value);
			}
			break;
		case TextToolsReplaceMode.AppendWithComma:
			if (string.IsNullOrEmpty(TxtEditor.Text))
			{
				num = 0;
				if (ds4JUxFaZYcQpMPkakLk != null)
				{
					goto IL_018d;
				}
				goto IL_01a9;
			}
			Ae7Lsfb7g3x(TxtEditor.Text.TrimEnd(',') + "," + e.Value);
			break;
		default:
			goto IL_01bc;
			IL_01a9:
			switch (num)
			{
			case 1:
				goto IL_01bc;
			case 2:
				goto end_IL_0023;
			}
			goto IL_018d;
			IL_01bc:
			TxtEditor.dkOLiRNGFGf(e.Value);
			break;
			IL_018d:
			do
			{
				Ae7Lsfb7g3x(e.Value);
				num = 2;
			}
			while (!fenqDUFa5KRVl0JWIene());
			goto IL_01a9;
			end_IL_0023:
			break;
		}
		TxtEditor.Focus();
	}

	private void MS0Lszwrm9n(ParamVarMode paramVarMode_1, object object_0)
	{
		int num = 2;
		while (true)
		{
			ToggledPopup.IsOpen = false;
			int num2 = 0;
			if (fenqDUFa5KRVl0JWIene())
			{
				goto IL_000e;
			}
			goto IL_00f9;
			IL_00f9:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto end_IL_010f;
			}
			goto IL_000e;
			IL_000e:
			ActionStepParam ksILHWjtjGn2;
			object obj2;
			ActionStepParam ksILHWjtjGn;
			object obj;
			switch (paramVarMode_1)
			{
			case ParamVarMode.CreateVariable:
				break;
			case ParamVarMode.Input:
				BtaLHkswJi1 = paramVarMode_1;
				goto end_IL_010f;
			case ParamVarMode.Variable:
				BtaLHkswJi1 = paramVarMode_1;
				ksILHWjtjGn2 = KsILHWjtjGn;
				if (object_0 == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = object_0.ToString();
					if (obj2 != null)
					{
						goto IL_0158;
					}
				}
				obj2 = "";
				goto IL_0158;
			case ParamVarMode.EnumValue:
				BtaLHkswJi1 = paramVarMode_1;
				ksILHWjtjGn = KsILHWjtjGn;
				if (object_0 == null)
				{
					obj = null;
				}
				else
				{
					obj = object_0.ToString();
					if (obj != null)
					{
						goto IL_0181;
					}
				}
				obj = "";
				goto IL_0181;
			case ParamVarMode.Clear:
				BtaLHkswJi1 = ParamVarMode.Input;
				KsILHWjtjGn.VarKey = "";
				Ae7Lsfb7g3x("");
				goto end_IL_010f;
			default:
				goto end_IL_010f;
			case ParamVarMode.Cancel:
				return;
				IL_0158:
				ksILHWjtjGn2.VarKey = (string)obj2;
				goto end_IL_010f;
				IL_0181:
				ksILHWjtjGn.Value = (string)obj;
				goto end_IL_010f;
			}
			_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
			_003C_003Ec__DisplayClass45_.WGbSOzbDFkE = XActionUiHelper.CreateVariable(Window.GetWindow(this), BWpLHIfG3HS, _paramDef.Type, false, _paramDef.Key, _paramDef.Name, false, true);
			if (_003C_003Ec__DisplayClass45_.WGbSOzbDFkE != null)
			{
				if (!iiaLHYEsd0o.Any(_003C_003Ec__DisplayClass45_.BG1SOflj4E8))
				{
					VariableOrValueSelectItem item = new VariableOrValueSelectItem(_003C_003Ec__DisplayClass45_.WGbSOzbDFkE);
					iiaLHYEsd0o.Add(item);
				}
				KsILHWjtjGn.VarKey = _003C_003Ec__DisplayClass45_.WGbSOzbDFkE.Key;
				KsILHWjtjGn.Value = "";
				BtaLHkswJi1 = ParamVarMode.Variable;
				num2 = 0;
				if (!fenqDUFa5KRVl0JWIene())
				{
					num2 = num;
				}
				goto IL_00f9;
			}
			return;
			continue;
			end_IL_010f:
			break;
		}
		C6LLsFKX36N(false);
		NotifyValueChange();
	}

	private void cB3LHwG6OSn(object sender, EventArgs e)
	{
		if (SelectorContainer.Child == null)
		{
			ParamVariableSelector paramVariableSelector = new ParamVariableSelector();
			paramVariableSelector.Init(BWpLHIfG3HS, _paramDef, _paramData, iiaLHYEsd0o);
			paramVariableSelector.SelectionCallback = MS0Lszwrm9n;
			paramVariableSelector.UpdateParamVarMode(BtaLHkswJi1);
			SelectorContainer.Child = paramVariableSelector;
		}
	}

	private void W4CLHt1pB87()
	{
		ik9LHsR9lCg = false;
		if (TogglePopupButton1.IsEnabled)
		{
			ik9LHsR9lCg = true;
		}
	}

	private bool tuyLHg3wUG4()
	{
		if (ik9LHsR9lCg)
		{
			TogglePopupButton1.IsChecked = true;
			ik9LHsR9lCg = false;
			return true;
		}
		return false;
	}

	private void cTHLHLTOL3p(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			W4CLHt1pB87();
		}
	}

	private void WPrLHvXSrOp(object sender, MouseButtonEventArgs e)
	{
		tuyLHg3wUG4();
	}

	private void na5LHSHVfuN(object sender, ContextMenuEventArgs e)
	{
		if (VariableInfoCtrl.ContextMenu == null)
		{
			VariableInfoCtrl.ContextMenu = new ContextMenu();
		}
		if (VariableInfoCtrl.ContextMenu.Items.Count == 0)
		{
			ItemCollection items = VariableInfoCtrl.ContextMenu.Items;
			AppHelper.AddMenuItem(items, "转换为表达式", "将变量模式转换为表达式$={变量}的形式。", "", otuLH2qSJSX).Icon = new TextBlock
			{
				Text = "$=",
				Foreground = "#198754".GetBrush(),
				FontWeight = FontWeights.Bold,
				FontSize = 14.0
			};
			AppHelper.AddMenuItem(items, "转换为文本插值", "将变量模式转换为文本插值$${变量}的形式。", "", PhALHueBAn1).Icon = new TextBlock
			{
				Text = "$$",
				Foreground = Brushes.DodgerBlue,
				FontWeight = FontWeights.Bold,
				FontSize = 14.0
			};
		}
	}

	private void otuLH2qSJSX(object sender, RoutedEventArgs e)
	{
		BtaLHkswJi1 = ParamVarMode.Input;
		KsILHWjtjGn.Value = "$={" + KsILHWjtjGn.VarKey + "}";
		Ae7Lsfb7g3x(KsILHWjtjGn.Value);
		TxtEditor.CaretOffset = TxtEditor.Text.Length;
		KsILHWjtjGn.VarKey = "";
		C6LLsFKX36N(false);
	}

	private void PhALHueBAn1(object sender, RoutedEventArgs e)
	{
		BtaLHkswJi1 = ParamVarMode.Input;
		KsILHWjtjGn.Value = "$${" + KsILHWjtjGn.VarKey + "}";
		Ae7Lsfb7g3x(KsILHWjtjGn.Value);
		TxtEditor.CaretOffset = TxtEditor.Text.Length;
		KsILHWjtjGn.VarKey = "";
		C6LLsFKX36N(false);
	}

	private void u5QLHN9fWwG(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			W4CLHt1pB87();
		}
	}

	private void WSgLHJt09f3(object sender, MouseButtonEventArgs e)
	{
		tuyLHg3wUG4();
	}

	private void hxqLH0Y3o4s(object sender, MouseButtonEventArgs e)
	{
		W4CLHt1pB87();
	}

	private void eSbLHCZmgTH(object sender, MouseButtonEventArgs e)
	{
		tuyLHg3wUG4();
	}

	private void YVELHPKIvC0(object sender, DragStartedEventArgs e)
	{
		PnlTextEditor.RowDefinitions[0].Height = new GridLength(PnlTextEditor.RowDefinitions[0].ActualHeight);
		TxtEditor.MaxHeight = double.PositiveInfinity;
	}

	private void FBaLHEVZiWr(object sender, DragCompletedEventArgs e)
	{
	}

	private void SBKLHytBZqJ(object sender, MouseWheelEventArgs e)
	{
		if (!TxtEditor.IsKeyboardFocusWithin || TxtEditor.ExtentHeight <= TxtEditor.ActualHeight)
		{
			e.Handled = true;
			MouseWheelEventArgs e2 = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
			e2.RoutedEvent = UIElement.MouseWheelEvent;
			((UIElement)sender).RaiseEvent(e2);
		}
	}

	private void V8ILH8GAKwZ(object sender, MouseButtonEventArgs e)
	{
		if (PnlTextEditor.IsVisible)
		{
			TxtEditor.Focus();
		}
	}

	[CompilerGenerated]
	private void k8dLHaUbgV8(object sender, RoutedEventArgs e)
	{
		string value = EnumParamValueControl1.Value;
		BtaLHkswJi1 = ParamVarMode.Input;
		KsILHWjtjGn.Value = value;
		Ae7Lsfb7g3x(KsILHWjtjGn.Value);
		TxtEditor.CaretOffset = TxtEditor.Text.Length;
		KsILHWjtjGn.VarKey = "";
		C6LLsFKX36N(false);
	}

	[CompilerGenerated]
	private void UgQLH7Ui2ZM(object sender, RoutedEventArgs e)
	{
		string value = EnumParamValueControl1.Value;
		BtaLHkswJi1 = ParamVarMode.Input;
		KsILHWjtjGn.Value = "$=\"" + value + "\"";
		Ae7Lsfb7g3x(KsILHWjtjGn.Value);
		TxtEditor.CaretOffset = TxtEditor.Text.Length;
		KsILHWjtjGn.VarKey = "";
		C6LLsFKX36N(false);
	}

	[CompilerGenerated]
	private void kVlLHRY2DDh(object sender, RoutedEventArgs e)
	{
		TextTools1.EditInExternalEditor(sender, e);
	}

	[CompilerGenerated]
	private bool m0uLHqHV4eR(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (!variableOrValueSelectItem_0.IsVariable)
		{
			return variableOrValueSelectItem_0.Key == KsILHWjtjGn.Value;
		}
		return false;
	}

	[CompilerGenerated]
	private bool dHkLHcVHBHa(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.IsVariable)
		{
			return variableOrValueSelectItem_0.Key == KsILHWjtjGn.VarKey;
		}
		return false;
	}

	[CompilerGenerated]
	private bool SxgLHVbLuZP(ActionVariable actionVariable_0)
	{
		return actionVariable_0.Key == KsILHWjtjGn.VarKey;
	}

	[CompilerGenerated]
	private bool MpKLHZbj0GV(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.IsVariable)
		{
			return false;
		}
		return variableOrValueSelectItem_0.Key == KsILHWjtjGn.Value;
	}

	[CompilerGenerated]
	private void XlOLH9BQV4N()
	{
		Thread.Sleep(50);
		base.Dispatcher.InvokeAsync(EIYLHhm11OQ);
	}

	[CompilerGenerated]
	private void EIYLHhm11OQ()
	{
		TxtEditor.Focus();
	}

	internal static bool fenqDUFa5KRVl0JWIene()
	{
		return ds4JUxFaZYcQpMPkakLk == null;
	}
}
