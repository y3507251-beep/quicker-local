using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenAI_API.Files;

public class FilesEndpoint : EndpointBase, IFilesEndpoint
{
	private class UVQBOgd4cyYkM1pVL2G : ApiResultBase
	{
		[CompilerGenerated]
		private List<File> yrvva9cFOg3;

		[CompilerGenerated]
		private string pLBvahW0X5x;

		internal static UVQBOgd4cyYkM1pVL2G jqIeWEc1luo9sfvAulNl;

		[JsonProperty("data")]
		public List<File> Data
		{
			[CompilerGenerated]
			get
			{
				return yrvva9cFOg3;
			}
			[CompilerGenerated]
			set
			{
				yrvva9cFOg3 = value;
			}
		}

		[JsonProperty("object")]
		public string JKOvaZAdaxN
		{
			[CompilerGenerated]
			get
			{
				return pLBvahW0X5x;
			}
			[CompilerGenerated]
			set
			{
				pLBvahW0X5x = value;
			}
		}

		internal static bool tILhBic1ZflJo6hur6gT()
		{
			return jqIeWEc1luo9sfvAulNl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteFileAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<File> _003C_003Et__builder;

		public FilesEndpoint _003C_003E4__this;

		public string fileId;

		private TaskAwaiter<File> _003C_003Eu__1;

		internal static object eRAvDWc1YZ0tttBwB2ms;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FilesEndpoint filesEndpoint = _003C_003E4__this;
			File result;
			try
			{
				TaskAwaiter<File> awaiter;
				if (num != 0)
				{
					awaiter = filesEndpoint.cbsq2d02C3<File>(filesEndpoint.Url + "/" + fileId).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<File>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
				if (eRAvDWc1YZ0tttBwB2ms != null)
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

		internal static bool CXxRuac18C3A2JWZLSDa()
		{
			return eRAvDWc1YZ0tttBwB2ms == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFileAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<File> _003C_003Et__builder;

		public FilesEndpoint _003C_003E4__this;

		public string fileId;

		private TaskAwaiter<File> _003C_003Eu__1;

		private static object xjO5hhc1gcQMwsljQr4o;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FilesEndpoint filesEndpoint = _003C_003E4__this;
			File result;
			try
			{
				TaskAwaiter<File> awaiter;
				if (num != 0)
				{
					awaiter = filesEndpoint.voeqvITQWy<File>(filesEndpoint.Url + "/" + fileId).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<File>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!MArDf3c1PM8wcqme1ChO())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
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

		internal static bool MArDf3c1PM8wcqme1ChO()
		{
			return xjO5hhc1gcQMwsljQr4o == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFileContentAsStringAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public FilesEndpoint _003C_003E4__this;

		public string fileId;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object YHRSTYc1U1hCmLKrr8iT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FilesEndpoint filesEndpoint = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = filesEndpoint.bZVqtfnqdY(filesEndpoint.Url + "/" + fileId + "/content").GetAwaiter();
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

		internal static bool xrixJ5c1xcXtSMNstIyY()
		{
			return YHRSTYc1U1hCmLKrr8iT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetFilesAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<File>> _003C_003Et__builder;

		public FilesEndpoint _003C_003E4__this;

		private TaskAwaiter<UVQBOgd4cyYkM1pVL2G> _003C_003Eu__1;

		internal static object UptG6Pc169FDQx6EPyws;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FilesEndpoint filesEndpoint = _003C_003E4__this;
			List<File> result;
			try
			{
				TaskAwaiter<UVQBOgd4cyYkM1pVL2G> awaiter;
				if (num != 0)
				{
					awaiter = filesEndpoint.voeqvITQWy<UVQBOgd4cyYkM1pVL2G>(null).GetAwaiter();
					if (!Fal8Eoc1tMRuvhSOmuhR())
					{
						switch (0)
						{
						}
					}
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
					_003C_003Eu__1 = default(TaskAwaiter<UVQBOgd4cyYkM1pVL2G>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult().Data;
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

		internal static bool Fal8Eoc1tMRuvhSOmuhR()
		{
			return UptG6Pc169FDQx6EPyws == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFileAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<File> _003C_003Et__builder;

		public string purpose;

		public string filePath;

		public FilesEndpoint _003C_003E4__this;

		private TaskAwaiter<File> _003C_003Eu__1;

		private static object c23DR9c1wtrkT0LwYYXy;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FilesEndpoint filesEndpoint = _003C_003E4__this;
			File result;
			try
			{
				TaskAwaiter<File> awaiter;
				if (num != 0)
				{
					MultipartFormDataContent object_ = new MultipartFormDataContent
					{
						{
							new StringContent(purpose),
							"purpose"
						},
						{
							new ByteArrayContent(System.IO.File.ReadAllBytes(filePath)),
							"file",
							Path.GetFileName(filePath)
						}
					};
					awaiter = filesEndpoint.xm2qSnuXRK<File>(filesEndpoint.Url, object_).GetAwaiter();
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
					if (!Aqvjh2c1T7xT43Jv0bco())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter<File>);
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

		internal static bool Aqvjh2c1T7xT43Jv0bco()
		{
			return c23DR9c1wtrkT0LwYYXy == null;
		}
	}

	internal static FilesEndpoint Wcw05qkH8TLemuEdNo1;

	protected override string Endpoint => "files";

	internal FilesEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CGetFilesAsync_003Ed__3))]
	public Task<List<File>> GetFilesAsync()
	{
		_003CGetFilesAsync_003Ed__3 stateMachine = default(_003CGetFilesAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<File>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetFileAsync_003Ed__4))]
	public Task<File> GetFileAsync(string fileId)
	{
		_003CGetFileAsync_003Ed__4 stateMachine = default(_003CGetFileAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<File>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileId = fileId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetFileContentAsStringAsync_003Ed__5))]
	public Task<string> GetFileContentAsStringAsync(string fileId)
	{
		_003CGetFileContentAsStringAsync_003Ed__5 stateMachine = default(_003CGetFileContentAsStringAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileId = fileId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDeleteFileAsync_003Ed__6))]
	public Task<File> DeleteFileAsync(string fileId)
	{
		_003CDeleteFileAsync_003Ed__6 stateMachine = default(_003CDeleteFileAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<File>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileId = fileId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CUploadFileAsync_003Ed__7))]
	public Task<File> UploadFileAsync(string filePath, string purpose = "fine-tune")
	{
		_003CUploadFileAsync_003Ed__7 stateMachine = default(_003CUploadFileAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<File>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.filePath = filePath;
		stateMachine.purpose = purpose;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool Wwrj3hkzgfwW6Iv9C6K()
	{
		return Wcw05qkH8TLemuEdNo1 == null;
	}
}
