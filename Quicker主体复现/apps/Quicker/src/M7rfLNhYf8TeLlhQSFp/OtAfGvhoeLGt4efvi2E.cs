using System;
using System.Reflection;
using t8SGKhhgLWTgeqjGcrq;

namespace M7rfLNhYf8TeLlhQSFp;

internal class OtAfGvhoeLGt4efvi2E
{
	internal delegate void ugjKIxhMkejnxZK2CqV(object o);

	internal static Module mox29kMXohn;

	private static OtAfGvhoeLGt4efvi2E ovr9XOyiUwlDpjmBecHx;

	internal static void KmuSnsTT3qKlY(int typemdt)
	{
		int num = 1;
		while (true)
		{
			Type type = mox29kMXohn.ResolveType(33554432 + typemdt);
			int num2 = 0;
			if (!FM71cByixhkoVcLGRjBK())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)mox29kMXohn.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
			return;
		}
	}

	static OtAfGvhoeLGt4efvi2E()
	{
		mox29kMXohn = typeof(global::M7rfLNhYf8TeLlhQSFp.OtAfGvhoeLGt4efvi2E).Assembly.ManifestModule;
	}

	internal static bool FM71cByixhkoVcLGRjBK()
	{
		return ovr9XOyiUwlDpjmBecHx == null;
	}
}
