using System.Linq;
using UnityEngine;
using Random = System.Random;

public static class World
{
    static readonly Random IntRandom = new Random();
    static readonly Random FloatRandom = new Random();
    static Camera _mainCamera = Object.FindObjectsOfType<Camera>().Single(x => x.GetComponent<CameraControler>().IsMainCamera);

    public static Random Random
    {
        get
        {
            return IntRandom;
        }
    }
    public static Random RandomF
    {
        get
        {
            return FloatRandom;
        }
    }
    public static Camera MainCamera
    {
        get
        {
            if (_mainCamera != null)
                return _mainCamera;
            return _mainCamera = Camera.main ?? Camera.current;
        }
        set
        {
            _mainCamera = value;
        }
    }

}