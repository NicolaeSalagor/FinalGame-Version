using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFollow : MonoBehaviour
{
    public GameObject gunBulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        gunBulletSpawn = GameObject.Find("Gun_FX_Spot");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gunBulletSpawn.transform.position;
    }
}
