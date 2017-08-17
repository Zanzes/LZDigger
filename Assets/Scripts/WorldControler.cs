using UnityEngine;
using Random = System.Random;

public class WorldControler : MonoBehaviour
{
    public int WorldWidth = 60;
    public int WorldHeight = 60;
    public GameObject[] Materials;

    readonly Random _random = new Random();

    void Start()
    {
        var xOffset = WorldWidth / 2;
        for (var y = 0; y < WorldHeight; y++)
            for (var x = 0; x < WorldWidth; x++)
                Instantiate(Materials[World.Random.Next(0, Materials.Length)], new Vector3(x - xOffset, -y),
                    Quaternion.identity);
    }
}