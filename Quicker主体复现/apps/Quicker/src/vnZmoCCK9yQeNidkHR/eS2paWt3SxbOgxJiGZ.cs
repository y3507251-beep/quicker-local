using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;

namespace vnZmoCCK9yQeNidkHR;

internal sealed class eS2paWt3SxbOgxJiGZ<I1LOyYxBJpVi2NGjEV> : DependencyObject
{
	private static readonly DependencyProperty gp4JmwRtvi;

	internal static object GW1eoj3kIJOeK4ik8hv;

	public I1LOyYxBJpVi2NGjEV Value
	{
		get
		{
			return (I1LOyYxBJpVi2NGjEV)GetValue(k8GJ1oO82r());
		}
		set
		{
			SetValue(k8GJ1oO82r(), value);
		}
	}

	[SpecialName]
	public static DependencyProperty k8GJ1oO82r()
	{
		return gp4JmwRtvi;
	}

	public void S50Js9WBgq(Binding binding_0)
	{
		BindingOperations.SetBinding(this, k8GJ1oO82r(), binding_0);
	}

	public void NqcJHDRfba(object object_0, string string_0)
	{
		S50Js9WBgq(new Binding(string_0)
		{
			Source = object_0
		});
	}

	static eS2paWt3SxbOgxJiGZ()
	{
		gp4JmwRtvi = DependencyProperty.Register("Value", typeof(I1LOyYxBJpVi2NGjEV), typeof(eS2paWt3SxbOgxJiGZ<I1LOyYxBJpVi2NGjEV>));
	}

	internal static bool ujFYJv3ajTrGGoPlgRL()
	{
		return GW1eoj3kIJOeK4ik8hv == null;
	}
}
