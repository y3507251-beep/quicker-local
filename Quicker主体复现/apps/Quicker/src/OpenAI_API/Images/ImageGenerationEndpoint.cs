using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Images;

public class ImageGenerationEndpoint : EndpointBase, IImageGenerationEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateImageAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageResult> _003C_003Et__builder;

		public string input;

		public Model model;

		public ImageGenerationEndpoint _003C_003E4__this;

		private TaskAwaiter<ImageResult> _003C_003Eu__1;

		private static object H99wYhc1Jv098h2JJtmx;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ImageGenerationEndpoint imageGenerationEndpoint = _003C_003E4__this;
			ImageResult result;
			try
			{
				TaskAwaiter<ImageResult> awaiter;
				if (num != 0)
				{
					ImageGenerationRequest request = new ImageGenerationRequest(input, model);
					awaiter = imageGenerationEndpoint.CreateImageAsync(request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (AqK0U4c1k93glT6d9KTW())
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
					_003C_003Eu__1 = default(TaskAwaiter<ImageResult>);
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

		internal static bool AqK0U4c1k93glT6d9KTW()
		{
			return H99wYhc1Jv098h2JJtmx == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateImageAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageResult> _003C_003Et__builder;

		public ImageGenerationEndpoint _003C_003E4__this;

		public ImageGenerationRequest request;

		private TaskAwaiter<ImageResult> _003C_003Eu__1;

		internal static object Q9SEi5c1rHa1v90ygdKH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ImageGenerationEndpoint imageGenerationEndpoint = _003C_003E4__this;
			ImageResult result;
			try
			{
				TaskAwaiter<ImageResult> awaiter;
				if (num != 0)
				{
					awaiter = imageGenerationEndpoint.xm2qSnuXRK<ImageResult>(null, request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<ImageResult>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!XMEG7Ec1NgNgvg5C0TjX())
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

		static _003CCreateImageAsync_003Ed__4()
		{
		}

		internal static bool XMEG7Ec1NgNgvg5C0TjX()
		{
			return Q9SEi5c1rHa1v90ygdKH == null;
		}

		internal static void wTFwfWc1LEQh01KKJ1qJ()
		{
		}
	}

	private static ImageGenerationEndpoint evHJSrkZ2BoCRoopD1v;

	protected override string Endpoint => "images/generations";

	internal ImageGenerationEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CCreateImageAsync_003Ed__3))]
	public Task<ImageResult> CreateImageAsync(string input, Model model = null)
	{
		_003CCreateImageAsync_003Ed__3 stateMachine = default(_003CCreateImageAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateImageAsync_003Ed__4))]
	public Task<ImageResult> CreateImageAsync(ImageGenerationRequest request)
	{
		_003CCreateImageAsync_003Ed__4 stateMachine = default(_003CCreateImageAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool EbCM6Yk5xhG3qBSUJkc()
	{
		return evHJSrkZ2BoCRoopD1v == null;
	}
}
