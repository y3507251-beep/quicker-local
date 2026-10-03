using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenAI_API.Models;

public class ModelsEndpoint : EndpointBase, IModelsEndpoint
{
	private class GZCp9ud1wFBkHb5rfho : ApiResultBase
	{
		[CompilerGenerated]
		private List<Model> YFIvaaIuOwO;

		[CompilerGenerated]
		private string agsva79RHF0;

		private static GZCp9ud1wFBkHb5rfho lvvLaUc1jHltLulI4Ek8;

		[JsonProperty("data")]
		public List<Model> data
		{
			[CompilerGenerated]
			get
			{
				return YFIvaaIuOwO;
			}
			[CompilerGenerated]
			set
			{
				YFIvaaIuOwO = value;
			}
		}

		[JsonProperty("object")]
		public string obj
		{
			[CompilerGenerated]
			get
			{
				return agsva79RHF0;
			}
			[CompilerGenerated]
			set
			{
				agsva79RHF0 = value;
			}
		}

		internal static bool R2JS9Tc1D2x1W2akGi2y()
		{
			return lvvLaUc1jHltLulI4Ek8 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetModelsAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<Model>> _003C_003Et__builder;

		public ModelsEndpoint _003C_003E4__this;

		private TaskAwaiter<GZCp9ud1wFBkHb5rfho> _003C_003Eu__1;

		internal static object UKfij2c1EGpED0D2CXnF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ModelsEndpoint modelsEndpoint = _003C_003E4__this;
			List<Model> result;
			try
			{
				TaskAwaiter<GZCp9ud1wFBkHb5rfho> awaiter;
				if (num != 0)
				{
					awaiter = modelsEndpoint.voeqvITQWy<GZCp9ud1wFBkHb5rfho>(null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (!YFoVr5c1GPoWiktohNGZ())
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
					_003C_003Eu__1 = default(TaskAwaiter<GZCp9ud1wFBkHb5rfho>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult().data;
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

		internal static bool YFoVr5c1GPoWiktohNGZ()
		{
			return UKfij2c1EGpED0D2CXnF == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRetrieveModelDetailsAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Model> _003C_003Et__builder;

		public ModelsEndpoint _003C_003E4__this;

		public string id;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object Kk8C2Cc11OWX1HVBCxSp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ModelsEndpoint modelsEndpoint = _003C_003E4__this;
			Model result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = modelsEndpoint.bZVqtfnqdY(modelsEndpoint.Url + "/" + id).GetAwaiter();
					int num2 = 0;
					if (Kk8C2Cc11OWX1HVBCxSp != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
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
					_003C_003Eu__1 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = JsonConvert.DeserializeObject<Model>(awaiter.GetResult());
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

		internal static bool b52HRtc1KxFiOcrIRv0u()
		{
			return Kk8C2Cc11OWX1HVBCxSp == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRetrieveModelDetailsAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Model> _003C_003Et__builder;

		public ModelsEndpoint _003C_003E4__this;

		public string id;

		private TaskAwaiter<Model> _003C_003Eu__1;

		private static object YIcvSLc1vLpIwESlKGdl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ModelsEndpoint modelsEndpoint = _003C_003E4__this;
			Model result;
			try
			{
				TaskAwaiter<Model> awaiter;
				if (num != 0)
				{
					awaiter = modelsEndpoint.RetrieveModelDetailsAsync(id).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<Model>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!usWRkZc1do3Oif9IGDCy())
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

		internal static bool usWRkZc1do3Oif9IGDCy()
		{
			return YIcvSLc1vLpIwESlKGdl == null;
		}
	}

	internal static ModelsEndpoint TYESa1kouA6uKGtbrAw;

	protected override string Endpoint => "models";

	internal ModelsEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CRetrieveModelDetailsAsync_003Ed__3))]
	public Task<Model> RetrieveModelDetailsAsync(string id)
	{
		_003CRetrieveModelDetailsAsync_003Ed__3 stateMachine = default(_003CRetrieveModelDetailsAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Model>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.id = id;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetModelsAsync_003Ed__4))]
	public Task<List<Model>> GetModelsAsync()
	{
		_003CGetModelsAsync_003Ed__4 stateMachine = default(_003CGetModelsAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<Model>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRetrieveModelDetailsAsync_003Ed__5))]
	[Obsolete("Use the overload without the APIAuthentication parameter instead, as custom auth is no longer used.", false)]
	public Task<Model> RetrieveModelDetailsAsync(string id, APIAuthentication auth = null)
	{
		_003CRetrieveModelDetailsAsync_003Ed__5 stateMachine = default(_003CRetrieveModelDetailsAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Model>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.id = id;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool T71mNVkfliYhdH22hpg()
	{
		return TYESa1kouA6uKGtbrAw == null;
	}
}
