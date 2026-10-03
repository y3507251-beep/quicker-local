using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using Qiniu.Util;

namespace Qiniu.Http;

public class HttpManager
{
	private bool FDPWdtRk1K;

	private string CSGWoaGFaF;

	internal static HttpManager AtFiPibySQwMdMW6psG;

	public HttpManager(bool allowAutoRedirect = false)
	{
		FDPWdtRk1K = allowAutoRedirect;
		CSGWoaGFaF = GetUserAgent();
	}

	public static string GetUserAgent()
	{
		string text = Environment.OSVersion.Platform.ToString() + "; " + Environment.OSVersion.Version;
		return string.Format("{0}/{1} ({2}; {3})", "QiniuCSharpSDK", "8.3.0", "UNKNOWN", text);
	}

	public void SetUserAgent(string userAgent)
	{
		if (!string.IsNullOrEmpty(userAgent))
		{
			CSGWoaGFaF = userAgent;
		}
	}

	public static string CreateFormDataBoundary()
	{
		string str = DateTime.UtcNow.Ticks.ToString();
		return string.Format("-------{0}Boundary{1}", "QiniuCSharpSDK", Hashing.CalcMD5X(str));
	}

	public HttpResult Get(string url, string token, bool binaryMode = false)
	{
		return Get(url, null, token, binaryMode);
	}

	public HttpResult Get(string url, StringDictionary headers, Auth auth, bool binaryMode = false)
	{
		if (headers == null)
		{
			headers = new StringDictionary { 
			{
				"Content-Type",
				ContentType.WWW_FORM_URLENC
			} };
		}
		if (!headers.ContainsKey("Content-Type"))
		{
			headers["Content-Type"] = ContentType.WWW_FORM_URLENC;
		}
		qp7WDKEIWM(ref headers, auth);
		string token = auth.CreateManageTokenV2("GET", url, headers);
		return Get(url, headers, token, binaryMode);
	}

	public HttpResult Get(string url, StringDictionary headers, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "GET";
			if (headers != null)
			{
				foreach (string key in headers.Keys)
				{
					if (!WebHeaderCollection.IsRestricted(key))
					{
						httpWebRequest.Headers.Add(key, headers[key]);
					}
				}
				if (headers.ContainsKey("Content-Type"))
				{
					httpWebRequest.ContentType = headers["Content-Type"];
				}
			}
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			int num = 0;
			if (AtFiPibySQwMdMW6psG != null)
			{
				goto IL_0133;
			}
			goto IL_0178;
			IL_0133:
			int num2 = default(int);
			num = num2;
			goto IL_0178;
			IL_0178:
			HttpWebResponse httpWebResponse = default(HttpWebResponse);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				IL_0178_2:
				switch (num)
				{
				case 2:
				{
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					HREW5XyU2M(ref httpResult_, httpWebResponse);
					if (binaryMode)
					{
						num5 = (int)httpWebResponse.ContentLength;
						httpResult_.Data = new byte[num5];
						num3 = num5;
						int num4 = 0;
						num = 1;
						if (AtFiPibySQwMdMW6psG == null)
						{
							continue;
						}
						break;
					}
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
					{
						httpResult_.Text = streamReader.ReadToEnd();
					}
					goto IL_01f7;
				}
				default:
					while (true)
					{
						httpWebRequest.ServicePoint.Expect100Continue = false;
						httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
						if (httpWebResponse != null)
						{
							httpResult_.Code = (int)httpWebResponse.StatusCode;
							num = 2;
							if (AtFiPibySQwMdMW6psG != null)
							{
								continue;
							}
							goto IL_0178_2;
						}
						break;
					}
					goto end_IL_0178;
				case 1:
					{
						using (BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream()))
						{
							while (num3 > 0)
							{
								int num4 = binaryReader.Read(httpResult_.Data, num5 - num3, num3);
								num3 -= num4;
							}
						}
						goto IL_01f7;
					}
					IL_01f7:
					httpWebResponse.Close();
					goto end_IL_0178;
				}
				goto IL_0133;
				continue;
				end_IL_0178:
				break;
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-GET] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult Post(string url, string token, bool binaryMode = false)
	{
		return Post(url, null, token, binaryMode);
	}

	public HttpResult Post(string url, StringDictionary headers, Auth auth, bool binaryMode = false)
	{
		if (headers == null)
		{
			headers = new StringDictionary { 
			{
				"Content-Type",
				ContentType.WWW_FORM_URLENC
			} };
		}
		if (!headers.ContainsKey("Content-Type"))
		{
			headers["Content-Type"] = ContentType.WWW_FORM_URLENC;
		}
		qp7WDKEIWM(ref headers, auth);
		string token = auth.CreateManageTokenV2("POST", url, headers);
		return Post(url, headers, token, binaryMode);
	}

	public HttpResult Post(string url, StringDictionary headers, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
        HttpWebResponse httpWebResponse = default;
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			int num = 1;
			if (AtFiPibySQwMdMW6psG == null)
			{
				goto IL_0027;
			}
			goto IL_0112;
			IL_0027:
			httpWebRequest.Method = "POST";
			if (headers != null)
			{
				foreach (string key in headers.Keys)
				{
					if (!WebHeaderCollection.IsRestricted(key))
					{
						httpWebRequest.Headers.Add(key, headers[key]);
					}
				}
				if (headers.ContainsKey("Content-Type"))
				{
					httpWebRequest.ContentType = headers["Content-Type"];
				}
			}
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			num = 0;
			if (!MI3HhDbpqVBxiyxSuM6())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0112;
			IL_0112:
			switch (num)
			{
			case 1:
				break;
			default:
				if (httpWebResponse != null)
				{
					httpResult_.Code = (int)httpWebResponse.StatusCode;
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					goto case 2;
				}
				goto end_IL_000a;
			case 2:
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				if (!binaryMode)
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					httpResult_.Text = streamReader.ReadToEnd();
				}
				else
				{
					int num3 = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num3];
					int num4 = num3;
					int num5 = 0;
					using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
					while (num4 > 0)
					{
						num5 = binaryReader.Read(httpResult_.Data, num3 - num4, num4);
						num4 -= num5;
					}
				}
				httpWebResponse.Close();
				goto end_IL_000a;
			}
			goto IL_0027;
			end_IL_000a:;
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostData(string url, byte[] data, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (string.IsNullOrEmpty(token))
			{
				goto IL_005d;
			}
			httpWebRequest.Headers.Add("Authorization", token);
			int num = 0;
			if (AtFiPibySQwMdMW6psG == null)
			{
				goto IL_004c;
			}
			goto IL_0090;
			IL_005d:
			httpWebRequest.ContentType = ContentType.APPLICATION_OCTET_STREAM;
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			num = 1;
			if (AtFiPibySQwMdMW6psG == null)
			{
				goto IL_004c;
			}
			goto IL_0090;
			IL_0090:
			int num2 = default(int);
			num = num2;
			goto IL_004c;
			IL_004c:
			switch (num)
			{
			case 1:
				httpWebRequest.ServicePoint.Expect100Continue = false;
				if (data != null)
				{
					httpWebRequest.AllowWriteStreamBuffering = true;
					using Stream stream = httpWebRequest.GetRequestStream();
					stream.Write(data, 0, data.Length);
					stream.Flush();
				}
				goto case 2;
			case 2:
				if (httpWebRequest.GetResponse() is HttpWebResponse httpWebResponse)
				{
					httpResult_.Code = (int)httpWebResponse.StatusCode;
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					HREW5XyU2M(ref httpResult_, httpWebResponse);
					if (binaryMode)
					{
						int num3 = (int)httpWebResponse.ContentLength;
						httpResult_.Data = new byte[num3];
						int num4 = num3;
						int num5 = 0;
						using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
						while (num4 > 0)
						{
							num5 = binaryReader.Read(httpResult_.Data, num3 - num4, num4);
							num4 -= num5;
						}
					}
					else
					{
						using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
						httpResult_.Text = streamReader.ReadToEnd();
					}
					httpWebResponse.Close();
				}
				goto end_IL_000a;
			}
			goto IL_005d;
			end_IL_000a:;
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-BIN] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostData(string url, byte[] data, string mimeType, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
        HttpWebResponse httpWebResponse = default;
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.ContentType = mimeType;
			int num = 0;
			if (MI3HhDbpqVBxiyxSuM6())
			{
				goto IL_0080;
			}
			goto IL_013f;
			IL_0180:
			int num2 = default(int);
			BinaryReader binaryReader = default(BinaryReader);
			int num4 = default(int);
			try
			{
				while (num2 > 0)
				{
					int num3 = binaryReader.Read(httpResult_.Data, num4 - num2, num2);
					num2 -= num3;
				}
			}
			finally
			{
				((IDisposable)binaryReader)?.Dispose();
			}
			goto IL_01b4;
			IL_01b4:
			httpWebResponse = default(HttpWebResponse);
			httpWebResponse.Close();
			goto end_IL_000a;
			IL_0080:
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			if (data != null)
			{
				httpWebRequest.AllowWriteStreamBuffering = true;
				using Stream stream = httpWebRequest.GetRequestStream();
				stream.Write(data, 0, data.Length);
				stream.Flush();
			}
			httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			if (httpWebResponse != null)
			{
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				if (binaryMode)
				{
					num4 = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num4];
					num2 = num4;
					int num3 = 0;
					goto IL_0059;
				}
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					httpResult_.Text = streamReader.ReadToEnd();
				}
				goto IL_01b4;
			}
			goto end_IL_000a;
			IL_0059:
			binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
			num = 1;
			if (!MI3HhDbpqVBxiyxSuM6())
			{
				int num5 = default(int);
				num = num5;
			}
			goto IL_013f;
			IL_013f:
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0080;
			case 1:
				goto IL_0180;
			}
			goto IL_0059;
			end_IL_000a:;
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-BIN] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostJson(string url, string data, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			int num = 1;
			if (!MI3HhDbpqVBxiyxSuM6())
			{
				goto IL_00a8;
			}
			goto IL_00ff;
			IL_00a8:
			int num2 = default(int);
			num = num2;
			goto IL_00ff;
			IL_00ff:
			HttpWebResponse httpWebResponse = default(HttpWebResponse);
			while (true)
			{
				switch (num)
				{
				case 2:
					httpWebRequest.ServicePoint.Expect100Continue = false;
					if (data != null)
					{
						httpWebRequest.AllowWriteStreamBuffering = true;
						using Stream stream = httpWebRequest.GetRequestStream();
						stream.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
						stream.Flush();
					}
					httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
					if (httpWebResponse == null)
					{
						break;
					}
					goto IL_008d;
				case 1:
					httpWebRequest.Method = "POST";
					if (!string.IsNullOrEmpty(token))
					{
						httpWebRequest.Headers.Add("Authorization", token);
					}
					httpWebRequest.ContentType = ContentType.APPLICATION_JSON;
					httpWebRequest.UserAgent = CSGWoaGFaF;
					httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
					goto case 2;
				default:
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					HREW5XyU2M(ref httpResult_, httpWebResponse);
					if (binaryMode)
					{
						int num3 = (int)httpWebResponse.ContentLength;
						httpResult_.Data = new byte[num3];
						int num4 = num3;
						int num5 = 0;
						using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
						while (num4 > 0)
						{
							num5 = binaryReader.Read(httpResult_.Data, num3 - num4, num4);
							num4 -= num5;
						}
					}
					else
					{
						using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
						httpResult_.Text = streamReader.ReadToEnd();
					}
					httpWebResponse.Close();
					break;
				}
				break;
				IL_008d:
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				num = 0;
				if (AtFiPibySQwMdMW6psG == null)
				{
					continue;
				}
				goto IL_00a8;
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-JSON] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostText(string url, string data, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			int num3 = default(int);
			int num5 = default(int);
			while (true)
			{
				IL_0114:
				httpWebRequest.ContentType = ContentType.TEXT_PLAIN;
				httpWebRequest.UserAgent = CSGWoaGFaF;
				httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
				httpWebRequest.ServicePoint.Expect100Continue = false;
				if (data != null)
				{
					httpWebRequest.AllowWriteStreamBuffering = true;
					using Stream stream = httpWebRequest.GetRequestStream();
					stream.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
					stream.Flush();
				}
				int num;
				if (httpWebRequest.GetResponse() is HttpWebResponse httpWebResponse)
				{
					httpResult_.Code = (int)httpWebResponse.StatusCode;
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					num = 0;
					if (!MI3HhDbpqVBxiyxSuM6())
					{
						goto IL_00bb;
					}
					goto IL_00bf;
				}
				break;
				IL_00bf:
				while (true)
				{
					switch (num)
					{
					default:
					{
						HREW5XyU2M(ref httpResult_, httpWebResponse);
						if (binaryMode)
						{
							goto IL_0096;
						}
						using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
						{
							httpResult_.Text = streamReader.ReadToEnd();
						}
						goto IL_01c2;
					}
					case 2:
						break;
					case 1:
						{
							int num2 = num3;
							int num4 = 0;
							using (BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream()))
							{
								while (num2 > 0)
								{
									num4 = binaryReader.Read(httpResult_.Data, num3 - num2, num2);
									num2 -= num4;
								}
							}
							goto IL_01c2;
						}
						IL_01c2:
						httpWebResponse.Close();
						goto end_IL_00bf;
					}
					goto IL_0114;
					IL_0096:
					num3 = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num3];
					num = 1;
					if (MI3HhDbpqVBxiyxSuM6())
					{
						continue;
					}
					goto IL_00bb;
					continue;
					end_IL_00bf:
					break;
				}
				break;
				IL_00bb:
				num = num5;
				goto IL_00bf;
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-TEXT] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostForm(string url, Dictionary<string, string> kvData, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.ContentType = ContentType.WWW_FORM_URLENC;
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			if (kvData != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (KeyValuePair<string, string> kvDatum in kvData)
				{
					stringBuilder.AppendFormat("{0}={1}&", Uri.EscapeDataString(kvDatum.Key), Uri.EscapeDataString(kvDatum.Value));
				}
				httpWebRequest.AllowWriteStreamBuffering = true;
				using Stream stream = httpWebRequest.GetRequestStream();
				stream.Write(Encoding.UTF8.GetBytes(stringBuilder.ToString()), 0, stringBuilder.Length - 1);
				stream.Flush();
			}
			if (httpWebRequest.GetResponse() is HttpWebResponse httpWebResponse)
			{
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				if (binaryMode)
				{
					int num = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num];
					int num2 = num;
					int num3 = 0;
					using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
					while (num2 > 0)
					{
						num3 = binaryReader.Read(httpResult_.Data, num - num2, num2);
						num2 -= num3;
					}
				}
				else
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					httpResult_.Text = streamReader.ReadToEnd();
				}
				httpWebResponse.Close();
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendFormat("[{0}] [{1}] [HTTP-POST-FORM] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder2.Append(ex3.Message + " ");
			}
			stringBuilder2.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder2.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostForm(string url, string data, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
        HttpWebResponse httpWebResponse = default;
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.ContentType = ContentType.WWW_FORM_URLENC;
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			Stream requestStream = default(Stream);
			int num;
			if (!string.IsNullOrEmpty(data))
			{
				httpWebRequest.AllowWriteStreamBuffering = true;
				requestStream = httpWebRequest.GetRequestStream();
				num = 2;
				if (AtFiPibySQwMdMW6psG != null)
				{
					goto IL_00d5;
				}
				goto IL_00d9;
			}
			goto IL_011b;
			IL_011b:
			httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			num = 0;
			if (MI3HhDbpqVBxiyxSuM6())
			{
				goto IL_009b;
			}
			goto IL_00d9;
			IL_00ed:
			try
			{
				requestStream.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
				requestStream.Flush();
			}
			finally
			{
				((IDisposable)requestStream)?.Dispose();
			}
			goto IL_011b;
			IL_009b:
			if (httpWebResponse != null)
			{
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				num = 1;
				if (!MI3HhDbpqVBxiyxSuM6())
				{
					goto IL_00d5;
				}
				goto IL_00d9;
			}
			goto end_IL_000a;
			IL_00d5:
			int num2 = default(int);
			num = num2;
			goto IL_00d9;
			IL_00d9:
			switch (num)
			{
			case 2:
				goto IL_00ed;
			case 1:
				if (binaryMode)
				{
					int num3 = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num3];
					int num4 = num3;
					int num5 = 0;
					using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
					while (num4 > 0)
					{
						num5 = binaryReader.Read(httpResult_.Data, num3 - num4, num4);
						num4 -= num5;
					}
				}
				else
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					httpResult_.Text = streamReader.ReadToEnd();
				}
				httpWebResponse.Close();
				goto end_IL_000a;
			}
			goto IL_009b;
			end_IL_000a:;
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-FORM] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostForm(string url, StringDictionary headers, string data, Auth auth, bool binaryMode = false)
	{
		if (headers == null)
		{
			headers = new StringDictionary { 
			{
				"Content-Type",
				ContentType.WWW_FORM_URLENC
			} };
		}
		if (!headers.ContainsKey("Content-Type"))
		{
			headers["Content-Type"] = ContentType.WWW_FORM_URLENC;
		}
		qp7WDKEIWM(ref headers, auth);
		string token = auth.CreateManageTokenV2("POST", url, headers, data);
		return PostForm(url, headers, Encoding.UTF8.GetBytes(data), token, binaryMode);
	}

	public HttpResult PostForm(string url, byte[] data, string token, bool binaryMode = false)
	{
		return PostForm(url, null, data, token, binaryMode);
	}

	public HttpResult PostForm(string url, StringDictionary headers, byte[] data, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (headers != null)
			{
				foreach (string key in headers.Keys)
				{
					if (!WebHeaderCollection.IsRestricted(key))
					{
						httpWebRequest.Headers.Add(key, headers[key]);
					}
				}
			}
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.ContentType = ContentType.WWW_FORM_URLENC;
			httpWebRequest.UserAgent = CSGWoaGFaF;
			if (AtFiPibySQwMdMW6psG != null)
			{
				switch (1)
				{
				case 1:
					break;
				default:
					goto IL_0114;
				case 2:
					goto IL_0121;
				}
			}
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			if (data != null)
			{
				httpWebRequest.AllowWriteStreamBuffering = true;
				using Stream stream = httpWebRequest.GetRequestStream();
				stream.Write(data, 0, data.Length);
				stream.Flush();
			}
			goto IL_0114;
			IL_0114:
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			goto IL_0121;
			IL_0121:
			if (httpWebResponse != null)
			{
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				if (binaryMode)
				{
					int num = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num];
					int num2 = num;
					int num3 = 0;
					using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
					while (num2 > 0)
					{
						num3 = binaryReader.Read(httpResult_.Data, num - num2, num2);
						num2 -= num3;
					}
				}
				else
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					httpResult_.Text = streamReader.ReadToEnd();
				}
				httpWebResponse.Close();
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-FORM] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PostMultipart(string url, byte[] data, string boundary, string token, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			if (!string.IsNullOrEmpty(token))
			{
				httpWebRequest.Headers.Add("Authorization", token);
			}
			httpWebRequest.ContentType = $"{ContentType.MULTIPART_FORM_DATA}; boundary={boundary}";
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.AllowWriteStreamBuffering = true;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(data, 0, data.Length);
				stream.Flush();
			}
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			int num = 1;
			if (AtFiPibySQwMdMW6psG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (httpWebResponse == null)
					{
						goto end_IL_0125;
					}
					httpResult_.Code = (int)httpWebResponse.StatusCode;
					httpResult_.RefCode = (int)httpWebResponse.StatusCode;
					HREW5XyU2M(ref httpResult_, httpWebResponse);
					if (binaryMode)
					{
						num3 = (int)httpWebResponse.ContentLength;
						httpResult_.Data = new byte[num3];
						num = 0;
						if (MI3HhDbpqVBxiyxSuM6())
						{
							continue;
						}
						goto default;
					}
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
					{
						httpResult_.Text = streamReader.ReadToEnd();
					}
					break;
				}
				default:
				{
					int num4 = num3;
					int num5 = 0;
					using (BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream()))
					{
						while (num4 > 0)
						{
							num5 = binaryReader.Read(httpResult_.Data, num3 - num4, num4);
							num4 -= num5;
						}
					}
					break;
				}
				}
				httpWebResponse.Close();
				break;
				continue;
				end_IL_0125:
				break;
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-POST-MPART] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	public HttpResult PutDataWithHeaders(string url, byte[] data, Dictionary<string, string> headers, bool binaryMode = false)
	{
		HttpResult httpResult_ = new HttpResult();
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "PUT";
			httpWebRequest.ContentType = ContentType.APPLICATION_OCTET_STREAM;
			httpWebRequest.UserAgent = CSGWoaGFaF;
			httpWebRequest.AllowAutoRedirect = FDPWdtRk1K;
			httpWebRequest.ServicePoint.Expect100Continue = false;
			foreach (KeyValuePair<string, string> header in headers)
			{
				if (!string.IsNullOrEmpty(header.Value))
				{
					httpWebRequest.Headers.Add(header.Key, header.Value);
				}
			}
			if (data != null)
			{
				httpWebRequest.AllowWriteStreamBuffering = true;
				using Stream stream = httpWebRequest.GetRequestStream();
				stream.Write(data, 0, data.Length);
				stream.Flush();
			}
			if (httpWebRequest.GetResponse() is HttpWebResponse httpWebResponse)
			{
				httpResult_.Code = (int)httpWebResponse.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse);
				if (binaryMode)
				{
					int num = (int)httpWebResponse.ContentLength;
					httpResult_.Data = new byte[num];
					int num2 = num;
					int num3 = 0;
					using BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
					while (num2 > 0)
					{
						num3 = binaryReader.Read(httpResult_.Data, num - num2, num2);
						num2 -= num3;
					}
				}
				else
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
					httpResult_.Text = streamReader.ReadToEnd();
				}
				httpWebResponse.Close();
			}
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse httpWebResponse2)
			{
				httpResult_.Code = (int)httpWebResponse2.StatusCode;
				httpResult_.RefCode = (int)httpWebResponse2.StatusCode;
				HREW5XyU2M(ref httpResult_, httpWebResponse2);
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream()))
				{
					httpResult_.Text = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
			}
		}
		catch (Exception ex2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [{1}] [HTTP-PUT-BIN] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), CSGWoaGFaF);
			for (Exception ex3 = ex2; ex3 != null; ex3 = ex3.InnerException)
			{
				stringBuilder.Append(ex3.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult_.RefCode = 0;
			httpResult_.RefText += stringBuilder.ToString();
		}
		finally
		{
			httpWebRequest?.Abort();
		}
		return httpResult_;
	}

	private void HREW5XyU2M(ref HttpResult httpResult_0, HttpWebResponse httpWebResponse_0)
	{
        string[] allKeys = default;
        string text = default;
        WebHeaderCollection headers = default;
        int num2 = default;
		if (httpWebResponse_0 == null)
		{
			return;
		}
		if (httpResult_0.RefInfo == null)
		{
			httpResult_0.RefInfo = new Dictionary<string, string>();
		}
		httpResult_0.RefInfo.Add("ProtocolVersion", httpWebResponse_0.ProtocolVersion.ToString());
		if (!string.IsNullOrEmpty(httpWebResponse_0.CharacterSet))
		{
			httpResult_0.RefInfo.Add("Characterset", httpWebResponse_0.CharacterSet);
		}
		if (!string.IsNullOrEmpty(httpWebResponse_0.ContentEncoding))
		{
			httpResult_0.RefInfo.Add("ContentEncoding", httpWebResponse_0.ContentEncoding);
		}
		int num;
		if (!string.IsNullOrEmpty(httpWebResponse_0.ContentType))
		{
			num = 0;
			if (AtFiPibySQwMdMW6psG != null)
			{
				goto IL_00e2;
			}
			goto IL_00e6;
		}
		goto IL_0133;
		IL_011c:
		httpResult_0.RefInfo.Add("ContentType", httpWebResponse_0.ContentType);
		goto IL_0133;
		IL_0133:
		httpResult_0.RefInfo.Add("ContentLength", httpWebResponse_0.ContentLength.ToString());
		headers = httpWebResponse_0.Headers;
		allKeys = default(string[]);
		num2 = default(int);
		if (headers != null && headers.Count > 0)
		{
			if (httpResult_0.RefInfo == null)
			{
				httpResult_0.RefInfo = new Dictionary<string, string>();
			}
			allKeys = headers.AllKeys;
			num2 = 0;
			goto IL_0112;
		}
		return;
		IL_0112:
		text = default(string);
		if (num2 < allKeys.Length)
		{
			text = allKeys[num2];
			num = 1;
			if (AtFiPibySQwMdMW6psG != null)
			{
				goto IL_00e2;
			}
			goto IL_00e6;
		}
		return;
		IL_00e6:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_011c;
		}
		httpResult_0.RefInfo.Add(text, headers[text]);
		num2++;
		goto IL_0112;
		IL_00e2:
		int num3 = default(int);
		num = num3;
		goto IL_00e6;
	}

	private void qp7WDKEIWM(ref StringDictionary stringDictionary_0, Auth auth_0)
	{
		string value = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
		string environmentVariable = Environment.GetEnvironmentVariable("DISABLE_QINIU_TIMESTAMP_SIGNATURE");
		bool? disableQiniuTimestampSignature = auth_0.AuthOptions.DisableQiniuTimestampSignature;
		if (disableQiniuTimestampSignature.HasValue)
		{
			if (disableQiniuTimestampSignature != true)
			{
				stringDictionary_0["X-Qiniu-Date"] = value;
				int num = 0;
				if (!MI3HhDbpqVBxiyxSuM6())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		else if (!string.IsNullOrEmpty(environmentVariable))
		{
			if (environmentVariable.ToLower() != "true")
			{
				stringDictionary_0["X-Qiniu-Date"] = value;
			}
		}
		else
		{
			stringDictionary_0["X-Qiniu-Date"] = value;
		}
	}

	internal static bool MI3HhDbpqVBxiyxSuM6()
	{
		return AtFiPibySQwMdMW6psG == null;
	}
}
