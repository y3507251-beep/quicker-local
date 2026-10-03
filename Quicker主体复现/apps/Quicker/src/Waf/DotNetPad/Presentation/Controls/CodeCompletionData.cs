using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using CodeCompletionServer.Entities;
using f58S7HAPjJ2xCDtiDo7;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;

namespace Waf.DotNetPad.Presentation.Controls;

public class CodeCompletionData : ICompletionData
{
	private readonly Lazy<object> n0uRgysQG5;

	private readonly Func<Task<ItemDescriptionResult>> IFcRL8BVMu;

	private readonly string[] dgYRvSaLDK;

	private readonly Lazy<ImageSource?> NmMRSPABXi;

	[CompilerGenerated]
	private double gidR2eG7Wv;

	[CompilerGenerated]
	private readonly string xuMRuFc3pO;

	internal static CodeCompletionData jXe1qNOT93ehjgld08Z;

	public double Priority
	{
		[CompilerGenerated]
		get
		{
			return gidR2eG7Wv;
		}
		[CompilerGenerated]
		set
		{
			gidR2eG7Wv = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return xuMRuFc3pO;
		}
	}

	public object Description => n0uRgysQG5.Value;

	public object Content => Text;

	public ImageSource? Image => NmMRSPABXi.Value;

	public CodeCompletionData(string text, string[] tags, Func<Task<ItemDescriptionResult>> getDescriptionFunc)
	{
		xuMRuFc3pO = text;
		IFcRL8BVMu = getDescriptionFunc;
		n0uRgysQG5 = new Lazy<object>(c8c7zHRT5S);
		dgYRvSaLDK = tags;
		NmMRSPABXi = new Lazy<ImageSource>(eTYRw4RVig);
	}

	public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
	{
		textArea.Document.Replace(completionSegment, Text);
	}

	private object c8c7zHRT5S()
	{
		return new uKb4poA9BfumB0ArUqj(IFcRL8BVMu());
	}

	private ImageSource? eTYRw4RVig()
	{
		string text = dgYRvSaLDK?.FirstOrDefault();
		if (text != null)
		{
			char c = default(char);
			int num;
			switch (text.Length)
			{
			case 4:
				if (text == "Enum")
				{
					return uNLRtMfI0A("EnumImageSource");
				}
				break;
			case 5:
				switch (text[0])
				{
				case 'L':
					if (!(text == "Local"))
					{
						break;
					}
					goto IL_00fb;
				case 'C':
					if (text == "Class")
					{
						return uNLRtMfI0A("ClassImageSource");
					}
					break;
				case 'E':
					if (text == "Event")
					{
						return uNLRtMfI0A("EventImageSource");
					}
					break;
				case 'F':
					{
						if (!(text == "Field"))
						{
							break;
						}
						goto IL_00fb;
					}
					IL_00fb:
					return uNLRtMfI0A("FieldImageSource");
				}
				break;
			case 6:
				c = text[1];
				num = 0;
				if (jXe1qNOT93ehjgld08Z == null)
				{
					goto IL_0215;
				}
				goto IL_0232;
			case 7:
				if (text == "Keyword")
				{
					return uNLRtMfI0A("KeywordImageSource");
				}
				break;
			case 8:
				switch (text[0])
				{
				case 'P':
					if (text == "Property")
					{
						return uNLRtMfI0A("PropertyImageSource");
					}
					break;
				case 'D':
					if (text == "Delegate")
					{
						return uNLRtMfI0A("DelegateImageSource");
					}
					break;
				case 'C':
					if (text == "Constant")
					{
						return uNLRtMfI0A("ConstantImageSource");
					}
					break;
				}
				break;
			case 9:
				c = text[0];
				if (c != 'I')
				{
					goto IL_0279;
				}
				if (text == "Interface")
				{
					return uNLRtMfI0A("InterfaceImageSource");
				}
				break;
			case 10:
				if (text == "EnumMember")
				{
					return uNLRtMfI0A("EnumItemImageSource");
				}
				break;
			case 15:
				{
					if (!(text == "ExtensionMethod"))
					{
						break;
					}
					num = 3;
					if (!a8ETQ3OmyJhOGkx1YF0())
					{
						break;
					}
					goto IL_0215;
				}
				IL_0215:
				switch (num)
				{
				case 3:
					return uNLRtMfI0A("ExtensionMethodImageSource");
				case 5:
					goto IL_0279;
				case 1:
				case 2:
				case 4:
					goto end_IL_0023;
				}
				goto IL_0232;
				IL_0279:
				switch (c)
				{
				case 'S':
					if (text == "Structure")
					{
						return uNLRtMfI0A("StructureImageSource");
					}
					break;
				case 'N':
					if (text == "Namespace")
					{
						return uNLRtMfI0A("NamespaceImageSource");
					}
					break;
				}
				break;
				IL_0232:
				switch (c)
				{
				case 'o':
					if (text == "Module")
					{
						return uNLRtMfI0A("ModuleImageSource");
					}
					break;
				case 'e':
					if (text == "Method")
					{
						return uNLRtMfI0A("MethodImageSource");
					}
					break;
				}
				break;
				end_IL_0023:
				break;
			}
		}
		return null;
	}

	private static ImageSource uNLRtMfI0A(string string_2)
	{
		try
		{
			if (Application.Current.Resources.Contains(string_2))
			{
				return (ImageSource)Application.Current.Resources[string_2];
			}
			return null;
		}
		catch (Exception)
		{
		}
		return null;
	}

	internal static bool a8ETQ3OmyJhOGkx1YF0()
	{
		return jXe1qNOT93ehjgld08Z == null;
	}
}
