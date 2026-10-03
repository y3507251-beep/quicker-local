using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace OpenAI_API.Audio;

public class TranscriptionEndpoint : EndpointBase, ITranscriptionEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAsFormatAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string language;

		public TranscriptionEndpoint _003C_003E4__this;

		public string prompt;

		public double? temperature;

		public string responseFormat;

		public Stream audioStream;

		public string filename;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object PpAdYDcB5OHRRZE8AKQo;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					AudioRequest audioRequest = new AudioRequest
					{
						Language = (language ?? transcriptionEndpoint.DefaultRequestArgs.Language),
						Model = transcriptionEndpoint.DefaultRequestArgs.Model,
						Prompt = (prompt ?? transcriptionEndpoint.DefaultRequestArgs.Prompt),
						Temperature = (temperature ?? transcriptionEndpoint.DefaultRequestArgs.Temperature),
						ResponseFormat = (responseFormat ?? transcriptionEndpoint.DefaultRequestArgs.ResponseFormat)
					};
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						audioStream.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(audioRequest.Model),
								"model"
							},
							{
								new StringContent(audioRequest.ResponseFormat),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								filename
							}
						};
						if (!string.IsNullOrEmpty(audioRequest.Language))
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Language), "language");
						}
						if (!string.IsNullOrEmpty(audioRequest.Prompt))
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Prompt), "prompt");
						}
						if (audioRequest.Temperature != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Temperature.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)memoryStream)?.Dispose();
						}
					}
					awaiter = transcriptionEndpoint.bZVqtfnqdY(transcriptionEndpoint.Url, HttpMethod.Post, multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (AYjxuncBYBDpSUZq8jfU())
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<string>);
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

		internal static bool AYjxuncBYBDpSUZq8jfU()
		{
			return PpAdYDcB5OHRRZE8AKQo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAsFormatAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string audioFilePath;

		public TranscriptionEndpoint _003C_003E4__this;

		public string responseFormat;

		public string language;

		public string prompt;

		public double? temperature;

		private FileStream _003CfileStream_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object avuQWbcBgLg95jhLfVIV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			string result;
			try
			{
				if (num != 0)
				{
					_003CfileStream_003E5__2 = File.OpenRead(audioFilePath);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = transcriptionEndpoint.GetAsFormatAsync(_003CfileStream_003E5__2, Path.GetFileName(audioFilePath), responseFormat, language, prompt, temperature).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					result = awaiter.GetResult();
					int num2 = 0;
					if (!YqyFJZcBPADP3JHD9aK7())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				finally
				{
					if (num < 0 && _003CfileStream_003E5__2 != null)
					{
						((IDisposable)_003CfileStream_003E5__2).Dispose();
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

		internal static bool YqyFJZcBPADP3JHD9aK7()
		{
			return avuQWbcBgLg95jhLfVIV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetTextAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public TranscriptionEndpoint _003C_003E4__this;

		public Stream audioStream;

		public string filename;

		public string language;

		public string prompt;

		public double? temperature;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object SBwsXacBUNwQYttRhryA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = transcriptionEndpoint.GetAsFormatAsync(audioStream, filename, "text", language, prompt, temperature).GetAwaiter();
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
					if (QAtjKGcBxHCKBNiJJtkd())
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(TaskAwaiter<string>);
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

		internal static bool QAtjKGcBxHCKBNiJJtkd()
		{
			return SBwsXacBUNwQYttRhryA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetTextAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string audioFilePath;

		public TranscriptionEndpoint _003C_003E4__this;

		public string language;

		public string prompt;

		public double? temperature;

		private FileStream _003CfileStream_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object wCQdhGcB6jPZvQ98GRnL;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			string result;
			try
			{
				if (num != 0)
				{
					_003CfileStream_003E5__2 = File.OpenRead(audioFilePath);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = transcriptionEndpoint.GetTextAsync(_003CfileStream_003E5__2, Path.GetFileName(audioFilePath), language, prompt, temperature).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					result = awaiter.GetResult();
					if (wCQdhGcB6jPZvQ98GRnL == null)
					{
						switch (0)
						{
						}
					}
				}
				finally
				{
					if (num < 0 && _003CfileStream_003E5__2 != null)
					{
						((IDisposable)_003CfileStream_003E5__2).Dispose();
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

		internal static bool CUFe76cBt6Z9GTIOQw4Y()
		{
			return wCQdhGcB6jPZvQ98GRnL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetWithDetailsAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AudioResultVerbose> _003C_003Et__builder;

		public string language;

		public TranscriptionEndpoint _003C_003E4__this;

		public string prompt;

		public double? temperature;

		public Stream audioStream;

		public string filename;

		private TaskAwaiter<AudioResultVerbose> _003C_003Eu__1;

		internal static object vxPhDIcBwVpqjHwqFta5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			AudioResultVerbose result;
			try
			{
				TaskAwaiter<AudioResultVerbose> awaiter;
				if (num != 0)
				{
					AudioRequest audioRequest = new AudioRequest
					{
						Language = (language ?? transcriptionEndpoint.DefaultRequestArgs.Language),
						Model = transcriptionEndpoint.DefaultRequestArgs.Model,
						Prompt = (prompt ?? transcriptionEndpoint.DefaultRequestArgs.Prompt),
						Temperature = (temperature ?? transcriptionEndpoint.DefaultRequestArgs.Temperature)
					};
					audioRequest.ResponseFormat = "verbose_json";
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						audioStream.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(audioRequest.Model),
								"model"
							},
							{
								new StringContent(audioRequest.ResponseFormat),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								filename
							}
						};
						if (!string.IsNullOrEmpty(audioRequest.Language))
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Language), "language");
						}
						if (!string.IsNullOrEmpty(audioRequest.Prompt))
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Prompt), "prompt");
						}
						if (audioRequest.Temperature != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(audioRequest.Temperature.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)memoryStream)?.Dispose();
						}
					}
					awaiter = transcriptionEndpoint.xm2qSnuXRK<AudioResultVerbose>(transcriptionEndpoint.Url, multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!rIe8P0cBTmRJ3lKMKyx4())
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
					_003C_003Eu__1 = default(TaskAwaiter<AudioResultVerbose>);
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

		internal static bool rIe8P0cBTmRJ3lKMKyx4()
		{
			return vxPhDIcBwVpqjHwqFta5 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetWithDetailsAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AudioResultVerbose> _003C_003Et__builder;

		public string audioFilePath;

		public TranscriptionEndpoint _003C_003E4__this;

		public string language;

		public string prompt;

		public double? temperature;

		private FileStream _003CfileStream_003E5__2;

		private TaskAwaiter<AudioResultVerbose> _003C_003Eu__1;

		internal static object LbmMetcBhJuqvgaZrAGF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TranscriptionEndpoint transcriptionEndpoint = _003C_003E4__this;
			AudioResultVerbose result;
			try
			{
				if (num != 0)
				{
					_003CfileStream_003E5__2 = File.OpenRead(audioFilePath);
				}
				try
				{
					TaskAwaiter<AudioResultVerbose> awaiter;
					if (num != 0)
					{
						awaiter = transcriptionEndpoint.GetWithDetailsAsync(_003CfileStream_003E5__2, Path.GetFileName(audioFilePath), language, prompt, temperature).GetAwaiter();
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
						if (LbmMetcBhJuqvgaZrAGF == null)
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = default(TaskAwaiter<AudioResultVerbose>);
						num = -1;
						_003C_003E1__state = -1;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && _003CfileStream_003E5__2 != null)
					{
						((IDisposable)_003CfileStream_003E5__2).Dispose();
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

		internal static bool xvptntcBHLHqHB4ZxvsR()
		{
			return LbmMetcBhJuqvgaZrAGF == null;
		}
	}

	[CompilerGenerated]
	private AudioRequest qJUZRNqhIf = new AudioRequest();

	[CompilerGenerated]
	private readonly bool s0RZq4NrTE;

	private static TranscriptionEndpoint xKQ1ROrNtYy0WEJmmQS;

	protected override string Endpoint
	{
		get
		{
			if (pfaZaLR5E3())
			{
				return "audio/translations";
			}
			return "audio/transcriptions";
		}
	}

	public AudioRequest DefaultRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return qJUZRNqhIf;
		}
		[CompilerGenerated]
		set
		{
			qJUZRNqhIf = value;
		}
	}

	internal TranscriptionEndpoint(OpenAIAPI api, bool translate)
		: base(api)
	{
		s0RZq4NrTE = translate;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool pfaZaLR5E3()
	{
		return s0RZq4NrTE;
	}

	[AsyncStateMachine(typeof(_003CGetTextAsync_003Ed__10))]
	public Task<string> GetTextAsync(Stream audioStream, string filename, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetTextAsync_003Ed__10 stateMachine = default(_003CGetTextAsync_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioStream = audioStream;
		stateMachine.filename = filename;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetTextAsync_003Ed__11))]
	public Task<string> GetTextAsync(string audioFilePath, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetTextAsync_003Ed__11 stateMachine = default(_003CGetTextAsync_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioFilePath = audioFilePath;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetWithDetailsAsync_003Ed__12))]
	public Task<AudioResultVerbose> GetWithDetailsAsync(Stream audioStream, string filename, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetWithDetailsAsync_003Ed__12 stateMachine = default(_003CGetWithDetailsAsync_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AudioResultVerbose>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioStream = audioStream;
		stateMachine.filename = filename;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetWithDetailsAsync_003Ed__13))]
	public Task<AudioResultVerbose> GetWithDetailsAsync(string audioFilePath, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetWithDetailsAsync_003Ed__13 stateMachine = default(_003CGetWithDetailsAsync_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AudioResultVerbose>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioFilePath = audioFilePath;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetAsFormatAsync_003Ed__14))]
	public Task<string> GetAsFormatAsync(Stream audioStream, string filename, string responseFormat, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetAsFormatAsync_003Ed__14 stateMachine = default(_003CGetAsFormatAsync_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioStream = audioStream;
		stateMachine.filename = filename;
		stateMachine.responseFormat = responseFormat;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetAsFormatAsync_003Ed__15))]
	public Task<string> GetAsFormatAsync(string audioFilePath, string responseFormat, string language = null, string prompt = null, double? temperature = null)
	{
		_003CGetAsFormatAsync_003Ed__15 stateMachine = default(_003CGetAsFormatAsync_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.audioFilePath = audioFilePath;
		stateMachine.responseFormat = responseFormat;
		stateMachine.language = language;
		stateMachine.prompt = prompt;
		stateMachine.temperature = temperature;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool VXj8jpr9TBLWp4K4EA5()
	{
		return xKQ1ROrNtYy0WEJmmQS == null;
	}
}
