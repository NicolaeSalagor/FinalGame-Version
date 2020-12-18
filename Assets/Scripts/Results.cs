using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public static int hitResult;
    public static int missResult;
    public Text hitResultCounter;
    public Text missResultCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hitResultCounter.text = "Hits : " + Collided.hit;
        missResultCounter.text = "Misses : " + Collided.miss;
        Cursor.visible = true;
    }
}
