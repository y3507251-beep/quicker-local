using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using GongSolutions.Wpf.DragDrop;
using IOn6RhAJdTUbfGy6gwn;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.History;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.X;

public class SubProgramEditor : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WioSAlHLbO0;

		public static Func<ActionVariable, string> WPrSAiuQVsm;

		public static Func<ActionVariable, string> HGmSA3NVstg;

		public static Func<string, bool> XbeSAfDDWTd;

		public static Func<string, string> ShoSAzLOL3O;

		public static Comparison<ActionVariable> LEsSOwZweoC;

		public static Func<ActionVariable, bool> hhMSOtvB5oe;

		public static Func<ActionVariable, bool> Q4fSOg8Tk8Y;

		private static _003C_003Ec EysAueWzAILEudgO5ZDO;

		static _003C_003Ec()
		{
			WioSAlHLbO0 = new _003C_003Ec();
		}

		internal string zg0SAoqAPkY(ActionVariable x)
		{
			return x.Key;
		}

		internal string ttRSATMmsI4(ActionVariable x)
		{
			return x.Group;
		}

		internal bool k8rSAMM1Fqj(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string ymASAACvPfg(string x)
		{
			return x;
		}

		internal int UYUSAOinUAp(ActionVariable a, ActionVariable b)
		{
			return string.Compare(a.Group + " " + a.Key, b.Group + " " + b.Key, StringComparison.Ordinal);
		}

		internal bool MYhSAFovoVY(ActionVariable x)
		{
			return x.IsInput;
		}

		internal bool gd0SAUmsLcQ(ActionVariable x)
		{
			return x.IsOutput;
		}

		internal static void WbI5kBWzjgH0rYNqVmfg()
		{
		}

		internal static bool C1YPSYWznegXgJrW3hAr()
		{
			return EysAueWzAILEudgO5ZDO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_0
	{
		public string kmOSOvoNWuZ;

		internal static _003C_003Ec__DisplayClass73_0 QUj7jKWzEvYY09pqef13;

		internal bool akgSOLAIlq8(ActionVariable v)
		{
			return v.Key == kmOSOvoNWuZ;
		}

		internal static bool T7LbXXWzGrxd0Zgn9Ztf()
		{
			return QUj7jKWzEvYY09pqef13 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateStep_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgramEditor _003C_003E4__this;

		public XToolboxItem item;

		private TaskAwaiter _003C_003Eu__1;

		private static object BGVscNWz1m5QcM2AEbwx;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubProgramEditor subProgramEditor = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (!UVeWDNWzKCUio3eTTQGH())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = subProgramEditor.ActionStepsWrapper.CreateStep(item, null).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool UVeWDNWzKCUio3eTTQGH()
		{
			return BGVscNWz1m5QcM2AEbwx == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateStep_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubProgramEditor _003C_003E4__this;

		public string stepRunnerKey;

		public int? insertIndex;

		public string controlFieldKey;

		private TaskAwaiter _003C_003Eu__1;

		private static object qQIlc7WzvoO5puP03uRU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubProgramEditor subProgramEditor = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = subProgramEditor.ActionStepsWrapper.CreateStep(stepRunnerKey, insertIndex, controlFieldKey).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				if (qQIlc7WzvoO5puP03uRU != null)
				{
					switch (0)
					{
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

		internal static bool Y0KCMeWzdn98ETqlouXZ()
		{
			return qQIlc7WzvoO5puP03uRU == null;
		}
	}

	[CompilerGenerated]
	private readonly SmartCollection<ActionVariable> kGFLklF61MN = new SmartCollection<ActionVariable>();

	[CompilerGenerated]
	private SubProgram zkhLkigqKNN;

	[CompilerGenerated]
	private IList<ActionStep> EgCLk3CKCVM;

	private readonly HistoryManager u3ILkfIEaoh = new HistoryManager();

	private bool xYPLkzZv6Qo;

	[CompilerGenerated]
	private EventHandler m_Cancel;

	[CompilerGenerated]
	private EventHandler m_Save;

	private readonly RoutedCommand zHdLGwRucKw = new RoutedCommand("Undo", typeof(ActionDesignerWindow));

	private readonly RoutedCommand JbfLGtwK7x7 = new RoutedCommand("Redo", typeof(ActionDesignerWindow));

	private ICollectionView QKaLGgpZQh1;

	[CompilerGenerated]
	private bool Pj4LGLj1XSj;

	private readonly DebounceDispatcher W7ZLGvqh6sK = new DebounceDispatcher();

	private object f5HLGSGOQDs;

	private DebounceTimer PLHLG2O7whv = new DebounceTimer();

	internal Grid GridMain;

	internal TextBlock LblSubprogramName;

	internal TextBox TxtFilter;

	internal Button BtnExpandByHightlight;

	internal Button BtnUndo;

	internal Button BtnRedo;

	internal DropDownButton BtnMenu;

	internal ContextMenu MainContextMenu1;

	internal MenuItem MenuExport;

	internal MenuItem MenuImport;

	internal MenuItem MenuExpandAll;

	internal MenuItem MenuCollapseAll;

	internal ActionStepsWrapper ActionStepsWrapper;

	internal Button BtnNewVar;

	internal Button BtnClearVarible;

	internal Button BtnSortVariable;

	internal MenuItem SortByVarName;

	internal MenuItem SortByVarType;

	internal MenuItem SortByVarGroup;

	internal ToggleButton ToggleVariableFilter;

	internal Grid GridVariableFilter;

	internal TextBox TxtVarFilter;

	internal ListBox LbVariables;

	internal TextBox TxtSubProgramName;

	internal TextBox TxtActionDescription;

	internal TextBoxWithToolsControl TxtSummaryExpression;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool UBwLGuqiv9T;

	private static SubProgramEditor uSk4qjFkGx8XLCnLskaf;

	public SmartCollection<ActionVariable> VariableList
	{
		[CompilerGenerated]
		get
		{
			return kGFLklF61MN;
		}
	}

	public SubProgram EditingSubProgram
	{
		[CompilerGenerated]
		get
		{
			return zkhLkigqKNN;
		}
		[CompilerGenerated]
		set
		{
			zkhLkigqKNN = value;
		}
	}

	public bool HasChanged
	{
		[CompilerGenerated]
		get
		{
			return Pj4LGLj1XSj;
		}
		[CompilerGenerated]
		private set
		{
			Pj4LGLj1XSj = value;
		}
	}

	public event EventHandler Cancel
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_Cancel;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Cancel, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_Cancel;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Cancel, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler Save
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_Save;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Save, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_Save;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Save, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IList<ActionStep> g1bLkAaqx2R()
	{
		return EgCLk3CKCVM;
	}

	[SpecialName]
	[CompilerGenerated]
	private void I2dLkOKQjRr(IList<ActionStep> value)
	{
		EgCLk3CKCVM = value;
	}

	public SubProgramEditor()
	{
		InitializeComponent();
		QKaLGgpZQh1 = CollectionViewSource.GetDefaultView(VariableList);
		QKaLGgpZQh1.Filter = qfELkJ85OLL;
		LbVariables.ItemsSource = QKaLGgpZQh1;
		VariableList.CollectionChanged += OIdLk8PCAKI;
		LbVariables.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
		TxtSummaryExpression.SetVariables(VariableList);
		fFKLk0EUAv1();
	}

	private bool qfELkJ85OLL(object object_1)
	{
		if (!string.IsNullOrEmpty(TxtVarFilter.Text) && TxtVarFilter.IsVisible)
		{
			ActionVariable actionVariable = (ActionVariable)object_1;
			if (tkxn6HAKAgMT8gvXbyh.IsMatch(actionVariable.Key, TxtVarFilter.Text))
			{
				return true;
			}
			if (string.IsNullOrEmpty(actionVariable.Desc))
			{
				return false;
			}
			return actionVariable.Desc.Contains(TxtVarFilter.Text);
		}
		return true;
	}

	private void fFKLk0EUAv1()
	{
		BtnUndo.Command = zHdLGwRucKw;
		BtnRedo.Command = JbfLGtwK7x7;
		zHdLGwRucKw.InputGestures.Add(new KeyGesture(Key.Z, ModifierKeys.Control));
		JbfLGtwK7x7.InputGestures.Add(new KeyGesture(Key.Y, ModifierKeys.Control));
		BtnUndo.CommandTarget = this;
		BtnRedo.CommandTarget = this;
		CommandBinding commandBinding = new CommandBinding
		{
			Command = zHdLGwRucKw
		};
		commandBinding.CanExecute += i37LkPD4g0e;
		commandBinding.Executed += CbUndoOnExecuted;
		if (uSk4qjFkGx8XLCnLskaf != null)
		{
			switch (0)
			{
			}
		}
		CommandBinding commandBinding2 = new CommandBinding
		{
			Command = JbfLGtwK7x7
		};
		commandBinding2.CanExecute += LtcLkCC10SW;
		commandBinding2.Executed += CbRedoOnExecuted;
		base.CommandBindings.Add(commandBinding);
		base.CommandBindings.Add(commandBinding2);
	}

	public void CbRedoOnExecuted(object sender, ExecutedRoutedEventArgs e)
	{
		if (u3ILkfIEaoh.CanRedo())
		{
			ActionStepsDto actionStepsDto_ = JsonConvert.DeserializeObject<ActionStepsDto>(u3ILkfIEaoh.Redo());
			Ld9LkEQmUZu(actionStepsDto_);
		}
		else
		{
			AppHelper.ShowWarning("不能重做了");
		}
		e.Handled = true;
	}

	private void LtcLkCC10SW(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = u3ILkfIEaoh.CanRedo();
		e.Handled = true;
	}

	private void i37LkPD4g0e(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = u3ILkfIEaoh.CanUndo();
		e.Handled = true;
	}

	public bool CanUndo()
	{
		return u3ILkfIEaoh.CanUndo();
	}

	public void CbUndoOnExecuted(object sender, ExecutedRoutedEventArgs e)
	{
		if (u3ILkfIEaoh.CanUndo())
		{
			ActionStepsDto actionStepsDto_ = JsonConvert.DeserializeObject<ActionStepsDto>(u3ILkfIEaoh.Undo());
			Ld9LkEQmUZu(actionStepsDto_);
		}
		else
		{
			AppHelper.ShowWarning("不能撤销了");
		}
		CommandManager.InvalidateRequerySuggested();
		e.Handled = true;
	}

	private void Ld9LkEQmUZu(ActionStepsDto actionStepsDto_0)
	{
		xYPLkzZv6Qo = true;
		VariableList.Reset(actionStepsDto_0.Variables);
		ActionStepsWrapper.ActionVariables = VariableList;
		ActionStepsWrapper.SetSteps(actionStepsDto_0.Steps);
		I2dLkOKQjRr(actionStepsDto_0.Steps);
		xYPLkzZv6Qo = false;
	}

	public void SetSubProgram(SubProgram subProgram, XAction action)
	{
		EditingSubProgram = subProgram;
		nitLky1q0qq(AppHelper.Clone(subProgram));
	}

	private void nitLky1q0qq(SubProgram subProgram_1)
	{
		xYPLkzZv6Qo = true;
		VariableList.Reset(subProgram_1.Variables);
		ActionStepsWrapper.ActionVariables = VariableList;
		ActionStepsWrapper.SetSteps(subProgram_1.Steps);
		I2dLkOKQjRr(subProgram_1.Steps);
		LblSubprogramName.Text = subProgram_1.Name;
		u3ILkfIEaoh.Reset();
		if (uSk4qjFkGx8XLCnLskaf == null)
		{
			switch (0)
			{
			}
		}
		xYPLkzZv6Qo = false;
		TxtSubProgramName.Text = subProgram_1.Name;
		TxtActionDescription.Text = subProgram_1.Description;
		TxtSummaryExpression.Text = subProgram_1.SummaryExpression ?? "";
		SaveState();
		HasChanged = false;
	}

	public void Reset()
	{
		EditingSubProgram = null;
		u3ILkfIEaoh.Reset();
		VariableList.Clear();
		ActionStepsWrapper.SetSteps(new List<ActionStep>());
		I2dLkOKQjRr(new List<ActionStep>());
		HasChanged = false;
	}

	private void OIdLk8PCAKI(object sender, NotifyCollectionChangedEventArgs e)
	{
		if (!xYPLkzZv6Qo)
		{
			SaveState();
		}
	}

	private void SaveState()
	{
		SubProgramHistoryItem value = new SubProgramHistoryItem
		{
			Variables = VariableList.ToList(),
			Steps = ActionStepsWrapper.GetSteps()
		};
		u3ILkfIEaoh.Add(JsonConvert.SerializeObject(value));
		HasChanged = true;
	}

	[AsyncStateMachine(typeof(_003CCreateStep_003Ed__40))]
	public Task CreateStep(XToolboxItem item)
	{
		_003CCreateStep_003Ed__40 stateMachine = default(_003CCreateStep_003Ed__40);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = item;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateStep_003Ed__41))]
	public Task CreateStep(string stepRunnerKey, int? insertIndex, string controlFieldKey)
	{
		_003CCreateStep_003Ed__41 stateMachine = default(_003CCreateStep_003Ed__41);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.stepRunnerKey = stepRunnerKey;
		stateMachine.insertIndex = insertIndex;
		stateMachine.controlFieldKey = controlFieldKey;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public SubProgram GetResult()
	{
		return new SubProgram
		{
			Variables = VariableList.ToList(),
			Steps = ActionStepsWrapper.GetSteps(),
			Name = TxtSubProgramName.Text,
			Description = TxtActionDescription.Text,
			SummaryExpression = TxtSummaryExpression.Text,
			SharedId = EditingSubProgram?.SharedId,
			LastEditTimeUtc = EditingSubProgram?.LastEditTimeUtc,
			Id = EditingSubProgram?.Id,
			TemplateId = EditingSubProgram?.TemplateId,
			TemplateRevision = (EditingSubProgram?.TemplateRevision ?? 0)
		};
	}

	private void UhSLkaeNcFE(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.ExportSubProgram(Window.GetWindow(this), GetResult());
	}

	private void fWILk7pJFC2(object sender, RoutedEventArgs e)
	{
		{
			(bool, string) tuple = AppHelper.ShowSelectFileDialog("*.qka|*.qka", ".qka", "", "", "导入动作定义");
			if (!tuple.Item1)
			{
				return;
			}
			try
			{
				SubProgram subProgram = JsonConvert.DeserializeObject<SubProgram>(File.ReadAllText(tuple.Item2));
				if (subProgram != null && (subProgram.Steps.HasData() || subProgram.Variables.HasData()))
				{
					SaveState();
					Ld9LkEQmUZu(new ActionStepsDto
					{
						Variables = subProgram.Variables,
						Steps = subProgram.Steps
					});
					if (!L1w0Z2Fk0NGuaC0bfQ0w())
					{
						switch (0)
						{
						}
					}
					SaveState();
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

	private void ActionStepsWrapper_OnStepChanged(object sender, EventArgs e)
	{
		W7ZLGvqh6sK.Debounce(100, WA6LkoabjCr);
	}

	private void rhiLkRoRIlu(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.CreateVariable(Window.GetWindow(this), VariableList, null, true);
	}

	private void HUjLkqCEr7t(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.ClearVariables(new SubProgram
		{
			Steps = g1bLkAaqx2R(),
			Variables = VariableList.ToList()
		}, VariableList, Window.GetWindow(this), true);
	}

	private void UOrLkc4wobs(object sender, RoutedEventArgs e)
	{
		BtnSortVariable.ContextMenu.IsOpen = true;
	}

	private void BiBLkViyqje(object sender, DragEventArgs e)
	{
	}

	private void OyYLkZxpDWD(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2 && sender == f5HLGSGOQDs && (sender as FrameworkElement).Tag is ActionVariable actionVariable_)
		{
			jhALkhUkJI3(actionVariable_);
		}
		f5HLGSGOQDs = sender;
	}

	private void h49Lk9lOE52(object sender, RoutedEventArgs e)
	{
		ActionVariable actionVariable_ = (sender as Button).Tag as ActionVariable;
		jhALkhUkJI3(actionVariable_);
	}

	private void jhALkhUkJI3(ActionVariable actionVariable_0)
	{
		VariableEditorWindow variableEditorWindow = new VariableEditorWindow(VariableList, true)
		{
			Owner = Window.GetWindow(this),
			EditingVariable = actionVariable_0
		};
		ActionVariable result;
		string key;
		int num;
		if (variableEditorWindow.ShowDialog() == true)
		{
			result = variableEditorWindow.Result;
			key = actionVariable_0.Key;
			num = 0;
			if (uSk4qjFkGx8XLCnLskaf == null)
			{
				goto IL_0052;
			}
			goto IL_008b;
		}
		return;
		IL_008b:
		switch (num)
		{
		case 1:
			goto IL_0176;
		}
		goto IL_0052;
		IL_0052:
		if (string.Equals(result.Key, key, StringComparison.InvariantCulture))
		{
			VariableList[VariableList.IndexOf(actionVariable_0)] = result;
			num = 1;
			if (uSk4qjFkGx8XLCnLskaf == null)
			{
				goto IL_008b;
			}
			goto IL_0176;
		}
		if ((result.IsInput || result.IsOutput) && !AppHelper.Confirm("如果已经在动作中使用了子程序，修改变量名将会导致动作步骤中对应的参数设置丢失。\r\n\r\n您确认要修改么？"))
		{
			return;
		}
		IList<ActionStep> steps = ActionStepsWrapper.GetSteps();
		VariableList[VariableList.IndexOf(actionVariable_0)] = result;
		XActionUiHelper.ReplaceSubProgramVisibleExpVars(VariableList, key, result.Key, result.Type);
		if (!string.IsNullOrEmpty(TxtSummaryExpression.Text))
		{
			TxtSummaryExpression.Text = XActionUiHelper.ReplaceVarInText(TxtSummaryExpression.Text, key, result.Key, result.Type, true);
		}
		XActionUiHelper.ReplaceStepsVar(steps, key, result.Key, result.Type);
		ActionStepsWrapper.SetSteps(steps);
		SaveState();
		try
		{
			LbVariables.SelectedItem = result;
			return;
		}
		catch (Exception)
		{
			return;
		}
		IL_0176:
		LbVariables.UpdateLayout();
	}

	private void VxpLkeVkODN(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.DeleteVariable((sender as Button).Tag as ActionVariable, VariableList, new SubProgram
		{
			Variables = VariableList.ToList(),
			Steps = g1bLkAaqx2R()
		}, Window.GetWindow(this));
	}

	private void NTZLkYaGRRZ(object sender, TextChangedEventArgs e)
	{
	}

	private void n0KLkIrhXdr(object sender, TextChangedEventArgs e)
	{
	}

	private void vVrLkWui164(object sender, RoutedEventArgs e)
	{
		this.m_Save?.Invoke(this, EventArgs.Empty);
	}

	private void RgxLkk3IBim(object sender, RoutedEventArgs e)
	{
		this.m_Cancel?.Invoke(this, EventArgs.Empty);
	}

	private void cydLkGoyLQ1(object sender, TextChangedEventArgs e)
	{
		if (base.IsLoaded)
		{
			PLHLG2O7whv.Debounce(500, RlFLkTyhhna);
		}
	}

	private void Vk6LksjVyaQ(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement).Tag is ActionVariable actionVariable)
		{
			TxtFilter.Text = "var:" + actionVariable.Key;
		}
	}

	private void w6CLkHYvbWR(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.ExpandAll();
	}

	private void o5lLk1hTZUS(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.CollapseAll();
	}

	private void zkaLkb5KsFs(object sender, TextChangedEventArgs e)
	{
		QKaLGgpZQh1.Refresh();
	}

	public void SetReadonly()
	{
		MenuExport.IsEnabled = false;
		MenuImport.IsEnabled = false;
		BtnSave.IsEnabled = false;
	}

	private void PByLk6DJEfO(object sender, RoutedEventArgs e)
	{
		ActionStepsWrapper.ExpandByHighlight();
	}

	private void FfVLkXTSd8p(object sender, RoutedEventArgs e)
	{
		if (LbVariables.SelectedItems.Count > 1)
		{
			List<string> values = LbVariables.SelectedItems.Cast<ActionVariable>().Select(_003C_003Ec.WPrSAiuQVsm ?? (_003C_003Ec.WPrSAiuQVsm = _003C_003Ec.WioSAlHLbO0.zg0SAoqAPkY)).ToList();
			ClipboardHelper.SetText(string.Join("\r\n", values));
		}
		else
		{
			ClipboardHelper.SetText("{" + ((sender as FrameworkElement).Tag as ActionVariable)?.Key + "}");
		}
	}

	private void xGMLkmJ7PNp(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.SortVariableListByType(VariableList);
	}

	private void lTRLkKBAYY7(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.SortVariableListByName(VariableList);
	}

	private void aLOLkxZQykP(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return && !string.IsNullOrEmpty(TxtFilter.Text))
		{
			AppHelper.TriggerButtonClick(BtnExpandByHightlight);
		}
	}

	private void S1lLkrPIW4v(object sender, RoutedEventArgs e)
	{
		if (ToggleVariableFilter.IsChecked == true)
		{
			TxtVarFilter.Focus();
		}
		else
		{
			TxtVarFilter.Text = "";
		}
	}

	private void gZgLkp5XEyx(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent("GongSolutions.Wpf.DragDrop"))
		{
			if (e.Data.GetData("GongSolutions.Wpf.DragDrop") is ActionVariable actionVariable)
			{
				_003C_003Ec__DisplayClass73_0 _003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_0();
				ActionVariable actionVariable2 = AppHelper.Clone(actionVariable);
				_003C_003Ec__DisplayClass73_.kmOSOvoNWuZ = actionVariable.Key + "_2";
				int num = 3;
				int num3 = default(int);
				while (true)
				{
					int num2;
					if (VariableList.Any(_003C_003Ec__DisplayClass73_.akgSOLAIlq8))
					{
						_003C_003Ec__DisplayClass73_.kmOSOvoNWuZ = actionVariable.Key + "_" + num;
						num2 = 0;
						if (uSk4qjFkGx8XLCnLskaf == null)
						{
							goto IL_009e;
						}
					}
					else
					{
						actionVariable2.Key = _003C_003Ec__DisplayClass73_.kmOSOvoNWuZ;
						VariableEditorWindow variableEditorWindow = new VariableEditorWindow(VariableList, true)
						{
							Owner = Window.GetWindow(this),
							EditingVariable = actionVariable2
						};
						if (variableEditorWindow.ShowDialog() != true)
						{
							break;
						}
						VariableList.Insert(VariableList.IndexOf(actionVariable) + 1, variableEditorWindow.Result);
						num2 = 1;
						if (!L1w0Z2Fk0NGuaC0bfQ0w())
						{
							num2 = num3;
						}
					}
					switch (num2)
					{
					case 1:
						return;
					}
					goto IL_009e;
					IL_009e:
					num++;
				}
			}
			else
			{
				AppHelper.ShowWarning("只支持拖放变量。");
			}
		}
		else
		{
			AppHelper.ShowWarning("只支持拖放变量。");
		}
	}

	private void DSBLkBIKpUV(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement).Tag is ActionVariable actionVariable)
		{
			TxtFilter.Text = "to:" + actionVariable.Key;
		}
	}

	private void HdfLkQaB3Q3(object sender, ContextMenuEventArgs e)
	{
		ContextMenu contextMenu = (sender as Grid)?.ContextMenu;
		if (contextMenu == null)
		{
			return;
		}
		int num2 = default(int);
		foreach (MenuItem item in (IEnumerable)contextMenu.Items)
		{
			if (!(item.Name == "MenuTag"))
			{
				continue;
			}
			item.Items.Clear();
			if (item.Items.Count != 0)
			{
				continue;
			}
			List<string> list = VariableList.Select(_003C_003Ec.HGmSA3NVstg ?? (_003C_003Ec.HGmSA3NVstg = _003C_003Ec.WioSAlHLbO0.ttRSATMmsI4)).Where(_003C_003Ec.XbeSAfDDWTd ?? (_003C_003Ec.XbeSAfDDWTd = _003C_003Ec.WioSAlHLbO0.k8rSAMM1Fqj)).Distinct()
				.OrderBy(_003C_003Ec.ShoSAzLOL3O ?? (_003C_003Ec.ShoSAzLOL3O = _003C_003Ec.WioSAlHLbO0.ymASAACvPfg))
				.ToList();
			foreach (string item2 in list)
			{
				AppHelper.AddMenuItem(item.Items, item2, "", "", NdDLknSXaAj).Tag = item2;
			}
			if (list.Count > 0)
			{
				int num = 0;
				if (uSk4qjFkGx8XLCnLskaf != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				AppHelper.AddMenuSeparator(item.Items);
				AppHelper.AddMenuItem(item.Items, "删除", "去除变量标签", "fa:Light_Times:danger", NdDLknSXaAj).Tag = null;
			}
			AppHelper.AddMenuItem(item.Items, "新标签...", "创建新标签", "", eIZLkjOp7Bt);
		}
	}

	private void eIZLkjOp7Bt(object sender, RoutedEventArgs e)
	{
		UserInputWindow userInputWindow = new UserInputWindow("text", "请输入分组名称", "", "");
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string textValue = userInputWindow.TextValue;
		foreach (ActionVariable item in LbVariables.SelectedItems.Cast<ActionVariable>())
		{
			item.Group = textValue;
		}
	}

	private void NdDLknSXaAj(object sender, RoutedEventArgs e)
	{
		if (!(sender is MenuItem menuItem))
		{
			return;
		}
		string text = menuItem.Tag as string;
		foreach (ActionVariable item in LbVariables.SelectedItems.Cast<ActionVariable>())
		{
			item.Group = text;
		}
	}

	private void NKfLk4Daw6V(object sender, RoutedEventArgs e)
	{
		VariableList.Sort(_003C_003Ec.LEsSOwZweoC ?? (_003C_003Ec.LEsSOwZweoC = _003C_003Ec.WioSAlHLbO0.UYUSAOinUAp));
	}

	private void NJYLk5VjOXh(object sender, RoutedEventArgs e)
	{
		List<ActionVariable> list = LbVariables.SelectedItems.Cast<ActionVariable>().ToList();
		if (!list.Any(_003C_003Ec.hhMSOtvB5oe ?? (_003C_003Ec.hhMSOtvB5oe = _003C_003Ec.WioSAlHLbO0.MYhSAFovoVY)))
		{
			foreach (ActionVariable item in list)
			{
				item.IsInput = true;
			}
			return;
		}
		foreach (ActionVariable item2 in list)
		{
			item2.IsInput = false;
		}
	}

	private void AQJLkDgfiVI(object sender, RoutedEventArgs e)
	{
		List<ActionVariable> list = LbVariables.SelectedItems.Cast<ActionVariable>().ToList();
		if (!list.Any(_003C_003Ec.Q4fSOg8Tk8Y ?? (_003C_003Ec.Q4fSOg8Tk8Y = _003C_003Ec.WioSAlHLbO0.gd0SAUmsLcQ)))
		{
			foreach (ActionVariable item in list)
			{
				item.IsOutput = true;
			}
			return;
		}
		foreach (ActionVariable item2 in list)
		{
			item2.IsOutput = false;
		}
	}

	private void JhdLkdGtf5s(object sender, KeyEventArgs e)
	{
		if ((e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H)) && LbVariables.SelectedItem is ActionVariable actionVariable)
		{
			TxtFilter.Text = "var:" + actionVariable.Key;
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!UBwLGuqiv9T)
		{
			UBwLGuqiv9T = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/subprogrameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			GridMain = (Grid)target;
			break;
		case 2:
			LblSubprogramName = (TextBlock)target;
			break;
		case 3:
			TxtFilter = (TextBox)target;
			num = 1;
			if (uSk4qjFkGx8XLCnLskaf != null)
			{
				goto IL_0140;
			}
			goto IL_038c;
		case 4:
			BtnExpandByHightlight = (Button)target;
			BtnExpandByHightlight.Click += PByLk6DJEfO;
			break;
		case 5:
			BtnUndo = (Button)target;
			break;
		case 6:
			BtnRedo = (Button)target;
			break;
		case 7:
			BtnMenu = (DropDownButton)target;
			break;
		case 8:
			MainContextMenu1 = (ContextMenu)target;
			num = 0;
			if (!L1w0Z2Fk0NGuaC0bfQ0w())
			{
				goto IL_0140;
			}
			goto IL_038c;
		case 9:
			MenuExport = (MenuItem)target;
			MenuExport.Click += UhSLkaeNcFE;
			break;
		case 10:
			MenuImport = (MenuItem)target;
			MenuImport.Click += fWILk7pJFC2;
			break;
		case 11:
			MenuExpandAll = (MenuItem)target;
			MenuExpandAll.Click += w6CLkHYvbWR;
			break;
		case 12:
			MenuCollapseAll = (MenuItem)target;
			MenuCollapseAll.Click += o5lLk1hTZUS;
			break;
		case 13:
			ActionStepsWrapper = (ActionStepsWrapper)target;
			break;
		case 14:
			BtnNewVar = (Button)target;
			BtnNewVar.Click += rhiLkRoRIlu;
			BtnNewVar.Drop += gZgLkp5XEyx;
			break;
		case 15:
			BtnClearVarible = (Button)target;
			BtnClearVarible.Click += HUjLkqCEr7t;
			break;
		case 16:
			BtnSortVariable = (Button)target;
			BtnSortVariable.Click += UOrLkc4wobs;
			break;
		case 17:
			SortByVarName = (MenuItem)target;
			SortByVarName.Click += lTRLkKBAYY7;
			break;
		case 18:
			SortByVarType = (MenuItem)target;
			SortByVarType.Click += xGMLkmJ7PNp;
			break;
		case 19:
			SortByVarGroup = (MenuItem)target;
			goto IL_03d7;
		case 20:
			ToggleVariableFilter = (ToggleButton)target;
			ToggleVariableFilter.Click += S1lLkrPIW4v;
			break;
		case 21:
			GridVariableFilter = (Grid)target;
			break;
		case 22:
			TxtVarFilter = (TextBox)target;
			TxtVarFilter.TextChanged += zkaLkb5KsFs;
			break;
		case 23:
			LbVariables = (ListBox)target;
			LbVariables.Drop += BiBLkViyqje;
			LbVariables.PreviewKeyDown += JhdLkdGtf5s;
			break;
		default:
			UBwLGuqiv9T = true;
			break;
		case 32:
			TxtSubProgramName = (TextBox)target;
			TxtSubProgramName.TextChanged += NTZLkYaGRRZ;
			num = 2;
			if (uSk4qjFkGx8XLCnLskaf != null)
			{
				break;
			}
			goto IL_038c;
		case 33:
			TxtActionDescription = (TextBox)target;
			TxtActionDescription.TextChanged += n0KLkIrhXdr;
			break;
		case 34:
			TxtSummaryExpression = (TextBoxWithToolsControl)target;
			break;
		case 35:
			BtnSave = (Button)target;
			BtnSave.Click += vVrLkWui164;
			break;
		case 36:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += RgxLkk3IBim;
				break;
			}
			IL_0140:
			num = num2;
			goto IL_038c;
			IL_038c:
			switch (num)
			{
			default:
				return;
			case 1:
				TxtFilter.KeyDown += aLOLkxZQykP;
				TxtFilter.TextChanged += cydLkGoyLQ1;
				return;
			case 2:
				return;
			case 3:
				return;
			case 4:
				break;
			}
			goto IL_03d7;
			IL_03d7:
			SortByVarGroup.Click += NKfLk4Daw6V;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 24:
				((Grid)target).ContextMenuOpening += HdfLkQaB3Q3;
				((Grid)target).PreviewMouseDown += OyYLkZxpDWD;
				return;
			case 25:
				((MenuItem)target).Click += Vk6LksjVyaQ;
				return;
			case 26:
				((MenuItem)target).Click += DSBLkBIKpUV;
				return;
			case 27:
				((MenuItem)target).Click += FfVLkXTSd8p;
				return;
			case 28:
				((MenuItem)target).Click += NJYLk5VjOXh;
				return;
			case 29:
				((MenuItem)target).Click += AQJLkDgfiVI;
				return;
			case 30:
				((Button)target).Click += h49Lk9lOE52;
				return;
			case 31:
				((Button)target).Click += VxpLkeVkODN;
				return;
			}
			if (L1w0Z2Fk0NGuaC0bfQ0w())
			{
				switch (0)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				continue;
			}
			return;
		}
	}

	[CompilerGenerated]
	private void WA6LkoabjCr(object object_1)
	{
		I2dLkOKQjRr(ActionStepsWrapper.GetSteps());
		SaveState();
		CommandManager.InvalidateRequerySuggested();
	}

	[CompilerGenerated]
	private void RlFLkTyhhna(object object_1)
	{
		base.Dispatcher.InvokeAsync(V20LkM7qS6E);
	}

	[CompilerGenerated]
	private void V20LkM7qS6E()
	{
		ActionStepsWrapper.DoFilter(TxtFilter.Text);
	}

	internal static bool L1w0Z2Fk0NGuaC0bfQ0w()
	{
		return uSk4qjFkGx8XLCnLskaf == null;
	}
}
