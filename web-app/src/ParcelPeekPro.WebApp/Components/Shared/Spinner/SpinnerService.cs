namespace ParcelPeekPro.WebApp.Components.Shared.Spinner;

public class SpinnerService
{
    public event Action<bool> OnShow;
    
    public void ShowSpinner(bool show)
    {
        OnShow?.Invoke(show);
    }
}
