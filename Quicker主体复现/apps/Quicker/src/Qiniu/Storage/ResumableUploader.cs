using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using GFy17Dq3Ka8YBV2L15c;
using Newtonsoft.Json;
using Qiniu.Http;
using Qiniu.Util;
using zVdobkq0UyBDM0DwbPT;

namespace Qiniu.Storage;

public class ResumableUploader
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static UploadProgressHandler fH4v7kUT1ky;

		public static UploadController jrDv7GQYTDr;
	}

	private Config xDcYi0unlH;

	private HttpManager mjdY3ijBx4;

	private static ResumableUploader VFwp8yoPghG05n0gXDA;

	public ResumableUploader(Config config)
	{
		if (config == null)
		{
			xDcYi0unlH = new Config();
		}
		else
		{
			xDcYi0unlH = config;
		}
		mjdY3ijBx4 = new HttpManager(false);
	}

	public HttpResult UploadFile(string localFile, string key, string token, PutExtra putExtra)
	{
		try
		{
			FileStream stream = new FileStream(localFile, FileMode.Open);
			return UploadStream(stream, key, token, putExtra);
		}
		catch (Exception ex)
		{
			HttpResult invalidFile = HttpResult.InvalidFile;
			invalidFile.RefText = ex.Message;
			return invalidFile;
		}
	}

	public HttpResult UploadStream(Stream stream, string key, string upToken, PutExtra putExtra)
	{
		HttpResult httpResult = new HttpResult();
		if (putExtra == null)
		{
			putExtra = new PutExtra();
		}
		if (putExtra.ProgressHandler == null)
		{
			putExtra.ProgressHandler = _003C_003EO.fH4v7kUT1ky ?? (_003C_003EO.fH4v7kUT1ky = DefaultUploadProgressHandler);
		}
		if (putExtra.UploadController == null)
		{
			putExtra.UploadController = _003C_003EO.jrDv7GQYTDr ?? (_003C_003EO.jrDv7GQYTDr = DefaultUploadController);
		}
		if (putExtra.BlockUploadThreads <= 0 || putExtra.BlockUploadThreads > 64)
		{
			putExtra.BlockUploadThreads = 1;
		}
		using (stream)
		{
			try
			{
				ResumeInfo resumeInfo_ = null;
				if (File.Exists(putExtra.ResumeRecordFile))
				{
					resumeInfo_ = ResumeHelper.Load(putExtra.ResumeRecordFile);
				}
				if (putExtra.Version == "v1")
				{
					httpResult = okvYT3dL13(stream, key, upToken, putExtra, resumeInfo_);
				}
				else
				{
					if (!(putExtra.Version == "v2"))
					{
						throw new Exception("Invalid Version, only supports v1 / v2");
					}
					httpResult = ceXYMyHG7m(stream, key, upToken, putExtra, resumeInfo_);
				}
			}
			catch (Exception ex)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("[{0}] [ResumableUpload] Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
				for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
				{
					stringBuilder.Append(ex2.Message + " ");
				}
				stringBuilder.AppendLine();
				httpResult.RefCode = 0;
				httpResult.RefText += stringBuilder.ToString();
			}
		}
		return httpResult;
	}

	private HttpResult okvYT3dL13(Stream stream_0, string string_0, string string_1, PutExtra putExtra_0, ResumeInfo resumeInfo_0)
	{
		HttpResult httpResult = new HttpResult();
		bool flag = resumeInfo_0 != null;
		HttpResult result;
		try
		{
			string string_2 = "";
			long value = 0L;
			int num = 4;
			if (!Cla0w9oMT2ACeSRQAFx())
			{
				goto IL_017f;
			}
			goto IL_0336;
			IL_017f:
			int num2 = default(int);
			num = num2;
			goto IL_0336;
			IL_0336:
			long num6 = default(long);
			long num7 = default(long);
			long expiredAt = default(long);
			Dictionary<long, byte[]> dictionary = default(Dictionary<long, byte[]>);
			Dictionary<string, long> dictionary3 = default(Dictionary<string, long>);
			UploadControllerAction uploadControllerAction = default(UploadControllerAction);
			ManualResetEvent manualResetEvent = default(ManualResetEvent);
			int num8 = default(int);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			long length = default(long);
			Dictionary<long, HttpResult> dictionary2 = default(Dictionary<long, HttpResult>);
			Dictionary<long, HttpResult>.KeyCollection.Enumerator enumerator2 = default(Dictionary<long, HttpResult>.KeyCollection.Enumerator);
			int num5 = default(int);
			while (true)
			{
				switch (num)
				{
				case 7:
					if (num6 < num7)
					{
						string value2 = resumeInfo_0.Contexts[num6];
						expiredAt = resumeInfo_0.ContextsExpiredAt[num6];
						if (!string.IsNullOrEmpty(value2))
						{
							num = 1;
							if (VFwp8yoPghG05n0gXDA != null)
							{
								continue;
							}
							goto case 6;
						}
						goto case 2;
					}
					if (dictionary.Count > 0)
					{
						num = 1;
						if (VFwp8yoPghG05n0gXDA == null)
						{
							continue;
						}
						break;
					}
					goto IL_0415;
				case 6:
					if (!UnixTimestamp.IsContextExpired(expiredAt))
					{
						dictionary3["UploadProgress"] += putExtra_0.PartSize;
						goto IL_009b;
					}
					goto case 2;
				case 2:
					while (true)
					{
						uploadControllerAction = putExtra_0.UploadController();
						if (uploadControllerAction != UploadControllerAction.Aborted)
						{
							switch (uploadControllerAction)
							{
							case UploadControllerAction.Suspended:
								httpResult.RefCode = 1;
								httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is paused\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
								manualResetEvent.WaitOne(1000);
								continue;
							default:
								continue;
							case UploadControllerAction.Activated:
								break;
							}
							long offset = num6 * putExtra_0.PartSize;
							stream_0.Seek(offset, SeekOrigin.Begin);
							num8 = stream_0.Read(array, 0, putExtra_0.PartSize);
							array2 = new byte[num8];
							goto case 5;
						}
						httpResult.Code = -2;
						httpResult.RefCode = -2;
						httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is aborted\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
						manualResetEvent.Set();
						result = httpResult;
						break;
					}
					goto end_IL_0336;
				case 5:
					Array.Copy(array, array2, num8);
					num = 0;
					if (Cla0w9oMT2ACeSRQAFx())
					{
						continue;
					}
					break;
				case 4:
					length = stream_0.Length;
					num7 = (length + putExtra_0.PartSize - 1L) / putExtra_0.PartSize;
					if (resumeInfo_0 == null)
					{
						resumeInfo_0 = new ResumeInfo
						{
							FileSize = length,
							BlockCount = num7,
							Contexts = new string[num7],
							ContextsExpiredAt = new long[num7],
							ExpiredAt = 0L
						};
					}
					uploadControllerAction = putExtra_0.UploadController();
					manualResetEvent = new ManualResetEvent(false);
					dictionary = new Dictionary<long, byte[]>();
					dictionary2 = new Dictionary<long, HttpResult>();
					dictionary3 = new Dictionary<string, long>();
					dictionary3.Add("UploadProgress", value);
					array = new byte[putExtra_0.PartSize];
					num6 = 0L;
					goto case 7;
				case 3:
					try
					{
						while (true)
						{
							if (enumerator2.MoveNext())
							{
								int num9 = (int)enumerator2.Current;
								HttpResult httpResult3 = dictionary2[num9];
								if (httpResult3.Code == 200)
								{
									continue;
								}
								httpResult = httpResult3;
								manualResetEvent.Set();
								result = httpResult;
								goto end_IL_0336;
							}
							if (VFwp8yoPghG05n0gXDA != null)
							{
								switch (0)
								{
								}
							}
							break;
						}
						goto IL_02b8;
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
					}
				default:
					dictionary.Add(num6, array2);
					if (dictionary.Count != putExtra_0.BlockUploadThreads)
					{
						goto IL_009b;
					}
					uMDYA3N1Dr(dictionary, string_1, putExtra_0, resumeInfo_0, dictionary2, dictionary3, length, string_2);
					enumerator2 = dictionary2.Keys.GetEnumerator();
					num2 = 3;
					goto case 3;
				case 1:
					{
						uMDYA3N1Dr(dictionary, string_1, putExtra_0, resumeInfo_0, dictionary2, dictionary3, length, string_2);
						foreach (long key in dictionary2.Keys)
						{
							int num3 = (int)key;
							HttpResult httpResult2 = dictionary2[num3];
							if (httpResult2.Code != 200)
							{
								httpResult = httpResult2;
								manualResetEvent.Set();
								result = httpResult;
								int num4 = 0;
								if (VFwp8yoPghG05n0gXDA != null)
								{
									num4 = num5;
								}
								switch (num4)
								{
								}
								goto end_IL_0336;
							}
						}
						dictionary.Clear();
						dictionary2.Clear();
						if (!string.IsNullOrEmpty(putExtra_0.ResumeRecordFile))
						{
							ResumeHelper.Save(resumeInfo_0, putExtra_0.ResumeRecordFile);
						}
						goto IL_0415;
					}
					IL_02b8:
					dictionary.Clear();
					dictionary2.Clear();
					if (!string.IsNullOrEmpty(putExtra_0.ResumeRecordFile))
					{
						ResumeHelper.Save(resumeInfo_0, putExtra_0.ResumeRecordFile);
					}
					goto IL_009b;
					IL_009b:
					num6++;
					goto case 7;
					IL_0415:
					if (uploadControllerAction == UploadControllerAction.Activated)
					{
						HttpResult httpResult4 = new HttpResult();
						httpResult4 = aF5YFWC9dn(string_0, length, string_0, string_1, putExtra_0, resumeInfo_0.Contexts);
						if (httpResult4.Code != 200)
						{
							httpResult.Shadow(httpResult4);
							httpResult.RefText += string.Format("[{0}] [ResumableUpload] Error: mkfile: code = {1}, text = {2}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), httpResult4.Code, httpResult4.Text);
						}
						if (File.Exists(putExtra_0.ResumeRecordFile))
						{
							File.Delete(putExtra_0.ResumeRecordFile);
						}
						httpResult.Shadow(httpResult4);
						httpResult.RefText += string.Format("[{0}] [ResumableUpload] Uploaded: \"{1}\" ==> \"{2}\"\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), putExtra_0.ResumeRecordFile, string_0);
					}
					else
					{
						httpResult.Code = -2;
						httpResult.RefCode = -2;
						httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is aborted, mkfile\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
					}
					manualResetEvent.Set();
					goto IL_05fc;
				}
				goto IL_017f;
				continue;
				end_IL_0336:
				break;
			}
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [ResumableUpload] Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				stringBuilder.Append(ex2.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.RefCode = 0;
			httpResult.RefText += stringBuilder.ToString();
			goto IL_05fc;
		}
		return result;
		IL_05fc:
		if (flag && httpResult.Code == 701)
		{
			stream_0.Seek(0L, SeekOrigin.Begin);
			return okvYT3dL13(stream_0, string_0, string_1, putExtra_0, null);
		}
		return httpResult;
	}

	private HttpResult ceXYMyHG7m(Stream stream_0, string string_0, string string_1, PutExtra putExtra_0, ResumeInfo resumeInfo_0)
	{
		HttpResult httpResult = new HttpResult();
		bool flag = resumeInfo_0 != null;
		try
		{
			string text = "~";
			if (string_0 != null)
			{
				text = Base64.GetEncodedObjectName(string_0);
			}
			long num = 0L;
			long length = stream_0.Length;
			long num2 = (length + putExtra_0.PartSize - 1L) / putExtra_0.PartSize;
			if (resumeInfo_0 == null || UnixTimestamp.IsContextExpired(resumeInfo_0.ExpiredAt))
			{
				HttpResult httpResult2 = KkqYUBgDTm(text, string_1);
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(httpResult2.Text);
				if (httpResult2.Code != 200)
				{
					return httpResult2;
				}
				resumeInfo_0 = new ResumeInfo
				{
					FileSize = length,
					BlockCount = num2,
					Etags = new Dictionary<string, object>[num2],
					Uploaded = 0L,
					ExpiredAt = long.Parse(dictionary["expireAt"]),
					UploadId = dictionary["uploadId"]
				};
			}
			long num3 = 0L;
			UploadControllerAction uploadControllerAction = default(UploadControllerAction);
			ManualResetEvent manualResetEvent = default(ManualResetEvent);
			Dictionary<long, byte[]> dictionary2 = default(Dictionary<long, byte[]>);
			Dictionary<long, HttpResult> dictionary3 = default(Dictionary<long, HttpResult>);
			Dictionary<string, long> dictionary4 = default(Dictionary<string, long>);
			byte[] array = default(byte[]);
			long num6 = default(long);
			int num9 = default(int);
			int num10 = default(int);
			while (true)
			{
				int num5;
				if (num3 < num2)
				{
					if (resumeInfo_0.Etags[num3] == null)
					{
						goto IL_0632;
					}
					num = (resumeInfo_0.Uploaded = num + putExtra_0.PartSize);
					num5 = 3;
					if (!Cla0w9oMT2ACeSRQAFx())
					{
						goto IL_04b4;
					}
					goto IL_05fc;
				}
				putExtra_0.ProgressHandler(num, length);
				uploadControllerAction = putExtra_0.UploadController();
				manualResetEvent = new ManualResetEvent(false);
				dictionary2 = new Dictionary<long, byte[]>();
				dictionary3 = new Dictionary<long, HttpResult>();
				dictionary4 = new Dictionary<string, long>();
				dictionary4.Add("UploadProgress", num);
				array = new byte[putExtra_0.PartSize];
				num6 = 0L;
				goto IL_0337;
				IL_049d:
				if (uploadControllerAction == UploadControllerAction.Activated)
				{
					num5 = 5;
					if (VFwp8yoPghG05n0gXDA != null)
					{
						goto IL_04b4;
					}
					goto IL_05fc;
				}
				goto IL_0725;
				IL_0632:
				num3++;
				continue;
				IL_015d:
				num6++;
				num5 = 4;
				if (Cla0w9oMT2ACeSRQAFx())
				{
					goto IL_05fc;
				}
				goto IL_0725;
				IL_05fc:
				while (true)
				{
					switch (num5)
					{
					case 10:
						break;
					case 9:
						goto IL_01cc;
					case 4:
					case 8:
						goto IL_0337;
					case 6:
						goto IL_049d;
					case 5:
						goto IL_04bb;
					case 1:
						goto IL_05dc;
					case 3:
						goto IL_0632;
					case 7:
						stream_0.Seek(0L, SeekOrigin.Begin);
						return ceXYMyHG7m(stream_0, string_0, string_1, putExtra_0, null);
					case 2:
						goto IL_0725;
					default:
						goto end_IL_06a9;
					}
					break;
					IL_05dc:
					ResumeHelper.Save(resumeInfo_0, putExtra_0.ResumeRecordFile);
					num5 = 6;
					if (VFwp8yoPghG05n0gXDA == null)
					{
						continue;
					}
					goto IL_04b4;
					IL_04bb:
					HttpResult httpResult3 = new HttpResult();
					httpResult3 = b1yYlWLW0a(string_0, resumeInfo_0, string_0, string_1, putExtra_0, text);
					if (httpResult.Code == 612 && File.Exists(putExtra_0.ResumeRecordFile))
					{
						File.Delete(putExtra_0.ResumeRecordFile);
					}
					if (flag && httpResult.Code == 612)
					{
						num5 = 7;
						if (VFwp8yoPghG05n0gXDA == null)
						{
							continue;
						}
					}
					else
					{
						if (httpResult3.Code != 200)
						{
							httpResult.Shadow(httpResult3);
							httpResult.RefText += string.Format("[{0}] [ResumableUpload] Error: mkfile: code = {1}, text = {2}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), httpResult3.Code, httpResult3.Text);
						}
						if (File.Exists(putExtra_0.ResumeRecordFile))
						{
							File.Delete(putExtra_0.ResumeRecordFile);
						}
						httpResult.Shadow(httpResult3);
						httpResult.RefText += string.Format("[{0}] [ResumableUpload] Uploaded: \"{1}\" ==> \"{2}\"\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), putExtra_0.ResumeRecordFile, string_0);
						num5 = 0;
						if (Cla0w9oMT2ACeSRQAFx())
						{
							continue;
						}
					}
					goto IL_04b4;
				}
				goto IL_013a;
				IL_0337:
				if (num6 < num2)
				{
					string value = null;
					Dictionary<string, object> dictionary5 = resumeInfo_0.Etags[num6];
					if (dictionary5 != null && dictionary5.Count > 0)
					{
						value = "~";
					}
					if (!string.IsNullOrEmpty(value))
					{
						goto IL_015d;
					}
					goto IL_01cc;
				}
				if (dictionary2.Count > 0)
				{
					uMDYA3N1Dr(dictionary2, string_1, putExtra_0, resumeInfo_0, dictionary3, dictionary4, length, text);
					foreach (long key in dictionary3.Keys)
					{
						int num7 = (int)key;
						HttpResult httpResult4 = dictionary3[num7];
						if (httpResult4.Code == 612 && File.Exists(putExtra_0.ResumeRecordFile))
						{
							File.Delete(putExtra_0.ResumeRecordFile);
						}
						if (flag)
						{
							int num8 = 0;
							if (!Cla0w9oMT2ACeSRQAFx())
							{
								num8 = num9;
							}
							switch (num8)
							{
							default:
								if (httpResult4.Code == 612)
								{
									stream_0.Seek(0L, SeekOrigin.Begin);
									return ceXYMyHG7m(stream_0, string_0, string_1, putExtra_0, null);
								}
								break;
							}
						}
						if (httpResult4.Code != 200)
						{
							httpResult = httpResult4;
							manualResetEvent.Set();
							return httpResult;
						}
					}
					dictionary2.Clear();
					dictionary3.Clear();
					if (!string.IsNullOrEmpty(putExtra_0.ResumeRecordFile))
					{
						num5 = 1;
						if (VFwp8yoPghG05n0gXDA != null)
						{
							goto IL_04b4;
						}
						goto IL_05fc;
					}
				}
				goto IL_049d;
				IL_0725:
				httpResult.Code = -2;
				httpResult.RefCode = -2;
				httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is aborted, mkfile\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
				break;
				IL_04b4:
				num5 = num10;
				goto IL_05fc;
				IL_01cc:
				while (true)
				{
					uploadControllerAction = putExtra_0.UploadController();
					if (uploadControllerAction != UploadControllerAction.Aborted)
					{
						if (uploadControllerAction == UploadControllerAction.Suspended)
						{
							httpResult.RefCode = 1;
							httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is paused\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
							manualResetEvent.WaitOne(1000);
						}
						else if (uploadControllerAction == UploadControllerAction.Activated)
						{
							break;
						}
						continue;
					}
					httpResult.Code = -2;
					httpResult.RefCode = -2;
					httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is aborted\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
					manualResetEvent.Set();
					return httpResult;
				}
				long offset = num6 * putExtra_0.PartSize;
				stream_0.Seek(offset, SeekOrigin.Begin);
				int num11 = stream_0.Read(array, 0, putExtra_0.PartSize);
				byte[] array2 = new byte[num11];
				Array.Copy(array, array2, num11);
				dictionary2.Add(num6, array2);
				if (dictionary2.Count == putExtra_0.BlockUploadThreads)
				{
					uMDYA3N1Dr(dictionary2, string_1, putExtra_0, resumeInfo_0, dictionary3, dictionary4, length, text);
					foreach (long key2 in dictionary3.Keys)
					{
						int num12 = (int)key2;
						HttpResult httpResult5 = dictionary3[num12];
						if (httpResult5.Code == 612 && File.Exists(putExtra_0.ResumeRecordFile))
						{
							File.Delete(putExtra_0.ResumeRecordFile);
						}
						if (!flag || httpResult5.Code != 612)
						{
							if (httpResult5.Code == 200)
							{
								continue;
							}
							httpResult = httpResult5;
							if (Cla0w9oMT2ACeSRQAFx())
							{
								switch (0)
								{
								}
							}
							manualResetEvent.Set();
							return httpResult;
						}
						stream_0.Seek(0L, SeekOrigin.Begin);
						return ceXYMyHG7m(stream_0, string_0, string_1, putExtra_0, null);
					}
					dictionary2.Clear();
					goto IL_013a;
				}
				goto IL_015d;
				IL_013a:
				dictionary3.Clear();
				if (!string.IsNullOrEmpty(putExtra_0.ResumeRecordFile))
				{
					ResumeHelper.Save(resumeInfo_0, putExtra_0.ResumeRecordFile);
				}
				goto IL_015d;
				continue;
				end_IL_06a9:
				break;
			}
			manualResetEvent.Set();
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] [ResumableUpload] Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				stringBuilder.Append(ex2.Message + " ");
			}
			stringBuilder.AppendLine();
			httpResult.RefCode = 0;
			httpResult.RefText += stringBuilder.ToString();
		}
		if (flag && httpResult.Code == 612)
		{
			stream_0.Seek(0L, SeekOrigin.Begin);
			return ceXYMyHG7m(stream_0, string_0, string_1, putExtra_0, null);
		}
		return httpResult;
	}

	private void uMDYA3N1Dr(Dictionary<long, byte[]> dictionary_0, string string_0, PutExtra putExtra_0, ResumeInfo resumeInfo_0, Dictionary<long, HttpResult> dictionary_1, Dictionary<string, long> dictionary_2, long long_0, string string_1)
	{
		ManualResetEvent[] array = new ManualResetEvent[dictionary_0.Count];
		int num = 0;
		object object_ = new object();
		foreach (long key in dictionary_0.Keys)
		{
			ManualResetEvent manualResetEvent_ = (array[num] = new ManualResetEvent(false));
			num++;
			byte[] byte_ = dictionary_0[key];
			cBEJp2qEsUfo3qp4MSu state = new cBEJp2qEsUfo3qp4MSu(manualResetEvent_, byte_, key, string_0, putExtra_0, resumeInfo_0, dictionary_1, object_, dictionary_2, long_0, string_1);
			ThreadPool.QueueUserWorkItem(r6bYOem0Bk, state);
		}
		try
		{
			WaitHandle[] waitHandles = array;
			WaitHandle.WaitAll(waitHandles);
		}
		catch (Exception)
		{
		}
	}

	private void r6bYOem0Bk(object object_0)
	{
		cBEJp2qEsUfo3qp4MSu cBEJp2qEsUfo3qp4MSu = (cBEJp2qEsUfo3qp4MSu)object_0;
		ManualResetEvent manualResetEvent = cBEJp2qEsUfo3qp4MSu.KJtYf8oC0X();
		Dictionary<long, HttpResult> xQdIbQRUsH = cBEJp2qEsUfo3qp4MSu.XQdIbQRUsH;
		PutExtra putExtra = cBEJp2qEsUfo3qp4MSu.uVJI0iQF3o();
		long num = cBEJp2qEsUfo3qp4MSu.vaxIv9PUqB();
		HttpResult httpResult = new HttpResult();
		UploadControllerAction uploadControllerAction;
		while (true)
		{
			uploadControllerAction = cBEJp2qEsUfo3qp4MSu.uVJI0iQF3o().UploadController();
			if (uploadControllerAction != UploadControllerAction.Suspended)
			{
				break;
			}
			manualResetEvent.WaitOne(1000);
		}
		int num2;
		byte[] array = default(byte[]);
		int num3 = default(int);
		string text = default(string);
		Dictionary<string, long> dictionary = default(Dictionary<string, long>);
		long totalBytes = default(long);
		object obj = default(object);
		if (uploadControllerAction == UploadControllerAction.Aborted)
		{
			manualResetEvent.Set();
			httpResult.Code = -2;
			httpResult.RefCode = -2;
			httpResult.RefText += string.Format("[{0}] [ResumableUpload] Info: upload task is aborted, mkblk {1}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), num);
			num2 = 0;
			if (!Cla0w9oMT2ACeSRQAFx())
			{
				goto IL_00ff;
			}
		}
		else
		{
			array = cBEJp2qEsUfo3qp4MSu.eJ5ItmswZg();
			num3 = array.Length;
			text = cBEJp2qEsUfo3qp4MSu.Aa9Iur68Iq();
			dictionary = cBEJp2qEsUfo3qp4MSu.X3LIqb5jm5();
			totalBytes = cBEJp2qEsUfo3qp4MSu.Y1dIZbT0HY();
			obj = cBEJp2qEsUfo3qp4MSu.Ud3IaNhLUP();
			num2 = 0;
			if (VFwp8yoPghG05n0gXDA == null)
			{
				goto IL_010a;
			}
		}
		switch (num2)
		{
		case 1:
			goto IL_010a;
		}
		goto IL_00ff;
		IL_00ff:
		xQdIbQRUsH.Add(num, httpResult);
		return;
		IL_010a:
		ResumeInfo resumeInfo = cBEJp2qEsUfo3qp4MSu.dV5IE9Rs52();
		try
		{
			string accessKeyFromUpToken = UpToken.GetAccessKeyFromUpToken(text);
			string bucketFromUpToken = UpToken.GetBucketFromUpToken(text);
			int num4 = 1;
			if (!Cla0w9oMT2ACeSRQAFx())
			{
				int num5 = default(int);
				num4 = num5;
			}
			string text3 = default(string);
			uint crc = default(uint);
			uint num7 = default(uint);
			int num8 = default(int);
			while (true)
			{
				switch (num4)
				{
				case 1:
				{
					if (accessKeyFromUpToken == null || bucketFromUpToken == null)
					{
						break;
					}
					string text2 = xDcYi0unlH.UpHost(accessKeyFromUpToken, bucketFromUpToken);
					text3 = "";
					if (!(putExtra.Version == "v1"))
					{
						if (!(putExtra.Version == "v2"))
						{
							throw new Exception("Invalid Version, only supports v1 / v2");
						}
						text3 = $"{text2}/buckets/{bucketFromUpToken}/objects/{cBEJp2qEsUfo3qp4MSu.Q99Ientask()}/uploads/{resumeInfo.UploadId}/{num + 1L}";
						num4 = 0;
						if (!Cla0w9oMT2ACeSRQAFx())
						{
							continue;
						}
					}
					else
					{
						text3 = $"{text2}/mkblk/{num3}";
					}
					goto default;
				}
				default:
				{
					string text4 = $"UpToken {text}";
					using (MemoryStream memoryStream = new MemoryStream(array, 0, num3))
					{
						byte[] data = memoryStream.ToArray();
						if (putExtra.Version == "v1")
						{
							httpResult = mjdY3ijBx4.PostData(text3, data, text4);
							goto IL_02a1;
						}
						goto IL_032d;
						IL_032d:
						int num6;
						if (putExtra.Version == "v2")
						{
							num6 = 3;
							if (VFwp8yoPghG05n0gXDA != null)
							{
								goto IL_0312;
							}
							goto IL_0314;
						}
						throw new Exception("Invalid Version, only supports v1 / v2");
						IL_02a1:
						if (httpResult.Code == 200)
						{
							if (!(putExtra.Version == "v1"))
							{
								if (!(putExtra.Version == "v2"))
								{
									goto IL_0468;
								}
								goto IL_0480;
							}
							ResumeContext resumeContext = JsonConvert.DeserializeObject<ResumeContext>(httpResult.Text);
							if (resumeContext.Crc32 != 0)
							{
								crc = resumeContext.Crc32;
								num7 = CRC32.CheckSumSlice(array, 0, num3);
								if (crc != num7)
								{
									httpResult.RefCode = 3;
									num6 = 1;
									if (!Cla0w9oMT2ACeSRQAFx())
									{
										goto IL_0312;
									}
									goto IL_0314;
								}
								resumeInfo.Contexts[num] = resumeContext.Ctx;
								resumeInfo.ContextsExpiredAt[num] = resumeContext.ExpiredAt;
								lock (obj)
								{
									dictionary["UploadProgress"] += num3;
								}
								putExtra.ProgressHandler(dictionary["UploadProgress"], totalBytes);
							}
							else
							{
								if (!(putExtra.Version == "v2"))
								{
									throw new Exception("Invalid Version, only supports v1 / v2");
								}
								httpResult.RefText += string.Format("[{0}] JSON Decode Error: text = {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), httpResult.Text);
								httpResult.RefCode = 3;
							}
						}
						else
						{
							httpResult.RefCode = 3;
						}
						goto end_IL_0218;
						IL_0480:
						Dictionary<string, string> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(httpResult.Text);
						string text5 = LabMD5.GenerateMD5(array);
						if (text5 != dictionary2["md5"])
						{
							httpResult.RefCode = 3;
							httpResult.RefText += string.Format(" md5: remote={0}, local={1}\n", dictionary2["md5"], text5);
							goto end_IL_01d7;
						}
						Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
						dictionary3.Add("etag", dictionary2["etag"]);
						dictionary3.Add("partNumber", num + 1L);
						resumeInfo.Etags[num] = dictionary3;
						lock (obj)
						{
							dictionary["UploadProgress"] += num3;
							resumeInfo.Uploaded += num3;
						}
						putExtra.ProgressHandler(dictionary["UploadProgress"], totalBytes);
						goto end_IL_0218;
						IL_0314:
						switch (num6)
						{
						case 3:
							break;
						default:
							goto IL_032d;
						case 1:
							httpResult.RefText += $" CRC32: remote={crc}, local={num7}\n";
							goto end_IL_0218;
						case 2:
							goto IL_0468;
						case 4:
							goto IL_0480;
						}
						Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
						dictionary4.Add("Authorization", text4);
						string value = LabMD5.GenerateMD5(array);
						dictionary4.Add("Content-MD5", value);
						httpResult = mjdY3ijBx4.PutDataWithHeaders(text3, data, dictionary4);
						goto IL_02a1;
						IL_0312:
						num6 = num8;
						goto IL_0314;
						IL_0468:
						throw new Exception("Invalid Version, only supports v1 / v2");
						end_IL_0218:;
					}
					goto end_IL_01d7;
				}
				}
				httpResult = HttpResult.InvalidToken;
				manualResetEvent.Set();
				return;
				continue;
				end_IL_01d7:
				break;
			}
		}
		catch (Exception ex)
		{
        Exception ex2 = default;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] mkblk Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num9 = 0;
			if (VFwp8yoPghG05n0gXDA != null)
			{
				goto IL_0608;
			}
			goto IL_061b;
			IL_0608:
			ex2 = ex;
			num9 = 1;
			if (VFwp8yoPghG05n0gXDA != null)
			{
				int num10 = default(int);
				num9 = num10;
			}
			goto IL_061b;
			IL_061b:
			switch (num9)
			{
			case 1:
				while (ex2 != null)
				{
					stringBuilder.Append(ex2.Message + " ");
					ex2 = ex2.InnerException;
				}
				stringBuilder.AppendLine();
				if (ex is lkv3bMqsFwsT98BDoV0)
				{
					lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV = (lkv3bMqsFwsT98BDoV0)ex;
					httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
					httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
					httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
					httpResult.RefText += stringBuilder.ToString();
				}
				else
				{
					httpResult.RefCode = 0;
					httpResult.RefText += stringBuilder.ToString();
				}
				goto end_IL_05d2;
			}
			goto IL_0608;
			end_IL_05d2:;
		}
		xQdIbQRUsH.Add(num, httpResult);
		manualResetEvent.Set();
	}

	private HttpResult aF5YFWC9dn(string string_0, long long_0, string string_1, string string_2, PutExtra putExtra_0, string[] string_3)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string text = "fname";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			if (!string.IsNullOrEmpty(string_0))
			{
				text = $"/fname/{Base64.UrlSafeBase64Encode(string_0)}";
			}
			if (!string.IsNullOrEmpty(putExtra_0.MimeType))
			{
				text2 = $"/mimeType/{Base64.UrlSafeBase64Encode(putExtra_0.MimeType)}";
			}
			int num2 = default(int);
			string accessKeyFromUpToken = default(string);
			string bucketFromUpToken = default(string);
			while (true)
			{
				if (string.IsNullOrEmpty(string_1))
				{
					goto IL_006b;
				}
				text3 = $"/key/{Base64.UrlSafeBase64Encode(string_1)}";
				int num = 1;
				if (VFwp8yoPghG05n0gXDA != null)
				{
					num = num2;
				}
				goto IL_0130;
				IL_006b:
				if (putExtra_0.Params != null && putExtra_0.Params.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (KeyValuePair<string, string> item in putExtra_0.Params)
					{
						string key = item.Key;
						string value = item.Value;
						if (key.StartsWith("x:") && !string.IsNullOrEmpty(value))
						{
							stringBuilder.AppendFormat("/{0}/{1}", key, Base64.UrlSafeBase64Encode(value));
						}
					}
					text4 = stringBuilder.ToString();
				}
				accessKeyFromUpToken = UpToken.GetAccessKeyFromUpToken(string_2);
				bucketFromUpToken = UpToken.GetBucketFromUpToken(string_2);
				num = 0;
				if (!Cla0w9oMT2ACeSRQAFx())
				{
					break;
				}
				goto IL_0130;
				IL_0130:
				switch (num)
				{
				case 1:
					break;
				case 2:
					continue;
				default:
					goto end_IL_0168;
				}
				goto IL_006b;
				continue;
				end_IL_0168:
				break;
			}
			if (accessKeyFromUpToken == null || bucketFromUpToken == null)
			{
				return HttpResult.InvalidToken;
			}
			string text5 = xDcYi0unlH.UpHost(accessKeyFromUpToken, bucketFromUpToken);
			string url = $"{text5}/mkfile/{long_0}{text2}{text}{text3}{text4}";
			string data = string.Join(",", string_3);
			string token = $"UpToken {string_2}";
			httpResult = mjdY3ijBx4.PostText(url, data, token);
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendFormat("[{0}] mkfile Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception current = ex; current != null; current = current.InnerException)
			{
				stringBuilder2.Append(current.Message + " ");
			}
			stringBuilder2.AppendLine();
			if (ex is lkv3bMqsFwsT98BDoV0)
			{
				lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV = (lkv3bMqsFwsT98BDoV0)ex;
				httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
				httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
				httpResult.RefText += stringBuilder2.ToString();
			}
			else
			{
				httpResult.RefCode = 0;
				httpResult.RefText += stringBuilder2.ToString();
			}
		}
		return httpResult;
	}

	private HttpResult KkqYUBgDTm(string string_0, string string_1)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string accessKeyFromUpToken = UpToken.GetAccessKeyFromUpToken(string_1);
			string bucketFromUpToken = UpToken.GetBucketFromUpToken(string_1);
			if (accessKeyFromUpToken == null || bucketFromUpToken == null)
			{
				return HttpResult.InvalidToken;
			}
			string arg = xDcYi0unlH.UpHost(accessKeyFromUpToken, bucketFromUpToken);
			int num = 0;
			if (VFwp8yoPghG05n0gXDA != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				string url = $"{arg}/buckets/{bucketFromUpToken}/objects/{string_0}/uploads";
				string token = $"UpToken {string_1}";
				httpResult = mjdY3ijBx4.PostText(url, null, token);
				break;
			}
			}
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] mkfile Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num3 = 1;
			if (VFwp8yoPghG05n0gXDA == null)
			{
				goto IL_00c2;
			}
			goto IL_0118;
			IL_00c2:
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				stringBuilder.Append(ex2.Message + " ");
			}
			stringBuilder.AppendLine();
			if (!(ex is lkv3bMqsFwsT98BDoV0))
			{
				httpResult.RefCode = 0;
				num3 = 0;
				if (!Cla0w9oMT2ACeSRQAFx())
				{
					int num4 = default(int);
					num3 = num4;
				}
				goto IL_0118;
			}
			lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV = (lkv3bMqsFwsT98BDoV0)ex;
			httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			httpResult.RefText += stringBuilder.ToString();
			goto end_IL_008c;
			IL_0118:
			switch (num3)
			{
			case 1:
				break;
			default:
				httpResult.RefText += stringBuilder.ToString();
				goto end_IL_008c;
			}
			goto IL_00c2;
			end_IL_008c:;
		}
		return httpResult;
	}

	private HttpResult b1yYlWLW0a(string string_0, ResumeInfo resumeInfo_0, string string_1, string string_2, PutExtra putExtra_0, string string_3)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				goto IL_002c;
			}
			string_0 = "fname";
			int num = 0;
			if (!Cla0w9oMT2ACeSRQAFx())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0135;
			IL_0135:
			switch (num)
			{
			case 1:
				goto end_IL_0006;
			}
			goto IL_002c;
			IL_002c:
			if (string.IsNullOrEmpty(putExtra_0.MimeType))
			{
				putExtra_0.MimeType = "";
			}
			if (string.IsNullOrEmpty(string_1))
			{
				string_1 = "";
			}
			string accessKeyFromUpToken = UpToken.GetAccessKeyFromUpToken(string_2);
			string bucketFromUpToken = UpToken.GetBucketFromUpToken(string_2);
			if (accessKeyFromUpToken == null || bucketFromUpToken == null)
			{
				return HttpResult.InvalidToken;
			}
			string text = xDcYi0unlH.UpHost(accessKeyFromUpToken, bucketFromUpToken);
			string token = $"UpToken {string_2}";
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("fname", string_0);
			dictionary.Add("mimeType", putExtra_0.MimeType);
			dictionary.Add("customVars", putExtra_0.Params);
			dictionary.Add("parts", resumeInfo_0.Etags);
			string url = $"{text}/buckets/{bucketFromUpToken}/objects/{string_3}/uploads/{resumeInfo_0.UploadId}";
			string data = JsonConvert.SerializeObject(dictionary);
			httpResult = mjdY3ijBx4.PostJson(url, data, token);
			num = 0;
			if (!Cla0w9oMT2ACeSRQAFx())
			{
				goto IL_0135;
			}
			end_IL_0006:;
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] completeParts Error: ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			Exception ex2 = ex;
			while (true)
			{
				if (ex2 == null)
				{
					stringBuilder.AppendLine();
					if (ex is lkv3bMqsFwsT98BDoV0)
					{
						lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV = (lkv3bMqsFwsT98BDoV0)ex;
						httpResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
						httpResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
						httpResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
						httpResult.RefText += stringBuilder.ToString();
						if (!Cla0w9oMT2ACeSRQAFx())
						{
							switch (0)
							{
							case 1:
								goto IL_0199;
							case 0:
								break;
							}
						}
					}
					else
					{
						httpResult.RefCode = 0;
						httpResult.RefText += stringBuilder.ToString();
					}
					break;
				}
				goto IL_0199;
				IL_0199:
				stringBuilder.Append(ex2.Message + " ");
				ex2 = ex2.InnerException;
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

	internal static bool Cla0w9oMT2ACeSRQAFx()
	{
		return VFwp8yoPghG05n0gXDA == null;
	}
}
