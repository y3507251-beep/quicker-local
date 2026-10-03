using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using CW;
using IflySdk;
using IflySdk.Enum;
using IflySdk.Model.Common;
using NAudio.Wave;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using snQ8SVoJZmpKYkXlGcy;

namespace Quicker.Actions.XActions.BuildinRunners.Sys.Sound;

public class VoiceInputWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public VoiceInputWindow KIfSbCQQ8ew;

		public string VsNSbPV9iLv;

		internal static _003C_003Ec__DisplayClass29_0 EfBHQCWiMrlFkIbgl4JA;

		internal void pA3Sb0dI8n0()
		{
			KIfSbCQQ8ew.ErrorMessage = VsNSbPV9iLv;
			KIfSbCQQ8ew.Close();
		}

		internal static void nFhE2RWiIFsLwbHJDNRe()
		{
		}

		internal static bool BR2DuOWiUKMWlg8RPP8Y()
		{
			return EfBHQCWiMrlFkIbgl4JA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public VoiceInputWindow BAXSb88ZPiS;

		public float kwbSba4rwJh;

		private static _003C_003Ec__DisplayClass34_0 ib9TheWi6ITygYfPpTU3;

		internal void VPSSbEtjxEF()
		{
			BAXSb88ZPiS.TxtResult.Text = "...";
		}

		internal void VFaSbyVYcUa()
		{
			BAXSb88ZPiS.ProgressBar.Value = (double)(AppHelper.fLiLTj0x4QY() - BAXSb88ZPiS.NIKgBunCNJc) / 1000.0;
			BAXSb88ZPiS.IconMic.Opacity = Math.Min(1.0, 0.1 + Math.Sqrt(kwbSba4rwJh) * 4.0);
		}

		internal static bool PrhmR3WitMTKTlhTTTdy()
		{
			return ib9TheWi6ITygYfPpTU3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public VoiceInputWindow RISSbR5GZhF;

		public string mrsSbq5WRXL;

		private static _003C_003Ec__DisplayClass36_0 DlJJGDWiTTsOKWoEaFtS;

		internal void zDuSb7TFJRD()
		{
			RISSbR5GZhF.TxtState.Text = mrsSbq5WRXL;
		}

		internal static bool q9QpTrWimepycr50ClyR()
		{
			return DlJJGDWiTTsOKWoEaFtS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public VoiceInputWindow T3lSbVF223b;

		public string wsNSbZHVFhd;

		internal static _003C_003Ec__DisplayClass37_0 g0ehfnWiCJny8yKlQRNv;

		internal void m3vSbcuwKDe()
		{
			T3lSbVF223b.TxtResult.Text = wsNSbZHVFhd;
		}

		static _003C_003Ec__DisplayClass37_0()
		{
		}

		internal static bool ilGkblWi7USGF9taiwJ8()
		{
			return g0ehfnWiCJny8yKlQRNv == null;
		}

		internal static void a0aleyWihsQoYW30KjJW()
		{
		}
	}

	private WaveInEvent VDRgpfbJUKr;

	private ASRApi T5ugpzfplMv;

	private float lLxgBwKNIfR = 0.01f;

	private float qN9gBtJQuPk = 0.05f;

	[CompilerGenerated]
	private string hACgBgb9SLt;

	[CompilerGenerated]
	private bool? NFIgBLejTdf;

	[CompilerGenerated]
	private string xl3gBvEerQT;

	[CompilerGenerated]
	private double gjvgBSyER4i;

	[CompilerGenerated]
	private AppSettings z7FgB2lo0Ip;

	private long NIKgBunCNJc;

	private vDPS50oKBWTdiSEguMZ DrvgBNpTMML;

	internal TextBlock TxtHelp;

	internal TextBlock TxtResult;

	internal ProgressBar ProgressBar;

	internal IconControl IconMic;

	internal TextBlock TxtState;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool hmmgBJZO6ho;

	internal static VoiceInputWindow EySIQIQhPdMU0KhSpQ4R;

	public string ResultText
	{
		[CompilerGenerated]
		get
		{
			return hACgBgb9SLt;
		}
		[CompilerGenerated]
		private set
		{
			hACgBgb9SLt = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return NFIgBLejTdf;
		}
		[CompilerGenerated]
		set
		{
			NFIgBLejTdf = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return xl3gBvEerQT;
		}
		[CompilerGenerated]
		private set
		{
			xl3gBvEerQT = value;
		}
	}

	public string HelpText
	{
		get
		{
			return TxtHelp.Text;
		}
		set
		{
			TxtHelp.Text = value;
		}
	}

	public double SilentStopSeconds
	{
		[CompilerGenerated]
		get
		{
			return gjvgBSyER4i;
		}
		[CompilerGenerated]
		set
		{
			gjvgBSyER4i = value;
		}
	}

	public AppSettings VendorSettings
	{
		[CompilerGenerated]
		get
		{
			return z7FgB2lo0Ip;
		}
		[CompilerGenerated]
		set
		{
			z7FgB2lo0Ip = value;
		}
	}

	public VoiceInputWindow()
	{
		InitializeComponent();
		base.Loaded += E3OgpjHy0Jf;
		base.Closed += CqSgpQPUolk;
	}

	private void CqSgpQPUolk(object sender, EventArgs e)
	{
		VZUgpDSq6XZ();
	}

	private void E3OgpjHy0Jf(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
		_003C_003Ec__DisplayClass29_.KIfSbCQQ8ew = this;
		NativeMethods.SetWindowNoActivate(this);
		try
		{
			KJGgpnuGdZq();
		}
		catch (Exception ex)
		{
			_003C_003Ec__DisplayClass29_.VsNSbPV9iLv = ex.Message;
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass29_.pA3Sb0dI8n0);
		}
	}

	private void KJGgpnuGdZq()
	{
		T5ugpzfplMv = new ApiBuilder().WithAppSettings(VendorSettings).WithVadEos((int)(SilentStopSeconds * 1000.0 + 1500.0)).UseError(VWygpOVAQcU)
			.UseMessage(LoMgpF6W9fF)
			.BuildASR();
		VDRgpfbJUKr = new WaveInEvent();
		VDRgpfbJUKr.WaveFormat = new WaveFormat(16000, 1);
		int num = 0;
		if (!rCliskQhMVa6UDhYkash())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		VDRgpfbJUKr.BufferMilliseconds = 40;
		DrvgBNpTMML = new vDPS50oKBWTdiSEguMZ(lLxgBwKNIfR, qN9gBtJQuPk);
		VDRgpfbJUKr.DataAvailable += U6egp5TQamO;
		VDRgpfbJUKr.RecordingStopped += qyKgp4l7bEe;
		VDRgpfbJUKr.StartRecording();
		NIKgBunCNJc = 0L;
		V8ogpdi6qss("识别中...");
	}

	private void qyKgp4l7bEe(object sender, StoppedEventArgs e)
	{
		V8ogpdi6qss("结束录音...");
		VDRgpfbJUKr?.Dispose();
		VDRgpfbJUKr = null;
		if (EySIQIQhPdMU0KhSpQ4R == null)
		{
			switch (0)
			{
			}
		}
		T5ugpzfplMv.Stop();
		if (!Result.HasValue)
		{
			if (!ResultText.IsNullOrEmpty())
			{
				Result = true;
			}
			else
			{
				Result = false;
			}
		}
		base.Dispatcher.InvokeAsync(fm9gpUhPbuV);
	}

	private void U6egp5TQamO(object sender, WaveInEventArgs e)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.BAXSb88ZPiS = this;
		_003C_003Ec__DisplayClass34_.kwbSba4rwJh = vDPS50oKBWTdiSEguMZ.MxbgBCJpLm2(e);
		if (NIKgBunCNJc == 0L)
		{
			if (_003C_003Ec__DisplayClass34_.kwbSba4rwJh < lLxgBwKNIfR)
			{
				return;
			}
			base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass34_.VPSSbEtjxEF);
			NIKgBunCNJc = AppHelper.fLiLTj0x4QY();
			goto IL_00c0;
		}
		if (!((double)(AppHelper.fLiLTj0x4QY() - NIKgBunCNJc) > 59500.0))
		{
			if (!(SilentStopSeconds > 1.0) || !((double)DrvgBNpTMML.RDDgB02pG2R(e, _003C_003Ec__DisplayClass34_.kwbSba4rwJh) > SilentStopSeconds * 1000.0))
			{
				goto IL_00c0;
			}
			if (!rCliskQhMVa6UDhYkash())
			{
				switch (0)
				{
				}
			}
		}
		VDRgpfbJUKr.StopRecording();
		return;
		IL_00c0:
		byte[] data = xt2gpT0amha(e.Buffer, 0, e.BytesRecorded);
		T5ugpzfplMv.Convert(data);
		base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass34_.VFaSbyVYcUa);
	}

	private void VZUgpDSq6XZ()
	{
		VDRgpfbJUKr?.Dispose();
		VDRgpfbJUKr = null;
		if (T5ugpzfplMv != null && T5ugpzfplMv.Status == ServiceStatus.Running)
		{
			Task.Run((Action)eNtgpl0GR4W);
		}
	}

	private void V8ogpdi6qss(string string_2)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.RISSbR5GZhF = this;
		_003C_003Ec__DisplayClass36_.mrsSbq5WRXL = string_2;
		base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass36_.zDuSb7TFJRD);
	}

	private void AsCgpoaDChU(string string_2)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.T3lSbVF223b = this;
		_003C_003Ec__DisplayClass37_.wsNSbZHVFhd = string_2;
		base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass37_.m3vSbcuwKDe);
	}

	private static byte[] xt2gpT0amha(byte[] byte_0, int int_0, int int_1)
	{
		if (int_0 >= 0 && int_0 <= byte_0.Length)
		{
			if (int_1 >= 0)
			{
				byte[] array;
				if (int_0 + int_1 <= byte_0.Length)
				{
					array = new byte[int_1];
					Array.Copy(byte_0, int_0, array, 0, int_1);
				}
				else
				{
					array = new byte[byte_0.Length - int_0];
					Array.Copy(byte_0, int_0, array, 0, byte_0.Length - int_0);
				}
				return array;
			}
			int num = 0;
			if (!rCliskQhMVa6UDhYkash())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return null;
	}

	private void IconMic_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
	{
		try
		{
			Process.Start("ms-settings:sound");
		}
		catch (Exception)
		{
			AppHelper.ShowWarning("无法打开 ");
		}
	}

	private void QungpMc0s2k(object sender, RoutedEventArgs e)
	{
		Result = true;
		try
		{
			VDRgpfbJUKr?.StopRecording();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("结束录制出错：" + ex.Message);
		}
	}

	private void DmagpASMAZM(object sender, RoutedEventArgs e)
	{
		Result = false;
		try
		{
			VDRgpfbJUKr?.StopRecording();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("停止录制出错：" + ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!hmmgBJZO6ho)
		{
			hmmgBJZO6ho = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/xactions/buildinrunners/sys/sound/voiceinputwindow.xaml", UriKind.Relative);
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
			hmmgBJZO6ho = true;
			break;
		case 1:
			TxtHelp = (TextBlock)target;
			break;
		case 2:
			TxtResult = (TextBlock)target;
			break;
		case 3:
			ProgressBar = (ProgressBar)target;
			break;
		case 4:
			IconMic = (IconControl)target;
			break;
		case 5:
			TxtState = (TextBlock)target;
			break;
		case 6:
			BtnOk = (Button)target;
			BtnOk.Click += QungpMc0s2k;
			break;
		case 7:
			BtnCancel = (Button)target;
			if (EySIQIQhPdMU0KhSpQ4R == null)
			{
				switch (0)
				{
				}
			}
			BtnCancel.Click += DmagpASMAZM;
			break;
		}
	}

	[CompilerGenerated]
	private void VWygpOVAQcU(object sender, ErrorEventArgs e)
	{
		if (e.Code != ResultCode.Disconnect)
		{
			V8ogpdi6qss("错误：" + e.Message);
		}
		ErrorMessage = e.Message;
		VDRgpfbJUKr?.StopRecording();
	}

	[CompilerGenerated]
	private void LoMgpF6W9fF(object object_0, string string_2)
	{
		AsCgpoaDChU(string_2);
		ResultText = string_2;
	}

	[CompilerGenerated]
	private void fm9gpUhPbuV()
	{
		try
		{
			Close();
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void eNtgpl0GR4W()
	{
		try
		{
			T5ugpzfplMv?.Stop();
			T5ugpzfplMv?.Dispose();
		}
		catch (Exception)
		{
		}
	}

	static VoiceInputWindow()
	{
	}

	internal static bool rCliskQhMVa6UDhYkash()
	{
		return EySIQIQhPdMU0KhSpQ4R == null;
	}

	internal static void luYRQKQhwU4cfmPcdHZu()
	{
	}
}
