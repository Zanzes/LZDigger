using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControler : MonoBehaviour
{
    public bool IsMainCamera = false;
    bool _drawBounds = false;

    public bool DrawBounds
    {
        get { return _drawBounds; }
        set
        {
            _drawBounds = value;
            if (_drawBounds)
                DrawCameraBounds();
            
        }
    }
    
    void Start () {
        if (IsMainCamera || CompareTag("MainCamera"))
            World.MainCamera = gameObject.GetComponent<Camera>();
    }

    void DrawCameraBounds()
    {
        var bounds = World.MainCamera.OrthographicBounds();
        var xa = bounds.max;
        var yb = bounds.min;
        var xb = new Vector3(yb.x, xa.y);
        var ya = new Vector3(xa.x, yb.y);
        Debug.DrawLine(xa, xb, Color.magenta);
        Debug.DrawLine(ya, yb, Color.magenta);
        Debug.DrawLine(xa, ya, Color.magenta);
        Debug.DrawLine(xb, yb, Color.magenta);
    }
}
