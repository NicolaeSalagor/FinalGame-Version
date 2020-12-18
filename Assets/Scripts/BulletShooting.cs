using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BulletShooting : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        GameObject bullet = GameObject.Find("bulletCollide");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("TargetTag"))
        {
            Destroy(collision.gameObject);
            Collided.hit++;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("WallTag")) 
        {
            Collided.miss++;
            Destroy(gameObject);
        }
    }
}
