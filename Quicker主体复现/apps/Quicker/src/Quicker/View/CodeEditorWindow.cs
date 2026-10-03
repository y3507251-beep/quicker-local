using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ejb3JZYiY7mfXrxejMO;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Indentation;
using ICSharpCode.AvalonEdit.Indentation.CSharp;
using j9PVNbXS3U4MP7j5Ps6;
using k7aPL5fDWhslvV5ur2A;
using log4net;
using Microsoft.Win32;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Vm.Expression;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Domain.ContextMenus;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.X;
using t7wokwYFlDgjUncgQNA;
using Z.Expressions;
using Z.Expressions.Compiler.Shared;

namespace Quicker.View;

public class CodeEditorWindow : Window, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec hPVSXcSp9IM;

		public static Func<ExpressionInputParam, bool> IpkSXVJVd2E;

		public static Func<ExpressionInputParam, bool> NYkSXZV8tQ5;

		public static Func<ExpressionInputParam, string> SCtSX92UxQE;

		private static _003C_003Ec INBNJmWZENOlEGMfWCUM;

		static _003C_003Ec()
		{
			hPVSXcSp9IM = new _003C_003Ec();
		}

		internal bool mfsSX7ptRTp(ExpressionInputParam x)
		{
			return x.Key == "quicker_in_param";
		}

		internal bool qB2SXR9ati9(ExpressionInputParam x)
		{
			return x.Key == "[cliptext]";
		}

		internal string Jp0SXqoaAU5(ExpressionInputParam x)
		{
			return x.Key;
		}

		internal static bool hU42hlWZG4W5qV2sWIu3()
		{
			return INBNJmWZENOlEGMfWCUM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass68_0
	{
		public ActionVariable Lo6SXeZlmfE;

		internal static _003C_003Ec__DisplayClass68_0 i9EjVrWZ1O4L7ujvFeSA;

		internal bool N5nSXhVP3cV(ExpressionInputParam x)
		{
			return x.Key == Lo6SXeZlmfE.Key;
		}

		internal static bool XjBqs7WZK2ZdKbbo7GaE()
		{
			return i9EjVrWZ1O4L7ujvFeSA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_0
	{
		public CodeEditorWindow RIkSXItmfPV;

		public IDictionary<string, object> QXvSXWCk5d3;

		private static _003C_003Ec__DisplayClass72_0 OA0GMIWZvyS6iy4oXY74;

		internal object o9PSXYle58o(ExpressionInputParam x)
		{
			_003C_003Ec__DisplayClass72_1 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_1
			{
				x = x
			};
			object obj = null;
			DataTable dataTable;
			if (_003C_003Ec__DisplayClass72_.x.VarType == VarType.Table)
			{
				dataTable = new DataTable();
				if (OA0GMIWZvyS6iy4oXY74 == null)
				{
					switch (1)
					{
					case 1:
						break;
					default:
						goto IL_0092;
					}
					ActionVariable actionVariable = RIkSXItmfPV.hu0gnOR4qe1.FirstOrDefault(_003C_003Ec__DisplayClass72_.A68SXkWnwWd);
					if (actionVariable?.TableDef != null)
					{
						zsVr57XToYMFTdxtZho.aNOghYZ7hRs(dataTable, actionVariable.TableDef);
					}
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass72_.x.SampleValue))
					{
						goto IL_00a3;
					}
				}
				goto IL_0092;
			}
			obj = VariableHelper.ConvertVarDefaultValue(_003C_003Ec__DisplayClass72_.x.VarType, _003C_003Ec__DisplayClass72_.x.SampleValue);
			goto IL_00c3;
			IL_0092:
			dataTable.mFighIebWbm(_003C_003Ec__DisplayClass72_.x.SampleValue);
			goto IL_00a3;
			IL_00c3:
			if (obj is long num && num > -2147483648L && num < 2147483647L)
			{
				obj = (int)num;
			}
			return obj;
			IL_00a3:
			obj = dataTable;
			goto IL_00c3;
		}

		internal static bool DwAUTQWZd4BSiJppw02J()
		{
			return OA0GMIWZvyS6iy4oXY74 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_1
	{
		public ExpressionInputParam x;

		internal static _003C_003Ec__DisplayClass72_1 P68U6NWZaaegHa975kEA;

		internal bool A68SXkWnwWd(ActionVariable v)
		{
			return v.Key == x.Key;
		}

		internal static bool FYWNHxWZrKp91MlIZUwn()
		{
			return P68U6NWZaaegHa975kEA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_2
	{
		public string n12SXsQVKJP;

		public _003C_003Ec__DisplayClass72_0 JbNSXHuiFGn;

		internal static _003C_003Ec__DisplayClass72_2 UE7de3WZ9c9cefPRQGYC;

		internal void bkASXGlyR6q()
		{
			try
			{
				object obj = JbNSXHuiFGn.RIkSXItmfPV.jXPgnfLYwTa.Execute(n12SXsQVKJP, JbNSXHuiFGn.QXvSXWCk5d3);
				JbNSXHuiFGn.RIkSXItmfPV.EvalResult = obj;
				if (obj == null)
				{
					JbNSXHuiFGn.RIkSXItmfPV.VtGg4w57MtQ = false;
					JbNSXHuiFGn.RIkSXItmfPV.cQsgnp1EGqm("null");
					return;
				}
				JbNSXHuiFGn.RIkSXItmfPV.VtGg4w57MtQ = false;
				JbNSXHuiFGn.RIkSXItmfPV.eyMgnz94cHb = new ExpressionSampleResult
				{
					TypeName = obj.GetType().FullName,
					StrValue = VariableHelper.ConvertToType(VarType.Text, obj).ToString(),
					ObjValue = obj
				};
				StringBuilder stringBuilder = new StringBuilder();
				int num = 0;
				if (UE7de3WZ9c9cefPRQGYC == null)
				{
					goto IL_00d4;
				}
				goto IL_024c;
				IL_024c:
				switch (num)
				{
				case 1:
					break;
				default:
					return;
				}
				goto IL_00d4;
				IL_00d4:
				if (!JbNSXHuiFGn.RIkSXItmfPV.PlKgnriUGgE(obj.GetType()) && !(obj is Delegate))
				{
					JbNSXHuiFGn.RIkSXItmfPV.QHpg4gSbxlb = JbNSXHuiFGn.RIkSXItmfPV.eyMgnz94cHb.StrValue;
					JbNSXHuiFGn.RIkSXItmfPV.QIgg4LZXZX3 = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
					{
						ReferenceLoopHandling = ReferenceLoopHandling.Ignore
					});
					stringBuilder.AppendLine("==Text==");
					stringBuilder.AppendLine(JbNSXHuiFGn.RIkSXItmfPV.QHpg4gSbxlb);
					stringBuilder.AppendLine();
					stringBuilder.AppendLine("==Json==");
					stringBuilder.AppendLine(JbNSXHuiFGn.RIkSXItmfPV.QIgg4LZXZX3);
				}
				else
				{
					JbNSXHuiFGn.RIkSXItmfPV.QHpg4gSbxlb = JbNSXHuiFGn.RIkSXItmfPV.eyMgnz94cHb.StrValue;
					stringBuilder.AppendLine(JbNSXHuiFGn.RIkSXItmfPV.QHpg4gSbxlb);
				}
				stringBuilder.AppendLine();
				stringBuilder.AppendLine("----");
				stringBuilder.AppendLine(obj.GetType().CSharpTypeToVarType().GetEnumDisplayName() + " (C#类型：" + obj.GetType().Name + ")");
				JbNSXHuiFGn.RIkSXItmfPV.cQsgnp1EGqm(stringBuilder.ToString());
				num = 0;
				if (UE7de3WZ9c9cefPRQGYC != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_024c;
			}
			catch (NullReferenceException ex)
			{
				JbNSXHuiFGn.RIkSXItmfPV.cQsgnp1EGqm("Error：解析表达式错误。" + ex.Message);
			}
			catch (EvalException ex2)
			{
				JbNSXHuiFGn.RIkSXItmfPV.cQsgnp1EGqm("Error：解析表达式错误。\n" + ex2.Message + "\n开始位置：" + ex2.StartPosition);
			}
			catch (Exception exception)
			{
				JbNSXHuiFGn.RIkSXItmfPV.cQsgnp1EGqm("Error：解析表达式错误。\n" + exception.GetMessageWithInner());
			}
		}

		internal static bool nVpQEiWZLEP5VmoVoeUM()
		{
			return UE7de3WZ9c9cefPRQGYC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_0
	{
		public CodeEditorWindow TS9SXbhJfEM;

		public string kt8SX6GYiig;

		internal static _003C_003Ec__DisplayClass78_0 yOkkYAWZb6JcY3qEtbWQ;

		internal void k7jSX1TbQXr()
		{
			TS9SXbhJfEM.TxtResult.Text = kt8SX6GYiig;
			TS9SXbhJfEM.BtnCopyText.IsEnabled = !string.IsNullOrEmpty(TS9SXbhJfEM.QHpg4gSbxlb);
			TS9SXbhJfEM.BtnCopyJson.IsEnabled = !string.IsNullOrEmpty(TS9SXbhJfEM.QIgg4LZXZX3);
		}

		internal static bool j69nWfWZqf406gwoKFpg()
		{
			return yOkkYAWZb6JcY3qEtbWQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass86_0
	{
		public ExpressionInputParam JyWSXm4EWfA;

		private static _003C_003Ec__DisplayClass86_0 fvpDFgWZZuxsfB0DMlTA;

		internal bool bQDSXXAYpxc(ActionVariable x)
		{
			return x.Key == JyWSXm4EWfA.Key;
		}

		internal static bool K0JoAoWZ5ZGorBs4J34B()
		{
			return fvpDFgWZZuxsfB0DMlTA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass89_0
	{
		public ExpressionInputParam SwZSXxVNYST;

		internal static _003C_003Ec__DisplayClass89_0 j2pSuoWZRol18wptSrc5;

		internal bool BmZSXKtbATJ(ActionVariable x)
		{
			return x.Key == SwZSXxVNYST.Key;
		}

		internal static bool CTHNNLWZgnjilVn9Svfj()
		{
			return j2pSuoWZRol18wptSrc5 == null;
		}
	}

	private static readonly ILog L86gnAhYyUD;

	private readonly ICollection<ActionVariable> hu0gnOR4qe1;

	private readonly string dXSgnFO0aJ8;

	public static readonly DependencyProperty SelectedHighlightingDefinitionProperty;

	private object q7MgnUaO5gD;

	private FoldingManager Sb8gnlZg5Ol;

	private string vhUgni7Sd46;

	public static readonly DependencyProperty EnableExpressionTesterProperty;

	public static readonly DependencyProperty ExpressionTesterIsOnProperty;

	private DebounceDispatcher G0ngn3yYf48 = new DebounceDispatcher();

	private EvalContext jXPgnfLYwTa = EvalManager.DefaultContext.Clone();

	private ExpressionSampleResult eyMgnz94cHb;

	private bool VtGg4w57MtQ = true;

	private FullyObservableCollection<ExpressionInputParam> QLmg4t1dqDU = new FullyObservableCollection<ExpressionInputParam>();

	private string QHpg4gSbxlb = "";

	private string QIgg4LZXZX3 = "";

	[CompilerGenerated]
	private object p7dg4vdndhl;

	internal CodeEditorWindow TheWindow;

	internal Grid WrapperGrid;

	internal ComboBox highlightingComboBox;

	internal Button BtnSave;

	internal Button BtnOpen;

	internal ToggleButton BtnEnableTester;

	internal CodeEditor textEditor;

	internal MenuItem MenuInsertVariable;

	internal MenuItem MenuInsertIcon;

	internal MenuItem MenuInsertNetworkIcon;

	internal MenuItem MenuTextProcess;

	internal MenuItem MenuComment;

	internal MenuItem MenuUnComment;

	internal MenuItem MenuIndent;

	internal MenuItem MenuFold;

	internal MenuItem MenuRegAssembly;

	internal Button BtnNewVar;

	internal ListBox LbVariables;

	internal CodeEditor TxtResult;

	internal Button BtnCopyText;

	internal Button BtnCopyJson;

	internal Button BtnShowInEditor;

	private bool qHsg4SJ2WBE;

	private static CodeEditorWindow y1A8pdFVJk4hNKGIOHj2;

	public string Text
	{
		get
		{
			return textEditor.Text;
		}
		set
		{
			textEditor.Text = value;
		}
	}

	public IList<string> HighlightingDefinitions => UGNZKrYVGqgfWZbLcQj.HighlightingDefinitionNames;

	public string SelectedHighlightingDefinition
	{
		get
		{
			return (string)GetValue(SelectedHighlightingDefinitionProperty);
		}
		set
		{
			SetValue(SelectedHighlightingDefinitionProperty, value);
		}
	}

	public bool WordWrap
	{
		get
		{
			return textEditor.WordWrap;
		}
		set
		{
			textEditor.WordWrap = value;
		}
	}

	public bool EnableExpressionTester
	{
		get
		{
			return (bool)GetValue(EnableExpressionTesterProperty);
		}
		set
		{
			SetValue(EnableExpressionTesterProperty, value);
		}
	}

	public bool ExpressionTesterIsOn
	{
		get
		{
			return (bool)GetValue(ExpressionTesterIsOnProperty);
		}
		set
		{
			SetValue(ExpressionTesterIsOnProperty, value);
		}
	}

	public EvalContext EvalContext
	{
		get
		{
			return jXPgnfLYwTa;
		}
		set
		{
			jXPgnfLYwTa = value;
		}
	}

	public object EvalResult
	{
		[CompilerGenerated]
		get
		{
			return p7dg4vdndhl;
		}
		[CompilerGenerated]
		set
		{
			p7dg4vdndhl = value;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private static void c04gnNmRjNV(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		((CodeEditorWindow)dependencyObject_0).qCRgnJeeBqB();
	}

	private void qCRgnJeeBqB()
	{
		textEditor.SyntaxHighlighting = UGNZKrYVGqgfWZbLcQj.fvHLxy2feEY(SelectedHighlightingDefinition);
		if (SelectedHighlightingDefinition == "QuickerExpression")
		{
			textEditor.DefaultHighlightType = null;
			textEditor.AutoChangeHighlighting = true;
			if (textEditor.IsLoaded)
			{
				textEditor.UpdateEditorHighlighting();
			}
		}
		else
		{
			textEditor.AutoChangeHighlighting = false;
		}
	}

	public CodeEditorWindow(ICollection<ActionVariable> variables, bool autoChangeHighlighting, string defaultHighlightType)
	{
		hu0gnOR4qe1 = variables;
		dXSgnFO0aJ8 = defaultHighlightType;
		InitializeComponent();
		base.Loaded += ubjgnElDHwq;
		sBZgnyjJkpG();
		MEPgnPOVgNY();
		base.DataContext = this;
		textEditor.ActionVariables = hu0gnOR4qe1;
		if (hu0gnOR4qe1 == null)
		{
			BtnNewVar.Visibility = Visibility.Collapsed;
		}
		textEditor.TextArea.SelectionChanged += Y3egnCnNXZa;
		Brush brush = (TryFindResource("ReverseMaskBrush2") as Brush) ?? Brushes.DarkGray;
		textEditor.TextArea.TextView.LineTransformers.Add(new ColorizeAvalonEdit(textEditor, brush));
		textEditor.TextChanged += Tnqgn0mAoOj;
		nU4gn7KNw4e();
		LbVariables.ItemsSource = QLmg4t1dqDU;
		QLmg4t1dqDU.ItemPropertyChanged += Vbwgn6OtPcq;
		dVngnbkUKsO();
		textEditor.NvPLK8JcZm3();
	}

	private void Tnqgn0mAoOj(object sender, EventArgs e)
	{
		KJcgnRI8sM1();
		dVngnbkUKsO();
	}

	private void Y3egnCnNXZa(object sender, EventArgs e)
	{
		textEditor.TextArea.TextView.Redraw();
	}

	private void MEPgnPOVgNY()
	{
		base.CommandBindings.AddKeyGesture(new KeyGesture(Key.Oem2, ModifierKeys.Control), QJtgnMfeQGo);
	}

	private void ubjgnElDHwq(object sender, RoutedEventArgs e)
	{
		SelectedHighlightingDefinition = dXSgnFO0aJ8.Or("QuickerExpression");
		textEditor.Focus();
		textEditor.CaretOffset = textEditor.Text.Length;
		if (textEditor.Text.Contains("Delete"))
		{
			EnableExpressionTester = false;
		}
	}

	private void sBZgnyjJkpG()
	{
		if (hu0gnOR4qe1 == null)
		{
			MenuInsertVariable.IsEnabled = false;
			return;
		}
		foreach (ActionVariable item in hu0gnOR4qe1.Union(new ActionVariable[2]
		{
			new ActionVariable
			{
				Key = "[cliptext]",
				Type = VarType.Text,
				Desc = "*剪贴板文本*"
			},
			new ActionVariable
			{
				Key = "quicker_in_param",
				Type = VarType.Text,
				Desc = "*动作参数*"
			}
		}))
		{
			MenuItem menuItem = new MenuItem
			{
				Header = ((!string.IsNullOrEmpty(item.Desc)) ? (item.Key.Replace("_", "__") + " (" + item.Desc + ")") : item.Key.Replace("_", "__")),
				Tag = item.Key,
				Icon = new IconControl
				{
					Width = 16.0,
					Height = 16.0,
					Icon = AppHelper.GetVarTypeIconStr(item.Type)
				}
			};
			menuItem.Click += sfggn8IlxEi;
			MenuInsertVariable.Items.Add(menuItem);
		}
	}

	private void sfggn8IlxEi(object sender, RoutedEventArgs e)
	{
		string text = (sender as MenuItem).Tag as string;
		textEditor.dkOLiRNGFGf("{" + text + "}");
	}

	private void N5JgnaeVMMj(object sender, SelectionChangedEventArgs e)
	{
		nU4gn7KNw4e();
	}

	private void nU4gn7KNw4e()
	{
		if (textEditor.SyntaxHighlighting == null)
		{
			q7MgnUaO5gD = null;
		}
		else
		{
			textEditor.TextArea.IndentationStrategy = new DefaultIndentationStrategy();
			q7MgnUaO5gD = textEditor.yitLi90LyKV();
		}
		if (q7MgnUaO5gD != null)
		{
			if (Sb8gnlZg5Ol == null)
			{
				Sb8gnlZg5Ol = FoldingManager.Install(textEditor.TextArea);
				int num = 0;
				if (!lfDSDRFVkX5iLqHep21S())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			KJcgnRI8sM1();
		}
		else if (Sb8gnlZg5Ol != null)
		{
			FoldingManager.Uninstall(Sb8gnlZg5Ol);
			Sb8gnlZg5Ol = null;
		}
	}

	private void KJcgnRI8sM1()
	{
		if (q7MgnUaO5gD != null)
		{
			if (q7MgnUaO5gD is BraceFoldingStrategy)
			{
				((BraceFoldingStrategy)q7MgnUaO5gD).UpdateFoldings(Sb8gnlZg5Ol, textEditor.Document);
			}
			if (q7MgnUaO5gD is XmlFoldingStrategy)
			{
				((XmlFoldingStrategy)q7MgnUaO5gD).UpdateFoldings(Sb8gnlZg5Ol, textEditor.Document);
			}
		}
	}

	private void xlwgnq4nwUW()
	{
		DocumentLine lineByOffset = textEditor.Document.GetLineByOffset(textEditor.SelectionStart);
		if (GZggnhHQ3Tq(lineByOffset) >= 0)
		{
			vLygnZ0FZPM();
		}
		else
		{
			Comment();
		}
	}

	private void WUtgncURbi3(object sender, RoutedEventArgs e)
	{
		Comment();
	}

	private void Comment()
	{
		TextDocument document = textEditor.Document;
		DocumentLine lineByOffset = document.GetLineByOffset(textEditor.SelectionStart);
		DocumentLine lineByOffset2 = document.GetLineByOffset(textEditor.SelectionStart + textEditor.SelectionLength);
		using (document.RunUpdate())
		{
			DocumentLine documentLine = lineByOffset;
			while (documentLine != null && documentLine.LineNumber <= lineByOffset2.LineNumber)
			{
				document.Insert(documentLine.Offset, Tpkgn9q4k1e());
				documentLine = documentLine.NextLine;
			}
		}
	}

	private void D8FgnVGr1xJ(object sender, RoutedEventArgs e)
	{
		vLygnZ0FZPM();
	}

	private void vLygnZ0FZPM()
	{
		TextDocument document = textEditor.Document;
		DocumentLine lineByOffset = document.GetLineByOffset(textEditor.SelectionStart);
		DocumentLine lineByOffset2 = document.GetLineByOffset(textEditor.SelectionStart + textEditor.SelectionLength);
		using (document.RunUpdate())
		{
			DocumentLine documentLine = lineByOffset;
			while (documentLine != null && documentLine.LineNumber <= lineByOffset2.LineNumber)
			{
				int num = GZggnhHQ3Tq(documentLine);
				if (num >= 0)
				{
					document.Remove(documentLine.Offset + num, Tpkgn9q4k1e().Length);
				}
				documentLine = documentLine.NextLine;
			}
		}
	}

	private string Tpkgn9q4k1e()
	{
		int num = 2;
		while (true)
		{
			string text = SelectedHighlightingDefinition.ToLower();
			int num2 = 1;
			if (!lfDSDRFVkX5iLqHep21S())
			{
				goto IL_0074;
			}
			goto IL_00a9;
			IL_00a9:
			switch (num2)
			{
			case 5:
				break;
			case 1:
				goto IL_0032;
			default:
				goto IL_0074;
			case 2:
				continue;
			case 4:
				goto IL_023e;
			case 3:
				goto IL_024c;
			}
			goto IL_000e;
			IL_0032:
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
					break;
				case 2:
					if (text == "vb")
					{
						return "'";
					}
					goto IL_024c;
				case 4:
					goto IL_0140;
				case 5:
					goto IL_0189;
				case 6:
					goto IL_01be;
				case 10:
					goto IL_01fe;
				default:
					goto IL_024c;
				}
				goto IL_0074;
			}
			goto IL_024c;
			IL_024c:
			return "//";
			IL_01fe:
			switch (text[0])
			{
			case 'p':
				if (text == "powershell")
				{
					return "#";
				}
				break;
			case 'j':
				if (text == "javascript")
				{
					return "//";
				}
				break;
			}
			goto IL_024c;
			IL_01be:
			switch (text[0])
			{
			case 's':
				if (text == "scheme")
				{
					return ";";
				}
				break;
			case 'p':
				if (text == "python")
				{
					return "#";
				}
				break;
			}
			goto IL_024c;
			IL_0189:
			char c = text[0];
			if (c != 'p')
			{
				if (c == 's')
				{
					goto IL_023e;
				}
			}
			else if (text == "plsql")
			{
				return "--";
			}
			goto IL_024c;
			IL_0140:
			switch (text[0])
			{
			case 'r':
				if (text == "ruby")
				{
					return "#";
				}
				break;
			case 'p':
				if (text == "perl")
				{
					return "#";
				}
				break;
			}
			goto IL_024c;
			IL_023e:
			if (text == "scala")
			{
				return "//";
			}
			goto IL_024c;
			IL_000e:
			if (text == "php")
			{
				break;
			}
			num2 = 3;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				num2 = num;
			}
			goto IL_00a9;
			IL_0074:
			switch (text[0])
			{
			case 'p':
				break;
			case 's':
				if (text == "sql")
				{
					return "--";
				}
				goto IL_024c;
			case 't':
				if (text == "tex")
				{
					return "%";
				}
				goto IL_024c;
			case 'v':
				if (text == "vtl")
				{
					return "##";
				}
				goto IL_024c;
			default:
				goto IL_024c;
			}
			goto IL_000e;
		}
		return "//";
	}

	private int GZggnhHQ3Tq(DocumentLine documentLine_0)
	{
		int num = 0;
		for (num = 0; num < documentLine_0.Length && char.IsWhiteSpace(textEditor.Document.GetCharAt(documentLine_0.Offset + num)); num++)
		{
		}
		if (num > documentLine_0.Length - 2)
		{
			return -1;
		}
		bool flag = true;
		string text = Tpkgn9q4k1e();
		int num3 = default(int);
		for (int i = 0; i < text.Length; i++)
		{
			if (textEditor.Document.GetCharAt(documentLine_0.Offset + num + i) == text[i])
			{
				continue;
			}
			int num2 = 1;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				continue;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = false;
					num2 = 0;
					if (!lfDSDRFVkX5iLqHep21S())
					{
						num2 = num3;
					}
					continue;
				}
				break;
			}
		}
		if (flag)
		{
			return num;
		}
		return -1;
	}

	private int aiNgneaRmsK(DocumentLine documentLine_0)
	{
		int num = 0;
		for (num = 0; num < documentLine_0.Length && char.IsWhiteSpace(textEditor.Document.GetCharAt(documentLine_0.Offset + num)); num++)
		{
		}
		if (num > documentLine_0.Length - 1)
		{
			return 0;
		}
		return num;
	}

	private void qITgnYuQZT5(object sender, RoutedEventArgs e)
	{
		if (vhUgni7Sd46 == null)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.DefaultExt = ".txt";
			if (saveFileDialog.ShowDialog() != true)
			{
				return;
			}
			vhUgni7Sd46 = saveFileDialog.FileName;
		}
		try
		{
			textEditor.Save(vhUgni7Sd46);
		}
		catch (Exception ex)
		{
			string message = "保存文件出错！" + ex.Message;
			L86gnAhYyUD.Warn(message, ex);
			AppHelper.ShowWarning(message, true);
		}
	}

	private void GdggnI2uuDT(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.CheckFileExists = true;
		if (openFileDialog.ShowDialog() == true)
		{
			try
			{
				vhUgni7Sd46 = openFileDialog.FileName;
				textEditor.Load(vhUgni7Sd46);
				textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(Path.GetExtension(vhUgni7Sd46));
			}
			catch (Exception ex)
			{
				string message = "打开文件出错！" + ex.Message;
				L86gnAhYyUD.Warn(message, ex);
				AppHelper.ShowWarning(message, true);
			}
		}
	}

	private void IergnWs8cNW(object sender, RoutedEventArgs e)
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow
		{
			Owner = this
		};
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			textEditor.dkOLiRNGFGf("fa:" + faIconSelectorWindow.SelectedIcon);
		}
	}

	private void wiBgnkYUaST(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
			e.Handled = true;
			if (lfDSDRFVkX5iLqHep21S())
			{
				switch (0)
				{
				}
			}
		}
		else if (e.Key == Key.OemPlus && Keyboard.Modifiers == ModifierKeys.Control)
		{
			if (textEditor.FontSize < 30.0)
			{
				textEditor.FontSize += 2.0;
			}
		}
		else if (e.Key == Key.OemMinus && Keyboard.Modifiers == ModifierKeys.Control && textEditor.FontSize > 6.0)
		{
			textEditor.FontSize -= 2.0;
		}
	}

	public void Indent()
	{
		textEditor.BeginChange();
		new CSharpIndentationStrategy().IndentLines(textEditor.Document, 0, textEditor.LineCount - 1);
		textEditor.EndChange();
	}

	private void JVCgnGYT5dK(object sender, RoutedEventArgs e)
	{
		Indent();
	}

	private void TextEditor_OnPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
	{
		if (MenuTextProcess.Items.IsEmpty)
		{
			ContentContextMenuService.BuildTextContextMenus(MenuTextProcess.Items, textEditor.SelectedText);
		}
	}

	private void XBygnsiKJP7(object sender, RoutedEventArgs e)
	{
		IconSelectorWindow iconSelectorWindow = new IconSelectorWindow();
		iconSelectorWindow.Owner = Window.GetWindow(this);
		if (iconSelectorWindow.ShowDialog() == true)
		{
			textEditor.dkOLiRNGFGf("url:" + iconSelectorWindow.SelectedIconUrl);
		}
	}

	private void fWjgnHr5mZA(object sender, RoutedEventArgs e)
	{
		if (Sb8gnlZg5Ol != null)
		{
			foreach (FoldingSection allFolding in Sb8gnlZg5Ol.AllFoldings)
			{
				allFolding.IsFolded = true;
			}
			return;
		}
		AppHelper.ShowWarning("折叠功能不可用，请更改高亮语法类型。");
	}

	private static void bWwgn1dsX9S(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		(dependencyObject_0 as CodeEditorWindow).dVngnbkUKsO();
	}

	private void dVngnbkUKsO()
	{
		bool flag = textEditor.Text.StartsWith("$=") || textEditor.Text.StartsWith("$$");
		ExpressionTesterIsOn = EnableExpressionTester && flag;
		if (ExpressionTesterIsOn)
		{
			MAngnXLKohg();
		}
		BtnEnableTester.Visibility = flag.ToVisibility();
	}

	private void Vbwgn6OtPcq(object sender, ItemPropertyChangedEventArgs e)
	{
		NN5gnKZ5mHc();
	}

	private void MAngnXLKohg()
	{
		if (ExpressionTesterIsOn)
		{
			W5GgnmcjC0a(textEditor.Text);
			NN5gnKZ5mHc();
		}
	}

	private void W5GgnmcjC0a(string string_4)
	{
		if (hu0gnOR4qe1.HasData())
		{
			using IEnumerator<ActionVariable> enumerator = hu0gnOR4qe1.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
				_003C_003Ec__DisplayClass68_.Lo6SXeZlmfE = enumerator.Current;
				if (!QLmg4t1dqDU.Any(_003C_003Ec__DisplayClass68_.N5nSXhVP3cV) && string_4.Contains("{" + _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.Key + "}"))
				{
					QLmg4t1dqDU.Add(new ExpressionInputParam
					{
						Key = _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.Key,
						Description = _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.Desc,
						VarType = _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.Type,
						SampleValue = _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.DefaultValue,
						IsKeyParam = (QLmg4t1dqDU.Count == 0),
						SaveState = _003C_003Ec__DisplayClass68_.Lo6SXeZlmfE.SaveState
					});
				}
			}
		}
		if (string_4.Contains("{quicker_in_param}"))
		{
			if (!lfDSDRFVkX5iLqHep21S())
			{
				switch (0)
				{
				}
			}
			if (!QLmg4t1dqDU.Any(_003C_003Ec.IpkSXVJVd2E ?? (_003C_003Ec.IpkSXVJVd2E = _003C_003Ec.hPVSXcSp9IM.mfsSX7ptRTp)))
			{
				QLmg4t1dqDU.Add(new ExpressionInputParam
				{
					Key = "quicker_in_param",
					Description = "动作参数",
					VarType = VarType.Text,
					SampleValue = "testvalue",
					IsKeyParam = false
				});
			}
		}
		if (string_4.Contains("{[cliptext]}") && !QLmg4t1dqDU.Any(_003C_003Ec.NYkSXZV8tQ5 ?? (_003C_003Ec.NYkSXZV8tQ5 = _003C_003Ec.hPVSXcSp9IM.qB2SXR9ati9)))
		{
			QLmg4t1dqDU.Add(new ExpressionInputParam
			{
				Key = "[cliptext]",
				Description = "剪贴板文本",
				VarType = VarType.Text,
				SampleValue = "demo clipboard text",
				IsKeyParam = false
			});
		}
	}

	private void NN5gnKZ5mHc()
	{
		G0ngn3yYf48.Debounce(1000, fcFgnx9TI2H);
	}

	private void fcFgnx9TI2H(object object_2)
	{
		int num = 2;
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			_003C_003Ec__DisplayClass72_0 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_0();
			int num2 = 1;
			if (!lfDSDRFVkX5iLqHep21S())
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass72_.RIkSXItmfPV = this;
					QHpg4gSbxlb = "";
					QIgg4LZXZX3 = "";
					EvalResult = null;
					num2 = 0;
					if (lfDSDRFVkX5iLqHep21S())
					{
						continue;
					}
					goto default;
				case 2:
					break;
				default:
					text = textEditor.Text;
					if (!string.IsNullOrEmpty(text) && (text.StartsWith("$=") || text.StartsWith("$$")))
					{
						_003C_003Ec__DisplayClass72_.QXvSXWCk5d3 = new Dictionary<string, object>();
						try
						{
							Dictionary<string, object> idictionary_ = QLmg4t1dqDU.ToDictionary(_003C_003Ec.SCtSX92UxQE ?? (_003C_003Ec.SCtSX92UxQE = _003C_003Ec.hPVSXcSp9IM.Jp0SXqoaAU5), _003C_003Ec__DisplayClass72_.o9PSXYle58o);
							if (text.StartsWith("$$"))
							{
								for (int i = 0; i < 2; i++)
								{
									if (text.StartsWith("$$"))
									{
										text = text.Substring(2);
										text = XActionHelper.xsVtDenQtcm(text, idictionary_, jXPgnfLYwTa);
									}
								}
								int num3 = 0;
								if (!lfDSDRFVkX5iLqHep21S())
								{
									num3 = num4;
								}
								switch (num3)
								{
								default:
									W5GgnmcjC0a(text);
									break;
								}
							}
						}
						catch (Exception ex)
						{
							cQsgnp1EGqm("Error：" + ex.Message);
							return;
						}
						goto case 3;
					}
					cQsgnp1EGqm("Error：表达式应该以$=开始");
					return;
				case 3:
					if (text.StartsWith("$="))
					{
						_003C_003Ec__DisplayClass72_2 _003C_003Ec__DisplayClass72_2 = new _003C_003Ec__DisplayClass72_2();
						_003C_003Ec__DisplayClass72_2.JbNSXHuiFGn = _003C_003Ec__DisplayClass72_;
						_003C_003Ec__DisplayClass72_2.n12SXsQVKJP = text.Substring(2);
						ActionExecuteContext actionExecuteContext = null;
						if (_003C_003Ec__DisplayClass72_2.n12SXsQVKJP.Contains("_context"))
						{
							actionExecuteContext = new ActionExecuteContext(new ActionItem
							{
								Id = "temp_action_id",
								Title = "临时动作"
							}, new PointTargetInfo(), AppState.AppServer, false, 0);
							_003C_003Ec__DisplayClass72_2.JbNSXHuiFGn.QXvSXWCk5d3.Add("_context", actionExecuteContext);
						}
						if (_003C_003Ec__DisplayClass72_2.n12SXsQVKJP.Contains("_eval"))
						{
							_003C_003Ec__DisplayClass72_2.JbNSXHuiFGn.QXvSXWCk5d3.Add("_eval", jXPgnfLYwTa);
						}
						foreach (ExpressionInputParam item in QLmg4t1dqDU)
						{
							try
							{
								string text2 = "v_" + item.Key;
								if (_003C_003Ec__DisplayClass72_2.n12SXsQVKJP.Contains("{" + item.Key + "}"))
								{
									if (item.Key == "[cliptext]")
									{
										text2 = "_cliptext_";
									}
									_003C_003Ec__DisplayClass72_2.n12SXsQVKJP = _003C_003Ec__DisplayClass72_2.n12SXsQVKJP.Replace("{" + item.Key + "}", text2);
									object value = _003C_003Ec__DisplayClass72_2.JbNSXHuiFGn.o9PSXYle58o(item);
									_003C_003Ec__DisplayClass72_2.JbNSXHuiFGn.QXvSXWCk5d3.Add(text2, value);
								}
							}
							catch (Exception ex2)
							{
								cQsgnp1EGqm("Error：解析变量值(" + item.Key + ")出错。" + ex2.Message);
								return;
							}
						}
						if (actionExecuteContext != null)
						{
							foreach (KeyValuePair<string, object> item2 in _003C_003Ec__DisplayClass72_2.JbNSXHuiFGn.QXvSXWCk5d3)
							{
								if (item2.Key != "_context" && item2.Key != "_eval" && item2.Key != "[cliptext]")
								{
									actionExecuteContext.CustomData.Add(item2);
								}
							}
						}
						Task.Run((Action)_003C_003Ec__DisplayClass72_2.bkASXGlyR6q);
					}
					else
					{
						EvalResult = text;
						cQsgnp1EGqm("插值结果：\n" + text);
					}
					return;
				}
				break;
			}
		}
	}

	private bool PlKgnriUGgE(Type type_0)
	{
		if (!type_0.IsPrimitive)
		{
			return type_0.Equals(typeof(string));
		}
		return true;
	}

	private void cQsgnp1EGqm(string string_4)
	{
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
		_003C_003Ec__DisplayClass78_.TS9SXbhJfEM = this;
		_003C_003Ec__DisplayClass78_.kt8SX6GYiig = string_4;
		base.Dispatcher.Invoke(_003C_003Ec__DisplayClass78_.k7jSX1TbQXr);
	}

	private void zF5gnBuWaWw(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.F2 && sender is TextBox textBox)
		{
			AppHelper.EditInCodeEditor(textBox);
		}
	}

	private void KbtgnQiDMaK(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(QHpg4gSbxlb))
		{
			ClipboardHelper.SetText(QHpg4gSbxlb);
			AppHelper.ShowSuccess("已复制。");
		}
		else
		{
			AppHelper.ShowWarning("没有可以复制的内容。");
		}
	}

	private void J4YgnjjCSpT(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(QIgg4LZXZX3))
		{
			AppHelper.ShowWarning("没有可以复制的内容。");
			return;
		}
		ClipboardHelper.SetText(QIgg4LZXZX3);
		AppHelper.ShowSuccess("已复制。");
	}

	private void bdtgnnqfBNK(object sender, RoutedEventArgs e)
	{
		AppHelper.ShowTextWindow("表达式结果", TxtResult.Text, this, false);
	}

	private void qwYgn4c0NLW(object sender, RoutedEventArgs e)
	{
		WrapperGrid.ColumnDefinitions[2].ClearValue(ColumnDefinition.WidthProperty);
	}

	private void TextEditor_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
	{
		if (Keyboard.Modifiers != ModifierKeys.Control)
		{
			return;
		}
		if (e.Delta > 0)
		{
			if (textEditor.FontSize < 40.0)
			{
				textEditor.FontSize++;
			}
		}
		else if (textEditor.FontSize > 6.0)
		{
			textEditor.FontSize--;
		}
	}

	private void jMxgn5mbtbH(object sender, RoutedEventArgs e)
	{
		MenuItem menuItem = sender as MenuItem;
		TextBox textBox = null;
		if (menuItem != null && ((ContextMenu)menuItem.Parent).PlacementTarget is TextBox textBox2)
		{
			AppHelper.EditInCodeEditor(textBox2);
		}
	}

	private void qsognDxZW5C(object sender, RoutedEventArgs e)
	{
		MenuItem menuItem = sender as MenuItem;
		TextBox textBox = null;
		if (menuItem == null || !(((ContextMenu)menuItem.Parent).PlacementTarget is TextBox textBox2))
		{
			return;
		}
		if (!lfDSDRFVkX5iLqHep21S())
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass86_0 _003C_003Ec__DisplayClass86_ = new _003C_003Ec__DisplayClass86_0();
		_003C_003Ec__DisplayClass86_.JyWSXm4EWfA = textBox2.Tag as ExpressionInputParam;
		if (_003C_003Ec__DisplayClass86_.JyWSXm4EWfA != null)
		{
			ActionVariable actionVariable = hu0gnOR4qe1.FirstOrDefault(_003C_003Ec__DisplayClass86_.bQDSXXAYpxc);
			if (actionVariable != null)
			{
				actionVariable.DefaultValue = textBox2.Text;
				AppHelper.ShowSuccess("更新变量 " + actionVariable.Key + " 的默认值成功。");
			}
		}
	}

	private void F6lgndpAZl4(object sender, RoutedEventArgs e)
	{
		ActionVariable actionVariable = XActionUiHelper.CreateVariable(Window.GetWindow(this), hu0gnOR4qe1, null);
		if (actionVariable != null)
		{
			QLmg4t1dqDU.Add(new ExpressionInputParam
			{
				Key = actionVariable.Key,
				Description = actionVariable.Desc,
				VarType = actionVariable.Type,
				SampleValue = actionVariable.DefaultValue,
				IsKeyParam = (QLmg4t1dqDU.Count == 0)
			});
		}
	}

	private void XNagnoYcPxy(object sender, RoutedEventArgs e)
	{
		UserInputWindow userInputWindow = new UserInputWindow("text", "请输入如下内容之一：\r\n程序集完整路径;\r\n已加载的程序集名称（如System.Windows.Forms);\r\nGAC程序集所包含的独特的命名空间", "", "");
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string text = userInputWindow.TextValue.Trim();
		if (text.IsNullOrEmpty())
		{
			AppHelper.ShowWarning("内容为空。");
			return;
		}
		try
		{
			Assembly assembly = G4VhktY7xL4iAHgxGcn.LC0L0NdjaV4(text);
			jXPgnfLYwTa.RegisterAssembly(assembly);
			AppHelper.ShowSuccess("注册成功。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("注册失败。" + ex.Message);
		}
	}

	private void tKvgnT0Eas3(object sender, RoutedEventArgs e)
	{
		TextBox textBox = default(TextBox);
		_003C_003Ec__DisplayClass89_0 _003C_003Ec__DisplayClass89_ = default(_003C_003Ec__DisplayClass89_0);
		while (true)
		{
			MenuItem menuItem = sender as MenuItem;
			int num = 0;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				goto IL_0003;
			}
			goto IL_003c;
			IL_003c:
			switch (num)
			{
			case 1:
				continue;
			case 2:
				goto IL_0067;
			}
			goto IL_0003;
			IL_0003:
			textBox = null;
			if (menuItem == null)
			{
				break;
			}
			textBox = ((ContextMenu)menuItem.Parent).PlacementTarget as TextBox;
			if (textBox == null)
			{
				break;
			}
			_003C_003Ec__DisplayClass89_ = new _003C_003Ec__DisplayClass89_0();
			num = 0;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				goto IL_003c;
			}
			goto IL_0067;
			IL_0067:
			_003C_003Ec__DisplayClass89_.SwZSXxVNYST = textBox.Tag as ExpressionInputParam;
			if (_003C_003Ec__DisplayClass89_.SwZSXxVNYST == null)
			{
				break;
			}
			ActionVariable actionVariable = hu0gnOR4qe1.FirstOrDefault(_003C_003Ec__DisplayClass89_.BmZSXKtbATJ);
			if (actionVariable == null || !actionVariable.SaveState || !(Window.GetWindow(this)?.Owner is ActionStepEditorWindow { Owner: ActionDesignerWindow { EditingActionItem: { } editingActionItem } }) || !(editingActionItem.Id != Guid.Empty.ToString()))
			{
				break;
			}
			(bool, string) tuple = ActionStateWriter.ReadActionStateValue(editingActionItem.Id, XActionRunner.GetVarStateKey(actionVariable.Key));
			if (!tuple.Item1)
			{
				break;
			}
			textBox.Text = tuple.Item2;
			AppHelper.ShowSuccess("加载变量 " + actionVariable.Key + " 的状态值成功。");
			return;
		}
		AppHelper.ShowWarning("未找到此变量的状态信息。");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!qHsg4SJ2WBE)
		{
			qHsg4SJ2WBE = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/codeeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			TheWindow = (CodeEditorWindow)target;
			TheWindow.KeyDown += wiBgnkYUaST;
			break;
		case 2:
			WrapperGrid = (Grid)target;
			break;
		case 3:
			((Button)target).Click += WUtgncURbi3;
			num = 3;
			if (!lfDSDRFVkX5iLqHep21S())
			{
				goto IL_01ab;
			}
			goto IL_026c;
		case 4:
			((Button)target).Click += D8FgnVGr1xJ;
			break;
		case 5:
			highlightingComboBox = (ComboBox)target;
			highlightingComboBox.SelectionChanged += N5JgnaeVMMj;
			break;
		case 6:
			BtnSave = (Button)target;
			BtnSave.Click += qITgnYuQZT5;
			break;
		case 7:
			BtnOpen = (Button)target;
			BtnOpen.Click += GdggnI2uuDT;
			break;
		case 8:
			BtnEnableTester = (ToggleButton)target;
			BtnEnableTester.Click += qwYgn4c0NLW;
			break;
		case 9:
			textEditor = (CodeEditor)target;
			break;
		case 10:
			MenuInsertVariable = (MenuItem)target;
			num = 1;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				goto IL_01ab;
			}
			goto IL_026c;
		case 11:
			MenuInsertIcon = (MenuItem)target;
			MenuInsertIcon.Click += IergnWs8cNW;
			break;
		case 12:
			MenuInsertNetworkIcon = (MenuItem)target;
			MenuInsertNetworkIcon.Click += XBygnsiKJP7;
			break;
		case 13:
			MenuTextProcess = (MenuItem)target;
			break;
		case 14:
			MenuComment = (MenuItem)target;
			MenuComment.Click += WUtgncURbi3;
			break;
		case 15:
			MenuUnComment = (MenuItem)target;
			MenuUnComment.Click += D8FgnVGr1xJ;
			break;
		case 16:
			MenuIndent = (MenuItem)target;
			num = 0;
			if (y1A8pdFVJk4hNKGIOHj2 != null)
			{
				goto IL_026c;
			}
			goto IL_0281;
		case 17:
			MenuFold = (MenuItem)target;
			MenuFold.Click += fWjgnHr5mZA;
			break;
		case 18:
			MenuRegAssembly = (MenuItem)target;
			MenuRegAssembly.Click += XNagnoYcPxy;
			break;
		case 19:
			BtnNewVar = (Button)target;
			BtnNewVar.Click += F6lgndpAZl4;
			break;
		case 20:
			LbVariables = (ListBox)target;
			break;
		default:
			qHsg4SJ2WBE = true;
			break;
		case 25:
			TxtResult = (CodeEditor)target;
			break;
		case 26:
			BtnCopyText = (Button)target;
			BtnCopyText.Click += KbtgnQiDMaK;
			break;
		case 27:
			BtnCopyJson = (Button)target;
			BtnCopyJson.Click += J4YgnjjCSpT;
			break;
		case 28:
			{
				BtnShowInEditor = (Button)target;
				BtnShowInEditor.Click += bdtgnnqfBNK;
				break;
			}
			IL_01ab:
			num = num2;
			goto IL_026c;
			IL_026c:
			switch (num)
			{
			case 1:
				return;
			case 3:
				return;
			case 2:
				return;
			}
			goto IL_0281;
			IL_0281:
			MenuIndent.Click += JVCgnGYT5dK;
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
		case 21:
			((TextBox)target).KeyDown += zF5gnBuWaWw;
			break;
		case 22:
			((MenuItem)target).Click += jMxgn5mbtbH;
			break;
		case 23:
			((MenuItem)target).Click += tKvgnT0Eas3;
			break;
		case 24:
			((MenuItem)target).Click += qsognDxZW5C;
			break;
		}
	}

	static CodeEditorWindow()
	{
		L86gnAhYyUD = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		SelectedHighlightingDefinitionProperty = DependencyProperty.Register("SelectedHighlightingDefinition", typeof(string), typeof(CodeEditorWindow), new PropertyMetadata(null, c04gnNmRjNV));
		EnableExpressionTesterProperty = DependencyProperty.Register("EnableExpressionTester", typeof(bool), typeof(CodeEditorWindow), new PropertyMetadata(true, bWwgn1dsX9S));
		ExpressionTesterIsOnProperty = DependencyProperty.Register("ExpressionTesterIsOn", typeof(bool), typeof(CodeEditorWindow), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	private void QJtgnMfeQGo(object sender, ExecutedRoutedEventArgs e)
	{
		xlwgnq4nwUW();
	}

	internal static bool lfDSDRFVkX5iLqHep21S()
	{
		return y1A8pdFVJk4hNKGIOHj2 == null;
	}
}
