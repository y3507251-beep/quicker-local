using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class ApiResult<T>
{
	public bool IsSuccess { get; set; }

	public int ErrorCode { get; set; }

	public string Message { get; set; }

	public Dictionary<string, string[]> Errors { get; set; }

	public T Data { get; set; }

	public static ApiResult<T> Error(string message, int errorCode = 0)
	{
		return new ApiResult<T>
		{
			IsSuccess = false,
			ErrorCode = errorCode,
			Message = message
		};
	}

	public static ApiResult<T> Success()
	{
		return new ApiResult<T>
		{
			IsSuccess = true,
			ErrorCode = 0,
			Message = ""
		};
	}

	public static ApiResult<T> Success(T data, string message = "")
	{
		return new ApiResult<T>
		{
			IsSuccess = true,
			Data = data
		};
	}
}
public class ApiResult : ApiResult<string>
{
}
