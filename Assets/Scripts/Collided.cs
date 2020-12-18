using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collided : MonoBehaviour
{
    public AudioSource crashTarget;
    public static int hit;
    public static int miss;
    public Text HitCounter;
    public Text MissCounter;
    public int currentHit; 
    

    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        miss = 0;
        currentHit = hit;
    }

    // Update is called once per frame
    void Update()
    {
        HitCounter.text = "Hits :" + hit;
        MissCounter.text = "Misses :" + miss;
        if(currentHit != hit)
        {
            crashTarget.PlayOneShot(crashTarget.clip);
            currentHit = hit;
        }
    }
}

