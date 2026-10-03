using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using log4net;
using Quicker.Utilities;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;
using Windows.Storage;

namespace O5blBdM6bCRI1gbI3U2;

internal class iah68iMf4KvhT7ULCsJ
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec r6W2whuYiPU;

		public static Func<XElement, bool> LOj2we2yiSU;

		public static Func<XElement, bool> Jxn2wYtDp1L;

		internal static _003C_003Ec iHaBT0ynR5Tgq0xCHkGH;

		static _003C_003Ec()
		{
			r6W2whuYiPU = new _003C_003Ec();
		}

		internal bool cXL2wZNmtgH(XElement e)
		{
			return e.Name.LocalName == "VisualElements";
		}

		internal bool qsV2w9iE0X7(XElement e)
		{
			return e.Name.LocalName == "DefaultTile";
		}

		internal static bool NHe8hAyngWTnRarx2f6L()
		{
			return iHaBT0ynR5Tgq0xCHkGH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string sG82wWRZ8xj;

		internal static _003C_003Ec__DisplayClass3_0 OphbXAynMAiP4wZSUlNs;

		internal bool Tf02wI2yEN8(XElement a)
		{
			return (string)a.Attribute("Id") == sG82wWRZ8xj;
		}

		internal static bool G64H1oynUE96iJwggnkw()
		{
			return OphbXAynMAiP4wZSUlNs == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInit_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private ConcurrentDictionary<string, string> _003Cdict_003E5__2;

		private string[] _003ClogoAttributes_003E5__3;

		private string[] _003CpreferedIconFilesEnds_003E5__4;

		private IEnumerator<Package> _003C_003E7__wrap4;

		private Package _003Cpackage_003E5__6;

		private List<AppListEntry> _003CappListEntries_003E5__7;

		private StorageFolder _003CinstalledLocation_003E5__8;

		private TaskAwaiter<IReadOnlyList<AppListEntry>> _003C_003Eu__1;

		private TaskAwaiter<StorageFile> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		private static object onTFBOyn6Re9DEVJgDuV;

		private void MoveNext()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			try
			{
				if ((uint)num > 2u)
				{
					_003Cdict_003E5__2 = new ConcurrentDictionary<string, string>();
					IEnumerable<Package> enumerable = new PackageManager().FindPackagesForUser(string.Empty);
					_003ClogoAttributes_003E5__3 = new string[4] { "Square44x44Logo", "Square71x71Logo", "Square150x150Logo", "Logo" };
					_003CpreferedIconFilesEnds_003E5__4 = new string[11]
					{
						".altform-unplated.png", ".targetsize-48.png", ".targetsize-48_altform-unplated.png", ".targetsize-64.png", ".targetsize-64_altform-unplated.png", ".png", ".scale-200.png", ".scale-150.png", ".scale-100.png", ".targetsize-256.png",
						".targetsize-256_altform-unplated.png"
					};
					_003C_003E7__wrap4 = enumerable.GetEnumerator();
					if (onTFBOyn6Re9DEVJgDuV == null)
					{
						switch (0)
						{
						}
					}
				}
				try
				{
					TaskAwaiter<IReadOnlyList<AppListEntry>> awaiter2 = default(TaskAwaiter<IReadOnlyList<AppListEntry>>);
					int num2;
					TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
					XDocument xDocument;
					XNamespace xNamespace;
					XNamespace namespaceOfPrefix;
					IEnumerable<XElement> source;
					List<AppListEntry>.Enumerator enumerator;
					IReadOnlyList<AppListEntry> result2;
					switch (num)
					{
					case 0:
						awaiter2 = _003C_003Eu__1;
						num2 = 0;
						if (!nlPmCsyntKUFcTo2DrdR())
						{
							goto IL_0564;
						}
						goto IL_0575;
					case 2:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0130;
					case 1:
					{
						StorageFile result;
						try
						{
							TaskAwaiter<StorageFile> awaiter3;
							if (num != 1)
							{
								_003CinstalledLocation_003E5__8 = _003Cpackage_003E5__6.InstalledLocation;
								awaiter3 = _003CinstalledLocation_003E5__8.GetFileAsync("AppxManifest.xml").GetAwaiter<StorageFile>();
								if (!awaiter3.IsCompleted)
								{
									num = 1;
									_003C_003E1__state = 1;
									_003C_003Eu__2 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<StorageFile>);
								num = -1;
								_003C_003E1__state = -1;
							}
							result = awaiter3.GetResult();
							int num7 = 0;
							if (!nlPmCsyntKUFcTo2DrdR())
							{
								int num8 = default(int);
								num7 = num8;
							}
							switch (num7)
							{
							}
						}
						catch (FileNotFoundException)
						{
							goto default;
						}
						catch (Exception)
						{
							goto default;
						}
						awaiter = FileIO.ReadTextAsync((IStorageFile)(object)result).GetAwaiter<string>();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0130;
					}
					default:
						{
							if (_003C_003E7__wrap4.MoveNext())
							{
								_003Cpackage_003E5__6 = _003C_003E7__wrap4.Current;
								awaiter2 = _003Cpackage_003E5__6.GetAppListEntriesAsync().GetAwaiter<IReadOnlyList<AppListEntry>>();
								if (!awaiter2.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0492;
							}
							num2 = 1;
							if (onTFBOyn6Re9DEVJgDuV == null)
							{
								break;
							}
							goto IL_0564;
						}
						IL_0564:
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0575;
						case 1:
							goto end_IL_00e2;
						}
						goto IL_0130;
						IL_0575:
						_003C_003Eu__1 = default(TaskAwaiter<IReadOnlyList<AppListEntry>>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0492;
						IL_0130:
						xDocument = XDocument.Parse(awaiter.GetResult());
						xNamespace = xDocument.Root.Name.Namespace;
						namespaceOfPrefix = xDocument.Root.GetNamespaceOfPrefix("uap");
						source = xDocument.Descendants(xNamespace + "Application");
						enumerator = _003CappListEntries_003E5__7.GetEnumerator();
						try
						{
							string text2 = default(string);
							bool flag = default(bool);
							string[] files = default(string[]);
							string text4 = default(string);
							string[] array2 = default(string[]);
							int num4 = default(int);
							int num6 = default(int);
							string directoryName = default(string);
							string fileNameWithoutExtension = default(string);
							while (enumerator.MoveNext())
							{
								while (true)
								{
									IL_0186:
									AppListEntry current = enumerator.Current;
									_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
									string appUserModelId = current.AppUserModelId;
									_003C_003Ec__DisplayClass3_.sG82wWRZ8xj = ((!appUserModelId.Contains('!')) ? appUserModelId : appUserModelId.Split('!').Last());
									XElement xElement = source.FirstOrDefault(_003C_003Ec__DisplayClass3_.Tf02wI2yEN8);
									if (xElement == null)
									{
										break;
									}
									XElement xElement2 = xElement.Descendants().FirstOrDefault(_003C_003Ec.LOj2we2yiSU ?? (_003C_003Ec.LOj2we2yiSU = _003C_003Ec.r6W2whuYiPU.cXL2wZNmtgH));
									if (xElement2 == null)
									{
										break;
									}
									string text = null;
									XElement xElement3 = xElement2.Element(namespaceOfPrefix + "DefaultTile");
									if (xElement3 == null)
									{
										xElement3 = xElement2.Descendants().FirstOrDefault(_003C_003Ec.Jxn2wYtDp1L ?? (_003C_003Ec.Jxn2wYtDp1L = _003C_003Ec.r6W2whuYiPU.qsV2w9iE0X7));
									}
									string[] array = _003ClogoAttributes_003E5__3;
									int num3 = 0;
									while (true)
									{
										if (num3 < array.Length)
										{
											text2 = array[num3];
											if (xElement3 != null)
											{
												string text3 = (string)xElement3.Attribute(text2);
												if (!string.IsNullOrEmpty(text3))
												{
													text = text3;
													goto IL_037c;
												}
											}
											goto IL_03d8;
										}
										goto IL_037c;
										IL_0415:
										if (!flag)
										{
											_003Cdict_003E5__2[appUserModelId] = files[0];
										}
										break;
										IL_0328:
										if (num3 < array.Length)
										{
											text4 = array[num3];
											array2 = files;
											num4 = 0;
											goto IL_0313;
										}
										goto IL_0415;
										IL_0354:
										int num5 = num6;
										goto IL_0356;
										IL_03d8:
										string text5 = (string)xElement2.Attribute(text2);
										if (string.IsNullOrEmpty(text5))
										{
											num3++;
											num5 = 3;
											if (onTFBOyn6Re9DEVJgDuV != null)
											{
												goto IL_0354;
											}
											goto IL_0356;
										}
										text = text5;
										goto IL_037c;
										IL_0313:
										if (num4 >= array2.Length)
										{
											goto IL_031b;
										}
										string text6 = array2[num4];
										if (!text6.Equals(Path.Combine(directoryName, fileNameWithoutExtension + text4), StringComparison.OrdinalIgnoreCase))
										{
											goto IL_030d;
										}
										_003Cdict_003E5__2[appUserModelId] = text6;
										flag = true;
										num5 = 1;
										if (onTFBOyn6Re9DEVJgDuV != null)
										{
											goto IL_0354;
										}
										goto IL_0356;
										IL_037c:
										if (string.IsNullOrEmpty(text))
										{
											break;
										}
										string path = Path.Combine(_003CinstalledLocation_003E5__8.Path, text);
										directoryName = Path.GetDirectoryName(path);
										Path.GetFileName(path);
										fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
										files = Directory.GetFiles(directoryName, fileNameWithoutExtension + "*" + Path.GetExtension(path), SearchOption.TopDirectoryOnly);
										goto IL_02c4;
										IL_030d:
										num4++;
										goto IL_0313;
										IL_031b:
										if (!flag)
										{
											num3++;
											goto IL_0328;
										}
										goto IL_0415;
										IL_0356:
										switch (num5)
										{
										case 5:
											goto IL_02c4;
										case 2:
											goto IL_030d;
										case 1:
											goto IL_031b;
										case 4:
											goto IL_03d8;
										case 3:
											continue;
										}
										goto IL_0186;
										IL_02c4:
										if (files.Length == 0)
										{
											break;
										}
										flag = false;
										array = _003CpreferedIconFilesEnds_003E5__4;
										num3 = 0;
										goto IL_0328;
									}
									break;
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						_003CappListEntries_003E5__7 = null;
						_003CinstalledLocation_003E5__8 = null;
						_003Cpackage_003E5__6 = null;
						goto default;
						IL_0492:
						result2 = awaiter2.GetResult();
						_003CappListEntries_003E5__7 = result2.ToList();
						if (_003CappListEntries_003E5__7.Count != 0)
						{
							goto case 1;
						}
						goto default;
						end_IL_00e2:
						break;
					}
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap4 != null)
					{
						_003C_003E7__wrap4.Dispose();
					}
				}
				_003C_003E7__wrap4 = null;
				pnrLoMveXr2 = _003Cdict_003E5__2;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdict_003E5__2 = null;
				_003ClogoAttributes_003E5__3 = null;
				_003CpreferedIconFilesEnds_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdict_003E5__2 = null;
			_003ClogoAttributes_003E5__3 = null;
			_003CpreferedIconFilesEnds_003E5__4 = null;
			_003C_003Et__builder.SetResult();
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

		internal static bool nlPmCsyntKUFcTo2DrdR()
		{
			return onTFBOyn6Re9DEVJgDuV == null;
		}
	}

	private static IDictionary<string, string> pnrLoMveXr2;

	private static readonly ILog owhLoAAaJ7a;

	internal static bool C5gLoObya6C;

	internal static iah68iMf4KvhT7ULCsJ pF2bxpFYd3jcGyguXrsr;

	private static string ey6LoDcfUYV(XmlDocument xmlDocument_0, string string_0)
	{
		return xmlDocument_0.DocumentElement.GetAttribute("xmlns:" + string_0);
	}

	[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
	public static Task jFoLodGY501()
	{
		_003CInit_003Ed__3 stateMachine = default(_003CInit_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static string DpvLoo2xNQd(string string_0)
	{
		if (pnrLoMveXr2 != null && pnrLoMveXr2.TryGetValue(string_0, out var value))
		{
			return value;
		}
		try
		{
			try
			{
				string text = HRbLoTbT4p1(string_0);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			catch
			{
			}
			string appIcon = UWPHelper2.GetAppIcon(string_0);
			if (File.Exists(appIcon))
			{
				return appIcon;
			}
			return null;
		}
		catch (Exception ex)
		{
			owhLoAAaJ7a.Warn("获取" + string_0 + "图标出错:" + ex.Message, ex);
			return null;
		}
	}

	private static string HRbLoTbT4p1(string string_0)
	{
		if (C5gLoObya6C)
		{
			AppInfo fromAppUserModelId = AppInfo.GetFromAppUserModelId(string_0);
			if (fromAppUserModelId != null && string_0.EndsWith("!App"))
			{
				if (!oVxUsyFYOLjFpP4cOaql())
				{
					switch (0)
					{
					}
				}
				Uri logo = fromAppUserModelId.Package.Logo;
				string localPath = logo.LocalPath;
				string text = Path.ChangeExtension(localPath, ".altform-unplated.png");
				if (File.Exists(text))
				{
					return text;
				}
				if (File.Exists(localPath))
				{
					return localPath;
				}
				owhLoAAaJ7a.Warn($"UWP图标不存在：{string_0}, Logo:{logo}");
			}
		}
		return null;
	}

	static iah68iMf4KvhT7ULCsJ()
	{
		pnrLoMveXr2 = null;
		owhLoAAaJ7a = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		C5gLoObya6C = ApiInformation.IsMethodPresent("Windows.ApplicationModel.AppInfo", "GetFromAppUserModelId");
	}

	internal static bool oVxUsyFYOLjFpP4cOaql()
	{
		return pF2bxpFYd3jcGyguXrsr == null;
	}
}
