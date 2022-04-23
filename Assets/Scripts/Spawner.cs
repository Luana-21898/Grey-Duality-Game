using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] correct;
    public GameObject[] wrong;

    public float xBounds,
        yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomCorrect = Random.Range(0, correct.Length);
        int randomWrong = Random.Range(0, wrong.Length);

        if (Random.value <= .3f)
            Instantiate(
                correct[randomCorrect],
                new Vector2(Random.Range(-xBounds, xBounds), yBound),
                Quaternion.identity
            );
        else
            Instantiate(
                wrong[randomWrong],
                new Vector2(Random.Range(-xBounds, xBounds), yBound),
                Quaternion.identity
            );

        StartCoroutine(SpawnRandomGameObject());
    }
}
