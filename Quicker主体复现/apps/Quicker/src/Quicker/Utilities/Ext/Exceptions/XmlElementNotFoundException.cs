using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Quicker.Utilities.Ext.Exceptions;

public class XmlElementNotFoundException : Exception
{
	[CompilerGenerated]
	private readonly XName wtTLzJBOwqj;

	internal static XmlElementNotFoundException HdjsL7FwtAGmcrZeau2M;

	public XName Name
	{
		[CompilerGenerated]
		get
		{
			return wtTLzJBOwqj;
		}
	}

	public XmlElementNotFoundException(XName name)
		: base($"XML element [{name}] was not found.")
	{
		wtTLzJBOwqj = name;
	}

	internal static void eE5xuLFwTUJlKa67MKHi()
	{
	}

	internal static bool DPC6EeFwSWIqXGtHE1Hq()
	{
		return HdjsL7FwtAGmcrZeau2M == null;
	}
}
