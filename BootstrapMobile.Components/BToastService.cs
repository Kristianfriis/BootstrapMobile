using System.Timers;

namespace BootstrapMobile.Components;

public class BToastService : IDisposable
{
    public event Action<string, ToastLevel>? OnShow;
    public event Action? OnHide;
    private System.Timers.Timer? Countdown;

    public void ShowToast(string message, ToastLevel level, double duration = 5000)
    {
        OnShow?.Invoke(message, level);
        StartCountdown(duration);
    }

    private void StartCountdown(double duration)
    {
        SetCountdown(duration);

        if (Countdown!.Enabled)
        {
            Countdown.Stop();
            Countdown.Start();
        }
        else
        {
            Countdown!.Start();
        }
    }

    private void SetCountdown(double duration)
    {
        if (Countdown != null) return;

        Countdown = new System.Timers.Timer(duration);
        Countdown.Elapsed += HideToast;
        Countdown.AutoReset = false;
    }

    private void HideToast(object? source, ElapsedEventArgs args)
        => OnHide?.Invoke();

    public void Dispose()
        => Countdown?.Dispose();
}
