namespace AudiobookPlanner.API.Common
{
  public class Result<T>
  {
    public bool Success { get; }
    public T? Value { get; }
    public string? Error { get; }
    public string? ErrorType { get; }
    public int? Count { get; }

    private Result(bool success, T? value, string? error, string? errorType, int? count)
    {
      Success = success;
      Value = value;
      Error = error;
      ErrorType = errorType;
      Count = count;
    }

    public static Result<T> Ok(T value, int? count = null) =>
      new Result<T>(true, value, null, null, count);

    public static Result<T> Fail(string error, string errorType = "General") =>
      new Result<T>(false, default, error, errorType, null);

    public static Result<T> NotFound(string message = "Not found") =>
      new Result<T>(false, default, message, "NotFound", null);

    public static Result<T> Validation(string message) =>
      new Result<T>(false, default, message, "Validation", null);

    public static Result<T> Conflict(string message) =>
      new Result<T>(false, default, message, "Conflict", null);
  }
}
