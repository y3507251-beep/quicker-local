using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CW;

public class WeakMulticastDelegate
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public Delegate h7IvyXHRb0F;

		internal static _003C_003Ec__DisplayClass5_0 svM2fMcERc5NPxBxrgkS;

		internal bool UZ2vy6mTC7J(WeakDelegate wd)
		{
			Delegate obj = wd.Delegate;
			if (wd.IsAlive)
			{
				return obj?.Equals(h7IvyXHRb0F) ?? false;
			}
			return true;
		}

		internal static bool q7yswTcEgp1CWwkN55uJ()
		{
			return svM2fMcERc5NPxBxrgkS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public WeakDelegate cXjvyKC14mn;

		internal static _003C_003Ec__DisplayClass6_0 FCgJ4VcEMmJXYv1Yrjwo;

		internal bool K6HvymY6KoR(WeakDelegate wd)
		{
			if (wd.IsAlive)
			{
				return wd.Equals(cXjvyKC14mn);
			}
			return true;
		}

		internal static bool hVrIAdcEU2vKdcA1v0Sv()
		{
			return FCgJ4VcEMmJXYv1Yrjwo == null;
		}
	}

	private LinkedList<WeakDelegate> VKx04EPtHT;

	internal static WeakMulticastDelegate wx4WEPE9O3IBDCdUBjP;

	[SpecialName]
	private LinkedList<WeakDelegate> Xno0jZfWy1()
	{
		return VKx04EPtHT ?? (VKx04EPtHT = new LinkedList<WeakDelegate>());
	}

	public void Add(Delegate handler)
	{
		Xno0jZfWy1().AddLast(new WeakDelegate(handler));
	}

	public void Add(WeakDelegate handler)
	{
		Xno0jZfWy1().AddLast(handler);
	}

	public void Remove(Delegate handler)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.h7IvyXHRb0F = handler;
		OMg0QeEMbc(_003C_003Ec__DisplayClass5_.UZ2vy6mTC7J);
	}

	public void Remove(WeakDelegate handler)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.cXjvyKC14mn = handler;
		OMg0QeEMbc(_003C_003Ec__DisplayClass6_.K6HvymY6KoR);
	}

	public void Invoke()
	{
		Invoke(null);
	}

	public void Invoke(params object[] args)
	{
		LinkedListNode<WeakDelegate> linkedListNode = Xno0jZfWy1().First;
		while (linkedListNode != null)
		{
			LinkedListNode<WeakDelegate> next = linkedListNode.Next;
			Delegate obj = linkedListNode.Value.Delegate;
			if ((object)obj != null)
			{
				obj.DynamicInvoke(args);
			}
			else
			{
				Xno0jZfWy1().Remove(linkedListNode);
			}
			linkedListNode = next;
		}
	}

	private void OMg0QeEMbc(Predicate<WeakDelegate> predicate_0)
	{
		LinkedListNode<WeakDelegate> linkedListNode = Xno0jZfWy1().First;
		while (linkedListNode != null)
		{
			LinkedListNode<WeakDelegate> next = linkedListNode.Next;
			if (predicate_0(linkedListNode.Value))
			{
				Xno0jZfWy1().Remove(linkedListNode);
			}
			linkedListNode = next;
		}
	}

	internal static bool jWUeDpELQ1xNyiG6AMl()
	{
		return wx4WEPE9O3IBDCdUBjP == null;
	}
}
