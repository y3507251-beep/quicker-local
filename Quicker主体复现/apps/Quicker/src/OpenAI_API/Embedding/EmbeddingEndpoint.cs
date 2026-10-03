using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Embedding;

public class EmbeddingEndpoint : EndpointBase, IEmbeddingEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateEmbeddingAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EmbeddingResult> _003C_003Et__builder;

		public EmbeddingEndpoint _003C_003E4__this;

		public string input;

		private TaskAwaiter<EmbeddingResult> _003C_003Eu__1;

		internal static object chlZHjc1suBVhE9MOWC9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EmbeddingEndpoint embeddingEndpoint = _003C_003E4__this;
			EmbeddingResult result;
			try
			{
				TaskAwaiter<EmbeddingResult> awaiter;
				if (num != 0)
				{
					EmbeddingRequest request = new EmbeddingRequest(embeddingEndpoint.DefaultEmbeddingRequestArgs.Model, input);
					awaiter = embeddingEndpoint.CreateEmbeddingAsync(request).GetAwaiter();
					if (tdEKbMc1Cs2wftv7j0NV())
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
					_003C_003Eu__1 = default(TaskAwaiter<EmbeddingResult>);
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

		internal static bool tdEKbMc1Cs2wftv7j0NV()
		{
			return chlZHjc1suBVhE9MOWC9 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateEmbeddingAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EmbeddingResult> _003C_003Et__builder;

		public EmbeddingEndpoint _003C_003E4__this;

		public EmbeddingRequest request;

		private TaskAwaiter<EmbeddingResult> _003C_003Eu__1;

		internal static object XxPcqvc14TlJuVFXRTOp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EmbeddingEndpoint embeddingEndpoint = _003C_003E4__this;
			EmbeddingResult result;
			try
			{
				TaskAwaiter<EmbeddingResult> awaiter;
				if (num != 0)
				{
					awaiter = embeddingEndpoint.xm2qSnuXRK<EmbeddingResult>(null, request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<EmbeddingResult>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!Eu15spc1hLBQHIHj91F8())
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

		internal static bool Eu15spc1hLBQHIHj91F8()
		{
			return XxPcqvc14TlJuVFXRTOp == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetEmbeddingsAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<float[]> _003C_003Et__builder;

		public Model model;

		public string input;

		public int? dimensions;

		public EmbeddingEndpoint _003C_003E4__this;

		private TaskAwaiter<EmbeddingResult> _003C_003Eu__1;

		private static object lfCHPVc1zlkE5m2ofFUk;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EmbeddingEndpoint embeddingEndpoint = _003C_003E4__this;
			float[] result;
			try
			{
				TaskAwaiter<EmbeddingResult> awaiter;
				if (num != 0)
				{
					Model obj = model;
					if (obj == null)
					{
						int num2 = 0;
						if (lfCHPVc1zlkE5m2ofFUk != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						obj = Model.DefaultEmbeddingModel;
					}
					EmbeddingRequest request = new EmbeddingRequest(obj, input, dimensions);
					awaiter = embeddingEndpoint.CreateEmbeddingAsync(request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<EmbeddingResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult()?.Data?[0]?.Embedding;
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

		static _003CGetEmbeddingsAsync_003Ed__10()
		{
		}

		internal static bool wmWwWRcKVdYDc7J7f9RH()
		{
			return lfCHPVc1zlkE5m2ofFUk == null;
		}

		internal static void M6a5wMcKFMkNIrV8UY2J()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetEmbeddingsAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<float[]> _003C_003Et__builder;

		public EmbeddingEndpoint _003C_003E4__this;

		public string input;

		private TaskAwaiter<EmbeddingResult> _003C_003Eu__1;

		private static object w4uNbocKcaFbbAIne2Li;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EmbeddingEndpoint embeddingEndpoint = _003C_003E4__this;
			float[] result;
			try
			{
				TaskAwaiter<EmbeddingResult> awaiter;
				if (num != 0)
				{
					EmbeddingRequest request = new EmbeddingRequest(embeddingEndpoint.DefaultEmbeddingRequestArgs.Model, input);
					awaiter = embeddingEndpoint.CreateEmbeddingAsync(request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (w4uNbocKcaFbbAIne2Li != null)
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
					_003C_003Eu__1 = default(TaskAwaiter<EmbeddingResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult()?.Data?[0]?.Embedding;
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

		internal static bool sYbNRCcKWEm3Z6iyoVHZ()
		{
			return w4uNbocKcaFbbAIne2Li == null;
		}
	}

	[CompilerGenerated]
	private EmbeddingRequest kIuc6bvBDr = new EmbeddingRequest
	{
		Model = Model.DefaultEmbeddingModel
	};

	internal static EmbeddingEndpoint HtGu8BaWmm7iFVhsF4X;

	public EmbeddingRequest DefaultEmbeddingRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return kIuc6bvBDr;
		}
		[CompilerGenerated]
		set
		{
			kIuc6bvBDr = value;
		}
	}

	protected override string Endpoint => "embeddings";

	internal EmbeddingEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CCreateEmbeddingAsync_003Ed__7))]
	public Task<EmbeddingResult> CreateEmbeddingAsync(string input)
	{
		_003CCreateEmbeddingAsync_003Ed__7 stateMachine = default(_003CCreateEmbeddingAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EmbeddingResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateEmbeddingAsync_003Ed__8))]
	public Task<EmbeddingResult> CreateEmbeddingAsync(EmbeddingRequest request)
	{
		_003CCreateEmbeddingAsync_003Ed__8 stateMachine = default(_003CCreateEmbeddingAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EmbeddingResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetEmbeddingsAsync_003Ed__9))]
	public Task<float[]> GetEmbeddingsAsync(string input)
	{
		_003CGetEmbeddingsAsync_003Ed__9 stateMachine = default(_003CGetEmbeddingsAsync_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<float[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetEmbeddingsAsync_003Ed__10))]
	public Task<float[]> GetEmbeddingsAsync(string input, Model model = null, int? dimensions = null)
	{
		_003CGetEmbeddingsAsync_003Ed__10 stateMachine = default(_003CGetEmbeddingsAsync_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<float[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine.model = model;
		stateMachine.dimensions = dimensions;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool Gh8i2JayfdJ3838W8MO()
	{
		return HtGu8BaWmm7iFVhsF4X == null;
	}
}
