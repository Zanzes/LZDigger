using System.Collections;
using UnityEngine;

public class BackgroundControler : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Cloud;

    void Start()
    {
        StartCoroutine(LateStart());
    }

    IEnumerator LateStart()
    {
        yield return new WaitForSeconds(.5f);
        StartCoroutine(BirdSpawner());
    }

    IEnumerator BirdSpawner()
    {

        var birdPosition = new Vector3(World.MainCamera.OrthographicBounds().max.x + 2, World.MainCamera.transform.position.y + World.RandomF.Next(0,15));
        Instantiate(Bird, birdPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
        StartCoroutine(BirdSpawner());
    }

}
