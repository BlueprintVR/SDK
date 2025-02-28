public class AdaptiveGestureSmoothing
{
    private float alphaMin = 0.05f; // More smoothing for slow movements
    private float alphaMax = 0.3f;  // Less smoothing for fast movements
    private float speedThreshold = 1.0f; // Adjust based on testing

    private Vector3 previousPosition;

    public Vector3 SmoothPosition(Vector3 newPosition, float deltaTime)
    {
        float speed = (newPosition - previousPosition).magnitude / deltaTime;
        float alpha = Mathf.Lerp(alphaMin, alphaMax, Mathf.Clamp01(speed / speedThreshold));

        previousPosition = Vector3.Lerp(previousPosition, newPosition, alpha);
        return previousPosition;
    }
}
