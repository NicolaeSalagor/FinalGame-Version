using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHopperController : MonoBehaviour
{
    public GameObject Target;
    public float spawnTime = 3f;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnBall", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnBall()
    {
        Vector3 position = new Vector3(Random.Range(-6, 5), Random.Range(0.5f, 4.5f), 13.853f);
        var newBall = GameObject.Instantiate(Target, position, transform.rotation);
    }
}
