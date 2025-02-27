void ProcessHandClick(Vector3 wristPosition, bool isPinching)
{
    if (!isPinching) return;

    foreach (var uiElement in UIElements)
    {
        if (CheckCollision(wristPosition, uiElement))
        {
            uiElement.OnClick();
        }
    }
}

void ProcessSwipeGesture(Vector3 wristVelocity)
{
    if (wristVelocity.magnitude > 0.2f)
    {
        UIManager.ScrollUI(wristVelocity);
    }
}
