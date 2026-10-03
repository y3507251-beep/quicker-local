namespace Quicker.Domain.Actions.X.BuiltinRunners;

public delegate void ProgressChangedHandler(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage);
