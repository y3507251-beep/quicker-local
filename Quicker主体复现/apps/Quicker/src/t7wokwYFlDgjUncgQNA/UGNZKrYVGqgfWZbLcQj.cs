using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using HandyControl.Data;
using HL.Manager;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using MdXaml.Highlighting;
using Quicker;
using Quicker.Utilities.Win32;

namespace t7wokwYFlDgjUncgQNA;

internal static class UGNZKrYVGqgfWZbLcQj
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static MarkdownCustomHighlighting.GetHighlightingFunc cfASlO5x9Bx;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nqLSllGiHq7;

		public static Func<IHighlightingDefinition, string> qW9SlircQyS;

		public static Func<string, string> JPXSl3MV6qC;

		private static _003C_003Ec GxQ7cHyWlWfWM0iohG70;

		static _003C_003Ec()
		{
			nqLSllGiHq7 = new _003C_003Ec();
		}

		internal string mn9SlFXgI4K(IHighlightingDefinition x)
		{
			return x.Name;
		}

		internal string jyBSlUuNhUB(string x)
		{
			return x;
		}

		internal static bool SwkTCByWZCnvBMFtR3tm()
		{
			return GxQ7cHyWlWfWM0iohG70 == null;
		}
	}

	private static IHighlightingDefinition OU3LxZbOkUs;

	private static IHighlightingDefinition VOwLx9f4Q7y;

	internal static object NyJlJqFuZjkSZvQFoWwZ;

	public static ObservableCollection<string> HighlightingDefinitionNames => new ObservableCollection<string>(ThemedHighlightingManager.Instance.HighlightingDefinitions.Select(_003C_003Ec.qW9SlircQyS ?? (_003C_003Ec.qW9SlircQyS = _003C_003Ec.nqLSllGiHq7.mn9SlFXgI4K)).OrderBy(_003C_003Ec.JPXSl3MV6qC ?? (_003C_003Ec.JPXSl3MV6qC = _003C_003Ec.nqLSllGiHq7.jyBSlUuNhUB)));

	public static IHighlightingDefinition QuickerExpression => ThemedHighlightingManager.Instance.GetDefinition("QuickerExpression");

	public static IHighlightingDefinition QuickerInterpolation => ThemedHighlightingManager.Instance.GetDefinition("QuickerInterpolation");

	static UGNZKrYVGqgfWZbLcQj()
	{
		kPyLx8L4sWe();
	}

	internal static IHighlightingDefinition nZcLxPqL9DV(string string_0)
	{
		if (string_0.IsValidFilePath() && File.Exists(string_0))
		{
			string_0 = File.ReadAllText(string_0);
		}
		if (!string_0.StartsWith("<"))
		{
			throw new Exception("不是合法的高亮语法定义。");
		}
		using XmlReader reader = XmlReader.Create(new MemoryStream(Encoding.Unicode.GetBytes(string_0)));
		return ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(reader, HighlightingManager.Instance);
	}

	public static void hP3LxEbr7j3(bool bool_0)
	{
		if (bool_0)
		{
			ThemedHighlightingManager.Instance.SetCurrentTheme("VS2019_Dark");
		}
		else
		{
			ThemedHighlightingManager.Instance.SetCurrentTheme("Light");
		}
	}

	public static IHighlightingDefinition fvHLxy2feEY(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		return ThemedHighlightingManager.Instance.GetDefinition(string_0);
	}

	[SpecialName]
	private static bool bG7LxchdOqs()
	{
		return App.Current.Brm1CjxFTF() == SkinType.Dark;
	}

	public static void kPyLx8L4sWe()
	{
		MarkdownCustomHighlighting.HighlightingResolver = _003C_003EO.cfASlO5x9Bx ?? (_003C_003EO.cfASlO5x9Bx = oVJLxamVY27);
	}

	private static IHighlightingDefinition oVJLxamVY27(string string_0)
	{
		while (true)
		{
			IHighlightingDefinition definitionByExtension = ThemedHighlightingManager.Instance.GetDefinitionByExtension("." + string_0);
			while (true)
			{
				IL_00c2:
				string name;
				string text;
				char c;
				if (definitionByExtension == null)
				{
					name = string_0;
					text = string_0.ToLower();
					if (text != null)
					{
						switch (text.Length)
						{
						case 4:
							break;
						case 14:
							goto IL_00f1;
						case 2:
							goto IL_0106;
						case 6:
							goto IL_0183;
						case 8:
							if (text == "markdown")
							{
								name = "MarkDown";
							}
							goto IL_0229;
						case 10:
							goto IL_01ed;
						default:
							goto IL_0229;
						}
						c = text[0];
						while (true)
						{
							if (c != 'h')
							{
								if (c != 'p')
								{
									if (c != 't' || !(text == "tsql"))
									{
										break;
									}
									name = "TSQL";
									if (NyJlJqFuZjkSZvQFoWwZ != null)
									{
										switch (1)
										{
										case 7:
											break;
										case 2:
											goto IL_00c2;
										case 3:
											goto end_IL_00c2;
										default:
											goto IL_01b4;
										case 6:
											goto IL_020e;
										case 1:
										case 4:
										case 5:
											goto end_IL_00b8;
										}
										continue;
									}
									break;
								}
								if (!(text == "posh"))
								{
									break;
								}
								goto IL_020e;
							}
							if (text == "html")
							{
								name = "HTML";
							}
							break;
							continue;
							end_IL_00b8:
							break;
						}
					}
					goto IL_0229;
				}
				return definitionByExtension;
				IL_0183:
				c = text[0];
				if (c != 'c')
				{
					if (c == 'm')
					{
						goto IL_01b4;
					}
					if (c == 'p' && text == "python")
					{
						name = "Python";
					}
				}
				else if (text == "csharp")
				{
					goto IL_01d0;
				}
				goto IL_0229;
				IL_0229:
				return ThemedHighlightingManager.Instance.GetDefinition(name);
				IL_01d0:
				name = "C#";
				goto IL_0229;
				IL_01ed:
				c = text[0];
				if (c != 'j')
				{
					if (c == 'p' && text == "powershell")
					{
						goto IL_020e;
					}
				}
				else if (text == "javascript")
				{
					name = "JavaScript";
				}
				goto IL_0229;
				IL_01b4:
				if (text == "msshel")
				{
					goto IL_020e;
				}
				goto IL_0229;
				IL_00f1:
				if (text == "microsoftshell")
				{
					goto IL_020e;
				}
				goto IL_0229;
				IL_0106:
				c = text[0];
				if (c != 'c')
				{
					if (c == 'q' && text == "qk")
					{
						name = "QuickerExpression";
					}
				}
				else if (text == "c#")
				{
					goto IL_01d0;
				}
				goto IL_0229;
				IL_020e:
				name = "PowerShell";
				goto IL_0229;
				continue;
				end_IL_00c2:
				break;
			}
		}
	}

	internal static void z4G70dFu8tFZh61g4lqP()
	{
	}

	internal static bool Hv6H2ZFu5n3wCoE1M4S3()
	{
		return NyJlJqFuZjkSZvQFoWwZ == null;
	}
}
