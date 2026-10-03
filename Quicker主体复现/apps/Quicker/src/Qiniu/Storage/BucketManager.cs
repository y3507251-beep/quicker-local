using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using GFy17Dq3Ka8YBV2L15c;
using Qiniu.Http;
using Qiniu.Util;

namespace Qiniu.Storage;

public class BucketManager
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public Dictionary<string, string> cTHv7Y9uf9v;

		private static _003C_003Ec__DisplayClass36_0 Jk3X9wcdot1TAprrJ07b;

		internal string rCxv7eMXDNw(string k)
		{
			return k + "=" + cTHv7Y9uf9v[k];
		}

		internal static void LXAGbAcdqYkJVi6lapij()
		{
		}

		internal static bool uNZJZIcdfVNFJvV8pT12()
		{
			return Jk3X9wcdot1TAprrJ07b == null;
		}
	}

	private Mac Af2eMpY3F1;

	private Auth RQOeAMUylV;

	private HttpManager IHHeOJ19i4;

	private Config K8aeFQ4dOJ;

	internal static BucketManager iXugBHuQXCiQVLnXQ8G;

	public BucketManager(Mac mac, Config config, AuthOptions authOptions = null)
	{
		Af2eMpY3F1 = mac;
		RQOeAMUylV = new Auth(mac, authOptions);
		IHHeOJ19i4 = new HttpManager(false);
		K8aeFQ4dOJ = config;
	}

	public StatResult Stat(string bucket, string key)
	{
		StatResult statResult = new StatResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{StatOp(bucket, key)}";
			HttpResult hr = IHHeOJ19i4.Get(url, null, RQOeAMUylV);
			statResult.Shadow(hr);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [stat] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
				{
					stringBuilder.Append(ex.Message + " ");
				}
				stringBuilder.AppendLine();
				statResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				statResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				statResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				statResult.RefText += stringBuilder.ToString();
				break;
			}
			}
		}
		return statResult;
	}

	public BucketsResult Buckets(bool shared)
	{
		BucketsResult bucketsResult = new BucketsResult();
		try
		{
			string arg = (K8aeFQ4dOJ.UseHttps ? "https://" : "http://");
			int num = 0;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				string arg2 = $"{arg}{Config.DefaultRsHost}";
				string arg3 = "false";
				if (shared)
				{
					arg3 = "true";
				}
				string url = $"{arg2}/buckets?shared={arg3}";
				HttpResult hr = IHHeOJ19i4.Get(url, null, RQOeAMUylV);
				bucketsResult.Shadow(hr);
				break;
			}
			}
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [buckets] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			bucketsResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			bucketsResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			bucketsResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			bucketsResult.RefText += stringBuilder.ToString();
			int num3 = 0;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		return bucketsResult;
	}

	public HttpResult Delete(string bucket, string key)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{DeleteOp(bucket, key)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [delete] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			Exception ex = lkv3bMqsFwsT98BDoV;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				switch (0)
				{
				}
			}
			while (ex != null)
			{
				stringBuilder.Append(ex.Message + " ");
				ex = ex.InnerException;
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			httpResult.RefText += stringBuilder.ToString();
		}
		return httpResult;
	}

	public HttpResult Copy(string srcBucket, string srcKey, string dstBucket, string dstKey)
	{
		return Copy(srcBucket, srcKey, dstBucket, dstKey, false);
	}

	public HttpResult Copy(string srcBucket, string srcKey, string dstBucket, string dstKey, bool force)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, srcBucket)}{CopyOp(srcBucket, srcKey, dstBucket, dstKey, force)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				switch (0)
				{
				}
			}
			stringBuilder.AppendFormat("[{0}] [copy] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			httpResult.RefText += stringBuilder.ToString();
		}
		return httpResult;
	}

	public HttpResult Move(string srcBucket, string srcKey, string dstBucket, string dstKey)
	{
		return Move(srcBucket, srcKey, dstBucket, dstKey, false);
	}

	public HttpResult Move(string srcBucket, string srcKey, string dstBucket, string dstKey, bool force)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, srcBucket)}{MoveOp(srcBucket, srcKey, dstBucket, dstKey, force)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [move] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder.ToString();
				break;
			}
		}
		return httpResult;
	}

	public HttpResult ChangeMime(string bucket, string key, string mimeType)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{ChangeMimeOp(bucket, key, mimeType)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [chgm] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			Exception ex = lkv3bMqsFwsT98BDoV;
			int num = 0;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			while (ex != null)
			{
				stringBuilder.Append(ex.Message + " ");
				ex = ex.InnerException;
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			httpResult.RefText += stringBuilder.ToString();
		}
		return httpResult;
	}

	public HttpResult ChangeType(string bucket, string key, int fileType)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{ChangeTypeOp(bucket, key, fileType)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [chtype] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder.ToString();
				break;
			}
		}
		return httpResult;
	}

	public HttpResult RestoreAr(string bucket, string key, int freezeAfterDays)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{RestoreArOp(bucket, key, freezeAfterDays)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [restore] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder.ToString();
				break;
			}
		}
		return httpResult;
	}

	private BatchResult RdeeTqqF0P(string string_0)
	{
		BatchResult batchResult = new BatchResult();
		try
		{
			string arg = (K8aeFQ4dOJ.UseHttps ? "https://" : "http://");
			string url = $"{arg}{Config.DefaultRsHost}" + "/batch";
			HttpResult hr = IHHeOJ19i4.PostForm(url, null, string_0, RQOeAMUylV);
			batchResult.Shadow(hr);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [batch] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			batchResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			batchResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			batchResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			batchResult.RefText += stringBuilder.ToString();
			int num = 0;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return batchResult;
	}

	public BatchResult Batch(IList<string> ops)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("op={0}", ops[0]);
		for (int i = 1; i < ops.Count; i++)
		{
			stringBuilder.AppendFormat("&op={0}", ops[i]);
		}
		return RdeeTqqF0P(stringBuilder.ToString());
	}

	public FetchResult Fetch(string resUrl, string bucket, string key)
	{
		FetchResult fetchResult = new FetchResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.IovipHost(Af2eMpY3F1.AccessKey, bucket)}{FetchOp(resUrl, bucket, key)}";
			HttpResult hr = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
			fetchResult.Shadow(hr);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [fetch] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			fetchResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			fetchResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			fetchResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				switch (0)
				{
				}
			}
			fetchResult.RefText += stringBuilder.ToString();
		}
		return fetchResult;
	}

	public HttpResult Prefetch(string bucket, string key)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = K8aeFQ4dOJ.IovipHost(Af2eMpY3F1.AccessKey, bucket) + PrefetchOp(bucket, key);
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [prefetch] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder.ToString();
				break;
			}
		}
		return httpResult;
	}

	public DomainsResult Domains(string bucket)
	{
		DomainsResult domainsResult = new DomainsResult();
		try
		{
			string arg = (K8aeFQ4dOJ.UseHttps ? "https://" : "http://");
			string arg2 = $"{arg}{Config.DefaultApiHost}";
			string url = string.Format("{0}{1}", arg2, "/v6/domain/list");
			string data = $"tbl={bucket}";
			HttpResult hr = IHHeOJ19i4.PostForm(url, null, data, RQOeAMUylV);
			domainsResult.Shadow(hr);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [domains] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			domainsResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			domainsResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			domainsResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				domainsResult.RefText += stringBuilder.ToString();
				break;
			}
		}
		return domainsResult;
	}

	public ListResult ListFiles(string bucket, string prefix, string marker, int limit, string delimiter)
	{
		ListResult listResult = new ListResult();
		try
		{
			StringBuilder stringBuilder = new StringBuilder("/list?bucket=" + bucket);
			if (!string.IsNullOrEmpty(marker))
			{
				stringBuilder.Append("&marker=" + marker);
			}
			if (!string.IsNullOrEmpty(prefix))
			{
				stringBuilder.Append("&prefix=" + prefix);
			}
			if (!string.IsNullOrEmpty(delimiter))
			{
				stringBuilder.Append("&delimiter=" + delimiter);
			}
			if (limit <= 1000 && limit >= 1)
			{
				stringBuilder.Append("&limit=" + limit);
			}
			else
			{
				stringBuilder.Append("&limit=1000");
			}
			string url = $"{K8aeFQ4dOJ.RsfHost(Af2eMpY3F1.AccessKey, bucket)}{stringBuilder.ToString()}";
			HttpResult hr = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
			listResult.Shadow(hr);
			int num = 0;
			if (iXugBHuQXCiQVLnXQ8G != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendFormat("[{0}] [listFiles] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num4 = default(int);
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder2.Append(ex.Message + " ");
				int num3 = 0;
				if (iXugBHuQXCiQVLnXQ8G != null)
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			stringBuilder2.AppendLine();
			listResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			listResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			listResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			listResult.RefText += stringBuilder2.ToString();
		}
		return listResult;
	}

	public HttpResult DeleteAfterDays(string bucket, string key, int deleteAfterDays)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{DeleteAfterDaysOp(bucket, key, deleteAfterDays)}";
			httpResult = IHHeOJ19i4.Post(url, null, RQOeAMUylV);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [deleteAfterDays] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num = 0;
			if (!r2W7TSuFRLplUMxhWYQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
				{
					stringBuilder.Append(ex.Message + " ");
				}
				stringBuilder.AppendLine();
				httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder.ToString();
				break;
			}
			}
		}
		return httpResult;
	}

	public HttpResult SetObjectLifecycle(string bucket, string key, int toIaAfterDays = 0, int toArchiveAfterDays = 0, int toDeepArchiveAfterDays = 0, int deleteAfterDays = 0)
	{
		return SetObjectLifecycle(bucket, key, null, toIaAfterDays, toArchiveAfterDays, toDeepArchiveAfterDays, deleteAfterDays);
	}

	public HttpResult SetObjectLifecycle(string bucket, string key, Dictionary<string, string> cond = null, int toIaAfterDays = 0, int toArchiveAfterDays = 0, int toDeepArchiveAfterDays = 0, int deleteAfterDays = 0)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string url = $"{K8aeFQ4dOJ.RsHost(Af2eMpY3F1.AccessKey, bucket)}{SetObjectLifecycleOp(bucket, key, cond, toIaAfterDays, toArchiveAfterDays, toDeepArchiveAfterDays, deleteAfterDays)}";
			StringDictionary headers = new StringDictionary { 
			{
				"Content-Type",
				ContentType.WWW_FORM_URLENC
			} };
			string token = RQOeAMUylV.CreateManageTokenV2("POST", url, headers);
			httpResult = IHHeOJ19i4.Post(url, headers, token);
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [setObjectLifecycle] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder.Append(ex.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			httpResult.RefText += stringBuilder.ToString();
		}
		return httpResult;
	}

	public string StatOp(string bucket, string key)
	{
		return $"/stat/{Base64.UrlSafeBase64Encode(bucket, key)}";
	}

	public string DeleteOp(string bucket, string key)
	{
		return $"/delete/{Base64.UrlSafeBase64Encode(bucket, key)}";
	}

	public string CopyOp(string srcBucket, string srcKey, string dstBucket, string dstKey)
	{
		return CopyOp(srcBucket, srcKey, dstBucket, dstKey, false);
	}

	public string CopyOp(string srcBucket, string srcKey, string dstBucket, string dstKey, bool force)
	{
		string arg = (force ? "force/true" : "force/false");
		return $"/copy/{Base64.UrlSafeBase64Encode(srcBucket, srcKey)}/{Base64.UrlSafeBase64Encode(dstBucket, dstKey)}/{arg}";
	}

	public string MoveOp(string srcBucket, string srcKey, string dstBucket, string dstKey)
	{
		return MoveOp(srcBucket, srcKey, dstBucket, dstKey, false);
	}

	public string MoveOp(string srcBucket, string srcKey, string dstBucket, string dstKey, bool force)
	{
		string arg = (force ? "force/true" : "force/false");
		return $"/move/{Base64.UrlSafeBase64Encode(srcBucket, srcKey)}/{Base64.UrlSafeBase64Encode(dstBucket, dstKey)}/{arg}";
	}

	public string ChangeMimeOp(string bucket, string key, string mimeType)
	{
		return $"/chgm/{Base64.UrlSafeBase64Encode(bucket, key)}/mime/{Base64.UrlSafeBase64Encode(mimeType)}";
	}

	public string ChangeTypeOp(string bucket, string key, int fileType)
	{
		return $"/chtype/{Base64.UrlSafeBase64Encode(bucket, key)}/type/{fileType}";
	}

	public string RestoreArOp(string bucket, string key, int freezeAfterDays)
	{
		return $"/restoreAr/{Base64.UrlSafeBase64Encode(bucket, key)}/freezeAfterDays/{freezeAfterDays}";
	}

	public string FetchOp(string url, string bucket, string key)
	{
		string text = null;
		text = ((key != null) ? Base64.UrlSafeBase64Encode(bucket, key) : Base64.UrlSafeBase64Encode(bucket));
		return $"/fetch/{Base64.UrlSafeBase64Encode(url)}/to/{text}";
	}

	public string PrefetchOp(string bucket, string key)
	{
		return $"/prefetch/{Base64.UrlSafeBase64Encode(bucket, key)}";
	}

	public string DeleteAfterDaysOp(string bucket, string key, int deleteAfterDays)
	{
		return $"/deleteAfterDays/{Base64.UrlSafeBase64Encode(bucket, key)}/{deleteAfterDays}";
	}

	public string SetObjectLifecycleOp(string bucket, string key, Dictionary<string, string> cond = null, int toIaAfterDays = 0, int toArchiveAfterDays = 0, int toDeepArchiveAfterDays = 0, int deleteAfterDays = 0)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.cTHv7Y9uf9v = cond;
		string text = Base64.UrlSafeBase64Encode(bucket, key);
		string text2 = $"/lifecycle/{text}/toIAAfterDays/{toIaAfterDays}/toArchiveAfterDays/{toArchiveAfterDays}/toDeepArchiveAfterDays/{toDeepArchiveAfterDays}/deleteAfterDays/{deleteAfterDays}";
		if (_003C_003Ec__DisplayClass36_.cTHv7Y9uf9v != null)
		{
			string text3 = string.Join("&", _003C_003Ec__DisplayClass36_.cTHv7Y9uf9v.Keys.Select(_003C_003Ec__DisplayClass36_.rCxv7eMXDNw));
			text2 = text2 + "/cond/" + Base64.UrlSafeBase64Encode(text3);
		}
		return text2;
	}

	internal static bool r2W7TSuFRLplUMxhWYQ()
	{
		return iXugBHuQXCiQVLnXQ8G == null;
	}
}
