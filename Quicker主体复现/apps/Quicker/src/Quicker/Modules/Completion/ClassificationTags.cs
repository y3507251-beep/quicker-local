using System;

namespace Quicker.Modules.Completion;

public static class ClassificationTags
{
	internal static object IlclymQVe7kdSJsJ1XDH;

	public static string GetClassificationTypeName(string textTag)
	{
		if (textTag != null)
		{
			string result = default(string);
			char c;
			switch (textTag.Length)
			{
			case 4:
				c = textTag[0];
				if (c != 'E')
				{
					if (c != 'T' || !(textTag == "Text"))
					{
						break;
					}
					goto IL_048b;
				}
				if (!(textTag == "Enum"))
				{
					break;
				}
				result = "enum name";
				goto IL_0491;
			case 5:
				c = textTag[0];
				while (true)
				{
					switch (c)
					{
					case 'C':
						break;
					case 'A':
						goto IL_0121;
					default:
						goto IL_016e;
					case 'E':
						goto IL_01b9;
					case 'F':
						goto IL_01ce;
					case 'B':
					case 'D':
						goto end_IL_0010;
					}
					if (!(textTag == "Class"))
					{
						goto end_IL_0010;
					}
					result = "class name";
					int num = 9;
					if (IlclymQVe7kdSJsJ1XDH != null)
					{
						goto IL_00df;
					}
					goto IL_0491;
					IL_01ce:
					if (textTag == "Field")
					{
						break;
					}
					goto end_IL_0010;
					IL_0121:
					if (textTag == "Alias")
					{
						break;
					}
					num = 0;
					if (IlclymQVe7kdSJsJ1XDH != null)
					{
						goto end_IL_0010;
					}
					goto IL_00df;
					IL_016e:
					if (c != 'L')
					{
						goto IL_019a;
					}
					if (!(textTag == "Label") && !(textTag == "Local"))
					{
						goto end_IL_0010;
					}
					break;
					IL_00df:
					switch (num)
					{
					case 12:
						break;
					case 5:
						goto IL_016e;
					case 8:
						goto IL_019a;
					case 11:
						goto IL_01b9;
					case 2:
						goto IL_022a;
					case 10:
						goto IL_025a;
					case 13:
						goto IL_038c;
					case 1:
						goto IL_03c9;
					case 4:
						goto IL_03e4;
					default:
						goto end_IL_0010;
					case 9:
						goto IL_0491;
					}
					continue;
					IL_01b9:
					if (textTag == "Event")
					{
						break;
					}
					goto end_IL_0010;
				}
				goto IL_041b;
			case 6:
				c = textTag[1];
				if (c != 'e')
				{
					if (c != 'o')
					{
						if (c != 't' || !(textTag == "Struct"))
						{
							break;
						}
						result = "struct name";
						goto IL_0491;
					}
					if (!(textTag == "Module"))
					{
						break;
					}
					goto IL_022a;
				}
				if (!(textTag == "Method"))
				{
					break;
				}
				goto IL_041b;
			case 7:
				if (!(textTag == "Keyword"))
				{
					break;
				}
				goto IL_025a;
			case 8:
				switch (textTag[0])
				{
				case 'P':
					break;
				case 'O':
					goto IL_02aa;
				case 'A':
					goto IL_02c5;
				case 'C':
					goto IL_02da;
				case 'D':
					goto IL_02f5;
				default:
					goto end_IL_0010;
				}
				if (!(textTag == "Property"))
				{
					break;
				}
				goto IL_041b;
			case 9:
				switch (textTag[0])
				{
				case 'L':
					break;
				case 'N':
					goto IL_0362;
				case 'P':
					goto IL_0377;
				case 'I':
					goto IL_038c;
				case 'E':
					goto IL_03a7;
				default:
					goto end_IL_0010;
				}
				if (!(textTag == "LineBreak"))
				{
					break;
				}
				goto IL_0357;
			case 10:
				if (!(textTag == "EnumMember"))
				{
					break;
				}
				goto IL_03c9;
			case 11:
				if (!(textTag == "Punctuation"))
				{
					break;
				}
				goto IL_03e4;
			case 13:
				switch (textTag[0])
				{
				case 'R':
					break;
				case 'S':
					goto IL_0423;
				case 'T':
					goto IL_0438;
				default:
					goto end_IL_0010;
				}
				if (!(textTag == "RangeVariable"))
				{
					break;
				}
				goto IL_041b;
			case 14:
				if (!(textTag == "NumericLiteral"))
				{
					break;
				}
				result = "number";
				goto IL_0491;
			case 15:
				if (!(textTag == "ExtensionMethod"))
				{
					break;
				}
				result = "extension method name";
				goto IL_0491;
			case 22:
				{
					if (!(textTag == "AnonymousTypeIndicator"))
					{
						break;
					}
					goto IL_048b;
				}
				IL_0357:
				result = "whitespace";
				goto IL_0491;
				IL_041b:
				result = "identifier";
				goto IL_0491;
				IL_0438:
				if (!(textTag == "TypeParameter"))
				{
					break;
				}
				result = "type parameter name";
				goto IL_0491;
				IL_022a:
				result = "module name";
				goto IL_0491;
				IL_0423:
				if (!(textTag == "StringLiteral"))
				{
					break;
				}
				result = "string";
				goto IL_0491;
				IL_048b:
				result = "text";
				goto IL_0491;
				IL_03a7:
				if (!(textTag == "ErrorType"))
				{
					break;
				}
				goto IL_041b;
				IL_0377:
				if (!(textTag == "Parameter"))
				{
					break;
				}
				goto IL_041b;
				IL_0362:
				if (!(textTag == "Namespace"))
				{
					break;
				}
				goto IL_041b;
				IL_02f5:
				if (!(textTag == "Delegate"))
				{
					break;
				}
				result = "delegate name";
				goto IL_0491;
				IL_03c9:
				result = "enum member name";
				goto IL_0491;
				IL_02da:
				if (!(textTag == "Constant"))
				{
					break;
				}
				result = "constant name";
				goto IL_0491;
				IL_038c:
				if (!(textTag == "Interface"))
				{
					break;
				}
				result = "interface name";
				goto IL_0491;
				IL_02c5:
				if (!(textTag == "Assembly"))
				{
					break;
				}
				goto IL_041b;
				IL_02aa:
				if (!(textTag == "Operator"))
				{
					break;
				}
				result = "operator";
				goto IL_0491;
				IL_0491:
				return result;
				IL_03e4:
				result = "punctuation";
				goto IL_0491;
				IL_025a:
				result = "keyword";
				goto IL_0491;
				IL_019a:
				if (c != 'S' || !(textTag == "Space"))
				{
					break;
				}
				goto IL_0357;
				end_IL_0010:
				break;
			}
		}
		throw new NotSupportedException(textTag);
	}

	internal static bool AQ1WSWQVjwCvW6sGLIPJ()
	{
		return IlclymQVe7kdSJsJ1XDH == null;
	}
}
