using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class HttpClientWithProgress : HttpClient
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public HttpClientWithProgress GFJvlFOvPU5;

		public WebClient QvtvlUP8pCH;

		internal static _003C_003Ec__DisplayClass45_0 mr3lajWePDqiHunuNV1r;

		internal void MLdvlOhf78k(object sender, DownloadProgressChangedEventArgs e)
		{
			CancellationTokenSource cts = GFJvlFOvPU5.Cts;
			if (cts != null && cts.IsCancellationRequested)
			{
				if (QvtvlUP8pCH.IsBusy)
				{
					QvtvlUP8pCH.CancelAsync();
				}
			}
			else
			{
				GFJvlFOvPU5.TotalBytes = e.TotalBytesToReceive;
				GFJvlFOvPU5.DownloadedSize = e.BytesReceived;
				GFJvlFOvPU5.HY0toh8yRSM(e.TotalBytesToReceive, e.BytesReceived);
			}
		}

		internal static bool Rkt8BCWeMB70gpZ3QaqW()
		{
			return mr3lajWePDqiHunuNV1r == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_1
	{
		public ManualResetEventSlim AYJvliAqP86;

		internal static _003C_003Ec__DisplayClass45_1 zKpUUmWexNkOhjcCiweQ;

		internal void EIHvllkRHsf(object sender, AsyncCompletedEventArgs e)
		{
			AYJvliAqP86.Set();
		}

		internal static bool oKT0LRWeIkf5wuTc2TAm()
		{
			return zKpUUmWexNkOhjcCiweQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public string g59vlfbR2SG;

		public int Kp7vlzSti7j;

		public FileStream VR7viwvCIZK;

		public object MeVvitwGBLo;

		internal static _003C_003Ec__DisplayClass46_0 VLggL4WetVfkskns1PdN;

		internal void XNJvl36uS9L(long start)
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(g59vlfbR2SG);
			obj.AddRange(start * Kp7vlzSti7j, start * Kp7vlzSti7j + Kp7vlzSti7j - 1L);
			HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			lock (MeVvitwGBLo)
			{
				using Stream stream = httpWebResponse.GetResponseStream();
				VR7viwvCIZK.Seek(start * Kp7vlzSti7j, SeekOrigin.Begin);
				stream.CopyTo(VR7viwvCIZK);
			}
		}

		internal static void BiF9fqWeTQ3EjgaXE8JJ()
		{
		}

		internal static bool xJwCkbWeS9DNlK25navi()
		{
			return VLggL4WetVfkskns1PdN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadFileFromHttpResponseMessage_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HttpResponseMessage response;

		public HttpClientWithProgress _003C_003E4__this;

		private long? _003CtotalBytes_003E5__2;

		private Stream _003CcontentStream_003E5__3;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object VekduUWem2LCCZMaCK5M;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HttpClientWithProgress httpClientWithProgress = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					response.EnsureSuccessStatusCode();
					int num2 = 0;
					if (VekduUWem2LCCZMaCK5M != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003CtotalBytes_003E5__2 = response.Content.Headers.ContentLength;
					httpClientWithProgress.TotalBytes = _003CtotalBytes_003E5__2;
					httpClientWithProgress.obBtoqFT7in(response);
					httpClientWithProgress.HY0toh8yRSM(0L, _003CtotalBytes_003E5__2.GetValueOrDefault());
					httpClientWithProgress._tempPathName = httpClientWithProgress.qeQtosot3JC + ".download";
				}
				try
				{
					int num4;
					TaskAwaiter<Stream> awaiter = default(TaskAwaiter<Stream>);
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_013e;
						}
						if (response.StatusCode == HttpStatusCode.PartialContent)
						{
							num4 = 0;
							if (!QN5XOXWesETpLjUbtIfQ())
							{
								goto IL_01fb;
							}
							goto IL_01ff;
						}
						awaiter = response.Content.ReadAsStreamAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							goto IL_0291;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Stream>);
						num = -1;
						_003C_003E1__state = -1;
					}
					Stream result = awaiter.GetResult();
					_003CcontentStream_003E5__3 = result;
					goto IL_013e;
					IL_01fb:
					int num5 = default(int);
					num4 = num5;
					goto IL_01ff;
					IL_0250:
					if (System.IO.File.Exists(httpClientWithProgress.qeQtosot3JC))
					{
						num4 = 1;
						if (VekduUWem2LCCZMaCK5M != null)
						{
							goto IL_01fb;
						}
						goto IL_01ff;
					}
					goto IL_02a9;
					IL_01ff:
					switch (num4)
					{
					case 1:
						goto IL_0260;
					case 2:
						goto IL_0291;
					}
					ActionExecuteContext qOutoGNQXbW = httpClientWithProgress.QOutoGNQXbW;
					if (qOutoGNQXbW != null && qOutoGNQXbW.IsDebugging)
					{
						httpClientWithProgress.QOutoGNQXbW.ActionLogger.LogWarning("服务器返回了PartialContent， 尝试分片下载。");
					}
					httpClientWithProgress.DownloadWithWebClient(httpClientWithProgress.D8ftoYMYCh3, httpClientWithProgress._tempPathName);
					goto IL_0250;
					IL_0291:
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_02a9:
					System.IO.File.Move(httpClientWithProgress._tempPathName, httpClientWithProgress.qeQtosot3JC);
					goto end_IL_00ac;
					IL_013e:
					try
					{
						TaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = httpClientWithProgress.KBOto9juMSi(_003CtotalBytes_003E5__2, _003CcontentStream_003E5__3).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							int num6 = 0;
							if (!QN5XOXWesETpLjUbtIfQ())
							{
								int num7 = default(int);
								num6 = num7;
							}
							switch (num6)
							{
							}
							num = -1;
							_003C_003E1__state = -1;
						}
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && _003CcontentStream_003E5__3 != null)
						{
							((IDisposable)_003CcontentStream_003E5__3).Dispose();
						}
					}
					_003CcontentStream_003E5__3 = null;
					goto IL_0250;
					IL_0260:
					if (!string.IsNullOrWhiteSpace(httpClientWithProgress.dLrtoWupRyw))
					{
						System.IO.File.Delete(httpClientWithProgress.qeQtosot3JC);
					}
					else
					{
						httpClientWithProgress.qeQtosot3JC = FindAvailableName(httpClientWithProgress.qeQtosot3JC);
					}
					goto IL_02a9;
					end_IL_00ac:;
				}
				finally
				{
					if (num < 0 && System.IO.File.Exists(httpClientWithProgress._tempPathName))
					{
						try
						{
							System.IO.File.Delete(httpClientWithProgress._tempPathName);
						}
						catch (Exception)
						{
						}
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

		internal static bool QN5XOXWesETpLjUbtIfQ()
		{
			return VekduUWem2LCCZMaCK5M == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLongRange_003Ed__48 : IEnumerable<long>, IEnumerator<long>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private long count;

		public long _003C_003E3__count;

		private long start;

		public long _003C_003E3__start;

		private long _003Ci_003E5__2;

		private static _003CLongRange_003Ed__48 EDXbbyWeHDFyb4K26w1N;

		long IEnumerator<long>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CLongRange_003Ed__48(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
			{
				_003C_003E1__state = -1;
				int num = 0;
				if (EDXbbyWeHDFyb4K26w1N != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				_003Ci_003E5__2++;
				break;
			}
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0L;
				break;
			}
			if (_003Ci_003E5__2 >= count)
			{
				return false;
			}
			_003C_003E2__current = start + _003Ci_003E5__2;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			_003CLongRange_003Ed__48 _003CLongRange_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CLongRange_003Ed__ = this;
			}
			else
			{
				_003CLongRange_003Ed__ = new _003CLongRange_003Ed__48(0);
			}
			_003CLongRange_003Ed__.start = _003C_003E3__start;
			_003CLongRange_003Ed__.count = _003C_003E3__count;
			return _003CLongRange_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<long>)this).GetEnumerator();
		}

		internal static bool UkbwDUWezZqXoSRygKwe()
		{
			return EDXbbyWeHDFyb4K26w1N == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessContentStream_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HttpClientWithProgress _003C_003E4__this;

		public Stream contentStream;

		public long? totalDownloadSize;

		private long _003CtotalBytesRead_003E5__2;

		private long _003CreadCount_003E5__3;

		private byte[] _003Cbuffer_003E5__4;

		private bool _003CmoreToRead_003E5__5;

		private int _003CtimeoutMs_003E5__6;

		private FileStream _003CfileStream_003E5__7;

		private int _003CbytesRead_003E5__8;

		private Task<int> _003CrecvTask_003E5__9;

		private TaskAwaiter<Task> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object MrnpQ4WjQZmiDgRPOY8N;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HttpClientWithProgress httpClientWithProgress = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					_003CtotalBytesRead_003E5__2 = 0L;
					_003CreadCount_003E5__3 = 0L;
					_003Cbuffer_003E5__4 = new byte[131072];
					_003CmoreToRead_003E5__5 = true;
					_003CtimeoutMs_003E5__6 = httpClientWithProgress.ExpireMs;
					_003CfileStream_003E5__7 = new FileStream(httpClientWithProgress._tempPathName, FileMode.Create, FileAccess.Write, FileShare.None, 131072, true);
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_01e4;
						}
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0109;
					}
					TaskAwaiter<Task> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Task>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_025f;
					IL_01ba:
					if (httpClientWithProgress.QOutoGNQXbW == null || !httpClientWithProgress.QOutoGNQXbW.IsShouldStopAction())
					{
						_003CrecvTask_003E5__9 = null;
						goto IL_01d9;
					}
					throw new Exception("中止动作，取消下载！");
					IL_01d9:
					if (_003CmoreToRead_003E5__5)
					{
						goto IL_01e4;
					}
					goto end_IL_006e;
					IL_025f:
					awaiter2.GetResult();
					if (_003CrecvTask_003E5__9.IsCompleted)
					{
						_003CbytesRead_003E5__8 = _003CrecvTask_003E5__9.Result;
						if (_003CbytesRead_003E5__8 == 0)
						{
							_003CmoreToRead_003E5__5 = false;
							goto IL_01d9;
						}
						awaiter = _003CfileStream_003E5__7.WriteAsync(_003Cbuffer_003E5__4, 0, _003CbytesRead_003E5__8).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0109;
					}
					throw new TimeoutException("下载超时。");
					IL_01e4:
					CancellationTokenSource cts = httpClientWithProgress.Cts;
					if (cts == null || !cts.IsCancellationRequested)
					{
						_003CbytesRead_003E5__8 = 0;
						_003CrecvTask_003E5__9 = contentStream.ReadAsync(_003Cbuffer_003E5__4, 0, _003Cbuffer_003E5__4.Length, httpClientWithProgress.Cts.Token);
						awaiter2 = Task.WhenAny(_003CrecvTask_003E5__9, Task.Delay(_003CtimeoutMs_003E5__6)).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_025f;
						}
						num = 0;
						_003C_003E1__state = 0;
						goto IL_02d1;
					}
					throw new Exception("下载已被取消(0)。");
					IL_02d1:
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
					IL_0109:
					awaiter.GetResult();
					int num2 = 1;
					if (!wkXuHpWjFZdIcL38ML5v())
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							_003CreadCount_003E5__3++;
							num2 = 0;
							if (!wkXuHpWjFZdIcL38ML5v())
							{
								continue;
							}
							goto default;
						case 1:
							_003CtotalBytesRead_003E5__2 += _003CbytesRead_003E5__8;
							goto case 2;
						default:
						{
							httpClientWithProgress.DownloadedSize = _003CtotalBytesRead_003E5__2;
							if (_003CreadCount_003E5__3 % 10L == 0L)
							{
								httpClientWithProgress.HY0toh8yRSM(totalDownloadSize, _003CtotalBytesRead_003E5__2);
							}
							CancellationTokenSource cts2 = httpClientWithProgress.Cts;
							if (cts2 != null && cts2.IsCancellationRequested)
							{
								throw new Exception("下载已被取消(1)。");
							}
							goto IL_01ba;
						}
						case 3:
							break;
						}
						break;
					}
					goto IL_02d1;
					end_IL_006e:;
				}
				finally
				{
					if (num < 0 && _003CfileStream_003E5__7 != null)
					{
						((IDisposable)_003CfileStream_003E5__7).Dispose();
					}
				}
				_003CfileStream_003E5__7 = null;
				if (!wkXuHpWjFZdIcL38ML5v())
				{
					switch (0)
					{
					}
				}
				if (totalDownloadSize.HasValue && totalDownloadSize > 0L && _003CtotalBytesRead_003E5__2 != totalDownloadSize.Value)
				{
					throw new InvalidDataException($"下载的文件不完整，预期大小{totalDownloadSize},实际大小{_003CtotalBytesRead_003E5__2}。");
				}
				httpClientWithProgress.HY0toh8yRSM(totalDownloadSize, _003CtotalBytesRead_003E5__2);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cbuffer_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cbuffer_003E5__4 = null;
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

		internal static bool wkXuHpWjFZdIcL38ML5v()
		{
			return MrnpQ4WjQZmiDgRPOY8N == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartDownload_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HttpClientWithProgress _003C_003E4__this;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object Yn7HswWjyR29LXQITpOR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HttpClientWithProgress httpClientWithProgress = _003C_003E4__this;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_00ac;
					}
					CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(httpClientWithProgress.Cts.Token, new CancellationTokenSource(httpClientWithProgress.ExpireMs).Token);
					awaiter = httpClientWithProgress.GetAsync(httpClientWithProgress.D8ftoYMYCh3, HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresponse_003E5__2 = result;
				goto IL_00ac;
				IL_00ac:
				try
				{
					TaskAwaiter awaiter2;
					if (num != 1)
					{
						if (_003Cresponse_003E5__2.Headers.Contains("ETag"))
						{
							httpClientWithProgress.ETag = _003Cresponse_003E5__2.Headers.ETag?.Tag?.Trim('"', '\'');
						}
						if (_003Cresponse_003E5__2.Content.Headers.Contains("Content-MD5"))
						{
							httpClientWithProgress.ContentMD5 = BitConverter.ToString(_003Cresponse_003E5__2.Content.Headers.ContentMD5).Replace("-", "").ToLower();
						}
						awaiter2 = httpClientWithProgress.w8tto7dYCvw(_003Cresponse_003E5__2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							int num2 = 0;
							if (Yn7HswWjyR29LXQITpOR != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter2.GetResult();
				}
				finally
				{
					if (num < 0 && _003Cresponse_003E5__2 != null)
					{
						((IDisposable)_003Cresponse_003E5__2).Dispose();
					}
				}
				_003Cresponse_003E5__2 = null;
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

		internal static bool Hsv3PJWjpJZBQllb7UoF()
		{
			return Yn7HswWjyR29LXQITpOR == null;
		}
	}

	private readonly string D8ftoYMYCh3;

	private readonly string ITrtoI93CUZ;

	private string dLrtoWupRyw;

	private readonly string Joltok6otb2;

	private readonly ActionExecuteContext QOutoGNQXbW;

	private string qeQtosot3JC;

	public string _tempPathName;

	[CompilerGenerated]
	private ProgressChangedHandler hj2toHcluqk;

	[CompilerGenerated]
	private int WCPto19hNYk;

	[CompilerGenerated]
	private CancellationTokenSource HPltobPiBwe;

	[CompilerGenerated]
	private bool? Ir1to6q1dyq;

	[CompilerGenerated]
	private string cCNtoXfKXsD;

	[CompilerGenerated]
	private string gARtomFlVcI;

	[CompilerGenerated]
	private long? MPbtoK8YTpx;

	[CompilerGenerated]
	private long FWwtoxLjS3D;

	private static HttpClientWithProgress aj5wWDQiQMhXxWDsXM8T;

	public string SaveFileName => dLrtoWupRyw;

	public string FullPathName => qeQtosot3JC;

	public int ExpireMs
	{
		[CompilerGenerated]
		get
		{
			return WCPto19hNYk;
		}
		[CompilerGenerated]
		set
		{
			WCPto19hNYk = value;
		}
	}

	public CancellationTokenSource Cts
	{
		[CompilerGenerated]
		get
		{
			return HPltobPiBwe;
		}
		[CompilerGenerated]
		set
		{
			HPltobPiBwe = value;
		}
	}

	public bool? AutoRename
	{
		[CompilerGenerated]
		get
		{
			return Ir1to6q1dyq;
		}
		[CompilerGenerated]
		private set
		{
			Ir1to6q1dyq = value;
		}
	}

	public string ETag
	{
		[CompilerGenerated]
		get
		{
			return cCNtoXfKXsD;
		}
		[CompilerGenerated]
		set
		{
			cCNtoXfKXsD = value;
		}
	}

	public string ContentMD5
	{
		[CompilerGenerated]
		get
		{
			return gARtomFlVcI;
		}
		[CompilerGenerated]
		set
		{
			gARtomFlVcI = value;
		}
	}

	public long? TotalBytes
	{
		[CompilerGenerated]
		get
		{
			return MPbtoK8YTpx;
		}
		[CompilerGenerated]
		set
		{
			MPbtoK8YTpx = value;
		}
	}

	public long DownloadedSize
	{
		[CompilerGenerated]
		get
		{
			return FWwtoxLjS3D;
		}
		[CompilerGenerated]
		set
		{
			FWwtoxLjS3D = value;
		}
	}

	public event ProgressChangedHandler ProgressChanged
	{
		[CompilerGenerated]
		add
		{
			ProgressChangedHandler progressChangedHandler = hj2toHcluqk;
			ProgressChangedHandler progressChangedHandler2;
			do
			{
				progressChangedHandler2 = progressChangedHandler;
				ProgressChangedHandler value2 = (ProgressChangedHandler)Delegate.Combine(progressChangedHandler2, value);
				progressChangedHandler = Interlocked.CompareExchange(ref hj2toHcluqk, value2, progressChangedHandler2);
			}
			while ((object)progressChangedHandler != progressChangedHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ProgressChangedHandler progressChangedHandler = hj2toHcluqk;
			ProgressChangedHandler progressChangedHandler2;
			do
			{
				progressChangedHandler2 = progressChangedHandler;
				ProgressChangedHandler value2 = (ProgressChangedHandler)Delegate.Remove(progressChangedHandler2, value);
				progressChangedHandler = Interlocked.CompareExchange(ref hj2toHcluqk, value2, progressChangedHandler2);
			}
			while ((object)progressChangedHandler != progressChangedHandler2);
		}
	}

	public HttpClientWithProgress(string downloadUrl, string saveFolder, string saveName, string fallbackName, HttpMessageHandler handler = null, ActionExecuteContext context = null, int expireMs = 10000, CancellationTokenSource cts = null, bool? autoRename = null)
		: base((handler == null) ? new HttpClientHandler() : handler)
	{
		D8ftoYMYCh3 = downloadUrl;
		ITrtoI93CUZ = saveFolder;
		dLrtoWupRyw = saveName;
		Joltok6otb2 = fallbackName;
		QOutoGNQXbW = context;
		ExpireMs = expireMs;
		Cts = cts;
		AutoRename = autoRename;
		base.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
		{
			NoCache = true
		};
	}

	[AsyncStateMachine(typeof(_003CStartDownload_003Ed__43))]
	public Task StartDownload()
	{
		_003CStartDownload_003Ed__43 stateMachine = default(_003CStartDownload_003Ed__43);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDownloadFileFromHttpResponseMessage_003Ed__44))]
	private Task w8tto7dYCvw(HttpResponseMessage httpResponseMessage_0)
	{
		_003CDownloadFileFromHttpResponseMessage_003Ed__44 stateMachine = default(_003CDownloadFileFromHttpResponseMessage_003Ed__44);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.response = httpResponseMessage_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void DownloadWithWebClient(string uri, string filePath)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.GFJvlFOvPU5 = this;
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		long fileSize = GetFileSize(uri);
		TotalBytes = fileSize;
		int num = 0;
		if (aj5wWDQiQMhXxWDsXM8T != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		QOutoGNQXbW?.ActionLogger.LogInfo($"获得文件大小：{fileSize}");
		_003C_003Ec__DisplayClass45_.QvtvlUP8pCH = new WebClient();
		try
		{
			_003C_003Ec__DisplayClass45_1 _003C_003Ec__DisplayClass45_2 = new _003C_003Ec__DisplayClass45_1();
			_003C_003Ec__DisplayClass45_.QvtvlUP8pCH.DownloadProgressChanged += _003C_003Ec__DisplayClass45_.MLdvlOhf78k;
			_003C_003Ec__DisplayClass45_2.AYJvliAqP86 = new ManualResetEventSlim(false);
			int num3 = 0;
			if (!Bu5sNIQiFTsfuhSYtHY4())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
			_003C_003Ec__DisplayClass45_.QvtvlUP8pCH.DownloadFileCompleted += _003C_003Ec__DisplayClass45_2.EIHvllkRHsf;
			_003C_003Ec__DisplayClass45_.QvtvlUP8pCH.DownloadFileAsync(new Uri(uri), filePath);
			_003C_003Ec__DisplayClass45_2.AYJvliAqP86.Wait(Cts.Token);
			CancellationTokenSource cts = Cts;
			if (cts != null && cts.IsCancellationRequested && _003C_003Ec__DisplayClass45_.QvtvlUP8pCH.IsBusy)
			{
				_003C_003Ec__DisplayClass45_.QvtvlUP8pCH.CancelAsync();
			}
			else if (TotalBytes.HasValue && TotalBytes > 0L && DownloadedSize != TotalBytes)
			{
				throw new InvalidDataException($"下载的文件不完整，预期大小{TotalBytes},实际大小{DownloadedSize}。");
			}
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			if (_003C_003Ec__DisplayClass45_.QvtvlUP8pCH != null)
			{
				((IDisposable)_003C_003Ec__DisplayClass45_.QvtvlUP8pCH).Dispose();
			}
		}
	}

	public void ParallelDownloadFile(string uri, string filePath, int chunkSize)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.g59vlfbR2SG = uri;
		_003C_003Ec__DisplayClass46_.Kp7vlzSti7j = chunkSize;
		if (aj5wWDQiQMhXxWDsXM8T != null)
		{
			switch (0)
			{
			}
		}
		if (_003C_003Ec__DisplayClass46_.g59vlfbR2SG == null)
		{
			throw new ArgumentNullException("uri");
		}
		long fileSize = GetFileSize(_003C_003Ec__DisplayClass46_.g59vlfbR2SG);
		QOutoGNQXbW?.ActionLogger.LogInfo($"获得文件大小：{fileSize}");
		_003C_003Ec__DisplayClass46_.VR7viwvCIZK = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write);
		try
		{
			_003C_003Ec__DisplayClass46_.VR7viwvCIZK.SetLength(fileSize);
			_003C_003Ec__DisplayClass46_.MeVvitwGBLo = new object();
			Parallel.ForEach(KuttoRNpVnA(0L, 1L + fileSize / _003C_003Ec__DisplayClass46_.Kp7vlzSti7j), new ParallelOptions
			{
				MaxDegreeOfParallelism = 4
			}, _003C_003Ec__DisplayClass46_.XNJvl36uS9L);
		}
		finally
		{
			if (_003C_003Ec__DisplayClass46_.VR7viwvCIZK != null)
			{
				((IDisposable)_003C_003Ec__DisplayClass46_.VR7viwvCIZK).Dispose();
			}
		}
	}

	public long GetFileSize(string uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(uri);
		obj.Method = "HEAD";
		HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
		long contentLength = httpWebResponse.ContentLength;
		string text = httpWebResponse.Headers["Content-Range"];
		int num = 0;
		if (!Bu5sNIQiFTsfuhSYtHY4())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (!string.IsNullOrWhiteSpace(text))
			{
				string[] array = text.Split('/');
				if (array.Length == 2 && array[1] != "*")
				{
					long num3 = Convert.ToInt64(array[1].Trim());
					if (num3 != contentLength && num3 > 0L)
					{
						QOutoGNQXbW?.ActionLogger.LogInfo($"ContentLength 和 ContentRange中的数据长度不一致。{contentLength} {num3}");
						return num3;
					}
				}
			}
			return httpWebResponse.ContentLength;
		}
	}

	[IteratorStateMachine(typeof(_003CLongRange_003Ed__48))]
	private static IEnumerable<long> KuttoRNpVnA(long long_1, long long_2)
	{
		return new _003CLongRange_003Ed__48(-2)
		{
			_003C_003E3__start = long_1,
			_003C_003E3__count = long_2
		};
	}

	private void obBtoqFT7in(HttpResponseMessage httpResponseMessage_0)
	{
		if (!string.IsNullOrWhiteSpace(dLrtoWupRyw))
		{
			if (AutoRename == true)
			{
				dLrtoWupRyw = O6StoZpSsHv(ITrtoI93CUZ, dLrtoWupRyw);
			}
			qeQtosot3JC = Path.Combine(ITrtoI93CUZ, dLrtoWupRyw);
			return;
		}
		string text = OshtocsrJPY(httpResponseMessage_0.Content.Headers.ContentDisposition);
		string fileName;
		int num;
		if (string.IsNullOrEmpty(text))
		{
			fileName = Path.GetFileName(httpResponseMessage_0.RequestMessage.RequestUri.LocalPath);
			num = 1;
			if (!Bu5sNIQiFTsfuhSYtHY4())
			{
				goto IL_00ad;
			}
			goto IL_00b1;
		}
		try
		{
			text = text.Trim(' ', '"');
			text = PathHelper.RemoveInvalidCharsFromFileName(text);
		}
		catch (Exception)
		{
		}
		goto IL_010a;
		IL_00b1:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (string.IsNullOrEmpty(fileName))
				{
					text = Joltok6otb2.Or(DateTime.Now.ToString("yyyyMMdd_HHmmss.qkd"));
					break;
				}
				goto IL_009c;
			}
			break;
			IL_009c:
			text = fileName;
			num = 0;
			if (Bu5sNIQiFTsfuhSYtHY4())
			{
				continue;
			}
			goto IL_00ad;
		}
		goto IL_010a;
		IL_010a:
		dLrtoWupRyw = text;
		if (!AutoRename.HasValue || AutoRename == true)
		{
			dLrtoWupRyw = O6StoZpSsHv(ITrtoI93CUZ, dLrtoWupRyw);
		}
		qeQtosot3JC = Path.Combine(ITrtoI93CUZ, dLrtoWupRyw);
		return;
		IL_00ad:
		int num2 = default(int);
		num = num2;
		goto IL_00b1;
	}

	private static string OshtocsrJPY(ContentDispositionHeaderValue contentDispositionHeaderValue_0)
	{
		if (contentDispositionHeaderValue_0 == null)
		{
			return null;
		}
		string fileNameStar = contentDispositionHeaderValue_0.FileNameStar;
		if (!string.IsNullOrEmpty(fileNameStar))
		{
			return th9toVZtchp(fileNameStar);
		}
		fileNameStar = contentDispositionHeaderValue_0.FileName;
		if (!string.IsNullOrEmpty(fileNameStar))
		{
			return th9toVZtchp(fileNameStar);
		}
		return null;
	}

	private static string th9toVZtchp(string string_6)
	{
		string pattern = "UTF-8''(.+)";
		Match match = Regex.Match(string_6, pattern);
		if (match.Success)
		{
			return Uri.UnescapeDataString(match.Groups[1].Value);
		}
		return Uri.UnescapeDataString(string_6);
	}

	private static string O6StoZpSsHv(string string_6, string string_7)
	{
		if (System.IO.File.Exists(Path.Combine(string_6, string_7)))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_7);
			string extension = Path.GetExtension(string_7);
			int num = 1;
			string text;
			do
			{
				text = fileNameWithoutExtension + $"_{num}" + extension;
				if (aj5wWDQiQMhXxWDsXM8T == null)
				{
					switch (0)
					{
					}
				}
				num++;
			}
			while (System.IO.File.Exists(Path.Combine(string_6, text)));
			return text;
		}
		return string_7;
	}

	public static string FindAvailableName(string pathName)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetFileName(pathName));
		string directoryName = Path.GetDirectoryName(pathName);
		if (string.IsNullOrWhiteSpace(directoryName))
		{
			throw new InvalidDataException("仅支持完整路径。");
		}
		string extension = Path.GetExtension(pathName);
		int num = 1;
		string text;
		do
		{
			text = Path.Combine(directoryName, $"{fileNameWithoutExtension}({num}){extension}");
		}
		while (System.IO.File.Exists(text));
		return text;
	}

	[AsyncStateMachine(typeof(_003CProcessContentStream_003Ed__54))]
	private Task KBOto9juMSi(long? nullable_2, Stream stream_0)
	{
		_003CProcessContentStream_003Ed__54 stateMachine = default(_003CProcessContentStream_003Ed__54);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.totalDownloadSize = nullable_2;
		stateMachine.contentStream = stream_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void HY0toh8yRSM(long? nullable_2, long long_1)
	{
		if (hj2toHcluqk != null)
		{
			double? progressPercentage = null;
			if (nullable_2.HasValue)
			{
				progressPercentage = Math.Round((double)long_1 / (double)nullable_2.Value * 100.0, 2);
			}
			hj2toHcluqk(nullable_2, long_1, progressPercentage);
		}
	}

	internal static bool Bu5sNIQiFTsfuhSYtHY4()
	{
		return aj5wWDQiQMhXxWDsXM8T == null;
	}
}
