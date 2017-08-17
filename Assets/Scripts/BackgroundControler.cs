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
        yield return new WaitForSeconds(2);

        var birdPosition = new Vector3(World.MainCamera.OrthographicBounds().max.x + 2, World.MainCamera.transform.position.y);
        Instantiate(Bird, birdPosition, Quaternion.identity);
        StartCoroutine(BirdSpawner());
    }

}
