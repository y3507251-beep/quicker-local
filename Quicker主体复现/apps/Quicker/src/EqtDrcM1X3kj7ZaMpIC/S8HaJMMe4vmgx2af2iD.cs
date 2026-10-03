using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EqtDrcM1X3kj7ZaMpIC;

internal class S8HaJMMe4vmgx2af2iD
{
	private readonly IDictionary<MouseButtons, bool> dV7LONaqX94 = new Dictionary<MouseButtons, bool>
	{
		{
			MouseButtons.None,
			false
		},
		{
			MouseButtons.Left,
			false
		},
		{
			MouseButtons.Middle,
			false
		},
		{
			MouseButtons.Right,
			false
		},
		{
			MouseButtons.XButton1,
			false
		},
		{
			MouseButtons.XButton2,
			false
		}
	};

	private static S8HaJMMe4vmgx2af2iD r4agm7Fg6bHuBZJgeXXt;

	internal void zCdLO2yDgGC(MouseButtons mouseButtons_0, bool bool_0)
	{
		dV7LONaqX94[mouseButtons_0] = bool_0;
	}

	internal bool y5DLOusfFai(MouseButtons mouseButtons_0)
	{
		return dV7LONaqX94[mouseButtons_0];
	}

	internal void Reset()
	{
		foreach (MouseButtons item in dV7LONaqX94.Keys.ToList())
		{
			dV7LONaqX94[item] = false;
		}
	}

	internal static bool iJCcUSFgtdumuTLlShgs()
	{
		return r4agm7Fg6bHuBZJgeXXt == null;
	}
}
