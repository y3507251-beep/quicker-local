internal static class _003CPrivateImplementationDetails_003E
{
	internal static uint ComputeStringHash(string text)
	{
		if (text == null)
		{
			return 0;
		}
		uint hash = 2166136261u;
		foreach (char character in text)
		{
			hash = unchecked((hash ^ character) * 16777619u);
		}
		return hash;
	}
}
