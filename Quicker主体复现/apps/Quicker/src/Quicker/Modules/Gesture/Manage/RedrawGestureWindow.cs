using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.UI;
using Quicker.View.Mouse;
using UniversalRecognizer.PointPatterns;

namespace Quicker.Modules.Gesture.Manage;

public class RedrawGestureWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec EpcvebH3xOV;

		public static Func<StylusPoint, System.Windows.Point> HBjve6xWscQ;

		private static _003C_003Ec bu7SJGcqEhUwTjon97mv;

		static _003C_003Ec()
		{
			EpcvebH3xOV = new _003C_003Ec();
		}

		internal System.Windows.Point yiPve17S6dZ(StylusPoint x)
		{
			return new System.Windows.Point
			{
				X = x.X,
				Y = x.Y
			};
		}

		internal static void ta7r8Icq1qriJ9dQXJlm()
		{
		}

		internal static bool tEWkwKcqGfCFRnbtvrMs()
		{
			return bu7SJGcqEhUwTjon97mv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public string mnBvemDhItl;

		internal static _003C_003Ec__DisplayClass9_0 DOjQUrcqKDO1mwlIVl0l;

		internal bool B0xveXv2Aq1(Quicker.Utilities._3rd.Gestures.Gesture x)
		{
			return x.Id == mnBvemDhItl;
		}

		internal static bool GDtCtBcqB2XWumU2lpjm()
		{
			return DOjQUrcqKDO1mwlIVl0l == null;
		}
	}

	private readonly Quicker.Utilities._3rd.Gestures.Gesture OALOM68oZ3;

	[CompilerGenerated]
	private Quicker.Utilities._3rd.Gestures.Gesture YrGOADoZTa;

	internal InkCanvas TheInkCanvas;

	internal GesturePreviewControl TheGesturePreviewControl;

	internal TextBox TxtName;

	internal Button BtnSaveGesture;

	internal Button BtnCancel;

	private bool uVqOOtPrJM;

	internal static RedrawGestureWindow HxiTpizO8Q33jmhJLLy;

	public Quicker.Utilities._3rd.Gestures.Gesture Result
	{
		[CompilerGenerated]
		get
		{
			return YrGOADoZTa;
		}
		[CompilerGenerated]
		set
		{
			YrGOADoZTa = value;
		}
	}

	public RedrawGestureWindow(Quicker.Utilities._3rd.Gestures.Gesture editingGesture)
	{
		OALOM68oZ3 = editingGesture;
		InitializeComponent();
		TxtName.Text = OALOM68oZ3.Name;
		TheGesturePreviewControl.Points = OALOM68oZ3.WindowsPoints;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void nyfO5s5gRQ(object sender, RoutedEventArgs e)
	{
		if (TheGesturePreviewControl.Points == null)
		{
			AppHelper.ShowWarning("请先绘制手势。");
		}
		else if (TxtName.EnsureNotEmpty("手势名称"))
		{
			Result = new Quicker.Utilities._3rd.Gestures.Gesture(OALOM68oZ3.Id, TxtName.Text, TheGesturePreviewControl.Points.ToArray());
			this.ThNvuM5Q9GQ(true);
		}
	}

	private void qNpOD5iP9x(object sender, MouseButtonEventArgs e)
	{
	}

	private void RQhOdpvmfB(object sender, MouseButtonEventArgs e)
	{
		System.Windows.Point[] array;
		PointPatternMatchResult[] pointPatternMatchResults;
		int num;
		if (TheInkCanvas.Strokes.Count == 1)
		{
			array = TheInkCanvas.Strokes[0].StylusPoints.Select(_003C_003Ec.HBjve6xWscQ ?? (_003C_003Ec.HBjve6xWscQ = _003C_003Ec.EpcvebH3xOV.yiPve17S6dZ)).ToArray();
			if (array.Length >= 30)
			{
				pointPatternMatchResults = new PointPatternAnalyzer(AppState.DataService.Y0Etm2L8Pto().Union(PresetGestures.Gestures).Where(SjHOTOeWhR)
					.ToArray(), 100).GetPointPatternMatchResults(array);
				if (pointPatternMatchResults.Length != 0)
				{
					num = 1;
					if (HxiTpizO8Q33jmhJLLy != null)
					{
						goto IL_00ca;
					}
					goto IL_00f9;
				}
				goto IL_01c2;
			}
			AppHelper.ShowWarning("线太短了，请重试。");
			TheGesturePreviewControl.Points = null;
		}
		goto IL_01e2;
		IL_00ca:
		if (pointPatternMatchResults.First().Probability > 85.0)
		{
			num = 0;
			if (!L0MXPtzJT5F0Y5rL0ly())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00f9;
		}
		goto IL_01c2;
		IL_01e2:
		TheInkCanvas.Strokes.Clear();
		TheInkCanvas.UpdateLayout();
		return;
		IL_00f9:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0106;
		}
		goto IL_00ca;
		IL_0106:
		if (!(pointPatternMatchResults.First().PatternId != OALOM68oZ3.Id))
		{
			goto IL_01c2;
		}
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.mnBvemDhItl = pointPatternMatchResults.First().PatternId;
		Quicker.Utilities._3rd.Gestures.Gesture gesture = AppState.DataService.Y0Etm2L8Pto().FirstOrDefault(_003C_003Ec__DisplayClass9_.B0xveXv2Aq1);
		AppHelper.ShowWarning($"已有此手势或与现有手势({gesture?.Name?.Or(gesture?.Id)})过度相似({pointPatternMatchResults.First().Probability})，请重试。");
		TheGesturePreviewControl.Points = null;
		goto IL_01e2;
		IL_01c2:
		TheGesturePreviewControl.Points = PointPatternMath.GetInterpolatedPointArray(array, 100);
		TxtName.Focus();
		goto IL_01e2;
	}

	private void Ng3OondSwG(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!uVqOOtPrJM)
		{
			uVqOOtPrJM = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/redrawgesturewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			uVqOOtPrJM = true;
			break;
		case 1:
		{
			TheInkCanvas = (InkCanvas)target;
			TheInkCanvas.MouseDown += qNpOD5iP9x;
			int num = 0;
			if (HxiTpizO8Q33jmhJLLy != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				TheInkCanvas.MouseUp += RQhOdpvmfB;
				break;
			}
			break;
		}
		case 2:
			TheGesturePreviewControl = (GesturePreviewControl)target;
			break;
		case 3:
			TxtName = (TextBox)target;
			break;
		case 4:
			BtnSaveGesture = (Button)target;
			BtnSaveGesture.Click += nyfO5s5gRQ;
			break;
		case 5:
			BtnCancel = (Button)target;
			BtnCancel.Click += Ng3OondSwG;
			break;
		}
	}

	[CompilerGenerated]
	private bool SjHOTOeWhR(PointPattern pointPattern_0)
	{
		return pointPattern_0.Id != OALOM68oZ3.Id;
	}

	internal static bool L0MXPtzJT5F0Y5rL0ly()
	{
		return HxiTpizO8Q33jmhJLLy == null;
	}
}
