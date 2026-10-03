using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CpRmjmYrY5NIYQiiVIA;
using FontAwesome5.WPF;
using JTIh7V5l65QV75A93Ly;
using jUHfG42nmbml7b5l5N7;
using log4net;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Icons;
using Quicker.Utilities.Images;
using SVGImage.SVG;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.Controls;

public class IconControl : ContentControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec B8ISioIbNBF;

		public static Func<ImageSource> vgJSiTmmmsw;

		internal static _003C_003Ec aqJfVsyyTCErv9hpC1fQ;

		static _003C_003Ec()
		{
			B8ISioIbNBF = new _003C_003Ec();
		}

		internal ImageSource jdmSidncFKs()
		{
			return FileSystemIconHelper.GetIconImageFromPath(Path.GetTempPath());
		}

		internal static bool OA7CkIyymKarkej9Wekc()
		{
			return aqJfVsyyTCErv9hpC1fQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public string CmJSiAx49vt;

		internal static _003C_003Ec__DisplayClass33_0 ieE9V4yyCCEWZOQAZCXq;

		internal ImageSource WNHSiMqjsQC()
		{
			return FileSystemIconHelper.GetIconImageFromPath(CmJSiAx49vt);
		}

		internal static bool NtWkmhyy7pLlYOf0QrNS()
		{
			return ieE9V4yyCCEWZOQAZCXq == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoUpdateIconAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IconControl _003C_003E4__this;

		public string iconStr;

		private CancellationToken _003Ctoken_003E5__2;

		private ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__2;

		internal static object aHOTYnyyHUVNEF7Jd39g;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconControl iconControl = _003C_003E4__this;
			try
			{
        object obj = default;
				if ((uint)num <= 5u)
				{
					goto IL_00ba;
				}
				if (iconControl.LSSLQ7suOvL != null)
				{
					iconControl.LSSLQ7suOvL.Cancel();
					iconControl.LSSLQ7suOvL = null;
				}
				obj = default(object);
				if (iconStr.StartsWith("fa:", StringComparison.OrdinalIgnoreCase))
				{
					iconControl.m5MLQCUxZaq(iconStr);
				}
				else
				{
					if (!iconStr.StartsWith("text:"))
					{
						iconControl.LSSLQ7suOvL = new CancellationTokenSource();
						_003Ctoken_003E5__2 = iconControl.LSSLQ7suOvL.Token;
						obj = null;
						goto IL_00ba;
					}
					int num2 = 0;
					if (!qAcn7MyyzlKTSnfgrdeE())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						iconControl.IrMLQ23jtNu(iconStr);
						break;
					}
				}
				goto end_IL_0010;
				IL_00ba:
				try
				{
					int num5;
					ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
					ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter);
					int num4 = default(int);
					ImageSource imageSource = default(ImageSource);
					Drawing drawing = default(Drawing);
					ConfiguredTaskAwaitable<ImageSource> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<ImageSource>);
					string string_2;
					string string_3;
					switch (num)
					{
					default:
						num5 = 0;
						if (aHOTYnyyHUVNEF7Jd39g != null)
						{
							goto IL_01f4;
						}
						goto IL_0312;
					case 0:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_038b;
					case 1:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0269;
					case 2:
						awaiter = _003C_003Eu__2;
						num4 = 3;
						goto IL_0446;
					case 3:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter);
						goto IL_049c;
					case 4:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0438;
					case 5:
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_01a4;
						}
						IL_0312:
						while (true)
						{
							switch (num5)
							{
							case 6:
								if (imageSource != null)
								{
									goto IL_01db;
								}
								drawing = obj as Drawing;
								if (drawing == null)
								{
									goto end_IL_00bc;
								}
								goto case 8;
							case 2:
								goto end_IL_0312;
							case 3:
								goto IL_0446;
							case 5:
								goto IL_046a;
							case 9:
								goto IL_049c;
							case 10:
								goto IL_04b2;
							case 1:
								goto IL_0513;
							case 4:
								goto IL_05d3;
							case 8:
								iconControl.pLVLQ0y7kVW(drawing);
								goto end_IL_00bc;
							case 7:
								goto end_IL_00bc;
							}
							if (!iconStr.StartsWith("icon:", StringComparison.OrdinalIgnoreCase))
							{
								if (iconStr.StartsWith("shellicon:", StringComparison.OrdinalIgnoreCase))
								{
									goto IL_0226;
								}
								if (!iconStr.StartsWith("previmg:", StringComparison.CurrentCultureIgnoreCase))
								{
									if (iconStr.StartsWith("url:"))
									{
										goto IL_03c1;
									}
									if (Uri.IsWellFormedUriString(iconStr, UriKind.Absolute))
									{
										goto IL_046a;
									}
									if (iconStr.StartsWith(".") || iconStr[1] == ':')
									{
										configuredTaskAwaitable = iconControl.vhxLQNVrC8D(iconStr, _003Ctoken_003E5__2).ConfigureAwait(true);
										num5 = 0;
										if (qAcn7MyyzlKTSnfgrdeE())
										{
											break;
										}
										continue;
									}
									if (!File.Exists(iconStr))
									{
										goto IL_04b2;
									}
									goto IL_04e1;
								}
								obj = ImageHelper.IOnvNk2qgcn(iconStr.Substring("previmg:".Length), iconControl.Width);
								goto IL_0513;
							}
							string string_ = iconStr.Substring("icon:".Length);
							configuredTaskAwaitable = iconControl.vhxLQNVrC8D(string_, _003Ctoken_003E5__2).ConfigureAwait(true);
							awaiter2 = configuredTaskAwaitable.GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto IL_038b;
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter2;
							goto IL_05d3;
							IL_05d3:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
							IL_04b2:
							try
							{
								obj = AppHelper.GetResourceImage(iconStr);
							}
							catch (Exception exception)
							{
								SNALQEFKhxc.Warn("无法加载图标：" + iconStr, exception);
							}
							goto IL_0513;
							IL_01db:
							iconControl.kKNLQu4GJvv(imageSource);
							num5 = 7;
							if (qAcn7MyyzlKTSnfgrdeE())
							{
								continue;
							}
							goto IL_01f4;
							continue;
							end_IL_0312:
							break;
						}
						awaiter2 = configuredTaskAwaitable.GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 4;
							_003C_003E1__state = 4;
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0438;
						IL_049c:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_04a6;
						IL_0446:
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_045c;
						IL_0226:
						string_2 = iconStr.Substring("shellicon:".Length);
						configuredTaskAwaitable = iconControl.vhxLQNVrC8D(string_2, _003Ctoken_003E5__2).ConfigureAwait(true);
						awaiter2 = configuredTaskAwaitable.GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0269;
						IL_0269:
						obj = awaiter2.GetResult();
						num5 = 1;
						if (!qAcn7MyyzlKTSnfgrdeE())
						{
							goto IL_01f4;
						}
						goto IL_0312;
						IL_0513:
						if (!_003Ctoken_003E5__2.IsCancellationRequested)
						{
							if (obj != null)
							{
								imageSource = obj as ImageSource;
								num5 = 6;
								if (!qAcn7MyyzlKTSnfgrdeE())
								{
									goto IL_01f4;
								}
								goto IL_0312;
							}
							iconControl.Content = null;
							break;
						}
						break;
						IL_04e1:
						awaiter = iconControl.t1tLQJSS4pD(iconStr, _003Ctoken_003E5__2).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 5;
							_003C_003E1__state = 5;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01a4;
						IL_038b:
						obj = awaiter2.GetResult();
						goto IL_0513;
						IL_01a4:
						obj = awaiter.GetResult();
						goto IL_0513;
						IL_03c1:
						string_3 = iconStr.Substring("url:".Length).Trim();
						awaiter = iconControl.t1tLQJSS4pD(string_3, _003Ctoken_003E5__2).ConfigureAwait(true).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_045c;
						}
						num = 2;
						_003C_003E1__state = 2;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0438:
						obj = awaiter2.GetResult();
						goto IL_0513;
						IL_045c:
						obj = awaiter.GetResult();
						goto IL_0513;
						IL_046a:
						awaiter = iconControl.t1tLQJSS4pD(iconStr, _003Ctoken_003E5__2).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 3;
							_003C_003E1__state = 3;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_04a6;
						IL_01f4:
						num5 = num4;
						goto IL_0312;
						IL_04a6:
						obj = awaiter.GetResult();
						goto IL_0513;
						end_IL_00bc:
						break;
					}
				}
				catch (OperationCanceledException)
				{
				}
				catch (Exception ex2)
				{
					SNALQEFKhxc.Warn("加载图标出错,icon=" + iconStr + ", " + ex2.Message, ex2);
				}
				end_IL_0010:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003Ctoken_003E5__2 = default(CancellationToken);
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003Ctoken_003E5__2 = default(CancellationToken);
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

		internal static bool qAcn7MyyzlKTSnfgrdeE()
		{
			return aHOTYnyyHUVNEF7Jd39g == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadShellObjectIcon_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageSource> _003C_003Et__builder;

		public string pathOrExt;

		public CancellationToken cancellationToken;

		private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter _003C_003Eu__2;

		internal static object nmZlfFypcCMFauACvGCJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ImageSource result;
			try
			{
        ImageSource imageSource = default;
				if ((uint)num <= 2u)
				{
					goto IL_0071;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass33_0();
				if (nmZlfFypcCMFauACvGCJ == null)
				{
					switch (0)
					{
					}
				}
				_003C_003E8__1.CmJSiAx49vt = pathOrExt;
				imageSource = default(ImageSource);
				if (!(_003C_003E8__1.CmJSiAx49vt == "unknown-proc.exe") && !string.IsNullOrEmpty(_003C_003E8__1.CmJSiAx49vt))
				{
					imageSource = null;
					goto IL_0071;
				}
				result = null;
				goto end_IL_0007;
				IL_0071:
				try
				{
					ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
					int num2;
					ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter awaiter2;
					int num3 = default(int);
					switch (num)
					{
					default:
						if (_003C_003E8__1.CmJSiAx49vt == ".folder")
						{
							awaiter = Task.Run(_003C_003Ec.vgJSiTmmmsw ?? (_003C_003Ec.vgJSiTmmmsw = _003C_003Ec.B8ISioIbNBF.jdmSidncFKs), cancellationToken).ConfigureAwait(true).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_0269;
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = 3;
							if (nmZlfFypcCMFauACvGCJ != null)
							{
								goto IL_02ae;
							}
							goto IL_02af;
						}
						if (!_003C_003E8__1.CmJSiAx49vt.StartsWith(".") && !FileSystemIconHelper.IsDllIconPath(_003C_003E8__1.CmJSiAx49vt) && !_003C_003E8__1.CmJSiAx49vt.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) && _003C_003E8__1.CmJSiAx49vt.IndexOfAny(new char[2] { '\\', '/' }) >= 0 && !_003C_003E8__1.CmJSiAx49vt.StartsWith("::"))
						{
							awaiter2 = JZry4r2NiosU3b6650j.LoKtyPkWI7s(_003C_003E8__1.CmJSiAx49vt).ConfigureAwait(true).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0276;
						}
						awaiter = Task.Run((Func<ImageSource>)_003C_003E8__1.WNHSiMqjsQC, cancellationToken).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02f2;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0269;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ImageSource>.ConfiguredTaskAwaiter);
						num2 = 1;
						if (nmZlfFypcCMFauACvGCJ != null)
						{
							goto IL_02ae;
						}
						goto IL_02af;
					case 2:
						goto IL_02ca;
						IL_02f2:
						imageSource = awaiter.GetResult();
						break;
						IL_02af:
						switch (num2)
						{
						case 2:
							break;
						case 4:
							goto IL_02ca;
						case 1:
							goto IL_02e9;
						default:
							goto end_IL_0072;
						case 3:
							return;
						}
						goto case 1;
						IL_0276:
						imageSource = awaiter2.GetResult();
						num2 = 0;
						if (nmZlfFypcCMFauACvGCJ != null)
						{
							goto IL_02ae;
						}
						goto IL_02af;
						IL_0269:
						imageSource = awaiter.GetResult();
						break;
						IL_02ae:
						num2 = num3;
						goto IL_02af;
						IL_02e9:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_02f2;
						IL_02ca:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0276;
						end_IL_0072:
						break;
					}
					result = imageSource;
				}
				catch (Exception ex)
				{
					string message = "无法获取shell 对象icon。" + _003C_003E8__1.CmJSiAx49vt + "  ex:" + ex.Message;
					SNALQEFKhxc.Warn(message, ex);
					result = null;
				}
				end_IL_0007:;
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
			_003C_003Et__builder.SetResult(result);
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

		internal static bool cxTdUWypWdj8QEicMY2a()
		{
			return nmZlfFypcCMFauACvGCJ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadUrlOrFileImageOrSvg_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public string urlOrFilePath;

		public IconControl _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter<Drawing> _003C_003Eu__1;

		private ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter _003C_003Eu__2;

		private static object GbpvTTyp2TybpGPXf23W;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconControl iconControl = _003C_003E4__this;
			object result;
			try
			{
				ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter awaiter = default(ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter);
				TaskAwaiter<Drawing> awaiter2 = default(TaskAwaiter<Drawing>);
				int num2;
				if (num != 0)
				{
					if (num != 1)
					{
						if (!urlOrFilePath.EndsWith(".svg", StringComparison.OrdinalIgnoreCase))
						{
							awaiter = JZry4r2NiosU3b6650j.LoKtyPkWI7s(urlOrFilePath).ConfigureAwait(true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00f7;
						}
						awaiter2 = tApqttYCLpKNRcDCrWi.o23L5iqGYrY(urlOrFilePath, iconControl.DefaultIconColor, token).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_0142;
						}
						num2 = 1;
						if (!U2EjZkypA9Fmk0Enjl1c())
						{
							goto IL_00d0;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num2 = 0;
						if (!U2EjZkypA9Fmk0Enjl1c())
						{
							goto IL_00d0;
						}
					}
					goto IL_00d4;
				}
				awaiter2 = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<Drawing>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0142;
				IL_00f7:
				result = awaiter.GetResult();
				goto end_IL_0010;
				IL_00d0:
				int num3 = default(int);
				num2 = num3;
				goto IL_00d4;
				IL_0142:
				result = awaiter2.GetResult();
				goto end_IL_0010;
				IL_00d4:
				switch (num2)
				{
				case 1:
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				_003C_003Eu__2 = default(ConfiguredValueTaskAwaitable<ImageSource>.ConfiguredValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00f7;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
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

		internal static bool U2EjZkypA9Fmk0Enjl1c()
		{
			return GbpvTTyp2TybpGPXf23W == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateIconAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IconControl _003C_003E4__this;

		private string _003CiconStr_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object UvI0SRypeHLRIHffXamn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconControl iconControl = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_007b;
				}
				if (iconControl.Icon is ImageSource imageSource_)
				{
					iconControl.kKNLQu4GJvv(imageSource_);
				}
				else
				{
					_003CiconStr_003E5__2 = iconControl.Icon as string;
					if (!string.IsNullOrEmpty(_003CiconStr_003E5__2) && _003CiconStr_003E5__2.Length >= 3)
					{
						goto IL_007b;
					}
					iconControl.Content = null;
					iconControl.xyRLQyvY9xx = _003CiconStr_003E5__2;
				}
				goto end_IL_0010;
				IL_007b:
				int num2 = 0;
				if (UvI0SRypeHLRIHffXamn != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					try
					{
        int num5 = default;
						if (num != 0)
						{
							if (!_003CiconStr_003E5__2.StartsWith("action:"))
							{
								goto IL_012d;
							}
							string string_ = _003CiconStr_003E5__2.Substring("action:".Length);
							(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(string_);
							if (tuple.Item1 != null)
							{
								_003CiconStr_003E5__2 = tuple.Item1.Icon;
							}
							else
							{
								_003CiconStr_003E5__2 = null;
							}
							if (!string.IsNullOrEmpty(_003CiconStr_003E5__2) && _003CiconStr_003E5__2.Length >= 3)
							{
								goto IL_012d;
							}
							iconControl.Content = null;
							iconControl.xyRLQyvY9xx = _003CiconStr_003E5__2;
							break;
						}
						TaskAwaiter awaiter = _003C_003Eu__1;
						int num4 = 0;
						if (UvI0SRypeHLRIHffXamn != null)
						{
							goto IL_018e;
						}
						goto IL_0192;
						IL_01e5:
						iconControl.Content = null;
						num5 = 2;
						goto IL_01f6;
						IL_012d:
						if (!(_003CiconStr_003E5__2 == iconControl.xyRLQyvY9xx))
						{
							goto IL_01e5;
						}
						if (_003CiconStr_003E5__2.StartsWith("fa:", StringComparison.OrdinalIgnoreCase))
						{
							goto IL_01bb;
						}
						if (_003CiconStr_003E5__2.EndsWith(".svg", StringComparison.OrdinalIgnoreCase))
						{
							num4 = 1;
							if (UvI0SRypeHLRIHffXamn != null)
							{
								goto IL_018e;
							}
							goto IL_0192;
						}
						goto end_IL_0096;
						IL_01f6:
						awaiter = iconControl.nuGLQSy4XRV(_003CiconStr_003E5__2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0238;
						IL_0192:
						switch (num4)
						{
						case 1:
							goto IL_01bb;
						case 2:
							goto IL_01f6;
						}
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0238;
						IL_018e:
						num4 = num5;
						goto IL_0192;
						IL_01bb:
						if (!(iconControl.RvDLQ8gt5tU == iconControl.DefaultIconColor) || iconControl.YQFLQaccU6q != iconControl.DefaultIconBrush)
						{
							goto IL_01e5;
						}
						goto end_IL_0096;
						IL_0238:
						awaiter.GetResult();
						end_IL_0096:;
					}
					catch (Exception ex)
					{
						SNALQEFKhxc.Warn("更新图标" + _003CiconStr_003E5__2 + "出错：" + ex.Message, ex);
					}
					finally
					{
						if (num < 0)
						{
							iconControl.xyRLQyvY9xx = _003CiconStr_003E5__2;
							iconControl.RvDLQ8gt5tU = iconControl.DefaultIconColor;
						}
					}
					break;
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CiconStr_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CiconStr_003E5__2 = null;
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

		internal static bool XfvEHFypjxHBchh8PJdk()
		{
			return UvI0SRypeHLRIHffXamn == null;
		}
	}

	private static readonly ILog SNALQEFKhxc;

	public static readonly DependencyProperty DefaultIconColorProperty;

	public static readonly DependencyProperty DefaultIconBrushProperty;

	public static readonly DependencyProperty IconProperty;

	private string xyRLQyvY9xx = string.Empty;

	private string RvDLQ8gt5tU = string.Empty;

	private Brush YQFLQaccU6q;

	private CancellationTokenSource LSSLQ7suOvL;

	internal static IconControl O0PxwyFbAyQQFbq06c2e;

	public string DefaultIconColor
	{
		get
		{
			return (string)GetValue(DefaultIconColorProperty);
		}
		set
		{
			SetValue(DefaultIconColorProperty, value);
		}
	}

	public Brush DefaultIconBrush
	{
		get
		{
			return (Brush)GetValue(DefaultIconBrushProperty);
		}
		set
		{
			SetValue(DefaultIconBrushProperty, value);
		}
	}

	public object Icon
	{
		get
		{
			return GetValue(IconProperty);
		}
		set
		{
			SetValue(IconProperty, value);
		}
	}

	public bool HasIcon
	{
		get
		{
			if (Icon != null)
			{
				if (!(Icon is ImageSource))
				{
					if (Icon is string value)
					{
						return !string.IsNullOrEmpty(value);
					}
					return false;
				}
				return true;
			}
			return false;
		}
	}

	private static void yUuLQwR2eV4(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is IconControl)
		{
			(dependencyObject_0 as IconControl).QWeLQLNYSmc();
		}
	}

	public static string GetDefaultIconColor(DependencyObject obj)
	{
		return (string)obj.GetValue(DefaultIconColorProperty);
	}

	public static void SetDefaultIconColor(DependencyObject obj, string value)
	{
		obj.SetValue(DefaultIconColorProperty, value);
	}

	public static Brush GetDefaultIconBrush(DependencyObject obj)
	{
		return (Brush)obj.GetValue(DefaultIconBrushProperty);
	}

	public static void SetDefaultIconBrush(DependencyObject obj, Brush value)
	{
		obj.SetValue(DefaultIconBrushProperty, value);
	}

	private static void gHKLQteg8cV(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is IconControl)
		{
			(dependencyObject_0 as IconControl).fCOLQvGQDXV();
		}
	}

	public IconControl()
	{
		base.IsTabStop = false;
		base.IsHitTestVisible = false;
	}

	protected override Size MeasureOverride(Size constraint)
	{
		while (true)
		{
			lJdLQg1tN1t(constraint);
			if (O0PxwyFbAyQQFbq06c2e == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		Size result;
		if (!double.IsNaN(constraint.Width) && !double.IsNaN(constraint.Height))
		{
			result = base.MeasureOverride(constraint);
			if (result.Width == 0.0)
			{
				result = constraint;
			}
		}
		else
		{
			result = new Size(32.0, 32.0);
		}
		if (double.IsInfinity(result.Width) || double.IsInfinity(result.Height) || double.IsNaN(result.Width) || double.IsNaN(result.Height) || result.Width < 0.0 || result.Height < 0.0)
		{
			result = new Size(32.0, 32.0);
		}
		return result;
	}

	private void lJdLQg1tN1t(Size size_0)
	{
		if (double.IsNaN(size_0.Height))
		{
			size_0.Height = (double.IsNaN(size_0.Width) ? 32.0 : size_0.Width);
		}
		if (double.IsNaN(size_0.Width))
		{
			size_0.Width = (double.IsNaN(size_0.Height) ? 32.0 : size_0.Height);
		}
		if (size_0.Width > base.Width || size_0.Width > 300.0)
		{
			size_0.Width = Math.Min(base.Width, 300.0);
		}
		if (size_0.Height > base.Height || size_0.Height > 300.0)
		{
			size_0.Height = Math.Min(base.Height, 300.0);
		}
		if (double.IsInfinity(size_0.Height) || double.IsNaN(size_0.Height))
		{
			size_0.Height = 32.0;
		}
		if (!double.IsInfinity(size_0.Width))
		{
			if (!double.IsNaN(size_0.Width))
			{
				return;
			}
			int num = 0;
			if (O0PxwyFbAyQQFbq06c2e != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		size_0.Width = 32.0;
	}

	internal void QWeLQLNYSmc()
	{
		string text = Icon as string;
		if (!string.IsNullOrEmpty(text) && (text.StartsWith("fa:") || text.EndsWith(".svg", StringComparison.OrdinalIgnoreCase)))
		{
			fCOLQvGQDXV();
		}
	}

	[AsyncStateMachine(typeof(_003CUpdateIconAsync_003Ed__28))]
	internal void fCOLQvGQDXV()
	{
		_003CUpdateIconAsync_003Ed__28 stateMachine = default(_003CUpdateIconAsync_003Ed__28);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoUpdateIconAsync_003Ed__30))]
	private Task nuGLQSy4XRV(string string_2)
	{
		_003CDoUpdateIconAsync_003Ed__30 stateMachine = default(_003CDoUpdateIconAsync_003Ed__30);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.iconStr = string_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void IrMLQ23jtNu(string string_2)
	{
		string[] array = string_2.Split(':');
		string text = array[1];
		string colorStr = ((array.Length > 2) ? array[2] : DefaultIconColor);
		TextBlock textBlock = new TextBlock
		{
			Text = (text.StartsWith("&") ? HttpUtility.HtmlDecode(text) : text)
		};
		textBlock.Foreground = FaIconHelper.GetBrushFromColorString(colorStr);
		string text2 = ((array.Length > 3) ? array[3] : "");
		int num = 1;
		if (!JmjG8oFbnkigfEPa1FZy())
		{
			goto IL_00f1;
		}
		goto IL_00f5;
		IL_00f5:
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				if (!string.IsNullOrEmpty(text2))
				{
					textBlock.FontFamily = new FontFamily(text2);
				}
				if (((array.Length > 4) ? array[4] : "").Contains("b"))
				{
					textBlock.FontWeight = FontWeights.Bold;
				}
				Viewbox content = new Viewbox
				{
					StretchDirection = StretchDirection.Both,
					Child = textBlock
				};
				base.Content = content;
				num = 0;
				if (JmjG8oFbnkigfEPa1FZy())
				{
					break;
				}
				goto end_IL_00f5;
			}
			default:
				return;
			}
			continue;
			end_IL_00f5:
			break;
		}
		goto IL_00f1;
		IL_00f1:
		int num2 = default(int);
		num = num2;
		goto IL_00f5;
	}

	private void kKNLQu4GJvv(ImageSource imageSource_0)
	{
		if (imageSource_0 == null)
		{
			base.Content = null;
		}
		if (base.Content is Image image)
		{
			image.Source = imageSource_0;
			return;
		}
		Image content = new Image
		{
			Source = imageSource_0
		};
		base.Content = content;
	}

	[AsyncStateMachine(typeof(_003CLoadShellObjectIcon_003Ed__33))]
	private Task<ImageSource> vhxLQNVrC8D(string string_2, CancellationToken cancellationToken_0)
	{
		_003CLoadShellObjectIcon_003Ed__33 stateMachine = default(_003CLoadShellObjectIcon_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageSource>.Create();
		stateMachine.pathOrExt = string_2;
		stateMachine.cancellationToken = cancellationToken_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CLoadUrlOrFileImageOrSvg_003Ed__34))]
	private Task<object> t1tLQJSS4pD(string string_2, CancellationToken cancellationToken_0)
	{
		_003CLoadUrlOrFileImageOrSvg_003Ed__34 stateMachine = default(_003CLoadUrlOrFileImageOrSvg_003Ed__34);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.urlOrFilePath = string_2;
		stateMachine.token = cancellationToken_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void pLVLQ0y7kVW(Drawing drawing_0)
	{
		if (!(base.Content is SVGImage.SVG.SVGImage sVGImage))
		{
			SVGImage.SVG.SVGImage content = new SVGImage.SVG.SVGImage
			{
				ImageSource = drawing_0,
				VerticalContentAlignment = VerticalAlignment.Center,
				HorizontalContentAlignment = HorizontalAlignment.Center
			};
			base.Content = content;
		}
		else
		{
			sVGImage.ImageSource = drawing_0;
		}
	}

	private void m5MLQCUxZaq(string string_2)
	{
		var (icon, brush) = FaIconHelper.DecodeFaIconString(string_2, DefaultIconColor);
		if (brush == null)
		{
			brush = ((DefaultIconBrush != null) ? DefaultIconBrush : FaIconHelper.GetBrushFromColorString(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6()?.DefaultIconColorForOtherUi.Or("#A0A0A0")));
		}
		if (base.Content is SvgAwesome svgAwesome)
		{
			svgAwesome.Foreground = brush;
			svgAwesome.Icon = icon;
			return;
		}
		SvgAwesome content = new SvgAwesome
		{
			Icon = icon,
			Foreground = brush
		};
		int num = 0;
		if (!JmjG8oFbnkigfEPa1FZy())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		base.Content = content;
	}

	internal static bool KbKLQPMI9dD(string string_2)
	{
		return string_2.StartsWithAny(true, "fa:", "url:", "icon:", "http", "previmg:");
	}

	static IconControl()
	{
		SNALQEFKhxc = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		DefaultIconColorProperty = DependencyProperty.RegisterAttached("DefaultIconColor", typeof(string), typeof(global::Quicker.View.Controls.IconControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits, yUuLQwR2eV4));
		DefaultIconBrushProperty = DependencyProperty.RegisterAttached("DefaultIconBrush", typeof(Brush), typeof(IconControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits, yUuLQwR2eV4));
		IconProperty = DependencyProperty.Register("Icon", typeof(object), typeof(IconControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, gHKLQteg8cV));
	}

	internal static bool JmjG8oFbnkigfEPa1FZy()
	{
		return O0PxwyFbAyQQFbq06c2e == null;
	}
}
