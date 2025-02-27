void ProcessHandHover(Vector3 wristPosition)
{
    foreach (var uiElement in UIElements)
    {
        if (CheckCollision(wristPosition, uiElement))
        {
            uiElement.OnHover();
        }
    }
}
