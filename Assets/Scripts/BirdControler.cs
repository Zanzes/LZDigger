using UnityEngine;

public class BirdControler : MonoBehaviour
{
    public float BirdSpeed = 5;
    bool _readyForDeletion;

    void Update()
    {
        transform.position += -(transform.right * BirdSpeed) * Time.deltaTime;
        var bounds = World.MainCamera.OrthographicBounds();
        if (bounds.ToRect().Contains(gameObject.transform.position))
            _readyForDeletion = true;
        else if (_readyForDeletion)
            Destroy(gameObject);
    }
}
