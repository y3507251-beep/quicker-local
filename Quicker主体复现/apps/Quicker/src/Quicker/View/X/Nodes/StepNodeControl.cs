using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities._3rd;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.X.Nodes;

public class StepNodeControl : Control
{
	private StepListControl wGRL1MDR67y;

	private StepListControl O37L1AoIbMH;

	private static readonly ILog VtIL1O9x3am;

	public static readonly RoutedEvent TriggerContextMenuEvent;

	public static readonly RoutedEvent TriggerEditEvent;

	public static readonly DependencyProperty StepNodeProperty;

	[CompilerGenerated]
	private bool AxJL1FGhHTw;

	[CompilerGenerated]
	private bool vMTL1U7VcCT;

	public static readonly DependencyProperty HasChildStepsProperty;

	[CompilerGenerated]
	private bool fclL1l1WATk;

	[CompilerGenerated]
	private string wQjL1iqnwTT;

	[CompilerGenerated]
	private string O3QL13BtVfg;

	private static StepNodeControl rxK9CdFNvqX6cMBHb7a0;

	public StepNode StepNode
	{
		get
		{
			return (StepNode)GetValue(StepNodeProperty);
		}
		set
		{
			SetValue(StepNodeProperty, value);
		}
	}

	public bool IsSubProgramStep
	{
		[CompilerGenerated]
		get
		{
			return AxJL1FGhHTw;
		}
		[CompilerGenerated]
		set
		{
			AxJL1FGhHTw = value;
		}
	}

	public bool IsCommentStep
	{
		[CompilerGenerated]
		get
		{
			return vMTL1U7VcCT;
		}
		[CompilerGenerated]
		set
		{
			vMTL1U7VcCT = value;
		}
	}

	public bool HasChildSteps
	{
		get
		{
			return (bool)GetValue(HasChildStepsProperty);
		}
		set
		{
			SetValue(HasChildStepsProperty, value);
		}
	}

	public bool HasElseSteps
	{
		[CompilerGenerated]
		get
		{
			return fclL1l1WATk;
		}
		[CompilerGenerated]
		set
		{
			fclL1l1WATk = value;
		}
	}

	public string StepIcon
	{
		[CompilerGenerated]
		get
		{
			return wQjL1iqnwTT;
		}
		[CompilerGenerated]
		set
		{
			wQjL1iqnwTT = value;
		}
	}

	public string IconTooltip
	{
		[CompilerGenerated]
		get
		{
			return O3QL13BtVfg;
		}
		[CompilerGenerated]
		set
		{
			O3QL13BtVfg = value;
		}
	}

	public event RoutedEventHandler TriggerContextMenu
	{
		add
		{
			AddHandler(TriggerContextMenuEvent, value);
		}
		remove
		{
			RemoveHandler(TriggerContextMenuEvent, value);
		}
	}

	public event RoutedEventHandler TriggerEdit
	{
		add
		{
			AddHandler(TriggerEditEvent, value);
		}
		remove
		{
			RemoveHandler(TriggerEditEvent, value);
		}
	}

	public StepNodeControl()
	{
		base.MouseRightButtonDown += hyFL15Vitvy;
		base.MouseLeftButtonDown += ufuL1dcexIV;
		base.MouseWheel += LwKL1nSPfQn;
	}

	private void LwKL1nSPfQn(object sender, MouseWheelEventArgs e)
	{
		if (!Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			return;
		}
		int num = ((!Keyboard.IsKeyDown(Key.LeftShift)) ? 1 : 10);
		if (StepNode.Step.StepRunnerKey == "sys:delay")
		{
			ActionStepParam actionStepParam = StepNode.Step.InputParams[WaitTimeRunner.delayMsParam.Key];
			if (string.IsNullOrEmpty(actionStepParam.Value))
			{
				return;
			}
			int num2 = 1;
			if (Ta0VQOFNd5ymMU5SykxO())
			{
				do
				{
					int result;
					switch (num2)
					{
					case 1:
						if (int.TryParse(actionStepParam.Value, out result))
						{
							result += ((e.Delta > 0) ? (50 * num) : (-50 * num));
							if (result < 0)
							{
								result = 0;
							}
							goto IL_00a7;
						}
						return;
					}
					break;
					IL_00a7:
					actionStepParam.Value = result.ToString();
					num2 = 0;
				}
				while (rxK9CdFNvqX6cMBHb7a0 == null);
			}
			StepNode.NotifyStepDataChange();
			e.Handled = true;
		}
		else if (StepNode.Step.StepType.CanScrollUpdateDelay())
		{
			int delayMs = StepNode.DelayMs;
			delayMs += ((e.Delta > 0) ? (20 * num) : (-20 * num));
			if (delayMs < 0)
			{
				delayMs = 0;
			}
			StepNode.DelayMs = delayMs;
			e.Handled = true;
		}
	}

	private void y1NL14FR1rE()
	{
		RoutedEventArgs e = new RoutedEventArgs(TriggerContextMenuEvent, this);
		RaiseEvent(e);
	}

	private void hyFL15Vitvy(object sender, MouseButtonEventArgs e)
	{
		if (StepNode != null)
		{
			y1NL14FR1rE();
		}
	}

	private void bqIL1DMXRNP()
	{
		RoutedEventArgs e = new RoutedEventArgs(TriggerEditEvent, this);
		RaiseEvent(e);
	}

	private void ufuL1dcexIV(object sender, MouseButtonEventArgs e)
	{
		if (e.Handled)
		{
			return;
		}
		if (e.ClickCount == 2 && !Keyboard.IsKeyDown(Key.LeftAlt))
		{
			int num = 0;
			if (rxK9CdFNvqX6cMBHb7a0 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!Keyboard.IsKeyDown(Key.RightAlt))
			{
				e.Handled = true;
				bqIL1DMXRNP();
				return;
			}
		}
		if (Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt))
		{
			StepNode.Disabled = !StepNode.Disabled;
			e.Handled = true;
		}
	}

	private static void BgUL1o6qok6(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is StepNodeControl stepNodeControl)
		{
			stepNodeControl.PdtL1TvCgsD();
		}
	}

	private void PdtL1TvCgsD()
	{
		IsCommentStep = StepNode.Runner is CommentStep;
		if (StepNode.Runner is SubProgramStep)
		{
			if (rxK9CdFNvqX6cMBHb7a0 == null)
			{
				switch (0)
				{
				}
			}
			(string, string) subProgramIcon = SubProgramStep.GetSubProgramIcon(StepNode.Step);
			StepIcon = subProgramIcon.Item1;
			IconTooltip = subProgramIcon.Item2;
			IsSubProgramStep = true;
		}
		else
		{
			StepIcon = StepNode.Runner.Icon;
			IconTooltip = StepNode.Runner.Description;
		}
		HasChildSteps = StepNode.Runner.StepType.IsEither(StepType.If, StepType.Loop);
		HasElseSteps = StepNode.Runner.StepType != StepType.Loop;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (HasChildSteps)
		{
			wGRL1MDR67y = GetTemplateChild("IfList") as StepListControl;
			wGRL1MDR67y.SetSteps(StepNode.IfSteps);
			if (HasElseSteps)
			{
				O37L1AoIbMH = GetTemplateChild("ElseList") as StepListControl;
				O37L1AoIbMH.SetSteps(StepNode.ElseSteps);
			}
		}
	}

	static StepNodeControl()
	{
		VtIL1O9x3am = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		TriggerContextMenuEvent = EventManager.RegisterRoutedEvent("TriggerContextMenu", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(StepNodeControl));
		TriggerEditEvent = EventManager.RegisterRoutedEvent("TriggerEdit", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(StepNodeControl));
		StepNodeProperty = DependencyProperty.Register("StepNode", typeof(global::Quicker.View.X.Nodes.StepNode), typeof(StepNodeControl), new PropertyMetadata(null, BgUL1o6qok6));
		HasChildStepsProperty = DependencyProperty.Register("HasChildSteps", typeof(bool), typeof(global::Quicker.View.X.Nodes.StepNodeControl), new PropertyMetadata(false));
	}

	internal static bool Ta0VQOFNd5ymMU5SykxO()
	{
		return rxK9CdFNvqX6cMBHb7a0 == null;
	}
}
