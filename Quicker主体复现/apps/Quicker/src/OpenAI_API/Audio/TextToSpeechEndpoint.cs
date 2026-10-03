using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Audio;

public class TextToSpeechEndpoint : EndpointBase, ITextToSpeechEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSpeechAsStreamAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public TextToSpeechEndpoint _003C_003E4__this;

		public TextToSpeechRequest request;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private static object CmsKqUcBKc9dRI9jAbHt;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextToSpeechEndpoint textToSpeechEndpoint = _003C_003E4__this;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					awaiter = textToSpeechEndpoint.GFBqgDhZtW(null, HttpMethod.Post, request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (CmsKqUcBKc9dRI9jAbHt == null)
						{
							switch (0)
							{
							}
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Stream>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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

		internal static bool OYaMqDcBBFq4tsEx5igB()
		{
			return CmsKqUcBKc9dRI9jAbHt == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSpeechAsStreamAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public string input;

		public string voice;

		public TextToSpeechEndpoint _003C_003E4__this;

		public double? speed;

		public Model model;

		public string responseFormat;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private static object I3YfmYcBdNTYnumfGyNv;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextToSpeechEndpoint textToSpeechEndpoint = _003C_003E4__this;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					TextToSpeechRequest object_ = new TextToSpeechRequest
					{
						Input = input,
						Voice = (voice ?? textToSpeechEndpoint.DefaultTTSRequestArgs.Voice),
						Speed = (speed ?? textToSpeechEndpoint.DefaultTTSRequestArgs.Speed),
						Model = (model ?? ((Model)textToSpeechEndpoint.DefaultTTSRequestArgs.Model)),
						ResponseFormat = (responseFormat ?? textToSpeechEndpoint.DefaultTTSRequestArgs.ResponseFormat)
					};
					awaiter = textToSpeechEndpoint.GFBqgDhZtW(null, HttpMethod.Post, object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (I3YfmYcBdNTYnumfGyNv != null)
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
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Stream>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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

		static _003CGetSpeechAsStreamAsync_003Ed__8()
		{
		}

		internal static bool j846cgcBOsH965AcdG06()
		{
			return I3YfmYcBdNTYnumfGyNv == null;
		}

		internal static void u1QSNccBavQbd37ZXn2M()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveSpeechToFileAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FileInfo> _003C_003Et__builder;

		public string input;

		public string voice;

		public TextToSpeechEndpoint _003C_003E4__this;

		public double? speed;

		public Model model;

		public string responseFormat;

		public string localPath;

		private TaskAwaiter<FileInfo> _003C_003Eu__1;

		private static object Hmw34icBrMMAWZ4rwwJ8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextToSpeechEndpoint textToSpeechEndpoint = _003C_003E4__this;
			FileInfo result;
			try
			{
				TaskAwaiter<FileInfo> awaiter;
				if (num != 0)
				{
					TextToSpeechRequest request = new TextToSpeechRequest
					{
						Input = input,
						Voice = (voice ?? textToSpeechEndpoint.DefaultTTSRequestArgs.Voice),
						Speed = (speed ?? textToSpeechEndpoint.DefaultTTSRequestArgs.Speed),
						Model = (model ?? ((Model)textToSpeechEndpoint.DefaultTTSRequestArgs.Model)),
						ResponseFormat = (responseFormat ?? textToSpeechEndpoint.DefaultTTSRequestArgs.ResponseFormat)
					};
					awaiter = textToSpeechEndpoint.SaveSpeechToFileAsync(request, localPath).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<FileInfo>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
				if (sGgRj3cBNSXO4r9Bb7nN())
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

		internal static bool sGgRj3cBNSXO4r9Bb7nN()
		{
			return Hmw34icBrMMAWZ4rwwJ8 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveSpeechToFileAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FileInfo> _003C_003Et__builder;

		public TextToSpeechEndpoint _003C_003E4__this;

		public TextToSpeechRequest request;

		public string localPath;

		private Stream _003Cstream_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private FileStream _003CoutputFileStream_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

		private static object C8Wcm2cBLHJunjTR8yIK;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextToSpeechEndpoint textToSpeechEndpoint = _003C_003E4__this;
			FileInfo result2;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0081;
					}
					awaiter = textToSpeechEndpoint.GetSpeechAsStreamAsync(request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<Stream>);
					num = -1;
					_003C_003E1__state = -1;
				}
				Stream result = awaiter.GetResult();
				_003Cstream_003E5__2 = result;
				goto IL_0081;
				IL_0081:
				try
				{
					if (num != 1)
					{
						_003CoutputFileStream_003E5__3 = new FileStream(localPath, FileMode.Create);
					}
					try
					{
						TaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = _003Cstream_003E5__2.CopyToAsync(_003CoutputFileStream_003E5__3).GetAwaiter();
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
							int num2 = 0;
							if (C8Wcm2cBLHJunjTR8yIK != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							_003C_003Eu__2 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && _003CoutputFileStream_003E5__3 != null)
						{
							((IDisposable)_003CoutputFileStream_003E5__3).Dispose();
						}
					}
					_003CoutputFileStream_003E5__3 = null;
				}
				finally
				{
					if (num < 0 && _003Cstream_003E5__2 != null)
					{
						((IDisposable)_003Cstream_003E5__2).Dispose();
					}
				}
				_003Cstream_003E5__2 = null;
				result2 = new FileInfo(localPath);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
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

		internal static bool kg3eWBcBuLDVt17pxZRr()
		{
			return C8Wcm2cBLHJunjTR8yIK == null;
		}
	}

	[CompilerGenerated]
	private TextToSpeechRequest MjxZ0eZEji = new TextToSpeechRequest();

	private static TextToSpeechEndpoint mHZJSRrdC83Z5R9mK73;

	protected override string Endpoint => "audio/speech";

	public TextToSpeechRequest DefaultTTSRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return MjxZ0eZEji;
		}
		[CompilerGenerated]
		set
		{
			MjxZ0eZEji = value;
		}
	}

	internal TextToSpeechEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CGetSpeechAsStreamAsync_003Ed__7))]
	public Task<Stream> GetSpeechAsStreamAsync(TextToSpeechRequest request)
	{
		_003CGetSpeechAsStreamAsync_003Ed__7 stateMachine = default(_003CGetSpeechAsStreamAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetSpeechAsStreamAsync_003Ed__8))]
	public Task<Stream> GetSpeechAsStreamAsync(string input, string voice = null, double? speed = null, string responseFormat = null, Model model = null)
	{
		_003CGetSpeechAsStreamAsync_003Ed__8 stateMachine = default(_003CGetSpeechAsStreamAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine.voice = voice;
		stateMachine.speed = speed;
		stateMachine.responseFormat = responseFormat;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CSaveSpeechToFileAsync_003Ed__9))]
	public Task<FileInfo> SaveSpeechToFileAsync(TextToSpeechRequest request, string localPath)
	{
		_003CSaveSpeechToFileAsync_003Ed__9 stateMachine = default(_003CSaveSpeechToFileAsync_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FileInfo>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.localPath = localPath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CSaveSpeechToFileAsync_003Ed__10))]
	public Task<FileInfo> SaveSpeechToFileAsync(string input, string localPath, string voice = null, double? speed = null, string responseFormat = null, Model model = null)
	{
		_003CSaveSpeechToFileAsync_003Ed__10 stateMachine = default(_003CSaveSpeechToFileAsync_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FileInfo>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine.localPath = localPath;
		stateMachine.voice = voice;
		stateMachine.speed = speed;
		stateMachine.responseFormat = responseFormat;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool hd7yBZrOWvgCIGsi8hk()
	{
		return mHZJSRrdC83Z5R9mK73 == null;
	}
}
