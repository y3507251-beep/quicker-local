using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Api;
using Cuiliang.AliyunOssSdk.Api.Bucket.Get;
using Cuiliang.AliyunOssSdk.Api.Bucket.List;
using Cuiliang.AliyunOssSdk.Api.Object.Append;
using Cuiliang.AliyunOssSdk.Api.Object.Copy;
using Cuiliang.AliyunOssSdk.Api.Object.Delete;
using Cuiliang.AliyunOssSdk.Api.Object.DeleteMultiple;
using Cuiliang.AliyunOssSdk.Api.Object.Get;
using Cuiliang.AliyunOssSdk.Api.Object.GetMeta;
using Cuiliang.AliyunOssSdk.Api.Object.Head;
using Cuiliang.AliyunOssSdk.Api.Object.Put;
using Cuiliang.AliyunOssSdk.Entites;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;
using Cuiliang.AliyunOssSdk.Utility.Authentication;
using log4net;

namespace Cuiliang.AliyunOssSdk;

public class OssClient
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAppendObject_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<AppentObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public long nextAppendPosition;

		public RequestContent file;

		private TaskAwaiter<OssResult<AppentObjectResult>> _003C_003Eu__1;

		private static object h75Ltxcenf5QIqSgdR8C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<AppentObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<AppentObjectResult>> awaiter;
				if (num != 0)
				{
					awaiter = new AppendObjectCommand(ossClient.Ub8SDBwWWp, bucket, key, nextAppendPosition, file).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					if (h75Ltxcenf5QIqSgdR8C != null)
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<AppentObjectResult>>);
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

		internal static bool CBopH0ceeJEXqJ2CF7QU()
		{
			return h75Ltxcenf5QIqSgdR8C == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCopyObjectAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<CopyObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo targetBucket;

		public string targetKey;

		public BucketInfo bucket;

		public string srcKey;

		public IDictionary<string, string> extraHeaders;

		private TaskAwaiter<OssResult<CopyObjectResult>> _003C_003Eu__1;

		internal static object DeCNemceDP8Xasd22WmU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<CopyObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<CopyObjectResult>> awaiter;
				if (num != 0)
				{
					awaiter = new CopyObjectCommand(ossClient.Ub8SDBwWWp, targetBucket, targetKey, bucket, srcKey, extraHeaders).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<CopyObjectResult>>);
					int num2 = 0;
					if (!v8ksHMce3Zp5udjiB86d())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
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

		internal static bool v8ksHMce3Zp5udjiB86d()
		{
			return DeCNemceDP8Xasd22WmU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteMultipleObjectsAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<DeleteMultipleObjectsResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public IList<string> keys;

		public bool quiet;

		private TaskAwaiter<OssResult<DeleteMultipleObjectsResult>> _003C_003Eu__1;

		private static object kxnLkvceG3RcdQM8Q7OM;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<DeleteMultipleObjectsResult> result;
			try
			{
				TaskAwaiter<OssResult<DeleteMultipleObjectsResult>> awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (kxnLkvceG3RcdQM8Q7OM != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = new DeleteMultipleObjectsCommand(ossClient.Ub8SDBwWWp, bucket, keys, quiet).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<DeleteMultipleObjectsResult>>);
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

		internal static bool bQq2G5ce0cu9uv9bwyLP()
		{
			return kxnLkvceG3RcdQM8Q7OM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteObjectAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<DeleteObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		private TaskAwaiter<OssResult<DeleteObjectResult>> _003C_003Eu__1;

		internal static object SH6RFHceKYwbyiwiQaOT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<DeleteObjectResult> result2;
			try
			{
				TaskAwaiter<OssResult<DeleteObjectResult>> awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (SH6RFHceKYwbyiwiQaOT != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = new DeleteObjectCommand(ossClient.Ub8SDBwWWp, bucket, key).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<DeleteObjectResult>>);
					num = -1;
					_003C_003E1__state = -1;
				}
				OssResult<DeleteObjectResult> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					YH6SdjNUBI.Error("Failed in OssClient.PutObjectAsync(). \nBucket: " + bucket.BucketName + "\nPath: " + key);
				}
				result2 = result;
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

		internal static bool M6q2M4ceB8dMf8pQRLcw()
		{
			return SH6RFHceKYwbyiwiQaOT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetBucketAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<GetBucketResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucketInfo;

		public string prefix;

		public string marker;

		public int maxKeys;

		public string delimiter;

		public string encodingType;

		private TaskAwaiter<OssResult<GetBucketResult>> _003C_003Eu__1;

		internal static object bw6pQacedgEWySSBjL5C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<GetBucketResult> result2;
			try
			{
				TaskAwaiter<OssResult<GetBucketResult>> awaiter;
				if (num != 0)
				{
					awaiter = new GetBucketCommand(ossClient.Ub8SDBwWWp, bucketInfo, prefix, marker, maxKeys, delimiter, encodingType).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!qc4mgFceOWtkxC9t0AQg())
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<GetBucketResult>>);
					num = -1;
					_003C_003E1__state = -1;
				}
				OssResult<GetBucketResult> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					YH6SdjNUBI.Warn("Failed in OssClient.GetBucketAsync(). \nBucket: " + bucketInfo.BucketName + "\n");
				}
				result2 = result;
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

		internal static bool qc4mgFceOWtkxC9t0AQg()
		{
			return bw6pQacedgEWySSBjL5C == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetObjectAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<GetObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public GetObjectParams parameters;

		private TaskAwaiter<OssResult<GetObjectResult>> _003C_003Eu__1;

		internal static object VtixdZcekUFXZIukxwwY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<GetObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<GetObjectResult>> awaiter;
				if (num != 0)
				{
					awaiter = new GetObjectCommand(ossClient.Ub8SDBwWWp, bucket, key, parameters).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
					if (VtixdZcekUFXZIukxwwY == null)
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<GetObjectResult>>);
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

		internal static bool OJM6c8ceantrpxIVaXNO()
		{
			return VtixdZcekUFXZIukxwwY == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetObjectMetaAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<GetObjectMetaResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		private TaskAwaiter<OssResult<GetObjectMetaResult>> _003C_003Eu__1;

		private static object CPVL7FceNMIGUxT7GLCs;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<GetObjectMetaResult> result;
			try
			{
				TaskAwaiter<OssResult<GetObjectMetaResult>> awaiter;
				if (num != 0)
				{
					awaiter = new GetObjectMetaCommand(ossClient.Ub8SDBwWWp, bucket, key).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					if (CPVL7FceNMIGUxT7GLCs != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<GetObjectMetaResult>>);
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

		internal static bool vjRULIce9IJknaGtuLHJ()
		{
			return CPVL7FceNMIGUxT7GLCs == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHeadObjectAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<HeadObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public HeadObjectParams parameters;

		private TaskAwaiter<OssResult<HeadObjectResult>> _003C_003Eu__1;

		internal static object wMXGQRceuIhGWUGSKsgW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<HeadObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<HeadObjectResult>> awaiter;
				if (num != 0)
				{
					awaiter = new HeadObjectCommand(ossClient.Ub8SDBwWWp, bucket, key, parameters).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<HeadObjectResult>>);
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

		internal static bool cRuN7aceo1KhH1DCJESJ()
		{
			return wMXGQRceuIhGWUGSKsgW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListBucketsAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<ListBucketsResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public string region;

		private TaskAwaiter<OssResult<ListBucketsResult>> _003C_003Eu__1;

		internal static object QScykJcebIRjHHUcVPTV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<ListBucketsResult> result;
			try
			{
				TaskAwaiter<OssResult<ListBucketsResult>> awaiter;
				if (num != 0)
				{
					awaiter = new ListBucketsCommand(ossClient.Ub8SDBwWWp, region, new ListBucketsRequest()).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (!dF43evceqghtIIwXFOrP())
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<ListBucketsResult>>);
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

		internal static bool dF43evceqghtIIwXFOrP()
		{
			return QScykJcebIRjHHUcVPTV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutObjectAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<PutObjectResult>> _003C_003Et__builder;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public RequestContent file;

		public IDictionary<string, string> extraHeaders;

		private TaskAwaiter<OssResult<PutObjectResult>> _003C_003Eu__1;

		private static object GUIehZcelsgp7RwRjnNm;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<PutObjectResult> result2;
			try
			{
				TaskAwaiter<OssResult<PutObjectResult>> awaiter;
				if (num != 0)
				{
					awaiter = new PutObjectCommand(ossClient.Ub8SDBwWWp, bucket, key, file, extraHeaders).ExecuteAsync(ossClient.FeRS5CvaY2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (GUIehZcelsgp7RwRjnNm != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<PutObjectResult>>);
					num = -1;
					_003C_003E1__state = -1;
				}
				OssResult<PutObjectResult> result = awaiter.GetResult();
				if (!result.IsSuccess)
				{
					YH6SdjNUBI.Error("Failed in OssClient.PutObjectAsync(). \nBucket: " + bucket.BucketName + "\nPath: " + key);
				}
				result2 = result;
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

		internal static bool WQfcbMceZOB8b57ef0EW()
		{
			return GUIehZcelsgp7RwRjnNm == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutObjectAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<PutObjectResult>> _003C_003Et__builder;

		public string content;

		public string mimeType;

		public ObjectMetadata meta;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public IDictionary<string, string> extraHeaders;

		private TaskAwaiter<OssResult<PutObjectResult>> _003C_003Eu__1;

		private static object F4b4aTce8h41Ko1aHKU7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<PutObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<PutObjectResult>> awaiter;
				if (num != 0)
				{
					RequestContent file = new RequestContent
					{
						ContentType = RequestContentType.String,
						StringContent = content,
						MimeType = mimeType,
						Metadata = meta
					};
					awaiter = ossClient.PutObjectAsync(bucket, key, file, extraHeaders).GetAwaiter();
					int num2 = 0;
					if (F4b4aTce8h41Ko1aHKU7 != null)
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<PutObjectResult>>);
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

		internal static bool dSSW5kceRSyDgohFtVIB()
		{
			return F4b4aTce8h41Ko1aHKU7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutObjectAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<PutObjectResult>> _003C_003Et__builder;

		public Stream content;

		public string mimeType;

		public ObjectMetadata meta;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public IDictionary<string, string> extraHeaders;

		private TaskAwaiter<OssResult<PutObjectResult>> _003C_003Eu__1;

		internal static object txAA8lceMQAPcPh04d7e;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<PutObjectResult> result;
			try
			{
				TaskAwaiter<OssResult<PutObjectResult>> awaiter;
				if (num != 0)
				{
					RequestContent file = new RequestContent
					{
						ContentType = RequestContentType.Stream,
						StreamContent = content,
						MimeType = mimeType,
						Metadata = meta
					};
					if (dpPoUlceUjC4YCeujnv9())
					{
						switch (0)
						{
						}
					}
					awaiter = ossClient.PutObjectAsync(bucket, key, file, extraHeaders).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<PutObjectResult>>);
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

		internal static bool dpPoUlceUjC4YCeujnv9()
		{
			return txAA8lceMQAPcPh04d7e == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutObjectByFileNameAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<PutObjectResult>> _003C_003Et__builder;

		public string filePathName;

		public ObjectMetadata meta;

		public OssClient _003C_003E4__this;

		public BucketInfo bucket;

		public string key;

		public IDictionary<string, string> extraHeaders;

		private FileStream _003Cstream_003E5__2;

		private TaskAwaiter<OssResult<PutObjectResult>> _003C_003Eu__1;

		internal static object VFT8KKceIcpTsiDHlX3M;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssClient ossClient = _003C_003E4__this;
			OssResult<PutObjectResult> result;
			try
			{
				if (num != 0)
				{
					_003Cstream_003E5__2 = File.OpenRead(filePathName);
				}
				try
				{
					TaskAwaiter<OssResult<PutObjectResult>> awaiter;
					if (num != 0)
					{
						int num2 = 0;
						if (VFT8KKceIcpTsiDHlX3M != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						RequestContent file = new RequestContent
						{
							ContentType = RequestContentType.Stream,
							StreamContent = _003Cstream_003E5__2,
							MimeType = MimeHelper.GetMime(filePathName),
							Metadata = meta
						};
						awaiter = ossClient.PutObjectAsync(bucket, key, file, extraHeaders).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<OssResult<PutObjectResult>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && _003Cstream_003E5__2 != null)
					{
						((IDisposable)_003Cstream_003E5__2).Dispose();
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

		internal static bool CVhJWuce6yejaX4LK7yW()
		{
			return VFT8KKceIcpTsiDHlX3M == null;
		}
	}

	private readonly HttpClient FeRS5CvaY2;

	private readonly RequestContext Ub8SDBwWWp;

	private static readonly ILog YH6SdjNUBI;

	internal static OssClient B4Ud2bndTg2bC8Aei4y;

	public OssClient(HttpClient client, RequestContext requestContext)
	{
		FeRS5CvaY2 = client;
		Ub8SDBwWWp = requestContext;
	}

	[AsyncStateMachine(typeof(_003CListBucketsAsync_003Ed__4))]
	public Task<OssResult<ListBucketsResult>> ListBucketsAsync(string region)
	{
		_003CListBucketsAsync_003Ed__4 stateMachine = default(_003CListBucketsAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<ListBucketsResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.region = region;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetBucketAsync_003Ed__5))]
	public Task<OssResult<GetBucketResult>> GetBucketAsync(BucketInfo bucketInfo, string prefix, string marker, int maxKeys = 100, string delimiter = "", string encodingType = "")
	{
		_003CGetBucketAsync_003Ed__5 stateMachine = default(_003CGetBucketAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<GetBucketResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucketInfo = bucketInfo;
		stateMachine.prefix = prefix;
		stateMachine.marker = marker;
		stateMachine.maxKeys = maxKeys;
		stateMachine.delimiter = delimiter;
		stateMachine.encodingType = encodingType;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutObjectAsync_003Ed__6))]
	public Task<OssResult<PutObjectResult>> PutObjectAsync(BucketInfo bucket, string key, RequestContent file, IDictionary<string, string> extraHeaders = null)
	{
		_003CPutObjectAsync_003Ed__6 stateMachine = default(_003CPutObjectAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<PutObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.file = file;
		stateMachine.extraHeaders = extraHeaders;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutObjectAsync_003Ed__7))]
	public Task<OssResult<PutObjectResult>> PutObjectAsync(BucketInfo bucket, string key, string content, string mimeType = "text/plain", ObjectMetadata meta = null, IDictionary<string, string> extraHeaders = null)
	{
		_003CPutObjectAsync_003Ed__7 stateMachine = default(_003CPutObjectAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<PutObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.content = content;
		stateMachine.mimeType = mimeType;
		stateMachine.meta = meta;
		stateMachine.extraHeaders = extraHeaders;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutObjectByFileNameAsync_003Ed__8))]
	public Task<OssResult<PutObjectResult>> PutObjectByFileNameAsync(BucketInfo bucket, string key, string filePathName, ObjectMetadata meta = null, IDictionary<string, string> extraHeaders = null)
	{
		_003CPutObjectByFileNameAsync_003Ed__8 stateMachine = default(_003CPutObjectByFileNameAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<PutObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.filePathName = filePathName;
		stateMachine.meta = meta;
		stateMachine.extraHeaders = extraHeaders;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutObjectAsync_003Ed__9))]
	public Task<OssResult<PutObjectResult>> PutObjectAsync(BucketInfo bucket, string key, Stream content, string mimeType = "application/octet-stream", ObjectMetadata meta = null, IDictionary<string, string> extraHeaders = null)
	{
		_003CPutObjectAsync_003Ed__9 stateMachine = default(_003CPutObjectAsync_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<PutObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.content = content;
		stateMachine.mimeType = mimeType;
		stateMachine.meta = meta;
		stateMachine.extraHeaders = extraHeaders;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCopyObjectAsync_003Ed__10))]
	public Task<OssResult<CopyObjectResult>> CopyObjectAsync(BucketInfo bucket, string srcKey, BucketInfo targetBucket, string targetKey, IDictionary<string, string> extraHeaders = null)
	{
		_003CCopyObjectAsync_003Ed__10 stateMachine = default(_003CCopyObjectAsync_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<CopyObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.srcKey = srcKey;
		stateMachine.targetBucket = targetBucket;
		stateMachine.targetKey = targetKey;
		stateMachine.extraHeaders = extraHeaders;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetObjectAsync_003Ed__11))]
	public Task<OssResult<GetObjectResult>> GetObjectAsync(BucketInfo bucket, string key, GetObjectParams parameters = null)
	{
		_003CGetObjectAsync_003Ed__11 stateMachine = default(_003CGetObjectAsync_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<GetObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.parameters = parameters;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CAppendObject_003Ed__12))]
	public Task<OssResult<AppentObjectResult>> AppendObject(BucketInfo bucket, string key, long nextAppendPosition, RequestContent file)
	{
		_003CAppendObject_003Ed__12 stateMachine = default(_003CAppendObject_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<AppentObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.nextAppendPosition = nextAppendPosition;
		stateMachine.file = file;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDeleteObjectAsync_003Ed__13))]
	public Task<OssResult<DeleteObjectResult>> DeleteObjectAsync(BucketInfo bucket, string key)
	{
		_003CDeleteObjectAsync_003Ed__13 stateMachine = default(_003CDeleteObjectAsync_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<DeleteObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDeleteMultipleObjectsAsync_003Ed__14))]
	public Task<OssResult<DeleteMultipleObjectsResult>> DeleteMultipleObjectsAsync(BucketInfo bucket, IList<string> keys, bool quiet = false)
	{
		_003CDeleteMultipleObjectsAsync_003Ed__14 stateMachine = default(_003CDeleteMultipleObjectsAsync_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<DeleteMultipleObjectsResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.keys = keys;
		stateMachine.quiet = quiet;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHeadObjectAsync_003Ed__15))]
	public Task<OssResult<HeadObjectResult>> HeadObjectAsync(BucketInfo bucket, string key, HeadObjectParams parameters)
	{
		_003CHeadObjectAsync_003Ed__15 stateMachine = default(_003CHeadObjectAsync_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<HeadObjectResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine.parameters = parameters;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetObjectMetaAsync_003Ed__16))]
	public Task<OssResult<GetObjectMetaResult>> GetObjectMetaAsync(BucketInfo bucket, string key)
	{
		_003CGetObjectMetaAsync_003Ed__16 stateMachine = default(_003CGetObjectMetaAsync_003Ed__16);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<GetObjectMetaResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bucket = bucket;
		stateMachine.key = key;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public string GetFileDownloadLink(BucketInfo bucket, string storeKey, int expireSeconds, string imgStyle = null)
	{
		long num = (DateTime.UtcNow.AddSeconds(expireSeconds).Ticks - 621355968000000000L) / 10000000L;
		string text = $"GET\n\n\n{num}\n/{bucket.BucketName}/{storeKey}";
		int num2 = 0;
		if (!EQlhk7nOVofk5y8xnLK())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			if (!string.IsNullOrEmpty(imgStyle))
			{
				text = text + "?x-oss-process=style/" + imgStyle;
			}
			string value = ServiceSignature.Create().ComputeSignature(Ub8SDBwWWp.OssCredential.AccessKeySecret, text);
			string text2 = (string.IsNullOrEmpty(imgStyle) ? string.Empty : ("x-oss-process=style/" + imgStyle + "&"));
			return $"{bucket.BucketUri}{storeKey}?{text2}OSSAccessKeyId={Ub8SDBwWWp.OssCredential.AccessKeyId}&Expires={num}&Signature={WebUtility.UrlEncode(value)}";
		}
		}
	}

	public string ComputePostSignature(string policy)
	{
		return ServiceSignature.Create().ComputeSignature(Ub8SDBwWWp.OssCredential.AccessKeySecret, policy);
	}

	static OssClient()
	{
		YH6SdjNUBI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool EQlhk7nOVofk5y8xnLK()
	{
		return B4Ud2bndTg2bC8Aei4y == null;
	}
}
