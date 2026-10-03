using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using k7aPL5fDWhslvV5ur2A;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class TextBoxWithToolsControl : UserControl, IComponentConnector, ITextControl
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnPreviewKeyDown_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextBoxWithToolsControl _003C_003E4__this;

		public KeyEventArgs e;

		private CodeEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object vPpmlwyWmDTFPOj83dIN;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextBoxWithToolsControl textBoxWithToolsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00da;
				}
				if (textBoxWithToolsControl.ShowEditInEditor && e.Key == Key.F2 && Keyboard.Modifiers == ModifierKeys.None)
				{
					_003Cdlg_003E5__2 = new CodeEditorWindow(textBoxWithToolsControl.S5ULrlx1IjQ, true, null)
					{
						Owner = Window.GetWindow(textBoxWithToolsControl),
						Text = textBoxWithToolsControl.TxtEditor.Text
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (pDh3VEyWsviWlKsvjtHa())
						{
							switch (0)
							{
							}
						}
						return;
					}
					goto IL_00da;
				}
				goto end_IL_000e;
				IL_00da:
				awaiter.GetResult();
				textBoxWithToolsControl.TxtEditor.Text = _003Cdlg_003E5__2.Text;
				_003Cdlg_003E5__2 = null;
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

		static _003COnPreviewKeyDown_003Ed__25()
		{
		}

		internal static bool pDh3VEyWsviWlKsvjtHa()
		{
			return vPpmlwyWmDTFPOj83dIN == null;
		}

		internal static void utxvGtyWh9QyN66MtB5E()
		{
		}
	}

	private IList<ActionVariable> S5ULrlx1IjQ;

	[CompilerGenerated]
	private EventHandler by6LrieAAK2;

	[CompilerGenerated]
	private double ImyLr3U0KJY;

	[CompilerGenerated]
	private bool S1uLrfpN22i;

	private TextToolsReplaceMode? YCpLrzn3eo9;

	private bool huCLpwl6aXh;

	[CompilerGenerated]
	private TextToolsReplaceMode V8JLptdGp80;

	internal TextBoxWithToolsControl TheControl;

	internal Grid LayoutGrid;

	internal CodeEditor TxtEditor;

	internal TextToolsControl TextTools;

	internal GridSplitter Splitter;

	private bool dXQLpgUDXMf;

	private static TextBoxWithToolsControl qJ7GFCFo5GGU8gAlxlMM;

	public string Text
	{
		get
		{
			return TxtEditor.Text;
		}
		set
		{
			TxtEditor.Text = value;
			if (!string.IsNullOrEmpty(value))
			{
				try
				{
					TxtEditor.CaretOffset = value.Length;
				}
				catch
				{
				}
			}
		}
	}

	public int CaretOffset => TxtEditor.CaretOffset;

	public bool SupportQuickerInParam
	{
		get
		{
			return TxtEditor.SupportQuickerInParam;
		}
		set
		{
			TxtEditor.SupportQuickerInParam = value;
		}
	}

	public bool SupportClipTextParam
	{
		get
		{
			return TxtEditor.SupportClipTextParam;
		}
		set
		{
			TxtEditor.SupportClipTextParam = value;
		}
	}

	public double InitialHeight
	{
		[CompilerGenerated]
		get
		{
			return ImyLr3U0KJY;
		}
		[CompilerGenerated]
		set
		{
			ImyLr3U0KJY = value;
		}
	}

	public bool ShowEditInEditor
	{
		[CompilerGenerated]
		get
		{
			return S1uLrfpN22i;
		}
		[CompilerGenerated]
		set
		{
			S1uLrfpN22i = value;
		}
	}

	public event EventHandler TextChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = by6LrieAAK2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref by6LrieAAK2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = by6LrieAAK2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref by6LrieAAK2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TextBoxWithToolsControl()
	{
		InitializeComponent();
		ka2whMfuvIXVT20tX6H.sFQLiVAd4ag(TxtEditor);
		TxtEditor.TextChanged += c10Lro4WYbK;
		base.PreviewKeyDown += OLXLr51Jk23;
		base.Loaded += Fw7LrdhB4l8;
		base.Unloaded += vsqLrD9clp9;
		base.Focusable = true;
	}

	[AsyncStateMachine(typeof(_003COnPreviewKeyDown_003Ed__25))]
	private void OLXLr51Jk23(object sender, KeyEventArgs e)
	{
		_003COnPreviewKeyDown_003Ed__25 stateMachine = default(_003COnPreviewKeyDown_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		if (e.Source == this)
		{
			TxtEditor.Focus();
		}
		else
		{
			base.OnGotFocus(e);
		}
	}

	private void vsqLrD9clp9(object sender, RoutedEventArgs e)
	{
		base.Loaded -= Fw7LrdhB4l8;
		TxtEditor.TextChanged -= c10Lro4WYbK;
		base.Unloaded -= vsqLrD9clp9;
		base.PreviewKeyDown -= OLXLr51Jk23;
	}

	private void Fw7LrdhB4l8(object sender, RoutedEventArgs e)
	{
		if (!huCLpwl6aXh)
		{
			if (!ShowEditInEditor)
			{
				SetupTools(new TextToolType[0]);
			}
			else
			{
				SetupTools(new TextToolType[1] { TextToolType.EditInCodeWindow });
			}
		}
		if (InitialHeight > 0.0)
		{
			SetInitialHeight(InitialHeight);
			int num = 0;
			if (qJ7GFCFo5GGU8gAlxlMM != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void c10Lro4WYbK(object sender, EventArgs e)
	{
		by6LrieAAK2?.Invoke(sender, e);
	}

	public void SetInitialHeight(double height)
	{
		LayoutGrid.RowDefinitions[0].MinHeight = height;
	}

	private void p7ILrTi2Cw0(object sender, DragStartedEventArgs e)
	{
		TxtEditor.ClearValue(FrameworkElement.MaxHeightProperty);
	}

	public void SetVariables(IList<ActionVariable> variables, bool defaultUseExpression = true)
	{
		S5ULrlx1IjQ = variables;
		TxtEditor.ActionVariables = variables;
		TextTools.SetVariableList(variables, defaultUseExpression);
	}

	public void SetupTools(ICollection<TextToolType> tools, string defaultHighlightingType = null, ActionExecuteContext actionExecuteContext = null)
	{
		TextTools.SetupTools(false, tools, this, new TextToolsContextHint(), defaultHighlightingType, actionExecuteContext);
		huCLpwl6aXh = true;
	}

	public void AddExtraTools(IEnumerable<TextToolItem> extraTools)
	{
		TextTools.AddExtraTools(extraTools);
	}

	public void ProcessExtraSettings(string extraSettings)
	{
		if (!string.IsNullOrEmpty(extraSettings))
		{
			string[] array = extraSettings.SplitToList();
			try
			{
				YEwLrMQt28M(array);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("字段扩展设置解析出错：" + ex.Message);
			}
			YCpLrzn3eo9 = TextToolsControl.Bu8tLMnxv81(array);
		}
	}

	internal void YEwLrMQt28M(string[] string_0)
	{
		IList<TextToolItem> list = TextToolsControl.hgdtLTVZCx6(string_0);
		if (list.HasData())
		{
			AddExtraTools(list);
		}
	}

	private void wRoLrAwfoiq(object sender, DragCompletedEventArgs e)
	{
		TxtEditor.MaxHeight = LayoutGrid.RowDefinitions[0].ActualHeight;
	}

	[SpecialName]
	[CompilerGenerated]
	internal TextToolsReplaceMode l1eLrOJPIKy()
	{
		return V8JLptdGp80;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void NFiLrFTdnUS(TextToolsReplaceMode value)
	{
		V8JLptdGp80 = value;
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		if (YCpLrzn3eo9.HasValue)
		{
			TextToolsControl.UpdateTextValueWithReplaceMode(this, YCpLrzn3eo9.Value, e.Value);
		}
		else if (e.IsFullContent)
		{
			TxtEditor.Text = e.Value;
		}
		else if (e.IsFullContent)
		{
			TxtEditor.Text = e.Value;
		}
		else
		{
			TxtEditor.SelectedText = e.Value;
		}
	}

	public string GetAllText()
	{
		return TxtEditor.Text;
	}

	public string GetSelectedText()
	{
		return TxtEditor.SelectedText;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return S5ULrlx1IjQ;
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
		try
		{
			TxtEditor.CaretOffset = TxtEditor.Document.TextLength;
			TxtEditor.TextArea.Caret.BringCaretToView();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!dXQLpgUDXMf)
		{
			dXQLpgUDXMf = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/textboxwithtoolscontrol.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			dXQLpgUDXMf = true;
			break;
		case 1:
		{
			TheControl = (TextBoxWithToolsControl)target;
			int num = 0;
			if (!q7US1qFoYBFEE6sb7fmM())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 2:
			LayoutGrid = (Grid)target;
			break;
		case 3:
			TxtEditor = (CodeEditor)target;
			break;
		case 4:
			TextTools = (TextToolsControl)target;
			break;
		case 5:
			Splitter = (GridSplitter)target;
			Splitter.DragCompleted += wRoLrAwfoiq;
			Splitter.DragStarted += p7ILrTi2Cw0;
			break;
		}
	}

	internal static bool q7US1qFoYBFEE6sb7fmM()
	{
		return qJ7GFCFo5GGU8gAlxlMM == null;
	}
}
