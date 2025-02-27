public class HapticFeedback
{
    // Trigger a short vibration for button press
    public void TriggerButtonPressFeedback()
    {
        // Example API call to send vibration signal
        VRControllerBracelet.TriggerVibration(0.5f, 0.2f); // 0.5 amplitude, 0.2 duration
    }

    // Trigger a stronger vibration when hovering over an interactive UI element
    public void TriggerHoverFeedback()
    {
        VRControllerBracelet.TriggerVibration(1.0f, 0.5f); // 1.0 amplitude, 0.5 duration
    }
}
