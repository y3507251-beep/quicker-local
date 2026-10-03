using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using GFy17Dq3Ka8YBV2L15c;
using Qiniu.Http;
using Qiniu.Util;

namespace Qiniu.Storage;

public class FormUploader
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static UploadProgressHandler hauv7Inscww;

		public static UploadController TRWv7WqKsLe;
	}

	private Config vXEYvFUPeH;

	private HttpManager iMiYSXRNey;

	internal static FormUploader Vep8dJutvQJja9Gtu76;

	public FormUploader(Config config)
	{
		vXEYvFUPeH = config;
		iMiYSXRNey = new HttpManager(false);
	}

	public HttpResult UploadFile(string localFile, string key, string token, PutExtra extra)
	{
		try
		{
			FileStream stream = new FileStream(localFile, FileMode.Open);
			return UploadStream(stream, key, token, extra);
		}
		catch (Exception ex)
		{
			HttpResult invalidFile = HttpResult.InvalidFile;
			invalidFile.RefText = ex.Message;
			return invalidFile;
		}
	}

	public HttpResult UploadData(byte[] data, string key, string token, PutExtra extra)
	{
		MemoryStream stream = new MemoryStream(data);
		return UploadStream(stream, key, token, extra);
	}

	public HttpResult UploadStream(Stream stream, string key, string token, PutExtra putExtra)
	{
		if (putExtra == null)
		{
			putExtra = new PutExtra();
			int num = 0;
			if (!k0GW0SuSMtSNlyboEDZ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (string.IsNullOrEmpty(putExtra.MimeType))
		{
			putExtra.MimeType = "application/octet-stream";
		}
		if (putExtra.ProgressHandler == null)
		{
			putExtra.ProgressHandler = _003C_003EO.hauv7Inscww ?? (_003C_003EO.hauv7Inscww = DefaultUploadProgressHandler);
		}
		if (putExtra.UploadController == null)
		{
			putExtra.UploadController = _003C_003EO.TRWv7WqKsLe ?? (_003C_003EO.TRWv7WqKsLe = DefaultUploadController);
		}
		string arg = key;
		if (string.IsNullOrEmpty(key))
		{
			arg = "fname_temp";
		}
		HttpResult httpResult = new HttpResult();
		using (stream)
		{
			try
			{
        byte[] array = default;
        MemoryStream memoryStream2 = default;
        byte[] bytes = default;
        StringBuilder stringBuilder2 = default;
				string text = HttpManager.CreateFormDataBoundary();
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("--" + text);
				if (key == null)
				{
					goto IL_00f6;
				}
				stringBuilder.AppendLine("Content-Disposition: form-data; name=\"key\"");
				goto IL_0344;
				IL_03c6:
				string bucketFromUpToken = default(string);
				if (bucketFromUpToken == null)
				{
					goto IL_04c1;
				}
				string accessKeyFromUpToken = default(string);
				string url = vXEYvFUPeH.UpHost(accessKeyFromUpToken, bucketFromUpToken);
				putExtra.ProgressHandler(stream.Length / 5L, stream.Length);
				MemoryStream memoryStream = default(MemoryStream);
				httpResult = iMiYSXRNey.PostMultipart(url, memoryStream.ToArray(), text, null);
				putExtra.ProgressHandler(stream.Length, stream.Length);
				if (httpResult.Code == 200)
				{
					httpResult.RefText += string.Format("[{0}] [FormUpload] Uploaded: #STREAM# ==> \"{1}\"\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), key);
				}
				else
				{
					httpResult.RefText += string.Format("[{0}] [FormUpload] Failed: code = {1}, text = {2}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), httpResult.Code, httpResult.Text);
				}
				memoryStream.Close();
				memoryStream2 = default(MemoryStream);
				memoryStream2.Close();
				goto end_IL_00ab;
				IL_0344:
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(key);
				int num3 = 4;
				if (Vep8dJutvQJja9Gtu76 == null)
				{
					goto IL_00e2;
				}
				goto IL_0325;
				IL_00e2:
				stringBuilder.AppendLine("--" + text);
				goto IL_00f6;
				IL_00f6:
				stringBuilder.AppendLine("Content-Disposition: form-data; name=\"token\"");
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(token);
				stringBuilder.AppendLine("--" + text);
				if (putExtra.Params != null && putExtra.Params.Count > 0)
				{
					foreach (KeyValuePair<string, string> item in putExtra.Params)
					{
						if (!item.Key.StartsWith("x:"))
						{
							continue;
						}
						stringBuilder.AppendFormat("Content-Disposition: form-data; name=\"{0}\"", item.Key);
						stringBuilder.AppendLine();
						stringBuilder.AppendLine();
						stringBuilder.AppendLine(item.Value);
						stringBuilder.AppendLine("--" + text);
						if (Vep8dJutvQJja9Gtu76 == null)
						{
							switch (0)
							{
							}
						}
					}
				}
				int count = 1048576;
				byte[] buffer = new byte[1048576];
				int num4 = 0;
				putExtra.ProgressHandler(0L, stream.Length);
				memoryStream2 = new MemoryStream();
				while ((num4 = stream.Read(buffer, 0, count)) != 0)
				{
					memoryStream2.Write(buffer, 0, num4);
				}
				uint num5 = CRC32.CheckSumBytes(memoryStream2.ToArray());
				stringBuilder.AppendLine("Content-Disposition: form-data; name=\"crc32\"");
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(num5.ToString());
				stringBuilder.AppendLine("--" + text);
				stringBuilder.AppendFormat("Content-Disposition: form-data; name=\"file\"; filename=\"{0}\"", arg);
				stringBuilder.AppendLine();
				stringBuilder.AppendFormat("Content-Type: {0}", putExtra.MimeType);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine();
				goto IL_02c4;
				IL_02c4:
				stringBuilder2 = new StringBuilder();
				num3 = 1;
				if (k0GW0SuSMtSNlyboEDZ())
				{
					goto IL_0325;
				}
				goto IL_036b;
				IL_0325:
				bytes = default(byte[]);
				array = default(byte[]);
				while (true)
				{
					switch (num3)
					{
					case 5:
						break;
					case 4:
						goto IL_02c4;
					case 1:
						stringBuilder2.AppendLine();
						stringBuilder2.AppendLine("--" + text + "--");
						bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
						array = memoryStream2.ToArray();
						num3 = 0;
						if (Vep8dJutvQJja9Gtu76 == null)
						{
							continue;
						}
						goto IL_036b;
					case 3:
						goto IL_0344;
					default:
						goto IL_036b;
					case 2:
						goto IL_03c6;
					}
					break;
				}
				goto IL_00e2;
				IL_036b:
				byte[] bytes2 = Encoding.UTF8.GetBytes(stringBuilder2.ToString());
				memoryStream = new MemoryStream();
				memoryStream.Write(bytes, 0, bytes.Length);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(bytes2, 0, bytes2.Length);
				accessKeyFromUpToken = UpToken.GetAccessKeyFromUpToken(token);
				bucketFromUpToken = UpToken.GetBucketFromUpToken(token);
				if (accessKeyFromUpToken != null)
				{
					goto IL_03c6;
				}
				goto IL_04c1;
				IL_04c1:
				return HttpResult.InvalidToken;
				end_IL_00ab:;
			}
			catch (Exception ex)
			{
				StringBuilder stringBuilder3 = new StringBuilder();
				stringBuilder3.AppendFormat("[{0}] [FormUpload] Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
				Exception ex2 = ex;
				int num7 = default(int);
				while (true)
				{
					int num6;
					if (ex2 != null)
					{
						stringBuilder3.Append(ex2.Message + " ");
						ex2 = ex2.InnerException;
						num6 = 0;
						if (Vep8dJutvQJja9Gtu76 == null)
						{
							continue;
						}
					}
					else
					{
						num6 = 0;
						if (Vep8dJutvQJja9Gtu76 != null)
						{
							num6 = num7;
						}
					}
					switch (num6)
					{
					case 1:
						continue;
					}
					stringBuilder3.AppendLine();
					if (ex is lkv3bMqsFwsT98BDoV0)
					{
						lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV = (lkv3bMqsFwsT98BDoV0)ex;
						httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
						httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
						httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
						httpResult.RefText += stringBuilder3.ToString();
					}
					else
					{
						httpResult.RefCode = 0;
						httpResult.RefText += stringBuilder3.ToString();
					}
					break;
				}
			}
		}
		return httpResult;
	}

	public static void DefaultUploadProgressHandler(long uploadedBytes, long totalBytes)
	{
	}

	public static UploadControllerAction DefaultUploadController()
	{
		return UploadControllerAction.Activated;
	}

	internal static bool k0GW0SuSMtSNlyboEDZ()
	{
		return Vep8dJutvQJja9Gtu76 == null;
	}
}
