namespace Quicker.Common.Vm;

public static class ApiResultHelper
{
	public static ApiResult<T> ToApiResult<T>(this T data)
	{
		return ApiResult<T>.Success(data);
	}
}
