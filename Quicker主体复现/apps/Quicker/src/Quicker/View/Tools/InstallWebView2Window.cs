using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using eqOmvXXN5XVBTDBbWA2;
using Quicker.Utilities;

namespace Quicker.View.Tools;

public class InstallWebView2Window : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public InstallWebView2Window ySASB9jKkW2;

		public string url;

		public string fn6SBh4FtJ1;

		private static _003C_003Ec__DisplayClass5_0 TtfxjPWxvcacvfGaCUbm;

		internal void kvFSBZNhinE()
		{
			fn6SBh4FtJ1 = ySASB9jKkW2.bH9LSP9tZoL(url);
		}

		internal static bool Tm0Iw2Wxd7M85aXNYXWj()
		{
			return TtfxjPWxvcacvfGaCUbm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public InstallWebView2Window CiHSBYvXADk;

		public int R3HSBInllHY;

		public int E61SBWLjYgY;

		private static _003C_003Ec__DisplayClass7_0 rjVLTrWxJZDfpomlRCw7;

		internal void dhKSBeJqVrE()
		{
			CiHSBYvXADk.DownloadProgress.Maximum = R3HSBInllHY;
			CiHSBYvXADk.DownloadProgress.Value = E61SBWLjYgY;
		}

		internal static bool xJnhVnWxkIDR4CI8PId0()
		{
			return rjVLTrWxJZDfpomlRCw7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDownload_OnClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InstallWebView2Window _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object yu6OuMWxrGgPRkxXImGE;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InstallWebView2Window installWebView2Window = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass5_0();
					_003C_003E8__1.ySASB9jKkW2 = _003C_003E4__this;
					_003C_003E8__1.url = "https://go.microsoft.com/fwlink/p/?LinkId=2124703";
					installWebView2Window.BtnDownload.IsEnabled = false;
				}
				try
				{
					ConfiguredTaskAwaitable configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
					int num2;
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					if (num != 0)
					{
						_003C_003E8__1.fn6SBh4FtJ1 = string.Empty;
						AppHelper.ShowInformation("开始下载了，请稍等...");
						installWebView2Window.DownloadProgress.Visibility = Visibility.Visible;
						configuredTaskAwaitable = Task.Run((Action)_003C_003E8__1.kvFSBZNhinE).ConfigureAwait(true);
						num2 = 0;
						if (yu6OuMWxrGgPRkxXImGE == null)
						{
							goto IL_00d9;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						num2 = 1;
						if (nEWes8WxNa6gi5osgAZW())
						{
							goto IL_010d;
						}
					}
					switch (num2)
					{
					case 1:
						goto IL_010d;
					}
					goto IL_00d9;
					IL_010d:
					awaiter.GetResult();
					installWebView2Window.DownloadProgress.Visibility = Visibility.Collapsed;
					installWebView2Window.BtnDownload.Visibility = Visibility.Collapsed;
					try
					{
						Process.Start(new ProcessStartInfo(_003C_003E8__1.fn6SBh4FtJ1)
						{
							Verb = "runas"
						});
					}
					catch (Exception)
					{
						AppHelper.SelectFileInExplorer(_003C_003E8__1.fn6SBh4FtJ1, false);
					}
					if (installWebView2Window.ManualClose)
					{
						installWebView2Window.BtnClose.Visibility = Visibility.Visible;
					}
					else
					{
						installWebView2Window.Close();
					}
					goto end_IL_004a;
					IL_00d9:
					awaiter = configuredTaskAwaitable.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_010d;
					end_IL_004a:;
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning(ex2.Message, true);
				}
				finally
				{
					if (num < 0)
					{
						installWebView2Window.BtnDownload.IsEnabled = true;
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool nEWes8WxNa6gi5osgAZW()
		{
			return yu6OuMWxrGgPRkxXImGE == null;
		}
	}

	[CompilerGenerated]
	private bool EnoLS8WCIEs;

	internal Button BtnDownload;

	internal Button BtnClose;

	internal ProgressBar DownloadProgress;

	private bool Va5LSajvCXj;

	internal static InstallWebView2Window TkPARMFnHMdduO5TR41R;

	public bool ManualClose
	{
		[CompilerGenerated]
		get
		{
			return EnoLS8WCIEs;
		}
		[CompilerGenerated]
		set
		{
			EnoLS8WCIEs = value;
		}
	}

	public InstallWebView2Window()
	{
		InitializeComponent();
	}

	[AsyncStateMachine(typeof(_003CBtnDownload_OnClick_003Ed__5))]
	private void aJQLSCmHfDe(object sender, RoutedEventArgs e)
	{
		_003CBtnDownload_OnClick_003Ed__5 stateMachine = default(_003CBtnDownload_OnClick_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private string bH9LSP9tZoL(string string_0)
	{
        string text3 = default;
        byte[] buffer = default;
        int num2 = default;
        Stream stream2 = default;
        int num3 = default;
		using N4iMQlXvFGVBcTKiGAT n4iMQlXvFGVBcTKiGAT = new N4iMQlXvFGVBcTKiGAT();
		using Stream stream = n4iMQlXvFGVBcTKiGAT.OpenRead(string_0);
		if (stream == null)
		{
			throw new InvalidOperationException("读取到的内容为空。");
		}
		string text = string.Empty;
		string text2 = n4iMQlXvFGVBcTKiGAT.ResponseHeaders["content-disposition"];
		if (!string.IsNullOrEmpty(text2))
		{
			text = new ContentDisposition(text2).FileName;
		}
		long.TryParse(n4iMQlXvFGVBcTKiGAT.ResponseHeaders.Get("Content-Length"), out var result);
		text = text.Trim(' ', '"');
		int num;
		if (string.IsNullOrEmpty(text))
		{
			string fileName = Path.GetFileName(n4iMQlXvFGVBcTKiGAT.CwOgJFUKW1T().LocalPath);
			if (!string.IsNullOrEmpty(fileName))
			{
				text = fileName;
				num = 0;
				if (!pXmMLBFnzOTLLRYRwl6L())
				{
					goto IL_0147;
				}
				goto IL_014b;
			}
		}
		goto IL_018b;
		IL_01ec:
		stream2 = default(Stream);
		stream2.Close();
		goto IL_0200;
		IL_01da:
		num2 = default(int);
		buffer = default(byte[]);
		int count = default(int);
		if ((num2 = stream.Read(buffer, 0, count)) > 0)
		{
			goto IL_01bc;
		}
		goto IL_01ec;
		IL_018b:
		if (string.IsNullOrEmpty(text))
		{
			text = "webview2_installer_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".msi";
		}
		text3 = "";
		num3 = default(int);
		if (text.Length > 0)
		{
			string path = KnownFolders.GetPath(KnownFolder.Downloads);
			text3 = Path.Combine(path, text);
			while (File.Exists(text3))
			{
				text3 = Path.Combine(path, Path.GetFileNameWithoutExtension(text) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(text));
			}
			stream2 = File.Create(text3);
			if (result == 0L)
			{
				num = 3;
				if (!pXmMLBFnzOTLLRYRwl6L())
				{
					goto IL_0147;
				}
				goto IL_014b;
			}
			count = 4096;
			buffer = new byte[4096];
			num3 = 0;
			goto IL_01da;
		}
		throw new InvalidOperationException("无法确定文件名。");
		IL_0200:
		stream.Close();
		return text3;
		IL_01bc:
		stream2.Write(buffer, 0, num2);
		num3 += num2;
		ARkLSEBG7sg((int)result, num3);
		goto IL_01da;
		IL_0147:
		int num4 = default(int);
		num = num4;
		goto IL_014b;
		IL_014b:
		switch (num)
		{
		case 3:
			goto IL_0199;
		case 1:
			goto IL_01bc;
		case 2:
			goto IL_0200;
		}
		goto IL_018b;
		IL_0199:
		stream.CopyTo(stream2);
		goto IL_01ec;
	}

	private void ARkLSEBG7sg(int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.CiHSBYvXADk = this;
		_003C_003Ec__DisplayClass7_.R3HSBInllHY = int_1;
		_003C_003Ec__DisplayClass7_.E61SBWLjYgY = int_0;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass7_.dhKSBeJqVrE);
	}

	private void K0ULSykjX5J(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Va5LSajvCXj)
		{
			Va5LSajvCXj = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/tools/installwebview2window.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			Va5LSajvCXj = true;
			break;
		case 1:
			BtnDownload = (Button)target;
			BtnDownload.Click += aJQLSCmHfDe;
			break;
		case 2:
			BtnClose = (Button)target;
			BtnClose.Click += K0ULSykjX5J;
			break;
		case 3:
			DownloadProgress = (ProgressBar)target;
			break;
		}
	}

	internal static bool pXmMLBFnzOTLLRYRwl6L()
	{
		return TkPARMFnHMdduO5TR41R == null;
	}
}
