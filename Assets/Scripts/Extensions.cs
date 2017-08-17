using UnityEngine;

public static class Extensions
{
    public static Bounds OrthographicBounds(this Camera camera)
    {
        var screenAspect = (float)Screen.width / (float)Screen.height;
        var cameraHeight = camera.orthographicSize * 2;
        var bounds = new Bounds(
            camera.transform.position,
            new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
        return bounds;
    }

    public static Rect ToRect(this Bounds bounds)
    {
        return new Rect(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.extents.x * 2, bounds.extents.y * 2);
    }
}
