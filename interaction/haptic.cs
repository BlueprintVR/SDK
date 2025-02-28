public class DynamicHapticFeedback
{
    public void TriggerFeedback(float intensity, float duration)
    {
        intensity = Mathf.Clamp01(intensity);
        duration = Mathf.Clamp(duration, 0.05f, 1.0f); // Prevent too weak/long signals

        VRControllerBracelet.TriggerVibration(intensity, duration);
    }

    public void OnButtonPress()
    {
        TriggerFeedback(0.8f, 0.2f); // Stronger vibration for button press
    }

    public void OnHover()
    {
        TriggerFeedback(0.3f, 0.1f); // Lighter vibration for hover effect
    }

    public void OnError()
    {
        TriggerFeedback(1.0f, 0.5f); // Strong, long vibration for error feedback
    }
}
