using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.UI;
using UniversalRecognizer.PointPatterns;

namespace Quicker.View.Mouse;

public class AddGestureWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec NcSSprZZQtA;

		public static Func<StylusPoint, System.Windows.Point> SiMSppUeiin;

		internal static _003C_003Ec e7w2iqWUqpxFfNQjSM3O;

		static _003C_003Ec()
		{
			NcSSprZZQtA = new _003C_003Ec();
		}

		internal System.Windows.Point VFiSpxbKhQZ(StylusPoint x)
		{
			return new System.Windows.Point
			{
				X = x.X,
				Y = x.Y
			};
		}

		internal static bool TLSBvVWUiawatdYdXCLZ()
		{
			return e7w2iqWUqpxFfNQjSM3O == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public string mpDSpQnVVh0;

		internal static _003C_003Ec__DisplayClass11_0 DUpi0WWUZrt1V5ATic8L;

		internal bool mvfSpBgHIx0(Gesture x)
		{
			return x.Id == mpDSpQnVVh0;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}

		internal static void vb1DpjWU8pAcIwELjXlf()
		{
		}

		internal static bool nQs8myWU5txTwWAQdHMX()
		{
			return DUpi0WWUZrt1V5ATic8L == null;
		}

		internal static void NyKfnyWURa10AdjcqB2y()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public PointPattern x;

		internal static _003C_003Ec__DisplayClass6_0 wiJ9cmWUg7qocC8xuOeZ;

		internal bool oChSpjiKG8l(Gesture existGesture)
		{
			return existGesture.Id != "preset:" + x.Name;
		}

		internal static bool HeRVCuWUPI83roUBrwsc()
		{
			return wiJ9cmWUg7qocC8xuOeZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_1
	{
		public int x;

		internal static _003C_003Ec__DisplayClass6_1 du8IcBWUx9QUGIFcVkIs;

		internal bool y2wSpnSmHuK(Gesture g)
		{
			return g.Name != "手势_" + x;
		}

		internal static bool y31BM6WUI7WSsJvy54aC()
		{
			return du8IcBWUx9QUGIFcVkIs == null;
		}
	}

	private readonly DataService lGZLLjYE4Py;

	[CompilerGenerated]
	private IList<Gesture> VSDLLnmwC3L;

	internal ListBox LbGestures;

	internal Button BtnSelectPreset;

	internal InkCanvas TheInkCanvas;

	internal GesturePreviewControl TheGesturePreviewControl;

	internal TextBox TxtName;

	internal Button BtnSaveGesture;

	private bool D45LL4hVmq1;

	private static AddGestureWindow gcIpFvFAaqrTjEixGopA;

	public IList<Gesture> Result
	{
		[CompilerGenerated]
		get
		{
			return VSDLLnmwC3L;
		}
		[CompilerGenerated]
		private set
		{
			VSDLLnmwC3L = value;
		}
	}

	public AddGestureWindow(DataService dataService)
	{
		lGZLLjYE4Py = dataService;
		InitializeComponent();
		base.Loaded += A5NLLXpd97q;
	}

	private void A5NLLXpd97q(object sender, RoutedEventArgs e)
	{
		LbGestures.ItemsSource = PresetGestures.Gestures.Where(VreLLpRmtbp);
		TxtName.Text = "手势_" + Enumerable.Range(1, 300).First(rsVLLBijJos);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void hGYLLmkKq3e(object sender, RoutedEventArgs e)
	{
		if (LbGestures.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择手势.", true);
			return;
		}
		List<Gesture> list = new List<Gesture>();
		foreach (object selectedItem in LbGestures.SelectedItems)
		{
			PointPattern pointPattern = selectedItem as PointPattern;
			list.Add(new Gesture("preset:" + pointPattern.Name, pointPattern.Name, pointPattern.WindowsPoints));
		}
		Result = list;
		base.DialogResult = true;
	}

	private void lieLLKptYrv(object sender, RoutedEventArgs e)
	{
		if (TheGesturePreviewControl.Points == null)
		{
			AppHelper.ShowWarning("请先绘制手势。");
		}
		else if (TxtName.EnsureNotEmpty("手势名称"))
		{
			Result = new List<Gesture>
			{
				new Gesture(Guid.NewGuid().ToString(), TxtName.Text, TheGesturePreviewControl.Points.ToArray())
			};
			base.DialogResult = true;
		}
	}

	private void eSQLLxDSVf0(object sender, MouseButtonEventArgs e)
	{
	}

	private void hagLLrwKqDj(object sender, MouseButtonEventArgs e)
	{
        Gesture gesture = default;
		System.Windows.Point[] array;
		PointPatternMatchResult[] pointPatternMatchResults;
		PointPatternMatchResult pointPatternMatchResult;
		int num;
		if (TheInkCanvas.Strokes.Count == 1)
		{
			array = TheInkCanvas.Strokes[0].StylusPoints.Select(_003C_003Ec.SiMSppUeiin ?? (_003C_003Ec.SiMSppUeiin = _003C_003Ec.NcSSprZZQtA.VFiSpxbKhQZ)).ToArray();
			if (array.Length >= 30)
			{
				pointPatternMatchResults = new PointPatternAnalyzer(lGZLLjYE4Py.Y0Etm2L8Pto(), 100).GetPointPatternMatchResults(array);
				if (pointPatternMatchResults.Length != 0)
				{
					pointPatternMatchResult = pointPatternMatchResults.First();
					num = 0;
					if (gcIpFvFAaqrTjEixGopA != null)
					{
						goto IL_00b4;
					}
					goto IL_0117;
				}
				goto IL_0167;
			}
			AppHelper.ShowWarning("线太短了，请重试。");
			TheGesturePreviewControl.Points = null;
		}
		goto IL_0187;
		IL_00b4:
		gesture = default(Gesture);
		if (pointPatternMatchResult.Probability > 85.0)
		{
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
			pointPatternMatchResult = pointPatternMatchResults.First();
			_003C_003Ec__DisplayClass11_.mpDSpQnVVh0 = pointPatternMatchResult.PatternId;
			gesture = lGZLLjYE4Py.Y0Etm2L8Pto().FirstOrDefault(_003C_003Ec__DisplayClass11_.mvfSpBgHIx0);
			num = 1;
			if (!Bb61QIFArPOuoCna4VHm())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0117;
		}
		goto IL_0167;
		IL_0187:
		TheInkCanvas.Strokes.Clear();
		TheInkCanvas.UpdateLayout();
		return;
		IL_0167:
		TheGesturePreviewControl.Points = PointPatternMath.GetInterpolatedPointArray(array, 100);
		TxtName.Focus();
		goto IL_0187;
		IL_0117:
		switch (num)
		{
		case 1:
			goto IL_0126;
		}
		goto IL_00b4;
		IL_0126:
		AppHelper.ShowWarning($"已有此手势或与现有手势轨迹 \"{gesture?.Name}\" 过度相似({pointPatternMatchResults.First().Probability})，请重试。");
		TheGesturePreviewControl.Points = null;
		goto IL_0187;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!D45LL4hVmq1)
		{
			D45LL4hVmq1 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/addgesturewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			D45LL4hVmq1 = true;
			break;
		case 1:
			LbGestures = (ListBox)target;
			break;
		case 2:
		{
			BtnSelectPreset = (Button)target;
			int num = 0;
			if (gcIpFvFAaqrTjEixGopA != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnSelectPreset.Click += hGYLLmkKq3e;
				break;
			}
			break;
		}
		case 3:
			TheInkCanvas = (InkCanvas)target;
			TheInkCanvas.MouseDown += eSQLLxDSVf0;
			TheInkCanvas.MouseUp += hagLLrwKqDj;
			break;
		case 4:
			TheGesturePreviewControl = (GesturePreviewControl)target;
			break;
		case 5:
			TxtName = (TextBox)target;
			break;
		case 6:
			BtnSaveGesture = (Button)target;
			BtnSaveGesture.Click += lieLLKptYrv;
			break;
		}
	}

	[CompilerGenerated]
	private bool VreLLpRmtbp(PointPattern pointPattern_0)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.x = pointPattern_0;
		return lGZLLjYE4Py.Y0Etm2L8Pto().All(_003C_003Ec__DisplayClass6_.oChSpjiKG8l);
	}

	[CompilerGenerated]
	private bool rsVLLBijJos(int int_0)
	{
		_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1();
		_003C_003Ec__DisplayClass6_.x = int_0;
		return lGZLLjYE4Py.Y0Etm2L8Pto().All(_003C_003Ec__DisplayClass6_.y2wSpnSmHuK);
	}

	internal static void P3gGAUFA9utLIWWRLtA6()
	{
	}

	internal static bool Bb61QIFArPOuoCna4VHm()
	{
		return gcIpFvFAaqrTjEixGopA == null;
	}
}
