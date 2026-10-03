using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using MTXq0hj3nIYZv6QCZpB;

namespace Eig9SsjOuVOUIUYQlrX;

internal class Pnds5QjnQ0GJ2J2HHwg
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public IntPtr Gu8vQ8Y3dGB;

		internal static _003C_003Ec__DisplayClass4_0 TA3lKBcmC4bKBhu1YR4v;

		internal bool Ll0vQyE8aya(RfTfOkjsvn7NpwY8QHo x)
		{
			if (x == null)
			{
				return false;
			}
			return x.Handle == Gu8vQ8Y3dGB;
		}

		internal static bool FZJZujcm7F53pV6ay2AD()
		{
			return TA3lKBcmC4bKBhu1YR4v == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public IntPtr l4CvQ7le4a7;

		private static _003C_003Ec__DisplayClass5_0 zfJw63cmhKkSMoFofOs2;

		internal bool jMEvQaDKrRL(RfTfOkjsvn7NpwY8QHo x)
		{
			return x.Handle != l4CvQ7le4a7;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}

		internal static bool Umt6rTcmHGvNNILDvZCv()
		{
			return zfJw63cmhKkSMoFofOs2 == null;
		}

		internal static void qYDJEqcsVsGr8eiOIbqt()
		{
		}
	}

	public readonly IList<RfTfOkjsvn7NpwY8QHo> Items = new List<RfTfOkjsvn7NpwY8QHo>();

	public object L2XtkEY14nL = new object();

	private static readonly ILog opQtkyO1p3H;

	private static Pnds5QjnQ0GJ2J2HHwg dFHpXgQkF9D3hjRs2mlT;

	public void VpEtkCw9yBh(IntPtr intptr_0, int int_0)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.Gu8vQ8Y3dGB = intptr_0;
		lock (L2XtkEY14nL)
		{
			try
			{
				RfTfOkjsvn7NpwY8QHo rfTfOkjsvn7NpwY8QHo = Items.FirstOrDefault(_003C_003Ec__DisplayClass4_.Ll0vQyE8aya);
				if (rfTfOkjsvn7NpwY8QHo != null)
				{
					Items.Remove(rfTfOkjsvn7NpwY8QHo);
					rfTfOkjsvn7NpwY8QHo.Pid = int_0;
				}
				else
				{
					rfTfOkjsvn7NpwY8QHo = new RfTfOkjsvn7NpwY8QHo
					{
						Handle = _003C_003Ec__DisplayClass4_.Gu8vQ8Y3dGB,
						Pid = int_0
					};
				}
				Items.Insert(0, rfTfOkjsvn7NpwY8QHo);
				if (Items.Count <= 100)
				{
					return;
				}
				if (dFHpXgQkF9D3hjRs2mlT == null)
				{
					switch (0)
					{
					}
				}
				Items.RemoveAt(Items.Count - 1);
			}
			catch (Exception ex)
			{
				opQtkyO1p3H.Warn("记录窗口历史出错：" + ex.Message, ex);
			}
		}
	}

	public IntPtr Tn4tkP4TX97(IntPtr intptr_0)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.l4CvQ7le4a7 = intptr_0;
		return Items.FirstOrDefault(_003C_003Ec__DisplayClass5_.jMEvQaDKrRL)?.Handle ?? IntPtr.Zero;
	}

	static Pnds5QjnQ0GJ2J2HHwg()
	{
		opQtkyO1p3H = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool XtGZOiQkcnx8W3FKiA3R()
	{
		return dFHpXgQkF9D3hjRs2mlT == null;
	}
}
