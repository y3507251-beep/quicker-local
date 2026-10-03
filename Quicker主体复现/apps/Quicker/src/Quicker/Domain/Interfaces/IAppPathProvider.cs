namespace Quicker.Domain.Interfaces;

public interface IAppPathProvider
{
	string GetBasePath();

	string GetDataSubFolder();
}
