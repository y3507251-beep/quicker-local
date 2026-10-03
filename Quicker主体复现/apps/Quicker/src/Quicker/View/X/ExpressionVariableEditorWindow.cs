using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Common.Vm.Expression;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.View.X;

public class ExpressionVariableEditorWindow : Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec S7EST9od2TM;

		public static Func<VarTypeItem, bool> HZgSThWjNFB;

		private static _003C_003Ec sMfhYLW7vAX4WomNFudc;

		static _003C_003Ec()
		{
			S7EST9od2TM = new _003C_003Ec();
		}

		internal bool pQDSTZn9lwn(VarTypeItem x)
		{
			return x.VarType == VarType.Any;
		}

		internal static void gE701jW7J519g931twkA()
		{
		}

		internal static bool W5kXDlW7dijSwhOVSTmR()
		{
			return sMfhYLW7vAX4WomNFudc == null;
		}
	}

	private readonly ObservableCollection<VarTypeItem> Xe2LhGggSan = new ObservableCollection<VarTypeItem>();

	[CompilerGenerated]
	private ExpressionInputParam nefLhs1Oxyp;

	[CompilerGenerated]
	private ExpressionInputParam gcRLhHP1AnP = new ExpressionInputParam();

	[CompilerGenerated]
	private IEnumerable<ExpressionInputParam> rQlLh1IVesF;

	[CompilerGenerated]
	private VarType? JqDLhb5a4u9;

	[CompilerGenerated]
	private bool? KtsLh6Yci7K;

	internal TextBox TxtKey;

	internal ComboBox CbType;

	internal TextBox TxtDesc;

	internal TextBox TxtDefaultValue;

	internal MenuItem MenuEditInEditor1;

	internal Button BtnEditInCode;

	internal CheckBox ChkIsKeyParam;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool JmdLhXJovOk;

	internal static ExpressionVariableEditorWindow vba6vGFOQD6Q7oQSY4uq;

	public ExpressionInputParam EditingVariable
	{
		[CompilerGenerated]
		get
		{
			return nefLhs1Oxyp;
		}
		[CompilerGenerated]
		set
		{
			nefLhs1Oxyp = value;
		}
	}

	public ExpressionInputParam ResultVariable
	{
		[CompilerGenerated]
		get
		{
			return gcRLhHP1AnP;
		}
		[CompilerGenerated]
		set
		{
			gcRLhHP1AnP = value;
		}
	}

	public IEnumerable<ExpressionInputParam> CurrentVariables
	{
		[CompilerGenerated]
		get
		{
			return rQlLh1IVesF;
		}
		[CompilerGenerated]
		set
		{
			rQlLh1IVesF = value;
		}
	}

	public VarType? PresetVarType
	{
		[CompilerGenerated]
		get
		{
			return JqDLhb5a4u9;
		}
		[CompilerGenerated]
		set
		{
			JqDLhb5a4u9 = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return KtsLh6Yci7K;
		}
		[CompilerGenerated]
		set
		{
			KtsLh6Yci7K = value;
		}
	}

	public ExpressionVariableEditorWindow(IEnumerable<ExpressionInputParam> currentVariables)
	{
		InitializeComponent();
		CurrentVariables = currentVariables;
		CbType.ItemsSource = Xe2LhGggSan;
		base.Loaded += FcFLhRyEyER;
	}

	private void FcFLhRyEyER(object sender, RoutedEventArgs e)
	{
		Q8JLhqtBbAC();
		if (EditingVariable != null)
		{
			TxtDesc.Text = EditingVariable.Description;
			TxtKey.Text = EditingVariable.Key;
			TxtDefaultValue.Text = EditingVariable.SampleValue;
			CbType.SelectedItem = Xe2LhGggSan.FirstOrDefault(ceqLhYdQ9VX);
			ChkIsKeyParam.IsChecked = EditingVariable.IsKeyParam;
			ResultVariable = AppHelper.Clone(EditingVariable);
		}
		else if (PresetVarType.HasValue)
		{
			int num = 0;
			if (!vefYi3FOF1N8eqAxyv9P())
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					CbType.SelectedItem = Xe2LhGggSan.FirstOrDefault(n0OLhIGGwSd);
					if (CbType.SelectedItem != null)
					{
						break;
					}
					num = 1;
					if (vba6vGFOQD6Q7oQSY4uq == null)
					{
						continue;
					}
					goto case 1;
				case 1:
					CbType.SelectedItem = Xe2LhGggSan.FirstOrDefault(_003C_003Ec.HZgSThWjNFB ?? (_003C_003Ec.HZgSThWjNFB = _003C_003Ec.S7EST9od2TM.pQDSTZn9lwn));
					break;
				}
				break;
			}
		}
		else
		{
			CbType.SelectedIndex = 0;
		}
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
		if (EditingVariable == null && !string.IsNullOrEmpty(TxtKey.Text))
		{
			TxtKey.SelectAll();
		}
	}

	private void Q8JLhqtBbAC()
	{
		int num = 1;
		while (true)
		{
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Text,
				Name = "文本",
				Description = "文本字符串"
			});
			int num2 = 0;
			if (!vefYi3FOF1N8eqAxyv9P())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Image,
				Name = "图片",
				Description = "图片内容"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Boolean,
				Name = "布尔",
				Description = "布尔（True/False）类型"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Number,
				Name = "数字",
				Description = "数字类型(小数数字)"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Integer,
				Name = "数字(整数)",
				Description = "数字类型(整数数字)"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.DateTime,
				Name = "日期时间",
				Description = "日期和时间类型"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.List,
				Name = "列表",
				Description = "文本列表，如选中的多个文件等"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Dict,
				Name = "词典",
				Description = "键-值对类型"
			});
			Xe2LhGggSan.Add(new VarTypeItem
			{
				VarType = VarType.Any,
				Name = "动态对象",
				Description = "任意的C#对象"
			});
			return;
		}
	}

	private void II8LhcxkXnY(object sender, RoutedEventArgs e)
	{
		if (oXDLhZQt6Qc(TxtKey))
		{
			string text = TxtKey.Text.Trim();
			int num;
			if (!zqKLhV62ng2(text))
			{
				AppHelper.ShowWarning("不能使用这个变量名。\r\n请使用英文字母或下划线开始的字符串作为变量名，不能有空格或其他特殊字符。\r\n在需要的时候也可以使用中文。", true);
				TxtKey.Focus();
				num = 1;
				if (vba6vGFOQD6Q7oQSY4uq != null)
				{
					int num2 = default(int);
					num = num2;
				}
			}
			else
			{
				ResultVariable.Key = text;
				ResultVariable.VarType = (CbType.SelectedItem as VarTypeItem).VarType;
				ResultVariable.Description = TxtDesc.Text;
				ResultVariable.SampleValue = TxtDefaultValue.Text;
				num = 0;
				if (!vefYi3FOF1N8eqAxyv9P())
				{
					goto IL_00cc;
				}
			}
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_00cc;
		}
		MessageBoxHelper.Show(this, "请输入变量名称！");
		return;
		IL_00cc:
		ResultVariable.IsKeyParam = ChkIsKeyParam.IsChecked == true;
		if (EditingVariable != null)
		{
			if (CurrentVariables.Any(Ir9LhkRmvR2))
			{
				MessageBoxHelper.Show(this, "变量名已存在！");
				return;
			}
		}
		else if (CurrentVariables.Any(KlyLhWIdvnR))
		{
			MessageBoxHelper.Show(this, "变量名已存在！");
			return;
		}
		this.ThNvuM5Q9GQ(true);
	}

	private bool zqKLhV62ng2(string string_0)
	{
		return VariableEditorWindow.IsValidVarKey(string_0);
	}

	private bool oXDLhZQt6Qc(TextBox textBox_0)
	{
		if (string.IsNullOrEmpty(textBox_0.Text))
		{
			textBox_0.Focus();
			return false;
		}
		return true;
	}

	private void zsRLh9N0WOJ(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtDefaultValue);
	}

	private void CUOLhhB6cR0(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtDefaultValue);
	}

	private void oMLLhePgxeP(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!JmdLhXJovOk)
		{
			JmdLhXJovOk = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/expressiontester/expressionvariableeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			JmdLhXJovOk = true;
			break;
		case 1:
			TxtKey = (TextBox)target;
			break;
		case 2:
			CbType = (ComboBox)target;
			break;
		case 3:
			TxtDesc = (TextBox)target;
			break;
		case 4:
			TxtDefaultValue = (TextBox)target;
			break;
		case 5:
			MenuEditInEditor1 = (MenuItem)target;
			MenuEditInEditor1.Click += zsRLh9N0WOJ;
			break;
		case 6:
		{
			BtnEditInCode = (Button)target;
			int num = 0;
			if (vba6vGFOQD6Q7oQSY4uq != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnEditInCode.Click += CUOLhhB6cR0;
				break;
			}
			break;
		}
		case 7:
			ChkIsKeyParam = (CheckBox)target;
			break;
		case 8:
			BtnSave = (Button)target;
			BtnSave.Click += II8LhcxkXnY;
			break;
		case 9:
			BtnCancel = (Button)target;
			BtnCancel.Click += oMLLhePgxeP;
			break;
		}
	}

	[CompilerGenerated]
	private bool ceqLhYdQ9VX(VarTypeItem varTypeItem_0)
	{
		return varTypeItem_0.VarType == EditingVariable.VarType;
	}

	[CompilerGenerated]
	private bool n0OLhIGGwSd(VarTypeItem varTypeItem_0)
	{
		return varTypeItem_0.VarType == PresetVarType;
	}

	[CompilerGenerated]
	private bool KlyLhWIdvnR(ExpressionInputParam expressionInputParam_2)
	{
		return expressionInputParam_2.Key == ResultVariable.Key;
	}

	[CompilerGenerated]
	private bool Ir9LhkRmvR2(ExpressionInputParam expressionInputParam_2)
	{
		if (expressionInputParam_2 != EditingVariable)
		{
			return expressionInputParam_2.Key == ResultVariable.Key;
		}
		return false;
	}

	internal static bool vefYi3FOF1N8eqAxyv9P()
	{
		return vba6vGFOQD6Q7oQSY4uq == null;
	}
}
