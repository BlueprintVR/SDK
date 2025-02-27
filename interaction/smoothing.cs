public class GestureSmoothing
{
    private float alpha = 0.1f; // Adjust for more/less smoothing
    private Vector3 previousPosition;
    
    public Vector3 SmoothPosition(Vector3 newPosition)
    {
        previousPosition.x = alpha * newPosition.x + (1 - alpha) * previousPosition.x;
        previousPosition.y = alpha * newPosition.y + (1 - alpha) * previousPosition.y;
        previousPosition.z = alpha * newPosition.z + (1 - alpha) * previousPosition.z;
        
        return previousPosition;
    }
}
