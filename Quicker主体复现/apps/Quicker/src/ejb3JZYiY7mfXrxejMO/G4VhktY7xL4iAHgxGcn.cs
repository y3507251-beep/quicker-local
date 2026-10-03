using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSScriptLibrary;
using Quicker.Public.Extensions;

namespace ejb3JZYiY7mfXrxejMO;

internal static class G4VhktY7xL4iAHgxGcn
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
	private interface Ltckt9uL8jbmWTPScA0
	{
		void Pn9Mr1yhYlm();

		[PreserveSig]
		int qYKMr9pfZWp(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, ref xWXV8yupXS9dRcTjhpK xWXV8yupXS9dRcTjhpK_0);
	}

	private struct xWXV8yupXS9dRcTjhpK
	{
		public int yQVS49gw2BH;

		public int wRPS4h6yxM8;

		public long FH0S4eElFpE;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string kpdS4YkFdwM;

		public int wH0S4IrKKCX;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public string tbiS4Gpf7C7;

		internal static _003C_003Ec__DisplayClass0_0 bZ1FiDWSEurNPjdpQMHg;

		internal bool kKbS4W7cegl(Assembly x)
		{
			return string.Equals(tbiS4Gpf7C7, x.GetName().Name + ".dll", StringComparison.OrdinalIgnoreCase);
		}

		internal bool ndrS4kH2PAg(Assembly x)
		{
			return string.Equals(tbiS4Gpf7C7, x.GetName().Name, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool yKWi0pWSGEvoGGJmEHrZ()
		{
			return bZ1FiDWSEurNPjdpQMHg == null;
		}
	}

	private static object FDRkNaF3JMhIQ72xdLKQ;

	public static Assembly LC0L0NdjaV4(string string_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7 = string_0;
		int num = 0;
		if (!u7kdHLF3kAs5ofn8fKm9())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			Assembly assembly = null;
			try
			{
				if (Path.IsPathRooted(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7) && File.Exists(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7))
				{
					assembly = Assembly.LoadFrom(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7);
					if (assembly != null)
					{
						return assembly;
					}
				}
			}
			catch (Exception)
			{
			}
			if (_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					assembly = Assembly.LoadWithPartialName(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7);
					if (assembly != null)
					{
						return assembly;
					}
				}
				catch
				{
				}
				assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(_003C_003Ec__DisplayClass0_.kKbS4W7cegl);
				if (assembly != null)
				{
					return assembly;
				}
			}
			Type type = Type.GetType(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7);
			if (type != null)
			{
				return type.Assembly;
			}
			assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(_003C_003Ec__DisplayClass0_.ndrS4kH2PAg);
			if (assembly != null)
			{
				return assembly;
			}
			string[] array = AssemblyResolver.FindGlobalAssembly(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7);
			if (array.HasData())
			{
				return Assembly.LoadFrom(array[0]);
			}
			return Assembly.Load(_003C_003Ec__DisplayClass0_.tbiS4Gpf7C7);
		}
		}
	}

	public static string N9kL0JxUF9T(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("name");
		}
		xWXV8yupXS9dRcTjhpK xWXV8yupXS9dRcTjhpK_ = default(xWXV8yupXS9dRcTjhpK);
		xWXV8yupXS9dRcTjhpK_.wH0S4IrKKCX = 1024;
		xWXV8yupXS9dRcTjhpK_.kpdS4YkFdwM = new string('\0', xWXV8yupXS9dRcTjhpK_.wH0S4IrKKCX);
		if (GJ3L00a5sKv(out var ltckt9uL8jbmWTPScA0_, 0) >= 0 && ltckt9uL8jbmWTPScA0_.qYKMr9pfZWp(0, string_0, ref xWXV8yupXS9dRcTjhpK_) < 0)
		{
			return null;
		}
		return xWXV8yupXS9dRcTjhpK_.kpdS4YkFdwM;
	}

	[DllImport("fusion.dll", EntryPoint = "CreateAssemblyCache")]
	private static extern int GJ3L00a5sKv(out Ltckt9uL8jbmWTPScA0 ltckt9uL8jbmWTPScA0_0, int int_0);

	internal static bool u7kdHLF3kAs5ofn8fKm9()
	{
		return FDRkNaF3JMhIQ72xdLKQ == null;
	}
}
