using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(crosshair.transform);
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBall();
        }
        
    }
    void SpawnBall()
    {
        var spawnBullet = Instantiate(bullet, transform.position, transform.rotation);
    }
}
