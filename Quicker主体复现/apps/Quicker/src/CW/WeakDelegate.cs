using System;
using System.Reflection;

namespace CW;

public class WeakDelegate
{
	private WeakReference OMF0rWAohJ;

	private MethodInfo bJB0pfpNIU;

	private Type F5R0BpG5sX;

	private static WeakDelegate uhDiulEkgLj0dcmuIBD;

	public Delegate Delegate
	{
		get
		{
			if (OMF0rWAohJ != null)
			{
				if (OMF0rWAohJ.Target != null)
				{
					return bJB0pfpNIU.CreateDelegate(F5R0BpG5sX, OMF0rWAohJ.Target);
				}
				return null;
			}
			return bJB0pfpNIU.CreateDelegate(F5R0BpG5sX);
		}
	}

	public bool IsAlive
	{
		get
		{
			if (OMF0rWAohJ != null)
			{
				return OMF0rWAohJ.IsAlive;
			}
			return true;
		}
	}

	public Type DelegateType => F5R0BpG5sX;

	public WeakReference Target => OMF0rWAohJ;

	public MethodInfo Method => bJB0pfpNIU;

	public WeakDelegate(Delegate handler)
	{
		OMF0rWAohJ = ((handler.Target != null) ? new WeakReference(handler.Target) : null);
		bJB0pfpNIU = handler.GetMethodInfo();
		F5R0BpG5sX = handler.GetType();
	}

	internal static bool Ct1e7rEamUC7SdKgeAj()
	{
		return uhDiulEkgLj0dcmuIBD == null;
	}
}
