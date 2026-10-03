namespace Quicker.Domain.Interfaces;

public interface IView
{
	void UpdateGlobalButtons();

	void UpdateProfileButtons();

	void UpdateButton(int buttonIndex);
}
