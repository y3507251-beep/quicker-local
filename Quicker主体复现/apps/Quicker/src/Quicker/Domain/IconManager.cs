using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using CW;
using IgQBbvXMVdsN7GVNUxX;
using jUHfG42nmbml7b5l5N7;
using O5blBdM6bCRI1gbI3U2;
using Quicker.Common.Vm;
using Quicker.Utilities;

namespace Quicker.Domain;

public class IconManager
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFileOrFolderIconAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string fileOrFodlerPath;

		public IconManager _003C_003E4__this;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter<ImageSource> _003C_003Eu__2;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private static object Wjg29Lc62oJSl1DZwnKL;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconManager iconManager = _003C_003E4__this;
			string result;
			try
			{
        ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
				if (num == 0)
				{
					goto IL_03a3;
				}
				if ((uint)(num - 1) <= 3u)
				{
					goto IL_00eb;
				}
				awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				{
					if (fileOrFodlerPath.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
					{
						string text = fileOrFodlerPath.Substring("StoreApp:".Length);
						string text2 = iah68iMf4KvhT7ULCsJ.DpvLoo2xNQd(text);
						if (text2 != null)
						{
							Image img = Image.FromFile(text2);
							awaiter = iconManager.UploadUWPIconAsync(text, img).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03bf;
						}
					}
					goto IL_00eb;
				}
				if (Wjg29Lc62oJSl1DZwnKL != null)
				{
					switch (0)
					{
					case 1:
						break;
					default:
						goto IL_03a3;
					}
				}
				AppHelper.ShowInformation("未登录用户不支持上传图标。");
				result = "";
				goto end_IL_000e;
				IL_03a3:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_03bf;
				IL_00eb:
				try
				{
					ValueTaskAwaiter<ImageSource> awaiter3 = default(ValueTaskAwaiter<ImageSource>);
					int num2;
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					ImageSource result2;
					switch (num)
					{
					default:
						if (File.Exists(fileOrFodlerPath))
						{
							awaiter = iconManager.UploadFileIconAsync(fileOrFodlerPath, IconHelper.GetExeOrLnkFileIcon(fileOrFodlerPath)).ConfigureAwait(false).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_01e6;
							}
							goto IL_0287;
						}
						if (Directory.Exists(fileOrFodlerPath))
						{
							awaiter = iconManager.UploadFileIconAsync("system.folder", IconHelper.GetFolderIcon()).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0275;
						}
						awaiter3 = JZry4r2NiosU3b6650j.LoKtyPkWI7s(fileOrFodlerPath).GetAwaiter();
						num2 = 2;
						if (Wjg29Lc62oJSl1DZwnKL == null)
						{
							goto IL_01f3;
						}
						goto IL_022d;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_01e6;
					case 2:
						goto IL_024c;
					case 3:
						awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(ValueTaskAwaiter<ImageSource>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_02c7;
					case 4:
						{
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							break;
						}
						IL_024c:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						num2 = 0;
						if (Wjg29Lc62oJSl1DZwnKL != null)
						{
							goto IL_022d;
						}
						goto IL_0275;
						IL_01e6:
						result = awaiter.GetResult();
						goto end_IL_00eb;
						IL_0275:
						result = awaiter.GetResult();
						goto end_IL_00eb;
						IL_01f3:
						if (!awaiter3.IsCompleted)
						{
							num = 3;
							_003C_003E1__state = 3;
							_003C_003Eu__2 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							num2 = 1;
							if (!naZOEuc6AD9IVT4tCSvX())
							{
								int num3 = default(int);
								num2 = num3;
							}
							goto IL_022d;
						}
						goto IL_02c7;
						IL_0340:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
						IL_02c7:
						result2 = awaiter3.GetResult();
						if (result2 != null)
						{
							Image image_ = AppHelper.ImageWpfToGDI(result2);
							awaiter2 = aFIptTXYsUoTUF4v33R.kiBt16rh2I5((fileOrFodlerPath.IsNullOrEmpty() || fileOrFodlerPath.StartsWith("::")) ? "system_icon.png" : Path.GetFileName(fileOrFodlerPath), image_).ConfigureAwait(false).GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								break;
							}
							num = 4;
							_003C_003E1__state = 4;
							_003C_003Eu__3 = awaiter2;
							goto IL_0340;
						}
						result = null;
						goto end_IL_00eb;
						IL_022d:
						switch (num2)
						{
						case 5:
							break;
						case 3:
							goto IL_024c;
						default:
							goto IL_0275;
						case 1:
							return;
						case 2:
							goto IL_0287;
						case 4:
							goto IL_0340;
						}
						goto IL_01f3;
						IL_0287:
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					result = awaiter2.GetResult().Data;
					end_IL_00eb:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("上传图标失败！" + ex.Message);
					result = null;
				}
				goto end_IL_000e;
				IL_03bf:
				result = awaiter.GetResult();
				end_IL_000e:;
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

		internal static bool naZOEuc6AD9IVT4tCSvX()
		{
			return Wjg29Lc62oJSl1DZwnKL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFaviconAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string site;

		public Image icon;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Uf6Ryvc6j0OPviZRmr8Y;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string data;
			try
			{
				ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = aFIptTXYsUoTUF4v33R.kiBt16rh2I5("favicon_" + site + ".png", icon).ConfigureAwait(false).GetAwaiter();
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
					int num2 = 0;
					if (!c7pGpCc6DfUGUrQEbIwk())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				ApiResult<string> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					throw new InvalidDataException(result.Message);
				}
				data = result.Data;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(data);
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

		internal static bool c7pGpCc6DfUGUrQEbIwk()
		{
			return Uf6Ryvc6j0OPviZRmr8Y == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFileIconAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string fileName;

		public Icon icon;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object I1ak5Jc6EFBkZ6M5XTxB;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string data;
			try
			{
				ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = aFIptTXYsUoTUF4v33R.nOTt1mVbUaN(fileName, icon).ConfigureAwait(false).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				ApiResult<string> result = awaiter.GetResult();
				int num2 = 0;
				if (!u3e1Wxc6GrZKA2E2DkVq())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					if (!result.IsSuccess)
					{
						throw new InvalidDataException(result.Message);
					}
					data = result.Data;
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(data);
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

		internal static bool u3e1Wxc6GrZKA2E2DkVq()
		{
			return I1ak5Jc6EFBkZ6M5XTxB == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadIconImageFileAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string imageFile;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object kjm1guc61RG9iAtBcEoj;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string data;
			try
			{
				ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
				Image image = default(Image);
				int num2;
				if (num != 0)
				{
					if (num != 1)
					{
						if (imageFile.EndsWith(".svg", StringComparison.OrdinalIgnoreCase))
						{
							awaiter = aFIptTXYsUoTUF4v33R.ihUt1XUajHY(imageFile).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0243;
						}
						if (imageFile.EndsWith(".ico", StringComparison.OrdinalIgnoreCase))
						{
							image = new Icon(imageFile, 64, 64).ToBitmap();
						}
						else if (imageFile.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
						{
							Icon icon = Icon.ExtractAssociatedIcon(imageFile);
							try
							{
								if (icon == null)
								{
									throw new InvalidDataException("无法获取文件图标。");
								}
								image = icon.ToBitmap();
								imageFile += ".png";
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)icon)?.Dispose();
								}
							}
						}
						else
						{
							image = Image.FromFile(imageFile);
							num2 = 2;
							if (kjm1guc61RG9iAtBcEoj != null)
							{
								goto IL_019f;
							}
						}
						goto IL_0178;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					num2 = 0;
					if (kjm1guc61RG9iAtBcEoj != null)
					{
						goto IL_019b;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num2 = 3;
					if (!Q4JmN7c6K394uljFwVgN())
					{
						goto IL_020f;
					}
				}
				goto IL_019f;
				IL_0178:
				if (image.Width > 64)
				{
					goto IL_01b6;
				}
				if (image.Height > 64)
				{
					num2 = 1;
					if (kjm1guc61RG9iAtBcEoj != null)
					{
						goto IL_019b;
					}
					goto IL_019f;
				}
				goto IL_01c3;
				IL_01c3:
				awaiter = aFIptTXYsUoTUF4v33R.kiBt16rh2I5(imageFile, image).ConfigureAwait(false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_020f;
				IL_019b:
				int num3 = default(int);
				num2 = num3;
				goto IL_019f;
				IL_01b6:
				image = IconHelper.ResizeImage(image, 64, 64);
				goto IL_01c3;
				IL_019f:
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto IL_01b6;
				default:
					goto IL_020f;
				case 3:
					goto IL_0239;
				}
				goto IL_0178;
				IL_0243:
				ApiResult<string> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					throw new InvalidDataException(result.Message);
				}
				data = result.Data;
				goto end_IL_0008;
				IL_020f:
				ApiResult<string> result2 = awaiter.GetResult();
				if (!result2.IsSuccess)
				{
					throw new InvalidDataException(result2.Message);
				}
				data = result2.Data;
				goto end_IL_0008;
				IL_0239:
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0243;
				end_IL_0008:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(data);
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

		internal static bool Q4JmN7c6K394uljFwVgN()
		{
			return kjm1guc61RG9iAtBcEoj == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadUWPIconAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string appModuleId;

		public Image img;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object h7rhmcc6Oj6a6U13Ji7o;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string data;
			try
			{
				ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = aFIptTXYsUoTUF4v33R.kiBt16rh2I5("uwp_" + appModuleId + ".png", img).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!TMjSuec6J7WqKI82JOpJ())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				ApiResult<string> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					throw new InvalidDataException(result.Message);
				}
				data = result.Data;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(data);
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

		internal static bool TMjSuec6J7WqKI82JOpJ()
		{
			return h7rhmcc6Oj6a6U13Ji7o == null;
		}
	}

	internal static IconManager a9IdCwQGQVuZTQ6nZfJu;

	[AsyncStateMachine(typeof(_003CUploadIconImageFileAsync_003Ed__1))]
	public Task<string> UploadIconImageFileAsync(string imageFile)
	{
		_003CUploadIconImageFileAsync_003Ed__1 stateMachine = default(_003CUploadIconImageFileAsync_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.imageFile = imageFile;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CUploadFileIconAsync_003Ed__2))]
	public Task<string> UploadFileIconAsync(string fileName, Icon icon)
	{
		_003CUploadFileIconAsync_003Ed__2 stateMachine = default(_003CUploadFileIconAsync_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.fileName = fileName;
		stateMachine.icon = icon;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetFileOrFolderIconAsync_003Ed__3))]
	public Task<string> GetFileOrFolderIconAsync(string fileOrFodlerPath)
	{
		_003CGetFileOrFolderIconAsync_003Ed__3 stateMachine = default(_003CGetFileOrFolderIconAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileOrFodlerPath = fileOrFodlerPath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CUploadUWPIconAsync_003Ed__4))]
	public Task<string> UploadUWPIconAsync(string appModuleId, Image img)
	{
		_003CUploadUWPIconAsync_003Ed__4 stateMachine = default(_003CUploadUWPIconAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.appModuleId = appModuleId;
		stateMachine.img = img;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CUploadFaviconAsync_003Ed__5))]
	public Task<string> UploadFaviconAsync(string site, Image icon)
	{
		_003CUploadFaviconAsync_003Ed__5 stateMachine = default(_003CUploadFaviconAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.site = site;
		stateMachine.icon = icon;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool iWiP5KQGFp0ZfAOkDWDY()
	{
		return a9IdCwQGQVuZTQ6nZfJu == null;
	}
}
